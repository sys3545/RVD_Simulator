using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RVD_Simulation
{
    public partial class SatelliteDataForm : Form
    {
        public SatelliteDataForm() // SatelliteDataForm 생성자
        {
            InitializeComponent();

            SetInitialColumn();
        }

        void SetInitialColumn() // Satellite List의 컬럼 초기 설정
        {
            dataGridView_SAT.ColumnCount = 6; // 컬럼에 나타낼 데이터 수
            dataGridView_SAT.Columns[0].Name = "Name";
            dataGridView_SAT.Columns[1].Name = "a";
        }

    }
}
