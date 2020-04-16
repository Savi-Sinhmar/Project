using System;
using Core.Domain.Posts;
using Core.Repository;
using Data.EfContext;

namespace Data.Repository
{
    public class PostRepository : Repository<Post>, IPostRepository
    {
        public PostRepository(KoodleDbContext context) 
            : base(context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }
        }
    }
}