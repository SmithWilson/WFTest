using ClientSoft.WFTest.Presentation.Base;

using Unity;

namespace ClientSoft.WFTest.Presentation.Application
{
    public sealed class ApplicationController
    {
        #region Fields
        private readonly IUnityContainer _unity = new UnityContainer();
        #endregion 


        public IUnityContainer RegisterInstance<TInerface>(TInerface instance)
        {
            return _unity.RegisterInstance(instance);
        }


        public void Run<TPresenter>()
            where TPresenter : class, IPresenter
        {
            _unity.Resolve<TPresenter>().Run();
        }

        public void Run<TPresenter, TArgs>(TArgs args)
            where TPresenter : class, IPresenter<TArgs>
        {
            _unity.Resolve<TPresenter>().Run(args);
        }
    }
}