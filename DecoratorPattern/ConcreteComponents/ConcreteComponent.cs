
using DecoratorPatternApp.Components;

namespace DecoratorPatternApp.Components
{
    public class ConcreteComponent : IComponent<string>
    {
        public string GetText()
        {
            return "I miss you daddy.";
        }
    }
}
