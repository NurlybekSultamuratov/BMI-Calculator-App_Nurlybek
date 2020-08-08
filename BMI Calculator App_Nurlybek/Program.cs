using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Name: Nurlybek Sultamuratov
/// Student number: 301103746
/// Date Last Modified 07.08.2020
/// Revision History: BMI Calculator App was created on 06.08.2020 and pushed to the Github
/// Finished coding and documenting on 07.08.2020
/// </summary>
namespace BMI_Calculator_App_Nurlybek
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BMICalculatorForm());
        }
    }
}
