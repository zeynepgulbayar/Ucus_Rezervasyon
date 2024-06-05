namespace UcakRezervasyon
{
	partial class MainForm
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
			this.btnAircraftForm = new System.Windows.Forms.Button();
			this.btnLocationForm = new System.Windows.Forms.Button();
			this.btnReservationForm = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnAircraftForm
			// 
			this.btnAircraftForm.Location = new System.Drawing.Point(12, 12);
			this.btnAircraftForm.Name = "btnAircraftForm";
			this.btnAircraftForm.Size = new System.Drawing.Size(200, 50);
			this.btnAircraftForm.TabIndex = 0;
			this.btnAircraftForm.Text = "Aircraft Form";
			this.btnAircraftForm.UseVisualStyleBackColor = true;
			this.btnAircraftForm.Click += new System.EventHandler(this.btnAircraftForm_Click);
			// 
			// btnLocationForm
			// 
			this.btnLocationForm.Location = new System.Drawing.Point(12, 80);
			this.btnLocationForm.Name = "btnLocationForm";
			this.btnLocationForm.Size = new System.Drawing.Size(200, 50);
			this.btnLocationForm.TabIndex = 1;
			this.btnLocationForm.Text = "Location Form";
			this.btnLocationForm.UseVisualStyleBackColor = true;
			this.btnLocationForm.Click += new System.EventHandler(this.btnLocationForm_Click);
			// 
			// btnReservationForm
			// 
			this.btnReservationForm.Location = new System.Drawing.Point(12, 150);
			this.btnReservationForm.Name = "btnReservationForm";
			this.btnReservationForm.Size = new System.Drawing.Size(200, 50);
			this.btnReservationForm.TabIndex = 2;
			this.btnReservationForm.Text = "Reservation Form";
			this.btnReservationForm.UseVisualStyleBackColor = true;
			this.btnReservationForm.Click += new System.EventHandler(this.btnReservationForm_Click);
			// 
			// MainForm
			// 
			this.ClientSize = new System.Drawing.Size(224, 211);
			this.Controls.Add(this.btnReservationForm);
			this.Controls.Add(this.btnLocationForm);
			this.Controls.Add(this.btnAircraftForm);
			this.Name = "MainForm";
			this.Text = "Main Form";
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.Button btnAircraftForm;
		private System.Windows.Forms.Button btnLocationForm;
		private System.Windows.Forms.Button btnReservationForm;
	}

}

