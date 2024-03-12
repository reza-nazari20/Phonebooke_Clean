using ApplicationPhonebook.DataBase;
using ApplicationPhonebook.Services.AddNewContact;
using ApplicationPhonebook.Services.DeleteContact;
using ApplicationPhonebook.Services.GetListContact;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PersistencePhonebook.Context;
using System.Security.Authentication.ExtendedProtection;
using UI_winform.Forms;

namespace Phonebook.Endpoint
{
    static class Program
    {
        //تزریق وابستگی از اینترفیس به کلاس
        public static IServiceProvider ServiceProvider { get; set; }

        static void ConfigureServices()
        {
            var Services = new ServiceCollection();

            Services.AddScoped<IDataBaseContext, DatabaseContext>();
            Services.AddScoped<IAddNewContactService, AddNewContactService>();
            Services.AddScoped<IGetListContactService, GetListContactService>();
            Services.AddTransient<IDeleteContactService, DeleteContactService>();

            Services.AddDbContext<DbContext>();

            ServiceProvider = Services.BuildServiceProvider();
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConfigureServices();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var ServiceGetList = (IGetListContactService)ServiceProvider.GetService(typeof(IGetListContactService));
            var ServiceDelete =(IDeleteContactService) ServiceProvider.GetService(typeof(IDeleteContactService));

            Application.Run(new frmMain(ServiceGetList,ServiceDelete));
        }
    }
}