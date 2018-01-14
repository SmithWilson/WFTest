using ClientSoft.WFTest.Presentation.Views;

using Unity;

namespace ClientSoft.WFTest.UI
{
    public static class DependencyInjection
    {
        public static IUnityContainer RegisterUILayer(this IUnityContainer container)
        {
            return container
                .RegisterType<IResultView, ResultForm>();
        }
    }
}