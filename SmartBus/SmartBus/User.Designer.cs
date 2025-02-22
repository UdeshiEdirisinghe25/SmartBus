namespace SmartBus
{
    partial class User
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
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            No = new DataGridViewTextBoxColumn();
            Route = new DataGridViewTextBoxColumn();
            Bus = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            Cancellation = new DataGridViewTextBoxColumn();
            Ticket = new DataGridViewTextBoxColumn();
            label6 = new Label();
            label7 = new Label();
            dataGridView2 = new DataGridView();
            booking = new DataGridViewTextBoxColumn();
            Route2 = new DataGridViewTextBoxColumn();
            Bus2 = new DataGridViewTextBoxColumn();
            Time2 = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnSearch = new Button();
            textBox1 = new TextBox();
            label5 = new Label();
            txtFrom = new TextBox();
            label4 = new Label();
            panel3 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCyan;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1370, 57);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(663, 14);
            label2.Name = "label2";
            label2.Size = new Size(98, 38);
            label2.TabIndex = 2;
            label2.Text = "User";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Script MT Bold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(0, 16);
            label1.Name = "label1";
            label1.Size = new Size(150, 38);
            label1.TabIndex = 1;
            label1.Text = "SmartBus";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(22, 97);
            label3.Name = "label3";
            label3.Size = new Size(209, 27);
            label3.TabIndex = 8;
            label3.Text = "Search Your Location";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { No, Route, Bus, Time, Cancellation, Ticket });
            dataGridView1.Location = new Point(22, 362);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(675, 125);
            dataGridView1.TabIndex = 10;
            // 
            // No
            // 
            No.HeaderText = "No";
            No.Name = "No";
            // 
            // Route
            // 
            Route.HeaderText = "Route";
            Route.Name = "Route";
            // 
            // Bus
            // 
            Bus.HeaderText = "Bus";
            Bus.Name = "Bus";
            // 
            // Time
            // 
            Time.HeaderText = "Time";
            Time.Name = "Time";
            // 
            // Cancellation
            // 
            Cancellation.HeaderText = "Cancellation";
            Cancellation.Name = "Cancellation";
            // 
            // Ticket
            // 
            Ticket.HeaderText = "Ticket";
            Ticket.Name = "Ticket";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(19, 324);
            label6.Name = "label6";
            label6.Size = new Size(166, 27);
            label6.TabIndex = 11;
            label6.Text = "Ongoing Bookings";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(18, 507);
            label7.Name = "label7";
            label7.Size = new Size(155, 27);
            label7.TabIndex = 12;
            label7.Text = "Booking History";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { booking, Route2, Bus2, Time2, Date });
            dataGridView2.Location = new Point(22, 542);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(675, 122);
            dataGridView2.TabIndex = 13;
            // 
            // booking
            // 
            booking.HeaderText = "No";
            booking.Name = "booking";
            // 
            // Route2
            // 
            Route2.HeaderText = "Route";
            Route2.Name = "Route2";
            // 
            // Bus2
            // 
            Bus2.HeaderText = "Bus";
            Bus2.Name = "Bus2";
            // 
            // Time2
            // 
            Time2.HeaderText = "Time";
            Time2.Name = "Time2";
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.Name = "Date";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtFrom);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(22, 144);
            panel1.Name = "panel1";
            panel1.Size = new Size(577, 142);
            panel1.TabIndex = 14;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.SlateGray;
            btnSearch.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = SystemColors.ActiveCaptionText;
            btnSearch.Location = new Point(459, 89);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(106, 38);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlDark;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(118, 85);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 22);
            textBox1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(17, 89);
            label5.Name = "label5";
            label5.Size = new Size(32, 21);
            label5.TabIndex = 7;
            label5.Text = "To:";
            // 
            // txtFrom
            // 
            txtFrom.BackColor = SystemColors.ControlDark;
            txtFrom.BorderStyle = BorderStyle.None;
            txtFrom.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFrom.Location = new Point(119, 32);
            txtFrom.Margin = new Padding(3, 2, 3, 2);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(243, 22);
            txtFrom.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(17, 34);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 0;
            label4.Text = "From:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Location = new Point(955, 131);
            panel3.Name = "panel3";
            panel3.Size = new Size(345, 202);
            panel3.TabIndex = 15;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(dataGridView2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(panel2);
            Name = "User";
            Text = "User";
            Load += User_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private Label label1;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn Route;
        private DataGridViewTextBoxColumn Bus;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn Cancellation;
        private DataGridViewTextBoxColumn Ticket;
        private Label label6;
        private Label label7;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn booking;
        private DataGridViewTextBoxColumn Route2;
        private DataGridViewTextBoxColumn Bus2;
        private DataGridViewTextBoxColumn Time2;
        private DataGridViewTextBoxColumn Date;
        private Panel panel1;
        private Button btnSearch;
        private TextBox textBox1;
        private Label label5;
        private TextBox txtFrom;
        private Label label4;
        private Panel panel3;
    }
}