
namespace LIMAN_YONETIM
{
    partial class frmcalisan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcalisan));
            this.btnbislem = new System.Windows.Forms.Button();
            this.btnmuhasebe = new System.Windows.Forms.Button();
            this.btnburo = new System.Windows.Forms.Button();
            this.btnguvenlik = new System.Windows.Forms.Button();
            this.btngeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnbislem
            // 
            this.btnbislem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbislem.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnbislem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnbislem.Location = new System.Drawing.Point(183, 195);
            this.btnbislem.Name = "btnbislem";
            this.btnbislem.Size = new System.Drawing.Size(208, 100);
            this.btnbislem.TabIndex = 0;
            this.btnbislem.Text = "BİLGİ İŞLEM";
            this.btnbislem.UseVisualStyleBackColor = true;
            this.btnbislem.Click += new System.EventHandler(this.btnbislem_Click);
            // 
            // btnmuhasebe
            // 
            this.btnmuhasebe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmuhasebe.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnmuhasebe.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnmuhasebe.Location = new System.Drawing.Point(569, 195);
            this.btnmuhasebe.Name = "btnmuhasebe";
            this.btnmuhasebe.Size = new System.Drawing.Size(208, 100);
            this.btnmuhasebe.TabIndex = 1;
            this.btnmuhasebe.Text = "MUHASEBE";
            this.btnmuhasebe.UseVisualStyleBackColor = true;
            this.btnmuhasebe.Click += new System.EventHandler(this.btnmuhasebe_Click);
            // 
            // btnburo
            // 
            this.btnburo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnburo.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnburo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnburo.Location = new System.Drawing.Point(183, 340);
            this.btnburo.Name = "btnburo";
            this.btnburo.Size = new System.Drawing.Size(208, 100);
            this.btnburo.TabIndex = 2;
            this.btnburo.Text = "BÜRO";
            this.btnburo.UseVisualStyleBackColor = true;
            this.btnburo.Click += new System.EventHandler(this.btnburo_Click);
            // 
            // btnguvenlik
            // 
            this.btnguvenlik.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnguvenlik.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnguvenlik.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnguvenlik.Location = new System.Drawing.Point(569, 340);
            this.btnguvenlik.Name = "btnguvenlik";
            this.btnguvenlik.Size = new System.Drawing.Size(208, 100);
            this.btnguvenlik.TabIndex = 3;
            this.btnguvenlik.Text = "GÜVENLİK";
            this.btnguvenlik.UseVisualStyleBackColor = true;
            this.btnguvenlik.Click += new System.EventHandler(this.btnguvenlik_Click);
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
            this.btngeri.TabIndex = 10;
            this.btngeri.UseVisualStyleBackColor = true;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // frmcalisan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1002, 602);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.btnguvenlik);
            this.Controls.Add(this.btnburo);
            this.Controls.Add(this.btnmuhasebe);
            this.Controls.Add(this.btnbislem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmcalisan";
            this.Text = "ÇALIŞAN GİRİŞİ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnbislem;
        private System.Windows.Forms.Button btnmuhasebe;
        private System.Windows.Forms.Button btnburo;
        private System.Windows.Forms.Button btnguvenlik;
        private System.Windows.Forms.Button btngeri;
    }
}