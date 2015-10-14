namespace HRIMS
{
    partial class LoginWin
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
            this.userName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.LgroupBox = new System.Windows.Forms.GroupBox();
            this.radioSu = new System.Windows.Forms.RadioButton();
            this.radioUser = new System.Windows.Forms.RadioButton();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPwd = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.LgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userName.Location = new System.Drawing.Point(200, 94);
            this.userName.Margin = new System.Windows.Forms.Padding(6);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(225, 33);
            this.userName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名";
            // 
            // userPwd
            // 
            this.userPwd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userPwd.Location = new System.Drawing.Point(200, 179);
            this.userPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userPwd.Name = "userPwd";
            this.userPwd.PasswordChar = '*';
            this.userPwd.Size = new System.Drawing.Size(225, 33);
            this.userPwd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "密  码";
            // 
            // Login
            // 
            this.Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login.Location = new System.Drawing.Point(131, 354);
            this.Login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(89, 50);
            this.Login.TabIndex = 4;
            this.Login.Text = "登录";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // LgroupBox
            // 
            this.LgroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LgroupBox.Controls.Add(this.radioSu);
            this.LgroupBox.Controls.Add(this.radioUser);
            this.LgroupBox.Controls.Add(this.labelLogin);
            this.LgroupBox.Controls.Add(this.labelPwd);
            this.LgroupBox.Controls.Add(this.labelUser);
            this.LgroupBox.Controls.Add(this.buttonClear);
            this.LgroupBox.Controls.Add(this.Login);
            this.LgroupBox.Controls.Add(this.label2);
            this.LgroupBox.Controls.Add(this.userPwd);
            this.LgroupBox.Controls.Add(this.label1);
            this.LgroupBox.Controls.Add(this.userName);
            this.LgroupBox.Location = new System.Drawing.Point(267, 68);
            this.LgroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LgroupBox.Name = "LgroupBox";
            this.LgroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LgroupBox.Size = new System.Drawing.Size(569, 460);
            this.LgroupBox.TabIndex = 6;
            this.LgroupBox.TabStop = false;
            // 
            // radioSu
            // 
            this.radioSu.AutoSize = true;
            this.radioSu.Location = new System.Drawing.Point(338, 266);
            this.radioSu.Name = "radioSu";
            this.radioSu.Size = new System.Drawing.Size(87, 29);
            this.radioSu.TabIndex = 10;
            this.radioSu.Text = "管理员";
            this.radioSu.UseVisualStyleBackColor = true;
            // 
            // radioUser
            // 
            this.radioUser.AutoSize = true;
            this.radioUser.Checked = true;
            this.radioUser.Location = new System.Drawing.Point(131, 266);
            this.radioUser.Name = "radioUser";
            this.radioUser.Size = new System.Drawing.Size(106, 29);
            this.radioUser.TabIndex = 9;
            this.radioUser.TabStop = true;
            this.radioUser.Text = "普通用户";
            this.radioUser.UseVisualStyleBackColor = true;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLogin.ForeColor = System.Drawing.Color.Red;
            this.labelLogin.Location = new System.Drawing.Point(159, 237);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(0, 17);
            this.labelLogin.TabIndex = 8;
            // 
            // labelPwd
            // 
            this.labelPwd.AutoSize = true;
            this.labelPwd.ForeColor = System.Drawing.Color.Red;
            this.labelPwd.Location = new System.Drawing.Point(431, 182);
            this.labelPwd.Name = "labelPwd";
            this.labelPwd.Size = new System.Drawing.Size(21, 25);
            this.labelPwd.TabIndex = 7;
            this.labelPwd.Text = "*";
            this.labelPwd.Visible = false;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.ForeColor = System.Drawing.Color.Red;
            this.labelUser.Location = new System.Drawing.Point(431, 97);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(21, 25);
            this.labelUser.TabIndex = 6;
            this.labelUser.Text = "*";
            this.labelUser.Visible = false;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(334, 354);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(91, 50);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "清空";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // LoginWin
            // 
            this.AcceptButton = this.Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1108, 630);
            this.Controls.Add(this.LgroupBox);
            this.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LoginWin";
            this.Text = "LoginWin";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.LgroupBox.ResumeLayout(false);
            this.LgroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.GroupBox LgroupBox;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelPwd;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.RadioButton radioSu;
        private System.Windows.Forms.RadioButton radioUser;

    }
}