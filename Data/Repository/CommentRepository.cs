using System;
using Core.Domain.Comments;
using Core.Repository;
using Data.EfContext;

namespace Data.Repository
{
    public class CommentRepository :Repository<Comment>,ICommentRepository
    {
        public CommentRepository(KoodleDbContext context) : base(context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

        }
    }
}