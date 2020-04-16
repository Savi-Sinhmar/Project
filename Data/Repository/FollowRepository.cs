using System;
using Core.Domain.Follows;
using Core.Repository;
using Data.EfContext;

namespace Data.Repository
{
    public class FollowRepository: Repository<Follow> , IFollowRepository
    {
        public FollowRepository(KoodleDbContext context)
            : base(context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }
        }
    }
}