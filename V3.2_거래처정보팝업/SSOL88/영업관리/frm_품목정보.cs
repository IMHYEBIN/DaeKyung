﻿using CRM_WMS.libarary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_WMS.Asset
{
    public partial class frmWarehousing : Form
    {
        public frmWarehousing()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
        }
        ssol88bll u = new ssol88bll();
        ssol88dal dal = new ssol88dal();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmWarehousing_Load(object sender, EventArgs e)
        {

        }

        private void button_등록_Click(object sender, EventArgs e)
        {
            u.제품코드 = textBox_제품코드.Text;
            u.영문품명 = textBox_영문품명.Text;
            u.한글품명 = textBox_한글품명.Text;
            u.고객사코드 = textBox_고객사코드.Text;
            u.품목정보납품단가 = textBox_납품단가.Text;
            u.개발일자 = dateTimePicker_개발일자.CustomFormat;
            u.양산일자 = dateTimePicker_양산일자.CustomFormat;
            u.단위 = textBox_단위.Text;
            u.제품중량 = textBox_제품중량.Text;
            u.기계가공 = textBox_기계가공.Text;
            u.재질 = textBox_재질.Text;
            u.공정 = textBox_공정.Text;
            u.도면코드 = textBox_도면코드.Text;
            u.제품사진 = textBox_제품사진.Text;
            u.금형코드 = textBox_금형코드.Text;
            u.지그코드 = textBox_지그코드.Text;
            u.단가고정 = textBox_단가고정.Text;
            u.로스율 = textBox_로스율.Text;
            bool sucesss = dal.insert_품목정보(u);

            //if the data is successfully inserted then the value of success will be true else ite will be false
            if (sucesss == true)
            {
                //
                MessageBox.Show("등록되엇습니다");
                this.Hide();
            }
            else
            {
                MessageBox.Show("데이터 넣는데 실패 햇습니다");
            }
            DataTable dt = dal.Select_품목정보();
            gridControl_품목정보.DataSource = dt;
        }

        private void button_수정_Click(object sender, EventArgs e)
        {
            u.제품코드 = textBox_제품코드.Text;
            u.영문품명 = textBox_영문품명.Text;
            u.한글품명 = textBox_한글품명.Text;
            u.고객사코드 = textBox_고객사코드.Text;
            u.품목정보납품단가 = textBox_납품단가.Text;
            u.개발일자 = dateTimePicker_개발일자.CustomFormat;
            u.양산일자 = dateTimePicker_양산일자.CustomFormat;
            u.단위 = textBox_단위.Text;
            u.제품중량 = textBox_제품중량.Text;
            u.기계가공 = textBox_기계가공.Text;
            u.재질 = textBox_재질.Text;
            u.공정 = textBox_공정.Text;
            u.도면코드 = textBox_도면코드.Text;
            u.제품사진 = textBox_제품사진.Text;
            u.금형코드 = textBox_금형코드.Text;
            u.지그코드 = textBox_지그코드.Text;
            u.단가고정 = textBox_단가고정.Text;
            u.로스율 = textBox_로스율.Text;
            bool sucesss = dal.Update_품목정보(u);

            //if the data is successfully inserted then the value of success will be true else ite will be false
            if (sucesss == true)
            {
                //
                MessageBox.Show("수정되었습니다");
                this.Hide();
            }
            else
            {
                MessageBox.Show("데이터 넣는데 실패 햇습니다");
            }
            DataTable dt = dal.Select_품목정보();
            gridControl_품목정보.DataSource = dt;
        }
    

        private void button_삭제_Click(object sender, EventArgs e)
        {
            u.제품코드 = textBox_제품코드.Text;
            u.영문품명 = textBox_영문품명.Text;
            u.한글품명 = textBox_한글품명.Text;
            u.고객사코드 = textBox_고객사코드.Text;
            u.품목정보납품단가 = textBox_납품단가.Text;
            u.개발일자 = dateTimePicker_개발일자.CustomFormat;
            u.양산일자 = dateTimePicker_양산일자.CustomFormat;
            u.단위 = textBox_단위.Text;
            u.제품중량 = textBox_제품중량.Text;
            u.기계가공 = textBox_기계가공.Text;
            u.재질 = textBox_재질.Text;
            u.공정 = textBox_공정.Text;
            u.도면코드 = textBox_도면코드.Text;
            u.제품사진 = textBox_제품사진.Text;
            u.금형코드 = textBox_금형코드.Text;
            u.지그코드 = textBox_지그코드.Text;
            u.단가고정 = textBox_단가고정.Text;
            u.로스율 = textBox_로스율.Text;
            bool sucesss = dal.delete_품목정보(u);

            //if the data is successfully inserted then the value of success will be true else ite will be false
            if (sucesss == true)
            {
                //
                MessageBox.Show("삭제되었습니다");
                this.Hide();
            }
            else
            {
                MessageBox.Show("데이터 넣는데 실패 햇습니다");
            }
            DataTable dt = dal.Select_품목정보();
            gridControl_품목정보.DataSource = dt;
        }
    }
}
