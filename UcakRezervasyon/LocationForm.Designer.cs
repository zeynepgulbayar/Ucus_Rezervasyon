namespace UcakRezervasyon
{
	partial class LocationForm
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			dataGridViewLocations = new DataGridView();
			txtCountry = new TextBox();
			txtCity = new TextBox();
			txtAirport = new TextBox();
			chkIsActive = new CheckBox();
			btnAddLocation = new Button();
			lblCountry = new Label();
			lblCity = new Label();
			lblAirport = new Label();
			lblIsActive = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridViewLocations).BeginInit();
			SuspendLayout();
			// 
			// dataGridViewLocations
			// 
			dataGridViewLocations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewLocations.Location = new Point(12, 12);
			dataGridViewLocations.Name = "dataGridViewLocations";
			dataGridViewLocations.Size = new Size(545, 286);
			dataGridViewLocations.TabIndex = 0;
			// 
			// txtCountry
			// 
			txtCountry.Location = new Point(681, 24);
			txtCountry.Name = "txtCountry";
			txtCountry.Size = new Size(200, 23);
			txtCountry.TabIndex = 1;
			// 
			// txtCity
			// 
			txtCity.Location = new Point(681, 64);
			txtCity.Name = "txtCity";
			txtCity.Size = new Size(200, 23);
			txtCity.TabIndex = 2;
			// 
			// txtAirport
			// 
			txtAirport.Location = new Point(681, 104);
			txtAirport.Name = "txtAirport";
			txtAirport.Size = new Size(200, 23);
			txtAirport.TabIndex = 3;
			// 
			// chkIsActive
			// 
			chkIsActive.AutoSize = true;
			chkIsActive.Location = new Point(681, 145);
			chkIsActive.Name = "chkIsActive";
			chkIsActive.Size = new Size(15, 14);
			chkIsActive.TabIndex = 4;
			chkIsActive.UseVisualStyleBackColor = true;
			// 
			// btnAddLocation
			// 
			btnAddLocation.Location = new Point(759, 202);
			btnAddLocation.Name = "btnAddLocation";
			btnAddLocation.Size = new Size(122, 54);
			btnAddLocation.TabIndex = 5;
			btnAddLocation.Text = "Ekle";
			btnAddLocation.UseVisualStyleBackColor = true;
			btnAddLocation.Click += btnAddLocation_Click;
			// 
			// lblCountry
			// 
			lblCountry.AutoSize = true;
			lblCountry.Location = new Point(601, 24);
			lblCountry.Name = "lblCountry";
			lblCountry.Size = new Size(30, 15);
			lblCountry.TabIndex = 6;
			lblCountry.Text = "Ülke";
			// 
			// lblCity
			// 
			lblCity.AutoSize = true;
			lblCity.Location = new Point(601, 64);
			lblCity.Name = "lblCity";
			lblCity.Size = new Size(33, 15);
			lblCity.TabIndex = 7;
			lblCity.Text = "Şehir";
			// 
			// lblAirport
			// 
			lblAirport.AutoSize = true;
			lblAirport.Location = new Point(601, 104);
			lblAirport.Name = "lblAirport";
			lblAirport.Size = new Size(64, 15);
			lblAirport.TabIndex = 8;
			lblAirport.Text = "Hava Alanı";
			// 
			// lblIsActive
			// 
			lblIsActive.AutoSize = true;
			lblIsActive.Location = new Point(601, 144);
			lblIsActive.Name = "lblIsActive";
			lblIsActive.Size = new Size(32, 15);
			lblIsActive.TabIndex = 9;
			lblIsActive.Text = "Aktif";
			// 
			// LocationForm
			// 
			ClientSize = new Size(949, 384);
			Controls.Add(lblIsActive);
			Controls.Add(lblAirport);
			Controls.Add(lblCity);
			Controls.Add(lblCountry);
			Controls.Add(btnAddLocation);
			Controls.Add(chkIsActive);
			Controls.Add(txtAirport);
			Controls.Add(txtCity);
			Controls.Add(txtCountry);
			Controls.Add(dataGridViewLocations);
			Name = "LocationForm";
			Text = "Location Form";
			((System.ComponentModel.ISupportInitialize)dataGridViewLocations).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		private System.Windows.Forms.DataGridView dataGridViewLocations;
		private System.Windows.Forms.TextBox txtCountry;
		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.TextBox txtAirport;
		private System.Windows.Forms.CheckBox chkIsActive;
		private System.Windows.Forms.Button btnAddLocation;
		private System.Windows.Forms.Label lblCountry;
		private System.Windows.Forms.Label lblCity;
		private System.Windows.Forms.Label lblAirport;
		private System.Windows.Forms.Label lblIsActive;
	}

}