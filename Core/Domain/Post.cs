using System;
using System.Collections.Generic;
using Core.Domain.Comments;
using Core.Domain.Likes;
using Core.Domain.Photos;
using Core.Domain.Users;

namespace Core.Domain.Posts
{
    public class Post : EntityBase
    {
        public string Content { get; set; }

        public User CreatedBy { get; set; }        

        public string CreatedById { get; set; }    

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public ICollection<Photo> Photos { get; set; }

        public ICollection<Comment> Comments { get; set; }
        
        public IEnumerable<Like> Likes { get; set; }

        public Post()
        {
            Photos = new List<Photo>();
            
            Comments = new List<Comment>();
            
            Likes = new List<Like>();
        }

        public bool IsForCurrentUser(string userId)
        {
            return (string.Equals(CreatedById, userId, StringComparison.CurrentCultureIgnoreCase));
        }

    }
}