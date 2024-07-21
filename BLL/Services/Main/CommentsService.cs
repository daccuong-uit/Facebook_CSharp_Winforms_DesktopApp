using DAL.Models.Main;
using DAL.Repositories.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BLL.Services.Main
{
    public class CommentsService
    {
        private readonly CommentsRepository commentsRepository; 
        public CommentsService()
        {
            commentsRepository = new CommentsRepository();
        }

        public CommentsDto ConvertToDtoPost(Comments comments)
        {
            CommentsDto commentsDto = new CommentsDto();
            commentsDto.CommentId = comments.CommentId;
            commentsDto.PostId = comments.PostId;
            commentsDto.UserCommentId = comments.UserCommentId;
            commentsDto.Content = comments.Content;
            commentsDto.CreatedAt = comments.CreatedAt;

            return commentsDto;
        }
        public Comments ConvertToBllPost(CommentsDto commentsDto)
        {
            Comments comments = new Comments();
            comments.CommentId = commentsDto.CommentId;
            comments.PostId = commentsDto.PostId;
            comments.UserCommentId = commentsDto.UserCommentId;
            comments.Content = commentsDto.Content;
            comments.CreatedAt = commentsDto.CreatedAt;

            return comments;
        }
        public void CreateComment(int postId, int userCommentId, string content)
        {
            commentsRepository.CreateComment(postId, userCommentId, content);
        }
        public List<CommentsDto> GetCommentsByPostId(int postId, int offset = 0, int limit = 1000)
        {
            List<Comments> comments = commentsRepository.GetCommentsByPostId(postId, offset, limit);
            List<CommentsDto> commentsDto = new List<CommentsDto>();
            foreach (Comments comment in comments)
            {
                commentsDto.Add(ConvertToDtoPost(comment));
            }

            return commentsDto;
        }
        public void UpdateComment(int commentId, string newComment)
        {
            commentsRepository.UpdateComment(commentId, newComment);
        }
        public void DeleteComment(int commentId)
        {
            commentsRepository.DeleteComment(commentId);
        }
        public int GetMaxCommentId()
        {
            return commentsRepository.GetMaxCommentId();
        }
    }
}
