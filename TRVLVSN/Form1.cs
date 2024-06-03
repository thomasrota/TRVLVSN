using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
			labelTit.Text += "Aggiungi viaggio";
			OpenFormInput<FormAdd>();
		}
		private void buttonDelete_Click(object sender, EventArgs e)
		{
			CloseFormsInput();
			labelTit.Text += "Elimina viaggio";
			OpenFormInput<FormDelete>();
		}
		private void buttonModify_Click(object sender, EventArgs e)
		{
			CloseFormsInput();
			labelTit.Text += "Modifica viaggio";
			OpenFormInput<FormMod>();
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
