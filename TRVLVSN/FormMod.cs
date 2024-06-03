using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRVLVSN
{
	public partial class FormMod : Form
	{
		private List<Trip> trips;
		private string FilePath = @"trips.json";
		private Trip tripToEdit;

		public FormMod()
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

		private async void buttonMod_Click(object sender, EventArgs e)
		{
			string tripNameToEdit = textBoxOldName.Text;

			tripToEdit = trips.FirstOrDefault(trip => trip.TripName == tripNameToEdit);
			if (tripToEdit != null)
			{
				DateTime today = DateTime.Today;
				bool datesValid = dateTimePickerModStartTrip.Value <= dateTimePickerModEndTrip.Value &&
								  dateTimePickerModArriveDate.Value < dateTimePickerModEndTrip.Value &&
								  dateTimePickeModrDpartureDate.Value < dateTimePickerModEndTrip.Value &&
								  dateTimePickerModStartTrip.Value >= today &&
								  dateTimePickerModEndTrip.Value >= today &&
								  dateTimePickerModArriveDate.Value >= today &&
								  dateTimePickeModrDpartureDate.Value >= today;

				if (!datesValid)
				{
					MessageBox.Show("Errore: assicurati di aver inserito le date correttamente.", "Errore di data", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				// Aggiorna i dettagli del viaggio
				tripToEdit.TripName = textBoxModTripName.Text;
				tripToEdit.StartDate = dateTimePickerModStartTrip.Value;
				tripToEdit.EndDate = dateTimePickerModEndTrip.Value;

				if (tripToEdit.Destinations.Any())
				{
					var destination = tripToEdit.Destinations.First();
					destination.Name = textBoxModDestinationName.Text;
					destination.ArrivalDate = dateTimePickerModArriveDate.Value;
					destination.DepartureDate = dateTimePickeModrDpartureDate.Value;
					destination.Activities = new List<string>(textBoxModActivity.Text.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries));
					// Ottieni le coordinate della destinazione
					var coordinates = await GeocodingHelper.GetCoordinatesAsync(destination.Name);
					if (coordinates.HasValue)
					{
						destination.Latitude = coordinates.Value.Latitude;
						destination.Longitude = coordinates.Value.Longitude;
					}
					else
					{
						MessageBox.Show("Error: Unable to get coordinates for the destination.", "Geocoding Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
				ClearUI();
				DisplayTrips();
				JsonHelper.SaveToFile(FilePath, trips);
				MessageBox.Show($"'{tripToEdit.TripName}' modificato con successo.", "Modificato correttamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show($"'{tripNameToEdit}' non trovato.", "Errore di ricerca", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void InitializeListView()
		{
			listViewModTrips.View = View.Details;
			listViewModTrips.Columns.Add("Nome Viaggio", 100, HorizontalAlignment.Left);
			listViewModTrips.Columns.Add("Data Inizio", 100, HorizontalAlignment.Left);
			listViewModTrips.Columns.Add("Data Fine", 100, HorizontalAlignment.Left);
			listViewModTrips.Columns.Add("Nome Destinazione", 100, HorizontalAlignment.Left);
			listViewModTrips.Columns.Add("Data di partenza", 100, HorizontalAlignment.Left);
			listViewModTrips.Columns.Add("Data di arrivo", 100, HorizontalAlignment.Left);
			listViewModTrips.Columns.Add("Attività", 200, HorizontalAlignment.Left);
		}

		private void DisplayTrips()
		{
			listViewModTrips.Items.Clear();
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

					listViewModTrips.Items.Add(item);
				}
			}
		}

		private void ClearUI()
		{
			textBoxOldName.Text = string.Empty;
			textBoxModTripName.Text = string.Empty;
			textBoxModDestinationName.Text = string.Empty;
			textBoxModActivity.Text = string.Empty;
		}
	}
}