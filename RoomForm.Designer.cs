namespace HRIMS
{
    partial class RoomForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.groupRoom = new System.Windows.Forms.GroupBox();
            this.buttonARoom = new System.Windows.Forms.Button();
            this.combType2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roomNum = new System.Windows.Forms.TextBox();
            this.groupType = new System.Windows.Forms.GroupBox();
            this.combType1 = new System.Windows.Forms.ComboBox();
            this.typeNum = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.buttonAType = new System.Windows.Forms.Button();
            this.textPrize = new System.Windows.Forms.TextBox();
            this.tabUpdate = new System.Windows.Forms.TabPage();
            this.groupRoom2 = new System.Windows.Forms.GroupBox();
            this.buttonCRoom = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.combRoom1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.combType4 = new System.Windows.Forms.ComboBox();
            this.groupType2 = new System.Windows.Forms.GroupBox();
            this.checkNew = new System.Windows.Forms.CheckBox();
            this.buttonCType = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.newPrize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combType3 = new System.Windows.Forms.ComboBox();
            this.newType = new System.Windows.Forms.TextBox();
            this.tabDel = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.combRoom2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.combType5 = new System.Windows.Forms.ComboBox();
            this.tabQuery = new System.Windows.Forms.TabPage();
            this.radioRoom = new System.Windows.Forms.RadioButton();
            this.radioType = new System.Windows.Forms.RadioButton();
            this.combRoom3 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.combType6 = new System.Windows.Forms.ComboBox();
            this.roomList = new System.Windows.Forms.ListView();
            this.buttonOk = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabAdd.SuspendLayout();
            this.groupRoom.SuspendLayout();
            this.groupType.SuspendLayout();
            this.tabUpdate.SuspendLayout();
            this.groupRoom2.SuspendLayout();
            this.groupType2.SuspendLayout();
            this.tabDel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabQuery.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAdd);
            this.tabControl1.Controls.Add(this.tabUpdate);
            this.tabControl1.Controls.Add(this.tabDel);
            this.tabControl1.Controls.Add(this.tabQuery);
            this.tabControl1.Location = new System.Drawing.Point(12, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1084, 596);
            this.tabControl1.TabIndex = 0;
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.groupRoom);
            this.tabAdd.Controls.Add(this.groupType);
            this.tabAdd.Location = new System.Drawing.Point(4, 30);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(1076, 562);
            this.tabAdd.TabIndex = 0;
            this.tabAdd.Text = "信息录入";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // groupRoom
            // 
            this.groupRoom.Controls.Add(this.buttonARoom);
            this.groupRoom.Controls.Add(this.combType2);
            this.groupRoom.Controls.Add(this.label3);
            this.groupRoom.Controls.Add(this.label2);
            this.groupRoom.Controls.Add(this.roomNum);
            this.groupRoom.Location = new System.Drawing.Point(536, 37);
            this.groupRoom.Name = "groupRoom";
            this.groupRoom.Size = new System.Drawing.Size(426, 431);
            this.groupRoom.TabIndex = 13;
            this.groupRoom.TabStop = false;
            this.groupRoom.Text = "客房录入";
            // 
            // buttonARoom
            // 
            this.buttonARoom.Location = new System.Drawing.Point(167, 298);
            this.buttonARoom.Name = "buttonARoom";
            this.buttonARoom.Size = new System.Drawing.Size(79, 37);
            this.buttonARoom.TabIndex = 13;
            this.buttonARoom.Text = "确定";
            this.buttonARoom.UseVisualStyleBackColor = true;
            this.buttonARoom.Click += new System.EventHandler(this.buttonAgain_Click);
            // 
            // combType2
            // 
            this.combType2.FormattingEnabled = true;
            this.combType2.Location = new System.Drawing.Point(167, 85);
            this.combType2.Name = "combType2";
            this.combType2.Size = new System.Drawing.Size(159, 29);
            this.combType2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "客房号";
            this.label3.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "客房类型";
            this.label2.UseMnemonic = false;
            // 
            // roomNum
            // 
            this.roomNum.Location = new System.Drawing.Point(167, 192);
            this.roomNum.Name = "roomNum";
            this.roomNum.Size = new System.Drawing.Size(159, 29);
            this.roomNum.TabIndex = 4;
            // 
            // groupType
            // 
            this.groupType.Controls.Add(this.combType1);
            this.groupType.Controls.Add(this.typeNum);
            this.groupType.Controls.Add(this.label13);
            this.groupType.Controls.Add(this.label1);
            this.groupType.Controls.Add(this.lable1);
            this.groupType.Controls.Add(this.buttonAType);
            this.groupType.Controls.Add(this.textPrize);
            this.groupType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupType.Location = new System.Drawing.Point(62, 37);
            this.groupType.Name = "groupType";
            this.groupType.Size = new System.Drawing.Size(423, 431);
            this.groupType.TabIndex = 12;
            this.groupType.TabStop = false;
            this.groupType.Text = "类型定价";
            // 
            // combType1
            // 
            this.combType1.FormattingEnabled = true;
            this.combType1.Location = new System.Drawing.Point(160, 135);
            this.combType1.Name = "combType1";
            this.combType1.Size = new System.Drawing.Size(159, 29);
            this.combType1.TabIndex = 13;
            // 
            // typeNum
            // 
            this.typeNum.Location = new System.Drawing.Point(160, 70);
            this.typeNum.Name = "typeNum";
            this.typeNum.Size = new System.Drawing.Size(159, 29);
            this.typeNum.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(70, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 21);
            this.label13.TabIndex = 11;
            this.label13.Text = "类型编号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "价  格";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(70, 138);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(74, 21);
            this.lable1.TabIndex = 8;
            this.lable1.Text = "客房类型";
            // 
            // buttonAType
            // 
            this.buttonAType.Location = new System.Drawing.Point(160, 311);
            this.buttonAType.Name = "buttonAType";
            this.buttonAType.Size = new System.Drawing.Size(79, 36);
            this.buttonAType.TabIndex = 6;
            this.buttonAType.Text = "确定";
            this.buttonAType.UseVisualStyleBackColor = true;
            this.buttonAType.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // textPrize
            // 
            this.textPrize.Location = new System.Drawing.Point(160, 217);
            this.textPrize.Name = "textPrize";
            this.textPrize.Size = new System.Drawing.Size(159, 29);
            this.textPrize.TabIndex = 1;
            // 
            // tabUpdate
            // 
            this.tabUpdate.Controls.Add(this.groupRoom2);
            this.tabUpdate.Controls.Add(this.groupType2);
            this.tabUpdate.Location = new System.Drawing.Point(4, 30);
            this.tabUpdate.Name = "tabUpdate";
            this.tabUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdate.Size = new System.Drawing.Size(1076, 562);
            this.tabUpdate.TabIndex = 1;
            this.tabUpdate.Text = "信息修改";
            this.tabUpdate.UseVisualStyleBackColor = true;
            // 
            // groupRoom2
            // 
            this.groupRoom2.Controls.Add(this.buttonCRoom);
            this.groupRoom2.Controls.Add(this.label7);
            this.groupRoom2.Controls.Add(this.combRoom1);
            this.groupRoom2.Controls.Add(this.label6);
            this.groupRoom2.Controls.Add(this.combType4);
            this.groupRoom2.Location = new System.Drawing.Point(562, 72);
            this.groupRoom2.Name = "groupRoom2";
            this.groupRoom2.Size = new System.Drawing.Size(415, 374);
            this.groupRoom2.TabIndex = 7;
            this.groupRoom2.TabStop = false;
            this.groupRoom2.Text = "客房修改";
            // 
            // buttonCRoom
            // 
            this.buttonCRoom.Location = new System.Drawing.Point(188, 281);
            this.buttonCRoom.Name = "buttonCRoom";
            this.buttonCRoom.Size = new System.Drawing.Size(76, 40);
            this.buttonCRoom.TabIndex = 8;
            this.buttonCRoom.Text = "确定";
            this.buttonCRoom.UseVisualStyleBackColor = true;
            this.buttonCRoom.Click += new System.EventHandler(this.button5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "客房号";
            // 
            // combRoom1
            // 
            this.combRoom1.FormattingEnabled = true;
            this.combRoom1.Location = new System.Drawing.Point(188, 182);
            this.combRoom1.Name = "combRoom1";
            this.combRoom1.Size = new System.Drawing.Size(147, 29);
            this.combRoom1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "类型名";
            // 
            // combType4
            // 
            this.combType4.FormattingEnabled = true;
            this.combType4.Location = new System.Drawing.Point(188, 88);
            this.combType4.Name = "combType4";
            this.combType4.Size = new System.Drawing.Size(147, 29);
            this.combType4.TabIndex = 4;
            // 
            // groupType2
            // 
            this.groupType2.Controls.Add(this.checkNew);
            this.groupType2.Controls.Add(this.buttonCType);
            this.groupType2.Controls.Add(this.label8);
            this.groupType2.Controls.Add(this.newPrize);
            this.groupType2.Controls.Add(this.label5);
            this.groupType2.Controls.Add(this.label4);
            this.groupType2.Controls.Add(this.combType3);
            this.groupType2.Controls.Add(this.newType);
            this.groupType2.Location = new System.Drawing.Point(41, 62);
            this.groupType2.Name = "groupType2";
            this.groupType2.Size = new System.Drawing.Size(386, 384);
            this.groupType2.TabIndex = 4;
            this.groupType2.TabStop = false;
            this.groupType2.Text = "类型修改";
            // 
            // checkNew
            // 
            this.checkNew.AutoSize = true;
            this.checkNew.Location = new System.Drawing.Point(292, 144);
            this.checkNew.Name = "checkNew";
            this.checkNew.Size = new System.Drawing.Size(15, 14);
            this.checkNew.TabIndex = 7;
            this.checkNew.UseVisualStyleBackColor = true;
            // 
            // buttonCType
            // 
            this.buttonCType.Location = new System.Drawing.Point(131, 302);
            this.buttonCType.Name = "buttonCType";
            this.buttonCType.Size = new System.Drawing.Size(76, 40);
            this.buttonCType.TabIndex = 6;
            this.buttonCType.Text = "确定";
            this.buttonCType.UseVisualStyleBackColor = true;
            this.buttonCType.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 21);
            this.label8.TabIndex = 5;
            this.label8.Text = "价  格";
            // 
            // newPrize
            // 
            this.newPrize.Location = new System.Drawing.Point(131, 219);
            this.newPrize.Name = "newPrize";
            this.newPrize.Size = new System.Drawing.Size(155, 29);
            this.newPrize.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "新类型";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "类型名";
            // 
            // combType3
            // 
            this.combType3.FormattingEnabled = true;
            this.combType3.Location = new System.Drawing.Point(131, 52);
            this.combType3.Name = "combType3";
            this.combType3.Size = new System.Drawing.Size(155, 29);
            this.combType3.TabIndex = 1;
            // 
            // newType
            // 
            this.newType.Location = new System.Drawing.Point(131, 137);
            this.newType.Name = "newType";
            this.newType.Size = new System.Drawing.Size(155, 29);
            this.newType.TabIndex = 0;
            // 
            // tabDel
            // 
            this.tabDel.Controls.Add(this.groupBox2);
            this.tabDel.Controls.Add(this.groupBox1);
            this.tabDel.Location = new System.Drawing.Point(4, 30);
            this.tabDel.Name = "tabDel";
            this.tabDel.Size = new System.Drawing.Size(1076, 562);
            this.tabDel.TabIndex = 2;
            this.tabDel.Text = "信息删除";
            this.tabDel.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.combRoom2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(119, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(777, 187);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "客房删除";
            // 
            // combRoom2
            // 
            this.combRoom2.FormattingEnabled = true;
            this.combRoom2.Location = new System.Drawing.Point(246, 85);
            this.combRoom2.Name = "combRoom2";
            this.combRoom2.Size = new System.Drawing.Size(193, 29);
            this.combRoom2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(511, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(163, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 21);
            this.label10.TabIndex = 1;
            this.label10.Text = "客房号";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDel);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.combType5);
            this.groupBox1.Location = new System.Drawing.Point(119, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 137);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "类型删除";
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(511, 55);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(90, 38);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "确定";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(166, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "类型";
            // 
            // combType5
            // 
            this.combType5.FormattingEnabled = true;
            this.combType5.Location = new System.Drawing.Point(246, 61);
            this.combType5.Name = "combType5";
            this.combType5.Size = new System.Drawing.Size(193, 29);
            this.combType5.TabIndex = 0;
            // 
            // tabQuery
            // 
            this.tabQuery.Controls.Add(this.radioRoom);
            this.tabQuery.Controls.Add(this.radioType);
            this.tabQuery.Controls.Add(this.combRoom3);
            this.tabQuery.Controls.Add(this.label12);
            this.tabQuery.Controls.Add(this.label11);
            this.tabQuery.Controls.Add(this.combType6);
            this.tabQuery.Controls.Add(this.roomList);
            this.tabQuery.Controls.Add(this.buttonOk);
            this.tabQuery.Location = new System.Drawing.Point(4, 30);
            this.tabQuery.Name = "tabQuery";
            this.tabQuery.Size = new System.Drawing.Size(1076, 562);
            this.tabQuery.TabIndex = 3;
            this.tabQuery.Text = "信息查询";
            this.tabQuery.UseVisualStyleBackColor = true;
            // 
            // radioRoom
            // 
            this.radioRoom.AutoSize = true;
            this.radioRoom.Location = new System.Drawing.Point(969, 181);
            this.radioRoom.Name = "radioRoom";
            this.radioRoom.Size = new System.Drawing.Size(92, 25);
            this.radioRoom.TabIndex = 12;
            this.radioRoom.TabStop = true;
            this.radioRoom.Text = "按客房号";
            this.radioRoom.UseVisualStyleBackColor = true;
            // 
            // radioType
            // 
            this.radioType.AutoSize = true;
            this.radioType.Location = new System.Drawing.Point(969, 109);
            this.radioType.Name = "radioType";
            this.radioType.Size = new System.Drawing.Size(76, 25);
            this.radioType.TabIndex = 11;
            this.radioType.TabStop = true;
            this.radioType.Text = "按类型";
            this.radioType.UseVisualStyleBackColor = true;
            // 
            // combRoom3
            // 
            this.combRoom3.FormattingEnabled = true;
            this.combRoom3.Location = new System.Drawing.Point(785, 180);
            this.combRoom3.Name = "combRoom3";
            this.combRoom3.Size = new System.Drawing.Size(165, 29);
            this.combRoom3.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(708, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 21);
            this.label12.TabIndex = 6;
            this.label12.Text = "客房号";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(712, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 21);
            this.label11.TabIndex = 5;
            this.label11.Text = "类型";
            // 
            // combType6
            // 
            this.combType6.FormattingEnabled = true;
            this.combType6.Location = new System.Drawing.Point(785, 108);
            this.combType6.Name = "combType6";
            this.combType6.Size = new System.Drawing.Size(165, 29);
            this.combType6.TabIndex = 3;
            // 
            // roomList
            // 
            this.roomList.FullRowSelect = true;
            this.roomList.GridLines = true;
            this.roomList.Location = new System.Drawing.Point(25, 30);
            this.roomList.Name = "roomList";
            this.roomList.Size = new System.Drawing.Size(649, 500);
            this.roomList.TabIndex = 1;
            this.roomList.UseCompatibleStateImageBehavior = false;
            this.roomList.View = System.Windows.Forms.View.Details;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(712, 287);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(89, 42);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "确定";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 630);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.tabControl1.ResumeLayout(false);
            this.tabAdd.ResumeLayout(false);
            this.groupRoom.ResumeLayout(false);
            this.groupRoom.PerformLayout();
            this.groupType.ResumeLayout(false);
            this.groupType.PerformLayout();
            this.tabUpdate.ResumeLayout(false);
            this.groupRoom2.ResumeLayout(false);
            this.groupRoom2.PerformLayout();
            this.groupType2.ResumeLayout(false);
            this.groupType2.PerformLayout();
            this.tabDel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabQuery.ResumeLayout(false);
            this.tabQuery.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TabPage tabUpdate;
        private System.Windows.Forms.TabPage tabDel;
        private System.Windows.Forms.TabPage tabQuery;
        private System.Windows.Forms.GroupBox groupType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Button buttonAType;
        private System.Windows.Forms.TextBox textPrize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox roomNum;
        private System.Windows.Forms.ComboBox combType2;
        private System.Windows.Forms.GroupBox groupRoom;
        private System.Windows.Forms.Button buttonARoom;
        private System.Windows.Forms.GroupBox groupRoom2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combRoom1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combType4;
        private System.Windows.Forms.GroupBox groupType2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox newPrize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combType3;
        private System.Windows.Forms.TextBox newType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox combType5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox combType6;
        private System.Windows.Forms.ListView roomList;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox typeNum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox combType1;
        private System.Windows.Forms.Button buttonCType;
        private System.Windows.Forms.Button buttonCRoom;
        private System.Windows.Forms.ComboBox combRoom2;
        private System.Windows.Forms.ComboBox combRoom3;
        private System.Windows.Forms.RadioButton radioRoom;
        private System.Windows.Forms.RadioButton radioType;
        private System.Windows.Forms.CheckBox checkNew;
    }
}