using System;
using System.Collections.Generic;

using ClientSoft.WFTest.Models;

namespace ClientSoft.WFTest.Presentation.Views
{
    public interface IResultView : IView
    {
        List<User> Users { set; }

        event EventHandler StartDownload;
    }
}