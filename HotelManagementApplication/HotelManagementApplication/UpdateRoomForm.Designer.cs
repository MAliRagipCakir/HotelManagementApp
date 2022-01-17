
namespace HotelManagementApplication
{
    partial class UpdateRoomForm
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
            this.nudPricePerDay = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudCapacity = new System.Windows.Forms.NumericUpDown();
            this.txtSearchAll = new MetroFramework.Controls.MetroTextBox();
            this.btnRemoveFeature = new System.Windows.Forms.Button();
            this.btnAddFeature = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearchRoom = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvRoomFeatures = new System.Windows.Forms.DataGridView();
            this.btnUpdateRoom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRoomName = new MetroFramework.Controls.MetroTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAllFeatures = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudPricePerDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomFeatures)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllFeatures)).BeginInit();
            this.SuspendLayout();
            // 
            // nudPricePerDay
            // 
            this.nudPricePerDay.DecimalPlaces = 2;
            this.nudPricePerDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudPricePerDay.Location = new System.Drawing.Point(127, 98);
            this.nudPricePerDay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPricePerDay.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudPricePerDay.Name = "nudPricePerDay";
            this.nudPricePerDay.Size = new System.Drawing.Size(131, 29);
            this.nudPricePerDay.TabIndex = 39;
            this.nudPricePerDay.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(26, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Capacity";
            // 
            // nudCapacity
            // 
            this.nudCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudCapacity.Location = new System.Drawing.Point(127, 63);
            this.nudCapacity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCapacity.Name = "nudCapacity";
            this.nudCapacity.Size = new System.Drawing.Size(131, 29);
            this.nudCapacity.TabIndex = 36;
            this.nudCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtSearchAll
            // 
            // 
            // 
            // 
            this.txtSearchAll.CustomButton.Image = null;
            this.txtSearchAll.CustomButton.Location = new System.Drawing.Point(132, 2);
            this.txtSearchAll.CustomButton.Name = "";
            this.txtSearchAll.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtSearchAll.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchAll.CustomButton.TabIndex = 1;
            this.txtSearchAll.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchAll.CustomButton.UseSelectable = true;
            this.txtSearchAll.CustomButton.Visible = false;
            this.txtSearchAll.Lines = new string[0];
            this.txtSearchAll.Location = new System.Drawing.Point(425, 12);
            this.txtSearchAll.MaxLength = 32767;
            this.txtSearchAll.Name = "txtSearchAll";
            this.txtSearchAll.PasswordChar = '\0';
            this.txtSearchAll.PromptText = "Search by Feature Name";
            this.txtSearchAll.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchAll.SelectedText = "";
            this.txtSearchAll.SelectionLength = 0;
            this.txtSearchAll.SelectionStart = 0;
            this.txtSearchAll.ShortcutsEnabled = true;
            this.txtSearchAll.Size = new System.Drawing.Size(160, 30);
            this.txtSearchAll.TabIndex = 56;
            this.txtSearchAll.UseSelectable = true;
            this.txtSearchAll.WaterMark = "Search by Feature Name";
            this.txtSearchAll.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchAll.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchAll.TextChanged += new System.EventHandler(this.txtSearchAll_TextChanged);
            // 
            // btnRemoveFeature
            // 
            this.btnRemoveFeature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveFeature.BackColor = System.Drawing.Color.Red;
            this.btnRemoveFeature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFeature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveFeature.Location = new System.Drawing.Point(591, 271);
            this.btnRemoveFeature.Name = "btnRemoveFeature";
            this.btnRemoveFeature.Size = new System.Drawing.Size(84, 52);
            this.btnRemoveFeature.TabIndex = 55;
            this.btnRemoveFeature.Text = "Remove Feature";
            this.btnRemoveFeature.UseVisualStyleBackColor = false;
            this.btnRemoveFeature.Click += new System.EventHandler(this.btnRemoveFeature_Click);
            // 
            // btnAddFeature
            // 
            this.btnAddFeature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFeature.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAddFeature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFeature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddFeature.Location = new System.Drawing.Point(591, 48);
            this.btnAddFeature.Name = "btnAddFeature";
            this.btnAddFeature.Size = new System.Drawing.Size(84, 52);
            this.btnAddFeature.TabIndex = 54;
            this.btnAddFeature.Text = "Add Feature";
            this.btnAddFeature.UseVisualStyleBackColor = false;
            this.btnAddFeature.Click += new System.EventHandler(this.btnAddFeature_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(26, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Price Per Day";
            // 
            // txtSearchRoom
            // 
            // 
            // 
            // 
            this.txtSearchRoom.CustomButton.Image = null;
            this.txtSearchRoom.CustomButton.Location = new System.Drawing.Point(132, 2);
            this.txtSearchRoom.CustomButton.Name = "";
            this.txtSearchRoom.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtSearchRoom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchRoom.CustomButton.TabIndex = 1;
            this.txtSearchRoom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchRoom.CustomButton.UseSelectable = true;
            this.txtSearchRoom.CustomButton.Visible = false;
            this.txtSearchRoom.Lines = new string[0];
            this.txtSearchRoom.Location = new System.Drawing.Point(425, 235);
            this.txtSearchRoom.MaxLength = 32767;
            this.txtSearchRoom.Name = "txtSearchRoom";
            this.txtSearchRoom.PasswordChar = '\0';
            this.txtSearchRoom.PromptText = "Search by Feature Name";
            this.txtSearchRoom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchRoom.SelectedText = "";
            this.txtSearchRoom.SelectionLength = 0;
            this.txtSearchRoom.SelectionStart = 0;
            this.txtSearchRoom.ShortcutsEnabled = true;
            this.txtSearchRoom.Size = new System.Drawing.Size(160, 30);
            this.txtSearchRoom.TabIndex = 53;
            this.txtSearchRoom.UseSelectable = true;
            this.txtSearchRoom.WaterMark = "Search by Feature Name";
            this.txtSearchRoom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchRoom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchRoom.TextChanged += new System.EventHandler(this.txtSearchRoom_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(290, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "Room\'s Features";
            // 
            // dgvRoomFeatures
            // 
            this.dgvRoomFeatures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRoomFeatures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomFeatures.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRoomFeatures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomFeatures.Location = new System.Drawing.Point(293, 271);
            this.dgvRoomFeatures.MultiSelect = false;
            this.dgvRoomFeatures.Name = "dgvRoomFeatures";
            this.dgvRoomFeatures.RowHeadersVisible = false;
            this.dgvRoomFeatures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoomFeatures.Size = new System.Drawing.Size(292, 181);
            this.dgvRoomFeatures.TabIndex = 51;
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateRoom.BackColor = System.Drawing.Color.SpringGreen;
            this.btnUpdateRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateRoom.Location = new System.Drawing.Point(383, 491);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(143, 40);
            this.btnUpdateRoom.TabIndex = 46;
            this.btnUpdateRoom.Text = "Update";
            this.btnUpdateRoom.UseVisualStyleBackColor = false;
            this.btnUpdateRoom.Click += new System.EventHandler(this.btnUpdateRoom_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "*";
            // 
            // txtRoomName
            // 
            // 
            // 
            // 
            this.txtRoomName.CustomButton.Image = null;
            this.txtRoomName.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.txtRoomName.CustomButton.Name = "";
            this.txtRoomName.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtRoomName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRoomName.CustomButton.TabIndex = 1;
            this.txtRoomName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRoomName.CustomButton.UseSelectable = true;
            this.txtRoomName.CustomButton.Visible = false;
            this.txtRoomName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtRoomName.Lines = new string[0];
            this.txtRoomName.Location = new System.Drawing.Point(26, 22);
            this.txtRoomName.MaxLength = 32767;
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.PasswordChar = '\0';
            this.txtRoomName.PromptText = "Room Name";
            this.txtRoomName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRoomName.SelectedText = "";
            this.txtRoomName.SelectionLength = 0;
            this.txtRoomName.SelectionStart = 0;
            this.txtRoomName.ShortcutsEnabled = true;
            this.txtRoomName.Size = new System.Drawing.Size(232, 35);
            this.txtRoomName.TabIndex = 16;
            this.txtRoomName.UseSelectable = true;
            this.txtRoomName.WaterMark = "Room Name";
            this.txtRoomName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRoomName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.MediumPurple;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.Location = new System.Drawing.Point(532, 491);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(143, 40);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nudPricePerDay);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudCapacity);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtRoomName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 157);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(290, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "All Features";
            // 
            // dgvAllFeatures
            // 
            this.dgvAllFeatures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAllFeatures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllFeatures.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAllFeatures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllFeatures.Location = new System.Drawing.Point(293, 48);
            this.dgvAllFeatures.MultiSelect = false;
            this.dgvAllFeatures.Name = "dgvAllFeatures";
            this.dgvAllFeatures.RowHeadersVisible = false;
            this.dgvAllFeatures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllFeatures.Size = new System.Drawing.Size(292, 181);
            this.dgvAllFeatures.TabIndex = 47;
            // 
            // UpdateRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(712, 550);
            this.Controls.Add(this.txtSearchAll);
            this.Controls.Add(this.btnRemoveFeature);
            this.Controls.Add(this.btnAddFeature);
            this.Controls.Add(this.txtSearchRoom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvRoomFeatures);
            this.Controls.Add(this.btnUpdateRoom);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAllFeatures);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateRoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UpdateRoomForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudPricePerDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomFeatures)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllFeatures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudPricePerDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudCapacity;
        private MetroFramework.Controls.MetroTextBox txtSearchAll;
        private System.Windows.Forms.Button btnRemoveFeature;
        private System.Windows.Forms.Button btnAddFeature;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox txtSearchRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvRoomFeatures;
        private System.Windows.Forms.Button btnUpdateRoom;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txtRoomName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAllFeatures;
    }
}