using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Domain.Friends;
using Core.Domain.Users;

namespace Services.Friends
{
    public interface IFriendService
    {
        Task<IEnumerable<User>> GetSuggestedFriendsAsync();

        Task AddFriendRequestAsync(string requestedById, string requestedToId);

        Task<bool> FriendRequestExistsAsync(string requestedById, string requestedToId);

        Task<IEnumerable<Friend>> GetApprovedFriends();
        
        Task<IEnumerable<Friend>> GetFriendRequests();

        Task AcceptFriendRequestAsync(string requestedByUserId, string requestedToUserId);
        
        
    }
}