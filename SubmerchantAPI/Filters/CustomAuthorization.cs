using System;
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PAM;

namespace SubmerchantAPI.Filters
{
    public class CustomAuthorization : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext filterContext)
        {
            if (filterContext != null)
            {
                Microsoft.Extensions.Primitives.StringValues tokens;
                filterContext.HttpContext.Request.Headers.TryGetValue("Authorization", out tokens);

                var _token = tokens.FirstOrDefault();
                if (_token != null)
                {
                    string bearerToken = _token.Split(" ").LastOrDefault();
                    if (bearerToken != null)
                    {
                        if (IsValidToken(bearerToken))
                        {
                            filterContext.HttpContext.Response.Headers.Add("bearerToken", bearerToken);
                            filterContext.HttpContext.Response.Headers.Add("BearerStatus", "Authorized");
                            filterContext.HttpContext.Response.Headers.Add("storeAccessiblity", "Authorized");
                            return;
                        }
                        else
                        {
                            filterContext.HttpContext.Response.Headers.Add("bearerToken", bearerToken);
                            filterContext.HttpContext.Response.Headers.Add("BearerStatus", "NotAuthorized");
                            filterContext.HttpContext.Response.StatusCode = (int)HttpStatusCode.Forbidden;
                            filterContext.HttpContext.Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = "Not Authorized";
                            filterContext.Result = new JsonResult("NotAuthorized")
                            {
                                Value = new
                                {
                                    Status = "Error",
                                    Message = "Invalid Token"
                                },
                            };
                        }
                    }
                }
                else
                {
                    filterContext.HttpContext.Response.StatusCode = (int)HttpStatusCode.ExpectationFailed;
                    filterContext.HttpContext.Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = "Please Provide bearerToken";
                    filterContext.Result = new JsonResult("Please Provide bearerToken")
                    {
                        Value = new
                        {
                            Status = "Error",
                            Message = "Please Provide bearerToken"
                        },
                    };
                }
            }
        }

        private bool IsValidToken(string authToken)
        {
            IdentityService identityService = new IdentityServiceClient();
            //PAM ValidateTokenAsync method has to be changed , it has to return boolean value instead of xml as string
            //incase of invalid token it should return false
            var result = identityService.ValidateTokenAsync(authToken).GetAwaiter().GetResult();
            //should return pam service response as a boolean value
            //return result;
            return true;
        }
    }
}