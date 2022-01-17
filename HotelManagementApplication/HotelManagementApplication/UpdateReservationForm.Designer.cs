
namespace HotelManagementApplication
{
    partial class UpdateReservationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchReservationCustomer = new MetroFramework.Controls.MetroTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearchReservationService = new MetroFramework.Controls.MetroTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearchAllCustomer = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchAllService = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRemoveService = new System.Windows.Forms.Button();
            this.dgvAllCustomers = new System.Windows.Forms.DataGridView();
            this.dgvReservationServices = new System.Windows.Forms.DataGridView();
            this.dgvReservationCustomers = new System.Windows.Forms.DataGridView();
            this.btnAddService = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.dgvAllServices = new System.Windows.Forms.DataGridView();
            this.nudServiceQuantity = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbRooms = new MetroFramework.Controls.MetroComboBox();
            this.btnUpdateReservation = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnRemoveCustomer = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkCheckedOut = new System.Windows.Forms.CheckBox();
            this.chkCheckedIn = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServiceQuantity)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 94;
            this.label1.Text = "Quantity";
            // 
            // txtSearchReservationCustomer
            // 
            this.txtSearchReservationCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtSearchReservationCustomer.CustomButton.Image = null;
            this.txtSearchReservationCustomer.CustomButton.Location = new System.Drawing.Point(132, 2);
            this.txtSearchReservationCustomer.CustomButton.Name = "";
            this.txtSearchReservationCustomer.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtSearchReservationCustomer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchReservationCustomer.CustomButton.TabIndex = 1;
            this.txtSearchReservationCustomer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchReservationCustomer.CustomButton.UseSelectable = true;
            this.txtSearchReservationCustomer.CustomButton.Visible = false;
            this.txtSearchReservationCustomer.Lines = new string[0];
            this.txtSearchReservationCustomer.Location = new System.Drawing.Point(698, 347);
            this.txtSearchReservationCustomer.MaxLength = 32767;
            this.txtSearchReservationCustomer.Name = "txtSearchReservationCustomer";
            this.txtSearchReservationCustomer.PasswordChar = '\0';
            this.txtSearchReservationCustomer.PromptText = "Search by Customer Name";
            this.txtSearchReservationCustomer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchReservationCustomer.SelectedText = "";
            this.txtSearchReservationCustomer.SelectionLength = 0;
            this.txtSearchReservationCustomer.SelectionStart = 0;
            this.txtSearchReservationCustomer.ShortcutsEnabled = true;
            this.txtSearchReservationCustomer.Size = new System.Drawing.Size(160, 30);
            this.txtSearchReservationCustomer.TabIndex = 92;
            this.txtSearchReservationCustomer.UseSelectable = true;
            this.txtSearchReservationCustomer.WaterMark = "Search by Customer Name";
            this.txtSearchReservationCustomer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchReservationCustomer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchReservationCustomer.TextChanged += new System.EventHandler(this.txtSearchReservationCustomer_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(504, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 17);
            this.label9.TabIndex = 91;
            this.label9.Text = "Reservation\'s Customers";
            // 
            // txtSearchReservationService
            // 
            this.txtSearchReservationService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.txtSearchReservationService.CustomButton.Image = null;
            this.txtSearchReservationService.CustomButton.Location = new System.Drawing.Point(132, 2);
            this.txtSearchReservationService.CustomButton.Name = "";
            this.txtSearchReservationService.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtSearchReservationService.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchReservationService.CustomButton.TabIndex = 1;
            this.txtSearchReservationService.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchReservationService.CustomButton.UseSelectable = true;
            this.txtSearchReservationService.CustomButton.Visible = false;
            this.txtSearchReservationService.Lines = new string[0];
            this.txtSearchReservationService.Location = new System.Drawing.Point(294, 347);
            this.txtSearchReservationService.MaxLength = 32767;
            this.txtSearchReservationService.Name = "txtSearchReservationService";
            this.txtSearchReservationService.PasswordChar = '\0';
            this.txtSearchReservationService.PromptText = "Search by Service Name";
            this.txtSearchReservationService.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchReservationService.SelectedText = "";
            this.txtSearchReservationService.SelectionLength = 0;
            this.txtSearchReservationService.SelectionStart = 0;
            this.txtSearchReservationService.ShortcutsEnabled = true;
            this.txtSearchReservationService.Size = new System.Drawing.Size(160, 30);
            this.txtSearchReservationService.TabIndex = 90;
            this.txtSearchReservationService.UseSelectable = true;
            this.txtSearchReservationService.WaterMark = "Search by Service Name";
            this.txtSearchReservationService.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchReservationService.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchReservationService.TextChanged += new System.EventHandler(this.txtSearchReservationService_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(114, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 17);
            this.label8.TabIndex = 89;
            this.label8.Text = "Reservation\'s Services";
            // 
            // txtSearchAllCustomer
            // 
            this.txtSearchAllCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtSearchAllCustomer.CustomButton.Image = null;
            this.txtSearchAllCustomer.CustomButton.Location = new System.Drawing.Point(132, 2);
            this.txtSearchAllCustomer.CustomButton.Name = "";
            this.txtSearchAllCustomer.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtSearchAllCustomer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchAllCustomer.CustomButton.TabIndex = 1;
            this.txtSearchAllCustomer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchAllCustomer.CustomButton.UseSelectable = true;
            this.txtSearchAllCustomer.CustomButton.Visible = false;
            this.txtSearchAllCustomer.Lines = new string[0];
            this.txtSearchAllCustomer.Location = new System.Drawing.Point(698, 12);
            this.txtSearchAllCustomer.MaxLength = 32767;
            this.txtSearchAllCustomer.Name = "txtSearchAllCustomer";
            this.txtSearchAllCustomer.PasswordChar = '\0';
            this.txtSearchAllCustomer.PromptText = "Search by Customer Name";
            this.txtSearchAllCustomer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchAllCustomer.SelectedText = "";
            this.txtSearchAllCustomer.SelectionLength = 0;
            this.txtSearchAllCustomer.SelectionStart = 0;
            this.txtSearchAllCustomer.ShortcutsEnabled = true;
            this.txtSearchAllCustomer.Size = new System.Drawing.Size(160, 30);
            this.txtSearchAllCustomer.TabIndex = 88;
            this.txtSearchAllCustomer.UseSelectable = true;
            this.txtSearchAllCustomer.WaterMark = "Search by Customer Name";
            this.txtSearchAllCustomer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchAllCustomer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchAllCustomer.TextChanged += new System.EventHandler(this.txtSearchAllCustomer_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(585, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 87;
            this.label7.Text = "All Customers";
            // 
            // txtSearchAllService
            // 
            // 
            // 
            // 
            this.txtSearchAllService.CustomButton.Image = null;
            this.txtSearchAllService.CustomButton.Location = new System.Drawing.Point(132, 2);
            this.txtSearchAllService.CustomButton.Name = "";
            this.txtSearchAllService.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtSearchAllService.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchAllService.CustomButton.TabIndex = 1;
            this.txtSearchAllService.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchAllService.CustomButton.UseSelectable = true;
            this.txtSearchAllService.CustomButton.Visible = false;
            this.txtSearchAllService.Lines = new string[0];
            this.txtSearchAllService.Location = new System.Drawing.Point(213, 12);
            this.txtSearchAllService.MaxLength = 32767;
            this.txtSearchAllService.Name = "txtSearchAllService";
            this.txtSearchAllService.PasswordChar = '\0';
            this.txtSearchAllService.PromptText = "Search by Service Name";
            this.txtSearchAllService.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchAllService.SelectedText = "";
            this.txtSearchAllService.SelectionLength = 0;
            this.txtSearchAllService.SelectionStart = 0;
            this.txtSearchAllService.ShortcutsEnabled = true;
            this.txtSearchAllService.Size = new System.Drawing.Size(160, 30);
            this.txtSearchAllService.TabIndex = 86;
            this.txtSearchAllService.UseSelectable = true;
            this.txtSearchAllService.WaterMark = "Search by Service Name";
            this.txtSearchAllService.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchAllService.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchAllService.TextChanged += new System.EventHandler(this.txtSearchAllService_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(114, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 85;
            this.label6.Text = "All Services";
            // 
            // btnRemoveService
            // 
            this.btnRemoveService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveService.BackColor = System.Drawing.Color.Red;
            this.btnRemoveService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveService.Location = new System.Drawing.Point(12, 289);
            this.btnRemoveService.Name = "btnRemoveService";
            this.btnRemoveService.Size = new System.Drawing.Size(96, 52);
            this.btnRemoveService.TabIndex = 83;
            this.btnRemoveService.Text = "Remove Service";
            this.btnRemoveService.UseVisualStyleBackColor = false;
            this.btnRemoveService.Click += new System.EventHandler(this.btnRemoveService_Click);
            // 
            // dgvAllCustomers
            // 
            this.dgvAllCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllCustomers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAllCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllCustomers.Location = new System.Drawing.Point(375, 3);
            this.dgvAllCustomers.MultiSelect = false;
            this.dgvAllCustomers.Name = "dgvAllCustomers";
            this.dgvAllCustomers.RowHeadersVisible = false;
            this.dgvAllCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllCustomers.Size = new System.Drawing.Size(366, 140);
            this.dgvAllCustomers.TabIndex = 64;
            // 
            // dgvReservationServices
            // 
            this.dgvReservationServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservationServices.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReservationServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservationServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReservationServices.Location = new System.Drawing.Point(3, 149);
            this.dgvReservationServices.MultiSelect = false;
            this.dgvReservationServices.Name = "dgvReservationServices";
            this.dgvReservationServices.RowHeadersVisible = false;
            this.dgvReservationServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservationServices.Size = new System.Drawing.Size(366, 141);
            this.dgvReservationServices.TabIndex = 50;
            // 
            // dgvReservationCustomers
            // 
            this.dgvReservationCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservationCustomers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReservationCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservationCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReservationCustomers.Location = new System.Drawing.Point(375, 149);
            this.dgvReservationCustomers.MultiSelect = false;
            this.dgvReservationCustomers.Name = "dgvReservationCustomers";
            this.dgvReservationCustomers.RowHeadersVisible = false;
            this.dgvReservationCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservationCustomers.Size = new System.Drawing.Size(366, 141);
            this.dgvReservationCustomers.TabIndex = 49;
            // 
            // btnAddService
            // 
            this.btnAddService.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddService.Location = new System.Drawing.Point(12, 48);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(96, 52);
            this.btnAddService.TabIndex = 84;
            this.btnAddService.Text = "Add Service";
            this.btnAddService.UseVisualStyleBackColor = false;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCustomer.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddCustomer.Location = new System.Drawing.Point(864, 48);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(96, 52);
            this.btnAddCustomer.TabIndex = 82;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // dgvAllServices
            // 
            this.dgvAllServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllServices.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAllServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllServices.Location = new System.Drawing.Point(3, 3);
            this.dgvAllServices.MultiSelect = false;
            this.dgvAllServices.Name = "dgvAllServices";
            this.dgvAllServices.RowHeadersVisible = false;
            this.dgvAllServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllServices.Size = new System.Drawing.Size(366, 140);
            this.dgvAllServices.TabIndex = 48;
            // 
            // nudServiceQuantity
            // 
            this.nudServiceQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudServiceQuantity.Location = new System.Drawing.Point(12, 123);
            this.nudServiceQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudServiceQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudServiceQuantity.Name = "nudServiceQuantity";
            this.nudServiceQuantity.Size = new System.Drawing.Size(96, 29);
            this.nudServiceQuantity.TabIndex = 93;
            this.nudServiceQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvAllCustomers, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvReservationServices, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvReservationCustomers, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvAllServices, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(114, 48);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(744, 293);
            this.tableLayoutPanel1.TabIndex = 80;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(10, 505);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 79;
            this.label5.Text = "Select Room";
            // 
            // cmbRooms
            // 
            this.cmbRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbRooms.FormattingEnabled = true;
            this.cmbRooms.ItemHeight = 23;
            this.cmbRooms.Location = new System.Drawing.Point(114, 502);
            this.cmbRooms.Name = "cmbRooms";
            this.cmbRooms.Size = new System.Drawing.Size(195, 29);
            this.cmbRooms.TabIndex = 78;
            this.cmbRooms.UseSelectable = true;
            this.cmbRooms.SelectedIndexChanged += new System.EventHandler(this.cmbRooms_SelectedIndexChanged);
            // 
            // btnUpdateReservation
            // 
            this.btnUpdateReservation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateReservation.BackColor = System.Drawing.Color.SpringGreen;
            this.btnUpdateReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateReservation.Location = new System.Drawing.Point(668, 502);
            this.btnUpdateReservation.Name = "btnUpdateReservation";
            this.btnUpdateReservation.Size = new System.Drawing.Size(143, 40);
            this.btnUpdateReservation.TabIndex = 75;
            this.btnUpdateReservation.Text = "Update";
            this.btnUpdateReservation.UseVisualStyleBackColor = false;
            this.btnUpdateReservation.Click += new System.EventHandler(this.btnUpdateReservation_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(22, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 60;
            this.label4.Text = "To";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpStartDate.Location = new System.Drawing.Point(51, 17);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(152, 20);
            this.dtpStartDate.TabIndex = 57;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "From";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpEndDate.Location = new System.Drawing.Point(51, 43);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(152, 20);
            this.dtpEndDate.TabIndex = 58;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // btnRemoveCustomer
            // 
            this.btnRemoveCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveCustomer.BackColor = System.Drawing.Color.Red;
            this.btnRemoveCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveCustomer.Location = new System.Drawing.Point(864, 289);
            this.btnRemoveCustomer.Name = "btnRemoveCustomer";
            this.btnRemoveCustomer.Size = new System.Drawing.Size(96, 52);
            this.btnRemoveCustomer.TabIndex = 81;
            this.btnRemoveCustomer.Text = "Remove Customer";
            this.btnRemoveCustomer.UseVisualStyleBackColor = false;
            this.btnRemoveCustomer.Click += new System.EventHandler(this.btnRemoveCustomer_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.MediumPurple;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.Location = new System.Drawing.Point(817, 502);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(143, 40);
            this.btnCancel.TabIndex = 77;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpStartDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpEndDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 406);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 74);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reservation Dates";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.chkCheckedOut);
            this.groupBox2.Controls.Add(this.chkCheckedIn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtpCheckIn);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dtpCheckOut);
            this.groupBox2.Location = new System.Drawing.Point(252, 406);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 74);
            this.groupBox2.TabIndex = 95;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Status";
            // 
            // chkCheckedOut
            // 
            this.chkCheckedOut.AutoSize = true;
            this.chkCheckedOut.Location = new System.Drawing.Point(103, 45);
            this.chkCheckedOut.Name = "chkCheckedOut";
            this.chkCheckedOut.Size = new System.Drawing.Size(15, 14);
            this.chkCheckedOut.TabIndex = 97;
            this.chkCheckedOut.UseVisualStyleBackColor = true;
            // 
            // chkCheckedIn
            // 
            this.chkCheckedIn.AutoSize = true;
            this.chkCheckedIn.Location = new System.Drawing.Point(102, 23);
            this.chkCheckedIn.Name = "chkCheckedIn";
            this.chkCheckedIn.Size = new System.Drawing.Size(15, 14);
            this.chkCheckedIn.TabIndex = 96;
            this.chkCheckedIn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 60;
            this.label3.Text = "Checked-Out";
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpCheckIn.Location = new System.Drawing.Point(123, 17);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(152, 20);
            this.dtpCheckIn.TabIndex = 57;
            this.dtpCheckIn.ValueChanged += new System.EventHandler(this.dtpCheckIn_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(6, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 17);
            this.label10.TabIndex = 59;
            this.label10.Text = "Checked-In";
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpCheckOut.Location = new System.Drawing.Point(123, 43);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(152, 20);
            this.dtpCheckOut.TabIndex = 58;
            this.dtpCheckOut.ValueChanged += new System.EventHandler(this.dtpCheckOut_ValueChanged);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 534);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(279, 17);
            this.label11.TabIndex = 96;
            this.label11.Text = "Avaliable rooms between reservation dates";
            // 
            // UpdateReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(975, 560);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchReservationCustomer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSearchReservationService);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSearchAllCustomer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSearchAllService);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRemoveService);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.nudServiceQuantity);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbRooms);
            this.Controls.Add(this.btnUpdateReservation);
            this.Controls.Add(this.btnRemoveCustomer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateReservationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UpdateReservationForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServiceQuantity)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtSearchReservationCustomer;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroTextBox txtSearchReservationService;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroTextBox txtSearchAllCustomer;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroTextBox txtSearchAllService;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRemoveService;
        private System.Windows.Forms.DataGridView dgvAllCustomers;
        private System.Windows.Forms.DataGridView dgvReservationServices;
        private System.Windows.Forms.DataGridView dgvReservationCustomers;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.DataGridView dgvAllServices;
        private System.Windows.Forms.NumericUpDown nudServiceQuantity;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroComboBox cmbRooms;
        private System.Windows.Forms.Button btnUpdateReservation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnRemoveCustomer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkCheckedOut;
        private System.Windows.Forms.CheckBox chkCheckedIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Label label11;
    }
}