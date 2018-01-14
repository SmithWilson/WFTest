using System;

using ClientSoft.WFTest.Presentation.Views;

namespace ClientSoft.WFTest.Presentation.Base
{
    public abstract class PresenterBase<T, V> : IPresenter<V> where T : class, IView<V>
    {
        protected T _view;

        public PresenterBase(T view)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
        }

        public virtual void Run(V args)
        {
            _view.Show(args);
        }
    }
}