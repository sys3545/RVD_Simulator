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
using System.Threading;

namespace RVD_Simulation
{
    public partial class SimulationForm : Form
    {
        MLApp.MLApp matlab; // matlab 연동 객체
        private int ExcuteNum; // 시뮬레이션 실행횟수

        [DllImport("user32.dll")]  // user32.dll methods
        public static extern IntPtr FindWindow(String lpClassName, String lpWindowName); // 윈도우 찾아서 불러오는 함수
        [DllImport("user32.dll")] // user32.dll methods
        public static extern IntPtr SetParent(IntPtr child, IntPtr newParent); // 윈도우의 부모를 지정,변경하는 함수

        ManeuverList[] maneuverList;
        int NumOfMane;
        const int maxNum = 5;
        double x0; double y0; double z0; double vx0; double vy0; double vz0; double angleVel;  double maxTime;

        public SimulationForm()
        {
            InitializeComponent();
            ExcuteNum = 0;
            CreateManeuverArray(maxNum);
        }

        void CreateManeuverArray(int max)
        {
            maneuverList = new ManeuverList[max];

            for (int i = 0; i < max; i++)
                maneuverList[i] = new ManeuverList();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            matlab = new MLApp.MLApp(); // 매트랩 객체 생성
            //matlab.Visible = 0; // Invisible  ( 나중에 주석 풀어야함)            
        }
        
        public void Simulation(double x0, double y0, double z0, double vx0, double vy0, double vz0, double angleVel, DateTime start, DateTime end, double maxTime, ManeuverList[] maneuverList, int NumOfMane)
        {
            // 최초 실행 시 윈도우 적용
            if (ExcuteNum == 0)
            {
                matlab.Execute("fig = figure(1);"); // Create figure window
                Thread.Sleep(2000);
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
            this.x0 = x0; this.y0 = y0; this.z0 = z0; this.vx0 = vx0; this.vy0 = vy0; this.vz0 = vz0; this.angleVel = angleVel; this.maxTime = maxTime;

            // track bar
            trackBarTime.Maximum = Convert.ToInt32(maxTime);

            // matlab           
            matlab.Execute(@"cd C:\Users\sys35\source\repos\RVD_Simulation\RVD_Simulation"); // 매트랩 함수 있는 폴더로 이동
            object result = null;
            matlab.Feval("EquOfMotion", 1, out result, x0, y0, z0, vx0, vy0, vz0, angleVel, maxTime);

            // maneuver processing
            this.maneuverList = maneuverList;
            this.NumOfMane = NumOfMane;

            ExcuteNum++; // 실행횟수 증가
            //tBox_TESTMAIN.Text = Convert.ToString(this.maneuverList[1].time);
            tBox_TESTMAIN.Text = Convert.ToString(this.NumOfMane);
        }

        // close button click event
        private void SimulationForm_FormClosing(object sender, FormClosingEventArgs e)
        {         
            //MessageBox.Show("종료하시겠습니까?");
        }

        // track bar 변경될 시
        private void trackBarTime_ValueChanged(object sender, EventArgs e)
        {
            int value = trackBarTime.Value;

            tBox_TESTMAIN.Text = Convert.ToString(value);
        }

        // Refresh button click event
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.ExcuteNum = 0;
            matlab.Execute("close(fig); fig = figure(1);");
            Thread.Sleep(2000);
            Simulation(x0, y0, z0, vx0, vy0, vz0, angleVel, dateTimePicker_Start.Value, dateTimePicker_End.Value, maxTime, maneuverList, NumOfMane);
            
        }
        // 2D View button click event
        private void btn2DView_Click(object sender, EventArgs e)
        {
            matlab.Execute("view(0,0)");
        }
        // 3D View button click event
        private void btn3DView_Click(object sender, EventArgs e)
        {
            matlab.Execute("view(45, 45)");
        }
    }
}
