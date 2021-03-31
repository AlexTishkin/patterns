namespace Mediator
{
    public class Checkbox : Component
    {
        public bool Value { get; set; }

        public Checkbox(string title, IMediator mediator) : base(title, mediator) { }

        public override void Click()
        {
            Value = !Value;
            base.Click();
        }
    }

}
