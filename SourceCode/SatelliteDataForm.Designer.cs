
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
            this.Col_Epoch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBoxAddSAT = new System.Windows.Forms.GroupBox();
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
            this.gBoxSimulation = new System.Windows.Forms.GroupBox();
            this.gBoxManeuver = new System.Windows.Forms.GroupBox();
            this.gBoxChaser = new System.Windows.Forms.GroupBox();
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
            this.gBoxSimulation.SuspendLayout();
            this.gBoxChaser.SuspendLayout();
            this.gBoxRelPOSVEL.SuspendLayout();
            this.gBoxTime2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxList
            // 
            this.gBoxList.Controls.Add(this.dataGridView_SAT);
            this.gBoxList.Font = new System.Drawing.Font("맑은 고딕", 22.26804F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gBoxList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gBoxList.Location = new System.Drawing.Point(21, 673);
            this.gBoxList.Name = "gBoxList";
            this.gBoxList.Size = new System.Drawing.Size(772, 255);
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
            this.Col_Epoch});
            this.dataGridView_SAT.Location = new System.Drawing.Point(21, 46);
            this.dataGridView_SAT.Name = "dataGridView_SAT";
            this.dataGridView_SAT.RowTemplate.Height = 25;
            this.dataGridView_SAT.Size = new System.Drawing.Size(729, 187);
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
            // Col_Epoch
            // 
            this.Col_Epoch.HeaderText = "Epoch";
            this.Col_Epoch.Name = "Col_Epoch";
            this.Col_Epoch.Width = 126;
            // 
            // gBoxAddSAT
            // 
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
            this.gBoxAddSAT.Size = new System.Drawing.Size(772, 644);
            this.gBoxAddSAT.TabIndex = 1;
            this.gBoxAddSAT.TabStop = false;
            this.gBoxAddSAT.Text = "Target Satellite Management";
            // 
            // labelKG_Target
            // 
            this.labelKG_Target.AutoSize = true;
            this.labelKG_Target.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKG_Target.Location = new System.Drawing.Point(215, 137);
            this.labelKG_Target.Name = "labelKG_Target";
            this.labelKG_Target.Size = new System.Drawing.Size(28, 19);
            this.labelKG_Target.TabIndex = 30;
            this.labelKG_Target.Text = "kg";
            // 
            // tBoxMass
            // 
            this.tBoxMass.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxMass.Location = new System.Drawing.Point(90, 133);
            this.tBoxMass.Name = "tBoxMass";
            this.tBoxMass.Size = new System.Drawing.Size(119, 29);
            this.tBoxMass.TabIndex = 29;
            this.tBoxMass.Text = "10";
            this.tBoxMass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelMass
            // 
            this.labelMass.AutoSize = true;
            this.labelMass.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMass.Location = new System.Drawing.Point(35, 140);
            this.labelMass.Name = "labelMass";
            this.labelMass.Size = new System.Drawing.Size(49, 19);
            this.labelMass.TabIndex = 28;
            this.labelMass.Text = "Mass";
            // 
            // labelEpoch
            // 
            this.labelEpoch.AutoSize = true;
            this.labelEpoch.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEpoch.Location = new System.Drawing.Point(25, 192);
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
            this.dateTimePicker_Epoch.Location = new System.Drawing.Point(90, 186);
            this.dateTimePicker_Epoch.Name = "dateTimePicker_Epoch";
            this.dateTimePicker_Epoch.ShowUpDown = true;
            this.dateTimePicker_Epoch.Size = new System.Drawing.Size(227, 29);
            this.dateTimePicker_Epoch.TabIndex = 26;
            // 
            // tBoxName
            // 
            this.tBoxName.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxName.Location = new System.Drawing.Point(90, 78);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(119, 29);
            this.tBoxName.TabIndex = 25;
            this.tBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(31, 84);
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
            this.gBoxPosVel.Location = new System.Drawing.Point(390, 46);
            this.gBoxPosVel.Name = "gBoxPosVel";
            this.gBoxPosVel.Size = new System.Drawing.Size(364, 346);
            this.gBoxPosVel.TabIndex = 23;
            this.gBoxPosVel.TabStop = false;
            this.gBoxPosVel.Text = "Position, Velocity";
            // 
            // labelKM6
            // 
            this.labelKM6.AutoSize = true;
            this.labelKM6.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKM6.Location = new System.Drawing.Point(259, 308);
            this.labelKM6.Name = "labelKM6";
            this.labelKM6.Size = new System.Drawing.Size(69, 19);
            this.labelKM6.TabIndex = 21;
            this.labelKM6.Text = "km/sec";
            // 
            // labelKM5
            // 
            this.labelKM5.AutoSize = true;
            this.labelKM5.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKM5.Location = new System.Drawing.Point(259, 255);
            this.labelKM5.Name = "labelKM5";
            this.labelKM5.Size = new System.Drawing.Size(69, 19);
            this.labelKM5.TabIndex = 20;
            this.labelKM5.Text = "km/sec";
            // 
            // labelKM4
            // 
            this.labelKM4.AutoSize = true;
            this.labelKM4.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKM4.Location = new System.Drawing.Point(258, 201);
            this.labelKM4.Name = "labelKM4";
            this.labelKM4.Size = new System.Drawing.Size(69, 19);
            this.labelKM4.TabIndex = 19;
            this.labelKM4.Text = "km/sec";
            // 
            // labelKM3
            // 
            this.labelKM3.AutoSize = true;
            this.labelKM3.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKM3.Location = new System.Drawing.Point(259, 147);
            this.labelKM3.Name = "labelKM3";
            this.labelKM3.Size = new System.Drawing.Size(33, 19);
            this.labelKM3.TabIndex = 18;
            this.labelKM3.Text = "km";
            // 
            // labelKM2
            // 
            this.labelKM2.AutoSize = true;
            this.labelKM2.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKM2.Location = new System.Drawing.Point(259, 95);
            this.labelKM2.Name = "labelKM2";
            this.labelKM2.Size = new System.Drawing.Size(33, 19);
            this.labelKM2.TabIndex = 17;
            this.labelKM2.Text = "km";
            // 
            // labelKM1
            // 
            this.labelKM1.AutoSize = true;
            this.labelKM1.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKM1.Location = new System.Drawing.Point(258, 39);
            this.labelKM1.Name = "labelKM1";
            this.labelKM1.Size = new System.Drawing.Size(33, 19);
            this.labelKM1.TabIndex = 16;
            this.labelKM1.Text = "km";
            // 
            // tBoxZvel
            // 
            this.tBoxZvel.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxZvel.Location = new System.Drawing.Point(134, 301);
            this.tBoxZvel.Name = "tBoxZvel";
            this.tBoxZvel.Size = new System.Drawing.Size(119, 29);
            this.tBoxZvel.TabIndex = 15;
            this.tBoxZvel.Text = "-1.976341";
            this.tBoxZvel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelZvel
            // 
            this.labelZvel.AutoSize = true;
            this.labelZvel.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelZvel.Location = new System.Drawing.Point(39, 308);
            this.labelZvel.Name = "labelZvel";
            this.labelZvel.Size = new System.Drawing.Size(88, 19);
            this.labelZvel.TabIndex = 14;
            this.labelZvel.Text = "Z Velocity";
            // 
            // tBoxYvel
            // 
            this.tBoxYvel.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxYvel.Location = new System.Drawing.Point(133, 248);
            this.tBoxYvel.Name = "tBoxYvel";
            this.tBoxYvel.Size = new System.Drawing.Size(119, 29);
            this.tBoxYvel.TabIndex = 13;
            this.tBoxYvel.Text = "5.533756";
            this.tBoxYvel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelYvel
            // 
            this.labelYvel.AutoSize = true;
            this.labelYvel.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelYvel.Location = new System.Drawing.Point(38, 255);
            this.labelYvel.Name = "labelYvel";
            this.labelYvel.Size = new System.Drawing.Size(88, 19);
            this.labelYvel.TabIndex = 12;
            this.labelYvel.Text = "Y Velocity";
            // 
            // tBoxXvel
            // 
            this.tBoxXvel.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxXvel.Location = new System.Drawing.Point(134, 194);
            this.tBoxXvel.Name = "tBoxXvel";
            this.tBoxXvel.Size = new System.Drawing.Size(119, 29);
            this.tBoxXvel.TabIndex = 11;
            this.tBoxXvel.Text = "4.901327";
            this.tBoxXvel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelXvel
            // 
            this.labelXvel.AutoSize = true;
            this.labelXvel.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelXvel.Location = new System.Drawing.Point(39, 201);
            this.labelXvel.Name = "labelXvel";
            this.labelXvel.Size = new System.Drawing.Size(88, 19);
            this.labelXvel.TabIndex = 10;
            this.labelXvel.Text = "X Velocity";
            // 
            // tBoxZ
            // 
            this.tBoxZ.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxZ.Location = new System.Drawing.Point(134, 140);
            this.tBoxZ.Name = "tBoxZ";
            this.tBoxZ.Size = new System.Drawing.Size(119, 29);
            this.tBoxZ.TabIndex = 9;
            this.tBoxZ.Text = "6448.296";
            this.tBoxZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelZ.Location = new System.Drawing.Point(108, 147);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(20, 19);
            this.labelZ.TabIndex = 8;
            this.labelZ.Text = "Z";
            // 
            // tBoxY
            // 
            this.tBoxY.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxY.Location = new System.Drawing.Point(134, 88);
            this.tBoxY.Name = "tBoxY";
            this.tBoxY.Size = new System.Drawing.Size(119, 29);
            this.tBoxY.TabIndex = 7;
            this.tBoxY.Text = "6862.875";
            this.tBoxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelY.Location = new System.Drawing.Point(108, 95);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(20, 19);
            this.labelY.TabIndex = 6;
            this.labelY.Text = "Y";
            // 
            // tBoxX
            // 
            this.tBoxX.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxX.Location = new System.Drawing.Point(133, 32);
            this.tBoxX.Name = "tBoxX";
            this.tBoxX.Size = new System.Drawing.Size(119, 29);
            this.tBoxX.TabIndex = 5;
            this.tBoxX.Text = "6524.834";
            this.tBoxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelX.Location = new System.Drawing.Point(108, 39);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(20, 19);
            this.labelX.TabIndex = 4;
            this.labelX.Text = "X";
            // 
            // tBoxTest
            // 
            this.tBoxTest.Font = new System.Drawing.Font("맑은 고딕", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxTest.Location = new System.Drawing.Point(124, 593);
            this.tBoxTest.Name = "tBoxTest";
            this.tBoxTest.Size = new System.Drawing.Size(236, 33);
            this.tBoxTest.TabIndex = 22;
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("맑은 고딕", 11.87629F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModify.Location = new System.Drawing.Point(527, 590);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(104, 38);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("맑은 고딕", 11.87629F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(650, 590);
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
            this.btnAdd.Location = new System.Drawing.Point(403, 590);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 38);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gBoxDisturbanceTarget
            // 
            this.gBoxDisturbanceTarget.Font = new System.Drawing.Font("맑은 고딕", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gBoxDisturbanceTarget.Location = new System.Drawing.Point(25, 398);
            this.gBoxDisturbanceTarget.Name = "gBoxDisturbanceTarget";
            this.gBoxDisturbanceTarget.Size = new System.Drawing.Size(729, 186);
            this.gBoxDisturbanceTarget.TabIndex = 0;
            this.gBoxDisturbanceTarget.TabStop = false;
            this.gBoxDisturbanceTarget.Text = "Disturbance";
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
            this.gBoxManeuver.Font = new System.Drawing.Font("맑은 고딕", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gBoxManeuver.Location = new System.Drawing.Point(21, 593);
            this.gBoxManeuver.Name = "gBoxManeuver";
            this.gBoxManeuver.Size = new System.Drawing.Size(814, 219);
            this.gBoxManeuver.TabIndex = 23;
            this.gBoxManeuver.TabStop = false;
            this.gBoxManeuver.Text = "Maneuver Planning";
            // 
            // gBoxChaser
            // 
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
            // tBoxTgtNum
            // 
            this.tBoxTgtNum.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxTgtNum.Location = new System.Drawing.Point(573, 44);
            this.tBoxTgtNum.Name = "tBoxTgtNum";
            this.tBoxTgtNum.Size = new System.Drawing.Size(119, 29);
            this.tBoxTgtNum.TabIndex = 34;
            // 
            // labelTGTSAT
            // 
            this.labelTGTSAT.AutoSize = true;
            this.labelTGTSAT.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTGTSAT.Location = new System.Drawing.Point(372, 50);
            this.labelTGTSAT.Name = "labelTGTSAT";
            this.labelTGTSAT.Size = new System.Drawing.Size(190, 19);
            this.labelTGTSAT.TabIndex = 32;
            this.labelTGTSAT.Text = "Target Satellite Number";
            // 
            // labelKg_Chaser
            // 
            this.labelKg_Chaser.AutoSize = true;
            this.labelKg_Chaser.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKg_Chaser.Location = new System.Drawing.Point(291, 50);
            this.labelKg_Chaser.Name = "labelKg_Chaser";
            this.labelKg_Chaser.Size = new System.Drawing.Size(28, 19);
            this.labelKg_Chaser.TabIndex = 33;
            this.labelKg_Chaser.Text = "kg";
            // 
            // tBoxMass_Chaser
            // 
            this.tBoxMass_Chaser.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxMass_Chaser.Location = new System.Drawing.Point(166, 44);
            this.tBoxMass_Chaser.Name = "tBoxMass_Chaser";
            this.tBoxMass_Chaser.Size = new System.Drawing.Size(119, 29);
            this.tBoxMass_Chaser.TabIndex = 32;
            // 
            // labelMass_Chaser
            // 
            this.labelMass_Chaser.AutoSize = true;
            this.labelMass_Chaser.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMass_Chaser.Location = new System.Drawing.Point(111, 51);
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
            this.gBoxRelPOSVEL.Location = new System.Drawing.Point(17, 97);
            this.gBoxRelPOSVEL.Name = "gBoxRelPOSVEL";
            this.gBoxRelPOSVEL.Size = new System.Drawing.Size(779, 210);
            this.gBoxRelPOSVEL.TabIndex = 23;
            this.gBoxRelPOSVEL.TabStop = false;
            this.gBoxRelPOSVEL.Text = "Relative Position, Velocity";
            // 
            // tBoxXRel
            // 
            this.tBoxXRel.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxXRel.Location = new System.Drawing.Point(148, 49);
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
            this.labelXRel.Location = new System.Drawing.Point(123, 56);
            this.labelXRel.Name = "labelXRel";
            this.labelXRel.Size = new System.Drawing.Size(20, 19);
            this.labelXRel.TabIndex = 4;
            this.labelXRel.Text = "X";
            // 
            // labelM6
            // 
            this.labelM6.AutoSize = true;
            this.labelM6.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelM6.Location = new System.Drawing.Point(614, 164);
            this.labelM6.Name = "labelM6";
            this.labelM6.Size = new System.Drawing.Size(60, 19);
            this.labelM6.TabIndex = 21;
            this.labelM6.Text = "m/sec";
            // 
            // labelYRel
            // 
            this.labelYRel.AutoSize = true;
            this.labelYRel.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelYRel.Location = new System.Drawing.Point(123, 112);
            this.labelYRel.Name = "labelYRel";
            this.labelYRel.Size = new System.Drawing.Size(20, 19);
            this.labelYRel.TabIndex = 6;
            this.labelYRel.Text = "Y";
            // 
            // labelM5
            // 
            this.labelM5.AutoSize = true;
            this.labelM5.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelM5.Location = new System.Drawing.Point(615, 112);
            this.labelM5.Name = "labelM5";
            this.labelM5.Size = new System.Drawing.Size(60, 19);
            this.labelM5.TabIndex = 20;
            this.labelM5.Text = "m/sec";
            // 
            // tBoxYRel
            // 
            this.tBoxYRel.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxYRel.Location = new System.Drawing.Point(149, 105);
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
            this.labelM4.Location = new System.Drawing.Point(613, 56);
            this.labelM4.Name = "labelM4";
            this.labelM4.Size = new System.Drawing.Size(60, 19);
            this.labelM4.TabIndex = 19;
            this.labelM4.Text = "m/sec";
            // 
            // labelZRel
            // 
            this.labelZRel.AutoSize = true;
            this.labelZRel.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelZRel.Location = new System.Drawing.Point(123, 164);
            this.labelZRel.Name = "labelZRel";
            this.labelZRel.Size = new System.Drawing.Size(20, 19);
            this.labelZRel.TabIndex = 8;
            this.labelZRel.Text = "Z";
            // 
            // labelM3
            // 
            this.labelM3.AutoSize = true;
            this.labelM3.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelM3.Location = new System.Drawing.Point(274, 162);
            this.labelM3.Name = "labelM3";
            this.labelM3.Size = new System.Drawing.Size(24, 19);
            this.labelM3.TabIndex = 18;
            this.labelM3.Text = "m";
            // 
            // tBoxZRel
            // 
            this.tBoxZRel.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxZRel.Location = new System.Drawing.Point(149, 157);
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
            this.labelM2.Location = new System.Drawing.Point(274, 109);
            this.labelM2.Name = "labelM2";
            this.labelM2.Size = new System.Drawing.Size(24, 19);
            this.labelM2.TabIndex = 17;
            this.labelM2.Text = "m";
            // 
            // labelXvelRel
            // 
            this.labelXvelRel.AutoSize = true;
            this.labelXvelRel.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelXvelRel.Location = new System.Drawing.Point(394, 56);
            this.labelXvelRel.Name = "labelXvelRel";
            this.labelXvelRel.Size = new System.Drawing.Size(88, 19);
            this.labelXvelRel.TabIndex = 10;
            this.labelXvelRel.Text = "X Velocity";
            // 
            // labelM1
            // 
            this.labelM1.AutoSize = true;
            this.labelM1.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelM1.Location = new System.Drawing.Point(273, 54);
            this.labelM1.Name = "labelM1";
            this.labelM1.Size = new System.Drawing.Size(24, 19);
            this.labelM1.TabIndex = 16;
            this.labelM1.Text = "m";
            // 
            // tBoxXvelRel
            // 
            this.tBoxXvelRel.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxXvelRel.Location = new System.Drawing.Point(489, 49);
            this.tBoxXvelRel.Name = "tBoxXvelRel";
            this.tBoxXvelRel.Size = new System.Drawing.Size(119, 29);
            this.tBoxXvelRel.TabIndex = 11;
            this.tBoxXvelRel.Text = "0";
            this.tBoxXvelRel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tBoxZvelRel
            // 
            this.tBoxZvelRel.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxZvelRel.Location = new System.Drawing.Point(489, 157);
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
            this.labelYVelRel.Location = new System.Drawing.Point(394, 112);
            this.labelYVelRel.Name = "labelYVelRel";
            this.labelYVelRel.Size = new System.Drawing.Size(88, 19);
            this.labelYVelRel.TabIndex = 12;
            this.labelYVelRel.Text = "Y Velocity";
            // 
            // labelZVelRel
            // 
            this.labelZVelRel.AutoSize = true;
            this.labelZVelRel.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelZVelRel.Location = new System.Drawing.Point(394, 164);
            this.labelZVelRel.Name = "labelZVelRel";
            this.labelZVelRel.Size = new System.Drawing.Size(88, 19);
            this.labelZVelRel.TabIndex = 14;
            this.labelZVelRel.Text = "Z Velocity";
            // 
            // tBoxYvelRel
            // 
            this.tBoxYvelRel.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxYvelRel.Location = new System.Drawing.Point(489, 105);
            this.tBoxYvelRel.Name = "tBoxYvelRel";
            this.tBoxYvelRel.Size = new System.Drawing.Size(119, 29);
            this.tBoxYvelRel.TabIndex = 13;
            this.tBoxYvelRel.Text = "0";
            this.tBoxYvelRel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gBoxDisturbanceChaser
            // 
            this.gBoxDisturbanceChaser.Font = new System.Drawing.Font("맑은 고딕", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gBoxDisturbanceChaser.Location = new System.Drawing.Point(17, 324);
            this.gBoxDisturbanceChaser.Name = "gBoxDisturbanceChaser";
            this.gBoxDisturbanceChaser.Size = new System.Drawing.Size(779, 188);
            this.gBoxDisturbanceChaser.TabIndex = 22;
            this.gBoxDisturbanceChaser.TabStop = false;
            this.gBoxDisturbanceChaser.Text = "Disturbance";
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
            this.gBoxSimulation.ResumeLayout(false);
            this.gBoxChaser.ResumeLayout(false);
            this.gBoxChaser.PerformLayout();
            this.gBoxRelPOSVEL.ResumeLayout(false);
            this.gBoxRelPOSVEL.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_a;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_e;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_i;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_RAAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_w;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_TA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Epoch;
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
    }
}