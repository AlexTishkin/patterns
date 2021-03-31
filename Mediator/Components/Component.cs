namespace Mediator
{
    public class Component
    {
        private IMediator _mediator;
        public bool IsVisible { get; set; }
        public string Title { get; set; }

        public Component(string title, IMediator mediator)
        {
            Title = title;
            _mediator = mediator;
        }

        public virtual void Click()
        {
            _mediator.Notify(this);
        }
    }

}
