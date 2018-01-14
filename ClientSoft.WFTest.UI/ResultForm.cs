using System;
using System.Collections.Generic;
using System.Windows.Forms;

using ClientSoft.WFTest.Models;
using ClientSoft.WFTest.Presentation.Views;

namespace ClientSoft.WFTest.UI
{
    public partial class ResultForm : Form, IResultView
    {
        private readonly ApplicationContext _appContext;

        public ResultForm(ApplicationContext appContext)
        {
            _appContext
                = appContext ?? throw new ArgumentNullException(nameof(appContext));

            InitializeComponent();
        }


        void IView.Show()
        {
            _appContext.MainForm = this;
            Application.Run(_appContext);
        }

        public event EventHandler StartDownload;

        public List<User> Users
        {
            set => value.ForEach(
                user => usersGrid.Rows.Add(new object[] { user.GetImage(), user.FullName }));
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            StartDownload?.Invoke(this, EventArgs.Empty);
        }
    }
}