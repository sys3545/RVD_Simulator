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
        ManeuverList[] maneuverList; // 기동정보 리스트
        int NumOfMane; // 기동 횟수
        const int maxNum = 5;
        double x0; double y0; double z0; double vx0; double vy0; double vz0; double angleVel; int maxTime; // 초기 정보
        double[] xArray; double[] yArray; double[] zArray; // 위치 계산 결과

        [DllImport("user32.dll")]  // user32.dll methods
        public static extern IntPtr FindWindow(String lpClassName, String lpWindowName); // 윈도우 찾아서 불러오는 함수
        [DllImport("user32.dll")] // user32.dll methods
        public static extern IntPtr SetParent(IntPtr child, IntPtr newParent); // 윈도우의 부모를 지정,변경하는 함수

        
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
            
            // data save
            dateTimePicker_Start.Value = start;
            dateTimePicker_End.Value = end;
            this.x0 = x0; this.y0 = y0; this.z0 = z0; this.vx0 = vx0; this.vy0 = vy0; this.vz0 = vz0; this.angleVel = angleVel; this.maxTime = (int)maxTime;

            // track bar
            trackBarTime.Maximum = Convert.ToInt32(maxTime);

            //// matlab ////           
            matlab.Execute(@"cd C:\Users\sys35\source\repos\RVD_Simulation\RVD_Simulation"); // 매트랩 함수 있는 폴더로 이동
            object result = null;
            matlab.Feval("EquOfMotion", 1, out result, x0, y0, z0, vx0, vy0, vz0, angleVel, maxTime); // 운동방정식 계산
            object[] Res = result as object[]; // 결과 임시저장
            xArray = new double[this.maxTime];
            yArray = new double[this.maxTime];
            zArray = new double[this.maxTime];
            for (int i = 0; i < maxTime; i++) // save the result of matlab function
            {
                xArray[i] = (Res[0] as double[,])[0, i];
                yArray[i] = (Res[0] as double[,])[1, i];
                zArray[i] = (Res[0] as double[,])[2, i];
            }

            // maneuver processing
            this.maneuverList = maneuverList;
            this.NumOfMane = NumOfMane;
            if(this.NumOfMane > 0)
                ProcessingManeuver(xArray, yArray, zArray, NumOfMane, maneuverList);

            tBox_TESTMAIN.Text = Convert.ToString(zArray[this.maxTime-1]);

            ExcuteNum++; // 실행횟수 증가
        }

        public void ProcessingManeuver(double[] x, double[] y, double[] z, int count, ManeuverList[] maneuverList)
        {
            for(int i=1; i<=count; i++)
            {
                
            }
        }

        // close button click event
        private void SimulationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("종료하시겠습니까?");
            matlab.Execute("exit");
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

        private void btnTestMain_Click(object sender, EventArgs e)
        {
           // object x = matlab.GetVariable("result", "base");
            //tBox_TESTMAIN.Text = Convert.ToString(x);
        }
    }
}
