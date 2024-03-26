using DecoratorPatternApp.Components;

namespace DecoratorPatternApp.Decorators
{
    public class ColorDecorator : Decorator<string>
    {

        public ColorDecorator(IComponent<string> component) : base(component)
        {
    
        }
        public override string GetText()
        {
            string originalText = base.GetText();

            string coloredText = $"\u001b[31m{originalText}\u001b[0m";

            return coloredText;
        }
    }
}
