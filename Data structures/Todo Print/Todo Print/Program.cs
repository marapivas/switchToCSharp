using System;
using System.Text;

namespace TodoPrint
{
    public class TodoPrint
    {
        public static void Main(string[] args)
        {
            string todoText = " - Buy milk\n";
            // Add "My todo:" to the beginning of the `todoText`
            // Add " - Download games" to the end of the `todoText`
            // Add " - Diablo" to the end of the `todoText` applying indentation

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("My todo");
            sb.Append(todoText);
            sb.Append(" - Download games\n      - Diablo");

            todoText = sb.ToString();

            Console.WriteLine(todoText);
        }
    }
}