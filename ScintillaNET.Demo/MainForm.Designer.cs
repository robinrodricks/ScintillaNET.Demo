namespace ScintillaNET.Demo {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.TextPanel = new System.Windows.Forms.Panel();
			this.FileName = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// TextPanel
			// 
			this.TextPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TextPanel.Location = new System.Drawing.Point(8, 64);
			this.TextPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.TextPanel.Name = "TextPanel";
			this.TextPanel.Size = new System.Drawing.Size(744, 550);
			this.TextPanel.TabIndex = 0;
			// 
			// FileName
			// 
			this.FileName.AutoSize = true;
			this.FileName.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FileName.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.FileName.Location = new System.Drawing.Point(12, 9);
			this.FileName.Name = "FileName";
			this.FileName.Size = new System.Drawing.Size(65, 38);
			this.FileName.TabIndex = 1;
			this.FileName.Text = "Title";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(769, 628);
			this.Controls.Add(this.FileName);
			this.Controls.Add(this.TextPanel);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "MainForm";
			this.Text = "ScintillaNET Demo App";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel TextPanel;
		private System.Windows.Forms.Label FileName;
	}
}

