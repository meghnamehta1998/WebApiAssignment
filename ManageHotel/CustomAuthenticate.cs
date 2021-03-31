using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Http.Controllers;

namespace ManageHotel
{
    public class CustomAuthenticate: System.Web.Http.Filters.ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            if (actionContext.Request.Headers.Authorization == null)
            {
                actionContext.Response = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized);
            }
            else
            {
                string token = actionContext.Request.Headers.Authorization.Parameter;
                string tokenDecode = Encoding.UTF8.GetString(Convert.FromBase64String(token));
                string username = tokenDecode.Substring(0, tokenDecode.IndexOf(":"));
                string passwd = tokenDecode.Substring(tokenDecode.IndexOf(":") + 1);
                if (username == "admin" && passwd == "admin")
                { }
                else
                {
                    actionContext.Response = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized);
                }
            }
        }
    }
}