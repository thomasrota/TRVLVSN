using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRVLVSN
{
	public partial class FormDelete : Form
	{
		private List<Trip> trips;
		private string FilePath = @"trips.json";

		public FormDelete()
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

		private void buttonDeleteTrip_Click(object sender, EventArgs e)
		{
			string tripNameToDelete = textBoxDeleteTrip.Text;

			Trip tripToDelete = trips.FirstOrDefault(trip => trip.TripName == tripNameToDelete);
			if (tripToDelete != null)
			{
				trips.Remove(tripToDelete);
				DisplayTrips();
				JsonHelper.SaveToFile(FilePath, trips);
				ClearUI();
				MessageBox.Show($"'{tripNameToDelete}' eliminato correttamente.", "Eliminazione avvenuta con successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show($"'{tripNameToDelete}' non trovato.", "Errore durante la fase di eliminazione", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buttonExport_Click_1(object sender, EventArgs e)
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

		private void InitializeListView()
		{
			listViewTrips.View = View.Details;
			listViewTrips.Columns.Add("Nome Viaggio", 100, HorizontalAlignment.Left);
			listViewTrips.Columns.Add("Data Inizio", 100, HorizontalAlignment.Left);
			listViewTrips.Columns.Add("Data Fine", 100, HorizontalAlignment.Left);
			listViewTrips.Columns.Add("Nome Destinazione", 100, HorizontalAlignment.Left);
			listViewTrips.Columns.Add("Data di partenza", 100, HorizontalAlignment.Left);
			listViewTrips.Columns.Add("Data di arrivo", 100, HorizontalAlignment.Left);
			listViewTrips.Columns.Add("Attività", 200, HorizontalAlignment.Left);
		}

		private void DisplayTrips()
		{
			listViewTrips.Items.Clear();
			foreach (var trip in trips)
			{
				foreach (var destination in trip.Destinations)
				{
					ListViewItem item = new ListViewItem(trip.TripName);
					item.SubItems.Add(trip.StartDate.ToString("dd/MM/yyyy"));
					item.SubItems.Add(trip.EndDate.ToString("dd/MM/yyyy"));
					item.SubItems.Add(destination.Name);
					item.SubItems.Add(destination.DepartureDate.ToString("dd/MM/yyyy"));
					item.SubItems.Add(destination.ArrivalDate.ToString("dd/MM/yyyy"));
					item.SubItems.Add(string.Join(", ", destination.Activities));

					listViewTrips.Items.Add(item);
				}
			}
		}

		private void ClearUI()
		{
			textBoxDeleteTrip.Text = string.Empty;
		}
	}
}
