namespace HRIMS
{
    partial class SettingForm
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
            this.buttonBackup = new System.Windows.Forms.Button();
            this.buttonRecover = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.radioRoom = new System.Windows.Forms.RadioButton();
            this.radioGuest = new System.Windows.Forms.RadioButton();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textDbname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSu = new System.Windows.Forms.Button();
            this.textPwd1 = new System.Windows.Forms.TextBox();
            this.textIp = new System.Windows.Forms.TextBox();
            this.textPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelErr = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textUserpwd1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textUserpwd = new System.Windows.Forms.TextBox();
            this.listUser = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.labelWait = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBackup
            // 
            this.buttonBackup.Location = new System.Drawing.Point(79, 51);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(90, 41);
            this.buttonBackup.TabIndex = 8;
            this.buttonBackup.Text = "备份数据";
            this.buttonBackup.UseVisualStyleBackColor = true;
            this.buttonBackup.Click += new System.EventHandler(this.buttonBackup_Click);
            // 
            // buttonRecover
            // 
            this.buttonRecover.Location = new System.Drawing.Point(79, 139);
            this.buttonRecover.Name = "buttonRecover";
            this.buttonRecover.Size = new System.Drawing.Size(90, 42);
            this.buttonRecover.TabIndex = 9;
            this.buttonRecover.Text = "恢复数据";
            this.buttonRecover.UseVisualStyleBackColor = true;
            this.buttonRecover.Click += new System.EventHandler(this.buttonRecover_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(92, 213);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(90, 42);
            this.buttonPrint.TabIndex = 12;
            this.buttonPrint.Text = "生成报表";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // radioRoom
            // 
            this.radioRoom.AutoSize = true;
            this.radioRoom.Location = new System.Drawing.Point(92, 139);
            this.radioRoom.Name = "radioRoom";
            this.radioRoom.Size = new System.Drawing.Size(92, 25);
            this.radioRoom.TabIndex = 11;
            this.radioRoom.TabStop = true;
            this.radioRoom.Text = "客房信息";
            this.radioRoom.UseVisualStyleBackColor = true;
            // 
            // radioGuest
            // 
            this.radioGuest.AutoSize = true;
            this.radioGuest.Location = new System.Drawing.Point(92, 81);
            this.radioGuest.Name = "radioGuest";
            this.radioGuest.Size = new System.Drawing.Size(92, 25);
            this.radioGuest.TabIndex = 10;
            this.radioGuest.TabStop = true;
            this.radioGuest.Text = "宾客信息";
            this.radioGuest.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(22, 30);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1074, 588);
            this.tabControl.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.textDbname);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.buttonSu);
            this.tabPage1.Controls.Add(this.textPwd1);
            this.tabPage1.Controls.Add(this.textIp);
            this.tabPage1.Controls.Add(this.textPwd);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textName);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1066, 554);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "管理员设置";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(493, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "格式为x.x.x.x";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(493, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 11;
            // 
            // textDbname
            // 
            this.textDbname.Location = new System.Drawing.Point(496, 145);
            this.textDbname.Name = "textDbname";
            this.textDbname.ReadOnly = true;
            this.textDbname.Size = new System.Drawing.Size(191, 29);
            this.textDbname.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "数据库名";
            // 
            // buttonSu
            // 
            this.buttonSu.Location = new System.Drawing.Point(496, 448);
            this.buttonSu.Name = "buttonSu";
            this.buttonSu.Size = new System.Drawing.Size(100, 51);
            this.buttonSu.TabIndex = 8;
            this.buttonSu.Text = "提交";
            this.buttonSu.UseVisualStyleBackColor = true;
            this.buttonSu.Click += new System.EventHandler(this.buttonSu_Click);
            // 
            // textPwd1
            // 
            this.textPwd1.Location = new System.Drawing.Point(496, 356);
            this.textPwd1.Name = "textPwd1";
            this.textPwd1.PasswordChar = '*';
            this.textPwd1.Size = new System.Drawing.Size(191, 29);
            this.textPwd1.TabIndex = 7;
            // 
            // textIp
            // 
            this.textIp.Location = new System.Drawing.Point(496, 65);
            this.textIp.Name = "textIp";
            this.textIp.Size = new System.Drawing.Size(191, 29);
            this.textIp.TabIndex = 1;
            // 
            // textPwd
            // 
            this.textPwd.Location = new System.Drawing.Point(496, 285);
            this.textPwd.Name = "textPwd";
            this.textPwd.PasswordChar = '*';
            this.textPwd.Size = new System.Drawing.Size(191, 29);
            this.textPwd.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器IP";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(496, 216);
            this.textName.Name = "textName";
            this.textName.ReadOnly = true;
            this.textName.Size = new System.Drawing.Size(191, 29);
            this.textName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "确认密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "用户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "密  码";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.listUser);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1066, 554);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "用户设置";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(666, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 137);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "用户注销";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 41);
            this.button1.TabIndex = 14;
            this.button1.Text = "注销";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelErr);
            this.groupBox1.Controls.Add(this.buttonOK);
            this.groupBox1.Controls.Add(this.textUserpwd1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textUserpwd);
            this.groupBox1.Location = new System.Drawing.Point(666, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 262);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户修改";
            // 
            // labelErr
            // 
            this.labelErr.AutoSize = true;
            this.labelErr.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelErr.ForeColor = System.Drawing.Color.Red;
            this.labelErr.Location = new System.Drawing.Point(120, 154);
            this.labelErr.Name = "labelErr";
            this.labelErr.Size = new System.Drawing.Size(0, 17);
            this.labelErr.TabIndex = 14;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(116, 195);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(88, 41);
            this.buttonOK.TabIndex = 9;
            this.buttonOK.Text = "修改";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textUserpwd1
            // 
            this.textUserpwd1.Location = new System.Drawing.Point(116, 122);
            this.textUserpwd1.Name = "textUserpwd1";
            this.textUserpwd1.PasswordChar = '*';
            this.textUserpwd1.Size = new System.Drawing.Size(194, 29);
            this.textUserpwd1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "确认密码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "密    码";
            // 
            // textUserpwd
            // 
            this.textUserpwd.Location = new System.Drawing.Point(116, 47);
            this.textUserpwd.Name = "textUserpwd";
            this.textUserpwd.PasswordChar = '*';
            this.textUserpwd.Size = new System.Drawing.Size(194, 29);
            this.textUserpwd.TabIndex = 9;
            // 
            // listUser
            // 
            this.listUser.CheckBoxes = true;
            this.listUser.FullRowSelect = true;
            this.listUser.GridLines = true;
            this.listUser.Location = new System.Drawing.Point(31, 24);
            this.listUser.Name = "listUser";
            this.listUser.Size = new System.Drawing.Size(567, 490);
            this.listUser.TabIndex = 11;
            this.listUser.UseCompatibleStateImageBehavior = false;
            this.listUser.View = System.Windows.Forms.View.Details;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1066, 554);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "数据管理";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonPrint);
            this.groupBox4.Controls.Add(this.radioRoom);
            this.groupBox4.Controls.Add(this.radioGuest);
            this.groupBox4.Location = new System.Drawing.Point(624, 49);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(295, 341);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.labelWait);
            this.groupBox3.Controls.Add(this.buttonBackup);
            this.groupBox3.Controls.Add(this.buttonRecover);
            this.groupBox3.Location = new System.Drawing.Point(146, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 341);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(79, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 42);
            this.button2.TabIndex = 11;
            this.button2.Text = "分类统计";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelWait
            // 
            this.labelWait.AutoSize = true;
            this.labelWait.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelWait.ForeColor = System.Drawing.Color.Red;
            this.labelWait.Location = new System.Drawing.Point(75, 262);
            this.labelWait.Name = "labelWait";
            this.labelWait.Size = new System.Drawing.Size(0, 20);
            this.labelWait.TabIndex = 10;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 630);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SettingForm";
            this.Text = "SettingForm";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBackup;
        private System.Windows.Forms.Button buttonRecover;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.RadioButton radioRoom;
        private System.Windows.Forms.RadioButton radioGuest;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonSu;
        private System.Windows.Forms.TextBox textPwd1;
        private System.Windows.Forms.TextBox textPwd;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textIp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textUserpwd1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listUser;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textDbname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textUserpwd;
        private System.Windows.Forms.Label labelErr;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelWait;
        private System.Windows.Forms.Button button2;
    }
}