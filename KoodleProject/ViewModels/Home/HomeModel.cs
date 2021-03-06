﻿using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Web.ViewModels.Home
{
    public class HomeModel
    {
        [Required]
        public string Content { get; set; }

        public IFormFileCollection Files { get; set; }

        public string UserProfilePicture { get; set; }

        public bool PostLoadMore { get; set; }
        
    }
}