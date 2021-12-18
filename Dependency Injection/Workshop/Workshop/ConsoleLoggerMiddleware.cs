using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace Workshop
{
    class ConsoleLoggerMiddleware : IMiddleware
    {
        public Printer Printer { get; }
        public IColor Color { get; set; }

        public ConsoleLoggerMiddleware(Printer Printer)
        {
            this.Printer = Printer;
        }

        public ConsoleLoggerMiddleware(IColor Color)
        {
            this.Color = Color;
        }

        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {

            Printer.Log("hello");

            Color.PrintColor();

            Console.WriteLine("Hi from the middleware");

            return next(context);
        }             
    }
}
