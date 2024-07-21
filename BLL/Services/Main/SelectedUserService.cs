using DAL.Models;
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
    public class SelectedUserService
    {
        private readonly SelectedUserRepository selectedUserRepository;
        public SelectedUserService()
        {
            selectedUserRepository = new SelectedUserRepository();
        }
        public SelectedUserDto ConvertToDtoPost(SelectedUser selectedUser)
        {
            SelectedUserDto selectedUserDto = new SelectedUserDto();
            selectedUserDto.PostId = selectedUser.PostId;
            selectedUserDto.UserId = selectedUser.UserId;

            return selectedUserDto;
        }
        public void InsertSelectedUser(int postId, int userId)
        {
            selectedUserRepository.InsertSelectedUser(postId, userId);
        }
        public void DeleteSelectedUsers(int postId)
        {
            selectedUserRepository.DeleteSelectedUsers(postId);
        }
        public List<int> GetSelectedUsers(int postId)
        {
            return selectedUserRepository.GetSelectedUsers(postId);
        }
    }
}
