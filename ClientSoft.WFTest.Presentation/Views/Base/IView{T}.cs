namespace ClientSoft.WFTest.Presentation.Views
{
    public interface IView<T> : IViewBase
    {
        void Show(T args);
    }
}
