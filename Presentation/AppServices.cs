using Core.Repositories;
using Core.Repositories.Interfaces;
using DatabaseContext;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    //public class AppServices
    //{
    //    private AppServices()
    //    {
    //        //var services = new ServiceCollection();
            
    //        //ApplicationDbContext context = new ApplicationDbContext();
    //        //services.AddSingleton(context);
            

    //        //services.AddScoped<ICuratorRepository, CuratorRepsoitory>();
    //        //services.AddScoped<IGroupRepository, GroupRepository>();
    //        //services.AddScoped<IStudentRepository, StudentRepository>();


    //        //ServiceProvider = services.BuildServiceProvider();
    //    }

    //    public IServiceProvider ServiceProvider { get; }

    //    private static AppServices _instance;
    //    private static readonly object _instanceLock = new object();
    //    private static AppServices GetInstance()
    //    {
    //        lock (_instanceLock)
    //        {
    //            return _instance ?? (_instance = new AppServices());
    //        }
    //    }

    //    public static AppServices Instance => _instance ?? GetInstance();
    //}
}
