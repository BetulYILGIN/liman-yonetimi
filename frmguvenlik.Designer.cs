
namespace LIMAN_YONETIM
{
    partial class frmguvenlik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmguvenlik));
            this.btnguvenlikraporu = new System.Windows.Forms.Button();
            this.btngeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnguvenlikraporu
            // 
            this.btnguvenlikraporu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnguvenlikraporu.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnguvenlikraporu.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnguvenlikraporu.Location = new System.Drawing.Point(323, 206);
            this.btnguvenlikraporu.Name = "btnguvenlikraporu";
            this.btnguvenlikraporu.Size = new System.Drawing.Size(307, 100);
            this.btnguvenlikraporu.TabIndex = 3;
            this.btnguvenlikraporu.Text = "Güvenlik Raporu Oluştur";
            this.btnguvenlikraporu.UseVisualStyleBackColor = true;
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
            this.btngeri.TabIndex = 12;
            this.btngeri.UseVisualStyleBackColor = true;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // frmguvenlik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1005, 601);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.btnguvenlikraporu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmguvenlik";
            this.Text = "GÜVENLİK";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnguvenlikraporu;
        private System.Windows.Forms.Button btngeri;
    }
}