using SSOL88.Popup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSOL88.Estimate
{
    public partial class frmEstimateWrite : Form
    {
        public frmEstimateWrite()
        {
            InitializeComponent();
          
            fnLoadGridControl();
        }

        private void button11_Click(object sender, EventArgs e)
        {
        }
        private void fnLoadGridControl()
        {
            // gridView, 스크롤 보이게 설정
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView2.OptionsView.ColumnAutoWidth = false;
            gridView3.OptionsView.ColumnAutoWidth = false;
        }

        private void frmEstimateWrite_Load(object sender, EventArgs e)
        {

        }
    }
}
