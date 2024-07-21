using DAL.Models.Main;
using DAL.Repositories.Main;
using DTO.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Main
{
    public class ShareService
    {
        private readonly ShareRepository shareRepository;
        public ShareService()
        {
            shareRepository = new ShareRepository();
        }
        public ShareDto ConvertToDtoShare(Share share)
        {
            ShareDto shareDto = new ShareDto();
            shareDto.ShareId = share.ShareId;
            shareDto.PostId = share.PostId;
            shareDto.UserId = share.UserId;
            shareDto.ShareTime = share.ShareTime;

            return shareDto;
        }
        public void AddShare(int postId, int userId)
        {
            shareRepository.AddShare(postId, userId);
        }
        public void DeleteShare(int shareId)
        {
            shareRepository.DeleteShare(shareId);
        }
        public void UpdateShare(int shareId, int postId, int userId)
        {
            shareRepository.UpdateShare(shareId, postId, userId);
        }
        public List<ShareDto> GetAllShares()
        {
            List<Share> shares = shareRepository.GetAllShares();
            List<ShareDto> sharesDto = new List<ShareDto>();
            foreach (Share share in shares)
            {
                sharesDto.Add(ConvertToDtoShare(share));
            }

            return sharesDto;
        }
        public List<ShareDto> GetSharesByUserId(int userId)
        {
            List<Share> shares = shareRepository.GetSharesByUserId(userId);
            List<ShareDto> sharesDto = new List<ShareDto>();
            foreach (Share share in shares)
            {
                sharesDto.Add(ConvertToDtoShare(share));
            }

            return sharesDto;
        }
        public List<int> GetSharesPosstId(int posstId)
        {
            List<Share> shares = shareRepository.GetAllShares();
            List<int> sharesDto = new List<int>();
            foreach (Share share in shares)
            {
                if(share.PostId == posstId)
                {
                    sharesDto.Add(share.UserId);
                }
            }

            return sharesDto;
        }
    }
}
