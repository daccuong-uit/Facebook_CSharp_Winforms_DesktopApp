using DAL.Models;
using DAL.Repositories;
using System;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Collections.Specialized.BitVector32;
using DTO;
using System.Collections.Generic;

namespace BLL.Services
{
    public class AuthenticationService
    {
        private readonly UserRepository userRepository;

        public AuthenticationService()
        {
            userRepository = new UserRepository();
        }

        public int Login(string username, string password)
        {
            User user = userRepository.GetUserByUsername(username);
            if (user != null && user.Password == password)
            {
                // Đăng nhập thành công
                return user.UserId;
            }
            // Đăng nhập thất bại
            return 0;
        }
        public void ResetPassword(string email, string newPassword)
        {
            bool success = this.userRepository.ResetPassword(email, newPassword);

            if (success)
            {
                MessageBox.Show("Mật khẩu đã được cập nhật thành công.");
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi cập nhật mật khẩu.");
            }
        }
        public void UpdateAvatar(int userId, string avatar)
        {
            userRepository.UpdateAvatar(userId, avatar);
        }
        private string GetOTP()
        {
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            int length = 6;
            StringBuilder otpBuilder = new StringBuilder();

            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                int index = random.Next(0, characters.Length);
                otpBuilder.Append(characters[index]);
            }

            string otp = otpBuilder.ToString();
            return otp;
        }
        public string SendEmail(string Email)
        {
            MailMessage mail = new MailMessage();
            mail.From = new System.Net.Mail.MailAddress("nguyendaccuong1103@gmail.com");
            SmtpClient smtp = new SmtpClient();
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(mail.From.Address, "yjui sqed qiaa vdzs");
            smtp.Host = "smtp.gmail.com";

            //recipient
            string OTP = GetOTP();
            mail.To.Add(new MailAddress(Email));
            mail.IsBodyHtml = true;
            mail.Subject = "Quên mật khẩu";
            mail.Body = "Đây là mã xác minh tài khoản của bạn: " + OTP;

            //for (int i = 0; i < attachmentFilename.Length; i++)
            //    mail.Attachments.Add(new Attachment(attachmentFilename[i]));

            smtp.Send(mail);
            MessageBox.Show("Email sent successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return OTP;
        }
        public User ConvertToBllUser(UserDto userDto)
        {
            User user = new User();
            user.UserId = userDto.UserId;
            user.Name = userDto.Name;
            user.LastName = userDto.LastName;
            user.Username = userDto.UserName;
            user.Email = userDto.Email;
            user.PhoneNumber = userDto.PhoneNumber;
            user.Password = userDto.Password;
            user.Avatar = userDto.Avatar;

            return user;
        }
        public UserDto ConvertToDtoUser(User user)
        {
            UserDto userDto = new UserDto();
            userDto.UserId = user.UserId;
            userDto.Name = user.Name;
            userDto.LastName = user.LastName;
            userDto.UserName = user.Username;
            userDto.Email = user.Email;
            userDto.PhoneNumber = user.PhoneNumber;
            userDto.Password = user.Password;
            userDto.Avatar = user.Avatar;

            return userDto;
        }
        public void Register(UserDto userDto)
        {
            User user = ConvertToBllUser(userDto);
            userRepository.Register(user);
        }

        /*public void Delete(int id)
        {
            userRepository.DeleteUser(id);
        }*/
        public UserDto GetUserByUserId(int userId)
        {
            User user = userRepository.GetUserByUserId(userId);
            UserDto userDto = ConvertToDtoUser(user);
            return userDto;
        }
        public int GetNumberOfUser()
        {
            int count;
            count = userRepository.GetNumberOfUser();
            return count;
        }
        public int GetUserIdByEmail(string email)
        {
            int userId;
            userId = userRepository.GetUserIdByEmail(email);
            return userId;
        }
        public List<int> GetAllUserIds()
        {
            return userRepository.GetAllUserIds();
        }
    }
}