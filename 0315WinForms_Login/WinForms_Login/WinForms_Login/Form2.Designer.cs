namespace WinForms_Login
{
    partial class Form2
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
            btn_newmember = new Button();
            txtbox_pwd = new TextBox();
            txtbox_id = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtbox_name = new TextBox();
            SuspendLayout();
            // 
            // btn_newmember
            // 
            btn_newmember.Location = new Point(87, 135);
            btn_newmember.Name = "btn_newmember";
            btn_newmember.Size = new Size(130, 31);
            btn_newmember.TabIndex = 9;
            btn_newmember.Text = "회원가입";
            btn_newmember.UseVisualStyleBackColor = true;
            btn_newmember.Click += btn_newmember_Click;
            // 
            // txtbox_pwd
            // 
            txtbox_pwd.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_pwd.Location = new Point(134, 88);
            txtbox_pwd.Name = "txtbox_pwd";
            txtbox_pwd.Size = new Size(130, 29);
            txtbox_pwd.TabIndex = 8;
            txtbox_pwd.TextChanged += txtbox_pwd_TextChanged;
            // 
            // txtbox_id
            // 
            txtbox_id.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_id.Location = new Point(134, 53);
            txtbox_id.Name = "txtbox_id";
            txtbox_id.Size = new Size(130, 29);
            txtbox_id.TabIndex = 7;
            txtbox_id.TextChanged += txtbox_id_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(37, 91);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 6;
            label2.Text = "비밀번호";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(37, 56);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 5;
            label1.Text = "아이디";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(37, 19);
            label3.Name = "label3";
            label3.Size = new Size(42, 21);
            label3.TabIndex = 10;
            label3.Text = "이름";
            // 
            // txtbox_name
            // 
            txtbox_name.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_name.Location = new Point(134, 16);
            txtbox_name.Name = "txtbox_name";
            txtbox_name.Size = new Size(130, 29);
            txtbox_name.TabIndex = 11;
            txtbox_name.TextChanged += txtbox_name_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 196);
            Controls.Add(txtbox_name);
            Controls.Add(label3);
            Controls.Add(btn_newmember);
            Controls.Add(txtbox_pwd);
            Controls.Add(txtbox_id);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_newmember;
        private TextBox txtbox_pwd;
        private TextBox txtbox_id;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtbox_name;
    }
}