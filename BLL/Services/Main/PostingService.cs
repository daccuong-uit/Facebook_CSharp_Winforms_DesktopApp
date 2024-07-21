using DAL.Models;
using DAL.Models.Main;
using DAL.Repositories;
using DAL.Repositories.Main;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Main
{
    public class PostingService
    {
        private readonly PostingRepository postingRepository;

        public PostingService()
        {
            postingRepository = new PostingRepository();
        }
        public PostingDto ConvertToDtoPost(Posting posting)
        {
            PostingDto postingDto = new PostingDto();
            postingDto.PostId = posting.PostId;
            postingDto.UserPostId = posting.UserPostId;
            postingDto.Caption = posting.Caption;
            postingDto.OptionId = posting.OptionId;
            postingDto.Media = posting.Media;
            postingDto.Statitude = posting.Statitude;
            postingDto.Share = posting.Share;
            postingDto.CreatedAt = posting.CreatedAt;

            return postingDto;
        }
        public Posting ConvertToBllPost(PostingDto postingDto)
        {
            Posting posting = new Posting();
            posting.PostId = postingDto.PostId;
            posting.UserPostId = postingDto.UserPostId;
            posting.Caption = postingDto.Caption;
            posting.OptionId = postingDto.OptionId;
            posting.Media = postingDto.Media;
            posting.Statitude = postingDto.Statitude;
            posting.Share = postingDto.Share;
            posting.CreatedAt = postingDto.CreatedAt;

            return posting;
        }
        // Thêm một post.
        public void AddPost(int userId, string caption, int option, string media, int statitude, int share)
        {
            postingRepository.Posting(userId, caption, option, media, statitude, share);
            Console.WriteLine("Hello");
        }
        public List<PostingDto> GetPost(int userId, int offset = 0, int limit = 30)
        {
            List<Posting> postings = postingRepository.GetPosts(userId, offset, limit);
            List<PostingDto> postingDtos = new List<PostingDto>();

            foreach (Posting posting in postings)
            {
                postingDtos.Add(ConvertToDtoPost(posting));
            }

            return postingDtos;
        }
        public List<PostingDto> GetAllPosts(int offset, int limit)
        {
            List<Posting> postings = postingRepository.GetAllPosts(offset, limit);
            List<PostingDto> postingDtos = new List<PostingDto>();

            foreach (Posting posting in postings)
            {
                postingDtos.Add(ConvertToDtoPost(posting));
            }

            return postingDtos;
        }
        public int GetMaxPostId()
        {
            return postingRepository.GetMaxPostId();
        }
        public PostingDto GetPostByPostId(int postId)
        {
            Posting posting = postingRepository.GetPostByPostId(postId);
            PostingDto postingDto = ConvertToDtoPost(posting);
            return postingDto;
        }
        public void UpdateOption(int postId, int newOption)
        {
            postingRepository.UpdateOption(postId, newOption);
        }
    }
}
