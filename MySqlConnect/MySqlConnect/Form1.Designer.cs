namespace MySqlConnect
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
            NameBox = new TextBox();
            AgeBox = new TextBox();
            JoinButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 51);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "이름 : ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 90);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "나이 : ";
            label2.Click += label2_Click;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(167, 48);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(100, 23);
            NameBox.TabIndex = 2;
            // 
            // AgeBox
            // 
            AgeBox.Location = new Point(167, 87);
            AgeBox.Name = "AgeBox";
            AgeBox.Size = new Size(100, 23);
            AgeBox.TabIndex = 3;
            // 
            // JoinButton
            // 
            JoinButton.Location = new Point(145, 133);
            JoinButton.Name = "JoinButton";
            JoinButton.Size = new Size(100, 23);
            JoinButton.TabIndex = 4;
            JoinButton.Text = "가입";
            JoinButton.UseVisualStyleBackColor = true;
            JoinButton.Click += JoinButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 168);
            Controls.Add(JoinButton);
            Controls.Add(AgeBox);
            Controls.Add(NameBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox NameBox;
        private TextBox AgeBox;
        private Button JoinButton;
    }
}