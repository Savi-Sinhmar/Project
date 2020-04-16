using System;
using Core.Domain.Likes;
using Core.Repository;
using Data.EfContext;

namespace Data.Repository
{
    public class LikeRepository : Repository<Like>, ILikeRepository
    {
        public LikeRepository(KoodleDbContext context) : base(context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }
        }
    }
}