using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSOL88.Personnal
{
    public partial class frmPersonnalBasic1 : Form
    {

        
        #region "0-------------------------- 변수선언"
        //int intUserIdx = -1;

        #endregion

        #region "1-------------------------- 정보 가져오기"
        #endregion

        #region "2-------------------------- 저장 및 내부 동작"
        private void fnInsertUser()
        {

        }
        #endregion

        #region "3-------------------------- 폼 로드 & 생성자 & 종료"
        public frmPersonnalBasic1()
        {
            InitializeComponent();
        }
        #endregion

        #region "4-------------------------- 컨트롤 체인지"
        #endregion

        #region "5-------------------------- 버튼 클릭"
        #endregion

        #region "6-------------------------- 정보 넘겨주기"
        #endregion


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel5.BringToFront();
            button3.BackColor = Color.FromArgb(78, 128, 203);
            button3.ForeColor = Color.White;
            button4.BackColor = Color.FromArgb(238, 241, 248);
            button4.ForeColor = Color.Black;
            button1.BackColor = Color.FromArgb(238, 241, 248);
            button1.ForeColor = Color.Black;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            button4.BackColor = Color.FromArgb(78, 128, 203);
            button4.ForeColor = Color.White;
            button3.BackColor = Color.FromArgb(238, 241, 248);
            button3.ForeColor = Color.Black;
            button1.BackColor = Color.FromArgb(238, 241, 248);
            button1.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.BringToFront();
            button1.BackColor = Color.FromArgb(78, 128, 203);
            button1.ForeColor = Color.White;
            button4.BackColor = Color.FromArgb(238, 241, 248);
            button4.ForeColor = Color.White;
            button3.BackColor = Color.FromArgb(238, 241, 248);
            button3.ForeColor = Color.Black;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            fnInsertUser();
        }

    }
}
