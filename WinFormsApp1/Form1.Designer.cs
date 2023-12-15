namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            TBinAverage = new TextBox();
            TBinScoremin = new TextBox();
            TBinNamemin = new TextBox();
            TBinIDmin = new TextBox();
            TBinScoremax = new TextBox();
            TBinNamemax = new TextBox();
            TBinIDmax = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            TBsaving = new Button();
            TBinScore = new TextBox();
            TBinName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            TBinID = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label18 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label12 = new Label();
            label13 = new Label();
            label11 = new Label();
            label10 = new Label();
            gradeAverage = new TextBox();
            F = new TextBox();
            D = new TextBox();
            DD = new TextBox();
            C = new TextBox();
            CC = new TextBox();
            B = new TextBox();
            BB = new TextBox();
            A = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(794, 41);
            label9.Name = "label9";
            label9.Size = new Size(48, 20);
            label9.TabIndex = 7;
            label9.Text = "คะแนน";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(651, 41);
            label8.Name = "label8";
            label8.Size = new Size(81, 20);
            label8.TabIndex = 7;
            label8.Text = "ชื่อ-นามสกุล";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(523, 41);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 7;
            label7.Text = "รหัสนักศึกษา";
            // 
            // TBinAverage
            // 
            TBinAverage.Location = new Point(763, 205);
            TBinAverage.Name = "TBinAverage";
            TBinAverage.Size = new Size(125, 27);
            TBinAverage.TabIndex = 7;
            // 
            // TBinScoremin
            // 
            TBinScoremin.Location = new Point(763, 138);
            TBinScoremin.Name = "TBinScoremin";
            TBinScoremin.Size = new Size(125, 27);
            TBinScoremin.TabIndex = 14;
            // 
            // TBinNamemin
            // 
            TBinNamemin.Location = new Point(632, 139);
            TBinNamemin.Name = "TBinNamemin";
            TBinNamemin.Size = new Size(125, 27);
            TBinNamemin.TabIndex = 13;
            // 
            // TBinIDmin
            // 
            TBinIDmin.Location = new Point(501, 139);
            TBinIDmin.Name = "TBinIDmin";
            TBinIDmin.Size = new Size(125, 27);
            TBinIDmin.TabIndex = 12;
            // 
            // TBinScoremax
            // 
            TBinScoremax.Location = new Point(763, 78);
            TBinScoremax.Name = "TBinScoremax";
            TBinScoremax.Size = new Size(125, 27);
            TBinScoremax.TabIndex = 11;
            TBinScoremax.TextChanged += TBinScoremax_TextChanged;
            // 
            // TBinNamemax
            // 
            TBinNamemax.Location = new Point(632, 79);
            TBinNamemax.Name = "TBinNamemax";
            TBinNamemax.Size = new Size(125, 27);
            TBinNamemax.TabIndex = 10;
            // 
            // TBinIDmax
            // 
            TBinIDmax.Location = new Point(501, 79);
            TBinIDmax.Name = "TBinIDmax";
            TBinIDmax.Size = new Size(125, 27);
            TBinIDmax.TabIndex = 7;
            TBinIDmax.TextChanged += TBinIDmax_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(680, 208);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 9;
            label6.Text = "คะแนนเฉลี่ย";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(414, 146);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 8;
            label5.Text = "คะแนนต่ำสุด";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(416, 82);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 7;
            label4.Text = "คะแนนสูงสุด";
            // 
            // TBsaving
            // 
            TBsaving.Location = new Point(159, 264);
            TBsaving.Name = "TBsaving";
            TBsaving.Size = new Size(125, 29);
            TBsaving.TabIndex = 2;
            TBsaving.Text = "บันทึก";
            TBsaving.UseVisualStyleBackColor = true;
            TBsaving.Click += button2_Click_1;
            // 
            // TBinScore
            // 
            TBinScore.Location = new Point(159, 201);
            TBinScore.Name = "TBinScore";
            TBinScore.Size = new Size(125, 27);
            TBinScore.TabIndex = 6;
            TBinScore.TextChanged += TBinScore_TextChanged_1;
            // 
            // TBinName
            // 
            TBinName.Location = new Point(159, 138);
            TBinName.Name = "TBinName";
            TBinName.Size = new Size(125, 27);
            TBinName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 201);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 4;
            label3.Text = "คะแนน";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 141);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 3;
            label2.Text = "ชื่อ-นามสกุล";
            // 
            // TBinID
            // 
            TBinID.Location = new Point(159, 79);
            TBinID.Name = "TBinID";
            TBinID.Size = new Size(125, 27);
            TBinID.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 79);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 0;
            label1.Text = "รหัสนักศึกษา";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(gradeAverage);
            groupBox2.Controls.Add(F);
            groupBox2.Controls.Add(D);
            groupBox2.Controls.Add(DD);
            groupBox2.Controls.Add(C);
            groupBox2.Controls.Add(CC);
            groupBox2.Controls.Add(B);
            groupBox2.Controls.Add(BB);
            groupBox2.Controls.Add(A);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(TBinAverage);
            groupBox2.Controls.Add(TBinScoremin);
            groupBox2.Controls.Add(TBinNamemin);
            groupBox2.Controls.Add(TBinIDmin);
            groupBox2.Controls.Add(TBinScoremax);
            groupBox2.Controls.Add(TBinNamemax);
            groupBox2.Controls.Add(TBinIDmax);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(470, 30);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(921, 444);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "ผลลัพท์";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(85, 354);
            label18.Name = "label18";
            label18.Size = new Size(66, 20);
            label18.TabIndex = 32;
            label18.Text = "เกรดเฉลี่ย";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(108, 320);
            label14.Name = "label14";
            label14.Size = new Size(16, 20);
            label14.TabIndex = 31;
            label14.Text = "F";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(108, 284);
            label15.Name = "label15";
            label15.Size = new Size(20, 20);
            label15.TabIndex = 30;
            label15.Text = "D";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(108, 253);
            label16.Name = "label16";
            label16.Size = new Size(30, 20);
            label16.TabIndex = 29;
            label16.Text = "D+";
            label16.Click += label16_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(108, 217);
            label17.Name = "label17";
            label17.Size = new Size(18, 20);
            label17.TabIndex = 28;
            label17.Text = "C";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(108, 183);
            label12.Name = "label12";
            label12.Size = new Size(28, 20);
            label12.TabIndex = 27;
            label12.Text = "C+";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(108, 147);
            label13.Name = "label13";
            label13.Size = new Size(18, 20);
            label13.TabIndex = 26;
            label13.Text = "B";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(108, 116);
            label11.Name = "label11";
            label11.Size = new Size(28, 20);
            label11.TabIndex = 25;
            label11.Text = "B+";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(108, 80);
            label10.Name = "label10";
            label10.Size = new Size(19, 20);
            label10.TabIndex = 24;
            label10.Text = "A";
            label10.Click += label10_Click;
            // 
            // gradeAverage
            // 
            gradeAverage.Location = new Point(195, 347);
            gradeAverage.Name = "gradeAverage";
            gradeAverage.Size = new Size(125, 27);
            gradeAverage.TabIndex = 23;
            // 
            // F
            // 
            F.Location = new Point(195, 314);
            F.Name = "F";
            F.Size = new Size(125, 27);
            F.TabIndex = 22;
            // 
            // D
            // 
            D.Location = new Point(195, 281);
            D.Name = "D";
            D.Size = new Size(125, 27);
            D.TabIndex = 21;
            // 
            // DD
            // 
            DD.Location = new Point(195, 246);
            DD.Name = "DD";
            DD.Size = new Size(125, 27);
            DD.TabIndex = 20;
            // 
            // C
            // 
            C.Location = new Point(195, 213);
            C.Name = "C";
            C.Size = new Size(125, 27);
            C.TabIndex = 19;
            // 
            // CC
            // 
            CC.Location = new Point(195, 180);
            CC.Name = "CC";
            CC.Size = new Size(125, 27);
            CC.TabIndex = 18;
            // 
            // B
            // 
            B.Location = new Point(195, 147);
            B.Name = "B";
            B.Size = new Size(125, 27);
            B.TabIndex = 17;
            // 
            // BB
            // 
            BB.Location = new Point(195, 112);
            BB.Name = "BB";
            BB.Size = new Size(125, 27);
            BB.TabIndex = 16;
            // 
            // A
            // 
            A.Location = new Point(195, 79);
            A.Name = "A";
            A.Size = new Size(125, 27);
            A.TabIndex = 15;
            A.TextChanged += textBox1_TextChanged_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TBsaving);
            groupBox1.Controls.Add(TBinScore);
            groupBox1.Controls.Add(TBinName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TBinID);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(36, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(362, 368);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "กรอกข้อมูล";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1403, 500);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox TBinAverage;
        private TextBox TBinScoremin;
        private TextBox TBinNamemin;
        private TextBox TBinIDmin;
        private TextBox TBinScoremax;
        private TextBox TBinNamemax;
        private TextBox TBinIDmax;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button TBsaving;
        private TextBox TBinScore;
        private TextBox TBinName;
        private Label label3;
        private Label label2;
        private TextBox TBinID;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox A;
        private TextBox gradeAverage;
        private TextBox F;
        private TextBox D;
        private TextBox DD;
        private TextBox C;
        private TextBox CC;
        private TextBox B;
        private TextBox BB;
        private Label label18;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label12;
        private Label label13;
        private Label label11;
        private Label label10;
    }
}
