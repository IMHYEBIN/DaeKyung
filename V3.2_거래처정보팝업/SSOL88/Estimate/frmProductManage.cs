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
    public partial class frmProductManage : Form
    {
        public frmProductManage()
        {
            InitializeComponent();

            fnLoadGridControl();
        }
        private void fnLoadGridControl()
        {
            // gridView, 스크롤 보이게 설정
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView2.OptionsView.ColumnAutoWidth = false;
        }

        private void frmProductManage_Load(object sender, EventArgs e)
        {

        }
    }
}
