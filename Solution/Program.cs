using System;
using System.Linq;

namespace Solution
{
    /// <summary>
    /// The 'Implementor' abstract class
    /// </summary>
    public interface IDisplay
    {
        void Display(string Text);
    }

    /// <summary>
    /// The 'ConcreteImplementor' class
    /// </summary>
    public class NormalDisplay:IDisplay
    {
        public void Display(string text)
        {
            Console.WriteLine(text);
        }
    }

    /// <summary>
    /// The 'ConcreteImplementor' class
    /// </summary>
    public class ReverseDisplay:IDisplay
    {
        public void Display(string Text)
        {
            Console.WriteLine(new String(Text.Reverse().ToArray()));
        }
    }

    /// <summary>
    /// The 'Abstraction' class
    /// </summary>
    public abstract class ReadingText
    {
        protected IDisplay display;
        public ReadingText(IDisplay display)
        {
            this.display = display;
        }
        public string Text { get; set; }
        public abstract void Display();
    }

    /// <summary>
    /// The 'RefinedAbstraction' class
    /// </summary>
    public class Windows8Reader:ReadingText
    {
        public Windows8Reader(IDisplay display):base(display)
        {

        }

        public override void Display()
        {
            display.Display("This is for Windows8Reader\n" + Text);
        }
    }

    /// <summary>
    /// The 'RefinedAbstraction' class
    /// </summary>
    public class Windows10Reader:ReadingText
    {
        public Windows10Reader(IDisplay display):base(display)
        {

        }

        public override void Display()
        {
            display.Display("This is for Windows10Reader\n" + Text);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create RefinedAbstraction
            ReadingText readingText10 = new Windows10Reader(new NormalDisplay())
            // Set ConcreteImplementor
            { Text = "Read this text for Windows10" };
            // Exercise the bridge
            readingText10.Display();

            ReadingText readingText8 = new Windows8Reader(new NormalDisplay()) { Text = "Read this text for Windows10" };
            readingText8.Display();

            //ReadingText readingText10R = new Windows10Reader(new ReverseDisplay()) { Text = "Read this text for Windows10" };
            //readingText10R.Display();

            //ReadingText readingText8R = new Windows8Reader(new ReverseDisplay()) { Text = "Read this text for Windows10" };
            //readingText8R.Display();


            Console.Read();
        }
    }
}
