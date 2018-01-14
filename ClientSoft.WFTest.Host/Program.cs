using System;
using System.Windows.Forms;

using ClientSoft.WFTest.Presentation.Application;
using ClientSoft.WFTest.Presentation.Presenters;
using ClientSoft.WFTest.UI;

namespace ClientSoft.WFTest.Host
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var appController = new ApplicationController();

            appController
                .RegisterInstance(new ApplicationContext())
                .RegisterUILayer();


            appController.Run<ResultPresenter>();
        }
    }
}