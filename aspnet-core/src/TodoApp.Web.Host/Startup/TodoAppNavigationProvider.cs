using Abp.Application.Navigation;
using Abp.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApp.Web.Host.Startup
{
    public class TodoAppNavigationProvider: NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
            .AddItem(
                new MenuItemDefinition(
                    "Home",
                    L("HomePage"),
                    url: "",
                    icon: "fa fa-home"
                    )
            ).AddItem(
                new MenuItemDefinition(
                    "About",
                    L("About"),
                    url: "Home/About",
                    icon: "fa fa-info"
                    )
            ).AddItem(
                new MenuItemDefinition(
                    "TaskList",
                    L("TaskList"),
                    url: "Tasks",
                    icon: "fa fa-tasks"
                    )
            );
        }
        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, TodoAppConsts.LocalizationSourceName);
        }
    }
    
}
