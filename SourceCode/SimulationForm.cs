using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MLApp;
using System.Runtime.InteropServices;

namespace RVD_Simulation
{
    public partial class SimulationForm : Form
    {
        MLApp.MLApp matlab; // matlab 연동 객체

        [DllImport("user32.dll")]  // user32.dll methods
        public static extern IntPtr FindWindow(String lpClassName, String lpWindowName); // 윈도우 찾아서 불러오는 함수
        [DllImport("user32.dll")] // user32.dll methods
        public static extern IntPtr SetParent(IntPtr child, IntPtr newParent); // 윈도우의 부모를 지정,변경하는 함수

        public SimulationForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            matlab = new MLApp.MLApp(); // 매트랩 객체 생성
            //matlab.Visible = 0; // Invisible  ( 나중에 주석 풀어야함)
            matlab.Execute("t = 0:1:100;  y = zeros(1,101); fig = figure(); plot(t, y);");
        }
        
        public void Simulation(double angleVel, DateTime start, DateTime end, double maxTime)
        {
            dateTimePicker_Start.Value = start;
            dateTimePicker_End.Value = end;

                       
           // 매트랩 객체 
            IntPtr hFigure;          
            hFigure = FindWindow(null, "Figure 1");


            if (hFigure != IntPtr.Zero)
            {
                SetParent(hFigure, pictureBoxSimul.Handle);
                matlab.Execute("fig.WindowState = 'maximized';");
                tBox_TESTMAIN.Text = "완료";
            }
            else
            {
                MessageBox.Show("매트랩을 찾을 수 없습니다.");
            }                   
        }

        private void SimulationForm_FormClosing(object sender, FormClosingEventArgs e) // close 키 클릭시
        {         
            //MessageBox.Show("종료하시겠습니까?");
        }       
    }
}
