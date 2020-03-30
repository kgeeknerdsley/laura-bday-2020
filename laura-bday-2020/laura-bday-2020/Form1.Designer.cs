namespace laura_bday_2020
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.parkImageBox = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.objectivePanel = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.parkImageBox)).BeginInit();
			this.panel1.SuspendLayout();
			this.objectivePanel.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// parkImageBox
			// 
			this.parkImageBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.parkImageBox.Location = new System.Drawing.Point(12, 12);
			this.parkImageBox.Name = "parkImageBox";
			this.parkImageBox.Size = new System.Drawing.Size(1049, 431);
			this.parkImageBox.TabIndex = 0;
			this.parkImageBox.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(760, 450);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(300, 250);
			this.panel1.TabIndex = 1;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(91, 183);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(120, 60);
			this.button4.TabIndex = 3;
			this.button4.Text = "button4";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(173, 99);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(120, 60);
			this.button3.TabIndex = 2;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(3, 99);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(120, 60);
			this.button2.TabIndex = 1;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Location = new System.Drawing.Point(91, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 60);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// objectivePanel
			// 
			this.objectivePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("objectivePanel.BackgroundImage")));
			this.objectivePanel.Controls.Add(this.label2);
			this.objectivePanel.Location = new System.Drawing.Point(13, 450);
			this.objectivePanel.Name = "objectivePanel";
			this.objectivePanel.Size = new System.Drawing.Size(300, 250);
			this.objectivePanel.TabIndex = 2;
			// 
			// panel3
			// 
			this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
			this.panel3.Controls.Add(this.label1);
			this.panel3.Location = new System.Drawing.Point(333, 450);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(403, 250);
			this.panel3.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(99, 101);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(174, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Wowee this here is some flavor text";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(48, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(201, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "this will become three pictures eventuallyl";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::laura_bday_2020.Properties.Resources.window_background;
			this.ClientSize = new System.Drawing.Size(1073, 712);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.objectivePanel);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.parkImageBox);
			this.Name = "Form1";
			this.Text = "Laura\'s Disney Tour";
			((System.ComponentModel.ISupportInitialize)(this.parkImageBox)).EndInit();
			this.panel1.ResumeLayout(false);
			this.objectivePanel.ResumeLayout(false);
			this.objectivePanel.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox parkImageBox;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel objectivePanel;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

