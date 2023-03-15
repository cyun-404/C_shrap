namespace WinForms_Login
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
            label1 = new Label();
            label2 = new Label();
            txtbox_id = new TextBox();
            txtbox_pwd = new TextBox();
            btn_newmember = new Button();
            btn_login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 51);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 0;
            label1.Text = "아이디";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(36, 86);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 1;
            label2.Text = "비밀번호";
            label2.Click += label2_Click;
            // 
            // txtbox_id
            // 
            txtbox_id.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_id.Location = new Point(133, 48);
            txtbox_id.Name = "txtbox_id";
            txtbox_id.Size = new Size(130, 29);
            txtbox_id.TabIndex = 2;
            txtbox_id.TextChanged += textBox1_TextChanged;
            // 
            // txtbox_pwd
            // 
            txtbox_pwd.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_pwd.Location = new Point(133, 83);
            txtbox_pwd.Name = "txtbox_pwd";
            txtbox_pwd.Size = new Size(130, 29);
            txtbox_pwd.TabIndex = 3;
            txtbox_pwd.TextChanged += txtbox_pwd_TextChanged;
            // 
            // btn_newmember
            // 
            btn_newmember.Location = new Point(159, 139);
            btn_newmember.Name = "btn_newmember";
            btn_newmember.Size = new Size(130, 31);
            btn_newmember.TabIndex = 4;
            btn_newmember.Text = "회원가입";
            btn_newmember.UseVisualStyleBackColor = true;
            btn_newmember.Click += btn_newmember_Click;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(23, 139);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(130, 31);
            btn_login.TabIndex = 5;
            btn_login.Text = "로그인";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 196);
            Controls.Add(btn_login);
            Controls.Add(btn_newmember);
            Controls.Add(txtbox_pwd);
            Controls.Add(txtbox_id);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtbox_id;
        private TextBox txtbox_pwd;
        private Button btn_newmember;
        private Button btn_login;
    }
}