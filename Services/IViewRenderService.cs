using System.Threading.Tasks;

namespace Services.ViewRender
{
    public interface IViewRenderService
    {
        Task<string> RenderViewToStringAsync(string viewName, object model);
    }
}