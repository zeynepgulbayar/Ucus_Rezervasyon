namespace UcakRezervasyon
{
	partial class Form
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
			btnAircraft = new Button();
			btnLocation = new Button();
			btnReservation = new Button();
			SuspendLayout();
			// 
			// btnAircraft
			// 
			btnAircraft.Location = new Point(12, 64);
			btnAircraft.Name = "btnAircraft";
			btnAircraft.Size = new Size(130, 52);
			btnAircraft.TabIndex = 0;
			btnAircraft.Text = "Uçak";
			btnAircraft.UseVisualStyleBackColor = true;
			btnAircraft.Click += btnAircraft_Click;
			// 
			// btnLocation
			// 
			btnLocation.Location = new Point(148, 64);
			btnLocation.Name = "btnLocation";
			btnLocation.Size = new Size(130, 52);
			btnLocation.TabIndex = 1;
			btnLocation.Text = "Lokasyon";
			btnLocation.UseVisualStyleBackColor = true;
			btnLocation.Click += btnLocation_Click;
			// 
			// btnReservation
			// 
			btnReservation.Location = new Point(284, 64);
			btnReservation.Name = "btnReservation";
			btnReservation.Size = new Size(130, 52);
			btnReservation.TabIndex = 2;
			btnReservation.Text = "Rezervasyon";
			btnReservation.UseVisualStyleBackColor = true;
			btnReservation.Click += btnReservation_Click;
			// 
			// Form
			// 
			ClientSize = new Size(426, 239);
			Controls.Add(btnReservation);
			Controls.Add(btnLocation);
			Controls.Add(btnAircraft);
			Name = "Form";
			Text = "Main Form";
			Load += MainForm_Load;
			ResumeLayout(false);
		}

		private System.Windows.Forms.Button btnAircraft;
		private System.Windows.Forms.Button btnLocation;
		private System.Windows.Forms.Button btnReservation;
	}
}
