
namespace LIMAN_YONETIM
{
    partial class frmgiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmgiris));
            this.btnyntc = new System.Windows.Forms.Button();
            this.btnprsnl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnyntc
            // 
            this.btnyntc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnyntc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnyntc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnyntc.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnyntc.ForeColor = System.Drawing.Color.Navy;
            this.btnyntc.Location = new System.Drawing.Point(200, 306);
            this.btnyntc.Name = "btnyntc";
            this.btnyntc.Size = new System.Drawing.Size(224, 77);
            this.btnyntc.TabIndex = 0;
            this.btnyntc.Text = "YÖNETİCİ GİRİŞİ";
            this.btnyntc.UseVisualStyleBackColor = false;
            this.btnyntc.Click += new System.EventHandler(this.btnyntc_Click);
            // 
            // btnprsnl
            // 
            this.btnprsnl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnprsnl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnprsnl.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnprsnl.ForeColor = System.Drawing.Color.Navy;
            this.btnprsnl.Location = new System.Drawing.Point(522, 306);
            this.btnprsnl.Name = "btnprsnl";
            this.btnprsnl.Size = new System.Drawing.Size(224, 77);
            this.btnprsnl.TabIndex = 1;
            this.btnprsnl.Text = "PERSONEL GİRİŞİ";
            this.btnprsnl.UseVisualStyleBackColor = false;
            this.btnprsnl.Click += new System.EventHandler(this.btnprsnl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(145, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(687, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "LİMAN YÖNETİM SİSTEMİ ";
            // 
            // frmgiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1001, 599);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnprsnl);
            this.Controls.Add(this.btnyntc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmgiris";
            this.Text = "LİMAN YÖNETİM SİSTEMİ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnyntc;
        private System.Windows.Forms.Button btnprsnl;
        private System.Windows.Forms.Label label1;
    }
}

