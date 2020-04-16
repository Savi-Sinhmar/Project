using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Core.Domain.Users;
using Services.Friends;

namespace Web.Components
{
    public class SuggestedFriendsViewComponent: ViewComponent
    {
        private readonly IFriendService _friendService;

        public SuggestedFriendsViewComponent(IFriendService friendService, UserManager<User> userManager)
        {
            _friendService = friendService;
        }

        public async Task<IViewComponentResult> InvokeAsync()    
        {
            return View(await _friendService.GetSuggestedFriendsAsync());
        }
    }
}