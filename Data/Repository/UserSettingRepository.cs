using System;
using Core.Domain.Users;
using Core.Repository;
using Data.EfContext;

namespace Data.Repository
{
    public class UserSettingRepository : Repository<UserSetting>, IUserSettingRepository
    {
        public UserSettingRepository(KoodleDbContext context) 
            : base(context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }
        }
    }
}