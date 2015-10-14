namespace HRIMS
{
    partial class GuestForm
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
            this.guestList = new System.Windows.Forms.ListView();
            this.textQuery = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.radioRoom = new System.Windows.Forms.RadioButton();
            this.radioName = new System.Windows.Forms.RadioButton();
            this.radioTime = new System.Windows.Forms.RadioButton();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // guestList
            // 
            this.guestList.FullRowSelect = true;
            this.guestList.GridLines = true;
            this.guestList.Location = new System.Drawing.Point(12, 33);
            this.guestList.Name = "guestList";
            this.guestList.Size = new System.Drawing.Size(804, 547);
            this.guestList.TabIndex = 0;
            this.guestList.UseCompatibleStateImageBehavior = false;
            this.guestList.View = System.Windows.Forms.View.Details;
            // 
            // textQuery
            // 
            this.textQuery.Location = new System.Drawing.Point(867, 49);
            this.textQuery.Name = "textQuery";
            this.textQuery.Size = new System.Drawing.Size(177, 29);
            this.textQuery.TabIndex = 5;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(867, 418);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(101, 40);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "确定";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // radioRoom
            // 
            this.radioRoom.AutoSize = true;
            this.radioRoom.Location = new System.Drawing.Point(867, 128);
            this.radioRoom.Name = "radioRoom";
            this.radioRoom.Size = new System.Drawing.Size(140, 25);
            this.radioRoom.TabIndex = 7;
            this.radioRoom.TabStop = true;
            this.radioRoom.Text = "按客房号码查询";
            this.radioRoom.UseVisualStyleBackColor = true;
            // 
            // radioName
            // 
            this.radioName.AutoSize = true;
            this.radioName.Location = new System.Drawing.Point(867, 199);
            this.radioName.Name = "radioName";
            this.radioName.Size = new System.Drawing.Size(140, 25);
            this.radioName.TabIndex = 8;
            this.radioName.TabStop = true;
            this.radioName.Text = "按客户姓名查询";
            this.radioName.UseVisualStyleBackColor = true;
            // 
            // radioTime
            // 
            this.radioTime.AutoSize = true;
            this.radioTime.Location = new System.Drawing.Point(867, 268);
            this.radioTime.Name = "radioTime";
            this.radioTime.Size = new System.Drawing.Size(140, 25);
            this.radioTime.TabIndex = 9;
            this.radioTime.TabStop = true;
            this.radioTime.Text = "按入住时间查询";
            this.radioTime.UseVisualStyleBackColor = true;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(867, 342);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(177, 29);
            this.datePicker.TabIndex = 10;
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 630);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.radioTime);
            this.Controls.Add(this.radioName);
            this.Controls.Add(this.radioRoom);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textQuery);
            this.Controls.Add(this.guestList);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "GuestForm";
            this.Text = "GuestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView guestList;
        private System.Windows.Forms.TextBox textQuery;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.RadioButton radioRoom;
        private System.Windows.Forms.RadioButton radioName;
        private System.Windows.Forms.RadioButton radioTime;
        private System.Windows.Forms.DateTimePicker datePicker;
    }
}