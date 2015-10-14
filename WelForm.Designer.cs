namespace HRIMS
{
    partial class WelForm
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
            this.labelWel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelWel
            // 
            this.labelWel.AutoSize = true;
            this.labelWel.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelWel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.labelWel.Location = new System.Drawing.Point(292, 219);
            this.labelWel.Name = "labelWel";
            this.labelWel.Size = new System.Drawing.Size(394, 38);
            this.labelWel.TabIndex = 0;
            this.labelWel.Text = "欢迎使用酒店客房管理系统！";
            // 
            // WelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 630);
            this.Controls.Add(this.labelWel);
            this.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "WelForm";
            this.Text = "WelForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWel;
    }
}