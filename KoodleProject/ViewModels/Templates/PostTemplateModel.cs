using System.Collections.Generic;
using Core.Domain.Posts;

namespace Web.ViewModels.Templates
{
    public class PostTemplateModel
    {
        public IEnumerable<Post> Posts{ get; set; }

        public bool LoadMore { get; set; }

    }
}