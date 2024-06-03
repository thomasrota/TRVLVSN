namespace TRVLVSN
{
	partial class FormVis
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
			this.labelNext = new System.Windows.Forms.Label();
			this.labelOld = new System.Windows.Forms.Label();
			this.listViewNew = new System.Windows.Forms.ListView();
			this.listViewOld = new System.Windows.Forms.ListView();
			this.buttonExport = new System.Windows.Forms.Button();
			this.buttonImportTrips = new System.Windows.Forms.Button();
			this.panelMap = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// labelNext
			// 
			this.labelNext.AutoSize = true;
			this.labelNext.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNext.Location = new System.Drawing.Point(54, 42);
			this.labelNext.Name = "labelNext";
			this.labelNext.Size = new System.Drawing.Size(123, 21);
			this.labelNext.TabIndex = 1;
			this.labelNext.Text = "Prossimi viaggi:";
			// 
			// labelOld
			// 
			this.labelOld.AutoSize = true;
			this.labelOld.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelOld.Location = new System.Drawing.Point(53, 256);
			this.labelOld.Name = "labelOld";
			this.labelOld.Size = new System.Drawing.Size(126, 21);
			this.labelOld.TabIndex = 2;
			this.labelOld.Text = "Viaggi trascorsi:";
			// 
			// listViewNew
			// 
			this.listViewNew.HideSelection = false;
			this.listViewNew.Location = new System.Drawing.Point(57, 86);
			this.listViewNew.Name = "listViewNew";
			this.listViewNew.Size = new System.Drawing.Size(476, 139);
			this.listViewNew.TabIndex = 3;
			this.listViewNew.UseCompatibleStateImageBehavior = false;
			// 
			// listViewOld
			// 
			this.listViewOld.HideSelection = false;
			this.listViewOld.Location = new System.Drawing.Point(57, 302);
			this.listViewOld.Name = "listViewOld";
			this.listViewOld.Size = new System.Drawing.Size(476, 139);
			this.listViewOld.TabIndex = 4;
			this.listViewOld.UseCompatibleStateImageBehavior = false;
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
			this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
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
			// panelMap
			// 
			this.panelMap.Location = new System.Drawing.Point(563, 42);
			this.panelMap.Name = "panelMap";
			this.panelMap.Size = new System.Drawing.Size(404, 399);
			this.panelMap.TabIndex = 8;
			// 
			// FormVis
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(995, 510);
			this.Controls.Add(this.panelMap);
			this.Controls.Add(this.buttonExport);
			this.Controls.Add(this.buttonImportTrips);
			this.Controls.Add(this.listViewOld);
			this.Controls.Add(this.listViewNew);
			this.Controls.Add(this.labelOld);
			this.Controls.Add(this.labelNext);
			this.Name = "FormVis";
			this.Text = "FormVis";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label labelNext;
		private System.Windows.Forms.Label labelOld;
		private System.Windows.Forms.ListView listViewNew;
		private System.Windows.Forms.ListView listViewOld;
		private System.Windows.Forms.Button buttonExport;
		private System.Windows.Forms.Button buttonImportTrips;
		private System.Windows.Forms.Panel panelMap;
	}
}