using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Core.Domain.Notifications;
using Core.Extensions;
using Core.Repository;
using Services.ViewRender;

namespace Services.Notifications
{
    public class NotificationService : INotificationService
    {
        private readonly IViewRenderService _renderService;
        private readonly IRepository<Notification> _notificationRepository;

        public NotificationService(IRepository<Notification> notificationRepository, IViewRenderService renderService)
        {
            _notificationRepository = notificationRepository;
            _renderService = renderService;
        }

        public async Task<Notification> GetNotificationAsync(string recipientId, string senderId, NotificationType type)
        {
            return await _notificationRepository.Table.FirstOrDefaultAsync(n =>
                n.RecipientId == recipientId && n.SenderId == senderId && n.Type == type);
        }

        public async Task<Notification> GetNotificationByIdAsync(int id)
        {
            return await _notificationRepository.Table.FirstOrDefaultAsync(n => n.Id == id);
        }

        public bool ShouldNotificationLoadMore(string userId)
        {
            var query = GetNotificationsByRecipientId(userId);

            return query.ShouldEnableLoadMore();
        }

        public async Task MarkAllAsReadAsync(string userId)
        {
            var notifications = await GetNotificationsByRecipientId(userId).ToListAsync();

            foreach (var notification in notifications)
            {
                notification.IsRead = true;
            }
        }

        public async Task<(IEnumerable<Notification> notifications, bool loadMore)> GetPagedNotificationsAsync(string userId,
            int pageIndex = 1, int pageSize = 10)
        {
            var query = _notificationRepository.Table
                .Include(n => n.Attributes)
                .Where(n => n.RecipientId == userId);

            var loadMore = query.ShouldEnableLoadMore(pageIndex, pageSize);

            query = query.OrderByDescending(n => n.CreatedOn);

            query = query.ApplyingPagination(pageIndex, pageSize);

            return (await query.ToListAsync(), loadMore);
        }

        public void RemoveNotification(Notification notification)
        {
            _notificationRepository.Remove(notification);
        }

        public async Task PushNotification(string recipientId, int notificationId)
        {
            var model = await GetNotificationByIdAsync(notificationId);

            var totalNotifications = await GetTotalUnReadNotificationsAsync(recipientId);
            
            var notification = await _renderService.RenderViewToStringAsync("Templates/_MiniNotification", model);  

           
        }


        public async Task<int> GetTotalUnReadNotificationsAsync(string recipientId)
        {
            return await  _notificationRepository.Table.Where(n => n.RecipientId == recipientId && !n.IsRead).CountAsync();
        }

        private IQueryable<Notification> GetNotificationsByRecipientId(string recipientId)
        {
            return _notificationRepository.Table
                .Where(n => n.RecipientId == recipientId);
        }
    }
}