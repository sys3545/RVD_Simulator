
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
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gBoxDisturbance = new System.Windows.Forms.GroupBox();
            this.gBoxSimulation = new System.Windows.Forms.GroupBox();
            this.gBoxList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SAT)).BeginInit();
            this.gBoxAddSAT.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxList
            // 
            this.gBoxList.Controls.Add(this.dataGridView_SAT);
            this.gBoxList.Font = new System.Drawing.Font("맑은 고딕", 22.26804F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gBoxList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gBoxList.Location = new System.Drawing.Point(689, 23);
            this.gBoxList.Name = "gBoxList";
            this.gBoxList.Size = new System.Drawing.Size(983, 373);
            this.gBoxList.TabIndex = 0;
            this.gBoxList.TabStop = false;
            this.gBoxList.Text = "Satellite List";
            // 
            // dataGridView_SAT
            // 
            this.dataGridView_SAT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SAT.Location = new System.Drawing.Point(19, 46);
            this.dataGridView_SAT.Name = "dataGridView_SAT";
            this.dataGridView_SAT.RowTemplate.Height = 25;
            this.dataGridView_SAT.Size = new System.Drawing.Size(942, 308);
            this.dataGridView_SAT.TabIndex = 0;
            // 
            // gBoxAddSAT
            // 
            this.gBoxAddSAT.Controls.Add(this.btnModify);
            this.gBoxAddSAT.Controls.Add(this.btnDelete);
            this.gBoxAddSAT.Controls.Add(this.btnAdd);
            this.gBoxAddSAT.Controls.Add(this.gBoxDisturbance);
            this.gBoxAddSAT.Font = new System.Drawing.Font("맑은 고딕", 22.26804F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gBoxAddSAT.Location = new System.Drawing.Point(21, 23);
            this.gBoxAddSAT.Name = "gBoxAddSAT";
            this.gBoxAddSAT.Size = new System.Drawing.Size(649, 789);
            this.gBoxAddSAT.TabIndex = 1;
            this.gBoxAddSAT.TabStop = false;
            this.gBoxAddSAT.Text = "Satellite Management";
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("맑은 고딕", 11.87629F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModify.Location = new System.Drawing.Point(403, 740);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(104, 38);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("맑은 고딕", 11.87629F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(521, 739);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 38);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("맑은 고딕", 11.87629F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(285, 740);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 38);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // gBoxDisturbance
            // 
            this.gBoxDisturbance.Font = new System.Drawing.Font("맑은 고딕", 16.3299F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gBoxDisturbance.Location = new System.Drawing.Point(25, 502);
            this.gBoxDisturbance.Name = "gBoxDisturbance";
            this.gBoxDisturbance.Size = new System.Drawing.Size(600, 222);
            this.gBoxDisturbance.TabIndex = 0;
            this.gBoxDisturbance.TabStop = false;
            this.gBoxDisturbance.Text = "Disturbance";
            // 
            // gBoxSimulation
            // 
            this.gBoxSimulation.Font = new System.Drawing.Font("맑은 고딕", 22.26804F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gBoxSimulation.Location = new System.Drawing.Point(689, 417);
            this.gBoxSimulation.Name = "gBoxSimulation";
            this.gBoxSimulation.Size = new System.Drawing.Size(982, 395);
            this.gBoxSimulation.TabIndex = 2;
            this.gBoxSimulation.TabStop = false;
            this.gBoxSimulation.Text = "Simulation";
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
    }
}