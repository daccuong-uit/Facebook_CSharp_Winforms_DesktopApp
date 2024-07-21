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
    public class LikeLoveService
    {
        private readonly LikeLoveRepository likeLoveRepository;
        public LikeLoveService()
        {
            likeLoveRepository = new LikeLoveRepository();
        }
        public LikeLoveDto ConvertToDtoLikeLove(LikeLove likeLove)
        {
            LikeLoveDto likeLoveDto = new LikeLoveDto();
            likeLoveDto.LikeId = likeLove.LikeId;
            likeLoveDto.PostId = likeLove.PostId;
            likeLoveDto.UserLikeId = likeLove.UserLikeId;
            likeLoveDto.Content = likeLove.Content;

            return likeLoveDto;
        }

        public LikeLove ConvertToBllLikeLove(LikeLoveDto likeLoveDto)
        {
            LikeLove likeLove = new LikeLove();
            likeLove.LikeId = likeLoveDto.LikeId;
            likeLove.PostId = likeLoveDto.PostId;
            likeLove.UserLikeId = likeLoveDto.UserLikeId;
            likeLove.Content = likeLoveDto.Content;

            return likeLove;
        }

        public void CreateLikeLove(int postId, int userLiketId, int content)
        {
            likeLoveRepository.CreateLikeLove(postId, userLiketId, content);
        }

        public List<LikeLoveDto> GetLikeLoveByPostId(int postId)
        {
            List<LikeLove> likeloves = likeLoveRepository.GetLikeLoveByPostId(postId);
            List<LikeLoveDto> likeLoveDtos = new List<LikeLoveDto>();

            foreach (LikeLove likelove in likeloves)
            {
                likeLoveDtos.Add(ConvertToDtoLikeLove(likelove));
            }

            return likeLoveDtos;
        }

        public void UpdateLikeLove(int likeId, int newContent)
        {
            likeLoveRepository.UpdateLikeLove(likeId, newContent);
        }

        public void DeleteLikeLove(int likeId)
        {
            likeLoveRepository.DeleteLikeLove(likeId);
        }
        public int GetLikeIdByUserLikeIdAndPostId(int userId, int postId)
        {
            return likeLoveRepository.GetLikeIdByUserLikeIdAndPostId(userId, postId);
        }
    }
}
