using Owin;
using System.Web.Mvc;

namespace IdentitySample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //Если ASP.NET MVC приложение использует для генерации страниц только Razor, 
            //то имеет смысл убрать генератор WebForms. 
            //Иначе MVC, будет периодически проверять наличие файлов с расширениями .aspx и .ascx 
            //при поиске представления или шаблона. Это конечно небольшая экономия, 
            //но она стоит всего двух команд в начале работы приложения.
            //http://www.codehint.ru/articles/2013-02-19_razor
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine());
        }
    }
}
