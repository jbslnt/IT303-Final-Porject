namespace QuizApplication
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_UserType = new System.Windows.Forms.Label();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl_InstructorLogin = new System.Windows.Forms.Label();
            this.txtfldUsername = new System.Windows.Forms.TextBox();
            this.txtfldPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.chkbx_Password = new System.Windows.Forms.CheckBox();
            this.btn_InstructorLogin = new System.Windows.Forms.Button();
            this.panel1_Login = new System.Windows.Forms.Panel();
            this.wrongLabel = new System.Windows.Forms.Label();
            this.panel2_Login = new System.Windows.Forms.Panel();
            this.btn_StudentLogin = new System.Windows.Forms.Button();
            this.lblStdnt = new System.Windows.Forms.Label();
            this.txtfldStudentID = new System.Windows.Forms.TextBox();
            this.lblStudent = new System.Windows.Forms.Label();
            this.picbox_Login = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabelSignUp = new System.Windows.Forms.LinkLabel();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.panel1_Login.SuspendLayout();
            this.panel2_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Cooper Black", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_Title.Location = new System.Drawing.Point(692, 32);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(348, 69);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "w i z z l e r";
            // 
            // lbl_UserType
            // 
            this.lbl_UserType.AutoSize = true;
            this.lbl_UserType.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserType.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_UserType.Location = new System.Drawing.Point(714, 115);
            this.lbl_UserType.Name = "lbl_UserType";
            this.lbl_UserType.Size = new System.Drawing.Size(107, 17);
            this.lbl_UserType.TabIndex = 1;
            this.lbl_UserType.Text = "Select User Type";
            // 
            // cmbUserType
            // 
            this.cmbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserType.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUserType.FormattingEnabled = true;
            this.cmbUserType.Items.AddRange(new object[] {
            "Student",
            "Instructor"});
            this.cmbUserType.Location = new System.Drawing.Point(717, 147);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(204, 28);
            this.cmbUserType.TabIndex = 2;
            this.cmbUserType.SelectedIndexChanged += new System.EventHandler(this.cmbUserType_SelectedIndexChanged);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.White;
            this.btn_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Exit.BackgroundImage")));
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Exit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Location = new System.Drawing.Point(1015, 7);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(24, 22);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_InstructorLogin
            // 
            this.lbl_InstructorLogin.AutoSize = true;
            this.lbl_InstructorLogin.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InstructorLogin.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_InstructorLogin.Location = new System.Drawing.Point(54, 14);
            this.lbl_InstructorLogin.Name = "lbl_InstructorLogin";
            this.lbl_InstructorLogin.Size = new System.Drawing.Size(171, 21);
            this.lbl_InstructorLogin.TabIndex = 0;
            this.lbl_InstructorLogin.Text = "Instructor Login";
            // 
            // txtfldUsername
            // 
            this.txtfldUsername.AcceptsTab = true;
            this.txtfldUsername.BackColor = System.Drawing.Color.LightGray;
            this.txtfldUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfldUsername.Location = new System.Drawing.Point(35, 73);
            this.txtfldUsername.Name = "txtfldUsername";
            this.txtfldUsername.Size = new System.Drawing.Size(204, 23);
            this.txtfldUsername.TabIndex = 1;
            // 
            // txtfldPassword
            // 
            this.txtfldPassword.AcceptsTab = true;
            this.txtfldPassword.BackColor = System.Drawing.Color.LightGray;
            this.txtfldPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfldPassword.Location = new System.Drawing.Point(35, 129);
            this.txtfldPassword.Name = "txtfldPassword";
            this.txtfldPassword.PasswordChar = '*';
            this.txtfldPassword.Size = new System.Drawing.Size(204, 23);
            this.txtfldPassword.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Silver;
            this.lblUsername.Location = new System.Drawing.Point(38, 50);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(71, 17);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Silver;
            this.lblPassword.Location = new System.Drawing.Point(38, 109);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // chkbx_Password
            // 
            this.chkbx_Password.AutoSize = true;
            this.chkbx_Password.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbx_Password.Location = new System.Drawing.Point(85, 161);
            this.chkbx_Password.Name = "chkbx_Password";
            this.chkbx_Password.Size = new System.Drawing.Size(110, 20);
            this.chkbx_Password.TabIndex = 7;
            this.chkbx_Password.Text = "Show Password";
            this.chkbx_Password.UseVisualStyleBackColor = true;
            this.chkbx_Password.CheckedChanged += new System.EventHandler(this.chkbx_Password_CheckedChanged);
            // 
            // btn_InstructorLogin
            // 
            this.btn_InstructorLogin.FlatAppearance.BorderSize = 18;
            this.btn_InstructorLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InstructorLogin.Location = new System.Drawing.Point(70, 187);
            this.btn_InstructorLogin.Name = "btn_InstructorLogin";
            this.btn_InstructorLogin.Size = new System.Drawing.Size(138, 25);
            this.btn_InstructorLogin.TabIndex = 8;
            this.btn_InstructorLogin.Text = "Login";
            this.btn_InstructorLogin.UseVisualStyleBackColor = true;
            this.btn_InstructorLogin.Click += new System.EventHandler(this.btn_InstructorLogin_Click);
            // 
            // panel1_Login
            // 
            this.panel1_Login.Controls.Add(this.wrongLabel);
            this.panel1_Login.Controls.Add(this.btn_InstructorLogin);
            this.panel1_Login.Controls.Add(this.chkbx_Password);
            this.panel1_Login.Controls.Add(this.lblPassword);
            this.panel1_Login.Controls.Add(this.lblUsername);
            this.panel1_Login.Controls.Add(this.txtfldPassword);
            this.panel1_Login.Controls.Add(this.txtfldUsername);
            this.panel1_Login.Controls.Add(this.lbl_InstructorLogin);
            this.panel1_Login.Location = new System.Drawing.Point(686, 190);
            this.panel1_Login.Name = "panel1_Login";
            this.panel1_Login.Size = new System.Drawing.Size(271, 257);
            this.panel1_Login.TabIndex = 4;
            // 
            // wrongLabel
            // 
            this.wrongLabel.AutoSize = true;
            this.wrongLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongLabel.ForeColor = System.Drawing.Color.Red;
            this.wrongLabel.Location = new System.Drawing.Point(38, 228);
            this.wrongLabel.Name = "wrongLabel";
            this.wrongLabel.Size = new System.Drawing.Size(211, 16);
            this.wrongLabel.TabIndex = 10;
            this.wrongLabel.Text = "Incorrect USERNAME or PASSWORD";
            this.wrongLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel2_Login
            // 
            this.panel2_Login.Controls.Add(this.btn_StudentLogin);
            this.panel2_Login.Controls.Add(this.lblStdnt);
            this.panel2_Login.Controls.Add(this.txtfldStudentID);
            this.panel2_Login.Controls.Add(this.lblStudent);
            this.panel2_Login.Location = new System.Drawing.Point(686, 190);
            this.panel2_Login.Name = "panel2_Login";
            this.panel2_Login.Size = new System.Drawing.Size(274, 257);
            this.panel2_Login.TabIndex = 9;
            // 
            // btn_StudentLogin
            // 
            this.btn_StudentLogin.FlatAppearance.BorderSize = 18;
            this.btn_StudentLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StudentLogin.Location = new System.Drawing.Point(70, 154);
            this.btn_StudentLogin.Name = "btn_StudentLogin";
            this.btn_StudentLogin.Size = new System.Drawing.Size(138, 25);
            this.btn_StudentLogin.TabIndex = 8;
            this.btn_StudentLogin.Text = "Login";
            this.btn_StudentLogin.UseVisualStyleBackColor = true;
            // 
            // lblStdnt
            // 
            this.lblStdnt.AutoSize = true;
            this.lblStdnt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStdnt.ForeColor = System.Drawing.Color.Silver;
            this.lblStdnt.Location = new System.Drawing.Point(38, 74);
            this.lblStdnt.Name = "lblStdnt";
            this.lblStdnt.Size = new System.Drawing.Size(99, 17);
            this.lblStdnt.TabIndex = 5;
            this.lblStdnt.Text = "Student ID no.";
            // 
            // txtfldStudentID
            // 
            this.txtfldStudentID.AcceptsTab = true;
            this.txtfldStudentID.BackColor = System.Drawing.Color.LightGray;
            this.txtfldStudentID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfldStudentID.Location = new System.Drawing.Point(35, 97);
            this.txtfldStudentID.Name = "txtfldStudentID";
            this.txtfldStudentID.Size = new System.Drawing.Size(204, 23);
            this.txtfldStudentID.TabIndex = 1;
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblStudent.Location = new System.Drawing.Point(64, 20);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(147, 21);
            this.lblStudent.TabIndex = 0;
            this.lblStudent.Text = "Student Login";
            // 
            // picbox_Login
            // 
            this.picbox_Login.Image = ((System.Drawing.Image)(resources.GetObject("picbox_Login.Image")));
            this.picbox_Login.Location = new System.Drawing.Point(0, 0);
            this.picbox_Login.Name = "picbox_Login";
            this.picbox_Login.Size = new System.Drawing.Size(578, 521);
            this.picbox_Login.TabIndex = 5;
            this.picbox_Login.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(598, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabelSignUp
            // 
            this.linkLabelSignUp.AutoSize = true;
            this.linkLabelSignUp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelSignUp.LinkColor = System.Drawing.Color.SaddleBrown;
            this.linkLabelSignUp.Location = new System.Drawing.Point(869, 476);
            this.linkLabelSignUp.Name = "linkLabelSignUp";
            this.linkLabelSignUp.Size = new System.Drawing.Size(52, 17);
            this.linkLabelSignUp.TabIndex = 12;
            this.linkLabelSignUp.TabStop = true;
            this.linkLabelSignUp.Text = "Sign Up";
            this.linkLabelSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSignUp_LinkClicked);
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.ForeColor = System.Drawing.Color.Black;
            this.lblSignUp.Location = new System.Drawing.Point(720, 476);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(152, 17);
            this.lblSignUp.TabIndex = 13;
            this.lblSignUp.Text = "Don\'t have an account?";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1047, 521);
            this.Controls.Add(this.lblSignUp);
            this.Controls.Add(this.linkLabelSignUp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2_Login);
            this.Controls.Add(this.picbox_Login);
            this.Controls.Add(this.panel1_Login);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.cmbUserType);
            this.Controls.Add(this.lbl_UserType);
            this.Controls.Add(this.lbl_Title);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(128)))), ((int)(((byte)(82)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1_Login.ResumeLayout(false);
            this.panel1_Login.PerformLayout();
            this.panel2_Login.ResumeLayout(false);
            this.panel2_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_UserType;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.Button btn_Exit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl_InstructorLogin;
        private System.Windows.Forms.TextBox txtfldUsername;
        private System.Windows.Forms.TextBox txtfldPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.CheckBox chkbx_Password;
        private System.Windows.Forms.Button btn_InstructorLogin;
        private System.Windows.Forms.Panel panel1_Login;
        private System.Windows.Forms.PictureBox picbox_Login;
        private System.Windows.Forms.Panel panel2_Login;
        private System.Windows.Forms.Button btn_StudentLogin;
        private System.Windows.Forms.Label lblStdnt;
        private System.Windows.Forms.TextBox txtfldStudentID;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label wrongLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabelSignUp;
        private System.Windows.Forms.Label lblSignUp;
    }
}