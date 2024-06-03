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
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace TRVLVSN
{
	public partial class FormVis : Form
	{
		private List<Trip> trips;
		private string FilePath = @"trips.json";
		private GMapControl gMapControl;
		private GMapOverlay markersOverlay;
		public FormVis()
		{
			InitializeComponent();
			trips = new List<Trip>();
			if (File.Exists(FilePath) && new FileInfo(FilePath).Length > 0)
			{
				trips = JsonHelper.LoadFromFile<Trip>(FilePath);
				InitializeMap();
				InitializeListView();
				DisplayTrips();
				//DisplayMap();
			}
		}

		private void InitializeMap()
		{
			gMapControl = new GMapControl
			{
				Dock = DockStyle.Fill,
				MapProvider = GMapProviders.OpenStreetMap,
				Position = new PointLatLng(20, 0), // Centro mappa
				MinZoom = 2,
				MaxZoom = 18,
				Zoom = 2,
				ShowCenter = false,

				CanDragMap = true,
				DragButton = MouseButtons.Left
			};

			gMapControl.MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter;
			gMapControl.IgnoreMarkerOnMouseWheel = true;

			panelMap.Controls.Add(gMapControl);

			markersOverlay = new GMapOverlay("markers");
			gMapControl.Overlays.Add(markersOverlay);
		}

		private void AddMarker(PointLatLng point, string tooltipText)
		{
			GMarkerGoogle marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);
			marker.ToolTipText = tooltipText;
			marker.ToolTipMode = MarkerTooltipMode.Always;
			markersOverlay.Markers.Add(marker);
		}	

		private void InitializeListView()
		{
			listViewOld.View = View.Details;
			listViewOld.Columns.Add("Nome Viaggio", 100, HorizontalAlignment.Left);
			listViewOld.Columns.Add("Data Inizio", 100, HorizontalAlignment.Left);
			listViewOld.Columns.Add("Data Fine", 100, HorizontalAlignment.Left);
			listViewOld.Columns.Add("Nome Destinazione", 100, HorizontalAlignment.Left);
			listViewOld.Columns.Add("Data di Arrivo", 100, HorizontalAlignment.Left);
			listViewOld.Columns.Add("Data di Partenza", 100, HorizontalAlignment.Left);
			listViewOld.Columns.Add("Attività", 200, HorizontalAlignment.Left);

			listViewNew.View = View.Details;
			listViewNew.Columns.Add("Nome Viaggio", 100, HorizontalAlignment.Left);
			listViewNew.Columns.Add("Data Inizio", 100, HorizontalAlignment.Left);
			listViewNew.Columns.Add("Data Fine", 100, HorizontalAlignment.Left);
			listViewNew.Columns.Add("Nome Destinazione", 100, HorizontalAlignment.Left);
			listViewNew.Columns.Add("Data di Arrivo", 100, HorizontalAlignment.Left);
			listViewNew.Columns.Add("Data di Partenza", 100, HorizontalAlignment.Left);
			listViewNew.Columns.Add("Attività", 200, HorizontalAlignment.Left);
		}

		private void DisplayTrips()
		{
			markersOverlay.Markers.Clear();
			listViewOld.Items.Clear();
			listViewNew.Items.Clear();

			DateTime today = DateTime.Today;

			foreach (var trip in trips)
			{
				foreach (var destination in trip.Destinations)
				{
					string activities = string.Join(", ", destination.Activities);
					ListViewItem item = new ListViewItem(trip.TripName);
					item.SubItems.Add(trip.StartDate.ToString("dd/MM/yyyy"));
					item.SubItems.Add(trip.EndDate.ToString("dd/MM/yyyy"));
					item.SubItems.Add(destination.Name);
					item.SubItems.Add(destination.ArrivalDate.ToString("dd/MM/yyyy"));
					item.SubItems.Add(destination.DepartureDate.ToString("dd/MM/yyyy"));
					item.SubItems.Add(activities);

					if (destination.DepartureDate < today)
					{
						listViewOld.Items.Add(item);
					}
					else
					{
						listViewNew.Items.Add(item);
					}

					PointLatLng point = new PointLatLng(destination.Latitude, destination.Longitude);
					string tooltipText = $"{destination.Name}\n{destination.ArrivalDate.ToShortDateString()} - {destination.DepartureDate.ToShortDateString()}";
					AddMarker(point, tooltipText);
				}
			}

			gMapControl.ZoomAndCenterMarkers("markers");
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
	}
}
