namespace RGZ_SRV
{
    partial class AddRunwayForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.LengthNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.AddRunwayBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LengthNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Длина ВПП";
            // 
            // LengthNumUpDown
            // 
            this.LengthNumUpDown.Location = new System.Drawing.Point(13, 30);
            this.LengthNumUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.LengthNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LengthNumUpDown.Name = "LengthNumUpDown";
            this.LengthNumUpDown.Size = new System.Drawing.Size(187, 20);
            this.LengthNumUpDown.TabIndex = 1;
            this.LengthNumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddRunwayBtn
            // 
            this.AddRunwayBtn.Location = new System.Drawing.Point(48, 68);
            this.AddRunwayBtn.Name = "AddRunwayBtn";
            this.AddRunwayBtn.Size = new System.Drawing.Size(120, 23);
            this.AddRunwayBtn.TabIndex = 2;
            this.AddRunwayBtn.Text = "Добавить";
            this.AddRunwayBtn.UseVisualStyleBackColor = true;
            this.AddRunwayBtn.Click += new System.EventHandler(this.AddRunwayBtn_Click);
            // 
            // AddRunwayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 99);
            this.Controls.Add(this.AddRunwayBtn);
            this.Controls.Add(this.LengthNumUpDown);
            this.Controls.Add(this.label1);
            this.Name = "AddRunwayForm";
            this.Text = "AddRunwayForm";
            ((System.ComponentModel.ISupportInitialize)(this.LengthNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown LengthNumUpDown;
        private System.Windows.Forms.Button AddRunwayBtn;
    }
}