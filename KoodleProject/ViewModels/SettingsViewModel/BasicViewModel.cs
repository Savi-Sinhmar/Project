using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Core.Helpers;

namespace Web.ViewModels.SettingsViewModel
{
    public class BasicViewModel
    {
        [Required] public string UserName { get; set; }

        [Required] public string FirstName { get; set; }

        [Required] public string LastName { get; set; }

        [Required] [EmailAddress] public string Email { get; set; }
        
        public string Description { get; set; }

        public string Lives { get; set; }

        public string From { get; set; }

        public string WorkAt { get; set; }

        public IFormFile ProfilePicture { get; set; }
        
        public IFormFile ProfileCoverPicture { get; set; }

        public string ProfilePictureUrl { get; set; }

        public string ProfileCoverPictureUrl { get; set; }
        
        public string GetPicture()    
        {
            return ProfilePictureUrl ?? $"/assets/images/avatars/user_icon.png";
        }


        public string GetCoverPicture()
        {
            return ProfileCoverPictureUrl ?? "/assets/images/no-profile-cover.jpg";
        }
    }
}