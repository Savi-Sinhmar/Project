using System;
using Core.Domain.Notifications;
using Core.Repository;
using Data.EfContext;

namespace Data.Repository
{
    public class NotificationRepository : Repository<Notification>, INotificationRepository
    {
        public NotificationRepository(KoodleDbContext context)
            : base(context)
        {
            if(context==null)
                throw new ArgumentNullException(nameof(context));
        }
    }
}