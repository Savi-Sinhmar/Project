using System;
using Core.Domain.Posts;
using Core.Domain.Users;

namespace Core.Domain.Likes
{
    public class Like : EntityBase
    {
        public Post Post { get; set; }

        public int PostId { get; set; }

        public User LikeBy { get; set; }

        public string LikeById { get; set; }

        public DateTime CreatedOn { get; set; }
        
    }
}