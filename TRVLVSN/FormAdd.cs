using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRVLVSN
{
	public partial class FormAdd : Form
	{
		private List<Trip> trips;
		private string FilePath = @"trips.json";

		public FormAdd()
		{
			InitializeComponent();
			InitializeListView();
			trips = new List<Trip>();
			if (File.Exists(FilePath) && new FileInfo(FilePath).Length > 0)
			{
				trips = JsonHelper.LoadFromFile<Trip>(FilePath);
				DisplayTrips();
			}
		}

		private async void buttonAdd_Click(object sender, EventArgs e)
		{
			DateTime today = DateTime.Today;
			bool datesValid = dateTimePickerStartTrip.Value <= dateTimePickerEndTrip.Value &&
			                  dateTimePickerArriveDate.Value < dateTimePickerEndTrip.Value &&
			                  dateTimePickerDpartureDate.Value < dateTimePickerEndTrip.Value &&
			                  dateTimePickerStartTrip.Value >= today &&
			                  dateTimePickerEndTrip.Value >= today &&
			                  dateTimePickerArriveDate.Value >= today &&
			                  dateTimePickerDpartureDate.Value >= today;

			if (!datesValid)
			{
				MessageBox.Show("Assicurati che le date siano inserite correttamente.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			var coordinates = await GeocodingHelper.GetCoordinatesAsync(textBoxDestinationName.Text);
			if (!coordinates.HasValue)
			{
				MessageBox.Show("Impossibile ricavare le coordinate della destinazione.", "Errore di Geolocalizzazione", MessageBoxButtons.OK, MessageBoxIcon.Error);
				textBoxDestinationName.Text = string.Empty;
				return;
			}

			Trip trip = new Trip
			{
				TripName = textBoxTripName.Text,
				StartDate = dateTimePickerStartTrip.Value,
				EndDate = dateTimePickerEndTrip.Value
			};

			Destination destination = new Destination
			{
				Name = textBoxDestinationName.Text,
				ArrivalDate = dateTimePickerArriveDate.Value,
				DepartureDate = dateTimePickerDpartureDate.Value,
				Activities = new List<string>(textBoxAddActivity.Text.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)),
				Latitude = coordinates.Value.Latitude,
				Longitude = coordinates.Value.Longitude
			};

			trip.AddDestination(destination);

			trips.Add(trip);
			ClearUI();
			DisplayTrips();
			JsonHelper.SaveToFile(FilePath, trips);
		}

		private void buttonImportTrips_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
				Title = "Seleziona un file JSON da importare."
			};

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string importFilePath = openFileDialog.FileName;
				List<Trip> importedTrips = JsonHelper.LoadFromFile<Trip>(importFilePath);

				if (importedTrips != null)
				{
					trips.AddRange(importedTrips);
					DisplayTrips();
					JsonHelper.SaveToFile(FilePath, trips);
				}
				else
				{
					MessageBox.Show("Errore: Impossibile importare dati dal file selezionato.", "Errore durante la fase di importazione", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void buttonExport_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog
			{
				Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
				Title = "Esporta i viaggi in un file JSON"
			};

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				string exportFilePath = saveFileDialog.FileName;
				try
				{
					File.Copy(FilePath, exportFilePath, true);
					MessageBox.Show("File esportato correttamente.", "Esportazione andata a buon fine", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Errore: {ex.Message}", "Errore durante la fase di esportazione", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void InitializeListView()
		{
			listViewAddedTrips.View = View.Details;
			listViewAddedTrips.Columns.Add("Nome Viaggio", 100, HorizontalAlignment.Left);
			listViewAddedTrips.Columns.Add("Data Inizio", 100, HorizontalAlignment.Left);
			listViewAddedTrips.Columns.Add("Data Fine", 100, HorizontalAlignment.Left);
			listViewAddedTrips.Columns.Add("Nome Destinazione", 100, HorizontalAlignment.Left);
			listViewAddedTrips.Columns.Add("Data di partenza", 100, HorizontalAlignment.Left);
			listViewAddedTrips.Columns.Add("Data di arrivo", 100, HorizontalAlignment.Left);
			listViewAddedTrips.Columns.Add("Attività", 200, HorizontalAlignment.Left);
		}

		private void DisplayTrips()
		{
			listViewAddedTrips.Items.Clear();
			DateTime today = DateTime.Today;

			var futureTrips = trips.Where(trip => trip.EndDate >= today).ToList();

			foreach (var trip in futureTrips)
			{
				foreach (var destination in trip.Destinations)
				{
					ListViewItem item = new ListViewItem(trip.TripName);
					item.SubItems.Add(trip.StartDate.ToString("dd/MM/yyyy"));
					item.SubItems.Add(trip.EndDate.ToString("dd/MM/yyyy"));
					item.SubItems.Add(destination.Name);
					item.SubItems.Add(destination.DepartureDate.ToString("dd/MM/yyyy"));
					item.SubItems.Add(destination.ArrivalDate.ToString("dd/MM/yyyy"));
					item.SubItems.Add(string.Join("; ", destination.Activities));

					listViewAddedTrips.Items.Add(item);
				}
			}
		}

		private void ClearUI()
		{
			textBoxTripName.Text = string.Empty;
			dateTimePickerStartTrip.Value = DateTime.Now;
			dateTimePickerEndTrip.Value = DateTime.Now;
			textBoxDestinationName.Text = string.Empty;
			dateTimePickerArriveDate.Value = DateTime.Now;
			dateTimePickerDpartureDate.Value = DateTime.Now;
			textBoxAddActivity.Text = string.Empty;
		}
	}
}
