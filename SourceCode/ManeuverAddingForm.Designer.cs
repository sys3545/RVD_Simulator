
namespace RVD_Simulation
{
    partial class ManeuverAddingForm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxDelZ = new System.Windows.Forms.TextBox();
            this.tBoxDelY = new System.Windows.Forms.TextBox();
            this.tBoxDelX = new System.Windows.Forms.TextBox();
            this.tBoxManeTime = new System.Windows.Forms.TextBox();
            this.lableburmTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tBoxDuration = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cBoxImpulse = new System.Windows.Forms.CheckBox();
            this.cBoxContinue = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("맑은 고딕", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOK.Location = new System.Drawing.Point(281, 384);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(95, 33);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(234, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "sec";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(234, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 32;
            this.label3.Text = "m/sec";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(234, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "m/sec";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(234, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "m/sec";
            // 
            // tBoxDelZ
            // 
            this.tBoxDelZ.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxDelZ.Location = new System.Drawing.Point(143, 266);
            this.tBoxDelZ.Name = "tBoxDelZ";
            this.tBoxDelZ.Size = new System.Drawing.Size(85, 29);
            this.tBoxDelZ.TabIndex = 29;
            this.tBoxDelZ.Text = "0";
            this.tBoxDelZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tBoxDelY
            // 
            this.tBoxDelY.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxDelY.Location = new System.Drawing.Point(143, 218);
            this.tBoxDelY.Name = "tBoxDelY";
            this.tBoxDelY.Size = new System.Drawing.Size(85, 29);
            this.tBoxDelY.TabIndex = 28;
            this.tBoxDelY.Text = "0";
            this.tBoxDelY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tBoxDelX
            // 
            this.tBoxDelX.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxDelX.Location = new System.Drawing.Point(143, 167);
            this.tBoxDelX.Name = "tBoxDelX";
            this.tBoxDelX.Size = new System.Drawing.Size(85, 29);
            this.tBoxDelX.TabIndex = 27;
            this.tBoxDelX.Text = "0";
            this.tBoxDelX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tBoxManeTime
            // 
            this.tBoxManeTime.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxManeTime.Location = new System.Drawing.Point(143, 115);
            this.tBoxManeTime.Name = "tBoxManeTime";
            this.tBoxManeTime.Size = new System.Drawing.Size(85, 29);
            this.tBoxManeTime.TabIndex = 26;
            this.tBoxManeTime.Text = "0";
            this.tBoxManeTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lableburmTime
            // 
            this.lableburmTime.AutoSize = true;
            this.lableburmTime.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lableburmTime.Location = new System.Drawing.Point(90, 118);
            this.lableburmTime.Name = "lableburmTime";
            this.lableburmTime.Size = new System.Drawing.Size(47, 19);
            this.lableburmTime.TabIndex = 34;
            this.lableburmTime.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(90, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 35;
            this.label5.Text = "△Vx";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(90, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 36;
            this.label6.Text = "△Vy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(90, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 19);
            this.label7.TabIndex = 37;
            this.label7.Text = "△Vz";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(65, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 19);
            this.label8.TabIndex = 38;
            this.label8.Text = "Duration";
            // 
            // tBoxDuration
            // 
            this.tBoxDuration.Enabled = false;
            this.tBoxDuration.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxDuration.Location = new System.Drawing.Point(143, 314);
            this.tBoxDuration.Name = "tBoxDuration";
            this.tBoxDuration.Size = new System.Drawing.Size(85, 29);
            this.tBoxDuration.TabIndex = 39;
            this.tBoxDuration.Text = "0";
            this.tBoxDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("돋움", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(234, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 19);
            this.label9.TabIndex = 40;
            this.label9.Text = "sec";
            // 
            // cBoxImpulse
            // 
            this.cBoxImpulse.AutoSize = true;
            this.cBoxImpulse.Checked = true;
            this.cBoxImpulse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBoxImpulse.Font = new System.Drawing.Font("맑은 고딕", 11.13402F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cBoxImpulse.Location = new System.Drawing.Point(72, 50);
            this.cBoxImpulse.Name = "cBoxImpulse";
            this.cBoxImpulse.Size = new System.Drawing.Size(92, 24);
            this.cBoxImpulse.TabIndex = 41;
            this.cBoxImpulse.Text = "Impulsive";
            this.cBoxImpulse.UseVisualStyleBackColor = true;
            this.cBoxImpulse.CheckedChanged += new System.EventHandler(this.cBoxImpulse_CheckedChanged);
            // 
            // cBoxContinue
            // 
            this.cBoxContinue.AutoSize = true;
            this.cBoxContinue.Font = new System.Drawing.Font("맑은 고딕", 11.13402F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cBoxContinue.Location = new System.Drawing.Point(209, 50);
            this.cBoxContinue.Name = "cBoxContinue";
            this.cBoxContinue.Size = new System.Drawing.Size(107, 24);
            this.cBoxContinue.TabIndex = 42;
            this.cBoxContinue.Text = "Continuous";
            this.cBoxContinue.UseVisualStyleBackColor = true;
            this.cBoxContinue.CheckedChanged += new System.EventHandler(this.cBoxContinue_CheckedChanged);
            // 
            // ManeuverAddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 429);
            this.Controls.Add(this.cBoxContinue);
            this.Controls.Add(this.cBoxImpulse);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tBoxDuration);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lableburmTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBoxDelZ);
            this.Controls.Add(this.tBoxDelY);
            this.Controls.Add(this.tBoxDelX);
            this.Controls.Add(this.tBoxManeTime);
            this.Controls.Add(this.btnOK);
            this.Name = "ManeuverAddingForm";
            this.Text = "ManeuverAdding";
            this.Load += new System.EventHandler(this.ManeuverAddingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxDelZ;
        private System.Windows.Forms.TextBox tBoxDelY;
        private System.Windows.Forms.TextBox tBoxDelX;
        private System.Windows.Forms.TextBox tBoxManeTime;
        private System.Windows.Forms.Label lableburmTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tBoxDuration;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cBoxImpulse;
        private System.Windows.Forms.CheckBox cBoxContinue;
    }
}