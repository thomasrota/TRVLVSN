namespace TRVLVSN
{
	partial class FormAdd
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
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonImportTrips = new System.Windows.Forms.Button();
			this.dateTimePickerStartTrip = new System.Windows.Forms.DateTimePicker();
			this.panelAddContent = new System.Windows.Forms.Panel();
			this.listViewAddedTrips = new System.Windows.Forms.ListView();
			this.labelArriveDate = new System.Windows.Forms.Label();
			this.dateTimePickerArriveDate = new System.Windows.Forms.DateTimePicker();
			this.labelDepartureDate = new System.Windows.Forms.Label();
			this.dateTimePickerDpartureDate = new System.Windows.Forms.DateTimePicker();
			this.textBoxAddActivity = new System.Windows.Forms.TextBox();
			this.labelActivity = new System.Windows.Forms.Label();
			this.textBoxDestinationName = new System.Windows.Forms.TextBox();
			this.labelDestinationName = new System.Windows.Forms.Label();
			this.textBoxTripName = new System.Windows.Forms.TextBox();
			this.labelTripName = new System.Windows.Forms.Label();
			this.labelDateEndTrip = new System.Windows.Forms.Label();
			this.dateTimePickerEndTrip = new System.Windows.Forms.DateTimePicker();
			this.labelDateStartTrip = new System.Windows.Forms.Label();
			this.buttonExport = new System.Windows.Forms.Button();
			this.panelAddContent.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonAdd
			// 
			this.buttonAdd.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAdd.Location = new System.Drawing.Point(725, 493);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(98, 38);
			this.buttonAdd.TabIndex = 0;
			this.buttonAdd.Text = "Aggiungi";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonImportTrips
			// 
			this.buttonImportTrips.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonImportTrips.Location = new System.Drawing.Point(581, 493);
			this.buttonImportTrips.Name = "buttonImportTrips";
			this.buttonImportTrips.Size = new System.Drawing.Size(138, 38);
			this.buttonImportTrips.TabIndex = 1;
			this.buttonImportTrips.Text = "Importa da file";
			this.buttonImportTrips.UseVisualStyleBackColor = true;
			this.buttonImportTrips.Click += new System.EventHandler(this.buttonImportTrips_Click);
			// 
			// dateTimePickerStartTrip
			// 
			this.dateTimePickerStartTrip.CalendarMonthBackground = System.Drawing.Color.FloralWhite;
			this.dateTimePickerStartTrip.CalendarTitleBackColor = System.Drawing.Color.PaleGoldenrod;
			this.dateTimePickerStartTrip.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePickerStartTrip.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerStartTrip.Location = new System.Drawing.Point(73, 236);
			this.dateTimePickerStartTrip.Name = "dateTimePickerStartTrip";
			this.dateTimePickerStartTrip.Size = new System.Drawing.Size(137, 28);
			this.dateTimePickerStartTrip.TabIndex = 2;
			// 
			// panelAddContent
			// 
			this.panelAddContent.Controls.Add(this.listViewAddedTrips);
			this.panelAddContent.Controls.Add(this.labelArriveDate);
			this.panelAddContent.Controls.Add(this.dateTimePickerArriveDate);
			this.panelAddContent.Controls.Add(this.labelDepartureDate);
			this.panelAddContent.Controls.Add(this.dateTimePickerDpartureDate);
			this.panelAddContent.Controls.Add(this.textBoxAddActivity);
			this.panelAddContent.Controls.Add(this.labelActivity);
			this.panelAddContent.Controls.Add(this.textBoxDestinationName);
			this.panelAddContent.Controls.Add(this.labelDestinationName);
			this.panelAddContent.Controls.Add(this.textBoxTripName);
			this.panelAddContent.Controls.Add(this.labelTripName);
			this.panelAddContent.Controls.Add(this.labelDateEndTrip);
			this.panelAddContent.Controls.Add(this.dateTimePickerEndTrip);
			this.panelAddContent.Controls.Add(this.labelDateStartTrip);
			this.panelAddContent.Controls.Add(this.dateTimePickerStartTrip);
			this.panelAddContent.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelAddContent.Location = new System.Drawing.Point(0, 0);
			this.panelAddContent.Name = "panelAddContent";
			this.panelAddContent.Size = new System.Drawing.Size(995, 487);
			this.panelAddContent.TabIndex = 3;
			// 
			// listViewAddedTrips
			// 
			this.listViewAddedTrips.HideSelection = false;
			this.listViewAddedTrips.Location = new System.Drawing.Point(672, 154);
			this.listViewAddedTrips.Name = "listViewAddedTrips";
			this.listViewAddedTrips.Size = new System.Drawing.Size(256, 274);
			this.listViewAddedTrips.TabIndex = 16;
			this.listViewAddedTrips.UseCompatibleStateImageBehavior = false;
			// 
			// labelArriveDate
			// 
			this.labelArriveDate.AutoSize = true;
			this.labelArriveDate.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelArriveDate.Location = new System.Drawing.Point(412, 369);
			this.labelArriveDate.Name = "labelArriveDate";
			this.labelArriveDate.Size = new System.Drawing.Size(120, 28);
			this.labelArriveDate.TabIndex = 15;
			this.labelArriveDate.Text = "Data Arrivo:";
			// 
			// dateTimePickerArriveDate
			// 
			this.dateTimePickerArriveDate.CalendarMonthBackground = System.Drawing.Color.FloralWhite;
			this.dateTimePickerArriveDate.CalendarTitleBackColor = System.Drawing.Color.PaleGoldenrod;
			this.dateTimePickerArriveDate.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePickerArriveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerArriveDate.Location = new System.Drawing.Point(417, 400);
			this.dateTimePickerArriveDate.Name = "dateTimePickerArriveDate";
			this.dateTimePickerArriveDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dateTimePickerArriveDate.Size = new System.Drawing.Size(137, 28);
			this.dateTimePickerArriveDate.TabIndex = 14;
			// 
			// labelDepartureDate
			// 
			this.labelDepartureDate.AutoSize = true;
			this.labelDepartureDate.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDepartureDate.Location = new System.Drawing.Point(412, 205);
			this.labelDepartureDate.Name = "labelDepartureDate";
			this.labelDepartureDate.Size = new System.Drawing.Size(148, 28);
			this.labelDepartureDate.TabIndex = 13;
			this.labelDepartureDate.Text = "Data Partenza:";
			// 
			// dateTimePickerDpartureDate
			// 
			this.dateTimePickerDpartureDate.CalendarMonthBackground = System.Drawing.Color.FloralWhite;
			this.dateTimePickerDpartureDate.CalendarTitleBackColor = System.Drawing.Color.PaleGoldenrod;
			this.dateTimePickerDpartureDate.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePickerDpartureDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerDpartureDate.Location = new System.Drawing.Point(417, 236);
			this.dateTimePickerDpartureDate.Name = "dateTimePickerDpartureDate";
			this.dateTimePickerDpartureDate.Size = new System.Drawing.Size(137, 28);
			this.dateTimePickerDpartureDate.TabIndex = 12;
			// 
			// textBoxAddActivity
			// 
			this.textBoxAddActivity.Location = new System.Drawing.Point(762, 83);
			this.textBoxAddActivity.Name = "textBoxAddActivity";
			this.textBoxAddActivity.Size = new System.Drawing.Size(166, 22);
			this.textBoxAddActivity.TabIndex = 11;
			// 
			// labelActivity
			// 
			this.labelActivity.AutoSize = true;
			this.labelActivity.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelActivity.Location = new System.Drawing.Point(757, 46);
			this.labelActivity.Name = "labelActivity";
			this.labelActivity.Size = new System.Drawing.Size(171, 28);
			this.labelActivity.TabIndex = 10;
			this.labelActivity.Text = "Aggiungi Attività:";
			// 
			// textBoxDestinationName
			// 
			this.textBoxDestinationName.Location = new System.Drawing.Point(398, 83);
			this.textBoxDestinationName.Name = "textBoxDestinationName";
			this.textBoxDestinationName.Size = new System.Drawing.Size(193, 22);
			this.textBoxDestinationName.TabIndex = 9;
			// 
			// labelDestinationName
			// 
			this.labelDestinationName.AutoSize = true;
			this.labelDestinationName.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDestinationName.Location = new System.Drawing.Point(393, 46);
			this.labelDestinationName.Name = "labelDestinationName";
			this.labelDestinationName.Size = new System.Drawing.Size(198, 28);
			this.labelDestinationName.TabIndex = 8;
			this.labelDestinationName.Text = "Nome Destinazione:";
			// 
			// textBoxTripName
			// 
			this.textBoxTripName.Location = new System.Drawing.Point(73, 83);
			this.textBoxTripName.Name = "textBoxTripName";
			this.textBoxTripName.Size = new System.Drawing.Size(142, 22);
			this.textBoxTripName.TabIndex = 7;
			// 
			// labelTripName
			// 
			this.labelTripName.AutoSize = true;
			this.labelTripName.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTripName.Location = new System.Drawing.Point(68, 46);
			this.labelTripName.Name = "labelTripName";
			this.labelTripName.Size = new System.Drawing.Size(147, 28);
			this.labelTripName.TabIndex = 6;
			this.labelTripName.Text = "Nome Viaggio:";
			// 
			// labelDateEndTrip
			// 
			this.labelDateEndTrip.AutoSize = true;
			this.labelDateEndTrip.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDateEndTrip.Location = new System.Drawing.Point(68, 369);
			this.labelDateEndTrip.Name = "labelDateEndTrip";
			this.labelDateEndTrip.Size = new System.Drawing.Size(104, 28);
			this.labelDateEndTrip.TabIndex = 5;
			this.labelDateEndTrip.Text = "Data Fine:";
			// 
			// dateTimePickerEndTrip
			// 
			this.dateTimePickerEndTrip.CalendarMonthBackground = System.Drawing.Color.FloralWhite;
			this.dateTimePickerEndTrip.CalendarTitleBackColor = System.Drawing.Color.PaleGoldenrod;
			this.dateTimePickerEndTrip.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePickerEndTrip.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerEndTrip.Location = new System.Drawing.Point(73, 400);
			this.dateTimePickerEndTrip.Name = "dateTimePickerEndTrip";
			this.dateTimePickerEndTrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dateTimePickerEndTrip.Size = new System.Drawing.Size(137, 28);
			this.dateTimePickerEndTrip.TabIndex = 4;
			// 
			// labelDateStartTrip
			// 
			this.labelDateStartTrip.AutoSize = true;
			this.labelDateStartTrip.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDateStartTrip.Location = new System.Drawing.Point(68, 205);
			this.labelDateStartTrip.Name = "labelDateStartTrip";
			this.labelDateStartTrip.Size = new System.Drawing.Size(116, 28);
			this.labelDateStartTrip.TabIndex = 3;
			this.labelDateStartTrip.Text = "Data Inizio:";
			// 
			// buttonExport
			// 
			this.buttonExport.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonExport.Location = new System.Drawing.Point(829, 493);
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.Size = new System.Drawing.Size(138, 38);
			this.buttonExport.TabIndex = 4;
			this.buttonExport.Text = "Esporta file";
			this.buttonExport.UseVisualStyleBackColor = true;
			this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
			// 
			// FormAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(995, 510);
			this.Controls.Add(this.buttonExport);
			this.Controls.Add(this.buttonImportTrips);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.panelAddContent);
			this.Name = "FormAdd";
			this.Text = "FormAdd";
			this.panelAddContent.ResumeLayout(false);
			this.panelAddContent.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonImportTrips;
		private System.Windows.Forms.DateTimePicker dateTimePickerStartTrip;
		private System.Windows.Forms.Panel panelAddContent;
		private System.Windows.Forms.Label labelDateStartTrip;
		private System.Windows.Forms.Label labelDateEndTrip;
		private System.Windows.Forms.DateTimePicker dateTimePickerEndTrip;
		private System.Windows.Forms.TextBox textBoxTripName;
		private System.Windows.Forms.Label labelTripName;
		private System.Windows.Forms.TextBox textBoxAddActivity;
		private System.Windows.Forms.Label labelActivity;
		private System.Windows.Forms.TextBox textBoxDestinationName;
		private System.Windows.Forms.Label labelDestinationName;
		private System.Windows.Forms.Label labelArriveDate;
		private System.Windows.Forms.DateTimePicker dateTimePickerArriveDate;
		private System.Windows.Forms.Label labelDepartureDate;
		private System.Windows.Forms.DateTimePicker dateTimePickerDpartureDate;
		private System.Windows.Forms.ListView listViewAddedTrips;
		private System.Windows.Forms.Button buttonExport;
	}
}