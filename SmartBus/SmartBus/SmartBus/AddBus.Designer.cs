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
            label2.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(326, 16);
            label2.Name = "label2";
            label2.Size = new Size(352, 47);
            label2.TabIndex = 3;
            label2.Text = "Record New Bus";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCyan;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1499, 68);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Script MT Bold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(0, 16);
            label4.Name = "label4";
            label4.Size = new Size(186, 48);
            label4.TabIndex = 1;
            label4.Text = "SmartBus";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(31, 32);
            label3.Name = "label3";
            label3.Size = new Size(62, 32);
            label3.TabIndex = 5;
            label3.Text = "Bus:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(523, 32);
            label1.Name = "label1";
            label1.Size = new Size(87, 32);
            label1.TabIndex = 6;
            label1.Text = "Route:";
            label1.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(31, 75);
            label5.Name = "label5";
            label5.Size = new Size(93, 32);
            label5.TabIndex = 7;
            label5.Text = "Driver:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(31, 123);
            label6.Name = "label6";
            label6.Size = new Size(134, 32);
            label6.TabIndex = 8;
            label6.Text = "Conductor:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(31, 173);
            label7.Name = "label7";
            label7.Size = new Size(152, 32);
            label7.TabIndex = 9;
            label7.Text = "Driver NTC:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(27, 221);
            label8.Name = "label8";
            label8.Size = new Size(193, 32);
            label8.TabIndex = 10;
            label8.Text = "Conductor NTC:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(523, 75);
            label9.Name = "label9";
            label9.Size = new Size(184, 32);
            label9.TabIndex = 11;
            label9.Text = "Depature time:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(523, 123);
            label10.Name = "label10";
            label10.Size = new Size(78, 32);
            label10.TabIndex = 12;
            label10.Text = "Price:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(523, 171);
            label11.Name = "label11";
            label11.Size = new Size(157, 32);
            label11.TabIndex = 13;
            label11.Text = "Travel Time:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
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
            panel1.Location = new Point(100, 104);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1023, 353);
            panel1.TabIndex = 15;
            panel1.Paint += panel1_Paint;
            // 
            // txtTime
            // 
            txtTime.BackColor = SystemColors.InactiveCaption;
            txtTime.BorderStyle = BorderStyle.None;
            txtTime.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTime.Location = new Point(756, 80);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(195, 27);
            txtTime.TabIndex = 27;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SlateGray;
            btnAdd.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ActiveCaptionText;
            btnAdd.Location = new Point(745, 288);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(106, 40);
            btnAdd.TabIndex = 26;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtTraveldistance
            // 
            txtTraveldistance.BackColor = SystemColors.InactiveCaption;
            txtTraveldistance.BorderStyle = BorderStyle.None;
            txtTraveldistance.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTraveldistance.Location = new Point(756, 220);
            txtTraveldistance.Name = "txtTraveldistance";
            txtTraveldistance.Size = new Size(195, 27);
            txtTraveldistance.TabIndex = 25;
            // 
            // txtTraveltime
            // 
            txtTraveltime.BackColor = SystemColors.InactiveCaption;
            txtTraveltime.BorderStyle = BorderStyle.None;
            txtTraveltime.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTraveltime.Location = new Point(756, 171);
            txtTraveltime.Name = "txtTraveltime";
            txtTraveltime.Size = new Size(195, 27);
            txtTraveltime.TabIndex = 24;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = SystemColors.InactiveCaption;
            txtPrice.BorderStyle = BorderStyle.None;
            txtPrice.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(756, 123);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(195, 27);
            txtPrice.TabIndex = 23;
            // 
            // txtRoute
            // 
            txtRoute.BackColor = SystemColors.InactiveCaption;
            txtRoute.BorderStyle = BorderStyle.None;
            txtRoute.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoute.Location = new Point(756, 32);
            txtRoute.Name = "txtRoute";
            txtRoute.Size = new Size(195, 27);
            txtRoute.TabIndex = 21;
            // 
            // txtConductorNTC
            // 
            txtConductorNTC.BackColor = SystemColors.InactiveCaption;
            txtConductorNTC.BorderStyle = BorderStyle.None;
            txtConductorNTC.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConductorNTC.Location = new Point(211, 227);
            txtConductorNTC.Name = "txtConductorNTC";
            txtConductorNTC.Size = new Size(250, 27);
            txtConductorNTC.TabIndex = 20;
            // 
            // txtDriverNTC
            // 
            txtDriverNTC.BackColor = SystemColors.InactiveCaption;
            txtDriverNTC.BorderStyle = BorderStyle.None;
            txtDriverNTC.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDriverNTC.Location = new Point(211, 179);
            txtDriverNTC.Name = "txtDriverNTC";
            txtDriverNTC.Size = new Size(250, 27);
            txtDriverNTC.TabIndex = 19;
            // 
            // txtConductor
            // 
            txtConductor.BackColor = SystemColors.InactiveCaption;
            txtConductor.BorderStyle = BorderStyle.None;
            txtConductor.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConductor.Location = new Point(211, 129);
            txtConductor.Name = "txtConductor";
            txtConductor.Size = new Size(250, 27);
            txtConductor.TabIndex = 18;
            // 
            // txtDriver
            // 
            txtDriver.BackColor = SystemColors.InactiveCaption;
            txtDriver.BorderStyle = BorderStyle.None;
            txtDriver.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDriver.Location = new Point(211, 81);
            txtDriver.Name = "txtDriver";
            txtDriver.Size = new Size(250, 27);
            txtDriver.TabIndex = 17;
            // 
            // txtBus
            // 
            txtBus.BackColor = SystemColors.InactiveCaption;
            txtBus.BorderStyle = BorderStyle.None;
            txtBus.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBus.Location = new Point(213, 35);
            txtBus.Name = "txtBus";
            txtBus.Size = new Size(250, 27);
            txtBus.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ControlLightLight;
            label12.Location = new Point(523, 220);
            label12.Name = "label12";
            label12.Size = new Size(199, 32);
            label12.TabIndex = 15;
            label12.Text = "Travel Distance:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ControlLightLight;
            label13.Location = new Point(35, 489);
            label13.Name = "label13";
            label13.Size = new Size(188, 35);
            label13.TabIndex = 16;
            label13.Text = "Schedule Rides";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(45, 540);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1160, 377);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // AddBus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(1249, 953);
            Controls.Add(dataGridView1);
            Controls.Add(label13);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
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