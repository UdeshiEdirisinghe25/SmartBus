namespace SmartBus
{
    partial class Booking
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
            pictureBox1 = new PictureBox();
            btnBook = new Button();
            checkedListBox1 = new CheckedListBox();
            txtFull = new TextBox();
            txtHalf = new TextBox();
            txtPassenger = new TextBox();
            txtPrice = new TextBox();
            txttime = new TextBox();
            txtRoute = new TextBox();
            txtConductor = new TextBox();
            txtDriver = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label4 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            linklblAddBus = new LinkLabel();
            panel2 = new Panel();
            lblBus = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnBook);
            panel1.Controls.Add(checkedListBox1);
            panel1.Controls.Add(txtFull);
            panel1.Controls.Add(txtHalf);
            panel1.Controls.Add(txtPassenger);
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(txttime);
            panel1.Controls.Add(txtRoute);
            panel1.Controls.Add(txtConductor);
            panel1.Controls.Add(txtDriver);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(linklblAddBus);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-183, -2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1219, 752);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Seat_new;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(201, 351);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(411, 179);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // btnBook
            // 
            btnBook.BackColor = Color.White;
            btnBook.BackgroundImageLayout = ImageLayout.None;
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBook.ForeColor = Color.DarkSlateBlue;
            btnBook.Location = new Point(880, 509);
            btnBook.Margin = new Padding(0);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(93, 30);
            btnBook.TabIndex = 22;
            btnBook.Text = "Book";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54" });
            checkedListBox1.Location = new Point(835, 248);
            checkedListBox1.Margin = new Padding(3, 2, 3, 2);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(132, 94);
            checkedListBox1.TabIndex = 21;
            // 
            // txtFull
            // 
            txtFull.BackColor = SystemColors.InactiveCaption;
            txtFull.BorderStyle = BorderStyle.None;
            txtFull.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFull.Location = new Point(718, 207);
            txtFull.Margin = new Padding(3, 2, 3, 2);
            txtFull.Name = "txtFull";
            txtFull.Size = new Size(145, 22);
            txtFull.TabIndex = 20;
            // 
            // txtHalf
            // 
            txtHalf.BackColor = SystemColors.InactiveCaption;
            txtHalf.BorderStyle = BorderStyle.None;
            txtHalf.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHalf.Location = new Point(718, 165);
            txtHalf.Margin = new Padding(3, 2, 3, 2);
            txtHalf.Name = "txtHalf";
            txtHalf.Size = new Size(145, 22);
            txtHalf.TabIndex = 19;
            // 
            // txtPassenger
            // 
            txtPassenger.BackColor = SystemColors.InactiveCaption;
            txtPassenger.BorderStyle = BorderStyle.None;
            txtPassenger.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassenger.Location = new Point(831, 120);
            txtPassenger.Margin = new Padding(3, 2, 3, 2);
            txtPassenger.Name = "txtPassenger";
            txtPassenger.Size = new Size(145, 22);
            txtPassenger.TabIndex = 18;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = SystemColors.InactiveCaption;
            txtPrice.BorderStyle = BorderStyle.None;
            txtPrice.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(341, 292);
            txtPrice.Margin = new Padding(3, 2, 3, 2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(253, 22);
            txtPrice.TabIndex = 17;
            // 
            // txttime
            // 
            txttime.BackColor = SystemColors.InactiveCaption;
            txttime.BorderStyle = BorderStyle.None;
            txttime.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txttime.Location = new Point(341, 251);
            txttime.Margin = new Padding(3, 2, 3, 2);
            txttime.Name = "txttime";
            txttime.Size = new Size(253, 22);
            txttime.TabIndex = 16;
            // 
            // txtRoute
            // 
            txtRoute.BackColor = SystemColors.InactiveCaption;
            txtRoute.BorderStyle = BorderStyle.None;
            txtRoute.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoute.Location = new Point(341, 210);
            txtRoute.Margin = new Padding(3, 2, 3, 2);
            txtRoute.Name = "txtRoute";
            txtRoute.Size = new Size(253, 22);
            txtRoute.TabIndex = 15;
            // 
            // txtConductor
            // 
            txtConductor.BackColor = SystemColors.InactiveCaption;
            txtConductor.BorderStyle = BorderStyle.None;
            txtConductor.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConductor.Location = new Point(341, 167);
            txtConductor.Margin = new Padding(3, 2, 3, 2);
            txtConductor.Name = "txtConductor";
            txtConductor.Size = new Size(253, 22);
            txtConductor.TabIndex = 14;
            // 
            // txtDriver
            // 
            txtDriver.BackColor = SystemColors.InactiveCaption;
            txtDriver.BorderStyle = BorderStyle.None;
            txtDriver.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDriver.Location = new Point(341, 123);
            txtDriver.Margin = new Padding(3, 2, 3, 2);
            txtDriver.Name = "txtDriver";
            txtDriver.Size = new Size(253, 22);
            txtDriver.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.SteelBlue;
            label12.Location = new Point(635, 247);
            label12.Name = "label12";
            label12.Size = new Size(160, 25);
            label12.TabIndex = 12;
            label12.Text = "Select your seat:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.SteelBlue;
            label11.Location = new Point(209, 290);
            label11.Name = "label11";
            label11.Size = new Size(60, 25);
            label11.TabIndex = 11;
            label11.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(635, 206);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 10;
            label4.Text = "Full:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.SteelBlue;
            label10.Location = new Point(209, 160);
            label10.Name = "label10";
            label10.Size = new Size(112, 25);
            label10.TabIndex = 9;
            label10.Text = "Conductor:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SteelBlue;
            label9.Location = new Point(209, 206);
            label9.Name = "label9";
            label9.Size = new Size(70, 25);
            label9.TabIndex = 8;
            label9.Text = "Route:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(635, 117);
            label8.Name = "label8";
            label8.Size = new Size(175, 25);
            label8.TabIndex = 7;
            label8.Text = "No.of Passengers:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(635, 160);
            label7.Name = "label7";
            label7.Size = new Size(54, 25);
            label7.TabIndex = 6;
            label7.Text = "Half:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(209, 247);
            label6.Name = "label6";
            label6.Size = new Size(61, 25);
            label6.TabIndex = 5;
            label6.Text = "Time:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(209, 117);
            label5.Name = "label5";
            label5.Size = new Size(70, 25);
            label5.TabIndex = 4;
            label5.Text = "Driver:";
            // 
            // linklblAddBus
            // 
            linklblAddBus.AutoSize = true;
            linklblAddBus.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            linklblAddBus.LinkColor = Color.White;
            linklblAddBus.Location = new Point(68, 372);
            linklblAddBus.Name = "linklblAddBus";
            linklblAddBus.Size = new Size(96, 28);
            linklblAddBus.TabIndex = 0;
            linklblAddBus.TabStop = true;
            linklblAddBus.Text = "Add Bus";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(lblBus);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 2);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1312, 62);
            panel2.TabIndex = 0;
            // 
            // lblBus
            // 
            lblBus.AutoSize = true;
            lblBus.Font = new Font("Malgun Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBus.ForeColor = SystemColors.ButtonHighlight;
            lblBus.Location = new Point(854, 12);
            lblBus.Name = "lblBus";
            lblBus.Size = new Size(62, 37);
            lblBus.TabIndex = 4;
            lblBus.Text = "Bus";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Script MT Bold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(193, 10);
            label3.Name = "label3";
            label3.Size = new Size(150, 38);
            label3.TabIndex = 3;
            label3.Text = "SmartBus";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(518, 12);
            label2.Name = "label2";
            label2.Size = new Size(130, 36);
            label2.TabIndex = 2;
            label2.Text = "Booking";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Script MT Bold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(0, 12);
            label1.Name = "label1";
            label1.Size = new Size(150, 38);
            label1.TabIndex = 1;
            label1.Text = "SmartBus";
            // 
            // Booking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 562);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Booking";
            Text = "Booking";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private LinkLabel linklblAddBus;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label12;
        private Label label11;
        private Label label4;
        private CheckedListBox checkedListBox1;
        private TextBox txtFull;
        private TextBox txtHalf;
        private TextBox txtPassenger;
        private TextBox txtPrice;
        private TextBox txttime;
        private TextBox txtRoute;
        private TextBox txtConductor;
        private TextBox txtDriver;
        private Button btnBook;
        private PictureBox pictureBox1;
        private Label lblBus;
    }
}