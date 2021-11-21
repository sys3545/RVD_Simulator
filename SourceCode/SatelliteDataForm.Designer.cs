
namespace RVD_Simulation
{
    partial class SatelliteDataForm
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
            this.gBoxList = new System.Windows.Forms.GroupBox();
            this.dataGridView_SAT = new System.Windows.Forms.DataGridView();
            this.Col_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_e = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_RAAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_w = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_TA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Epoch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBoxAddSAT = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxCrossSecTgt = new System.Windows.Forms.TextBox();
            this.labelKG_Target = new System.Windows.Forms.Label();
            this.tBoxMass = new System.Windows.Forms.TextBox();
            this.labelMass = new System.Windows.Forms.Label();
            this.labelEpoch = new System.Windows.Forms.Label();
            this.dateTimePicker_Epoch = new System.Windows.Forms.DateTimePicker();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.gBoxPosVel = new System.Windows.Forms.GroupBox();
            this.labelKM6 = new System.Windows.Forms.Label();
            this.labelKM5 = new System.Windows.Forms.Label();
            this.labelKM4 = new System.Windows.Forms.Label();
            this.labelKM3 = new System.Windows.Forms.Label();
            this.labelKM2 = new System.Windows.Forms.Label();
            this.labelKM1 = new System.Windows.Forms.Label();
            this.tBoxZvel = new System.Windows.Forms.TextBox();
            this.labelZvel = new System.Windows.Forms.Label();
            this.tBoxYvel = new System.Windows.Forms.TextBox();
            this.labelYvel = new System.Windows.Forms.Label();
            this.tBoxXvel = new System.Windows.Forms.TextBox();
            this.labelXvel = new System.Windows.Forms.Label();
            this.tBoxZ = new System.Windows.Forms.TextBox();
            this.labelZ = new System.Windows.Forms.Label();
            this.tBoxY = new System.Windows.Forms.TextBox();
            this.labelY = new System.Windows.Forms.Label();
            this.tBoxX = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.tBoxTest = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gBoxDisturbanceTarget = new System.Windows.Forms.GroupBox();
            this.tBoxDragTgt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxDragTgt = new System.Windows.Forms.CheckBox();
            this.gBoxSimulation = new System.Windows.Forms.GroupBox();
            this.gBoxManeuver = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnManeuverDel = new System.Windows.Forms.Button();
            this.btnManeuverAdd = new System.Windows.Forms.Button();
            this.dataGridView_Maneuver = new System.Windows.Forms.DataGridView();
            this.Col_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_vx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_vy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_vz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBoxChaser = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxCorssSecCha = new System.Windows.Forms.TextBox();
            this.tBoxTgtNum = new System.Windows.Forms.TextBox();
            this.labelTGTSAT = new System.Windows.Forms.Label();
            this.labelKg_Chaser = new System.Windows.Forms.Label();
            this.tBoxMass_Chaser = new System.Windows.Forms.TextBox();
            this.labelMass_Chaser = new System.Windows.Forms.Label();
            this.gBoxRelPOSVEL = new System.Windows.Forms.GroupBox();
            this.tBoxXRel = new System.Windows.Forms.TextBox();
            this.labelXRel = new System.Windows.Forms.Label();
            this.labelM6 = new System.Windows.Forms.Label();
            this.labelYRel = new System.Windows.Forms.Label();
            this.labelM5 = new System.Windows.Forms.Label();
            this.tBoxYRel = new System.Windows.Forms.TextBox();
            this.labelM4 = new System.Windows.Forms.Label();
            this.labelZRel = new System.Windows.Forms.Label();
            this.labelM3 = new System.Windows.Forms.Label();
            this.tBoxZRel = new System.Windows.Forms.TextBox();
            this.labelM2 = new System.Windows.Forms.Label();
            this.labelXvelRel = new System.Windows.Forms.Label();
            this.labelM1 = new System.Windows.Forms.Label();
            this.tBoxXvelRel = new System.Windows.Forms.TextBox();
            this.tBoxZvelRel = new System.Windows.Forms.TextBox();
            this.labelYVelRel = new System.Windows.Forms.Label();
            this.labelZVelRel = new System.Windows.Forms.Label();
            this.tBoxYvelRel = new System.Windows.Forms.TextBox();
            this.gBoxDisturbanceChaser = new System.Windows.Forms.GroupBox();
            this.tBoxDragCha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxDragCha = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.gBoxTime2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_EndSimul = new System.Windows.Forms.DateTimePicker();
            this.labelWave = new System.Windows.Forms.Label();
            this.labelUTC4 = new System.Windows.Forms.Label();
            this.labelUTC3 = new System.Windows.Forms.Label();
            this.dateTimePicker_StartSimul = new System.Windows.Forms.DateTimePicker();
            this.gBoxList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SAT)).BeginInit();
            this.gBoxAddSAT.SuspendLayout();
            this.gBoxPosVel.SuspendLayout();
            this.gBoxDisturbanceTarget.SuspendLayout();
            this.gBoxSimulation.SuspendLayout();
            this.gBoxManeuver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Maneuver)).BeginInit();
            this.gBoxChaser.SuspendLayout();
            this.gBoxRelPOSVEL.SuspendLayout();
            this.gBoxDisturbanceChaser.SuspendLayout();
            this.gBoxTime2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxList
            // 
            this.gBoxList.Controls.Add(this.dataGridView_SAT);
            this.gBoxList.Font = new System.Drawing.Font("맑은 고딕", 22.26804F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gBoxList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gBoxList.Location = new System.Drawing.Point(21, 649);
            this.gBoxList.Name = "gBoxList";
            this.gBoxList.Size = new System.Drawing.Size(772, 279);
            this.gBoxList.TabIndex = 0;
            this.gBoxList.TabStop = false;
            this.gBoxList.Text = "Satellite List";
            // 
            // dataGridView_SAT
            // 
            this.dataGridView_SAT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_SAT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SAT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Number,
            this.Col_Name,
            this.Col_a,
            this.Col_e,
            this.Col_i,
            this.Col_RAAN,
            this.Col_w,
            this.Col_TA,
            this.Col_Period,
            this.Col_Epoch});
            this.dataGridView_SAT.Location = new System.Drawing.Point(21, 46);
            this.dataGridView_SAT.Name = "dataGridView_SAT";
            this.dataGridView_SAT.RowTemplate.Height = 25;
            this.dataGridView_SAT.Size = new System.Drawing.Size(729, 211);
            this.dataGridView_SAT.TabIndex = 0;
            // 
            // Col_Number
            // 
            this.Col_Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Col_Number.HeaderText = "Number";
            this.Col_Number.Name = "Col_Number";
            this.Col_Number.Width = 154;
            // 
            // Col_Name
            // 
            this.Col_Name.HeaderText = "Name";
            this.Col_Name.Name = "Col_Name";
            this.Col_Name.Width = 124;
            // 
            // Col_a
            // 
            this.Col_a.HeaderText = "a(km)";
            this.Col_a.Name = "Col_a";
            this.Col_a.Width = 118;
            // 
            // Col_e
            // 
            this.Col_e.HeaderText = "e";
            this.Col_e.Name = "Col_e";
            this.Col_e.Width = 59;
            // 
            // Col_i
            // 
            this.Col_i.HeaderText = "i(deg)";
            this.Col_i.Name = "Col_i";
            this.Col_i.Width = 120;
            // 
            // Col_RAAN
            // 
            this.Col_RAAN.HeaderText = "RAAN(deg)";
            this.Col_RAAN.Name = "Col_RAAN";
            this.Col_RAAN.Width = 194;
            // 
            // Col_w
            // 
            this.Col_w.HeaderText = "w(deg)";
            this.Col_w.Name = "Col_w";
            this.Col_w.Width = 135;
            // 
            // Col_TA
            // 
            this.Col_TA.HeaderText = "TA(deg)";
            this.Col_TA.Name = "Col_TA";
            this.Col_TA.Width = 149;
            // 
            // Col_Period
            // 
            this.Col_Period.HeaderText = "Period(sec)";
            this.Col_Period.Name = "Col_Period";
            this.Col_Period.Width = 191;
            // 
            // Col_Epoch
            // 
            this.Col_Epoch.HeaderText = "Epoch";
            this.Col_Epoch.Name = "Col_Epoch";
            this.Col_Epoch.Width = 126;
            // 
            // gBoxAddSAT
            // 
            this.gBoxAddSAT.Controls.Add(this.label5);
            this.gBoxAddSAT.Controls.Add(this.label3);
            this.gBoxAddSAT.Controls.Add(this.tBoxCrossSecTgt);
            this.gBoxAddSAT.Controls.Add(this.labelKG_Target);
            this.gBoxAddSAT.Controls.Add(this.tBoxMass);
            this.gBoxAddSAT.Controls.Add(this.labelMass);
            this.gBoxAddSAT.Controls.Add(this.labelEpoch);
            this.gBoxAddSAT.Controls.Add(this.dateTimePicker_Epoch);
            this.gBoxAddSAT.Controls.Add(this.tBoxName);
            this.gBoxAddSAT.Controls.Add(this.labelName);
            this.gBoxAddSAT.Controls.Add(this.gBoxPosVel);
            this.gBoxAddSAT.Controls.Add(this.tBoxTest);
            this.gBoxAddSAT.Controls.Add(this.btnModify);
            this.gBoxAddSAT.Controls.Add(this.btnDelete);
            this.gBoxAddSAT.Controls.Add(this.btnAdd);
            this.gBoxAddSAT.Controls.Add(this.gBoxDisturbanceTarget);
            this.gBoxAddSAT.Font = new System.Drawing.Font("맑은 고딕", 22.26804F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gBoxAddSAT.Location = new System.Drawing.Point(21, 23);
            this.gBoxAddSAT.Name = "gBoxAddSAT";
            this.gBoxAddSAT.Size = new System.Drawing.Size(772, 631);
            this.gBoxAddSAT.TabIndex = 1;
            this.gBoxAddSAT.TabStop = false;
            this.gBoxAddSAT.Text = "Target Satellite Management";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(25, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "Cross-Section";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(310, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 32;
            this.label3.Text = "m^2";
            // 
            // tBoxCrossSecTgt
            // 
            this.tBoxCrossSecTgt.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxCrossSecTgt.Location = new System.Drawing.Point(185, 197);
            this.tBoxCrossSecTgt.Name = "tBoxCrossSecTgt";
            this.tBoxCrossSecTgt.Size = new System.Drawing.Size(119, 29);
            this.tBoxCrossSecTgt.TabIndex = 31;
            this.tBoxCrossSecTgt.Text = "1";
            this.tBoxCrossSecTgt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelKG_Target
            // 
            this.labelKG_Target.AutoSize = true;
            this.labelKG_Target.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKG_Target.Location = new System.Drawing.Point(310, 157);
            this.labelKG_Target.Name = "labelKG_Target";
            this.labelKG_Target.Size = new System.Drawing.Size(28, 19);
            this.labelKG_Target.TabIndex = 30;
            this.labelKG_Target.Text = "kg";
            // 
            // tBoxMass
            // 
            this.tBoxMass.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxMass.Location = new System.Drawing.Point(185, 153);
            this.tBoxMass.Name = "tBoxMass";
            this.tBoxMass.Size = new System.Drawing.Size(119, 29);
            this.tBoxMass.TabIndex = 29;
            this.tBoxMass.Text = "45000";
            this.tBoxMass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelMass
            // 
            this.labelMass.AutoSize = true;
            this.labelMass.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMass.Location = new System.Drawing.Point(61, 156);
            this.labelMass.Name = "labelMass";
            this.labelMass.Size = new System.Drawing.Size(49, 19);
            this.labelMass.TabIndex = 28;
            this.labelMass.Text = "Mass";
            // 
            // labelEpoch
            // 
            this.labelEpoch.AutoSize = true;
            this.labelEpoch.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEpoch.Location = new System.Drawing.Point(50, 341);
            this.labelEpoch.Name = "labelEpoch";
            this.labelEpoch.Size = new System.Drawing.Size(60, 19);
            this.labelEpoch.TabIndex = 27;
            this.labelEpoch.Text = "Epoch";
            // 
            // dateTimePicker_Epoch
            // 
            this.dateTimePicker_Epoch.CalendarFont = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_Epoch.CustomFormat = " yyy/MM/dd HH:mm:ss";
            this.dateTimePicker_Epoch.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_Epoch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Epoch.Location = new System.Drawing.Point(139, 336);
            this.dateTimePicker_Epoch.Name = "dateTimePicker_Epoch";
            this.dateTimePicker_Epoch.ShowUpDown = true;
            this.dateTimePicker_Epoch.Size = new System.Drawing.Size(214, 29);
            this.dateTimePicker_Epoch.TabIndex = 26;
            this.dateTimePicker_Epoch.Value = new System.DateTime(2021, 11, 5, 3, 0, 0, 0);
            // 
            // tBoxName
            // 
            this.tBoxName.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxName.Location = new System.Drawing.Point(185, 110);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(119, 29);
            this.tBoxName.TabIndex = 25;
            this.tBoxName.Text = "ISS";
            this.tBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(60, 113);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(54, 19);
            this.labelName.TabIndex = 24;
            this.labelName.Text = "Name";
            // 
            // gBoxPosVel
            // 
            this.gBoxPosVel.Controls.Add(this.labelKM6);
            this.gBoxPosVel.Controls.Add(this.labelKM5);
            this.gBoxPosVel.Controls.Add(this.labelKM4);
            this.gBoxPosVel.Controls.Add(this.labelKM3);
            this.gBoxPosVel.Controls.Add(this.labelKM2);
            this.gBoxPosVel.Controls.Add(this.labelKM1);
            this.gBoxPosVel.Controls.Add(this.tBoxZvel);
            this.gBoxPosVel.Controls.Add(this.labelZvel);
            this.gBoxPosVel.Controls.Add(this.tBoxYvel);
            this.gBoxPosVel.Controls.Add(this.labelYvel);
            this.gBoxPosVel.Controls.Add(this.tBoxXvel);
            this.gBoxPosVel.Controls.Add(this.labelXvel);
            this.gBoxPosVel.Controls.Add(this.tBoxZ);
            this.gBoxPosVel.Controls.Add(this.labelZ);
            this.gBoxPosVel.Controls.Add(this.tBoxY);
            this.gBoxPosVel.Controls.Add(this.labelY);
            this.gBoxPosVel.Controls.Add(this.tBoxX);
            this.gBoxPosVel.Controls.Add(this.labelX);
            this.gBoxPosVel.Font = new System.Drawing.Font("맑은 고딕", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gBoxPosVel.Location = new System.Drawing.Point(390, 84);
            this.gBoxPosVel.Name = "gBoxPosVel";
            this.gBoxPosVel.Size = new System.Drawing.Size(364, 292);
            this.gBoxPosVel.TabIndex = 23;
            this.gBoxPosVel.TabStop = false;
            this.gBoxPosVel.Text = "Position, Velocity";
            // 
            // labelKM6
            // 
            this.labelKM6.AutoSize = true;
            this.labelKM6.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKM6.Location = new System.Drawing.Point(262, 255);
            this.labelKM6.Name = "labelKM6";
            this.labelKM6.Size = new System.Drawing.Size(69, 19);
            this.labelKM6.TabIndex = 21;
            this.labelKM6.Text = "km/sec";
            // 
            // labelKM5
            // 
            this.labelKM5.AutoSize = true;
            this.labelKM5.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKM5.Location = new System.Drawing.Point(263, 212);
            this.labelKM5.Name = "labelKM5";
            this.labelKM5.Size = new System.Drawing.Size(69, 19);
            this.labelKM5.TabIndex = 20;
            this.labelKM5.Text = "km/sec";
            // 
            // labelKM4
            // 
            this.labelKM4.AutoSize = true;
            this.labelKM4.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKM4.Location = new System.Drawing.Point(261, 169);
            this.labelKM4.Name = "labelKM4";
            this.labelKM4.Size = new System.Drawing.Size(69, 19);
            this.labelKM4.TabIndex = 19;
            this.labelKM4.Text = "km/sec";
            // 
            // labelKM3
            // 
            this.labelKM3.AutoSize = true;
            this.labelKM3.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKM3.Location = new System.Drawing.Point(262, 128);
            this.labelKM3.Name = "labelKM3";
            this.labelKM3.Size = new System.Drawing.Size(33, 19);
            this.labelKM3.TabIndex = 18;
            this.labelKM3.Text = "km";
            // 
            // labelKM2
            // 
            this.labelKM2.AutoSize = true;
            this.labelKM2.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKM2.Location = new System.Drawing.Point(261, 83);
            this.labelKM2.Name = "labelKM2";
            this.labelKM2.Size = new System.Drawing.Size(33, 19);
            this.labelKM2.TabIndex = 17;
            this.labelKM2.Text = "km";
            // 
            // labelKM1
            // 
            this.labelKM1.AutoSize = true;
            this.labelKM1.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKM1.Location = new System.Drawing.Point(262, 39);
            this.labelKM1.Name = "labelKM1";
            this.labelKM1.Size = new System.Drawing.Size(33, 19);
            this.labelKM1.TabIndex = 16;
            this.labelKM1.Text = "km";
            // 
            // tBoxZvel
            // 
            this.tBoxZvel.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxZvel.Location = new System.Drawing.Point(137, 248);
            this.tBoxZvel.Name = "tBoxZvel";
            this.tBoxZvel.Size = new System.Drawing.Size(119, 29);
            this.tBoxZvel.TabIndex = 15;
            this.tBoxZvel.Text = "2.085344";
            this.tBoxZvel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelZvel
            // 
            this.labelZvel.AutoSize = true;
            this.labelZvel.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelZvel.Location = new System.Drawing.Point(42, 255);
            this.labelZvel.Name = "labelZvel";
            this.labelZvel.Size = new System.Drawing.Size(88, 19);
            this.labelZvel.TabIndex = 14;
            this.labelZvel.Text = "Z Velocity";
            // 
            // tBoxYvel
            // 
            this.tBoxYvel.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxYvel.Location = new System.Drawing.Point(137, 205);
            this.tBoxYvel.Name = "tBoxYvel";
            this.tBoxYvel.Size = new System.Drawing.Size(119, 29);
            this.tBoxYvel.TabIndex = 13;
            this.tBoxYvel.Text = "2.345939";
            this.tBoxYvel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelYvel
            // 
            this.labelYvel.AutoSize = true;
            this.labelYvel.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelYvel.Location = new System.Drawing.Point(42, 212);
            this.labelYvel.Name = "labelYvel";
            this.labelYvel.Size = new System.Drawing.Size(88, 19);
            this.labelYvel.TabIndex = 12;
            this.labelYvel.Text = "Y Velocity";
            // 
            // tBoxXvel
            // 
            this.tBoxXvel.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxXvel.Location = new System.Drawing.Point(137, 162);
            this.tBoxXvel.Name = "tBoxXvel";
            this.tBoxXvel.Size = new System.Drawing.Size(119, 29);
            this.tBoxXvel.TabIndex = 11;
            this.tBoxXvel.Text = "6.975133";
            this.tBoxXvel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelXvel
            // 
            this.labelXvel.AutoSize = true;
            this.labelXvel.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelXvel.Location = new System.Drawing.Point(42, 169);
            this.labelXvel.Name = "labelXvel";
            this.labelXvel.Size = new System.Drawing.Size(88, 19);
            this.labelXvel.TabIndex = 10;
            this.labelXvel.Text = "X Velocity";
            // 
            // tBoxZ
            // 
            this.tBoxZ.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxZ.Location = new System.Drawing.Point(137, 121);
            this.tBoxZ.Name = "tBoxZ";
            this.tBoxZ.Size = new System.Drawing.Size(119, 29);
            this.tBoxZ.TabIndex = 9;
            this.tBoxZ.Text = "-5001.6614";
            this.tBoxZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelZ.Location = new System.Drawing.Point(75, 128);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(20, 19);
            this.labelZ.TabIndex = 8;
            this.labelZ.Text = "Z";
            // 
            // tBoxY
            // 
            this.tBoxY.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxY.Location = new System.Drawing.Point(136, 76);
            this.tBoxY.Name = "tBoxY";
            this.tBoxY.Size = new System.Drawing.Size(119, 29);
            this.tBoxY.TabIndex = 7;
            this.tBoxY.Text = "-3707.2397";
            this.tBoxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelY.Location = new System.Drawing.Point(74, 83);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(20, 19);
            this.labelY.TabIndex = 6;
            this.labelY.Text = "Y";
            // 
            // tBoxX
            // 
            this.tBoxX.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxX.Location = new System.Drawing.Point(137, 32);
            this.tBoxX.Name = "tBoxX";
            this.tBoxX.Size = new System.Drawing.Size(119, 29);
            this.tBoxX.TabIndex = 5;
            this.tBoxX.Text = "2743.7381";
            this.tBoxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelX.Location = new System.Drawing.Point(76, 39);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(20, 19);
            this.labelX.TabIndex = 4;
            this.labelX.Text = "X";
            // 
            // tBoxTest
            // 
            this.tBoxTest.Font = new System.Drawing.Font("맑은 고딕", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxTest.Location = new System.Drawing.Point(124, 585);
            this.tBoxTest.Name = "tBoxTest";
            this.tBoxTest.Size = new System.Drawing.Size(236, 33);
            this.tBoxTest.TabIndex = 22;
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("맑은 고딕", 11.87629F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModify.Location = new System.Drawing.Point(527, 582);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(104, 38);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("맑은 고딕", 11.87629F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(650, 582);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 38);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("맑은 고딕", 11.87629F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(403, 582);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 38);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gBoxDisturbanceTarget
            // 
            this.gBoxDisturbanceTarget.Controls.Add(this.tBoxDragTgt);
            this.gBoxDisturbanceTarget.Controls.Add(this.label1);
            this.gBoxDisturbanceTarget.Controls.Add(this.cBoxDragTgt);
            this.gBoxDisturbanceTarget.Font = new System.Drawing.Font("맑은 고딕", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gBoxDisturbanceTarget.Location = new System.Drawing.Point(25, 379);
            this.gBoxDisturbanceTarget.Name = "gBoxDisturbanceTarget";
            this.gBoxDisturbanceTarget.Size = new System.Drawing.Size(729, 188);
            this.gBoxDisturbanceTarget.TabIndex = 0;
            this.gBoxDisturbanceTarget.TabStop = false;
            this.gBoxDisturbanceTarget.Text = "Disturbance";
            // 
            // tBoxDragTgt
            // 
            this.tBoxDragTgt.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxDragTgt.Location = new System.Drawing.Point(525, 36);
            this.tBoxDragTgt.Name = "tBoxDragTgt";
            this.tBoxDragTgt.Size = new System.Drawing.Size(158, 29);
            this.tBoxDragTgt.TabIndex = 32;
            this.tBoxDragTgt.Text = "0";
            this.tBoxDragTgt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("돋움", 14.84536F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(365, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Drag Coefficient";
            // 
            // cBoxDragTgt
            // 
            this.cBoxDragTgt.AutoSize = true;
            this.cBoxDragTgt.Font = new System.Drawing.Font("돋움", 14.84536F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cBoxDragTgt.Location = new System.Drawing.Point(40, 39);
            this.cBoxDragTgt.Name = "cBoxDragTgt";
            this.cBoxDragTgt.Size = new System.Drawing.Size(178, 24);
            this.cBoxDragTgt.TabIndex = 0;
            this.cBoxDragTgt.Text = "Atmospheric Drag";
            this.cBoxDragTgt.UseVisualStyleBackColor = true;
            this.cBoxDragTgt.CheckedChanged += new System.EventHandler(this.cBoxDragTgt_CheckedChanged);
            // 
            // gBoxSimulation
            // 
            this.gBoxSimulation.Controls.Add(this.gBoxManeuver);
            this.gBoxSimulation.Controls.Add(this.gBoxChaser);
            this.gBoxSimulation.Controls.Add(this.btnStart);
            this.gBoxSimulation.Controls.Add(this.gBoxTime2);
            this.gBoxSimulation.Font = new System.Drawing.Font("맑은 고딕", 22.26804F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gBoxSimulation.Location = new System.Drawing.Point(816, 23);
            this.gBoxSimulation.Name = "gBoxSimulation";
            this.gBoxSimulation.Size = new System.Drawing.Size(861, 905);
            this.gBoxSimulation.TabIndex = 2;
            this.gBoxSimulation.TabStop = false;
            this.gBoxSimulation.Text = "Simulation Setting";
            // 
            // gBoxManeuver
            // 
            this.gBoxManeuver.Controls.Add(this.button1);
            this.gBoxManeuver.Controls.Add(this.btnManeuverDel);
            this.gBoxManeuver.Controls.Add(this.btnManeuverAdd);
            this.gBoxManeuver.Controls.Add(this.dataGridView_Maneuver);
            this.gBoxManeuver.Font = new System.Drawing.Font("맑은 고딕", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gBoxManeuver.Location = new System.Drawing.Point(21, 593);
            this.gBoxManeuver.Name = "gBoxManeuver";
            this.gBoxManeuver.Size = new System.Drawing.Size(814, 219);
            this.gBoxManeuver.TabIndex = 23;
            this.gBoxManeuver.TabStop = false;
            this.gBoxManeuver.Text = "Maneuver Planning";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 11.87629F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(691, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Modify";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnManeuverDel
            // 
            this.btnManeuverDel.Font = new System.Drawing.Font("맑은 고딕", 11.87629F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnManeuverDel.Location = new System.Drawing.Point(691, 158);
            this.btnManeuverDel.Name = "btnManeuverDel";
            this.btnManeuverDel.Size = new System.Drawing.Size(105, 38);
            this.btnManeuverDel.TabIndex = 3;
            this.btnManeuverDel.Text = "Delete";
            this.btnManeuverDel.UseVisualStyleBackColor = true;
            this.btnManeuverDel.Click += new System.EventHandler(this.btnManeuverDel_Click);
            // 
            // btnManeuverAdd
            // 
            this.btnManeuverAdd.Font = new System.Drawing.Font("맑은 고딕", 11.87629F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnManeuverAdd.Location = new System.Drawing.Point(691, 44);
            this.btnManeuverAdd.Name = "btnManeuverAdd";
            this.btnManeuverAdd.Size = new System.Drawing.Size(105, 38);
            this.btnManeuverAdd.TabIndex = 2;
            this.btnManeuverAdd.Text = "Add";
            this.btnManeuverAdd.UseVisualStyleBackColor = true;
            this.btnManeuverAdd.Click += new System.EventHandler(this.btnManeuverAdd_Click);
            // 
            // dataGridView_Maneuver
            // 
            this.dataGridView_Maneuver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Maneuver.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Time,
            this.Col_vx,
            this.Col_vy,
            this.Col_vz,
            this.Col_Duration,
            this.Col_Type});
            this.dataGridView_Maneuver.Location = new System.Drawing.Point(17, 44);
            this.dataGridView_Maneuver.Name = "dataGridView_Maneuver";
            this.dataGridView_Maneuver.RowTemplate.Height = 25;
            this.dataGridView_Maneuver.Size = new System.Drawing.Size(649, 152);
            this.dataGridView_Maneuver.TabIndex = 0;
            // 
            // Col_Time
            // 
            this.Col_Time.HeaderText = "Time(sec)";
            this.Col_Time.Name = "Col_Time";
            this.Col_Time.Width = 101;
            // 
            // Col_vx
            // 
            this.Col_vx.HeaderText = "△Vx";
            this.Col_vx.Name = "Col_vx";
            this.Col_vx.Width = 101;
            // 
            // Col_vy
            // 
            this.Col_vy.HeaderText = "△Vy";
            this.Col_vy.Name = "Col_vy";
            this.Col_vy.Width = 101;
            // 
            // Col_vz
            // 
            this.Col_vz.HeaderText = "△Vz";
            this.Col_vz.Name = "Col_vz";
            this.Col_vz.Width = 101;
            // 
            // Col_Duration
            // 
            this.Col_Duration.HeaderText = "Duration";
            this.Col_Duration.Name = "Col_Duration";
            this.Col_Duration.Width = 101;
            // 
            // Col_Type
            // 
            this.Col_Type.HeaderText = "Type";
            this.Col_Type.Name = "Col_Type";
            this.Col_Type.Width = 101;
            // 
            // gBoxChaser
            // 
            this.gBoxChaser.Controls.Add(this.label6);
            this.gBoxChaser.Controls.Add(this.label4);
            this.gBoxChaser.Controls.Add(this.tBoxCorssSecCha);
            this.gBoxChaser.Controls.Add(this.tBoxTgtNum);
            this.gBoxChaser.Controls.Add(this.labelTGTSAT);
            this.gBoxChaser.Controls.Add(this.labelKg_Chaser);
            this.gBoxChaser.Controls.Add(this.tBoxMass_Chaser);
            this.gBoxChaser.Controls.Add(this.labelMass_Chaser);
            this.gBoxChaser.Controls.Add(this.gBoxRelPOSVEL);
            this.gBoxChaser.Controls.Add(this.gBoxDisturbanceChaser);
            this.gBoxChaser.Font = new System.Drawing.Font("맑은 고딕", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gBoxChaser.Location = new System.Drawing.Point(21, 55);
            this.gBoxChaser.Name = "gBoxChaser";
            this.gBoxChaser.Size = new System.Drawing.Size(814, 529);
            this.gBoxChaser.TabIndex = 29;
            this.gBoxChaser.TabStop = false;
            this.gBoxChaser.Text = "Chaser Initial Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(48, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 19);
            this.label6.TabIndex = 34;
            this.label6.Text = "Cross-Section";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(350, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 35;
            this.label4.Text = "m^2";
            // 
            // tBoxCorssSecCha
            // 
            this.tBoxCorssSecCha.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxCorssSecCha.Location = new System.Drawing.Point(225, 140);
            this.tBoxCorssSecCha.Name = "tBoxCorssSecCha";
            this.tBoxCorssSecCha.Size = new System.Drawing.Size(119, 29);
            this.tBoxCorssSecCha.TabIndex = 32;
            this.tBoxCorssSecCha.Text = "1";
            this.tBoxCorssSecCha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBoxTgtNum
            // 
            this.tBoxTgtNum.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxTgtNum.Location = new System.Drawing.Point(225, 55);
            this.tBoxTgtNum.Name = "tBoxTgtNum";
            this.tBoxTgtNum.Size = new System.Drawing.Size(119, 29);
            this.tBoxTgtNum.TabIndex = 34;
            this.tBoxTgtNum.Text = "1";
            this.tBoxTgtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTGTSAT
            // 
            this.labelTGTSAT.AutoSize = true;
            this.labelTGTSAT.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTGTSAT.Location = new System.Drawing.Point(45, 61);
            this.labelTGTSAT.Name = "labelTGTSAT";
            this.labelTGTSAT.Size = new System.Drawing.Size(125, 19);
            this.labelTGTSAT.TabIndex = 32;
            this.labelTGTSAT.Text = "Target Number";
            // 
            // labelKg_Chaser
            // 
            this.labelKg_Chaser.AutoSize = true;
            this.labelKg_Chaser.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKg_Chaser.Location = new System.Drawing.Point(350, 104);
            this.labelKg_Chaser.Name = "labelKg_Chaser";
            this.labelKg_Chaser.Size = new System.Drawing.Size(28, 19);
            this.labelKg_Chaser.TabIndex = 33;
            this.labelKg_Chaser.Text = "kg";
            // 
            // tBoxMass_Chaser
            // 
            this.tBoxMass_Chaser.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxMass_Chaser.Location = new System.Drawing.Point(225, 98);
            this.tBoxMass_Chaser.Name = "tBoxMass_Chaser";
            this.tBoxMass_Chaser.Size = new System.Drawing.Size(119, 29);
            this.tBoxMass_Chaser.TabIndex = 32;
            this.tBoxMass_Chaser.Text = "10";
            this.tBoxMass_Chaser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelMass_Chaser
            // 
            this.labelMass_Chaser.AutoSize = true;
            this.labelMass_Chaser.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMass_Chaser.Location = new System.Drawing.Point(89, 105);
            this.labelMass_Chaser.Name = "labelMass_Chaser";
            this.labelMass_Chaser.Size = new System.Drawing.Size(49, 19);
            this.labelMass_Chaser.TabIndex = 31;
            this.labelMass_Chaser.Text = "Mass";
            // 
            // gBoxRelPOSVEL
            // 
            this.gBoxRelPOSVEL.Controls.Add(this.tBoxXRel);
            this.gBoxRelPOSVEL.Controls.Add(this.labelXRel);
            this.gBoxRelPOSVEL.Controls.Add(this.labelM6);
            this.gBoxRelPOSVEL.Controls.Add(this.labelYRel);
            this.gBoxRelPOSVEL.Controls.Add(this.labelM5);
            this.gBoxRelPOSVEL.Controls.Add(this.tBoxYRel);
            this.gBoxRelPOSVEL.Controls.Add(this.labelM4);
            this.gBoxRelPOSVEL.Controls.Add(this.labelZRel);
            this.gBoxRelPOSVEL.Controls.Add(this.labelM3);
            this.gBoxRelPOSVEL.Controls.Add(this.tBoxZRel);
            this.gBoxRelPOSVEL.Controls.Add(this.labelM2);
            this.gBoxRelPOSVEL.Controls.Add(this.labelXvelRel);
            this.gBoxRelPOSVEL.Controls.Add(this.labelM1);
            this.gBoxRelPOSVEL.Controls.Add(this.tBoxXvelRel);
            this.gBoxRelPOSVEL.Controls.Add(this.tBoxZvelRel);
            this.gBoxRelPOSVEL.Controls.Add(this.labelYVelRel);
            this.gBoxRelPOSVEL.Controls.Add(this.labelZVelRel);
            this.gBoxRelPOSVEL.Controls.Add(this.tBoxYvelRel);
            this.gBoxRelPOSVEL.Location = new System.Drawing.Point(422, 29);
            this.gBoxRelPOSVEL.Name = "gBoxRelPOSVEL";
            this.gBoxRelPOSVEL.Size = new System.Drawing.Size(374, 292);
            this.gBoxRelPOSVEL.TabIndex = 23;
            this.gBoxRelPOSVEL.TabStop = false;
            this.gBoxRelPOSVEL.Text = "Relative Position, Velocity";
            // 
            // tBoxXRel
            // 
            this.tBoxXRel.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxXRel.Location = new System.Drawing.Point(135, 36);
            this.tBoxXRel.Name = "tBoxXRel";
            this.tBoxXRel.Size = new System.Drawing.Size(119, 29);
            this.tBoxXRel.TabIndex = 5;
            this.tBoxXRel.Text = "0";
            this.tBoxXRel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelXRel
            // 
            this.labelXRel.AutoSize = true;
            this.labelXRel.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelXRel.Location = new System.Drawing.Point(75, 43);
            this.labelXRel.Name = "labelXRel";
            this.labelXRel.Size = new System.Drawing.Size(20, 19);
            this.labelXRel.TabIndex = 4;
            this.labelXRel.Text = "X";
            // 
            // labelM6
            // 
            this.labelM6.AutoSize = true;
            this.labelM6.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelM6.Location = new System.Drawing.Point(261, 259);
            this.labelM6.Name = "labelM6";
            this.labelM6.Size = new System.Drawing.Size(60, 19);
            this.labelM6.TabIndex = 21;
            this.labelM6.Text = "m/sec";
            // 
            // labelYRel
            // 
            this.labelYRel.AutoSize = true;
            this.labelYRel.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelYRel.Location = new System.Drawing.Point(75, 86);
            this.labelYRel.Name = "labelYRel";
            this.labelYRel.Size = new System.Drawing.Size(20, 19);
            this.labelYRel.TabIndex = 6;
            this.labelYRel.Text = "Y";
            // 
            // labelM5
            // 
            this.labelM5.AutoSize = true;
            this.labelM5.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelM5.Location = new System.Drawing.Point(262, 216);
            this.labelM5.Name = "labelM5";
            this.labelM5.Size = new System.Drawing.Size(60, 19);
            this.labelM5.TabIndex = 20;
            this.labelM5.Text = "m/sec";
            // 
            // tBoxYRel
            // 
            this.tBoxYRel.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxYRel.Location = new System.Drawing.Point(136, 79);
            this.tBoxYRel.Name = "tBoxYRel";
            this.tBoxYRel.Size = new System.Drawing.Size(119, 29);
            this.tBoxYRel.TabIndex = 7;
            this.tBoxYRel.Text = "0";
            this.tBoxYRel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelM4
            // 
            this.labelM4.AutoSize = true;
            this.labelM4.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelM4.Location = new System.Drawing.Point(260, 173);
            this.labelM4.Name = "labelM4";
            this.labelM4.Size = new System.Drawing.Size(60, 19);
            this.labelM4.TabIndex = 19;
            this.labelM4.Text = "m/sec";
            // 
            // labelZRel
            // 
            this.labelZRel.AutoSize = true;
            this.labelZRel.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelZRel.Location = new System.Drawing.Point(75, 130);
            this.labelZRel.Name = "labelZRel";
            this.labelZRel.Size = new System.Drawing.Size(20, 19);
            this.labelZRel.TabIndex = 8;
            this.labelZRel.Text = "Z";
            // 
            // labelM3
            // 
            this.labelM3.AutoSize = true;
            this.labelM3.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelM3.Location = new System.Drawing.Point(261, 128);
            this.labelM3.Name = "labelM3";
            this.labelM3.Size = new System.Drawing.Size(24, 19);
            this.labelM3.TabIndex = 18;
            this.labelM3.Text = "m";
            // 
            // tBoxZRel
            // 
            this.tBoxZRel.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxZRel.Location = new System.Drawing.Point(136, 123);
            this.tBoxZRel.Name = "tBoxZRel";
            this.tBoxZRel.Size = new System.Drawing.Size(119, 29);
            this.tBoxZRel.TabIndex = 9;
            this.tBoxZRel.Text = "0";
            this.tBoxZRel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelM2
            // 
            this.labelM2.AutoSize = true;
            this.labelM2.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelM2.Location = new System.Drawing.Point(261, 83);
            this.labelM2.Name = "labelM2";
            this.labelM2.Size = new System.Drawing.Size(24, 19);
            this.labelM2.TabIndex = 17;
            this.labelM2.Text = "m";
            // 
            // labelXvelRel
            // 
            this.labelXvelRel.AutoSize = true;
            this.labelXvelRel.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelXvelRel.Location = new System.Drawing.Point(41, 173);
            this.labelXvelRel.Name = "labelXvelRel";
            this.labelXvelRel.Size = new System.Drawing.Size(88, 19);
            this.labelXvelRel.TabIndex = 10;
            this.labelXvelRel.Text = "X Velocity";
            // 
            // labelM1
            // 
            this.labelM1.AutoSize = true;
            this.labelM1.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelM1.Location = new System.Drawing.Point(260, 41);
            this.labelM1.Name = "labelM1";
            this.labelM1.Size = new System.Drawing.Size(24, 19);
            this.labelM1.TabIndex = 16;
            this.labelM1.Text = "m";
            // 
            // tBoxXvelRel
            // 
            this.tBoxXvelRel.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxXvelRel.Location = new System.Drawing.Point(136, 166);
            this.tBoxXvelRel.Name = "tBoxXvelRel";
            this.tBoxXvelRel.Size = new System.Drawing.Size(119, 29);
            this.tBoxXvelRel.TabIndex = 11;
            this.tBoxXvelRel.Text = "0";
            this.tBoxXvelRel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tBoxZvelRel
            // 
            this.tBoxZvelRel.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxZvelRel.Location = new System.Drawing.Point(136, 252);
            this.tBoxZvelRel.Name = "tBoxZvelRel";
            this.tBoxZvelRel.Size = new System.Drawing.Size(119, 29);
            this.tBoxZvelRel.TabIndex = 15;
            this.tBoxZvelRel.Text = "0";
            this.tBoxZvelRel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelYVelRel
            // 
            this.labelYVelRel.AutoSize = true;
            this.labelYVelRel.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelYVelRel.Location = new System.Drawing.Point(41, 216);
            this.labelYVelRel.Name = "labelYVelRel";
            this.labelYVelRel.Size = new System.Drawing.Size(88, 19);
            this.labelYVelRel.TabIndex = 12;
            this.labelYVelRel.Text = "Y Velocity";
            // 
            // labelZVelRel
            // 
            this.labelZVelRel.AutoSize = true;
            this.labelZVelRel.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelZVelRel.Location = new System.Drawing.Point(41, 259);
            this.labelZVelRel.Name = "labelZVelRel";
            this.labelZVelRel.Size = new System.Drawing.Size(88, 19);
            this.labelZVelRel.TabIndex = 14;
            this.labelZVelRel.Text = "Z Velocity";
            // 
            // tBoxYvelRel
            // 
            this.tBoxYvelRel.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxYvelRel.Location = new System.Drawing.Point(136, 209);
            this.tBoxYvelRel.Name = "tBoxYvelRel";
            this.tBoxYvelRel.Size = new System.Drawing.Size(119, 29);
            this.tBoxYvelRel.TabIndex = 13;
            this.tBoxYvelRel.Text = "0";
            this.tBoxYvelRel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gBoxDisturbanceChaser
            // 
            this.gBoxDisturbanceChaser.Controls.Add(this.tBoxDragCha);
            this.gBoxDisturbanceChaser.Controls.Add(this.label2);
            this.gBoxDisturbanceChaser.Controls.Add(this.cBoxDragCha);
            this.gBoxDisturbanceChaser.Font = new System.Drawing.Font("맑은 고딕", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gBoxDisturbanceChaser.Location = new System.Drawing.Point(17, 324);
            this.gBoxDisturbanceChaser.Name = "gBoxDisturbanceChaser";
            this.gBoxDisturbanceChaser.Size = new System.Drawing.Size(779, 188);
            this.gBoxDisturbanceChaser.TabIndex = 22;
            this.gBoxDisturbanceChaser.TabStop = false;
            this.gBoxDisturbanceChaser.Text = "Disturbance";
            // 
            // tBoxDragCha
            // 
            this.tBoxDragCha.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxDragCha.Location = new System.Drawing.Point(554, 34);
            this.tBoxDragCha.Name = "tBoxDragCha";
            this.tBoxDragCha.Size = new System.Drawing.Size(158, 29);
            this.tBoxDragCha.TabIndex = 33;
            this.tBoxDragCha.Text = "0";
            this.tBoxDragCha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("돋움", 14.84536F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(391, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Drag Coefficient";
            // 
            // cBoxDragCha
            // 
            this.cBoxDragCha.AutoSize = true;
            this.cBoxDragCha.Font = new System.Drawing.Font("돋움", 14.84536F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cBoxDragCha.Location = new System.Drawing.Point(42, 39);
            this.cBoxDragCha.Name = "cBoxDragCha";
            this.cBoxDragCha.Size = new System.Drawing.Size(178, 24);
            this.cBoxDragCha.TabIndex = 3;
            this.cBoxDragCha.Text = "Atmospheric Drag";
            this.cBoxDragCha.UseVisualStyleBackColor = true;
            this.cBoxDragCha.CheckedChanged += new System.EventHandler(this.cBoxDragCha_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("맑은 고딕", 11.87629F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(688, 832);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(147, 51);
            this.btnStart.TabIndex = 28;
            this.btnStart.Text = "Start Simulation";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // gBoxTime2
            // 
            this.gBoxTime2.Controls.Add(this.dateTimePicker_EndSimul);
            this.gBoxTime2.Controls.Add(this.labelWave);
            this.gBoxTime2.Controls.Add(this.labelUTC4);
            this.gBoxTime2.Controls.Add(this.labelUTC3);
            this.gBoxTime2.Controls.Add(this.dateTimePicker_StartSimul);
            this.gBoxTime2.Font = new System.Drawing.Font("맑은 고딕", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gBoxTime2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gBoxTime2.Location = new System.Drawing.Point(21, 818);
            this.gBoxTime2.Name = "gBoxTime2";
            this.gBoxTime2.Size = new System.Drawing.Size(650, 65);
            this.gBoxTime2.TabIndex = 6;
            this.gBoxTime2.TabStop = false;
            this.gBoxTime2.Text = "Time Setting";
            // 
            // dateTimePicker_EndSimul
            // 
            this.dateTimePicker_EndSimul.CalendarFont = new System.Drawing.Font("돋움", 17.81443F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_EndSimul.CustomFormat = " yyy/MM/dd HH:mm:ss";
            this.dateTimePicker_EndSimul.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_EndSimul.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_EndSimul.Location = new System.Drawing.Point(357, 28);
            this.dateTimePicker_EndSimul.Name = "dateTimePicker_EndSimul";
            this.dateTimePicker_EndSimul.ShowUpDown = true;
            this.dateTimePicker_EndSimul.Size = new System.Drawing.Size(223, 29);
            this.dateTimePicker_EndSimul.TabIndex = 3;
            this.dateTimePicker_EndSimul.Value = new System.DateTime(2021, 11, 6, 3, 0, 0, 0);
            // 
            // labelWave
            // 
            this.labelWave.AutoSize = true;
            this.labelWave.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelWave.Location = new System.Drawing.Point(310, 33);
            this.labelWave.Name = "labelWave";
            this.labelWave.Size = new System.Drawing.Size(23, 19);
            this.labelWave.TabIndex = 4;
            this.labelWave.Text = "~";
            // 
            // labelUTC4
            // 
            this.labelUTC4.AutoSize = true;
            this.labelUTC4.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUTC4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelUTC4.Location = new System.Drawing.Point(588, 35);
            this.labelUTC4.Name = "labelUTC4";
            this.labelUTC4.Size = new System.Drawing.Size(43, 19);
            this.labelUTC4.TabIndex = 1;
            this.labelUTC4.Text = "UTC";
            // 
            // labelUTC3
            // 
            this.labelUTC3.AutoSize = true;
            this.labelUTC3.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUTC3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelUTC3.Location = new System.Drawing.Point(246, 33);
            this.labelUTC3.Name = "labelUTC3";
            this.labelUTC3.Size = new System.Drawing.Size(43, 19);
            this.labelUTC3.TabIndex = 0;
            this.labelUTC3.Text = "UTC";
            // 
            // dateTimePicker_StartSimul
            // 
            this.dateTimePicker_StartSimul.CalendarFont = new System.Drawing.Font("돋움", 17.81443F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_StartSimul.CustomFormat = " yyy/MM/dd HH:mm:ss";
            this.dateTimePicker_StartSimul.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_StartSimul.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_StartSimul.Location = new System.Drawing.Point(17, 28);
            this.dateTimePicker_StartSimul.Name = "dateTimePicker_StartSimul";
            this.dateTimePicker_StartSimul.ShowUpDown = true;
            this.dateTimePicker_StartSimul.Size = new System.Drawing.Size(223, 29);
            this.dateTimePicker_StartSimul.TabIndex = 2;
            this.dateTimePicker_StartSimul.Value = new System.DateTime(2021, 11, 5, 3, 0, 0, 0);
            // 
            // SatelliteDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 950);
            this.Controls.Add(this.gBoxSimulation);
            this.Controls.Add(this.gBoxAddSAT);
            this.Controls.Add(this.gBoxList);
            this.Name = "SatelliteDataForm";
            this.Text = "Satellite Data Management";
            this.gBoxList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SAT)).EndInit();
            this.gBoxAddSAT.ResumeLayout(false);
            this.gBoxAddSAT.PerformLayout();
            this.gBoxPosVel.ResumeLayout(false);
            this.gBoxPosVel.PerformLayout();
            this.gBoxDisturbanceTarget.ResumeLayout(false);
            this.gBoxDisturbanceTarget.PerformLayout();
            this.gBoxSimulation.ResumeLayout(false);
            this.gBoxManeuver.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Maneuver)).EndInit();
            this.gBoxChaser.ResumeLayout(false);
            this.gBoxChaser.PerformLayout();
            this.gBoxRelPOSVEL.ResumeLayout(false);
            this.gBoxRelPOSVEL.PerformLayout();
            this.gBoxDisturbanceChaser.ResumeLayout(false);
            this.gBoxDisturbanceChaser.PerformLayout();
            this.gBoxTime2.ResumeLayout(false);
            this.gBoxTime2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxList;
        private System.Windows.Forms.GroupBox gBoxAddSAT;
        private System.Windows.Forms.GroupBox gBoxDisturbanceTarget;
        private System.Windows.Forms.GroupBox gBoxSimulation;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.DataGridView dataGridView_SAT;
        private System.Windows.Forms.GroupBox gBoxTime2;
        private System.Windows.Forms.Label labelWave;
        private System.Windows.Forms.DateTimePicker dateTimePicker_EndSimul;
        private System.Windows.Forms.DateTimePicker dateTimePicker_StartSimul;
        private System.Windows.Forms.Label labelUTC4;
        private System.Windows.Forms.Label labelUTC3;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox tBoxX;
        private System.Windows.Forms.TextBox tBoxZ;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.TextBox tBoxY;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelKM1;
        private System.Windows.Forms.TextBox tBoxZvel;
        private System.Windows.Forms.Label labelZvel;
        private System.Windows.Forms.TextBox tBoxYvel;
        private System.Windows.Forms.Label labelYvel;
        private System.Windows.Forms.TextBox tBoxXvel;
        private System.Windows.Forms.Label labelXvel;
        private System.Windows.Forms.Label labelKM6;
        private System.Windows.Forms.Label labelKM5;
        private System.Windows.Forms.Label labelKM4;
        private System.Windows.Forms.Label labelKM3;
        private System.Windows.Forms.Label labelKM2;
        private System.Windows.Forms.TextBox tBoxTest;
        private System.Windows.Forms.GroupBox gBoxPosVel;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Epoch;
        private System.Windows.Forms.Label labelEpoch;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label labelMass;
        private System.Windows.Forms.TextBox tBoxMass;
        private System.Windows.Forms.GroupBox gBoxChaser;
        private System.Windows.Forms.Label labelM6;
        private System.Windows.Forms.Label labelM5;
        private System.Windows.Forms.Label labelM4;
        private System.Windows.Forms.Label labelM3;
        private System.Windows.Forms.Label labelM2;
        private System.Windows.Forms.Label labelM1;
        private System.Windows.Forms.TextBox tBoxZvelRel;
        private System.Windows.Forms.Label labelZVelRel;
        private System.Windows.Forms.TextBox tBoxYvelRel;
        private System.Windows.Forms.Label labelYVelRel;
        private System.Windows.Forms.TextBox tBoxXvelRel;
        private System.Windows.Forms.Label labelXvelRel;
        private System.Windows.Forms.TextBox tBoxZRel;
        private System.Windows.Forms.Label labelZRel;
        private System.Windows.Forms.TextBox tBoxYRel;
        private System.Windows.Forms.Label labelYRel;
        private System.Windows.Forms.TextBox tBoxXRel;
        private System.Windows.Forms.Label labelXRel;
        private System.Windows.Forms.GroupBox gBoxDisturbanceChaser;
        private System.Windows.Forms.GroupBox gBoxRelPOSVEL;
        private System.Windows.Forms.Label labelKG_Target;
        private System.Windows.Forms.TextBox tBoxTgtNum;
        private System.Windows.Forms.Label labelTGTSAT;
        private System.Windows.Forms.Label labelKg_Chaser;
        private System.Windows.Forms.TextBox tBoxMass_Chaser;
        private System.Windows.Forms.Label labelMass_Chaser;
        private System.Windows.Forms.GroupBox gBoxManeuver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_a;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_e;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_i;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_RAAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_w;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_TA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Period;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Epoch;
        private System.Windows.Forms.Button btnManeuverAdd;
        private System.Windows.Forms.DataGridView dataGridView_Maneuver;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnManeuverDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_vx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_vy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_vz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Type;
        private System.Windows.Forms.TextBox tBoxDragTgt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cBoxDragTgt;
        private System.Windows.Forms.TextBox tBoxDragCha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cBoxDragCha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxCrossSecTgt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxCorssSecCha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}