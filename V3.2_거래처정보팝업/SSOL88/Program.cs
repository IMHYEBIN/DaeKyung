using CRM_WMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSOL88
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Splash screens and wait forms created with the help of the SplashScreenManager component run in a separate thread.  
            // Information on custom skins registered in the main thread is not available in the splash screen thread  
            // until you call the SplashScreenManager.RegisterUserSkins method.  
            // To provide information on custom skins to the splash screen thread, uncomment the following line. 
            //SplashScreenManager.RegisterUserSkins(asm);  

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }

        // Recommended code for design-time skin initialization.  
        // In Visual Studio 2012 and higher, add the following code to your project  
        // to ensure that your custom skin assembly is loaded and that the custom skin is registered at design time.  
        public class SkinRegistration : Component
        {
            public SkinRegistration()
            {
                DevExpress.Skins.SkinManager.Default.RegisterAssembly(typeof(DevExpress.UserSkins.CRMSkin).Assembly);
            }
        }
    }
}
