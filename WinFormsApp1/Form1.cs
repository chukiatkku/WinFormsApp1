using System.CodeDom;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int arrayIndex = 0;
        int maxver = 0;

        public Form1()
        {
            InitializeComponent();
        }
        //create array 
        string[] arrID = new string[1000];
        string[] arrName = new string[1000];
        string[] arrScore = new string[1000];


        List<StudentLab03> list_lab03 = new List<StudentLab03>();
        StudentLab03 student;

        //ค่าาาที่ตั้งไว้ object
        string id;
        string name;
        double score;

        //เกรด
        double[] point = new double [8];
        double[] GPA = {4.0, 3.5, 3.0, 2.5, 2.0, 1.5, 1.0};
        
        // ABC 
        int[] grade = new int[8];



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e, arrayIndex);
        }

        private void button1_Click(object sender, EventArgs e, int arrayIndex)
        {

        }

        private void TBinName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBinScore_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBinIDmax_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBinScoremax_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            {

                id = TBinID.Text;
                name = TBinName.Text;
                score = double.Parse(TBinScore.Text);

                //Object
                student = new StudentLab03();
                student.id = id;
                student.name = name;
                student.score = score;

                //List
                list_lab03.Add(student);

                // if max min 
                double max = 0;
                foreach (StudentLab03 Liist in list_lab03)
                {

                    if (Liist.score > max)
                    {
                        max = Liist.score;
                        TBinIDmax.Text = Liist.id;
                        TBinNamemax.Text = Liist.name;
                        TBinScoremax.Text = max.ToString();
                    }

                }

                double min = 0;
                foreach (StudentLab03 Liist in list_lab03)
                {

                    if (Liist.score < min)
                    {
                        min = Liist.score;
                        TBinIDmin.Text = Liist.id;
                        TBinNamemin.Text = Liist.name;
                        TBinScoremin.Text = min.ToString();
                    }

                }

                //averange fast code 
                double listaverage = (double)list_lab03.Sum(f => f.score);
                TBinAverage.Text = (listaverage / (double)list_lab03.Count).ToString();



                // หาA-F 
                //A
                double all_point = score;
                if (all_point >= 80 && all_point <= 100)
                {
                    grade[0]++;
                    point[0] = (grade[0] * GPA[0]);
                    A.Text = grade[0].ToString();
                }
                //B+
                else if (all_point >= 75 &&  (all_point <= 79))
                {
                    grade[1]++;
                    point[1] = (grade[1] * GPA[1]);
                    BB.Text = grade[1].ToString();
                    
                }
                //B
                else if (all_point >= 70 && (all_point <= 74))
                {
                    grade[2]++;
                    point[2] = (grade[2] * GPA[2]);
                    B.Text = grade[2].ToString();
                }
                //C+
                else if (all_point >= 65 && (all_point <= 69))
                {
                    grade[3]++;
                    point[3] = (grade[3] * GPA[3]);
                    CC.Text = grade[3].ToString();
                }
                //C
                else if (all_point >= 60 && (all_point <= 64))
                {
                    grade[4]++;
                    point[4] = (grade[4] * GPA[4]);
                    C.Text = grade[4].ToString();
                }
                //D+
                else if (all_point >= 55 && (all_point <= 59))
                {
                    grade[5]++;
                    point[5] = (grade[5] * GPA[5]);
                    DD.Text = grade[5].ToString();
                }
                //D
                else if (all_point >= 50 && (all_point <= 54))
                {
                    grade[6]++;
                    point[6] = (grade[6] * GPA[6]);
                    D.Text = grade[6].ToString();
                }
                //F
               else
                {
                    grade[7]++;
                    F.Text = grade[7].ToString();
                    
                }

                double Averagegpa = 0.0;
                for (int i = 0; i < GPA.Length; i++) 
                {
                   Averagegpa += point[i];
                }


                int deviding = list_lab03.Count;
                double showgpa = Averagegpa /deviding;
                gradeAverage.Text = showgpa.ToString("0.00");

                //get input data from textbox
                string inputID = TBinID.Text;
                string inputName = TBinName.Text;
                string inputScore = TBinScore.Text;

                //add data to array
                arrID[arrayIndex] = inputID;
                arrName[arrayIndex] = inputName;
                arrScore[arrayIndex] = inputScore;
                arrayIndex++;
                int x = int.Parse(inputScore);

                if (x > maxver)
                {
                    maxver = x;
                    TBinIDmax.Text = inputID;
                    TBinNamemax.Text = inputName;
                    TBinScoremax.Text = inputScore;
                }
                if (x < maxver)
                {
                    maxver = x;
                    TBinIDmin.Text = inputID;
                    TBinNamemin.Text = inputName;
                    TBinScoremin.Text = inputScore;

                    



                }
            }
        }

        private void TBinScore_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}