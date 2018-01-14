using System;
using System.Collections.Generic;

using ClientSoft.WFTest.Models;
using ClientSoft.WFTest.Presentation.Base;
using ClientSoft.WFTest.Presentation.Views;

namespace ClientSoft.WFTest.Presentation.Presenters
{
    public class ResultPresenter : PresenterBase<IResultView>
    {
        public ResultPresenter(IResultView view) : base(view)
        {
            view.StartDownload += View_StartDownload;
        }

        private void View_StartDownload(object sender, EventArgs e)
        {
            _view.Users = new List<User>
            {
                new User
                {
                    FirstName = "Кирилл",
                    LastName = "Москалёв",
                    Photo100 = "https://pp.userapi.com/c625129/v625129552/604f1/lIITdL6Ovr0.jpg"
                },
                new User
                {
                    FirstName = "Arthur",
                    LastName = "Irgashev",
                    Photo100 = "https://pp.userapi.com/c637422/v637422174/21ef9/pAY1-4rMX_E.jpg"
                },
                new User
                {
                    FirstName = "Артемий",
                    LastName = "Морозов",
                    Photo100 = "https://pp.userapi.com/c836330/v836330324/46a78/n8zibQret8A.jpg"
                }
            };
        }
    }
}