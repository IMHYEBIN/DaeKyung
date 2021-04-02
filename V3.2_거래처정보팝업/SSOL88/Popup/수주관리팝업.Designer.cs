
namespace SSOL88.Popup
{
    partial class 수주관리팝업
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.수정 = new System.Windows.Forms.Button();
            this.추가 = new System.Windows.Forms.Button();
            this.삭제 = new System.Windows.Forms.Button();
            this.주문수량 = new System.Windows.Forms.TextBox();
            this.진행상태 = new System.Windows.Forms.ComboBox();
            this.담당자 = new System.Windows.Forms.TextBox();
            this.수주금액 = new System.Windows.Forms.TextBox();
            this.제품명 = new System.Windows.Forms.ComboBox();
            this.부가세 = new System.Windows.Forms.TextBox();
            this.납품단가 = new System.Windows.Forms.TextBox();
            this.연락처 = new System.Windows.Forms.TextBox();
            this.생산구분 = new System.Windows.Forms.ComboBox();
            this.고객사 = new System.Windows.Forms.ComboBox();
            this.납기일 = new System.Windows.Forms.DateTimePicker();
            this.접수일 = new System.Windows.Forms.DateTimePicker();
            this.상담일 = new System.Windows.Forms.DateTimePicker();
            this.특기사항 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.상세주소 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.주소 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.수주일 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 수정
            // 
            this.수정.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.수정.BackColor = System.Drawing.Color.White;
            this.수정.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.수정.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.수정.Location = new System.Drawing.Point(527, 332);
            this.수정.Name = "수정";
            this.수정.Size = new System.Drawing.Size(75, 23);
            this.수정.TabIndex = 278;
            this.수정.Text = "수정";
            this.수정.UseVisualStyleBackColor = false;
            this.수정.Click += new System.EventHandler(this.수정_Click);
            // 
            // 추가
            // 
            this.추가.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.추가.BackColor = System.Drawing.Color.White;
            this.추가.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.추가.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.추가.Location = new System.Drawing.Point(447, 332);
            this.추가.Name = "추가";
            this.추가.Size = new System.Drawing.Size(75, 23);
            this.추가.TabIndex = 277;
            this.추가.Text = "추가";
            this.추가.UseVisualStyleBackColor = false;
            this.추가.Click += new System.EventHandler(this.추가_Click);
            // 
            // 삭제
            // 
            this.삭제.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.삭제.BackColor = System.Drawing.Color.White;
            this.삭제.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.삭제.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.삭제.Location = new System.Drawing.Point(607, 332);
            this.삭제.Name = "삭제";
            this.삭제.Size = new System.Drawing.Size(79, 23);
            this.삭제.TabIndex = 276;
            this.삭제.Text = "삭제";
            this.삭제.UseVisualStyleBackColor = false;
            this.삭제.Click += new System.EventHandler(this.삭제_Click);
            // 
            // 주문수량
            // 
            this.주문수량.Location = new System.Drawing.Point(103, 261);
            this.주문수량.Name = "주문수량";
            this.주문수량.Size = new System.Drawing.Size(225, 21);
            this.주문수량.TabIndex = 275;
            // 
            // 진행상태
            // 
            this.진행상태.FormattingEnabled = true;
            this.진행상태.Items.AddRange(new object[] {
            "상담",
            "접수",
            "출하"});
            this.진행상태.Location = new System.Drawing.Point(102, 82);
            this.진행상태.Name = "진행상태";
            this.진행상태.Size = new System.Drawing.Size(225, 20);
            this.진행상태.TabIndex = 274;
            // 
            // 담당자
            // 
            this.담당자.Location = new System.Drawing.Point(103, 140);
            this.담당자.Name = "담당자";
            this.담당자.Size = new System.Drawing.Size(224, 21);
            this.담당자.TabIndex = 273;
            // 
            // 수주금액
            // 
            this.수주금액.Location = new System.Drawing.Point(103, 291);
            this.수주금액.Name = "수주금액";
            this.수주금액.Size = new System.Drawing.Size(224, 21);
            this.수주금액.TabIndex = 272;
            // 
            // 제품명
            // 
            this.제품명.FormattingEnabled = true;
            this.제품명.Items.AddRange(new object[] {
            "전면 코너기둥-1",
            "전면 코너기둥-2 ",
            "전면 코너기둥",
            "트러스",
            "퍼린-1",
            "퍼린-2",
            "전후면 보강대-1",
            "전후면 보강대-2",
            "전후면 보강대-3",
            "전면 수직브레싱"});
            this.제품명.Location = new System.Drawing.Point(103, 232);
            this.제품명.Name = "제품명";
            this.제품명.Size = new System.Drawing.Size(224, 20);
            this.제품명.TabIndex = 271;
            // 
            // 부가세
            // 
            this.부가세.Location = new System.Drawing.Point(443, 260);
            this.부가세.Name = "부가세";
            this.부가세.Size = new System.Drawing.Size(225, 21);
            this.부가세.TabIndex = 270;
            // 
            // 납품단가
            // 
            this.납품단가.Location = new System.Drawing.Point(443, 230);
            this.납품단가.Name = "납품단가";
            this.납품단가.Size = new System.Drawing.Size(225, 21);
            this.납품단가.TabIndex = 269;
            // 
            // 연락처
            // 
            this.연락처.Location = new System.Drawing.Point(443, 140);
            this.연락처.Name = "연락처";
            this.연락처.Size = new System.Drawing.Size(225, 21);
            this.연락처.TabIndex = 268;
            // 
            // 생산구분
            // 
            this.생산구분.FormattingEnabled = true;
            this.생산구분.Items.AddRange(new object[] {
            "자체",
            "외주"});
            this.생산구분.Location = new System.Drawing.Point(443, 82);
            this.생산구분.Name = "생산구분";
            this.생산구분.Size = new System.Drawing.Size(225, 20);
            this.생산구분.TabIndex = 267;
            // 
            // 고객사
            // 
            this.고객사.FormattingEnabled = true;
            this.고객사.Items.AddRange(new object[] {
            "테크엔"});
            this.고객사.Location = new System.Drawing.Point(103, 112);
            this.고객사.Name = "고객사";
            this.고객사.Size = new System.Drawing.Size(224, 20);
            this.고객사.TabIndex = 266;
            // 
            // 납기일
            // 
            this.납기일.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.납기일.Location = new System.Drawing.Point(443, 51);
            this.납기일.Name = "납기일";
            this.납기일.Size = new System.Drawing.Size(225, 21);
            this.납기일.TabIndex = 265;
            this.납기일.Value = new System.DateTime(2021, 4, 1, 0, 0, 0, 0);
            // 
            // 접수일
            // 
            this.접수일.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.접수일.Location = new System.Drawing.Point(103, 51);
            this.접수일.Name = "접수일";
            this.접수일.Size = new System.Drawing.Size(225, 21);
            this.접수일.TabIndex = 264;
            this.접수일.Value = new System.DateTime(2021, 4, 1, 0, 0, 0, 0);
            this.접수일.ValueChanged += new System.EventHandler(this.dateTimePicker4_ValueChanged);
            // 
            // 상담일
            // 
            this.상담일.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.상담일.Location = new System.Drawing.Point(443, 21);
            this.상담일.Name = "상담일";
            this.상담일.Size = new System.Drawing.Size(225, 21);
            this.상담일.TabIndex = 263;
            this.상담일.Value = new System.DateTime(2021, 4, 1, 0, 0, 0, 0);
            this.상담일.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // 특기사항
            // 
            this.특기사항.Location = new System.Drawing.Point(443, 170);
            this.특기사항.Name = "특기사항";
            this.특기사항.Size = new System.Drawing.Size(225, 21);
            this.특기사항.TabIndex = 259;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label15.Location = new System.Drawing.Point(360, 265);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 255;
            this.label15.Text = "부가세";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label16.Location = new System.Drawing.Point(360, 175);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 254;
            this.label16.Text = "특기사항";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label18.Location = new System.Drawing.Point(360, 235);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 12);
            this.label18.TabIndex = 253;
            this.label18.Text = "납품단가";
            // 
            // 상세주소
            // 
            this.상세주소.Location = new System.Drawing.Point(103, 201);
            this.상세주소.Name = "상세주소";
            this.상세주소.Size = new System.Drawing.Size(225, 21);
            this.상세주소.TabIndex = 251;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(20, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 246;
            this.label2.Text = "제품명";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(20, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 244;
            this.label8.Text = "수주금액";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(20, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 243;
            this.label9.Text = "주문수량";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(20, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 242;
            this.label10.Text = "상세주소";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(360, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 229;
            this.label4.Text = "생산구분";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(360, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 228;
            this.label5.Text = "상담일";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Location = new System.Drawing.Point(360, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 227;
            this.label12.Text = "연락처";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Location = new System.Drawing.Point(360, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 226;
            this.label13.Text = "납기일";
            // 
            // 주소
            // 
            this.주소.Location = new System.Drawing.Point(103, 171);
            this.주소.Name = "주소";
            this.주소.Size = new System.Drawing.Size(225, 21);
            this.주소.TabIndex = 147;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label32.Location = new System.Drawing.Point(20, 86);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(53, 12);
            this.label32.TabIndex = 129;
            this.label32.Text = "진행상태";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label23.Location = new System.Drawing.Point(20, 176);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 12);
            this.label23.TabIndex = 126;
            this.label23.Text = "주소";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(20, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 121;
            this.label11.Text = "담당자";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(20, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 117;
            this.label3.Text = "고객사";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(20, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 116;
            this.label1.Text = "접수일";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(20, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 113;
            this.label6.Text = "수주일";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.수주일);
            this.panel1.Controls.Add(this.수정);
            this.panel1.Controls.Add(this.추가);
            this.panel1.Controls.Add(this.삭제);
            this.panel1.Controls.Add(this.주문수량);
            this.panel1.Controls.Add(this.진행상태);
            this.panel1.Controls.Add(this.담당자);
            this.panel1.Controls.Add(this.수주금액);
            this.panel1.Controls.Add(this.제품명);
            this.panel1.Controls.Add(this.부가세);
            this.panel1.Controls.Add(this.납품단가);
            this.panel1.Controls.Add(this.연락처);
            this.panel1.Controls.Add(this.생산구분);
            this.panel1.Controls.Add(this.고객사);
            this.panel1.Controls.Add(this.납기일);
            this.panel1.Controls.Add(this.접수일);
            this.panel1.Controls.Add(this.상담일);
            this.panel1.Controls.Add(this.특기사항);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.상세주소);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.주소);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 370);
            this.panel1.TabIndex = 216;
            // 
            // 수주일
            // 
            this.수주일.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.수주일.Location = new System.Drawing.Point(102, 20);
            this.수주일.Name = "수주일";
            this.수주일.Size = new System.Drawing.Size(225, 21);
            this.수주일.TabIndex = 279;
            this.수주일.Value = new System.DateTime(2021, 4, 1, 0, 0, 0, 0);
            // 
            // 수주관리팝업
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 367);
            this.Controls.Add(this.panel1);
            this.Name = "수주관리팝업";
            this.Text = "수주관리팝업";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button 수정;
        private System.Windows.Forms.Button 추가;
        private System.Windows.Forms.Button 삭제;
        private System.Windows.Forms.TextBox 주문수량;
        private System.Windows.Forms.ComboBox 진행상태;
        private System.Windows.Forms.TextBox 담당자;
        private System.Windows.Forms.TextBox 수주금액;
        private System.Windows.Forms.ComboBox 제품명;
        private System.Windows.Forms.TextBox 부가세;
        private System.Windows.Forms.TextBox 납품단가;
        private System.Windows.Forms.TextBox 연락처;
        private System.Windows.Forms.ComboBox 생산구분;
        private System.Windows.Forms.ComboBox 고객사;
        private System.Windows.Forms.DateTimePicker 납기일;
        private System.Windows.Forms.DateTimePicker 접수일;
        private System.Windows.Forms.DateTimePicker 상담일;
        private System.Windows.Forms.TextBox 특기사항;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox 상세주소;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox 주소;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker 수주일;
    }
}