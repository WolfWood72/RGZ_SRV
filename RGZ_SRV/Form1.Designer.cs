namespace RGZ_SRV
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dGW_Plane = new System.Windows.Forms.DataGridView();
            this.DGW_runway = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimerStart_button = new System.Windows.Forms.Button();
            this.TimerStop_button = new System.Windows.Forms.Button();
            this.TimerReset_button = new System.Windows.Forms.Button();
            this.AddPlaneBtn = new System.Windows.Forms.Button();
            this.DeletePlaneBtn = new System.Windows.Forms.Button();
            this.TimerGroupBox = new System.Windows.Forms.GroupBox();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.PlaneGroupBox = new System.Windows.Forms.GroupBox();
            this.MaxQUerySizeForLandingNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.MaxQuerySizeForTakeOFFnumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dGW_PlaneEnd = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.RunwayGroupBox = new System.Windows.Forms.GroupBox();
            this.MinIntervalBetweenLAndingNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.DeleteRunwayBtn = new System.Windows.Forms.Button();
            this.AddRunwayBtn = new System.Windows.Forms.Button();
            this.NumberPlane = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeTakeoff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeLanding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LengthTakeOff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuelResidual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NumberRunway = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LengthRunway = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RunwayStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.RunwayTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlaneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanesProperty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlaneStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dGW_Plane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_runway)).BeginInit();
            this.TimerGroupBox.SuspendLayout();
            this.PlaneGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxQUerySizeForLandingNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxQuerySizeForTakeOFFnumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGW_PlaneEnd)).BeginInit();
            this.RunwayGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinIntervalBetweenLAndingNumUpDown)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGW_Plane
            // 
            this.dGW_Plane.AllowUserToAddRows = false;
            this.dGW_Plane.AllowUserToDeleteRows = false;
            this.dGW_Plane.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGW_Plane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGW_Plane.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberPlane,
            this.TimeTakeoff,
            this.TimeLanding,
            this.LengthTakeOff,
            this.FuelResidual,
            this.Status});
            this.dGW_Plane.Location = new System.Drawing.Point(120, 38);
            this.dGW_Plane.MultiSelect = false;
            this.dGW_Plane.Name = "dGW_Plane";
            this.dGW_Plane.ReadOnly = true;
            this.dGW_Plane.RowHeadersVisible = false;
            this.dGW_Plane.Size = new System.Drawing.Size(447, 227);
            this.dGW_Plane.TabIndex = 0;
            // 
            // DGW_runway
            // 
            this.DGW_runway.AllowUserToAddRows = false;
            this.DGW_runway.AllowUserToDeleteRows = false;
            this.DGW_runway.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW_runway.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberRunway,
            this.LengthRunway,
            this.RunwayStatus,
            this.RunwayTime,
            this.PlaneNumber,
            this.PlanesProperty,
            this.PlaneStatus});
            this.DGW_runway.Location = new System.Drawing.Point(111, 19);
            this.DGW_runway.MultiSelect = false;
            this.DGW_runway.Name = "DGW_runway";
            this.DGW_runway.ReadOnly = true;
            this.DGW_runway.RowHeadersVisible = false;
            this.DGW_runway.ShowCellErrors = false;
            this.DGW_runway.ShowCellToolTips = false;
            this.DGW_runway.ShowEditingIcon = false;
            this.DGW_runway.ShowRowErrors = false;
            this.DGW_runway.Size = new System.Drawing.Size(783, 239);
            this.DGW_runway.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimerStart_button
            // 
            this.TimerStart_button.Location = new System.Drawing.Point(6, 57);
            this.TimerStart_button.Name = "TimerStart_button";
            this.TimerStart_button.Size = new System.Drawing.Size(75, 23);
            this.TimerStart_button.TabIndex = 2;
            this.TimerStart_button.Text = "Старт";
            this.TimerStart_button.UseVisualStyleBackColor = true;
            this.TimerStart_button.Click += new System.EventHandler(this.TimerStart_button_Click);
            // 
            // TimerStop_button
            // 
            this.TimerStop_button.Location = new System.Drawing.Point(6, 86);
            this.TimerStop_button.Name = "TimerStop_button";
            this.TimerStop_button.Size = new System.Drawing.Size(75, 23);
            this.TimerStop_button.TabIndex = 3;
            this.TimerStop_button.Text = "Стоп";
            this.TimerStop_button.UseVisualStyleBackColor = true;
            this.TimerStop_button.Click += new System.EventHandler(this.TimerStop_button_Click);
            // 
            // TimerReset_button
            // 
            this.TimerReset_button.Location = new System.Drawing.Point(6, 115);
            this.TimerReset_button.Name = "TimerReset_button";
            this.TimerReset_button.Size = new System.Drawing.Size(75, 23);
            this.TimerReset_button.TabIndex = 4;
            this.TimerReset_button.Text = "Сбросить таймер";
            this.TimerReset_button.UseVisualStyleBackColor = true;
            this.TimerReset_button.Click += new System.EventHandler(this.TimerReset_button_Click);
            // 
            // AddPlaneBtn
            // 
            this.AddPlaneBtn.Location = new System.Drawing.Point(11, 39);
            this.AddPlaneBtn.Name = "AddPlaneBtn";
            this.AddPlaneBtn.Size = new System.Drawing.Size(99, 51);
            this.AddPlaneBtn.TabIndex = 6;
            this.AddPlaneBtn.Text = "Добавить самолет в очередь";
            this.AddPlaneBtn.UseVisualStyleBackColor = true;
            this.AddPlaneBtn.Click += new System.EventHandler(this.AddPlaneBtn_Click);
            // 
            // DeletePlaneBtn
            // 
            this.DeletePlaneBtn.Location = new System.Drawing.Point(11, 96);
            this.DeletePlaneBtn.Name = "DeletePlaneBtn";
            this.DeletePlaneBtn.Size = new System.Drawing.Size(99, 56);
            this.DeletePlaneBtn.TabIndex = 7;
            this.DeletePlaneBtn.Text = "Удалить самолет из очереди";
            this.DeletePlaneBtn.UseVisualStyleBackColor = true;
            this.DeletePlaneBtn.Click += new System.EventHandler(this.DeletePlaneBtn_Click);
            // 
            // TimerGroupBox
            // 
            this.TimerGroupBox.Controls.Add(this.TimerLabel);
            this.TimerGroupBox.Controls.Add(this.TimerStart_button);
            this.TimerGroupBox.Controls.Add(this.TimerStop_button);
            this.TimerGroupBox.Controls.Add(this.TimerReset_button);
            this.TimerGroupBox.Location = new System.Drawing.Point(12, 317);
            this.TimerGroupBox.Name = "TimerGroupBox";
            this.TimerGroupBox.Size = new System.Drawing.Size(92, 149);
            this.TimerGroupBox.TabIndex = 8;
            this.TimerGroupBox.TabStop = false;
            this.TimerGroupBox.Text = "Таймер";
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimerLabel.Location = new System.Drawing.Point(6, 22);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(59, 21);
            this.TimerLabel.TabIndex = 5;
            this.TimerLabel.Text = "label1";
            // 
            // PlaneGroupBox
            // 
            this.PlaneGroupBox.Controls.Add(this.MaxQUerySizeForLandingNumUpDown);
            this.PlaneGroupBox.Controls.Add(this.label4);
            this.PlaneGroupBox.Controls.Add(this.MaxQuerySizeForTakeOFFnumUpDown);
            this.PlaneGroupBox.Controls.Add(this.label3);
            this.PlaneGroupBox.Controls.Add(this.label2);
            this.PlaneGroupBox.Controls.Add(this.label1);
            this.PlaneGroupBox.Controls.Add(this.dGW_PlaneEnd);
            this.PlaneGroupBox.Controls.Add(this.AddPlaneBtn);
            this.PlaneGroupBox.Controls.Add(this.DeletePlaneBtn);
            this.PlaneGroupBox.Controls.Add(this.dGW_Plane);
            this.PlaneGroupBox.Location = new System.Drawing.Point(12, 27);
            this.PlaneGroupBox.Name = "PlaneGroupBox";
            this.PlaneGroupBox.Size = new System.Drawing.Size(1020, 284);
            this.PlaneGroupBox.TabIndex = 9;
            this.PlaneGroupBox.TabStop = false;
            this.PlaneGroupBox.Text = "Самолеты";
            // 
            // MaxQUerySizeForLandingNumUpDown
            // 
            this.MaxQUerySizeForLandingNumUpDown.Location = new System.Drawing.Point(17, 251);
            this.MaxQUerySizeForLandingNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxQUerySizeForLandingNumUpDown.Name = "MaxQUerySizeForLandingNumUpDown";
            this.MaxQUerySizeForLandingNumUpDown.Size = new System.Drawing.Size(93, 20);
            this.MaxQUerySizeForLandingNumUpDown.TabIndex = 14;
            this.MaxQUerySizeForLandingNumUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MaxQUerySizeForLandingNumUpDown.ValueChanged += new System.EventHandler(this.MaxQUerySizeForLandingNumUpDown_ValueChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(14, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 46);
            this.label4.TabIndex = 13;
            this.label4.Text = "Макс. размер очереди на посадку";
            // 
            // MaxQuerySizeForTakeOFFnumUpDown
            // 
            this.MaxQuerySizeForTakeOFFnumUpDown.Location = new System.Drawing.Point(14, 186);
            this.MaxQuerySizeForTakeOFFnumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxQuerySizeForTakeOFFnumUpDown.Name = "MaxQuerySizeForTakeOFFnumUpDown";
            this.MaxQuerySizeForTakeOFFnumUpDown.Size = new System.Drawing.Size(96, 20);
            this.MaxQuerySizeForTakeOFFnumUpDown.TabIndex = 12;
            this.MaxQuerySizeForTakeOFFnumUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MaxQuerySizeForTakeOFFnumUpDown.ValueChanged += new System.EventHandler(this.MaxQuerySizeForTakeOFFnumUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(11, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Макс. размер очереди на взлет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Взлетевшие\\севшие самолеты";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Очередь на ВПП";
            // 
            // dGW_PlaneEnd
            // 
            this.dGW_PlaneEnd.AllowUserToAddRows = false;
            this.dGW_PlaneEnd.AllowUserToDeleteRows = false;
            this.dGW_PlaneEnd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGW_PlaneEnd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGW_PlaneEnd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewComboBoxColumn1});
            this.dGW_PlaneEnd.Location = new System.Drawing.Point(589, 38);
            this.dGW_PlaneEnd.MultiSelect = false;
            this.dGW_PlaneEnd.Name = "dGW_PlaneEnd";
            this.dGW_PlaneEnd.ReadOnly = true;
            this.dGW_PlaneEnd.RowHeadersVisible = false;
            this.dGW_PlaneEnd.Size = new System.Drawing.Size(425, 227);
            this.dGW_PlaneEnd.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер самолета";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Время взлета";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Время посадки";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Длина разгона";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Остаток топлива";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn1.HeaderText = "Статус";
            this.dataGridViewComboBoxColumn1.Items.AddRange(new object[] {
            "Посадка",
            "Очередь на посадку",
            "Приземлился",
            "Взлет",
            "Очередь на взлет",
            "Взлетел"});
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.ReadOnly = true;
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // RunwayGroupBox
            // 
            this.RunwayGroupBox.Controls.Add(this.MinIntervalBetweenLAndingNumUpDown);
            this.RunwayGroupBox.Controls.Add(this.label5);
            this.RunwayGroupBox.Controls.Add(this.DeleteRunwayBtn);
            this.RunwayGroupBox.Controls.Add(this.AddRunwayBtn);
            this.RunwayGroupBox.Controls.Add(this.DGW_runway);
            this.RunwayGroupBox.Location = new System.Drawing.Point(132, 317);
            this.RunwayGroupBox.Name = "RunwayGroupBox";
            this.RunwayGroupBox.Size = new System.Drawing.Size(900, 271);
            this.RunwayGroupBox.TabIndex = 10;
            this.RunwayGroupBox.TabStop = false;
            this.RunwayGroupBox.Text = "ВПП";
            // 
            // MinIntervalBetweenLAndingNumUpDown
            // 
            this.MinIntervalBetweenLAndingNumUpDown.Location = new System.Drawing.Point(6, 152);
            this.MinIntervalBetweenLAndingNumUpDown.Name = "MinIntervalBetweenLAndingNumUpDown";
            this.MinIntervalBetweenLAndingNumUpDown.Size = new System.Drawing.Size(99, 20);
            this.MinIntervalBetweenLAndingNumUpDown.TabIndex = 10;
            this.MinIntervalBetweenLAndingNumUpDown.ValueChanged += new System.EventHandler(this.MinIntervalBetweenLAndingNumUpDown_ValueChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 43);
            this.label5.TabIndex = 9;
            this.label5.Text = "Минимальный интервал между посадками";
            // 
            // DeleteRunwayBtn
            // 
            this.DeleteRunwayBtn.Location = new System.Drawing.Point(6, 57);
            this.DeleteRunwayBtn.Name = "DeleteRunwayBtn";
            this.DeleteRunwayBtn.Size = new System.Drawing.Size(99, 37);
            this.DeleteRunwayBtn.TabIndex = 8;
            this.DeleteRunwayBtn.Text = "Удалить ВПП";
            this.DeleteRunwayBtn.UseVisualStyleBackColor = true;
            this.DeleteRunwayBtn.Click += new System.EventHandler(this.DeleteRunwayBtn_Click);
            // 
            // AddRunwayBtn
            // 
            this.AddRunwayBtn.Location = new System.Drawing.Point(6, 15);
            this.AddRunwayBtn.Name = "AddRunwayBtn";
            this.AddRunwayBtn.Size = new System.Drawing.Size(99, 36);
            this.AddRunwayBtn.TabIndex = 7;
            this.AddRunwayBtn.Text = "Добавить ВПП";
            this.AddRunwayBtn.UseVisualStyleBackColor = true;
            this.AddRunwayBtn.Click += new System.EventHandler(this.AddRunwayBtn_Click);
            // 
            // NumberPlane
            // 
            this.NumberPlane.HeaderText = "Номер самолета";
            this.NumberPlane.Name = "NumberPlane";
            this.NumberPlane.ReadOnly = true;
            // 
            // TimeTakeoff
            // 
            this.TimeTakeoff.HeaderText = "Время взлета";
            this.TimeTakeoff.Name = "TimeTakeoff";
            this.TimeTakeoff.ReadOnly = true;
            // 
            // TimeLanding
            // 
            this.TimeLanding.HeaderText = "Время посадки";
            this.TimeLanding.Name = "TimeLanding";
            this.TimeLanding.ReadOnly = true;
            // 
            // LengthTakeOff
            // 
            this.LengthTakeOff.HeaderText = "Длина разгона";
            this.LengthTakeOff.Name = "LengthTakeOff";
            this.LengthTakeOff.ReadOnly = true;
            // 
            // FuelResidual
            // 
            this.FuelResidual.HeaderText = "Остаток топлива";
            this.FuelResidual.Name = "FuelResidual";
            this.FuelResidual.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Status.HeaderText = "Статус";
            this.Status.Items.AddRange(new object[] {
            "Посадка",
            "Очередь на посадку",
            "Приземлился",
            "Взлет",
            "Очередь на взлет",
            "Взлетел"});
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // NumberRunway
            // 
            this.NumberRunway.HeaderText = "Номер ВПП";
            this.NumberRunway.Name = "NumberRunway";
            this.NumberRunway.ReadOnly = true;
            this.NumberRunway.Width = 50;
            // 
            // LengthRunway
            // 
            this.LengthRunway.HeaderText = "Длина ВПП";
            this.LengthRunway.Name = "LengthRunway";
            this.LengthRunway.ReadOnly = true;
            this.LengthRunway.Width = 50;
            // 
            // RunwayStatus
            // 
            this.RunwayStatus.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.RunwayStatus.HeaderText = "Статус ВПП";
            this.RunwayStatus.Items.AddRange(new object[] {
            "Занято",
            "Свободно",
            "Ожидание"});
            this.RunwayStatus.Name = "RunwayStatus";
            this.RunwayStatus.ReadOnly = true;
            this.RunwayStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RunwayStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // RunwayTime
            // 
            this.RunwayTime.HeaderText = "Расчетное время";
            this.RunwayTime.Name = "RunwayTime";
            this.RunwayTime.ReadOnly = true;
            // 
            // PlaneNumber
            // 
            this.PlaneNumber.HeaderText = "Номер самолета";
            this.PlaneNumber.Name = "PlaneNumber";
            this.PlaneNumber.ReadOnly = true;
            this.PlaneNumber.Width = 60;
            // 
            // PlanesProperty
            // 
            this.PlanesProperty.HeaderText = "Характеристики самолета";
            this.PlanesProperty.Name = "PlanesProperty";
            this.PlanesProperty.ReadOnly = true;
            this.PlanesProperty.Width = 360;
            // 
            // PlaneStatus
            // 
            this.PlaneStatus.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.PlaneStatus.HeaderText = "Статус самолета";
            this.PlaneStatus.Items.AddRange(new object[] {
            "Посадка",
            "Очередь на посадку",
            "Приземлился",
            "Взлет",
            "Очередь на взлет",
            "Взлетел"});
            this.PlaneStatus.Name = "PlaneStatus";
            this.PlaneStatus.ReadOnly = true;
            this.PlaneStatus.Width = 65;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1044, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 602);
            this.Controls.Add(this.RunwayGroupBox);
            this.Controls.Add(this.PlaneGroupBox);
            this.Controls.Add(this.TimerGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Аэропорт";
            ((System.ComponentModel.ISupportInitialize)(this.dGW_Plane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_runway)).EndInit();
            this.TimerGroupBox.ResumeLayout(false);
            this.TimerGroupBox.PerformLayout();
            this.PlaneGroupBox.ResumeLayout(false);
            this.PlaneGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxQUerySizeForLandingNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxQuerySizeForTakeOFFnumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGW_PlaneEnd)).EndInit();
            this.RunwayGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MinIntervalBetweenLAndingNumUpDown)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dGW_Plane;
        private System.Windows.Forms.DataGridView DGW_runway;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button TimerStart_button;
        private System.Windows.Forms.Button TimerStop_button;
        private System.Windows.Forms.Button TimerReset_button;
        private System.Windows.Forms.Button AddPlaneBtn;
        private System.Windows.Forms.Button DeletePlaneBtn;
        private System.Windows.Forms.GroupBox TimerGroupBox;
        private System.Windows.Forms.GroupBox PlaneGroupBox;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.GroupBox RunwayGroupBox;
        private System.Windows.Forms.Button DeleteRunwayBtn;
        private System.Windows.Forms.Button AddRunwayBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGW_PlaneEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.NumericUpDown MaxQUerySizeForLandingNumUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown MaxQuerySizeForTakeOFFnumUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown MinIntervalBetweenLAndingNumUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberPlane;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeTakeoff;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeLanding;
        private System.Windows.Forms.DataGridViewTextBoxColumn LengthTakeOff;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuelResidual;
        private System.Windows.Forms.DataGridViewComboBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberRunway;
        private System.Windows.Forms.DataGridViewTextBoxColumn LengthRunway;
        private System.Windows.Forms.DataGridViewComboBoxColumn RunwayStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn RunwayTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlaneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanesProperty;
        private System.Windows.Forms.DataGridViewComboBoxColumn PlaneStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}

