using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    static class Program
    {
        public static Form1 f1;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
           
        }
    }
}
