using Microsoft.AspNetCore.Http;

namespace Core.Extensions
{
    public class ExceptionMiddlewareBase
    {
#pragma warning disable CS0649 // Field 'ExceptionMiddlewareBase._next' is never assigned to, and will always have its default value null
        private RequestDelegate _next;
#pragma warning restore CS0649 // Field 'ExceptionMiddlewareBase._next' is never assigned to, and will always have its default value null

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception e)
            {
                await HandleExceptionAsync(httpContext, e);
            }
        }

        private Task HandleExceptionAsync(HttpContext httpContext, Exception e)
        {
            throw new NotImplementedException();
        }
    }
}