
namespace TcKontrolUret
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
            this.btnTcUret = new System.Windows.Forms.Button();
            this.txtYeniTc = new System.Windows.Forms.TextBox();
            this.txtDogrulanacakTc = new System.Windows.Forms.TextBox();
            this.btnTcDogrula = new System.Windows.Forms.Button();
            this.lblGecerliMi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTcUret
            // 
            this.btnTcUret.Location = new System.Drawing.Point(35, 23);
            this.btnTcUret.Name = "btnTcUret";
            this.btnTcUret.Size = new System.Drawing.Size(75, 23);
            this.btnTcUret.TabIndex = 0;
            this.btnTcUret.Text = "Tc Üret";
            this.btnTcUret.UseVisualStyleBackColor = true;
            this.btnTcUret.Click += new System.EventHandler(this.btnTcUret_Click);
            // 
            // txtYeniTc
            // 
            this.txtYeniTc.Location = new System.Drawing.Point(143, 25);
            this.txtYeniTc.Name = "txtYeniTc";
            this.txtYeniTc.ReadOnly = true;
            this.txtYeniTc.Size = new System.Drawing.Size(100, 20);
            this.txtYeniTc.TabIndex = 1;
            // 
            // txtDogrulanacakTc
            // 
            this.txtDogrulanacakTc.Location = new System.Drawing.Point(35, 76);
            this.txtDogrulanacakTc.Name = "txtDogrulanacakTc";
            this.txtDogrulanacakTc.Size = new System.Drawing.Size(100, 20);
            this.txtDogrulanacakTc.TabIndex = 3;
            // 
            // btnTcDogrula
            // 
            this.btnTcDogrula.Location = new System.Drawing.Point(168, 74);
            this.btnTcDogrula.Name = "btnTcDogrula";
            this.btnTcDogrula.Size = new System.Drawing.Size(75, 23);
            this.btnTcDogrula.TabIndex = 2;
            this.btnTcDogrula.Text = "Tc Doğrula";
            this.btnTcDogrula.UseVisualStyleBackColor = true;
            this.btnTcDogrula.Click += new System.EventHandler(this.btnTcDogrula_Click);
            // 
            // lblGecerliMi
            // 
            this.lblGecerliMi.AutoSize = true;
            this.lblGecerliMi.Location = new System.Drawing.Point(49, 108);
            this.lblGecerliMi.Name = "lblGecerliMi";
            this.lblGecerliMi.Size = new System.Drawing.Size(86, 13);
            this.lblGecerliMi.TabIndex = 4;
            this.lblGecerliMi.Text = "Geçerli/Geçersiz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 144);
            this.Controls.Add(this.lblGecerliMi);
            this.Controls.Add(this.txtDogrulanacakTc);
            this.Controls.Add(this.btnTcDogrula);
            this.Controls.Add(this.txtYeniTc);
            this.Controls.Add(this.btnTcUret);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTcUret;
        private System.Windows.Forms.TextBox txtYeniTc;
        private System.Windows.Forms.TextBox txtDogrulanacakTc;
        private System.Windows.Forms.Button btnTcDogrula;
        private System.Windows.Forms.Label lblGecerliMi;
    }
}

