using System.Text;

namespace HtmlEditor
{
    public class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("EDITOR MODE");
            Console.WriteLine("---------------------------");
            Start();
        }
        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            }
            while(Console.ReadKey().Key != ConsoleKey.Escape);
            Console.WriteLine("---------------------------");
            Console.WriteLine("Would you like to save this file?");
            Viewer.Show(file.ToString());
        }
    }
}