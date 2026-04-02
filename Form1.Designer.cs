namespace LoginScreen
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
            lblAppName = new Label();
            txtID = new TextBox();
            txtPW = new TextBox();
            btnLogin = new Button();
            lblErrorMsg = new Label();
            btnDelete = new Button();
            btnLP = new Button();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("한컴 고딕", 48F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.Location = new Point(273, 9);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(246, 104);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Login";
            lblAppName.Click += lblAppName_Click;
            // 
            // txtID
            // 
            txtID.Font = new Font("맑은 고딕", 28F);
            txtID.ForeColor = Color.Silver;
            txtID.Location = new Point(101, 116);
            txtID.Name = "txtID";
            txtID.Size = new Size(611, 70);
            txtID.TabIndex = 2;
            txtID.Text = "아이디";
            txtID.Enter += txtID_Enter;
            txtID.KeyDown += txtID_KeyDown;
            txtID.Leave += txtID_Leave;
            // 
            // txtPW
            // 
            txtPW.Font = new Font("맑은 고딕", 28F);
            txtPW.ForeColor = Color.Silver;
            txtPW.Location = new Point(101, 207);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(611, 70);
            txtPW.TabIndex = 3;
            txtPW.Text = "패스워드";
            txtPW.Enter += txtPW_Enter;
            txtPW.KeyDown += txtPW_KeyDown;
            txtPW.Leave += txtPW_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(192, 192, 255);
            btnLogin.Font = new Font("맑은 고딕", 25F);
            btnLogin.ForeColor = Color.Blue;
            btnLogin.Location = new Point(260, 326);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(277, 99);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.ForeColor = Color.IndianRed;
            lblErrorMsg.Location = new Point(111, 292);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(282, 20);
            lblErrorMsg.TabIndex = 4;
            lblErrorMsg.Text = "아이디 또는 비밀번호가 잘못되었습니다.";
            lblErrorMsg.Visible = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkGray;
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(663, 226);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(32, 29);
            btnDelete.TabIndex = 5;
            btnDelete.TabStop = false;
            btnDelete.Text = "X";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLP
            // 
            btnLP.Location = new Point(620, 226);
            btnLP.Name = "btnLP";
            btnLP.Size = new Size(37, 29);
            btnLP.TabIndex = 6;
            btnLP.TabStop = false;
            btnLP.Text = "O";
            btnLP.UseVisualStyleBackColor = true;
            btnLP.MouseDown += btnLP_MouseDown;
            btnLP.MouseUp += btnLP_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLP);
            Controls.Add(btnDelete);
            Controls.Add(lblErrorMsg);
            Controls.Add(btnLogin);
            Controls.Add(txtPW);
            Controls.Add(txtID);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Login Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private TextBox txtID;
        private TextBox txtPW;
        private Button btnLogin;
        private Label lblErrorMsg;
        private Button btnDelete;
        private Button btnLP;
    }
}
