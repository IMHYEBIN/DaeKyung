namespace SSOL88.Counsult
{
    partial class frm_수주관리
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
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_수주관리));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.검색 = new System.Windows.Forms.Button();
            this.제품명 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.조회기간검색 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.수정 = new System.Windows.Forms.Button();
            this.추가 = new System.Windows.Forms.Button();
            this.삭제 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource3 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col수주코드 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col업체명 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col제품명 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col주문수량 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col납품단가 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col수주금액 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col운송비 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col접수일 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col납기일 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col수주중량 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col수주디테일코드 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col디테일일련번호 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "112.140.64.121_dkdb_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = "select 수주마스터코드,수주일련번호 from ba;";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.Name = "sqlDataSource2";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1904, 1041);
            this.splitContainer1.SplitterDistance = 47;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.검색);
            this.panel4.Controls.Add(this.제품명);
            this.panel4.Controls.Add(this.dateTimePicker2);
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.조회기간검색);
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.수정);
            this.panel4.Controls.Add(this.추가);
            this.panel4.Controls.Add(this.삭제);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.button8);
            this.panel4.Controls.Add(this.button11);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1904, 46);
            this.panel4.TabIndex = 62;
            // 
            // 검색
            // 
            this.검색.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.검색.BackColor = System.Drawing.Color.Gray;
            this.검색.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.검색.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.검색.Location = new System.Drawing.Point(445, 11);
            this.검색.Name = "검색";
            this.검색.Size = new System.Drawing.Size(75, 23);
            this.검색.TabIndex = 250;
            this.검색.Text = "검색";
            this.검색.UseVisualStyleBackColor = false;
            // 
            // 제품명
            // 
            this.제품명.Location = new System.Drawing.Point(263, 12);
            this.제품명.Name = "제품명";
            this.제품명.Size = new System.Drawing.Size(174, 21);
            this.제품명.TabIndex = 249;
            this.제품명.TextChanged += new System.EventHandler(this.거래처명_TextChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(1081, 11);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(128, 21);
            this.dateTimePicker2.TabIndex = 248;
            this.dateTimePicker2.Value = new System.DateTime(2021, 4, 1, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(947, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 21);
            this.dateTimePicker1.TabIndex = 247;
            this.dateTimePicker1.Value = new System.DateTime(2021, 4, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(1073, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 12);
            this.label4.TabIndex = 245;
            this.label4.Text = "~";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // 조회기간검색
            // 
            this.조회기간검색.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.조회기간검색.BackColor = System.Drawing.Color.Gray;
            this.조회기간검색.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.조회기간검색.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.조회기간검색.Location = new System.Drawing.Point(1210, 10);
            this.조회기간검색.Name = "조회기간검색";
            this.조회기간검색.Size = new System.Drawing.Size(75, 23);
            this.조회기간검색.TabIndex = 241;
            this.조회기간검색.Text = "검색";
            this.조회기간검색.UseVisualStyleBackColor = false;
            this.조회기간검색.Click += new System.EventHandler(this.조회기간검색_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(887, 10);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(398, 23);
            this.button7.TabIndex = 243;
            this.button7.Text = "조회기간";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // 수정
            // 
            this.수정.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.수정.BackColor = System.Drawing.Color.White;
            this.수정.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.수정.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.수정.Location = new System.Drawing.Point(1535, 13);
            this.수정.Name = "수정";
            this.수정.Size = new System.Drawing.Size(75, 23);
            this.수정.TabIndex = 9;
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
            this.추가.Location = new System.Drawing.Point(1455, 13);
            this.추가.Name = "추가";
            this.추가.Size = new System.Drawing.Size(75, 23);
            this.추가.TabIndex = 8;
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
            this.삭제.Location = new System.Drawing.Point(1615, 13);
            this.삭제.Name = "삭제";
            this.삭제.Size = new System.Drawing.Size(79, 23);
            this.삭제.TabIndex = 7;
            this.삭제.Text = "삭제";
            this.삭제.UseVisualStyleBackColor = false;
            this.삭제.Click += new System.EventHandler(this.삭제_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "전체",
            "거래처1",
            "거래처2",
            "거래처3",
            "거래처4"});
            this.comboBox1.Location = new System.Drawing.Point(85, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(118, 20);
            this.comboBox1.TabIndex = 234;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(10, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(193, 23);
            this.button8.TabIndex = 240;
            this.button8.Text = "업체명";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(209, 12);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(311, 23);
            this.button11.TabIndex = 239;
            this.button11.Text = "제품명";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gridControl2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitterControl1);
            this.splitContainer2.Panel2.Controls.Add(this.gridControl3);
            this.splitContainer2.Size = new System.Drawing.Size(1904, 990);
            this.splitContainer2.SplitterDistance = 634;
            this.splitContainer2.TabIndex = 0;
            // 
            // gridControl2
            // 
            this.gridControl2.DataMember = "Query";
            this.gridControl2.DataSource = this.sqlDataSource3;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView1;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1904, 634);
            this.gridControl2.TabIndex = 218;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl2.Click += new System.EventHandler(this.gridControl2_Click_1);
            // 
            // sqlDataSource3
            // 
            this.sqlDataSource3.ConnectionName = "112.140.64.121_dkdb_Connection";
            this.sqlDataSource3.Name = "sqlDataSource3";
            customSqlQuery2.Name = "Query";
            customSqlQuery2.Sql = "select * from ba;";
            this.sqlDataSource3.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery2});
            this.sqlDataSource3.ResultSchemaSerializable = resources.GetString("sqlDataSource3.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col수주코드,
            this.col업체명,
            this.col제품명,
            this.col주문수량,
            this.col납품단가,
            this.col수주금액,
            this.col운송비,
            this.col접수일,
            this.col납기일,
            this.col수주중량});
            this.gridView1.GridControl = this.gridControl2;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick_1);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // col수주코드
            // 
            this.col수주코드.FieldName = "수주코드";
            this.col수주코드.Name = "col수주코드";
            this.col수주코드.Visible = true;
            this.col수주코드.VisibleIndex = 0;
            // 
            // col업체명
            // 
            this.col업체명.FieldName = "업체명";
            this.col업체명.Name = "col업체명";
            this.col업체명.Visible = true;
            this.col업체명.VisibleIndex = 1;
            // 
            // col제품명
            // 
            this.col제품명.FieldName = "제품명";
            this.col제품명.Name = "col제품명";
            this.col제품명.Visible = true;
            this.col제품명.VisibleIndex = 2;
            // 
            // col주문수량
            // 
            this.col주문수량.FieldName = "주문수량";
            this.col주문수량.Name = "col주문수량";
            this.col주문수량.Visible = true;
            this.col주문수량.VisibleIndex = 3;
            // 
            // col납품단가
            // 
            this.col납품단가.FieldName = "납품단가";
            this.col납품단가.Name = "col납품단가";
            this.col납품단가.Visible = true;
            this.col납품단가.VisibleIndex = 4;
            // 
            // col수주금액
            // 
            this.col수주금액.FieldName = "수주금액";
            this.col수주금액.Name = "col수주금액";
            this.col수주금액.Visible = true;
            this.col수주금액.VisibleIndex = 5;
            // 
            // col운송비
            // 
            this.col운송비.FieldName = "운송비";
            this.col운송비.Name = "col운송비";
            this.col운송비.Visible = true;
            this.col운송비.VisibleIndex = 6;
            // 
            // col접수일
            // 
            this.col접수일.FieldName = "접수일";
            this.col접수일.Name = "col접수일";
            this.col접수일.Visible = true;
            this.col접수일.VisibleIndex = 7;
            // 
            // col납기일
            // 
            this.col납기일.FieldName = "납기일";
            this.col납기일.Name = "col납기일";
            this.col납기일.Visible = true;
            this.col납기일.VisibleIndex = 8;
            // 
            // col수주중량
            // 
            this.col수주중량.FieldName = "수주중량";
            this.col수주중량.Name = "col수주중량";
            this.col수주중량.Visible = true;
            this.col수주중량.VisibleIndex = 9;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterControl1.Location = new System.Drawing.Point(0, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(1904, 10);
            this.splitterControl1.TabIndex = 220;
            this.splitterControl1.TabStop = false;
            // 
            // gridControl3
            // 
            this.gridControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl3.Location = new System.Drawing.Point(0, 0);
            this.gridControl3.MainView = this.gridView2;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(1904, 352);
            this.gridControl3.TabIndex = 219;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col수주디테일코드,
            this.col디테일일련번호});
            this.gridView2.GridControl = this.gridControl3;
            this.gridView2.Name = "gridView2";
            // 
            // col수주디테일코드
            // 
            this.col수주디테일코드.FieldName = "수주디테일코드";
            this.col수주디테일코드.Name = "col수주디테일코드";
            this.col수주디테일코드.Visible = true;
            this.col수주디테일코드.VisibleIndex = 0;
            // 
            // col디테일일련번호
            // 
            this.col디테일일련번호.FieldName = "디테일일련번호";
            this.col디테일일련번호.Name = "col디테일일련번호";
            this.col디테일일련번호.Visible = true;
            this.col디테일일련번호.VisibleIndex = 1;
            // 
            // frm_수주관리
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frm_수주관리";
            this.Text = "수주관리";
            this.Load += new System.EventHandler(this.frm_수주관리_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button 수정;
        private System.Windows.Forms.Button 추가;
        private System.Windows.Forms.Button 삭제;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn col수주디테일코드;
        private DevExpress.XtraGrid.Columns.GridColumn col디테일일련번호;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private System.Windows.Forms.Button 조회기간검색;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label4;
        public DevExpress.XtraGrid.GridControl gridControl2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button 검색;
        private System.Windows.Forms.TextBox 제품명;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col수주코드;
        private DevExpress.XtraGrid.Columns.GridColumn col업체명;
        private DevExpress.XtraGrid.Columns.GridColumn col제품명;
        private DevExpress.XtraGrid.Columns.GridColumn col주문수량;
        private DevExpress.XtraGrid.Columns.GridColumn col납품단가;
        private DevExpress.XtraGrid.Columns.GridColumn col수주금액;
        private DevExpress.XtraGrid.Columns.GridColumn col운송비;
        private DevExpress.XtraGrid.Columns.GridColumn col접수일;
        private DevExpress.XtraGrid.Columns.GridColumn col납기일;
        private DevExpress.XtraGrid.Columns.GridColumn col수주중량;
    }
}