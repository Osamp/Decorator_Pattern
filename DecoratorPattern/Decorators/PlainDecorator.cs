
using DecoratorPatternApp.Components;

namespace DecoratorPatternApp.Decorators
{
    public class PlainDecorator : Decorator<string>
    {
        
        public PlainDecorator(IComponent<string> component) : base(component)
        {
            
        }

        public override string GetText()
        {
        
            return "Mr Yaw Gyeni Sampong " + base.GetText();
        }
    }
}
