namespace KD
{
    partial class KD_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KD_Menu));
            this.btn_New_Awaria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_New_Awaria
            // 
            this.btn_New_Awaria.Image = global::KD.Properties.Resources.Files_New_File_icon;
            this.btn_New_Awaria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_New_Awaria.Location = new System.Drawing.Point(70, 72);
            this.btn_New_Awaria.Name = "btn_New_Awaria";
            this.btn_New_Awaria.Size = new System.Drawing.Size(141, 50);
            this.btn_New_Awaria.TabIndex = 0;
            this.btn_New_Awaria.Text = "Nowa Awaria";
            this.btn_New_Awaria.UseVisualStyleBackColor = true;
            this.btn_New_Awaria.Click += new System.EventHandler(this.button1_Click);
            // 
            // KD_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_New_Awaria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KD_Menu";
            this.Text = "Książka Dyspozytora - Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_New_Awaria;
    }
}