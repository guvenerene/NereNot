using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NereNot
{
    static class Program
    {
        public static string NotifyConnStr = @"Server=ERENGUVEN\ERENGUVEN;Database=Nere_NOT;User ID=Nere;Password=Nere";
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
