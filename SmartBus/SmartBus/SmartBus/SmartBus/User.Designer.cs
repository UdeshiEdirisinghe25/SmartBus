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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            panel2 = new Panel();
            btnAdd = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            Cancellation = new DataGridViewButtonColumn();
            Ticket = new DataGridViewButtonColumn();
            label6 = new Label();
            label7 = new Label();
            dataGridView2 = new DataGridView();
            panel1 = new Panel();
            btnSearch = new Button();
            txtTo = new TextBox();
            label5 = new Label();
            txtFrom = new TextBox();
            label4 = new Label();
            panel3 = new Panel();
            btnBook = new Button();
            checkedListBox1 = new CheckedListBox();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox5 = new PictureBox();
            btnRefresh = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1814, 97);
            panel2.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.SteelBlue;
            btnAdd.Location = new Point(1694, 27);
            btnAdd.Margin = new Padding(0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(106, 44);
            btnAdd.TabIndex = 27;
            btnAdd.Text = "Logout";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(758, 19);
            label2.Name = "label2";
            label2.Size = new Size(121, 44);
            label2.TabIndex = 2;
            label2.Text = "Hello ";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Script MT Bold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(186, 48);
            label1.TabIndex = 1;
            label1.Text = "SmartBus";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(277, 144);
            label3.Name = "label3";
            label3.Size = new Size(258, 32);
            label3.TabIndex = 8;
            label3.Text = "Search Your Location";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Cancellation, Ticket });
            dataGridView1.Location = new Point(935, 199);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(849, 187);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Cancellation
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.NullValue = "Cancel";
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            Cancellation.DefaultCellStyle = dataGridViewCellStyle1;
            Cancellation.HeaderText = "Cancellation";
            Cancellation.MinimumWidth = 6;
            Cancellation.Name = "Cancellation";
            Cancellation.Resizable = DataGridViewTriState.True;
            Cancellation.SortMode = DataGridViewColumnSortMode.Automatic;
            Cancellation.Text = "Cancel";
            Cancellation.ToolTipText = "Cancel";
            Cancellation.Width = 125;
            // 
            // Ticket
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.NullValue = "Download";
            dataGridViewCellStyle2.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            Ticket.DefaultCellStyle = dataGridViewCellStyle2;
            Ticket.HeaderText = "Ticket";
            Ticket.MinimumWidth = 6;
            Ticket.Name = "Ticket";
            Ticket.Resizable = DataGridViewTriState.True;
            Ticket.SortMode = DataGridViewColumnSortMode.Automatic;
            Ticket.Width = 125;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(935, 144);
            label6.Name = "label6";
            label6.Size = new Size(229, 32);
            label6.TabIndex = 11;
            label6.Text = "Ongoing Bookings";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(935, 415);
            label7.Name = "label7";
            label7.Size = new Size(199, 32);
            label7.TabIndex = 12;
            label7.Text = "Booking History";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.Control;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(935, 472);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(849, 176);
            dataGridView2.TabIndex = 13;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtTo);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtFrom);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(277, 199);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(616, 189);
            panel1.TabIndex = 14;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ControlLightLight;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.DarkSlateBlue;
            btnSearch.Location = new Point(482, 119);
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(121, 51);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtTo
            // 
            txtTo.BackColor = SystemColors.GradientInactiveCaption;
            txtTo.BorderStyle = BorderStyle.None;
            txtTo.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTo.Location = new Point(135, 113);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(278, 27);
            txtTo.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 119);
            label5.Name = "label5";
            label5.Size = new Size(41, 28);
            label5.TabIndex = 7;
            label5.Text = "To:";
            // 
            // txtFrom
            // 
            txtFrom.BackColor = SystemColors.GradientInactiveCaption;
            txtFrom.BorderStyle = BorderStyle.None;
            txtFrom.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFrom.Location = new Point(136, 43);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(278, 27);
            txtFrom.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 45);
            label4.Name = "label4";
            label4.Size = new Size(65, 28);
            label4.TabIndex = 0;
            label4.Text = "From:";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonFace;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(btnBook);
            panel3.Controls.Add(checkedListBox1);
            panel3.Location = new Point(277, 472);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(616, 269);
            panel3.TabIndex = 15;
            // 
            // btnBook
            // 
            btnBook.BackColor = SystemColors.ControlLightLight;
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBook.ForeColor = Color.DarkSlateBlue;
            btnBook.Location = new Point(481, 201);
            btnBook.Margin = new Padding(0);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(121, 51);
            btnBook.TabIndex = 30;
            btnBook.Text = "Book";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(18, 10);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(584, 180);
            checkedListBox1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(277, 415);
            label8.Name = "label8";
            label8.Size = new Size(229, 32);
            label8.TabIndex = 16;
            label8.Text = "Please select a bus";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.New1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(14, 576);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 209);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightSteelBlue;
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(pictureBox1);
            panel4.ForeColor = SystemColors.ButtonHighlight;
            panel4.Location = new Point(0, 97);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(257, 977);
            panel4.TabIndex = 28;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(80, 339);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(80, 89);
            pictureBox4.TabIndex = 31;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(80, 196);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(80, 89);
            pictureBox3.TabIndex = 30;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources._5ddcebd7790099ed046736eb5f14ef7a;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(80, 56);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 92);
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(1105, 629);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(786, 253);
            pictureBox5.TabIndex = 29;
            pictureBox5.TabStop = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.ControlLightLight;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.DarkSlateBlue;
            btnRefresh.Location = new Point(1679, 125);
            btnRefresh.Margin = new Padding(0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(121, 51);
            btnRefresh.TabIndex = 30;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1810, 881);
            Controls.Add(btnRefresh);
            Controls.Add(panel4);
            Controls.Add(label8);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(dataGridView2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(pictureBox5);
            Margin = new Padding(3, 4, 3, 4);
            Name = "User";
            Text = "User";
            Load += User_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private Label label1;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label6;
        private Label label7;
        private DataGridView dataGridView2;
        private Panel panel1;
        private Button btnSearch;
        private TextBox txtTo;
        private Label label5;
        private TextBox txtFrom;
        private Label label4;
        private Panel panel3;
        private Button btnAdd;
        private Label label8;
        private PictureBox pictureBox1;
        private Panel panel4;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private DataGridViewButtonColumn Cancellation;
        private DataGridViewButtonColumn Ticket;
        private Button btnBook;
        private CheckedListBox checkedListBox1;
        private Button btnRefresh;
    }
}