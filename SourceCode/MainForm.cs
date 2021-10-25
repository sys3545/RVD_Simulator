using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RVD_Simulation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SatelliteDataForm SatelliteForm = new SatelliteDataForm(); // '인공위성 생성 폼' 생성
            SatelliteForm.Show(); // '인공위성 생성 폼' 디스플레이
        }


    }
}
