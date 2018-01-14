namespace ClientSoft.WFTest.Presentation.Base
{
    public interface IPresenter
    {
        void Run();
    }
    public interface IPresenter<T>
    {
        void Run(T args);
    }
}