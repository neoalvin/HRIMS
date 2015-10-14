namespace HRIMS
{
    partial class GuestExit
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
            this.textRoom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.buttonCalcu = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textReturn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // roomList
            // 
            this.roomList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roomList.CheckBoxes = true;
            this.roomList.FullRowSelect = true;
            this.roomList.GridLines = true;
            this.roomList.Location = new System.Drawing.Point(24, 28);
            this.roomList.Name = "roomList";
            this.roomList.Size = new System.Drawing.Size(667, 571);
            this.roomList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.roomList.TabIndex = 1;
            this.roomList.UseCompatibleStateImageBehavior = false;
            this.roomList.View = System.Windows.Forms.View.Details;
            // 
            // textRoom
            // 
            this.textRoom.Location = new System.Drawing.Point(839, 100);
            this.textRoom.Name = "textRoom";
            this.textRoom.Size = new System.Drawing.Size(157, 29);
            this.textRoom.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(775, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "客房号";
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(1007, 99);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(51, 29);
            this.buttonQuery.TabIndex = 4;
            this.buttonQuery.Text = "查询";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // buttonCalcu
            // 
            this.buttonCalcu.Location = new System.Drawing.Point(779, 362);
            this.buttonCalcu.Name = "buttonCalcu";
            this.buttonCalcu.Size = new System.Drawing.Size(68, 36);
            this.buttonCalcu.TabIndex = 5;
            this.buttonCalcu.Text = "结算";
            this.buttonCalcu.UseVisualStyleBackColor = true;
            this.buttonCalcu.Click += new System.EventHandler(this.buttonCalcu_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(934, 362);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(62, 36);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "确定";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textCost
            // 
            this.textCost.Location = new System.Drawing.Point(839, 188);
            this.textCost.Name = "textCost";
            this.textCost.Size = new System.Drawing.Size(157, 29);
            this.textCost.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(775, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "实付款";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(775, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "应退款";
            // 
            // textReturn
            // 
            this.textReturn.BackColor = System.Drawing.SystemColors.Control;
            this.textReturn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textReturn.Font = new System.Drawing.Font("微软雅黑", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textReturn.ForeColor = System.Drawing.Color.Red;
            this.textReturn.Location = new System.Drawing.Point(839, 279);
            this.textReturn.Name = "textReturn";
            this.textReturn.Size = new System.Drawing.Size(157, 22);
            this.textReturn.TabIndex = 10;
            // 
            // GuestExit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 630);
            this.Controls.Add(this.textReturn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textCost);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCalcu);
            this.Controls.Add(this.buttonQuery);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textRoom);
            this.Controls.Add(this.roomList);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "GuestExit";
            this.Text = "GuestExit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView roomList;
        private System.Windows.Forms.TextBox textRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.Button buttonCalcu;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textReturn;
    }
}