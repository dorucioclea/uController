#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:3.0.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

[assembly: Microsoft.AspNetCore.Routing.EndpointRouteProviderAttribute(typeof(Samples.MyHandler_Generated))]

namespace Samples
{
    public class MyHandler_Generated : Microsoft.AspNetCore.Routing.IEndpointRouteProvider
    {
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public async System.Threading.Tasks.Task Get(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            var handler = new Samples.MyHandler();
            var context = httpContext;
            await handler.Get(context);
        }
        
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public async System.Threading.Tasks.Task Blah(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            var handler = new Samples.MyHandler();
            var result = handler.Blah();
            await new uController.ObjectResult(result).ExecuteAsync(httpContext);
        }
        
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public async System.Threading.Tasks.Task StatusCode(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            var handler = new Samples.MyHandler();
            var statusValue = httpContext.Request.RouteValues["status"]?.ToString();
            System.Int32 status = default;
            if (statusValue == null || !System.Int32.TryParse(statusValue, out status))
            {
                status = default;
            }
            var result = handler.StatusCode(status);
            await result.ExecuteAsync(httpContext);
        }
        
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public async System.Threading.Tasks.Task SlowTaskStatusCode(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            var handler = new Samples.MyHandler();
            var result = await handler.SlowTaskStatusCode();
            await result.ExecuteAsync(httpContext);
        }
        
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public async System.Threading.Tasks.Task FastValueTaskStatusCode(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            var handler = new Samples.MyHandler();
            var loggerFactory = httpContext.RequestServices.GetRequiredService<Microsoft.Extensions.Logging.ILoggerFactory>();
            var result = await handler.FastValueTaskStatusCode(loggerFactory);
            await result.ExecuteAsync(httpContext);
        }
        
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public async System.Threading.Tasks.Task DoAsync(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            var handler = new Samples.MyHandler();
            var context = httpContext;
            var q = httpContext.Request.Query["q"].ToString();
            await handler.DoAsync(context, q);
        }
        
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public async System.Threading.Tasks.Task HelloDavid(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            var handler = new Samples.MyHandler();
            var result = handler.HelloDavid();
            await new uController.ObjectResult(result).ExecuteAsync(httpContext);
        }
        
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public async System.Threading.Tasks.Task GetAsync(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            var handler = new Samples.MyHandler();
            var name = httpContext.Request.RouteValues["name"]?.ToString();
            var result = await handler.GetAsync(name);
            await new uController.ObjectResult(result).ExecuteAsync(httpContext);
        }
        
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public async System.Threading.Tasks.Task Hello(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            var handler = new Samples.MyHandler();
            var formCollection = await httpContext.Request.ReadFormAsync();
            var s = formCollection["foo"].ToString();
            var id = httpContext.Request.Headers["X-Id"].ToString();
            var pageValue = httpContext.Request.Query["page"].ToString();
            System.Nullable<System.Int32> page = default;
            if (pageValue != null && System.Int32.TryParse(pageValue, out var pageTemp))
            {
                page = pageTemp;
            }
            var pageSizeValue = httpContext.Request.Query["pageSize"].ToString();
            System.Nullable<System.Int32> pageSize = default;
            if (pageSizeValue != null && System.Int32.TryParse(pageSizeValue, out var pageSizeTemp))
            {
                pageSize = pageSizeTemp;
            }
            var result = handler.Hello(s, id, page, pageSize);
            await new uController.ObjectResult(result).ExecuteAsync(httpContext);
        }
        
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public async System.Threading.Tasks.Task Post(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            var handler = new Samples.MyHandler();
            var reader = httpContext.RequestServices.GetRequiredService<uController.IHttpRequestReader>();
            var obj = (System.Text.Json.JsonElement)await reader.ReadAsync(httpContext, typeof(System.Text.Json.JsonElement));
            var result = handler.Post(obj);
            await result.ExecuteAsync(httpContext);
        }
        
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public async System.Threading.Tasks.Task PostAForm(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            var handler = new Samples.MyHandler();
            var form = await httpContext.Request.ReadFormAsync();
            handler.PostAForm(form);
        }
        
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public async System.Threading.Tasks.Task Authed(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            var handler = new Samples.MyHandler();
            handler.Authed();
        }
        
        void Microsoft.AspNetCore.Routing.IEndpointRouteProvider.MapRoutes(Microsoft.AspNetCore.Routing.IEndpointRouteBuilder routes)
        {
            routes.Map("/", Get).WithMetadata(new uController.HttpGetAttribute());
            routes.Map("/blah", Blah).WithMetadata(new uController.HttpGetAttribute());
            routes.Map("/status/{status}", StatusCode).WithMetadata(new uController.HttpGetAttribute());
            routes.Map("/slow/status/{status}", SlowTaskStatusCode).WithMetadata(new uController.HttpGetAttribute());
            routes.Map("/fast/status/{status}", FastValueTaskStatusCode).WithMetadata(new uController.HttpGetAttribute());
            routes.Map("/lag", DoAsync).WithMetadata(new uController.HttpGetAttribute());
            routes.Map("/hey/david", HelloDavid).WithMetadata(new uController.HttpGetAttribute());
            routes.Map("/hey/{name?}", GetAsync).WithMetadata(new uController.HttpGetAttribute());
            routes.Map("/hello", Hello).WithMetadata(new uController.HttpGetAttribute());
            routes.Map("/", Post).WithMetadata(new uController.HttpPostAttribute());
            routes.Map("/post-form", PostAForm).WithMetadata(new uController.HttpPostAttribute());
            routes.Map("/auth", Authed).WithMetadata(new uController.HttpGetAttribute(), new Microsoft.AspNetCore.Authorization.AuthorizeAttribute());
        }
    }
}
