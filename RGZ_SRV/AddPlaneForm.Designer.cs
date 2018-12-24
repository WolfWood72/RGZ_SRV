namespace RGZ_SRV
{
    partial class AddPlaneForm
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
            this.AddPlaneBtn = new System.Windows.Forms.Button();
            this.FuelResidualNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.TimeLandingNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.TimeTakeOffNumcUpDown = new System.Windows.Forms.NumericUpDown();
            this.LengthTakeOffNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TakeOffRadioBtn = new System.Windows.Forms.RadioButton();
            this.LandigRbtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.FuelResidualNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeLandingNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeTakeOffNumcUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthTakeOffNumUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddPlaneBtn
            // 
            this.AddPlaneBtn.Location = new System.Drawing.Point(67, 258);
            this.AddPlaneBtn.Name = "AddPlaneBtn";
            this.AddPlaneBtn.Size = new System.Drawing.Size(126, 23);
            this.AddPlaneBtn.TabIndex = 0;
            this.AddPlaneBtn.Text = "Добавить";
            this.AddPlaneBtn.UseVisualStyleBackColor = true;
            this.AddPlaneBtn.Click += new System.EventHandler(this.AddPlaneBtn_Click);
            // 
            // FuelResidualNumUpDown
            // 
            this.FuelResidualNumUpDown.Location = new System.Drawing.Point(15, 150);
            this.FuelResidualNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FuelResidualNumUpDown.Name = "FuelResidualNumUpDown";
            this.FuelResidualNumUpDown.Size = new System.Drawing.Size(222, 20);
            this.FuelResidualNumUpDown.TabIndex = 1;
            this.FuelResidualNumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TimeLandingNumUpDown
            // 
            this.TimeLandingNumUpDown.Location = new System.Drawing.Point(15, 111);
            this.TimeLandingNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TimeLandingNumUpDown.Name = "TimeLandingNumUpDown";
            this.TimeLandingNumUpDown.Size = new System.Drawing.Size(222, 20);
            this.TimeLandingNumUpDown.TabIndex = 2;
            this.TimeLandingNumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TimeTakeOffNumcUpDown
            // 
            this.TimeTakeOffNumcUpDown.Location = new System.Drawing.Point(15, 72);
            this.TimeTakeOffNumcUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TimeTakeOffNumcUpDown.Name = "TimeTakeOffNumcUpDown";
            this.TimeTakeOffNumcUpDown.Size = new System.Drawing.Size(222, 20);
            this.TimeTakeOffNumcUpDown.TabIndex = 3;
            this.TimeTakeOffNumcUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LengthTakeOffNumUpDown
            // 
            this.LengthTakeOffNumUpDown.Location = new System.Drawing.Point(15, 33);
            this.LengthTakeOffNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LengthTakeOffNumUpDown.Name = "LengthTakeOffNumUpDown";
            this.LengthTakeOffNumUpDown.Size = new System.Drawing.Size(222, 20);
            this.LengthTakeOffNumUpDown.TabIndex = 4;
            this.LengthTakeOffNumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Длина разбега";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Длина нахождения на ВПП при взлете";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Длина нахождения на ВПП при посадке";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Остаток топлива";
            // 
            // TakeOffRadioBtn
            // 
            this.TakeOffRadioBtn.AutoSize = true;
            this.TakeOffRadioBtn.Checked = true;
            this.TakeOffRadioBtn.Location = new System.Drawing.Point(9, 19);
            this.TakeOffRadioBtn.Name = "TakeOffRadioBtn";
            this.TakeOffRadioBtn.Size = new System.Drawing.Size(55, 17);
            this.TakeOffRadioBtn.TabIndex = 10;
            this.TakeOffRadioBtn.TabStop = true;
            this.TakeOffRadioBtn.Text = "Взлет";
            this.TakeOffRadioBtn.UseVisualStyleBackColor = true;
            // 
            // LandigRbtn
            // 
            this.LandigRbtn.AutoSize = true;
            this.LandigRbtn.Location = new System.Drawing.Point(9, 42);
            this.LandigRbtn.Name = "LandigRbtn";
            this.LandigRbtn.Size = new System.Drawing.Size(69, 17);
            this.LandigRbtn.TabIndex = 11;
            this.LandigRbtn.TabStop = true;
            this.LandigRbtn.Text = "Посадка";
            this.LandigRbtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TakeOffRadioBtn);
            this.groupBox1.Controls.Add(this.LandigRbtn);
            this.groupBox1.Location = new System.Drawing.Point(15, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 76);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Куда добавить";
            // 
            // AddPlaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 290);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LengthTakeOffNumUpDown);
            this.Controls.Add(this.TimeTakeOffNumcUpDown);
            this.Controls.Add(this.TimeLandingNumUpDown);
            this.Controls.Add(this.FuelResidualNumUpDown);
            this.Controls.Add(this.AddPlaneBtn);
            this.Name = "AddPlaneForm";
            this.ShowIcon = false;
            this.Text = "AddPlaneForm";
            ((System.ComponentModel.ISupportInitialize)(this.FuelResidualNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeLandingNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeTakeOffNumcUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthTakeOffNumUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddPlaneBtn;
        private System.Windows.Forms.NumericUpDown FuelResidualNumUpDown;
        private System.Windows.Forms.NumericUpDown TimeLandingNumUpDown;
        private System.Windows.Forms.NumericUpDown TimeTakeOffNumcUpDown;
        private System.Windows.Forms.NumericUpDown LengthTakeOffNumUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton TakeOffRadioBtn;
        private System.Windows.Forms.RadioButton LandigRbtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}