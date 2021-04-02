using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using SSOL88.기초정보관리;
using SSOL88.Counsult;
using SSOL88.기초정보;
using SSOL88.영업관리.출하관리;
using SSOL88.영업관리.영업기준정보;
using SSOL88.영업관리;
using SSOL88.생산관리;
using SSOL88.자재관리;
using SSOL88.재고관리;
using SSOL88.품질관리;
using SSOL88.시스템관리;
//using SSOL88.Asset;

namespace CRM_WMS
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            fnSetmdGlobalVars();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // 2019-08-16 dhkim - StatusBar 시간 및 버전 추가
            timer1_Tick(sender, e);
            timer1.Interval = 1000;
            timer1.Start();
            //barStaticItem4.Caption = System.Reflection.Assembly.GetExecutingAssembly().GetName().ToString();
            barStaticItem4.Caption = Application.ProductVersion;

            // 2019-09-09 dhkim DevExpress 스킨 적용
            Assembly asm = typeof(DevExpress.UserSkins.CRMSkin).Assembly;
            DevExpress.Skins.SkinManager.Default.RegisterAssembly(asm);

            // DocumentManager MdiParent 세팅
            documentManager1.MdiParent = this;

            // DockPanel 캡션 숨기기
            SkinElement element = SkinManager.GetSkinElement(SkinProductId.Docking, DevExpress.LookAndFeel.UserLookAndFeel.Default, "DockWindowBorder");
            element.ContentMargins.Top = -18;
            LookAndFeelHelper.ForceDefaultLookAndFeelChanged();

            this.WindowState = FormWindowState.Maximized;
        }

        // {{ 기본정보
        // 회사정보
        private void controlCompanyInfo_Click(object sender, EventArgs e)
        {
        }

        // 거래처관리
        private void controlAccountManage_Click(object sender, EventArgs e)
        {
        }

        // 현장관리
        private void controlSiteManage_Click(object sender, EventArgs e)
        {
        }

        // 시스템관리
        private void controlSystemManage_Click(object sender, EventArgs e)
        {
        }
        // }} 기본정보

        // {{ 상담관리
        // 상담등록
        private void controlCounsultAdd_Click(object sender, EventArgs e)
        {
        }

        // 상담리스트
        private void controlCounsultList_Click(object sender, EventArgs e)
        {
        }

        // 고객리스트
        private void controlCustomerList_Click(object sender, EventArgs e)
        {
        }
        // }} 상담관리

        // {{ 자산관리
        // 자산관리
        private void controlAssetManage_Click(object sender, EventArgs e)
        {
        }

        // 현장별자산설정
        private void controlSiteSetting_Click(object sender, EventArgs e)
        {

        }

        // 입출고조회
        private void controlWarehousing_Click(object sender, EventArgs e)
        {
        }
        // }} 자산관리

        // {{ 자금관리
        // 기본정보
        private void controlAccountSubject_Click(object sender, EventArgs e)
        {
        }
        // 매출 - 등록
        private void controlSales1_Click(object sender, EventArgs e)
        {
        }
        // 매출 - 전자결재
        private void controlSales2_Click(object sender, EventArgs e)
        {
        }
        // 매출 - 입금
        private void controlSales3_Click(object sender, EventArgs e)
        {
        }
        // 매출 - 조회
        private void controlSales4_Click(object sender, EventArgs e)
        {
        }
        // 매입 - 등록
        private void controlBuy1_Click(object sender, EventArgs e)
        {
        }
        // 매입 - 출금
        private void controlBuy3_Click(object sender, EventArgs e)
        {
        }
        // 매입 - 조회
        private void controlBuy4_Click(object sender, EventArgs e)
        {
        }
        // 결산 - 통장입출금
        private void controlSettlement1_Click(object sender, EventArgs e)
        {
        }
        // 결산 - 미수미지급
        private void controlSettlement2_Click(object sender, EventArgs e)
        {
        }
        // 결산 - 일계표
        private void controlSettlement3_Click(object sender, EventArgs e)
        {
        }
        // 결산 - 월자금집행계획
        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
        }
        // 결산 - 거래처별 상품 산출내역
        private void controlSettlement4_Click(object sender, EventArgs e)
        {
        }
        // 결산 - 수지항목별 조회
        private void controlSettlement5_Click(object sender, EventArgs e)
        {

        }
        // 결산 - 세금계산서
        private void controlSettlement6_Click(object sender, EventArgs e)
        {
        }

        // 출납 - 카드현금출납
        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
        }
        // 출납 - 조회
        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
        }
        // 출납 - 지출결의서
        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
        }
        // }} 자금관리


        // {{ 인사관리
        // 기본정보관리
        private void controlPersonnalBasic_Click(object sender, EventArgs e)
        {
        }
        // 급여관리
        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
        }
        //일용직급여대장
        private void accordionControlElement7_Click_1(object sender, EventArgs e)
        {
        }
        // }} 인사관리

        // {{ 견적관리
        // 견적서작성
        private void controlEstimateWrite_Click(object sender, EventArgs e)
        {
        }

        // 상품관리
        private void controlProductManage_Click(object sender, EventArgs e)
        {
        }
        // }} 견적관리









        // Form 종료
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //properties.settings.default.set_is_update = true;

           // properties.settings.default.save();
        }




        // 
        private void AddChildForm<T>() where T : Form, new()
        {
            BaseDocument baseDoc = FindBaseDocument<T>();
            Document doc = FindFloatDocument<T>();

            Debug.WriteLine("baseDoc = " + baseDoc);
            Debug.WriteLine("doc = " + doc);

            if (baseDoc == null)
            {
                if (doc == null)
                {
                    T childForm = new T();
                    childForm.MdiParent = this;
                    childForm.Show();
                }
                else
                {
                    tabbedView1.Controller.Select(doc);

                    BaseDocument baseDoc2 = FindFloatBaseDocument<T>();
                    tabbedView1.Controller.Activate(baseDoc2);
                }

            }
            else
            {
                Debug.WriteLine("Call_2");
                tabbedView1.Controller.Activate(baseDoc);
            }
        }

        private BaseDocument FindBaseDocument<T>() where T : Form
        {
            foreach (BaseDocument document in documentManager1.View.Documents)
            {
                if (document.Form is T)
                    return document;
            }
            return null;
        }

        private BaseDocument FindFloatBaseDocument<T>() where T : Form
        {
            foreach (BaseDocument document in documentManager1.View.FloatDocuments)
            {
                if (document.Form is T)
                    return document;
            }
            return null;
        }

        private Document FindDocument<T>() where T : Form
        {
            foreach (Document document in documentManager1.View.FloatDocuments)
            {
                if (document.Form is T)
                    return document;
            }
            return null;
        }

        private Document FindFloatDocument<T>() where T : Form
        {
            foreach (Document document in documentManager1.View.FloatDocuments)
            {
                if (document.Form is T)
                    return document;
            }
            return null;
        }

        private void controlBuy2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            barStaticItem3.Caption = DateTime.Now.ToString("yyyy-MM-dd tt hh:mm:ss");
        }

        private void controlGroupFund_Click(object sender, EventArgs e)
        {

        }

        private void fnSetmdGlobalVars()
        {
        }

        private void 회사정보_Click(object sender, EventArgs e)
        {
            AddChildForm<frm_회사정보>();
        }

        private void 거래처정보_Click(object sender, EventArgs e)
        {
            AddChildForm<거래처정보>();
        }

        private void 품목정보_Click(object sender, EventArgs e)
        {
            AddChildForm<frm_품목정보>();
        }

        private void 창고정보_Click(object sender, EventArgs e)
        {
            AddChildForm<frm_창고정보>();
        }

        private void 수주관리_Click(object sender, EventArgs e)
        {
            AddChildForm<frm_수주관리>();
        }

        private void 출하관리_Click(object sender, EventArgs e)
        {
            AddChildForm<frm_출하등록>();
        }

        private void 품목정보관리_Click(object sender, EventArgs e)
        {
            AddChildForm<frm_거래처별품목정보>();
        }

        private void 매출단가관리_Click(object sender, EventArgs e)
        {
            AddChildForm<frm_매출단가관리>();
        }

        private void 매출관리_Click(object sender, EventArgs e)
        {
            AddChildForm<frm_매출단가등록>();
        }

        private void 작업지시관리_Click(object sender, EventArgs e)
        {
            AddChildForm<frm_작업지시관리>();
        }

        private void 생산실적관리_Click(object sender, EventArgs e)
        {
            AddChildForm<frm_생산실적관리>();
        }

        private void 라인관리_Click(object sender, EventArgs e)
        {
            AddChildForm<frm_라인관리>();
        }
        private void 자재발주관리_Click(object sender, EventArgs e)
        {
            AddChildForm<frm_자재발주관리>();
        }

        private void 자재입고관리_Click(object sender, EventArgs e)
        {
            AddChildForm<frm_자재입고관리>();
        }

        private void 자재출고관리_Click(object sender, EventArgs e)
        {
            AddChildForm<frm_자재출고관리>();
        }

        private void 매입관리_Click(object sender, EventArgs e)
        {
            AddChildForm<frm_매입관리>();
        }

        private void 자재품목정보관리_Click(object sender, EventArgs e)
        {
            AddChildForm<frm_품목정보관리_자재>();
        }

        private void 매입단가관리_Click(object sender, EventArgs e)
        {
            AddChildForm<frm_매입단가관리>();
        }

        private void 수불장_Click(object sender, EventArgs e)
        {
            AddChildForm<frm_수불장>();
        }

        private void 창고관리_Click(object sender, EventArgs e)
        {
            AddChildForm<frm_창고관리>();
        }

        private void 기간별재고관리_Click(object sender, EventArgs e)
        {
            AddChildForm<frm_기간별재고관리>();
        }

        private void 재고관리_Click(object sender, EventArgs e)
        {
            AddChildForm<frm_재고관리>();
        }

        private void 검사표준서_Click(object sender, EventArgs e)
        {
            AddChildForm<frm_검사표준서>();
        }

        private void 고객반품처리_Click(object sender, EventArgs e)
        {
            AddChildForm<frm_고객반품처리>();
        }

        private void 수입검사관리_Click(object sender, EventArgs e)
        {
            AddChildForm<frm_수입검사관리>();
        }

        private void 입고검사관리_Click(object sender, EventArgs e)
        {
            AddChildForm<frm_입고검사관리>();
        }

        private void 사용자관리_Click(object sender, EventArgs e)
        {
            AddChildForm<frm_사용자관리>();
        }

        private void 메뉴관리_Click(object sender, EventArgs e)
        {
            AddChildForm<frm_메뉴관리 >();
        }

























        private void COMPANY_ITEMINFO_Click(object sender, EventArgs e)
        {
            AddChildForm<frm_거래처별품목정보>();
        }

        private void UnitPrice_registeration_Click(object sender, EventArgs e)
        {
            AddChildForm<frm_매출단가등록>();
        }

        private void MaterialInput_Status_Click(object sender, EventArgs e)
        {
           
        }

        private void ProductResult_Register_Click(object sender, EventArgs e)
        {
          
        }



        private void Bad_Registeration_Click(object sender, EventArgs e)
        {
            AddChildForm<frm_불량현황>();
        }

        private void NonOperation_registeration_Click(object sender, EventArgs e)
        {
            AddChildForm<frm_비가동현황>();
        }

        private void Bad_Status_Click(object sender, EventArgs e)
        {
            AddChildForm<frm_불량현황>();
        }

        private void NonOperation_Status_Click(object sender, EventArgs e)
        {
            AddChildForm<frm_비가동현황>();
        }

        private void BOM_management_Click(object sender, EventArgs e)
        {
           
        }

        private void Inventory_management_Click(object sender, EventArgs e)
        {

        }

        private void LOT_Tracking_Management_Click(object sender, EventArgs e)
        {

        }

      
    }
}

