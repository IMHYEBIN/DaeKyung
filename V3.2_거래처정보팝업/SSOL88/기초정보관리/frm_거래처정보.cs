﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SSOL88.Counsult
{
    public partial class 거래처정보 : Form
    {
        public 거래처정보()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously

            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
        }
        MySqlConnection connection = new MySqlConnection("Server=112.140.64.121;port=3306;database=dkdb;username=ssol88;password=defcon33@@dd;charset=utf8");
        MySqlCommand command;


        static string constring = "Server=112.140.64.121;Database=dkdb;Uid=ssol88;Pwd=defcon33@@dd;charset=utf8";
        MySqlConnection conn = new MySqlConnection(constring);
        DataTable dt = new DataTable();


        public void populateDGV()
        {
            string selectQuery = "Select * from aa";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
            adapter.Fill(table);
            gridControl2.DataSource = table;

        }
        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public void excuteQuery(string query)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(query, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("완료되었습니다");
                }
                else
                {
                    MessageBox.Show("실패했습니다");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void frm_거래처정보_Load(object sender, EventArgs e)
        {
            filldata();
        }
        //데이터 채우는 함수
        private void filldata()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand cmd;

            //SQL
            string sql = "select * from aa ";
            cmd = new MySqlCommand(sql, conn);
            adapter.SelectCommand = cmd;

            //Bind datagrid

            adapter.Fill(dt);
            gridControl2.DataSource = dt;

        }

        //데이터 찾는 함수
        public void searchData(string valueToFind)
        {
            string searchQuery = "select * from  aa where  concat(거래처이름,담당자1) Like  '%" + valueToFind + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            gridControl2.DataSource = table;

        }

        void clear()
        {
            //거래처코드.Text = "";
            //거래처이름.Text = "";
            //설립년월일.Text = "";
            //대표자.Text = "";
            //거래처구분.Text = "";
            //업태.Text = "";
            //업종.Text = "";
            //사업자번호.Text = "";
            //주소.Text = "";
            //전화.Text = "";
            //팩스.Text = "";
            //담당자.Text = "";
            //연락처.Text = "";
            //담당자2.Text = "";
            //연락처2.Text = "";
            //경리담당자.Text = "";
            //경리연락처.Text = "";
            //대표이메일.Text = "";
            //계좌번호.Text = "";
        }

        //private void 추가_Click_1(object sender, EventArgs e)
        //{
        //    string insertQuery = "insert into aa(거래처코드,거래처이름,설립년월일,대표자,거래처구분,업태,업종,사업자번호,주소,전화,팩스,담당자1,휴대폰1,담당자2,휴대폰2,경리담당자,경리연락처,대표이메일,계좌번호) values('" + 거래처코드.Text + "','" + 거래처이름.Text + "','" + 설립년월일.Text + "','" + 대표자.Text + "','" + 거래처구분.Text + "','" + 업태.Text + "','" + 업종.Text + "','" + 사업자번호.Text + "','" + 주소.Text + "','" + 전화.Text + "','" + 팩스.Text + "','" + 담당자.Text + "','" + 연락처.Text + "','" + 담당자2.Text + "','" + 연락처2.Text + "' , '" + 경리담당자.Text + "' , '" + 경리연락처.Text + "' , '" + 대표이메일.Text + "' , '" + 계좌번호.Text + "')";
        //    excuteQuery(insertQuery);
        //    clear();
        //    populateDGV();
        //}

        //private void 수정_Click_1(object sender, EventArgs e)
        //{


        //    string updateQuery = "Update aa set 거래처코드='" + 거래처코드.Text + "',거래처이름='" + 거래처이름.Text + "', 설립년월일='" + 설립년월일.Text + "',대표자='" + 대표자.Text + "',거래처구분='" + 거래처구분.Text + "',업태='" + 업태.Text + "',업종='" + 업종.Text + "',사업자번호='" + 사업자번호.Text + "',주소='" + 주소.Text + "',전화='" + 전화.Text + "',팩스='" + 팩스.Text + "',담당자1='" + 담당자.Text + "',휴대폰1='" + 연락처.Text + "',담당자2='" + 담당자2.Text + "',휴대폰2='" + 연락처2.Text + "',경리담당자='" + 경리담당자.Text + "',경리연락처= '" + 경리연락처.Text + "',대표이메일='" + 대표이메일.Text + "',계좌번호='" + 계좌번호.Text + "';";
        //    excuteQuery(updateQuery);
        //    clear();
        //    populateDGV();
        //}

        //private void 삭제_Click_1(object sender, EventArgs e)
        //{
        //    string deleteQuery = "delete from aa where 거래처코드='" + 거래처코드.Text + "';";
        //    excuteQuery(deleteQuery);
        //    clear();
        //    populateDGV();
        //}

        private void gridControl2_Click_1(object sender, EventArgs e)
        {


        }

        private void 거래처명_TextChanged(object sender, EventArgs e)
        {
            searchData(거래처명.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            if (comboBox1.SelectedItem.ToString() == "All")
            {
                gridControl2.DataSource = dt;
            }
            else
            {
                dv.RowFilter = string.Format("거래처구분 like '%{0}%'", comboBox1.SelectedItem.ToString());
            }
            gridControl2.DataSource = dv;
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
          
        }
    }
}