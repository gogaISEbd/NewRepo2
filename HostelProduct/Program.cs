using Controllers;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.Model;
using Unity;
using Unity.Lifetime;


namespace HostelProduct
{
    static class Program
    {
        private static IUnityContainer container = null;
        public static IUnityContainer Container
        {
            get
            {
                if (container == null)
                {
                    container = BuildUnityContainer();
                }
                return container;
            }
        }

        [STAThread]
    static void Main()
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        var container = BuildUnityContainer();
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(container.Resolve<FormEntry>());
    }

    public static IUnityContainer BuildUnityContainer()
    {
        var currentContainer = new UnityContainer();
        currentContainer.RegisterType<DbContext, HostelContext>(new
       HierarchicalLifetimeManager());
        currentContainer.RegisterType<StaffController>(new
       HierarchicalLifetimeManager());
       

        return currentContainer;
    }
    
    }
}
