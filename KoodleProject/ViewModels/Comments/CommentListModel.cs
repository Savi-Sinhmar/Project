using System.Collections.Generic;
using Core.Domain.Comments;

namespace Web.ViewModels.Comments
{
    public class CommentViewModel
    {
        public IEnumerable<Comment> Comments{ get; set; }

        public int PostId { get; set; }

        public bool LoadMore { get; set; }
    }
}