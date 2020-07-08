using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

using System.Diagnostics;
using System.IO;

namespace dotNetCoreWebAppMiddleware.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class CustomMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomMiddleware(RequestDelegate next)
        {
            _next = next;
        }


        public async Task Invoke(HttpContext httpContext)
        {
            using var buffer = new MemoryStream();
            var request = httpContext.Request;
            var response = httpContext.Response;
            var steam = response.Body;
            response.Body = buffer;

            await _next(httpContext);
            // request and response objects in the Invoke method which is the place to add our custom logic. 
            Debug.WriteLine($"Request content type: {httpContext.Request.Headers["Accept"]} {System.Environment.NewLine} Request path: {request.Path} {System.Environment.NewLine} {response.ContentLength ?? buffer.Length}");

            buffer.Position = 0;

            await buffer.CopyToAsync(steam);
 
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class CustomMiddlewareExtensions
    {
        public static IApplicationBuilder UseCustomMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomMiddleware>();
        }
    }
}
