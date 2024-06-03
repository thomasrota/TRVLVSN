namespace TRVLVSN
{
	partial class FormMod
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonExport = new System.Windows.Forms.Button();
			this.listViewModTrips = new System.Windows.Forms.ListView();
			this.labelModArriveDate = new System.Windows.Forms.Label();
			this.dateTimePickerModArriveDate = new System.Windows.Forms.DateTimePicker();
			this.labelModDepartureDate = new System.Windows.Forms.Label();
			this.dateTimePickeModrDpartureDate = new System.Windows.Forms.DateTimePicker();
			this.textBoxModActivity = new System.Windows.Forms.TextBox();
			this.dateTimePickerModStartTrip = new System.Windows.Forms.DateTimePicker();
			this.buttonImportTrips = new System.Windows.Forms.Button();
			this.labelModActivity = new System.Windows.Forms.Label();
			this.textBoxModDestinationName = new System.Windows.Forms.TextBox();
			this.labelModDestinationName = new System.Windows.Forms.Label();
			this.textBoxModTripName = new System.Windows.Forms.TextBox();
			this.labelModTripName = new System.Windows.Forms.Label();
			this.labelDateModEndTrip = new System.Windows.Forms.Label();
			this.dateTimePickerModEndTrip = new System.Windows.Forms.DateTimePicker();
			this.labelDateStartTrip = new System.Windows.Forms.Label();
			this.buttonMod = new System.Windows.Forms.Button();
			this.panelAddContent = new System.Windows.Forms.Panel();
			this.textBoxOldName = new System.Windows.Forms.TextBox();
			this.labelOldName = new System.Windows.Forms.Label();
			this.panelAddContent.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonExport
			// 
			this.buttonExport.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonExport.Location = new System.Drawing.Point(829, 493);
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.Size = new System.Drawing.Size(138, 38);
			this.buttonExport.TabIndex = 8;
			this.buttonExport.Text = "Esporta file";
			this.buttonExport.UseVisualStyleBackColor = true;
			this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
			// 
			// listViewModTrips
			// 
			this.listViewModTrips.HideSelection = false;
			this.listViewModTrips.Location = new System.Drawing.Point(672, 154);
			this.listViewModTrips.Name = "listViewModTrips";
			this.listViewModTrips.Size = new System.Drawing.Size(256, 274);
			this.listViewModTrips.TabIndex = 16;
			this.listViewModTrips.UseCompatibleStateImageBehavior = false;
			// 
			// labelModArriveDate
			// 
			this.labelModArriveDate.AutoSize = true;
			this.labelModArriveDate.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelModArriveDate.Location = new System.Drawing.Point(490, 369);
			this.labelModArriveDate.Name = "labelModArriveDate";
			this.labelModArriveDate.Size = new System.Drawing.Size(120, 28);
			this.labelModArriveDate.TabIndex = 15;
			this.labelModArriveDate.Text = "Data Arrivo:";
			// 
			// dateTimePickerModArriveDate
			// 
			this.dateTimePickerModArriveDate.CalendarMonthBackground = System.Drawing.Color.FloralWhite;
			this.dateTimePickerModArriveDate.CalendarTitleBackColor = System.Drawing.Color.PaleGoldenrod;
			this.dateTimePickerModArriveDate.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePickerModArriveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerModArriveDate.Location = new System.Drawing.Point(495, 400);
			this.dateTimePickerModArriveDate.Name = "dateTimePickerModArriveDate";
			this.dateTimePickerModArriveDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dateTimePickerModArriveDate.Size = new System.Drawing.Size(137, 28);
			this.dateTimePickerModArriveDate.TabIndex = 14;
			// 
			// labelModDepartureDate
			// 
			this.labelModDepartureDate.AutoSize = true;
			this.labelModDepartureDate.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelModDepartureDate.Location = new System.Drawing.Point(490, 205);
			this.labelModDepartureDate.Name = "labelModDepartureDate";
			this.labelModDepartureDate.Size = new System.Drawing.Size(148, 28);
			this.labelModDepartureDate.TabIndex = 13;
			this.labelModDepartureDate.Text = "Data Partenza:";
			// 
			// dateTimePickeModrDpartureDate
			// 
			this.dateTimePickeModrDpartureDate.CalendarMonthBackground = System.Drawing.Color.FloralWhite;
			this.dateTimePickeModrDpartureDate.CalendarTitleBackColor = System.Drawing.Color.PaleGoldenrod;
			this.dateTimePickeModrDpartureDate.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePickeModrDpartureDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickeModrDpartureDate.Location = new System.Drawing.Point(495, 236);
			this.dateTimePickeModrDpartureDate.Name = "dateTimePickeModrDpartureDate";
			this.dateTimePickeModrDpartureDate.Size = new System.Drawing.Size(137, 28);
			this.dateTimePickeModrDpartureDate.TabIndex = 12;
			// 
			// textBoxModActivity
			// 
			this.textBoxModActivity.Location = new System.Drawing.Point(762, 83);
			this.textBoxModActivity.Name = "textBoxModActivity";
			this.textBoxModActivity.Size = new System.Drawing.Size(166, 22);
			this.textBoxModActivity.TabIndex = 11;
			// 
			// dateTimePickerModStartTrip
			// 
			this.dateTimePickerModStartTrip.CalendarMonthBackground = System.Drawing.Color.FloralWhite;
			this.dateTimePickerModStartTrip.CalendarTitleBackColor = System.Drawing.Color.PaleGoldenrod;
			this.dateTimePickerModStartTrip.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePickerModStartTrip.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerModStartTrip.Location = new System.Drawing.Point(284, 236);
			this.dateTimePickerModStartTrip.Name = "dateTimePickerModStartTrip";
			this.dateTimePickerModStartTrip.Size = new System.Drawing.Size(137, 28);
			this.dateTimePickerModStartTrip.TabIndex = 2;
			// 
			// buttonImportTrips
			// 
			this.buttonImportTrips.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonImportTrips.Location = new System.Drawing.Point(581, 493);
			this.buttonImportTrips.Name = "buttonImportTrips";
			this.buttonImportTrips.Size = new System.Drawing.Size(138, 38);
			this.buttonImportTrips.TabIndex = 6;
			this.buttonImportTrips.Text = "Importa da file";
			this.buttonImportTrips.UseVisualStyleBackColor = true;
			this.buttonImportTrips.Click += new System.EventHandler(this.buttonImportTrips_Click);
			// 
			// labelModActivity
			// 
			this.labelModActivity.AutoSize = true;
			this.labelModActivity.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelModActivity.Location = new System.Drawing.Point(757, 46);
			this.labelModActivity.Name = "labelModActivity";
			this.labelModActivity.Size = new System.Drawing.Size(171, 28);
			this.labelModActivity.TabIndex = 10;
			this.labelModActivity.Text = "Aggiungi Attività:";
			// 
			// textBoxModDestinationName
			// 
			this.textBoxModDestinationName.Location = new System.Drawing.Point(476, 83);
			this.textBoxModDestinationName.Name = "textBoxModDestinationName";
			this.textBoxModDestinationName.Size = new System.Drawing.Size(193, 22);
			this.textBoxModDestinationName.TabIndex = 9;
			// 
			// labelModDestinationName
			// 
			this.labelModDestinationName.AutoSize = true;
			this.labelModDestinationName.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelModDestinationName.Location = new System.Drawing.Point(471, 46);
			this.labelModDestinationName.Name = "labelModDestinationName";
			this.labelModDestinationName.Size = new System.Drawing.Size(198, 28);
			this.labelModDestinationName.TabIndex = 8;
			this.labelModDestinationName.Text = "Nome Destinazione:";
			// 
			// textBoxModTripName
			// 
			this.textBoxModTripName.Location = new System.Drawing.Point(284, 83);
			this.textBoxModTripName.Name = "textBoxModTripName";
			this.textBoxModTripName.Size = new System.Drawing.Size(142, 22);
			this.textBoxModTripName.TabIndex = 7;
			// 
			// labelModTripName
			// 
			this.labelModTripName.AutoSize = true;
			this.labelModTripName.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelModTripName.Location = new System.Drawing.Point(279, 46);
			this.labelModTripName.Name = "labelModTripName";
			this.labelModTripName.Size = new System.Drawing.Size(147, 28);
			this.labelModTripName.TabIndex = 6;
			this.labelModTripName.Text = "Nome Viaggio:";
			// 
			// labelDateModEndTrip
			// 
			this.labelDateModEndTrip.AutoSize = true;
			this.labelDateModEndTrip.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDateModEndTrip.Location = new System.Drawing.Point(279, 369);
			this.labelDateModEndTrip.Name = "labelDateModEndTrip";
			this.labelDateModEndTrip.Size = new System.Drawing.Size(104, 28);
			this.labelDateModEndTrip.TabIndex = 5;
			this.labelDateModEndTrip.Text = "Data Fine:";
			// 
			// dateTimePickerModEndTrip
			// 
			this.dateTimePickerModEndTrip.CalendarMonthBackground = System.Drawing.Color.FloralWhite;
			this.dateTimePickerModEndTrip.CalendarTitleBackColor = System.Drawing.Color.PaleGoldenrod;
			this.dateTimePickerModEndTrip.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePickerModEndTrip.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerModEndTrip.Location = new System.Drawing.Point(284, 400);
			this.dateTimePickerModEndTrip.Name = "dateTimePickerModEndTrip";
			this.dateTimePickerModEndTrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dateTimePickerModEndTrip.Size = new System.Drawing.Size(137, 28);
			this.dateTimePickerModEndTrip.TabIndex = 4;
			// 
			// labelDateStartTrip
			// 
			this.labelDateStartTrip.AutoSize = true;
			this.labelDateStartTrip.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDateStartTrip.Location = new System.Drawing.Point(279, 205);
			this.labelDateStartTrip.Name = "labelDateStartTrip";
			this.labelDateStartTrip.Size = new System.Drawing.Size(116, 28);
			this.labelDateStartTrip.TabIndex = 3;
			this.labelDateStartTrip.Text = "Data Inizio:";
			// 
			// buttonMod
			// 
			this.buttonMod.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonMod.Location = new System.Drawing.Point(725, 493);
			this.buttonMod.Name = "buttonMod";
			this.buttonMod.Size = new System.Drawing.Size(98, 38);
			this.buttonMod.TabIndex = 5;
			this.buttonMod.Text = "Modifica";
			this.buttonMod.UseVisualStyleBackColor = true;
			this.buttonMod.Click += new System.EventHandler(this.buttonMod_Click);
			// 
			// panelAddContent
			// 
			this.panelAddContent.Controls.Add(this.textBoxOldName);
			this.panelAddContent.Controls.Add(this.labelOldName);
			this.panelAddContent.Controls.Add(this.listViewModTrips);
			this.panelAddContent.Controls.Add(this.labelModArriveDate);
			this.panelAddContent.Controls.Add(this.dateTimePickerModArriveDate);
			this.panelAddContent.Controls.Add(this.labelModDepartureDate);
			this.panelAddContent.Controls.Add(this.dateTimePickeModrDpartureDate);
			this.panelAddContent.Controls.Add(this.textBoxModActivity);
			this.panelAddContent.Controls.Add(this.labelModActivity);
			this.panelAddContent.Controls.Add(this.textBoxModDestinationName);
			this.panelAddContent.Controls.Add(this.labelModDestinationName);
			this.panelAddContent.Controls.Add(this.textBoxModTripName);
			this.panelAddContent.Controls.Add(this.labelModTripName);
			this.panelAddContent.Controls.Add(this.labelDateModEndTrip);
			this.panelAddContent.Controls.Add(this.dateTimePickerModEndTrip);
			this.panelAddContent.Controls.Add(this.labelDateStartTrip);
			this.panelAddContent.Controls.Add(this.dateTimePickerModStartTrip);
			this.panelAddContent.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelAddContent.Location = new System.Drawing.Point(0, 0);
			this.panelAddContent.Name = "panelAddContent";
			this.panelAddContent.Size = new System.Drawing.Size(995, 487);
			this.panelAddContent.TabIndex = 7;
			// 
			// textBoxOldName
			// 
			this.textBoxOldName.Location = new System.Drawing.Point(17, 83);
			this.textBoxOldName.Name = "textBoxOldName";
			this.textBoxOldName.Size = new System.Drawing.Size(222, 22);
			this.textBoxOldName.TabIndex = 18;
			// 
			// labelOldName
			// 
			this.labelOldName.AutoSize = true;
			this.labelOldName.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelOldName.Location = new System.Drawing.Point(12, 46);
			this.labelOldName.Name = "labelOldName";
			this.labelOldName.Size = new System.Drawing.Size(227, 28);
			this.labelOldName.TabIndex = 17;
			this.labelOldName.Text = "Vecchio Nome Viaggio:";
			// 
			// FormMod
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(995, 510);
			this.Controls.Add(this.buttonExport);
			this.Controls.Add(this.buttonImportTrips);
			this.Controls.Add(this.buttonMod);
			this.Controls.Add(this.panelAddContent);
			this.Name = "FormMod";
			this.Text = "FormMod";
			this.panelAddContent.ResumeLayout(false);
			this.panelAddContent.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonExport;
		private System.Windows.Forms.ListView listViewModTrips;
		private System.Windows.Forms.Label labelModArriveDate;
		private System.Windows.Forms.DateTimePicker dateTimePickerModArriveDate;
		private System.Windows.Forms.Label labelModDepartureDate;
		private System.Windows.Forms.DateTimePicker dateTimePickeModrDpartureDate;
		private System.Windows.Forms.TextBox textBoxModActivity;
		private System.Windows.Forms.DateTimePicker dateTimePickerModStartTrip;
		private System.Windows.Forms.Button buttonImportTrips;
		private System.Windows.Forms.Label labelModActivity;
		private System.Windows.Forms.TextBox textBoxModDestinationName;
		private System.Windows.Forms.Label labelModDestinationName;
		private System.Windows.Forms.TextBox textBoxModTripName;
		private System.Windows.Forms.Label labelModTripName;
		private System.Windows.Forms.Label labelDateModEndTrip;
		private System.Windows.Forms.DateTimePicker dateTimePickerModEndTrip;
		private System.Windows.Forms.Label labelDateStartTrip;
		private System.Windows.Forms.Button buttonMod;
		private System.Windows.Forms.Panel panelAddContent;
		private System.Windows.Forms.TextBox textBoxOldName;
		private System.Windows.Forms.Label labelOldName;
	}
}