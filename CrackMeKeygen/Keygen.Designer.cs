namespace CrackMeKeygen
{
    partial class Keygen
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxKey = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.Location = new System.Drawing.Point(23, 63);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(305, 76);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Generate Key";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroTextBoxKey
            // 
            // 
            // 
            // 
            this.metroTextBoxKey.CustomButton.Image = null;
            this.metroTextBoxKey.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.metroTextBoxKey.CustomButton.Name = "";
            this.metroTextBoxKey.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxKey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxKey.CustomButton.TabIndex = 1;
            this.metroTextBoxKey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxKey.CustomButton.UseSelectable = true;
            this.metroTextBoxKey.CustomButton.Visible = false;
            this.metroTextBoxKey.Lines = new string[0];
            this.metroTextBoxKey.Location = new System.Drawing.Point(23, 145);
            this.metroTextBoxKey.MaxLength = 32767;
            this.metroTextBoxKey.Name = "metroTextBoxKey";
            this.metroTextBoxKey.PasswordChar = '\0';
            this.metroTextBoxKey.ReadOnly = true;
            this.metroTextBoxKey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxKey.SelectedText = "";
            this.metroTextBoxKey.SelectionLength = 0;
            this.metroTextBoxKey.SelectionStart = 0;
            this.metroTextBoxKey.ShortcutsEnabled = true;
            this.metroTextBoxKey.Size = new System.Drawing.Size(305, 23);
            this.metroTextBoxKey.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBoxKey.TabIndex = 1;
            this.metroTextBoxKey.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxKey.UseSelectable = true;
            this.metroTextBoxKey.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxKey.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Keygen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 188);
            this.Controls.Add(this.metroTextBoxKey);
            this.Controls.Add(this.metroButton1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Keygen";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "CrackMe Keygen";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Keygen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxKey;
    }
}

