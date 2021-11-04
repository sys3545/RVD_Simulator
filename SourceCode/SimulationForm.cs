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
        int ExcuteNum; // 시뮬레이션 실행횟수

        [DllImport("user32.dll")]  // user32.dll methods
        public static extern IntPtr FindWindow(String lpClassName, String lpWindowName); // 윈도우 찾아서 불러오는 함수
        [DllImport("user32.dll")] // user32.dll methods
        public static extern IntPtr SetParent(IntPtr child, IntPtr newParent); // 윈도우의 부모를 지정,변경하는 함수

        public SimulationForm()
        {
            InitializeComponent();
            ExcuteNum = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            matlab = new MLApp.MLApp(); // 매트랩 객체 생성
            //matlab.Visible = 0; // Invisible  ( 나중에 주석 풀어야함)
            matlab.Execute("t = 0:1:100;  y = zeros(1,101); fig = figure(); plot(t, y);");
        }
        
        public void Simulation(double x0, double y0, double z0, double vx0, double vy0, double vz0, double angleVel, DateTime start, DateTime end, double maxTime)
        {
            // 최초 실행 시 윈도우 적용
            if (ExcuteNum == 0)
            {
                // 매트랩 객체 
                IntPtr hFigure;
                hFigure = FindWindow(null, "Figure 1");


                if (hFigure != IntPtr.Zero)
                {
                    SetParent(hFigure, pictureBoxSimul.Handle);
                    matlab.Execute("set(fig, 'OuterPosition', [3,350,1000,700]);");                   
                    ExcuteNum++;
                }
                else
                {
                    MessageBox.Show("매트랩을 찾을 수 없습니다.");
                }
            }
            // simulation method
            dateTimePicker_Start.Value = start;
            dateTimePicker_End.Value = end;
            matlab.Execute(@"cd C:\Users\sys35\source\repos\RVD_Simulation\RVD_Simulation"); // 매트랩 함수 있는 폴더로 이동
            object result = null;
            matlab.Feval("EquOfMotion", 1, out result, x0, y0, z0, vx0, vy0, vz0, angleVel, maxTime);
            tBox_TESTMAIN.Text = Convert.ToString(maxTime);
        }

        private void SimulationForm_FormClosing(object sender, FormClosingEventArgs e) // close 키 클릭시
        {         
            //MessageBox.Show("종료하시겠습니까?");
        }       
    }
}
