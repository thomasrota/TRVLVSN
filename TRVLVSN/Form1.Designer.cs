namespace TRVLVSN
{
	partial class Form1
	{
		/// <summary>
		/// Variabile di progettazione necessaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Pulire le risorse in uso.
		/// </summary>
		/// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Codice generato da Progettazione Windows Form

		/// <summary>
		/// Metodo necessario per il supporto della finestra di progettazione. Non modificare
		/// il contenuto del metodo con l'editor di codice.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panelSidebar = new System.Windows.Forms.Panel();
			this.buttonExt = new System.Windows.Forms.Button();
			this.buttonVisualize = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonModify = new System.Windows.Forms.Button();
			this.buttonAddTrip = new System.Windows.Forms.Button();
			this.panelLogo = new System.Windows.Forms.Panel();
			this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
			this.panelTitle = new System.Windows.Forms.Panel();
			this.labelTit = new System.Windows.Forms.Label();
			this.labelTitle = new System.Windows.Forms.Label();
			this.panelContent = new System.Windows.Forms.Panel();
			this.labelLogo = new System.Windows.Forms.Label();
			this.panelSidebar.SuspendLayout();
			this.panelLogo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
			this.panelTitle.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelSidebar
			// 
			this.panelSidebar.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.panelSidebar.Controls.Add(this.buttonExt);
			this.panelSidebar.Controls.Add(this.buttonVisualize);
			this.panelSidebar.Controls.Add(this.buttonDelete);
			this.panelSidebar.Controls.Add(this.buttonModify);
			this.panelSidebar.Controls.Add(this.buttonAddTrip);
			this.panelSidebar.Controls.Add(this.panelLogo);
			this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelSidebar.Location = new System.Drawing.Point(0, 0);
			this.panelSidebar.Name = "panelSidebar";
			this.panelSidebar.Size = new System.Drawing.Size(240, 657);
			this.panelSidebar.TabIndex = 0;
			// 
			// buttonExt
			// 
			this.buttonExt.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonExt.FlatAppearance.BorderSize = 0;
			this.buttonExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonExt.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonExt.Location = new System.Drawing.Point(0, 584);
			this.buttonExt.Name = "buttonExt";
			this.buttonExt.Size = new System.Drawing.Size(240, 73);
			this.buttonExt.TabIndex = 6;
			this.buttonExt.Text = "ESCI";
			this.buttonExt.UseVisualStyleBackColor = true;
			this.buttonExt.Click += new System.EventHandler(this.buttonExt_Click);
			// 
			// buttonVisualize
			// 
			this.buttonVisualize.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonVisualize.FlatAppearance.BorderSize = 0;
			this.buttonVisualize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonVisualize.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonVisualize.Location = new System.Drawing.Point(0, 443);
			this.buttonVisualize.Name = "buttonVisualize";
			this.buttonVisualize.Size = new System.Drawing.Size(240, 73);
			this.buttonVisualize.TabIndex = 5;
			this.buttonVisualize.Text = "Visualizza";
			this.buttonVisualize.UseVisualStyleBackColor = true;
			this.buttonVisualize.Click += new System.EventHandler(this.buttonVisualize_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonDelete.FlatAppearance.BorderSize = 0;
			this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDelete.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDelete.Location = new System.Drawing.Point(0, 370);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(240, 73);
			this.buttonDelete.TabIndex = 4;
			this.buttonDelete.Text = "Elimina Viaggio";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonModify
			// 
			this.buttonModify.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonModify.FlatAppearance.BorderSize = 0;
			this.buttonModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonModify.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonModify.Location = new System.Drawing.Point(0, 297);
			this.buttonModify.Name = "buttonModify";
			this.buttonModify.Size = new System.Drawing.Size(240, 73);
			this.buttonModify.TabIndex = 3;
			this.buttonModify.Text = "Modifica Viaggio";
			this.buttonModify.UseVisualStyleBackColor = true;
			this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
			// 
			// buttonAddTrip
			// 
			this.buttonAddTrip.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonAddTrip.FlatAppearance.BorderSize = 0;
			this.buttonAddTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAddTrip.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAddTrip.Location = new System.Drawing.Point(0, 224);
			this.buttonAddTrip.Name = "buttonAddTrip";
			this.buttonAddTrip.Size = new System.Drawing.Size(240, 73);
			this.buttonAddTrip.TabIndex = 2;
			this.buttonAddTrip.Text = "Aggiungi Viaggio";
			this.buttonAddTrip.UseVisualStyleBackColor = true;
			this.buttonAddTrip.Click += new System.EventHandler(this.buttonAddTrip_Click);
			// 
			// panelLogo
			// 
			this.panelLogo.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panelLogo.Controls.Add(this.labelLogo);
			this.panelLogo.Controls.Add(this.pictureBoxLogo);
			this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelLogo.Location = new System.Drawing.Point(0, 0);
			this.panelLogo.Name = "panelLogo";
			this.panelLogo.Size = new System.Drawing.Size(240, 224);
			this.panelLogo.TabIndex = 1;
			// 
			// pictureBoxLogo
			// 
			this.pictureBoxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.BackgroundImage")));
			this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBoxLogo.Location = new System.Drawing.Point(40, 51);
			this.pictureBoxLogo.Name = "pictureBoxLogo";
			this.pictureBoxLogo.Size = new System.Drawing.Size(159, 115);
			this.pictureBoxLogo.TabIndex = 0;
			this.pictureBoxLogo.TabStop = false;
			// 
			// panelTitle
			// 
			this.panelTitle.BackColor = System.Drawing.SystemColors.Control;
			this.panelTitle.Controls.Add(this.labelTit);
			this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitle.Location = new System.Drawing.Point(240, 0);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new System.Drawing.Size(1013, 100);
			this.panelTitle.TabIndex = 1;
			// 
			// labelTit
			// 
			this.labelTit.AutoSize = true;
			this.labelTit.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTit.Location = new System.Drawing.Point(41, 35);
			this.labelTit.Name = "labelTit";
			this.labelTit.Size = new System.Drawing.Size(0, 35);
			this.labelTit.TabIndex = 0;
			// 
			// labelTitle
			// 
			this.labelTitle.Location = new System.Drawing.Point(0, 0);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(100, 23);
			this.labelTitle.TabIndex = 0;
			// 
			// panelContent
			// 
			this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelContent.Location = new System.Drawing.Point(240, 100);
			this.panelContent.Name = "panelContent";
			this.panelContent.Size = new System.Drawing.Size(1013, 557);
			this.panelContent.TabIndex = 2;
			// 
			// labelLogo
			// 
			this.labelLogo.AutoSize = true;
			this.labelLogo.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLogo.Location = new System.Drawing.Point(54, 169);
			this.labelLogo.Name = "labelLogo";
			this.labelLogo.Size = new System.Drawing.Size(126, 25);
			this.labelLogo.TabIndex = 1;
			this.labelLogo.Text = "TRAVEL VISION";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(1253, 657);
			this.Controls.Add(this.panelContent);
			this.Controls.Add(this.panelTitle);
			this.Controls.Add(this.panelSidebar);
			this.DoubleBuffered = true;
			this.MaximumSize = new System.Drawing.Size(1271, 704);
			this.MinimumSize = new System.Drawing.Size(1271, 704);
			this.Name = "Form1";
			this.Text = "TRVLVSN";
			this.panelSidebar.ResumeLayout(false);
			this.panelLogo.ResumeLayout(false);
			this.panelLogo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
			this.panelTitle.ResumeLayout(false);
			this.panelTitle.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelSidebar;
		private System.Windows.Forms.Panel panelLogo;
		private System.Windows.Forms.Panel panelTitle;
		private System.Windows.Forms.Button buttonAddTrip;
		private System.Windows.Forms.PictureBox pictureBoxLogo;
		private System.Windows.Forms.Button buttonExt;
		private System.Windows.Forms.Button buttonVisualize;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonModify;
		private System.Windows.Forms.Panel panelContent;
		private System.Windows.Forms.Label labelTit;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Label labelLogo;
	}
}

