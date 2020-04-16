using System;
using Core.Domain.Friends;
using Core.Repository;
using Data.EfContext;

namespace Data.Repository
{
    public class FriendRepository : Repository<Friend>, IFriendRepository
    {
        public FriendRepository(KoodleDbContext context) 
            : base(context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }
        }
    }
}