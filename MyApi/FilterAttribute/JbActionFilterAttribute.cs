using Microsoft.AspNetCore.Mvc.Filters;
using System.Text.Json.Serialization;

namespace MyApi.FilterAttribute
{
    public class JbActionFilterAttribute : ActionFilterAttribute
    {
        public JbActionFilterAttribute()
        {
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("======>正在執行...." + "OnActionExecuted");
            base.OnActionExecuted(context);
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("======>正在執行...." + "OnActionExecuting");
            base.OnActionExecuting(context);
        }
        public override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            Console.WriteLine("======>正在執行...." + "OnActionExecutionAsync");
            Console.WriteLine("正在呼叫：   " + context.ActionDescriptor.DisplayName);
            foreach (var key in context.ActionArguments)
                Console.WriteLine("傳入參數：     " + key.Key + " => " + Newtonsoft.Json.JsonConvert.SerializeObject(key.Value));
            return base.OnActionExecutionAsync(context, next);
        }
        public override void OnResultExecuted(ResultExecutedContext context)
        {
            Console.WriteLine("======>正在執行...." + "OnResultExecuted");
            base.OnResultExecuted(context);
        }
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            Console.WriteLine("======>正在執行...." + "OnResultExecuting");
            base.OnResultExecuting(context);
        }
        public override Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            Console.WriteLine("======>正在執行...." + "OnResultExecutionAsync");
            return base.OnResultExecutionAsync(context, next);
        }
        public override bool IsDefaultAttribute()
        {
            Console.WriteLine("======>正在執行...." + "IsDefaultAttribute");
            return base.IsDefaultAttribute();
        }
        public override bool Match(object? obj)
        {
            Console.WriteLine("======>正在執行...." + "        public override bool Match(object? obj)\r\n");
            return base.Match(obj);
        }
    }
}
