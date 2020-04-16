using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.Posts;
using Web.ViewModels.Comments;

namespace Web.Components
{
    public class CommentsViewComponent : ViewComponent
    {
        private readonly IPostService _postService;

        public CommentsViewComponent(IPostService postService)
        {
            _postService = postService;
        }
        // GET
        public async Task<IViewComponentResult> InvokeAsync(int postId)
        {
            var (data, loadMore) = await _postService.GetPagedCommentsByPostIdAsync(postId);
            
            return View(new CommentViewModel
            {
                Comments = data,
                LoadMore = loadMore,
                PostId = postId
            });
        }
    }
}