using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Core.Domain.Photos;

namespace Services.Photos
{
    public interface IPhotoService
    {
        Task UploadAsync(IFormFileCollection files, int postId);

        Task<string> UploadAsync(IFormFile file);

        Task<IEnumerable<Photo>> GetUserPhotosAsync(string userId);

        Task<int> GetUserTotalPhotosAsync(string userId);

        void RemovePhotoFromDisk(string profilePictureUrl);
    }
}