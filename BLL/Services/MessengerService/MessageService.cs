using DAL.Models;
using DAL.Repositories;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BLL.Services
{
    public class MessageService
    {
        private readonly MessageRepository messageRepository;

        public MessageService()
        {
            messageRepository = new MessageRepository();
        }
        public MessageDto ConvertToDtoContact(Message message)
        {
            MessageDto messageDto = new MessageDto();
            messageDto.MessageId = message.MessageId;
            messageDto.ChatId = message.ChatId;
            messageDto.UserId = message.UserId;
            messageDto.Content = message.Content;
            messageDto.ContentImage = message.ContentImage;
            messageDto.ContentIcon = message.ContentIcon;
            messageDto.ContentVideo = message.ContentVideo;
            messageDto.SentAt = message.SentAt;

            return messageDto;
        }
        public Message ConvertToBllContact(MessageDto messageDto)
        {
            Message message = new Message();
            message.MessageId = messageDto.MessageId;
            message.ChatId = messageDto.ChatId;
            message.UserId = messageDto.UserId;
            message.Content = messageDto.Content;
            message.ContentImage = messageDto.ContentImage;
            message.ContentIcon = messageDto.ContentIcon;
            message.ContentVideo = messageDto.ContentVideo;
            message.SentAt = messageDto.SentAt;

            return message;
        }

        // Lấy danh sách tin nhắn dựa vào UserId và ChatId
        public List<MessageDto> GetMessagesByChatIdAndUserId(int chatId, int userId)
        {
            List<Message> messages = messageRepository.GetMessagesByChatIdAndUserId(chatId, userId);
            List<MessageDto> messageDtos = new List<MessageDto>();

            foreach (Message message in messages)
            {
                messageDtos.Add(ConvertToDtoContact(message));
            }

            return messageDtos;
        }

        // Lấy danh sách tin nhắn trong một cuộc trò chuyện dựa trên ID cuộc trò chuyện.
        /*public List<MessageDto> GetMessagesByChatId(int chatId)
        {
            List<Message> messages = messageRepository.GetMessagesByChatId(chatId);
            List<MessageDto> messageDtos = new List<MessageDto>();

            foreach (Message message in messages)
            {
                messageDtos.Add(ConvertToDtoContact(message));
            }

            return messageDtos;
        }*/

        // Lấy danh sách tin nhắn của một người dùng dựa trên ID người dùng.
        /*public List<MessageDto> GetMessagesByUserId(int userId)
        {
            List<Message> messages = messageRepository.GetMessagesByUserId(userId);
            List<MessageDto> messageDtos = new List<MessageDto>();

            foreach (Message message in messages)
            {
                messageDtos.Add(ConvertToDtoContact(message));
            }

            return messageDtos;
        }*/

        // Gửi một tin nhắn trong cuộc trò chuyện.
        public void SendMessage(int userId, int contactUserId, string content, string contentImage, string contentIcon, string contentVideo)
        {
            messageRepository.SendMessage(userId, contactUserId, content, contentImage, contentIcon, contentVideo);
        }

        // Xóa một tin nhắn dựa trên ID tin nhắn.
        /*public void DeleteMessage(int messageId)
        {
            messageRepository.DeleteMessage(messageId);
        }*/
    }
}
