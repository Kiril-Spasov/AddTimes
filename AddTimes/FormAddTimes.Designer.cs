namespace AddTimes
{
    partial class FormAddTimes
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
            this.BtnAddTimes = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnAddTimes
            // 
            this.BtnAddTimes.Location = new System.Drawing.Point(60, 71);
            this.BtnAddTimes.Name = "BtnAddTimes";
            this.BtnAddTimes.Size = new System.Drawing.Size(195, 56);
            this.BtnAddTimes.TabIndex = 0;
            this.BtnAddTimes.Text = "Add Times";
            this.BtnAddTimes.UseVisualStyleBackColor = true;
            this.BtnAddTimes.Click += new System.EventHandler(this.BtnAddTimes_Click);
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(359, 71);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(355, 335);
            this.TxtResult.TabIndex = 1;
            // 
            // FormAddTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.BtnAddTimes);
            this.Name = "FormAddTimes";
            this.Text = "Add Times";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAddTimes;
        private System.Windows.Forms.TextBox TxtResult;
    }
}

