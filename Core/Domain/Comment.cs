using System;
using Core.Domain.Posts;
using Core.Domain.Users;

namespace Core.Domain.Comments
{
    public class Comment :EntityBase
    {
        public User CommentBy { get; set; }
        
        public string CommentById { get; set; }

        public Post Post { get; set; }

        public int PostId { get; set; }

        public string Content { get; set; }    
        
        public DateTime CreatedOn { get;  private set; } = DateTime.Now;
        
    }
}