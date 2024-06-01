namespace TRVLVSN
{
	partial class FormDelete
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
			this.listViewTrips = new System.Windows.Forms.ListView();
			this.labelDeleteTrip = new System.Windows.Forms.Label();
			this.textBoxDeleteTrip = new System.Windows.Forms.TextBox();
			this.buttonExport = new System.Windows.Forms.Button();
			this.buttonImportTrips = new System.Windows.Forms.Button();
			this.buttonDeleteTrip = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listViewTrips
			// 
			this.listViewTrips.HideSelection = false;
			this.listViewTrips.Location = new System.Drawing.Point(410, 23);
			this.listViewTrips.Name = "listViewTrips";
			this.listViewTrips.Size = new System.Drawing.Size(557, 440);
			this.listViewTrips.TabIndex = 0;
			this.listViewTrips.UseCompatibleStateImageBehavior = false;
			// 
			// labelDeleteTrip
			// 
			this.labelDeleteTrip.AutoSize = true;
			this.labelDeleteTrip.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDeleteTrip.Location = new System.Drawing.Point(53, 23);
			this.labelDeleteTrip.Name = "labelDeleteTrip";
			this.labelDeleteTrip.Size = new System.Drawing.Size(126, 25);
			this.labelDeleteTrip.TabIndex = 1;
			this.labelDeleteTrip.Text = "Nome Viaggio:";
			// 
			// textBoxDeleteTrip
			// 
			this.textBoxDeleteTrip.Location = new System.Drawing.Point(58, 51);
			this.textBoxDeleteTrip.Name = "textBoxDeleteTrip";
			this.textBoxDeleteTrip.Size = new System.Drawing.Size(121, 22);
			this.textBoxDeleteTrip.TabIndex = 2;
			// 
			// buttonExport
			// 
			this.buttonExport.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonExport.Location = new System.Drawing.Point(829, 493);
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.Size = new System.Drawing.Size(138, 38);
			this.buttonExport.TabIndex = 7;
			this.buttonExport.Text = "Esporta file";
			this.buttonExport.UseVisualStyleBackColor = true;
			this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click_1);
			// 
			// buttonImportTrips
			// 
			this.buttonImportTrips.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonImportTrips.Location = new System.Drawing.Point(685, 493);
			this.buttonImportTrips.Name = "buttonImportTrips";
			this.buttonImportTrips.Size = new System.Drawing.Size(138, 38);
			this.buttonImportTrips.TabIndex = 6;
			this.buttonImportTrips.Text = "Importa da file";
			this.buttonImportTrips.UseVisualStyleBackColor = true;
			this.buttonImportTrips.Click += new System.EventHandler(this.buttonImportTrips_Click);
			// 
			// buttonDeleteTrip
			// 
			this.buttonDeleteTrip.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDeleteTrip.Location = new System.Drawing.Point(58, 424);
			this.buttonDeleteTrip.Name = "buttonDeleteTrip";
			this.buttonDeleteTrip.Size = new System.Drawing.Size(283, 39);
			this.buttonDeleteTrip.TabIndex = 8;
			this.buttonDeleteTrip.Text = "Elimina";
			this.buttonDeleteTrip.UseVisualStyleBackColor = true;
			this.buttonDeleteTrip.Click += new System.EventHandler(this.buttonDeleteTrip_Click);
			// 
			// FormDelete
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(995, 510);
			this.Controls.Add(this.buttonDeleteTrip);
			this.Controls.Add(this.buttonExport);
			this.Controls.Add(this.buttonImportTrips);
			this.Controls.Add(this.textBoxDeleteTrip);
			this.Controls.Add(this.labelDeleteTrip);
			this.Controls.Add(this.listViewTrips);
			this.Name = "FormDelete";
			this.Text = "FormDelete";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listViewTrips;
		private System.Windows.Forms.Label labelDeleteTrip;
		private System.Windows.Forms.TextBox textBoxDeleteTrip;
		private System.Windows.Forms.Button buttonExport;
		private System.Windows.Forms.Button buttonImportTrips;
		private System.Windows.Forms.Button buttonDeleteTrip;
	}
}