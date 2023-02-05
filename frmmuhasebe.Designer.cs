
namespace LIMAN_YONETIM
{
    partial class frmmuhasebe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmuhasebe));
            this.btnhizmetucreti = new System.Windows.Forms.Button();
            this.btnyoneticigirisi = new System.Windows.Forms.Button();
            this.btngeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnhizmetucreti
            // 
            this.btnhizmetucreti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnhizmetucreti.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnhizmetucreti.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnhizmetucreti.Location = new System.Drawing.Point(334, 158);
            this.btnhizmetucreti.Name = "btnhizmetucreti";
            this.btnhizmetucreti.Size = new System.Drawing.Size(307, 100);
            this.btnhizmetucreti.TabIndex = 2;
            this.btnhizmetucreti.Text = "Hizmet Ücreti Görüntüle";
            this.btnhizmetucreti.UseVisualStyleBackColor = true;
            this.btnhizmetucreti.Click += new System.EventHandler(this.btnbislem_Click);
            // 
            // btnyoneticigirisi
            // 
            this.btnyoneticigirisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnyoneticigirisi.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnyoneticigirisi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnyoneticigirisi.Location = new System.Drawing.Point(334, 296);
            this.btnyoneticigirisi.Name = "btnyoneticigirisi";
            this.btnyoneticigirisi.Size = new System.Drawing.Size(307, 100);
            this.btnyoneticigirisi.TabIndex = 3;
            this.btnyoneticigirisi.Text = "Yönetici Girişi";
            this.btnyoneticigirisi.UseVisualStyleBackColor = true;
            // 
            // btngeri
            // 
            this.btngeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btngeri.BackgroundImage")));
            this.btngeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngeri.FlatAppearance.BorderSize = 0;
            this.btngeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngeri.Location = new System.Drawing.Point(12, 12);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(25, 25);
            this.btngeri.TabIndex = 13;
            this.btngeri.UseVisualStyleBackColor = true;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // frmmuhasebe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1003, 600);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.btnyoneticigirisi);
            this.Controls.Add(this.btnhizmetucreti);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmmuhasebe";
            this.Text = "MUHASEBE";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnhizmetucreti;
        private System.Windows.Forms.Button btnyoneticigirisi;
        private System.Windows.Forms.Button btngeri;
    }
}