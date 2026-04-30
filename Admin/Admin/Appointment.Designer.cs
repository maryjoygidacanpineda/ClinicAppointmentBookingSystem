namespace Admin
{
    partial class frmAppointment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppointment));
            this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvAppointments = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnMenu = new Guna.UI2.WinForms.Guna2Button();
            this.side = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.cbDoctor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.tbDisease = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbFullname = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSchedule = new Guna.UI2.WinForms.Guna2Button();
            this.btnComplete = new Guna.UI2.WinForms.Guna2Button();
            this.sidetransition1 = new System.Windows.Forms.Timer(this.components);
            this.btnadd = new Guna.UI2.WinForms.Guna2Button();
            this.dtpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.side.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.AutoRoundedCorners = true;
            this.tbSearch.BorderColor = System.Drawing.Color.Navy;
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.DefaultText = "";
            this.tbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.Location = new System.Drawing.Point(826, 58);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PlaceholderText = "";
            this.tbSearch.SelectedText = "";
            this.tbSearch.Size = new System.Drawing.Size(194, 39);
            this.tbSearch.TabIndex = 4;
            // 
            // cbStatus
            // 
            this.cbStatus.AutoRoundedCorners = true;
            this.cbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbStatus.BorderColor = System.Drawing.Color.Navy;
            this.cbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbStatus.ItemHeight = 30;
            this.cbStatus.Location = new System.Drawing.Point(259, 33);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(166, 36);
            this.cbStatus.TabIndex = 5;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.guna2Panel1.Controls.Add(this.dgvAppointments);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 152);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(917, 329);
            this.guna2Panel1.TabIndex = 6;
            // 
            // dgvAppointments
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAppointments.ColumnHeadersHeight = 4;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppointments.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAppointments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAppointments.Location = new System.Drawing.Point(4, 3);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.RowHeadersVisible = false;
            this.dgvAppointments.Size = new System.Drawing.Size(908, 323);
            this.dgvAppointments.TabIndex = 0;
            this.dgvAppointments.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAppointments.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAppointments.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAppointments.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAppointments.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAppointments.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAppointments.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAppointments.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvAppointments.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAppointments.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAppointments.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAppointments.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAppointments.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvAppointments.ThemeStyle.ReadOnly = false;
            this.dgvAppointments.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAppointments.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAppointments.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAppointments.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAppointments.ThemeStyle.RowsStyle.Height = 22;
            this.dgvAppointments.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAppointments.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAppointments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointments_CellClick);
            this.dgvAppointments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointments_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(985, 66);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(25, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMenu.FillColor = System.Drawing.Color.Transparent;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageSize = new System.Drawing.Size(35, 40);
            this.btnMenu.Location = new System.Drawing.Point(0, -1);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(44, 37);
            this.btnMenu.TabIndex = 8;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // side
            // 
            this.side.Controls.Add(this.guna2Button4);
            this.side.Controls.Add(this.btnLogout);
            this.side.Location = new System.Drawing.Point(38, 3);
            this.side.Name = "side";
            this.side.Size = new System.Drawing.Size(2, 37);
            this.side.TabIndex = 9;
            // 
            // guna2Button4
            // 
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button4.Image")));
            this.guna2Button4.Location = new System.Drawing.Point(23, 7);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(20, 24);
            this.guna2Button4.TabIndex = 10;
            // 
            // btnLogout
            // 
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Location = new System.Drawing.Point(31, 7);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 24);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(40, 40);
            this.btnExit.Location = new System.Drawing.Point(1017, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(39, 40);
            this.btnExit.TabIndex = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbDoctor
            // 
            this.cbDoctor.AutoRoundedCorners = true;
            this.cbDoctor.BackColor = System.Drawing.Color.Transparent;
            this.cbDoctor.BorderColor = System.Drawing.Color.Navy;
            this.cbDoctor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoctor.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDoctor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDoctor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbDoctor.ItemHeight = 30;
            this.cbDoctor.Location = new System.Drawing.Point(590, 61);
            this.cbDoctor.Name = "cbDoctor";
            this.cbDoctor.Size = new System.Drawing.Size(165, 36);
            this.cbDoctor.TabIndex = 11;
            this.cbDoctor.SelectedIndexChanged += new System.EventHandler(this.cbDoctor_SelectedIndexChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(61, 22);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(26, 15);
            this.guna2HtmlLabel1.TabIndex = 12;
            this.guna2HtmlLabel1.Text = "Date";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(605, 41);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(35, 15);
            this.guna2HtmlLabel2.TabIndex = 13;
            this.guna2HtmlLabel2.Text = "Doctor";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(463, 52);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(50, 45);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbDisease
            // 
            this.tbDisease.AutoRoundedCorners = true;
            this.tbDisease.BorderColor = System.Drawing.Color.Navy;
            this.tbDisease.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDisease.DefaultText = "";
            this.tbDisease.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbDisease.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbDisease.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDisease.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDisease.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDisease.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbDisease.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDisease.Location = new System.Drawing.Point(250, 99);
            this.tbDisease.Name = "tbDisease";
            this.tbDisease.PlaceholderText = "";
            this.tbDisease.SelectedText = "";
            this.tbDisease.Size = new System.Drawing.Size(194, 39);
            this.tbDisease.TabIndex = 15;
            // 
            // tbFullname
            // 
            this.tbFullname.AutoRoundedCorners = true;
            this.tbFullname.BorderColor = System.Drawing.Color.Navy;
            this.tbFullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFullname.DefaultText = "";
            this.tbFullname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbFullname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbFullname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFullname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFullname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFullname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbFullname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFullname.Location = new System.Drawing.Point(50, 99);
            this.tbFullname.Name = "tbFullname";
            this.tbFullname.PlaceholderText = "";
            this.tbFullname.SelectedText = "";
            this.tbFullname.Size = new System.Drawing.Size(194, 39);
            this.tbFullname.TabIndex = 16;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(58, 82);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(45, 15);
            this.guna2HtmlLabel3.TabIndex = 18;
            this.guna2HtmlLabel3.Text = "Fullname";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(271, 78);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(41, 15);
            this.guna2HtmlLabel4.TabIndex = 19;
            this.guna2HtmlLabel4.Text = "Disease";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(270, 14);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(33, 15);
            this.guna2HtmlLabel5.TabIndex = 20;
            this.guna2HtmlLabel5.Text = "Status";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(472, 93);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(38, 15);
            this.guna2HtmlLabel6.TabIndex = 21;
            this.guna2HtmlLabel6.Text = "Update";
            // 
            // btnCancel
            // 
            this.btnCancel.AutoRoundedCorners = true;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(945, 392);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 36);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.AutoRoundedCorners = true;
            this.btnSchedule.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSchedule.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSchedule.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSchedule.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSchedule.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSchedule.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.btnSchedule.ForeColor = System.Drawing.Color.White;
            this.btnSchedule.Location = new System.Drawing.Point(945, 238);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(95, 36);
            this.btnSchedule.TabIndex = 23;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.AutoRoundedCorners = true;
            this.btnComplete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnComplete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnComplete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnComplete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnComplete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnComplete.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.btnComplete.ForeColor = System.Drawing.Color.White;
            this.btnComplete.Location = new System.Drawing.Point(945, 315);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(95, 36);
            this.btnComplete.TabIndex = 24;
            this.btnComplete.Text = "Complete";
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // sidetransition1
            // 
            this.sidetransition1.Tick += new System.EventHandler(this.sidetransition1_Tick);
            // 
            // btnadd
            // 
            this.btnadd.AutoRoundedCorners = true;
            this.btnadd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnadd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnadd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnadd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnadd.FillColor = System.Drawing.Color.DarkKhaki;
            this.btnadd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(945, 153);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(95, 36);
            this.btnadd.TabIndex = 25;
            this.btnadd.Text = "Add Appointment";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.AutoRoundedCorners = true;
            this.dtpDate.Checked = true;
            this.dtpDate.FillColor = System.Drawing.Color.White;
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDate.Location = new System.Drawing.Point(46, 40);
            this.dtpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 36);
            this.dtpDate.TabIndex = 26;
            this.dtpDate.Value = new System.DateTime(2026, 4, 29, 12, 8, 17, 301);
            // 
            // frmAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1062, 487);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.tbFullname);
            this.Controls.Add(this.tbDisease);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.cbDoctor);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.side);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.tbSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAppointment";
            this.Load += new System.EventHandler(this.frmAppointment_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.side.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox tbSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbStatus;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAppointments;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnMenu;
        private Guna.UI2.WinForms.Guna2Panel side;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2ComboBox cbDoctor;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2TextBox tbDisease;
        private Guna.UI2.WinForms.Guna2TextBox tbFullname;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSchedule;
        private Guna.UI2.WinForms.Guna2Button btnComplete;
        private System.Windows.Forms.Timer sidetransition1;
        private Guna.UI2.WinForms.Guna2Button btnadd;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDate;
    }
}