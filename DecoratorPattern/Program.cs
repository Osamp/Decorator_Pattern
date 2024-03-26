using System;
using DecoratorPatternApp.Components;
using DecoratorPatternApp.Decorators;

namespace DecoratorPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
    
            IComponent<string> concreteComponent = new ConcreteComponent();

            var plainDecorator = new PlainDecorator(concreteComponent);
            var colorDecorator = new ColorDecorator(concreteComponent);
            var upperCaseDecorator = new UpperCaseDecorator(concreteComponent);

            Console.WriteLine(plainDecorator.GetText());

            Console.WriteLine(colorDecorator.GetText());

            Console.WriteLine(upperCaseDecorator.GetText());
        }
    }
}
