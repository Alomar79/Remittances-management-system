using Remittances.Forms;
using Remittances.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remittances
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static string Salesman="Gest";
        public static EntryClass entryCls = new EntryClass();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmMain());
            Application.Run(new frmMatches());
            //Application.Run(new FRM_Users());
            //Application.Run(new frmCountries());
            //Application.Run(new FRM_Accounts());
            //Application.Run(new frmCurrency());
            //Application.Run(new DateTimeTesting());
            Application.Run(new frmEntriesProg());
        }
    }
}
