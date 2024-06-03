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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		#region Funzioni evento
		private void buttonAddTrip_Click(object sender, EventArgs e)
		{
			CloseFormsInput();
			panelTitle.BackColor = Color.FloralWhite;
			labelTit.Text += "Aggiungi viaggio";
			OpenFormInput<FormAdd>();
		}
		private void buttonDelete_Click(object sender, EventArgs e)
		{
			CloseFormsInput();
			panelTitle.BackColor = Color.FloralWhite;
			labelTit.Text += "Elimina viaggio";
			OpenFormInput<FormDelete>();
		}
		private void buttonModify_Click(object sender, EventArgs e)
		{
			CloseFormsInput();
			panelTitle.BackColor = Color.FloralWhite;
			labelTit.Text += "Modifica viaggio";
			OpenFormInput<FormMod>();
		}
		private void buttonVisualize_Click(object sender, EventArgs e)
		{
			CloseFormsInput();
			panelTitle.BackColor = Color.FloralWhite;
			labelTit.Text += "Visualizza viaggi";
			OpenFormInput<FormVis>();
		}

		private void buttonExt_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Sei sicuro di voler uscire?", "Uscita", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				var save = MessageBox.Show("Vuoi salvare i dati prima di uscire?", "Salvataggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (save == DialogResult.Yes)
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
							File.Copy(@"trips.json", exportFilePath, true);
							MessageBox.Show("File esportato correttamente.", "Esportazione andata a buon fine", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						catch (Exception ex)
						{
							MessageBox.Show($"Errore: {ex.Message}", "Errore durante la fase di esportazione", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
				Application.Exit();
			}
		}

		#endregion
		#region Funzioni servizio
		// Funzione per aprire un form in un pannello
		private void OpenFormInput<MyForm>() where MyForm : Form, new()
		{
		   Form FormInput;
		   FormInput = panelContent.Controls.OfType<MyForm>().FirstOrDefault();
		   if (FormInput == null)
		   {
		       FormInput = new MyForm();
		       FormInput.TopLevel = false;
		       FormInput.FormBorderStyle = FormBorderStyle.None;
		       FormInput.Dock = DockStyle.Fill;
		       panelContent.Controls.Add(FormInput);
		       panelContent.Tag = FormInput;
		       FormInput.Show();
		       FormInput.BringToFront();
		   }
		   else
		   {
		       FormInput.BringToFront();
		   }
		}
		// Funzione per chiudere form nel pannello
		private void CloseFormsInput()
		{
		   Form FormInput = panelContent.Controls.OfType<Form>().FirstOrDefault();
		   if (FormInput != null)
		   {
		       FormInput.Close();
		       labelTit.Text = "";
			}
		}
		#endregion
	}
}
