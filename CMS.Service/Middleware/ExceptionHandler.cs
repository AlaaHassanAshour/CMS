using CMS.Core.Exceptions;
using CMS.Core.ViewModel;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;

namespace CMS.Service
{
    public class ExceptionHandler
    {

        private readonly RequestDelegate _next;

        public ExceptionHandler(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var exceptionHandlerPathFeature = context.Features.Get<IExceptionHandlerPathFeature>();
            var exception = exceptionHandlerPathFeature.Error;

            var response = new APIResponseViewModel();

            switch (exception)
            {
                case InvalidUsernameException userNameNotFound:
                    response.Message = userNameNotFound.Message;
                    context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                    break;
                default:
                    response.Message = "Test";
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    break;
            }

            context.Response.ContentType = "application/json";
            await context.Response.WriteAsync(
                JsonConvert.SerializeObject(response)
            );

        }
    }
}
