namespace SmartBus
{
    partial class AddBus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBus));
            label2 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            panel1 = new Panel();
            txtTime = new TextBox();
            btnAdd = new Button();
            txtTraveldistance = new TextBox();
            txtTraveltime = new TextBox();
            txtPrice = new TextBox();
            txtRoute = new TextBox();
            txtConductorNTC = new TextBox();
            txtDriverNTC = new TextBox();
            txtConductor = new TextBox();
            txtDriver = new TextBox();
            txtBus = new TextBox();
            label12 = new Label();
            label13 = new Label();
            dataGridView1 = new DataGridView();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(474, 15);
            label2.Name = "label2";
            label2.Size = new Size(244, 36);
            label2.TabIndex = 3;
            label2.Text = "Record New Bus";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1312, 61);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Script MT Bold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 12);
            label4.Name = "label4";
            label4.Size = new Size(150, 38);
            label4.TabIndex = 1;
            label4.Text = "SmartBus";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(27, 24);
            label3.Name = "label3";
            label3.Size = new Size(50, 25);
            label3.TabIndex = 5;
            label3.Text = "Bus:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(458, 24);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 6;
            label1.Text = "Route:";
            label1.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(27, 56);
            label5.Name = "label5";
            label5.Size = new Size(70, 25);
            label5.TabIndex = 7;
            label5.Text = "Driver:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(27, 92);
            label6.Name = "label6";
            label6.Size = new Size(112, 25);
            label6.TabIndex = 8;
            label6.Text = "Conductor:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(27, 130);
            label7.Name = "label7";
            label7.Size = new Size(115, 25);
            label7.TabIndex = 9;
            label7.Text = "Driver NTC:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(24, 166);
            label8.Name = "label8";
            label8.Size = new Size(157, 25);
            label8.TabIndex = 10;
            label8.Text = "Conductor NTC:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(458, 56);
            label9.Name = "label9";
            label9.Size = new Size(146, 25);
            label9.TabIndex = 11;
            label9.Text = "Depature time:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(458, 92);
            label10.Name = "label10";
            label10.Size = new Size(60, 25);
            label10.TabIndex = 12;
            label10.Text = "Price:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(458, 128);
            label11.Name = "label11";
            label11.Size = new Size(121, 25);
            label11.TabIndex = 13;
            label11.Text = "Travel Time:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(txtTime);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txtTraveldistance);
            panel1.Controls.Add(txtTraveltime);
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(txtRoute);
            panel1.Controls.Add(txtConductorNTC);
            panel1.Controls.Add(txtDriverNTC);
            panel1.Controls.Add(txtConductor);
            panel1.Controls.Add(txtDriver);
            panel1.Controls.Add(txtBus);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(87, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 265);
            panel1.TabIndex = 15;
            panel1.Paint += panel1_Paint;
            // 
            // txtTime
            // 
            txtTime.BackColor = Color.WhiteSmoke;
            txtTime.BorderStyle = BorderStyle.None;
            txtTime.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTime.Location = new Point(662, 60);
            txtTime.Margin = new Padding(3, 2, 3, 2);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(171, 22);
            txtTime.TabIndex = 27;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.BackColor = Color.White;
            btnAdd.BackgroundImageLayout = ImageLayout.None;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.DarkSlateBlue;
            btnAdd.Location = new Point(652, 216);
            btnAdd.Margin = new Padding(0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(103, 30);
            btnAdd.TabIndex = 26;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtTraveldistance
            // 
            txtTraveldistance.BackColor = Color.WhiteSmoke;
            txtTraveldistance.BorderStyle = BorderStyle.None;
            txtTraveldistance.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTraveldistance.Location = new Point(662, 165);
            txtTraveldistance.Margin = new Padding(3, 2, 3, 2);
            txtTraveldistance.Name = "txtTraveldistance";
            txtTraveldistance.Size = new Size(171, 22);
            txtTraveldistance.TabIndex = 25;
            // 
            // txtTraveltime
            // 
            txtTraveltime.BackColor = Color.WhiteSmoke;
            txtTraveltime.BorderStyle = BorderStyle.None;
            txtTraveltime.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTraveltime.Location = new Point(662, 128);
            txtTraveltime.Margin = new Padding(3, 2, 3, 2);
            txtTraveltime.Name = "txtTraveltime";
            txtTraveltime.Size = new Size(171, 22);
            txtTraveltime.TabIndex = 24;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.WhiteSmoke;
            txtPrice.BorderStyle = BorderStyle.None;
            txtPrice.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(662, 92);
            txtPrice.Margin = new Padding(3, 2, 3, 2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(171, 22);
            txtPrice.TabIndex = 23;
            // 
            // txtRoute
            // 
            txtRoute.BackColor = Color.WhiteSmoke;
            txtRoute.BorderStyle = BorderStyle.None;
            txtRoute.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoute.Location = new Point(662, 24);
            txtRoute.Margin = new Padding(3, 2, 3, 2);
            txtRoute.Name = "txtRoute";
            txtRoute.Size = new Size(171, 22);
            txtRoute.TabIndex = 21;
            // 
            // txtConductorNTC
            // 
            txtConductorNTC.BackColor = Color.WhiteSmoke;
            txtConductorNTC.BorderStyle = BorderStyle.None;
            txtConductorNTC.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConductorNTC.Location = new Point(185, 170);
            txtConductorNTC.Margin = new Padding(3, 2, 3, 2);
            txtConductorNTC.Name = "txtConductorNTC";
            txtConductorNTC.Size = new Size(219, 22);
            txtConductorNTC.TabIndex = 20;
            // 
            // txtDriverNTC
            // 
            txtDriverNTC.BackColor = Color.WhiteSmoke;
            txtDriverNTC.BorderStyle = BorderStyle.None;
            txtDriverNTC.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDriverNTC.Location = new Point(185, 134);
            txtDriverNTC.Margin = new Padding(3, 2, 3, 2);
            txtDriverNTC.Name = "txtDriverNTC";
            txtDriverNTC.Size = new Size(219, 22);
            txtDriverNTC.TabIndex = 19;
            // 
            // txtConductor
            // 
            txtConductor.BackColor = Color.WhiteSmoke;
            txtConductor.BorderStyle = BorderStyle.None;
            txtConductor.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConductor.Location = new Point(185, 97);
            txtConductor.Margin = new Padding(3, 2, 3, 2);
            txtConductor.Name = "txtConductor";
            txtConductor.Size = new Size(219, 22);
            txtConductor.TabIndex = 18;
            // 
            // txtDriver
            // 
            txtDriver.BackColor = Color.WhiteSmoke;
            txtDriver.BorderStyle = BorderStyle.None;
            txtDriver.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDriver.Location = new Point(185, 61);
            txtDriver.Margin = new Padding(3, 2, 3, 2);
            txtDriver.Name = "txtDriver";
            txtDriver.Size = new Size(219, 22);
            txtDriver.TabIndex = 17;
            // 
            // txtBus
            // 
            txtBus.BackColor = Color.WhiteSmoke;
            txtBus.BorderStyle = BorderStyle.None;
            txtBus.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBus.Location = new Point(186, 26);
            txtBus.Margin = new Padding(3, 2, 3, 2);
            txtBus.Name = "txtBus";
            txtBus.Size = new Size(219, 22);
            txtBus.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(458, 165);
            label12.Name = "label12";
            label12.Size = new Size(153, 25);
            label12.TabIndex = 15;
            label12.Text = "Travel Distance:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Malgun Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.DarkSlateBlue;
            label13.Location = new Point(29, 371);
            label13.Name = "label13";
            label13.Size = new Size(166, 30);
            label13.TabIndex = 16;
            label13.Text = "Schedule Rides";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 421);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1015, 212);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // AddBus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1093, 661);
            Controls.Add(dataGridView1);
            Controls.Add(label13);
            Controls.Add(panel1);
            Controls.Add(panel2);
            MaximizeBox = false;
            Name = "AddBus";
            Text = "AddBus";
            Load += AddBus_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Panel panel1;
        private Label label12;
        private TextBox txtConductorNTC;
        private TextBox txtDriverNTC;
        private TextBox txtConductor;
        private TextBox txtDriver;
        private TextBox txtBus;
        private TextBox txtTraveldistance;
        private TextBox txtTraveltime;
        private TextBox txtPrice;
        private TextBox txtRoute;
        private Button btnAdd;
        private Label label13;
        private DataGridView dataGridView1;
        private TextBox txtTime;
    }
}