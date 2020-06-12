namespace _1
{
    partial class Form3
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.InfoLabel = new MetroFramework.Controls.MetroLabel();
            this.InfoTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(199, 209);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Ok";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.InfoLabel.Location = new System.Drawing.Point(23, 31);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(43, 19);
            this.InfoLabel.Style = MetroFramework.MetroColorStyle.Purple;
            this.InfoLabel.TabIndex = 4;
            this.InfoLabel.Text = "Error";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.InfoLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.InfoLabel.UseStyleColors = true;
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.Location = new System.Drawing.Point(23, 70);
            this.InfoTextBox.Multiline = true;
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.Size = new System.Drawing.Size(418, 133);
            this.InfoTextBox.TabIndex = 5;
            this.InfoTextBox.Text = "Wrong Login or Password ";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 255);
            this.ControlBox = false;
            this.Controls.Add(this.InfoTextBox);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.metroButton1);
            this.Name = "Form3";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel InfoLabel;
        private MetroFramework.Controls.MetroTextBox InfoTextBox;
    }
}