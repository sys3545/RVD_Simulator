﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Numerics;
using System.Runtime.InteropServices;

namespace RVD_Simulation
{
    /////////////////// 인공위성 데이터 폼 클래스//////////////////
    ///////////////////////////////////////////////////////////////
    public partial class SatelliteDataForm : Form 
    {
        int NumOfSat = 0; // Currnet number of satellites
        const int maxNum = 6; // The max number of satellites
        Satellite[] SAT; // Satellite 객체 배열 생성
        SimulationForm SimulationForm; // 시뮬레이션 폼 인스턴스


        public SatelliteDataForm() // SatelliteDataForm 생성자
        {
            InitializeComponent();

            // 시뮬레이션 폼 디스플레이
            SimulationForm = new SimulationForm();
            SimulationForm.Show();
            SetInitialColumn(); // Satellite List 폼 객체의 컬럼 초기 설정
            CreateSATArray(maxNum); // Satellite 객체 배열 생성
        }

        void CreateSATArray(int max) // Satellite 객체 배열 생성
        {
            SAT = new Satellite[max];

            for (int i = 0; i < max; i++)
                SAT[i] = new Satellite();
        }

        void SetInitialColumn() // Satellite List 폼 객체의 컬럼 초기 설정
        {
            dataGridView_SAT.ColumnCount = 9; // 컬럼에 나타낼 데이터 수
            dataGridView_SAT.ColumnHeadersDefaultCellStyle.Font = new Font("맑은 고딕", 14, FontStyle.Bold); // 컬럼헤더 폰트
            dataGridView_SAT.DefaultCellStyle.Font = new Font("맑은 고딕", 14); // 내용부분 폰트           
        }

        private void btnAdd_Click(object sender, EventArgs e) // 인공위성 생성버튼
        {
            if (this.NumOfSat < maxNum - 1)
            {
                this.NumOfSat += 1; //위성 갯수 증가

                SAT[NumOfSat].name = Convert.ToString(tBoxName.Text); // Name 저장
                SAT[NumOfSat].number = NumOfSat; // Number 저장
                SAT[NumOfSat].mass = Convert.ToDouble(tBoxMass.Text); // mass 저장
                SAT[NumOfSat].epoch = dateTimePicker_Epoch.Value; // epch time 저장

                SAT[NumOfSat].x = Convert.ToDouble(tBoxX.Text); // position, velocity 저장           
                SAT[NumOfSat].y = Convert.ToDouble(tBoxY.Text);
                SAT[NumOfSat].z = Convert.ToDouble(tBoxZ.Text);
                SAT[NumOfSat].xvel = Convert.ToDouble(tBoxXvel.Text);
                SAT[NumOfSat].yvel = Convert.ToDouble(tBoxYvel.Text);
                SAT[NumOfSat].zvel = Convert.ToDouble(tBoxZvel.Text);
              
                SAT[NumOfSat].makePosVector();
                SAT[NumOfSat].makeVelVector();
                Calculator.RV2COE(ref SAT[NumOfSat]); // cartesian to classical
                Calculator.FindPeriod(ref SAT[NumOfSat]); // calculate period, angular velocity

                // Satellite List에 추가
                string[] newOne = { Convert.ToString(SAT[NumOfSat].number), SAT[NumOfSat].name, Convert.ToString(SAT[NumOfSat].a),Convert.ToString(SAT[NumOfSat].e),
                Convert.ToString(SAT[NumOfSat].i), Convert.ToString(SAT[NumOfSat].RAAN), Convert.ToString(SAT[NumOfSat].w), Convert.ToString(SAT[NumOfSat].TA), Convert.ToString(SAT[NumOfSat].epoch)};
                dataGridView_SAT.Rows.Add(newOne);

                tBoxTest.Text = Convert.ToString(SAT[NumOfSat].period);  /////////////////////////////////////////////테스트 출력
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) // 인공위성 삭제버튼
        {
            if (this.NumOfSat > 0)
            {
                dataGridView_SAT.Rows.Remove(dataGridView_SAT.Rows[NumOfSat-1]); // 리스트에서 최근 위성 삭제
                this.NumOfSat -= 1; // 위성 갯수 감소               
            }
        }

        private void btnStart_Click(object sender, EventArgs e) // 시뮬레이션 시작버튼
        {
            double diff; // 시간차이
            int SelectNum; // 선택된 타겟번호
            double x0; double y0; double z0; double vx0; double vy0; double vz0;


            // 시간차이 구하기
            diff = Calculator.FindDiffTime(dateTimePicker_StartSimul.Value, dateTimePicker_EndSimul.Value);

            // 선택된 타겟 가져오기
            SelectNum = Convert.ToInt32(tBoxTgtNum.Text);

            // 초기 상대 값 가져오기
            x0 = Convert.ToDouble(tBoxXRel.Text);
            y0 = Convert.ToDouble(tBoxYRel.Text);
            z0 = Convert.ToDouble(tBoxZRel.Text);
            vx0 = Convert.ToDouble(tBoxXvelRel.Text);
            vy0 = Convert.ToDouble(tBoxYvelRel.Text);
            vz0 = Convert.ToDouble(tBoxZvelRel.Text);

            // 시뮬레이션 시작
            if (diff > 0)
            {
                SimulationForm.Simulation(x0, y0, z0, vx0, vy0, vz0, SAT[SelectNum].angleVel, dateTimePicker_StartSimul.Value, dateTimePicker_EndSimul.Value, diff);
            }
            else
            {
                MessageBox.Show("시뮬레이션 시간이 너무 짧습니다.");
            }
        }
    }


    /////////////////////// 인공위성 클래스 ///////////////////////
    ///////////////////////////////////////////////////////////////
    public partial class Satellite  
    {
        public string name; // 위성 이름
        public int number; // 위성 식별 넘버
        public double mass; // 위성 질량
        public DateTime epoch; // 위성 에포크 타임

        //위성 카테시안
        public double x = 0; public double y = 0; public double z = 0; // position (km)
        public double xvel = 0; public double yvel = 0; public double zvel = 0; // velocity (m)
        public Vector3 posvector;  public Vector3 velvector; // vectors
        public double angleVel = 0; // (rad/sec)
        public double period = 0; // (sec)

        // 위성 궤도요소
        public float a = 0; public float e = 0; public float i = 0; public float RAAN = 0; public float w = 0; public float TA = 0; // 궤도 6요소  

        public Satellite()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
            this.xvel = 0;
            this.yvel = 0;
            this.zvel = 0;
            this.name = "";
            this.number = 0;
            this.mass = 0;
        }

       public void makePosVector()
        {
            posvector.X = (float)this.x;
            posvector.Y = (float)this.y;
            posvector.Z = (float)this.z;
        }
        public void makeVelVector()
        {
            velvector.X = (float)this.xvel;
            velvector.Y = (float)this.yvel;
            velvector.Z = (float)this.zvel;
        }
    }


    /////////////////////// 계산전용 클래스 ///////////////////////
    ///////////////////////////////////////////////////////////////
    public static class Calculator
    {
        public const float Mu = 398600.441f; // km^3/s^2

        public static float RadToDeg(float Rad) // Radian to degree
        {
            return (Rad * 180) / (float)Math.PI;
        }
        public static float DegToRad(float Deg) // Degree to Radian
        {
            return (Deg / 180) * (float)Math.PI;
        }

        public static double FindDiffTime(DateTime t1, DateTime t2) // Find the difference t1 and t2 in seconds
        {
            TimeSpan diff = t2 - t1;
            
            return Math.Floor(diff.TotalSeconds) + 1;
        }

        public static void RV2COE(ref Satellite SAT) // Algorithm 9 (Vallado)
        {
            float h; float v; float r; float e; float n;
            Vector3 hvector; Vector3 nvector; Vector3 evector;

            hvector = Vector3.Cross(SAT.posvector, SAT.velvector);
            h = hvector.Length();
            v = SAT.velvector.Length();
            r = SAT.posvector.Length();

            nvector = Vector3.Cross(new Vector3(0, 0, 1), hvector);
            n = nvector.Length();

            // evector
            float tempVal = (float)Math.Pow(v, 2) - (Mu / r);
            Vector3 tempE1 = Vector3.Multiply(tempVal, SAT.posvector);
            Vector3 tempE2 = Vector3.Multiply(Vector3.Dot(SAT.posvector,SAT.velvector), SAT.velvector);
            evector = Vector3.Subtract(tempE1, tempE2) / Mu;
            e = evector.Length();

            float xi = (float)(Math.Pow(v, 2) / 2) - (Mu / r); // 크사이

            // semimajor axis
            SAT.a = -Mu / (2 * xi);
            // eccentricity
            SAT.e = e;
            // inclination
            SAT.i = (float)Math.Acos(hvector.Z/h);
            SAT.i = RadToDeg(SAT.i);
            // RAAN
            SAT.RAAN = (float)Math.Acos(nvector.X / n);
            SAT.RAAN = RadToDeg(SAT.RAAN);
            if (nvector.Y < 0)
                SAT.RAAN = 360 - SAT.RAAN;
            // w
            SAT.w = (float)Math.Acos(Vector3.Dot(nvector, evector) / (e * n));
            SAT.w = RadToDeg(SAT.w);
            if (evector.Z < 0)
                SAT.w = 360 - SAT.w;
            // TA
            SAT.TA = (float)Math.Acos(Vector3.Dot(evector, SAT.posvector) / (e * r));
            SAT.TA = RadToDeg(SAT.TA);
            if (Vector3.Dot(SAT.posvector, SAT.velvector) < 0)
                SAT.TA = 360 - SAT.TA;            
        }

        public static void FindPeriod(ref Satellite SAT) // Calculate a period using semimajoraxis
        {
            SAT.period = 2 * Math.PI * Math.Sqrt(Math.Pow(SAT.a, 3) / Mu);
            SAT.angleVel = (2 * Math.PI) / SAT.period;
        }
    }
}
