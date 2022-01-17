
namespace HotelManagementApplication
{
    partial class MainMenuForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.panelNavBar = new System.Windows.Forms.Panel();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnFeatures = new System.Windows.Forms.Button();
            this.btnRooms = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnReservations = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.panelNavBar.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNavBar
            // 
            this.panelNavBar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelNavBar.Controls.Add(this.btnCustomers);
            this.panelNavBar.Controls.Add(this.btnFeatures);
            this.panelNavBar.Controls.Add(this.btnRooms);
            this.panelNavBar.Controls.Add(this.btnServices);
            this.panelNavBar.Controls.Add(this.btnReservations);
            this.panelNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavBar.Location = new System.Drawing.Point(0, 0);
            this.panelNavBar.Margin = new System.Windows.Forms.Padding(4);
            this.panelNavBar.Name = "panelNavBar";
            this.panelNavBar.Size = new System.Drawing.Size(750, 50);
            this.panelNavBar.TabIndex = 0;
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCustomers.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCustomers.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomers.Image")));
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.Location = new System.Drawing.Point(600, 0);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCustomers.Size = new System.Drawing.Size(150, 50);
            this.btnCustomers.TabIndex = 4;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnFeatures
            // 
            this.btnFeatures.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFeatures.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFeatures.FlatAppearance.BorderSize = 0;
            this.btnFeatures.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFeatures.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnFeatures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeatures.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFeatures.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFeatures.Image = ((System.Drawing.Image)(resources.GetObject("btnFeatures.Image")));
            this.btnFeatures.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFeatures.Location = new System.Drawing.Point(450, 0);
            this.btnFeatures.Name = "btnFeatures";
            this.btnFeatures.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnFeatures.Size = new System.Drawing.Size(150, 50);
            this.btnFeatures.TabIndex = 2;
            this.btnFeatures.Text = "Features";
            this.btnFeatures.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFeatures.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFeatures.UseVisualStyleBackColor = true;
            this.btnFeatures.Click += new System.EventHandler(this.btnFeatures_Click);
            // 
            // btnRooms
            // 
            this.btnRooms.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRooms.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRooms.FlatAppearance.BorderSize = 0;
            this.btnRooms.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRooms.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRooms.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRooms.Image = ((System.Drawing.Image)(resources.GetObject("btnRooms.Image")));
            this.btnRooms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRooms.Location = new System.Drawing.Point(300, 0);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnRooms.Size = new System.Drawing.Size(150, 50);
            this.btnRooms.TabIndex = 1;
            this.btnRooms.Text = "Rooms";
            this.btnRooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRooms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRooms.UseVisualStyleBackColor = true;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // btnServices
            // 
            this.btnServices.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnServices.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnServices.FlatAppearance.BorderSize = 0;
            this.btnServices.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnServices.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnServices.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnServices.Image = ((System.Drawing.Image)(resources.GetObject("btnServices.Image")));
            this.btnServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServices.Location = new System.Drawing.Point(150, 0);
            this.btnServices.Name = "btnServices";
            this.btnServices.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnServices.Size = new System.Drawing.Size(150, 50);
            this.btnServices.TabIndex = 3;
            this.btnServices.Text = "Services";
            this.btnServices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnServices.UseVisualStyleBackColor = true;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // btnReservations
            // 
            this.btnReservations.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnReservations.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReservations.FlatAppearance.BorderSize = 0;
            this.btnReservations.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReservations.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReservations.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReservations.Image = ((System.Drawing.Image)(resources.GetObject("btnReservations.Image")));
            this.btnReservations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservations.Location = new System.Drawing.Point(0, 0);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnReservations.Size = new System.Drawing.Size(150, 50);
            this.btnReservations.TabIndex = 0;
            this.btnReservations.Text = "Reservations";
            this.btnReservations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReservations.UseVisualStyleBackColor = true;
            this.btnReservations.Click += new System.EventHandler(this.btnReservations_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelChildForm.Controls.Add(this.lblTime);
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 50);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(4);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(750, 450);
            this.panelChildForm.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTime.Location = new System.Drawing.Point(333, 392);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 24);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Time";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(225, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tmrClock
            // 
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelNavBar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(766, 539);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to the Hotel California";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.panelNavBar.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavBar;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Button btnFeatures;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Button btnReservations;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrClock;
    }
}