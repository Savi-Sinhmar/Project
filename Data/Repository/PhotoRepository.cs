using System;
using Core.Domain.Photos;
using Core.Repository;
using Data.EfContext;

namespace Data.Repository
{
    public class PhotoRepository : Repository<Photo>, IPhotoRepository
    {
        public PhotoRepository(KoodleDbContext context) : base(context)
        {
            if(context ==null) throw new ArgumentNullException(nameof(context));
        }
    }
}