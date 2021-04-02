using SSOL88.Counsult;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SSOL88.Popup
{
    public partial class 수주관리팝업 : Form
    {
        frm_수주관리 fgrid;

        public 수주관리팝업(frm_수주관리 form)
        {
            InitializeComponent();
            this.fgrid = form;
        }
        MySqlConnection connection = new MySqlConnection("Server=112.140.64.121;port=3306;database=dkdb;username=ssol88;password=defcon33@@dd;charset=utf8");
        MySqlCommand command;

        public void populateDGV()
        {
            string selectQuery = "Select * from ba";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
            adapter.Fill(table);
            fgrid.gridControl2.DataSource = table;
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

        void clear()
        {
            수주일.Text = "";
            상담일.Text = "";
            접수일.Text = "";
            납기일.Text = "";
            진행상태.Text = "";
            생산구분.Text = "";
            고객사.Text = "";
            담당자.Text = "";
            연락처.Text = "";
            주소.Text = "";
            특기사항.Text = "";
            제품명.Text = "";
            주문수량.Text = "";
            수주금액.Text = "";
            부가세.Text = "";
        
        }


        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void 추가_Click(object sender, EventArgs e)
        {
            string insertQuery = "insert into ba(수주일,상담일,접수일,납기일,진행상태,생산구분,고객사,담당자,연락처,주소,특기사항,제품명,주문수량,납품단가,수주금액,부가세) " +
                "values('" + 수주일.Text + "','" + 상담일.Text + "','" +접수일.Text + "','" + 납기일.Text + "','" + 진행상태.Text + "','" + 생산구분.Text + "','" + 고객사.Text + "','" + 담당자.Text + "','" + 연락처.Text + "','" + 주소.Text + "','" + 특기사항.Text + "','" + 제품명.Text + "','" + 주문수량.Text + "','"
               +납품단가.Text+"','"+수주금액.Text+"','"+부가세.Text+"')";
            MySqlCommand command = new MySqlCommand(insertQuery, connection);
             MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            fgrid.gridControl2.DataSource = table;
            
            populateDGV();
        }

        private void 수정_Click(object sender, EventArgs e)
        {
            string updateQuery = "Update ba set 수주일='" + 수주일.Text + "',상담일='" + 상담일.Text + 
                "',접수일='" + 접수일.Text + "',납기일='" + 납기일.Text + "',진행상태='" + 진행상태.Text + 
                "',생산구분='" + 생산구분.Text + "',고객사='" + 고객사.Text + "',담당자='" + 담당자.Text + "',연락처='" + 연락처.Text + 
                "',주소='" + 주소.Text + "',특기사항='" + 특기사항.Text + "',제품명='" + 제품명.Text + "',주문수량='" + 주문수량.Text + 
                "',납품단가='" + 납품단가.Text + "',수주금액='" + 수주금액.Text +"',부가세= '"+부가세.Text+ "';";
             excuteQuery(updateQuery);
              populateDGV();
        }

        private void 삭제_Click(object sender, EventArgs e)
        {
            string deleteQuery = "delete from aa where 수주일='" + 수주일.Text + "';";
            excuteQuery(deleteQuery);
            clear();
            populateDGV();
        }
    }
}
