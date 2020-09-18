using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace AgrixemAPI.Controllers.Accounts
{
    public class ApiExplorerIgnores : IActionModelConvention
    {
        public void Apply(ActionModel action)
        {
            if (action.Controller.ControllerName.Equals("Media"))
            {
                action.ApiExplorer.IsVisible = false;
            }
        }
    }
}
