using Microsoft.AspNetCore.Mvc.Filters;

namespace MyApi.FilterAttribute
{
    public class JbExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            base.OnException(context);
        }
        public override Task OnExceptionAsync(ExceptionContext context)
        {
            return base.OnExceptionAsync(context);
        }
    }
}
