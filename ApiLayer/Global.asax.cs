using System.Web;
using System.Web.Http;
using AutoMapper;
using BLL.DTOs;

namespace ApiLayer
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            Mapper.Initialize(cfg => cfg.AddProfile<MapperConfig>());
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}