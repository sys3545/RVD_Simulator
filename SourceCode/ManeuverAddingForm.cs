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
        public int type;
        public ManeuverAddingForm()
        {
            InitializeComponent();
            this.type = 1;
        }


        private void ManeuverAddingForm_Load(object sender, EventArgs e) // 폼 생성
        {

        }

        private void btnOK_Click(object sender, EventArgs e)  // OK 버튼
        {
            DialogResult = DialogResult.OK; // 다이얼로그 결과 Ok를 넘긴다.

            if (cBoxContinue.Checked) this.type = 2; // 1이 impulse 2가 continue

            string[] maneuverInfo = { tBoxManeTime.Text, tBoxDelX.Text, tBoxDelY.Text, tBoxDelZ.Text, tBoxDuration.Text, Convert.ToString(type)}; // 값 저장

            SatelliteDataForm sateliiteDataForm = (SatelliteDataForm)Owner; // 부모폼 호출

            sateliiteDataForm.maneuverInfo = maneuverInfo; // 전달

            this.Close();
        }

        private void cBoxImpulse_CheckedChanged(object sender, EventArgs e) // impulse 체크 변경
        {
            if(cBoxImpulse.Checked) // 체크가 된 상태
            {
                if (cBoxContinue.Checked) cBoxContinue.Checked = false; // 컨티뉴 번 체크 끄기
                tBoxDuration.Enabled = false; // 듀레이션 끄기
            }
        }

        private void cBoxContinue_CheckedChanged(object sender, EventArgs e)
        {
            if(cBoxContinue.Checked)
            {
                if (cBoxImpulse.Checked) cBoxImpulse.Checked = false;
                tBoxDuration.Enabled = true;
            }
        }
    }
}
