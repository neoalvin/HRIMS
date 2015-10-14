namespace HRIMS
{
    partial class GuestLogin
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
            this.roomList = new System.Windows.Forms.ListView();
            this.combType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCalcu = new System.Windows.Forms.Button();
            this.textCost = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textDetails = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textDay = new System.Windows.Forms.TextBox();
            this.textCostsum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // roomList
            // 
            this.roomList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roomList.BackColor = System.Drawing.SystemColors.Control;
            this.roomList.CheckBoxes = true;
            this.roomList.FullRowSelect = true;
            this.roomList.GridLines = true;
            this.roomList.Location = new System.Drawing.Point(21, 25);
            this.roomList.Name = "roomList";
            this.roomList.Size = new System.Drawing.Size(674, 581);
            this.roomList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.roomList.TabIndex = 0;
            this.roomList.UseCompatibleStateImageBehavior = false;
            this.roomList.View = System.Windows.Forms.View.Details;
            // 
            // combType
            // 
            this.combType.FormattingEnabled = true;
            this.combType.Location = new System.Drawing.Point(812, 41);
            this.combType.Name = "combType";
            this.combType.Size = new System.Drawing.Size(146, 29);
            this.combType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(722, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "客房类型";
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(979, 37);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(58, 35);
            this.buttonQuery.TabIndex = 3;
            this.buttonQuery.Text = "查询";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(812, 116);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(146, 29);
            this.textName.TabIndex = 4;
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(812, 191);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(225, 29);
            this.textId.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(722, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "身份证号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(722, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "宾客姓名";
            // 
            // textTel
            // 
            this.textTel.Location = new System.Drawing.Point(812, 266);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(225, 29);
            this.textTel.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(722, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "联系方式";
            // 
            // buttonCalcu
            // 
            this.buttonCalcu.Location = new System.Drawing.Point(726, 552);
            this.buttonCalcu.Name = "buttonCalcu";
            this.buttonCalcu.Size = new System.Drawing.Size(86, 44);
            this.buttonCalcu.TabIndex = 10;
            this.buttonCalcu.Text = "结算";
            this.buttonCalcu.UseVisualStyleBackColor = true;
            this.buttonCalcu.Click += new System.EventHandler(this.buttonCalcu_Click);
            // 
            // textCost
            // 
            this.textCost.BackColor = System.Drawing.SystemColors.Control;
            this.textCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCost.Font = new System.Drawing.Font("微软雅黑", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textCost.ForeColor = System.Drawing.Color.Red;
            this.textCost.Location = new System.Drawing.Point(812, 378);
            this.textCost.Name = "textCost";
            this.textCost.Size = new System.Drawing.Size(191, 22);
            this.textCost.TabIndex = 11;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(951, 552);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(86, 44);
            this.buttonOK.TabIndex = 12;
            this.buttonOK.Text = "确定";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(728, 493);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "总费用";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(722, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = " ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(728, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "备    注";
            // 
            // textDetails
            // 
            this.textDetails.Location = new System.Drawing.Point(812, 416);
            this.textDetails.Name = "textDetails";
            this.textDetails.Size = new System.Drawing.Size(225, 29);
            this.textDetails.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(722, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "入住天数";
            // 
            // textDay
            // 
            this.textDay.Location = new System.Drawing.Point(812, 341);
            this.textDay.Name = "textDay";
            this.textDay.Size = new System.Drawing.Size(225, 29);
            this.textDay.TabIndex = 18;
            // 
            // textCostsum
            // 
            this.textCostsum.BackColor = System.Drawing.SystemColors.Control;
            this.textCostsum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCostsum.Font = new System.Drawing.Font("微软雅黑", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textCostsum.ForeColor = System.Drawing.Color.Red;
            this.textCostsum.Location = new System.Drawing.Point(812, 493);
            this.textCostsum.Name = "textCostsum";
            this.textCostsum.Size = new System.Drawing.Size(225, 22);
            this.textCostsum.TabIndex = 19;
            // 
            // GuestLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1108, 630);
            this.Controls.Add(this.textCostsum);
            this.Controls.Add(this.textDay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textDetails);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textCost);
            this.Controls.Add(this.buttonCalcu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textTel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.buttonQuery);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combType);
            this.Controls.Add(this.roomList);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "GuestLogin";
            this.Text = "GuestLogin";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView roomList;
        private System.Windows.Forms.ComboBox combType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCalcu;
        private System.Windows.Forms.TextBox textCost;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textDetails;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textDay;
        private System.Windows.Forms.TextBox textCostsum;
    }
}