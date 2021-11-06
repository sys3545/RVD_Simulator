using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RVD_Simulation
{
    public partial class ManeuverAddingForm : Form
    {
        public int mynum = 11;
        public ManeuverAddingForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK; // 다이얼로그 결과 Ok를 넘긴다.

            string[] maneuverInfo = { tBoxManeTime.Text, tBoxDelX.Text, tBoxDelY.Text, tBoxDelZ.Text }; // 값 저장

            SatelliteDataForm sateliiteDataForm = (SatelliteDataForm)Owner; // 부모폼 호출

            sateliiteDataForm.maneuverInfo = maneuverInfo; // 전달

            this.Close();
        }
    }
}
