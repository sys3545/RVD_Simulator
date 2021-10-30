
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
            this.gBoxAddSAT = new System.Windows.Forms.GroupBox();
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
            this.gBoxDisturbance = new System.Windows.Forms.GroupBox();
            this.gBoxSimulation = new System.Windows.Forms.GroupBox();
            this.gBoxTime2 = new System.Windows.Forms.GroupBox();
            this.labelEnd2 = new System.Windows.Forms.Label();
            this.labelStart2 = new System.Windows.Forms.Label();
            this.dateTimePicker_End2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Start2 = new System.Windows.Forms.DateTimePicker();
            this.labelUTC4 = new System.Windows.Forms.Label();
            this.labelUTC3 = new System.Windows.Forms.Label();
            this.gBoxList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SAT)).BeginInit();
            this.gBoxAddSAT.SuspendLayout();
            this.gBoxPosVel.SuspendLayout();
            this.gBoxSimulation.SuspendLayout();
            this.gBoxTime2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxList
            // 
            this.gBoxList.Controls.Add(this.dataGridView_SAT);
            this.gBoxList.Font = new System.Drawing.Font("맑은 고딕", 22.26804F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gBoxList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gBoxList.Location = new System.Drawing.Point(816, 23);
            this.gBoxList.Name = "gBoxList";
            this.gBoxList.Size = new System.Drawing.Size(856, 236);
            this.gBoxList.TabIndex = 0;
            this.gBoxList.TabStop = false;
            this.gBoxList.Text = "Satellite List";
            // 
            // dataGridView_SAT
            // 
            this.dataGridView_SAT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SAT.Location = new System.Drawing.Point(21, 46);
            this.dataGridView_SAT.Name = "dataGridView_SAT";
            this.dataGridView_SAT.RowTemplate.Height = 25;
            this.dataGridView_SAT.Size = new System.Drawing.Size(814, 173);
            this.dataGridView_SAT.TabIndex = 0;
            // 
            // gBoxAddSAT
            // 
            this.gBoxAddSAT.Controls.Add(this.tBoxName);
            this.gBoxAddSAT.Controls.Add(this.labelName);
            this.gBoxAddSAT.Controls.Add(this.gBoxPosVel);
            this.gBoxAddSAT.Controls.Add(this.tBoxTest);
            this.gBoxAddSAT.Controls.Add(this.btnModify);
            this.gBoxAddSAT.Controls.Add(this.btnDelete);
            this.gBoxAddSAT.Controls.Add(this.btnAdd);
            this.gBoxAddSAT.Controls.Add(this.gBoxDisturbance);
            this.gBoxAddSAT.Font = new System.Drawing.Font("맑은 고딕", 22.26804F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gBoxAddSAT.Location = new System.Drawing.Point(21, 23);
            this.gBoxAddSAT.Name = "gBoxAddSAT";
            this.gBoxAddSAT.Size = new System.Drawing.Size(772, 789);
            this.gBoxAddSAT.TabIndex = 1;
            this.gBoxAddSAT.TabStop = false;
            this.gBoxAddSAT.Text = "Target Satellite Management";
            // 
            // tBoxName
            // 
            this.tBoxName.Font = new System.Drawing.Font("맑은 고딕", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxName.Location = new System.Drawing.Point(109, 112);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(119, 33);
            this.tBoxName.TabIndex = 25;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(49, 119);
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
            this.gBoxPosVel.Location = new System.Drawing.Point(390, 80);
            this.gBoxPosVel.Name = "gBoxPosVel";
            this.gBoxPosVel.Size = new System.Drawing.Size(360, 384);
            this.gBoxPosVel.TabIndex = 23;
            this.gBoxPosVel.TabStop = false;
            this.gBoxPosVel.Text = "Position, Velocity";
            // 
            // labelKM6
            // 
            this.labelKM6.AutoSize = true;
            this.labelKM6.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKM6.Location = new System.Drawing.Point(259, 329);
            this.labelKM6.Name = "labelKM6";
            this.labelKM6.Size = new System.Drawing.Size(69, 19);
            this.labelKM6.TabIndex = 21;
            this.labelKM6.Text = "km/sec";
            // 
            // labelKM5
            // 
            this.labelKM5.AutoSize = true;
            this.labelKM5.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKM5.Location = new System.Drawing.Point(259, 276);
            this.labelKM5.Name = "labelKM5";
            this.labelKM5.Size = new System.Drawing.Size(69, 19);
            this.labelKM5.TabIndex = 20;
            this.labelKM5.Text = "km/sec";
            // 
            // labelKM4
            // 
            this.labelKM4.AutoSize = true;
            this.labelKM4.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKM4.Location = new System.Drawing.Point(258, 222);
            this.labelKM4.Name = "labelKM4";
            this.labelKM4.Size = new System.Drawing.Size(69, 19);
            this.labelKM4.TabIndex = 19;
            this.labelKM4.Text = "km/sec";
            // 
            // labelKM3
            // 
            this.labelKM3.AutoSize = true;
            this.labelKM3.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKM3.Location = new System.Drawing.Point(259, 168);
            this.labelKM3.Name = "labelKM3";
            this.labelKM3.Size = new System.Drawing.Size(33, 19);
            this.labelKM3.TabIndex = 18;
            this.labelKM3.Text = "km";
            // 
            // labelKM2
            // 
            this.labelKM2.AutoSize = true;
            this.labelKM2.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKM2.Location = new System.Drawing.Point(259, 116);
            this.labelKM2.Name = "labelKM2";
            this.labelKM2.Size = new System.Drawing.Size(33, 19);
            this.labelKM2.TabIndex = 17;
            this.labelKM2.Text = "km";
            // 
            // labelKM1
            // 
            this.labelKM1.AutoSize = true;
            this.labelKM1.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKM1.Location = new System.Drawing.Point(258, 60);
            this.labelKM1.Name = "labelKM1";
            this.labelKM1.Size = new System.Drawing.Size(33, 19);
            this.labelKM1.TabIndex = 16;
            this.labelKM1.Text = "km";
            // 
            // tBoxZvel
            // 
            this.tBoxZvel.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxZvel.Location = new System.Drawing.Point(134, 322);
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
            this.labelZvel.Location = new System.Drawing.Point(39, 329);
            this.labelZvel.Name = "labelZvel";
            this.labelZvel.Size = new System.Drawing.Size(88, 19);
            this.labelZvel.TabIndex = 14;
            this.labelZvel.Text = "Z Velocity";
            // 
            // tBoxYvel
            // 
            this.tBoxYvel.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxYvel.Location = new System.Drawing.Point(133, 269);
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
            this.labelYvel.Location = new System.Drawing.Point(38, 276);
            this.labelYvel.Name = "labelYvel";
            this.labelYvel.Size = new System.Drawing.Size(88, 19);
            this.labelYvel.TabIndex = 12;
            this.labelYvel.Text = "Y Velocity";
            // 
            // tBoxXvel
            // 
            this.tBoxXvel.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxXvel.Location = new System.Drawing.Point(134, 215);
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
            this.labelXvel.Location = new System.Drawing.Point(39, 222);
            this.labelXvel.Name = "labelXvel";
            this.labelXvel.Size = new System.Drawing.Size(88, 19);
            this.labelXvel.TabIndex = 10;
            this.labelXvel.Text = "X Velocity";
            // 
            // tBoxZ
            // 
            this.tBoxZ.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxZ.Location = new System.Drawing.Point(134, 161);
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
            this.labelZ.Location = new System.Drawing.Point(108, 168);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(20, 19);
            this.labelZ.TabIndex = 8;
            this.labelZ.Text = "Z";
            // 
            // tBoxY
            // 
            this.tBoxY.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxY.Location = new System.Drawing.Point(134, 109);
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
            this.labelY.Location = new System.Drawing.Point(108, 116);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(20, 19);
            this.labelY.TabIndex = 6;
            this.labelY.Text = "Y";
            // 
            // tBoxX
            // 
            this.tBoxX.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxX.Location = new System.Drawing.Point(133, 53);
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
            this.labelX.Location = new System.Drawing.Point(108, 60);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(20, 19);
            this.labelX.TabIndex = 4;
            this.labelX.Text = "X";
            // 
            // tBoxTest
            // 
            this.tBoxTest.Font = new System.Drawing.Font("맑은 고딕", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxTest.Location = new System.Drawing.Point(120, 743);
            this.tBoxTest.Name = "tBoxTest";
            this.tBoxTest.Size = new System.Drawing.Size(236, 33);
            this.tBoxTest.TabIndex = 22;
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("맑은 고딕", 11.87629F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModify.Location = new System.Drawing.Point(523, 740);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(104, 38);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("맑은 고딕", 11.87629F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(646, 740);
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
            this.btnAdd.Location = new System.Drawing.Point(399, 740);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 38);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gBoxDisturbance
            // 
            this.gBoxDisturbance.Font = new System.Drawing.Font("맑은 고딕", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gBoxDisturbance.Location = new System.Drawing.Point(25, 502);
            this.gBoxDisturbance.Name = "gBoxDisturbance";
            this.gBoxDisturbance.Size = new System.Drawing.Size(725, 222);
            this.gBoxDisturbance.TabIndex = 0;
            this.gBoxDisturbance.TabStop = false;
            this.gBoxDisturbance.Text = "Disturbance";
            // 
            // gBoxSimulation
            // 
            this.gBoxSimulation.Controls.Add(this.gBoxTime2);
            this.gBoxSimulation.Font = new System.Drawing.Font("맑은 고딕", 22.26804F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gBoxSimulation.Location = new System.Drawing.Point(816, 279);
            this.gBoxSimulation.Name = "gBoxSimulation";
            this.gBoxSimulation.Size = new System.Drawing.Size(855, 533);
            this.gBoxSimulation.TabIndex = 2;
            this.gBoxSimulation.TabStop = false;
            this.gBoxSimulation.Text = "Simulation";
            // 
            // gBoxTime2
            // 
            this.gBoxTime2.Controls.Add(this.labelEnd2);
            this.gBoxTime2.Controls.Add(this.labelStart2);
            this.gBoxTime2.Controls.Add(this.dateTimePicker_End2);
            this.gBoxTime2.Controls.Add(this.dateTimePicker_Start2);
            this.gBoxTime2.Controls.Add(this.labelUTC4);
            this.gBoxTime2.Controls.Add(this.labelUTC3);
            this.gBoxTime2.Font = new System.Drawing.Font("맑은 고딕", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gBoxTime2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gBoxTime2.Location = new System.Drawing.Point(21, 46);
            this.gBoxTime2.Name = "gBoxTime2";
            this.gBoxTime2.Size = new System.Drawing.Size(486, 162);
            this.gBoxTime2.TabIndex = 6;
            this.gBoxTime2.TabStop = false;
            this.gBoxTime2.Text = "Time Setting";
            // 
            // labelEnd2
            // 
            this.labelEnd2.AutoSize = true;
            this.labelEnd2.Font = new System.Drawing.Font("돋움", 16.3299F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEnd2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEnd2.Location = new System.Drawing.Point(28, 113);
            this.labelEnd2.Name = "labelEnd2";
            this.labelEnd2.Size = new System.Drawing.Size(95, 23);
            this.labelEnd2.TabIndex = 5;
            this.labelEnd2.Text = "End Time";
            // 
            // labelStart2
            // 
            this.labelStart2.AutoSize = true;
            this.labelStart2.Font = new System.Drawing.Font("돋움", 16.3299F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStart2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelStart2.Location = new System.Drawing.Point(22, 57);
            this.labelStart2.Name = "labelStart2";
            this.labelStart2.Size = new System.Drawing.Size(103, 23);
            this.labelStart2.TabIndex = 4;
            this.labelStart2.Text = "Start Time";
            // 
            // dateTimePicker_End2
            // 
            this.dateTimePicker_End2.CalendarFont = new System.Drawing.Font("돋움", 17.81443F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_End2.CustomFormat = " yyy/MM/dd HH:mm:ss";
            this.dateTimePicker_End2.Enabled = false;
            this.dateTimePicker_End2.Font = new System.Drawing.Font("돋움", 16.3299F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_End2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_End2.Location = new System.Drawing.Point(134, 107);
            this.dateTimePicker_End2.Name = "dateTimePicker_End2";
            this.dateTimePicker_End2.Size = new System.Drawing.Size(281, 33);
            this.dateTimePicker_End2.TabIndex = 3;
            // 
            // dateTimePicker_Start2
            // 
            this.dateTimePicker_Start2.CalendarFont = new System.Drawing.Font("돋움", 17.81443F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_Start2.CustomFormat = " yyy/MM/dd HH:mm:ss";
            this.dateTimePicker_Start2.Enabled = false;
            this.dateTimePicker_Start2.Font = new System.Drawing.Font("돋움", 16.3299F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_Start2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Start2.Location = new System.Drawing.Point(134, 51);
            this.dateTimePicker_Start2.Name = "dateTimePicker_Start2";
            this.dateTimePicker_Start2.Size = new System.Drawing.Size(281, 33);
            this.dateTimePicker_Start2.TabIndex = 2;
            // 
            // labelUTC4
            // 
            this.labelUTC4.AutoSize = true;
            this.labelUTC4.Font = new System.Drawing.Font("돋움", 16.3299F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUTC4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelUTC4.Location = new System.Drawing.Point(424, 114);
            this.labelUTC4.Name = "labelUTC4";
            this.labelUTC4.Size = new System.Drawing.Size(49, 23);
            this.labelUTC4.TabIndex = 1;
            this.labelUTC4.Text = "UTC";
            // 
            // labelUTC3
            // 
            this.labelUTC3.AutoSize = true;
            this.labelUTC3.Font = new System.Drawing.Font("돋움", 16.3299F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUTC3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelUTC3.Location = new System.Drawing.Point(424, 57);
            this.labelUTC3.Name = "labelUTC3";
            this.labelUTC3.Size = new System.Drawing.Size(49, 23);
            this.labelUTC3.TabIndex = 0;
            this.labelUTC3.Text = "UTC";
            // 
            // SatelliteDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 850);
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
            this.gBoxTime2.ResumeLayout(false);
            this.gBoxTime2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxList;
        private System.Windows.Forms.GroupBox gBoxAddSAT;
        private System.Windows.Forms.GroupBox gBoxDisturbance;
        private System.Windows.Forms.GroupBox gBoxSimulation;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.DataGridView dataGridView_SAT;
        private System.Windows.Forms.GroupBox gBoxTime2;
        private System.Windows.Forms.Label labelEnd2;
        private System.Windows.Forms.Label labelStart2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_End2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Start2;
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
    }
}