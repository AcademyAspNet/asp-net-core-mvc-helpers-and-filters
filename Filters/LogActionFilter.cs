using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace AspNetCoreMvcHelpers.Filters
{
    public class LogActionFilter : IActionFilter
    {
        private Stopwatch _stopwatch;

        public void OnActionExecuting(ActionExecutingContext context)
        {
            string? actionName = context.ActionDescriptor.DisplayName;
            Console.WriteLine($"Выполняется действие '{actionName}'...");

            _stopwatch = Stopwatch.StartNew();
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            string? actionName = context.ActionDescriptor.DisplayName;
            Console.WriteLine($"Действие '{actionName}' выполнено.");

            _stopwatch.Stop();
            long ms = _stopwatch.ElapsedMilliseconds;

            Console.WriteLine($"Действие было обработано за {ms} мсек.");
        }
    }
}
