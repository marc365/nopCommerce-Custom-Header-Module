using System;
using System.Web;

namespace Nop.Web.Extensions
{
    public class CustomHeaderModule : IHttpModule
    {
        public void Init(HttpApplication application)
        {
            application.PostReleaseRequestState += new EventHandler(application_PostReleaseRequestState);

        }

        public void Dispose()
        {
        }

        void application_PostReleaseRequestState(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Headers.Remove("Last-Modified");
            HttpContext.Current.Response.Headers.Remove("Server");
            HttpContext.Current.Response.Headers.Remove("X-AspNet-Version");
            HttpContext.Current.Response.Headers.Remove("X-AspNetMvc-Version");
            HttpContext.Current.Response.Headers.Remove("ETag");
            //    Note:
            //    X-SourceFiles Header included the base64 encoded physical path of the source files in your hard disk. This header is only sent for the request from localhost. So, there's no need to worry about removing this.
        }
    }
}