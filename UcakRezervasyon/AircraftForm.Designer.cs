namespace UcakRezervasyon
{
	partial class AircraftForm
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
			dataGridViewAircrafts = new DataGridView();
			txtModel = new TextBox();
			txtBrand = new TextBox();
			txtSerialNumber = new TextBox();
			txtSeatCapacity = new TextBox();
			btnAddAircraft = new Button();
			lblModel = new Label();
			lblBrand = new Label();
			lblSerialNumber = new Label();
			lblSeatCapacity = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridViewAircrafts).BeginInit();
			SuspendLayout();
			// 
			// dataGridViewAircrafts
			// 
			dataGridViewAircrafts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewAircrafts.Location = new Point(12, 12);
			dataGridViewAircrafts.Name = "dataGridViewAircrafts";
			dataGridViewAircrafts.Size = new Size(517, 264);
			dataGridViewAircrafts.TabIndex = 0;
			// 
			// txtModel
			// 
			txtModel.Location = new Point(694, 34);
			txtModel.Name = "txtModel";
			txtModel.Size = new Size(200, 23);
			txtModel.TabIndex = 1;
			// 
			// txtBrand
			// 
			txtBrand.Location = new Point(694, 74);
			txtBrand.Name = "txtBrand";
			txtBrand.Size = new Size(200, 23);
			txtBrand.TabIndex = 2;
			// 
			// txtSerialNumber
			// 
			txtSerialNumber.Location = new Point(694, 114);
			txtSerialNumber.Name = "txtSerialNumber";
			txtSerialNumber.Size = new Size(200, 23);
			txtSerialNumber.TabIndex = 3;
			// 
			// txtSeatCapacity
			// 
			txtSeatCapacity.Location = new Point(694, 154);
			txtSeatCapacity.Name = "txtSeatCapacity";
			txtSeatCapacity.Size = new Size(200, 23);
			txtSeatCapacity.TabIndex = 4;
			// 
			// btnAddAircraft
			// 
			btnAddAircraft.Location = new Point(773, 213);
			btnAddAircraft.Name = "btnAddAircraft";
			btnAddAircraft.Size = new Size(121, 39);
			btnAddAircraft.TabIndex = 5;
			btnAddAircraft.Text = "Ekle";
			btnAddAircraft.UseVisualStyleBackColor = true;
			btnAddAircraft.Click += btnAddAircraft_Click;
			// 
			// lblModel
			// 
			lblModel.AutoSize = true;
			lblModel.Location = new Point(614, 42);
			lblModel.Name = "lblModel";
			lblModel.Size = new Size(41, 15);
			lblModel.TabIndex = 6;
			lblModel.Text = "Model";
			// 
			// lblBrand
			// 
			lblBrand.AutoSize = true;
			lblBrand.Location = new Point(614, 82);
			lblBrand.Name = "lblBrand";
			lblBrand.Size = new Size(40, 15);
			lblBrand.TabIndex = 7;
			lblBrand.Text = "Marka";
			// 
			// lblSerialNumber
			// 
			lblSerialNumber.AutoSize = true;
			lblSerialNumber.Location = new Point(614, 122);
			lblSerialNumber.Name = "lblSerialNumber";
			lblSerialNumber.Size = new Size(43, 15);
			lblSerialNumber.TabIndex = 8;
			lblSerialNumber.Text = "Seri no";
			// 
			// lblSeatCapacity
			// 
			lblSeatCapacity.AutoSize = true;
			lblSeatCapacity.Location = new Point(614, 162);
			lblSeatCapacity.Name = "lblSeatCapacity";
			lblSeatCapacity.Size = new Size(51, 15);
			lblSeatCapacity.TabIndex = 9;
			lblSeatCapacity.Text = "Kapasite";
			// 
			// AircraftForm
			// 
			ClientSize = new Size(979, 342);
			Controls.Add(lblSeatCapacity);
			Controls.Add(lblSerialNumber);
			Controls.Add(lblBrand);
			Controls.Add(lblModel);
			Controls.Add(btnAddAircraft);
			Controls.Add(txtSeatCapacity);
			Controls.Add(txtSerialNumber);
			Controls.Add(txtBrand);
			Controls.Add(txtModel);
			Controls.Add(dataGridViewAircrafts);
			Name = "AircraftForm";
			Text = "Aircraft Form";
			((System.ComponentModel.ISupportInitialize)dataGridViewAircrafts).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		private System.Windows.Forms.DataGridView dataGridViewAircrafts;
		private System.Windows.Forms.TextBox txtModel;
		private System.Windows.Forms.TextBox txtBrand;
		private System.Windows.Forms.TextBox txtSerialNumber;
		private System.Windows.Forms.TextBox txtSeatCapacity;
		private System.Windows.Forms.Button btnAddAircraft;
		private System.Windows.Forms.Label lblModel;
		private System.Windows.Forms.Label lblBrand;
		private System.Windows.Forms.Label lblSerialNumber;
		private System.Windows.Forms.Label lblSeatCapacity;
	}

}