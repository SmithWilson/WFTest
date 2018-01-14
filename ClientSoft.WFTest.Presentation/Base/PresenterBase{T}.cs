using System;

using ClientSoft.WFTest.Presentation.Views;

namespace ClientSoft.WFTest.Presentation.Base
{
    public abstract class PresenterBase<T> : IPresenter where T : class, IView
    {
        protected T _view;

        public PresenterBase(T view)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
        }

        public virtual void Run()
        {
            _view.Show();
        }
    }
}