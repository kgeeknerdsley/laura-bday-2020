namespace laura_bday_2020
{
	partial class mainWindow
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
			this.parkImageBox = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonBack = new System.Windows.Forms.Button();
			this.buttonRight = new System.Windows.Forms.Button();
			this.buttonLeft = new System.Windows.Forms.Button();
			this.buttonForward = new System.Windows.Forms.Button();
			this.objectivePanel = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.locationLabelFixed = new System.Windows.Forms.Label();
			this.nameLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.parkImageBox)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// parkImageBox
			// 
			this.parkImageBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.parkImageBox.Image = global::laura_bday_2020.Properties.Resources.gates;
			this.parkImageBox.InitialImage = null;
			this.parkImageBox.Location = new System.Drawing.Point(12, 12);
			this.parkImageBox.Name = "parkImageBox";
			this.parkImageBox.Size = new System.Drawing.Size(1049, 431);
			this.parkImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.parkImageBox.TabIndex = 0;
			this.parkImageBox.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = global::laura_bday_2020.Properties.Resources.control_background_green;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.buttonBack);
			this.panel1.Controls.Add(this.buttonRight);
			this.panel1.Controls.Add(this.buttonLeft);
			this.panel1.Controls.Add(this.buttonForward);
			this.panel1.Location = new System.Drawing.Point(760, 450);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(300, 250);
			this.panel1.TabIndex = 1;
			// 
			// buttonBack
			// 
			this.buttonBack.Location = new System.Drawing.Point(91, 165);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(120, 60);
			this.buttonBack.TabIndex = 3;
			this.buttonBack.Text = "Back";
			this.buttonBack.UseVisualStyleBackColor = true;
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// buttonRight
			// 
			this.buttonRight.Location = new System.Drawing.Point(148, 99);
			this.buttonRight.Name = "buttonRight";
			this.buttonRight.Size = new System.Drawing.Size(120, 60);
			this.buttonRight.TabIndex = 2;
			this.buttonRight.Text = "Right";
			this.buttonRight.UseVisualStyleBackColor = true;
			this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
			// 
			// buttonLeft
			// 
			this.buttonLeft.Location = new System.Drawing.Point(22, 99);
			this.buttonLeft.Name = "buttonLeft";
			this.buttonLeft.Size = new System.Drawing.Size(120, 60);
			this.buttonLeft.TabIndex = 1;
			this.buttonLeft.Text = "Left";
			this.buttonLeft.UseVisualStyleBackColor = true;
			this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
			// 
			// buttonForward
			// 
			this.buttonForward.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonForward.Location = new System.Drawing.Point(91, 33);
			this.buttonForward.Name = "buttonForward";
			this.buttonForward.Size = new System.Drawing.Size(120, 60);
			this.buttonForward.TabIndex = 0;
			this.buttonForward.Text = "Forward";
			this.buttonForward.UseVisualStyleBackColor = true;
			this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
			// 
			// objectivePanel
			// 
			this.objectivePanel.BackgroundImage = global::laura_bday_2020.Properties.Resources.control_background_green;
			this.objectivePanel.Location = new System.Drawing.Point(13, 450);
			this.objectivePanel.Name = "objectivePanel";
			this.objectivePanel.Size = new System.Drawing.Size(300, 250);
			this.objectivePanel.TabIndex = 2;
			// 
			// panel3
			// 
			this.panel3.BackgroundImage = global::laura_bday_2020.Properties.Resources.control_background_green;
			this.panel3.Controls.Add(this.nameLabel);
			this.panel3.Controls.Add(this.locationLabelFixed);
			this.panel3.Location = new System.Drawing.Point(333, 450);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(403, 250);
			this.panel3.TabIndex = 3;
			// 
			// locationLabelFixed
			// 
			this.locationLabelFixed.AutoSize = true;
			this.locationLabelFixed.BackColor = System.Drawing.Color.Transparent;
			this.locationLabelFixed.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.locationLabelFixed.Location = new System.Drawing.Point(12, 13);
			this.locationLabelFixed.Name = "locationLabelFixed";
			this.locationLabelFixed.Size = new System.Drawing.Size(162, 22);
			this.locationLabelFixed.TabIndex = 0;
			this.locationLabelFixed.Text = "Location";
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(174, 39);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(35, 13);
			this.nameLabel.TabIndex = 1;
			this.nameLabel.Text = "label1";
			// 
			// mainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::laura_bday_2020.Properties.Resources.window_background;
			this.ClientSize = new System.Drawing.Size(1073, 712);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.objectivePanel);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.parkImageBox);
			this.Name = "mainWindow";
			this.Text = "Laura\'s Disney Tour";
			((System.ComponentModel.ISupportInitialize)(this.parkImageBox)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox parkImageBox;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonBack;
		private System.Windows.Forms.Button buttonRight;
		private System.Windows.Forms.Button buttonLeft;
		private System.Windows.Forms.Button buttonForward;
		private System.Windows.Forms.Panel objectivePanel;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label locationLabelFixed;
		private System.Windows.Forms.Label nameLabel;
	}
}

