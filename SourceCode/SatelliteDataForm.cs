using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Numerics;

namespace RVD_Simulation
{
    public partial class SatelliteDataForm : Form /////////////////////// 인공위성 데이터 폼 클래스 ///////////////////////
    {
        int NumOfSat = 0; // Currnet number of satellites
        const int maxNum = 6; // The max number of satellites
        Satellite[] SAT; // Satellite 객체 배열 생성


        public SatelliteDataForm() // SatelliteDataForm 생성자
        {
            InitializeComponent();

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
            dataGridView_SAT.ColumnCount = 6; // 컬럼에 나타낼 데이터 수
            dataGridView_SAT.Columns[0].Name = "Name";
            dataGridView_SAT.Columns[1].Name = "semimajor";
        }

        private void btnAdd_Click(object sender, EventArgs e) // 인공위성 생성버튼
        {
            if(this.NumOfSat < maxNum - 1) this.NumOfSat += 1; //위성 갯수 증가

            SAT[NumOfSat].x = Convert.ToDouble(tBoxX.Text); // position, velocity 저장           
            SAT[NumOfSat].y = Convert.ToDouble(tBoxY.Text);
            SAT[NumOfSat].z = Convert.ToDouble(tBoxZ.Text);
            SAT[NumOfSat].xvel = Convert.ToDouble(tBoxXvel.Text);
            SAT[NumOfSat].yvel = Convert.ToDouble(tBoxYvel.Text);
            SAT[NumOfSat].zvel = Convert.ToDouble(tBoxZvel.Text);

            SAT[NumOfSat].name = Convert.ToString(tBoxX.Name); // Name 저장
            SAT[NumOfSat].number = NumOfSat; // Number 저장

            SAT[NumOfSat].makePosVector();
            SAT[NumOfSat].makeVelVector();
            Calculator.RV2COE(ref SAT[NumOfSat]); // cartesian to classical

            tBoxTest.Text = Convert.ToString(SAT[NumOfSat].TA);  /////////////////////////////////////////////테스트 출력
        }

        private void btnDelete_Click(object sender, EventArgs e) // 인공위성 삭제버튼
        {
            if (this.NumOfSat > 0) this.NumOfSat -= 1; // 위성 갯수 감소
            tBoxTest.Text = Convert.ToString(NumOfSat);
        }
    }

    public partial class Satellite  /////////////////////// 인공위성 클래스 ///////////////////////
    {
        public string name; // 위성 이름
        public int number; // 위성 식별 넘버

        //위성 카테시안
        public double x = 0; public double y = 0; public double z = 0; // position
        public double xvel = 0; public double yvel = 0; public double zvel = 0; // velocity
        public Vector3 posvector;  public Vector3 velvector; // vectors
        public Vector3 testvector; // 테스트벡터 (삭제예정)

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

    public static class Calculator
    {
        public const float Mu = 398600.441f; // km^3/s^2

        public static float RadToDeg(float Rad)
        {
            return (Rad * 180) / (float)Math.PI;
        }
        public static float DegToRad(float Deg)
        {
            return (Deg / 180) * (float)Math.PI;
        }


        public static void RV2COE(ref Satellite SAT) // Algorithm 9
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
    }
}
