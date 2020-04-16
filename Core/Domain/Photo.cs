using System;
using Core.Domain.Posts;

namespace Core.Domain.Photos
{
    public class Photo : EntityBase
    {
        public string FileName { get; set; }

        public Post Post { get; set; }

        public int PostId { get; set; }
        
        public DateTime CreatedOn { get; set; }
    }
}