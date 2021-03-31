namespace Mediator
{
    // Общий интерфейс посредников
    public interface IMediator
    {
        void Notify(Component sender);
    }

}
