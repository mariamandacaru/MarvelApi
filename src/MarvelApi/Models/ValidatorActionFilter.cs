using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MarvelApi.Models
{
    public class ValidatorActionFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (!filterContext.ModelState.IsValid)
            {
                filterContext.Result = new ConflictObjectResult(filterContext.ModelState);
            }
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            
        }
    }
}
