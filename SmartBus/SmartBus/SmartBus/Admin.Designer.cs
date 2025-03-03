namespace SmartBus
{
    partial class Admin
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            ReferenceID = new DataGridViewTextBoxColumn();
            BusNumber = new DataGridViewTextBoxColumn();
            Route = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            TravelDistance = new DataGridViewTextBoxColumn();
            TravelTime = new DataGridViewTextBoxColumn();
            DriverNTC = new DataGridViewTextBoxColumn();
            ConductorNTC = new DataGridViewTextBoxColumn();
            linklblAddBus = new LinkLabel();
            panel3 = new Panel();
            panel2 = new Panel();
            btnBook = new Button();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(linklblAddBus);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1900, 1024);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ReferenceID, BusNumber, Route, Time, TravelDistance, TravelTime, DriverNTC, ConductorNTC });
            dataGridView1.Location = new Point(129, 550);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1603, 326);
            dataGridView1.TabIndex = 2;
            // 
            // ReferenceID
            // 
            ReferenceID.HeaderText = "ReferenceID";
            ReferenceID.MinimumWidth = 15;
            ReferenceID.Name = "ReferenceID";
            ReferenceID.ReadOnly = true;
            ReferenceID.Width = 125;
            // 
            // BusNumber
            // 
            BusNumber.HeaderText = "BusNumber";
            BusNumber.MinimumWidth = 10;
            BusNumber.Name = "BusNumber";
            BusNumber.ReadOnly = true;
            BusNumber.Width = 125;
            // 
            // Route
            // 
            Route.HeaderText = "Route";
            Route.MinimumWidth = 10;
            Route.Name = "Route";
            Route.ReadOnly = true;
            Route.Width = 125;
            // 
            // Time
            // 
            Time.HeaderText = "Time";
            Time.MinimumWidth = 10;
            Time.Name = "Time";
            Time.ReadOnly = true;
            Time.Width = 125;
            // 
            // TravelDistance
            // 
            TravelDistance.HeaderText = "TravelDistance";
            TravelDistance.MinimumWidth = 10;
            TravelDistance.Name = "TravelDistance";
            TravelDistance.ReadOnly = true;
            TravelDistance.Width = 125;
            // 
            // TravelTime
            // 
            TravelTime.HeaderText = "TravelTime";
            TravelTime.MinimumWidth = 10;
            TravelTime.Name = "TravelTime";
            TravelTime.Width = 125;
            // 
            // DriverNTC
            // 
            DriverNTC.HeaderText = "DriverNTC";
            DriverNTC.MinimumWidth = 10;
            DriverNTC.Name = "DriverNTC";
            DriverNTC.Width = 125;
            // 
            // ConductorNTC
            // 
            ConductorNTC.HeaderText = "ConductorNTC";
            ConductorNTC.MinimumWidth = 6;
            ConductorNTC.Name = "ConductorNTC";
            ConductorNTC.ReadOnly = true;
            ConductorNTC.Width = 125;
            // 
            // linklblAddBus
            // 
            linklblAddBus.AutoSize = true;
            linklblAddBus.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            linklblAddBus.LinkColor = Color.White;
            linklblAddBus.Location = new Point(78, 496);
            linklblAddBus.Name = "linklblAddBus";
            linklblAddBus.Size = new Size(122, 34);
            linklblAddBus.TabIndex = 0;
            linklblAddBus.TabStop = true;
            linklblAddBus.Text = "Add Bus";
            // 
            // panel3
            // 
            panel3.BackColor = Color.CadetBlue;
            panel3.Location = new Point(94, 112);
            panel3.Name = "panel3";
            panel3.Size = new Size(1638, 322);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCyan;
            panel2.Controls.Add(btnBook);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1903, 76);
            panel2.TabIndex = 0;
            // 
            // btnBook
            // 
            btnBook.BackColor = Color.SlateGray;
            btnBook.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBook.ForeColor = SystemColors.ActiveCaptionText;
            btnBook.Location = new Point(1663, 16);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(106, 40);
            btnBook.TabIndex = 23;
            btnBook.Text = "Logout";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(758, 18);
            label2.Name = "label2";
            label2.Size = new Size(145, 47);
            label2.TabIndex = 2;
            label2.Text = "Admin";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Script MT Bold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(3, 16);
            label1.Name = "label1";
            label1.Size = new Size(186, 48);
            label1.TabIndex = 1;
            label1.Text = "SmartBus";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1782, 977);
            Controls.Add(panel1);
            Name = "Admin";
            Text = "Admin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Panel panel3;
        private LinkLabel linklblAddBus;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ReferenceID;
        private DataGridViewTextBoxColumn BusNumber;
        private DataGridViewTextBoxColumn Route;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn TravelDistance;
        private DataGridViewTextBoxColumn TravelTime;
        private DataGridViewTextBoxColumn DriverNTC;
        private DataGridViewTextBoxColumn ConductorNTC;
        private Button btnBook;
    }
}