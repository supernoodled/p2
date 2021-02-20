namespace p2 {
	partial class Form1 {
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
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.go = new MetroFramework.Controls.MetroButton();
			this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
			this.lower = new MetroFramework.Controls.MetroRadioButton();
			this.input = new MetroFramework.Controls.MetroTextBox();
			this.output = new MetroFramework.Controls.MetroTextBox();
			this.higher = new MetroFramework.Controls.MetroRadioButton();
			((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
			this.SuspendLayout();
			// 
			// go
			// 
			this.go.Highlight = true;
			this.go.Location = new System.Drawing.Point(144, 63);
			this.go.Name = "go";
			this.go.Size = new System.Drawing.Size(83, 45);
			this.go.Style = MetroFramework.MetroColorStyle.Orange;
			this.go.TabIndex = 1;
			this.go.Text = "go";
			this.go.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.go.UseSelectable = true;
			this.go.Click += new System.EventHandler(this.metroButton1_Click);
			// 
			// metroStyleManager1
			// 
			this.metroStyleManager1.Owner = this;
			this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Orange;
			this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// lower
			// 
			this.lower.AutoSize = true;
			this.lower.Location = new System.Drawing.Point(23, 63);
			this.lower.Name = "lower";
			this.lower.Size = new System.Drawing.Size(52, 15);
			this.lower.Style = MetroFramework.MetroColorStyle.Orange;
			this.lower.TabIndex = 2;
			this.lower.Text = "lower";
			this.lower.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.lower.UseSelectable = true;
			// 
			// input
			// 
			// 
			// 
			// 
			this.input.CustomButton.Image = null;
			this.input.CustomButton.Location = new System.Drawing.Point(93, 2);
			this.input.CustomButton.Name = "";
			this.input.CustomButton.Size = new System.Drawing.Size(19, 19);
			this.input.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.input.CustomButton.TabIndex = 1;
			this.input.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.input.CustomButton.UseSelectable = true;
			this.input.CustomButton.Visible = false;
			this.input.Lines = new string[0];
			this.input.Location = new System.Drawing.Point(23, 84);
			this.input.MaxLength = 5;
			this.input.Name = "input";
			this.input.PasswordChar = '\0';
			this.input.PromptText = "input - 5 digits max";
			this.input.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.input.SelectedText = "";
			this.input.SelectionLength = 0;
			this.input.SelectionStart = 0;
			this.input.ShortcutsEnabled = true;
			this.input.Size = new System.Drawing.Size(115, 24);
			this.input.Style = MetroFramework.MetroColorStyle.Orange;
			this.input.TabIndex = 0;
			this.input.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.input.UseSelectable = true;
			this.input.WaterMark = "input - 5 digits max";
			this.input.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.input.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// output
			// 
			// 
			// 
			// 
			this.output.CustomButton.Image = null;
			this.output.CustomButton.Location = new System.Drawing.Point(92, 1);
			this.output.CustomButton.Name = "";
			this.output.CustomButton.Size = new System.Drawing.Size(111, 111);
			this.output.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.output.CustomButton.TabIndex = 1;
			this.output.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.output.CustomButton.UseSelectable = true;
			this.output.CustomButton.Visible = false;
			this.output.Lines = new string[0];
			this.output.Location = new System.Drawing.Point(23, 114);
			this.output.MaxLength = 32767;
			this.output.Multiline = true;
			this.output.Name = "output";
			this.output.PasswordChar = '\0';
			this.output.PromptText = "output - upto 16 numbers";
			this.output.ReadOnly = true;
			this.output.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.output.SelectedText = "";
			this.output.SelectionLength = 0;
			this.output.SelectionStart = 0;
			this.output.ShortcutsEnabled = true;
			this.output.Size = new System.Drawing.Size(204, 113);
			this.output.Style = MetroFramework.MetroColorStyle.Orange;
			this.output.TabIndex = 4;
			this.output.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.output.UseSelectable = true;
			this.output.WaterMark = "output - upto 16 numbers";
			this.output.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.output.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// higher
			// 
			this.higher.AutoSize = true;
			this.higher.Location = new System.Drawing.Point(81, 63);
			this.higher.Name = "higher";
			this.higher.Size = new System.Drawing.Size(57, 15);
			this.higher.Style = MetroFramework.MetroColorStyle.Orange;
			this.higher.TabIndex = 3;
			this.higher.Text = "higher";
			this.higher.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.higher.UseSelectable = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
			this.ClientSize = new System.Drawing.Size(250, 250);
			this.Controls.Add(this.higher);
			this.Controls.Add(this.output);
			this.Controls.Add(this.input);
			this.Controls.Add(this.lower);
			this.Controls.Add(this.go);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.ShowIcon = false;
			this.Style = MetroFramework.MetroColorStyle.Orange;
			this.Text = "p2";
			this.Theme = MetroFramework.MetroThemeStyle.Dark;
			((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public MetroFramework.Controls.MetroButton go;
		public MetroFramework.Components.MetroStyleManager metroStyleManager1;
		public MetroFramework.Controls.MetroRadioButton higher;
		public MetroFramework.Controls.MetroTextBox output;
		public MetroFramework.Controls.MetroTextBox input;
		public MetroFramework.Controls.MetroRadioButton lower;
	}
}

