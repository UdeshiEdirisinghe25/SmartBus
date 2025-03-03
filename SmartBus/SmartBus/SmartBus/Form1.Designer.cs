namespace SmartBus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 720);
            panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = SystemColors.ControlLightLight;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(808, 617);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(363, 32);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Don’t have an account? Sign up";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SlateGray;
            btnLogin.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ActiveCaptionText;
            btnLogin.Location = new Point(733, 427);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(106, 40);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.InactiveCaption;
            txtPassword.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(409, 341);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(377, 34);
            txtPassword.TabIndex = 5;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = SystemColors.InactiveCaption;
            txtUserName.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(409, 280);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(377, 34);
            txtUserName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(197, 341);
            label4.Name = "label4";
            label4.Size = new Size(124, 32);
            label4.TabIndex = 3;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(197, 275);
            label3.Name = "label3";
            label3.Size = new Size(149, 32);
            label3.TabIndex = 2;
            label3.Text = "User Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Freestyle Script", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(667, 117);
            label2.Name = "label2";
            label2.Size = new Size(299, 47);
            label2.TabIndex = 1;
            label2.Text = "Book Easy, Ride Smart!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 40F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(377, 37);
            label1.Name = "label1";
            label1.Size = new Size(388, 80);
            label1.TabIndex = 0;
            label1.Text = "SmartBus";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1182, 673);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Button btnLogin;
        private LinkLabel linkLabel1;
    }
}
