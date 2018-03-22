using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilitarios;
using CaixaEletronico.Class;
using CaixaEletronico.Base;
using CaixaEletronico.Exceptions;
using CaixaEletronico.Util;

namespace CaixaEletronicoDesktop
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
            Application.Run(new frmMenu());

        }


    }
}
