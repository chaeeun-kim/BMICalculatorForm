using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
///-----------------------------------------------------------------------------------------------------------------------------------
///   Author's name:  chaeeun kim
///   Author's student number: 301060073
///   Date last modified :2020,8,2
///   Program Description: this program will calculate BMI based on user inputs   
///-----------------------------------------------------------------------------------------------------------------------------------

namespace BMICalculatorForm
{
    public static class Program
    {
        public static SplashForm splashform;
        public static BMICalculatorForm bmicalculatorform;

        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            splashform = new SplashForm();
            bmicalculatorform = new BMICalculatorForm();

            Application.Run(splashform);
        }
    }
}
