using DecoratorPatternApp.Components;

namespace DecoratorPatternApp.Decorators
{
    public class UpperCaseDecorator : Decorator<string>
    {
    
        public UpperCaseDecorator(IComponent<string> component) : base(component)
        {
            
        }

        public override string GetText()
        {
            string originalText = base.GetText();
            string upperCaseText = originalText.ToUpper();

            return upperCaseText;
        }
    }
}
