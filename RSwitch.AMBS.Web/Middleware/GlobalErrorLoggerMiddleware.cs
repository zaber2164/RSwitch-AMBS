using System.Net;
using RSwitch.AMBS.Utility.Exceptions;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RSwitch.AMBS.Model;
using RSwitch.AMBS.Model.DTO;

namespace RSwitch.AMBS.Web.Middleware
{
    public class GlobalErrorLoggerMiddleware
    {
        private readonly RequestDelegate _next;

        public GlobalErrorLoggerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (NotFoundException ex)
            {
                await HandleNotFoundExceptionAsync(context, ex);
            }
            catch (ShowErrorMessage ex)
            {
                await HandleShowErrorMessageAsync(context, ex);
            }
            catch (ArgumentNullReferenceException ex)
            {
                await HandleArgumentNullReferenceExceptionAsync(context, ex);
            }
            catch (Exception e)
            {
                await HandleExceptionAsync(context, e);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            //Log.Error(ex, context.Request.GetDisplayUrl());
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            var x = ex.GetType().ToString();
            switch (ex.GetType().ToString())
            {
                case "System.Reflection.AmbiguousMatchException":
                    context.Response.StatusCode = (int)HttpStatusCode.Ambiguous;
                    break;
            }
            var error = new ErrorResponseDTO()
            {
                Error = ex.InnerException != null ? $"An error occurred. Please contact with system admin. Error Message: {ex.InnerException?.Message}" :
                //ex.Message != string.Empty ? $"An error occurred..... Please contact with system admin. Error Message: {ex.Message}" :
                ex.Message != string.Empty ? $"{ex.Message}" :
                $"An error occurred. Please contact with system admin."
            };
            Console.WriteLine(error);
            //test an app factory call from here to log into db
            //var res = factory.GetLoanApplicationByIdAsync(5);

            return context.Response.WriteAsync(JsonConvert.SerializeObject(error, new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            }).ToString());
        }

        private Task HandleNotFoundExceptionAsync(HttpContext context, Exception ex)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.NotFound;
            var error = new ErrorResponseDTO()
            {
                Error = ex.Message.TrimEnd('\n')
            };

            return context.Response.WriteAsync(JsonConvert.SerializeObject(error, new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            }).ToString());
        }
        private Task HandleShowErrorMessageAsync(HttpContext context, Exception ex)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.UnprocessableEntity;
            var error = new ErrorResponseDTO()
            {
                Error = ex.Message.TrimEnd('\n')
            };

            return context.Response.WriteAsync(JsonConvert.SerializeObject(error, new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            }).ToString());
        }

        private Task HandleArgumentNullReferenceExceptionAsync(HttpContext context, Exception ex)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            var error = new ErrorResponseDTO()
            {
                Error = ex.Message.TrimEnd('\n')
            };

            return context.Response.WriteAsync(JsonConvert.SerializeObject(error, new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            }).ToString());
        }
    }
}
