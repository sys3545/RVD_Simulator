
namespace RVD_Simulation
{
    partial class SimulationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gboxTrajectory = new System.Windows.Forms.GroupBox();
            this.pictureBoxSimul = new System.Windows.Forms.PictureBox();
            this.gBoxTime = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.dateTimePicker_End = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.labelUTC2 = new System.Windows.Forms.Label();
            this.labelUTC1 = new System.Windows.Forms.Label();
            this.gBoxStatus = new System.Windows.Forms.GroupBox();
            this.tBox_TESTMAIN = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.gboxTrajectory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSimul)).BeginInit();
            this.gBoxTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.gBoxStatus.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxTrajectory
            // 
            this.gboxTrajectory.Controls.Add(this.pictureBoxSimul);
            this.gboxTrajectory.Font = new System.Drawing.Font("맑은 고딕", 22.26804F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gboxTrajectory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gboxTrajectory.Location = new System.Drawing.Point(12, 38);
            this.gboxTrajectory.Name = "gboxTrajectory";
            this.gboxTrajectory.Size = new System.Drawing.Size(1047, 800);
            this.gboxTrajectory.TabIndex = 0;
            this.gboxTrajectory.TabStop = false;
            this.gboxTrajectory.Text = "Trajectories";
            // 
            // pictureBoxSimul
            // 
            this.pictureBoxSimul.Location = new System.Drawing.Point(16, 46);
            this.pictureBoxSimul.Name = "pictureBoxSimul";
            this.pictureBoxSimul.Size = new System.Drawing.Size(1013, 737);
            this.pictureBoxSimul.TabIndex = 4;
            this.pictureBoxSimul.TabStop = false;
            // 
            // gBoxTime
            // 
            this.gBoxTime.Controls.Add(this.trackBar1);
            this.gBoxTime.Controls.Add(this.labelEnd);
            this.gBoxTime.Controls.Add(this.labelStart);
            this.gBoxTime.Controls.Add(this.dateTimePicker_End);
            this.gBoxTime.Controls.Add(this.dateTimePicker_Start);
            this.gBoxTime.Controls.Add(this.labelUTC2);
            this.gBoxTime.Controls.Add(this.labelUTC1);
            this.gBoxTime.Font = new System.Drawing.Font("맑은 고딕", 22.26804F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gBoxTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gBoxTime.Location = new System.Drawing.Point(1077, 38);
            this.gBoxTime.Name = "gBoxTime";
            this.gBoxTime.Size = new System.Drawing.Size(571, 224);
            this.gBoxTime.TabIndex = 1;
            this.gBoxTime.TabStop = false;
            this.gBoxTime.Text = "Time";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(50, 171);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(485, 45);
            this.trackBar1.TabIndex = 6;
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Font = new System.Drawing.Font("돋움", 16.3299F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEnd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEnd.Location = new System.Drawing.Point(68, 126);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(95, 23);
            this.labelEnd.TabIndex = 5;
            this.labelEnd.Text = "End Time";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("돋움", 16.3299F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelStart.Location = new System.Drawing.Point(62, 70);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(103, 23);
            this.labelStart.TabIndex = 4;
            this.labelStart.Text = "Start Time";
            // 
            // dateTimePicker_End
            // 
            this.dateTimePicker_End.CalendarFont = new System.Drawing.Font("돋움", 17.81443F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_End.CustomFormat = " yyy/MM/dd HH:mm:ss";
            this.dateTimePicker_End.Enabled = false;
            this.dateTimePicker_End.Font = new System.Drawing.Font("돋움", 16.3299F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_End.Location = new System.Drawing.Point(186, 119);
            this.dateTimePicker_End.Name = "dateTimePicker_End";
            this.dateTimePicker_End.Size = new System.Drawing.Size(281, 33);
            this.dateTimePicker_End.TabIndex = 3;
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.CalendarFont = new System.Drawing.Font("돋움", 16.3299F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_Start.CustomFormat = " yyy/MM/dd HH:mm:ss";
            this.dateTimePicker_Start.Enabled = false;
            this.dateTimePicker_Start.Font = new System.Drawing.Font("돋움", 16.3299F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Start.Location = new System.Drawing.Point(186, 63);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(281, 33);
            this.dateTimePicker_Start.TabIndex = 2;
            // 
            // labelUTC2
            // 
            this.labelUTC2.AutoSize = true;
            this.labelUTC2.Font = new System.Drawing.Font("돋움", 16.3299F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUTC2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelUTC2.Location = new System.Drawing.Point(476, 125);
            this.labelUTC2.Name = "labelUTC2";
            this.labelUTC2.Size = new System.Drawing.Size(49, 23);
            this.labelUTC2.TabIndex = 1;
            this.labelUTC2.Text = "UTC";
            // 
            // labelUTC1
            // 
            this.labelUTC1.AutoSize = true;
            this.labelUTC1.Font = new System.Drawing.Font("돋움", 16.3299F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUTC1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelUTC1.Location = new System.Drawing.Point(476, 69);
            this.labelUTC1.Name = "labelUTC1";
            this.labelUTC1.Size = new System.Drawing.Size(49, 23);
            this.labelUTC1.TabIndex = 0;
            this.labelUTC1.Text = "UTC";
            // 
            // gBoxStatus
            // 
            this.gBoxStatus.Controls.Add(this.tBox_TESTMAIN);
            this.gBoxStatus.Font = new System.Drawing.Font("맑은 고딕", 22.26804F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gBoxStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gBoxStatus.Location = new System.Drawing.Point(1077, 268);
            this.gBoxStatus.Name = "gBoxStatus";
            this.gBoxStatus.Size = new System.Drawing.Size(572, 570);
            this.gBoxStatus.TabIndex = 2;
            this.gBoxStatus.TabStop = false;
            this.gBoxStatus.Text = "Satellite Status";
            // 
            // tBox_TESTMAIN
            // 
            this.tBox_TESTMAIN.Font = new System.Drawing.Font("맑은 고딕", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBox_TESTMAIN.Location = new System.Drawing.Point(10, 526);
            this.tBox_TESTMAIN.Name = "tBox_TESTMAIN";
            this.tBox_TESTMAIN.Size = new System.Drawing.Size(183, 33);
            this.tBox_TESTMAIN.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("바탕", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1700, 27);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(50, 23);
            this.FileMenu.Text = "File";
            // 
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 850);
            this.Controls.Add(this.gBoxStatus);
            this.Controls.Add(this.gBoxTime);
            this.Controls.Add(this.gboxTrajectory);
            this.Controls.Add(this.menuStrip1);
            this.Name = "SimulationForm";
            this.Text = "RVD/Prox Simulation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SimulationForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gboxTrajectory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSimul)).EndInit();
            this.gBoxTime.ResumeLayout(false);
            this.gBoxTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.gBoxStatus.ResumeLayout(false);
            this.gBoxStatus.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxTrajectory;
        private System.Windows.Forms.GroupBox gBoxTime;
        private System.Windows.Forms.Label labelUTC1;
        private System.Windows.Forms.Label labelUTC2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Start;
        private System.Windows.Forms.DateTimePicker dateTimePicker_End;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.GroupBox gBoxStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.TextBox tBox_TESTMAIN;
        private System.Windows.Forms.PictureBox pictureBoxSimul;
    }
}

