namespace Endjin.SpecFlow.Owin.Hosting.Hooks
{
    #region Using Directives

    using System;
    using System.Configuration;
    using System.Linq;
    using System.Web.Http;

    using global::Owin;

    #endregion

    public class WebStartup
    {
        /// <summary>
        /// The method name is defined by convention
        /// </summary>
        public void Configuration(IAppBuilder app)
        {
            string staticFilePath;

            if (ConfigurationManager.AppSettings.AllKeys.Contains(ConfigurationKeys.StaticFilePath))
            {
                staticFilePath = ConfigurationManager.AppSettings[ConfigurationKeys.StaticFilePath];
            }
            else
            {
                throw new InvalidOperationException("Could not find a Static Files Path AppSettings entry for " + ConfigurationKeys.StaticFilePath);
            }

            app.UseStaticFiles(staticFilePath);

            var config = new HttpConfiguration();

            config.Routes.MapHttpRoute(
                    name: "DefaultApi",
                    routeTemplate: "api/{controller}/{id}",
                    defaults: new { id = RouteParameter.Optional });

            app.UseWebApi(config);
        }
    }
}