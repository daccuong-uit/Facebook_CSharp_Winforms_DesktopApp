using DAL.Repositories;
using System;

namespace BLL.Services
{
    public class ChatService
    {
        private readonly ChatRepository chatRepository;

        public ChatService()
        {
            chatRepository = new ChatRepository();
        }

        // Thêm một người tham gia vào cuộc trò chuyện.
        public void AddParticipantToChat(int chatId, int userId)
        {
            // Thực hiện kiểm tra logic nếu cần thiết trước khi thêm người tham gia.

            chatRepository.AddParticipant(chatId, userId);
        }

        // Xóa một người tham gia khỏi cuộc trò chuyện.
        public void RemoveParticipantFromChat(int chatId, int userId)
        {
            // Thực hiện kiểm tra logic nếu cần thiết trước khi xóa người tham gia.

            chatRepository.RemoveParticipant(chatId, userId);
        }
    }
}