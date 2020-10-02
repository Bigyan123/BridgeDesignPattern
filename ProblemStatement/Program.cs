using System;
using System.Linq;

namespace ProblemStatement
{
    public class ReadingApp
    {
        public string Text { get; set; }
        public virtual void Display()
        {
            Console.WriteLine(Text);
        }
        public virtual void ReverseDisplay()
        {
            Console.WriteLine(new String(Text.Reverse().ToArray()));
        }
    }
    public class Windows8App : ReadingApp
    {
        public override void Display()
        {
            Console.WriteLine("Display text in Windows 8");
            base.Display();
        }
        public override void ReverseDisplay()
        {
            Console.WriteLine("Reverse text display in windows 8".Reverse());
            base.ReverseDisplay();
        }
    }

    public class Windows10App : ReadingApp
    {
        public override void Display()
        {
            Console.WriteLine("Display in windows 10");
            base.Display();
        }

        public override void ReverseDisplay()
        {
            Console.WriteLine("Reverse display in windows 10".Reverse());
            base.ReverseDisplay();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Class initialization
            ReadingApp readingApp10 = new Windows10App() { Text = "Read this text for windows 10" };
            readingApp10.Display();
            //readingApp10.ReverseDisplay();

            ReadingApp readingApp8 = new Windows8App() { Text = "Read this text for windows 10" };
            readingApp8.Display();
            //readingApp10.ReverseDisplay();

            Console.Read();
        }
    }
}