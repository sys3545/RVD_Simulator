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
        int NumOfMane = 0; // 기동 횟수
        const int maxNum = 5; // 최대 기동 횟수
        double x0; double y0; double z0; double vx0; double vy0; double vz0; double angleVel; double maxTime; // 초기 정보
        object result = null; // 매트랩 결과저장 변수
        object[] Res = null; // 매트랩 결과저장 변수

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

        void CreateManeuverArray(int max)  // 기동 정보 배열 초기화
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
            dateTimePicker_Start.Value = start;    dateTimePicker_End.Value = end;
            this.x0 = x0; this.y0 = y0; this.z0 = z0; this.vx0 = vx0; this.vy0 = vy0; this.vz0 = vz0; this.angleVel = angleVel; this.maxTime = maxTime;
            this.NumOfMane = NumOfMane;
            // track bar
            trackBarTime.Maximum = Convert.ToInt32(maxTime);

            ////////////////////////////////////////////////////// matlab /////////////////////////////////////////////////////////////      
            matlab.Execute(@"cd C:\Users\sys35\source\repos\RVD_Simulation\RVD_Simulation"); // 매트랩 함수 있는 폴더로 이동          
            for (int i = 0; i <= NumOfMane; i++)
            {
                result = null; //  **** 매우 중요  result를 매번 초기화 해주어야 계속 갱신할 수 있다. *****
                this.maneuverList[i] = maneuverList[i]; // 기동 정보 저장

                // 현재 xyz를 구할 시간범위 설정 , 초기값 설정
                double curStartTime;   double curEndTime;
                double[] initialValues = new double[6];
                if (i == 0)
                {
                    curStartTime = 0;
                    initialValues[0] = this.x0; initialValues[1] = this.y0; initialValues[2] = this.z0;
                    initialValues[3] = this.vx0; initialValues[4] = this.vy0; initialValues[5] = this.vz0;
                }
                else
                {
                    curStartTime = maneuverList[i].time;
                    initialValues = matlabGetXYZEnd();
                    // impulse burn  ( 나중에 여기서 burn type 처리할수도?)
                    initialValues[3] += maneuverList[i].dvx;
                    initialValues[4] += maneuverList[i].dvy;
                    initialValues[5] += maneuverList[i].dvz;
                }
                if (i == NumOfMane)
                    curEndTime = this.maxTime;
                else
                    curEndTime = maneuverList[i + 1].time;
                //simulation
                matlab.Feval("getXYZ", 1, out result, initialValues[0], initialValues[1], initialValues[2], initialValues[3], initialValues[4], initialValues[5], this.angleVel, curStartTime, curEndTime);
                Res = result as object[]; // c#에 매트랩 함수 결과 저장
                matlabTempDataSave(); // 함수 결과를 매트랩 워크스테이션에 저장
                matlabMakeFinalXYZ(i); // 최종 결과 만들기
            }
            matlabplot(); // 시뮬레이션 출력
        }

        public void matlabTempDataSave() // 함수 결과를 매트랩 워크스테이션에 저장
        {
            matlab.PutWorkspaceData("Res", "base", Res);
            matlab.Execute("result = cell2mat(Res);  xtemp = result(1,:);  ytemp = result(2,:); ztemp = result(3,:); vxtemp = result(4,:); vytemp = result(5,:); vztemp = result(6,:);");
        }

        public void matlabMakeFinalXYZ(int i) // 최종 XYZ 값을 만드는 함수
        {
            if (i == 0)
                matlab.Execute("x = xtemp; y = ytemp; z = ztemp; vx = vxtemp; vy = vytemp; vz = vztemp; ");
            else
                matlab.Execute("x = horzcat(x, xtemp); y = horzcat(y, ytemp); z = horzcat(z,ztemp); vx = horzcat(vx, vxtemp); vy = horzcat(vy, vytemp); vz = horzcat(vz,vztemp);"); 
        }

        public void matlabplot() // 결과를 plot 하는 함수
        {
            matlab.Execute("scatter3(0,0,0,100,'red','fill'); hold on; plot3(x(1,:), y(1,:), z(1,:), 'blue'); grid on; title('Rendezvous Simulation');");
            matlab.Execute("xlabel('V - bar (m)'); ylabel('H - bar (m)'); zlabel('R - bar (m)'); hold off; legend('Target Satellite','Chaser trajectory','Location','northwest'); h = gca; set(h,'YDir','reverse'); set(h,'ZDir','reverse');  set(h,'XDir','reverse'); ");
        }

        public double[] matlabGetXYZEnd() // 이전 기동에서 last값을 따옴( 다음 기동의 초기값으로 사용 )
        {
            double[] endvalues = new double[6];
            matlab.Execute("xlast = x(end); ylast = y(end); zlast = z(end); vxlast = vx(end); vylast = vy(end); vzlast = vz(end);");
            endvalues[0] = (double)matlab.GetVariable("xlast", "base");
            endvalues[1] = (double)matlab.GetVariable("ylast", "base");
            endvalues[2] = (double)matlab.GetVariable("zlast", "base");
            endvalues[3] = (double)matlab.GetVariable("vxlast", "base");
            endvalues[4] = (double)matlab.GetVariable("vylast", "base");
            endvalues[5] = (double)matlab.GetVariable("vzlast", "base");
            return endvalues;
        }

       
        ///////////////////////////////////////////////////// button event ////////////////////////////////////////////////////////////////
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
            result = null;
            matlab.Execute("close(fig); fig = figure(1);");
            Thread.Sleep(2000);
            Simulation(x0, y0, z0, vx0, vy0, vz0, angleVel, dateTimePicker_Start.Value, dateTimePicker_End.Value, maxTime, maneuverList, NumOfMane);
            tBox_TESTMAIN.Text = Convert.ToString("donerefresh");
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
            //matlab.PutWorkspaceData("x", "base", Res);
        }
    }
}
