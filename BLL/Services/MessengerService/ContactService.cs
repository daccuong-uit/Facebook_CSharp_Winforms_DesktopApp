using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using DAL.Repositories;
using DTO;

namespace BLL.Services
{
    public class ContactService
    {
        private readonly ContactRepository contactRepository;
        public ContactService()
        {
            contactRepository = new ContactRepository();
        }

        public ContactDto ConvertToDtoContact(Contact contact)
        {
            ContactDto contactDto = new ContactDto();
            contactDto.ContactId = contact.ContactId;
            contactDto.UserId = contact.UserId;
            contactDto.ContactUserId = contact.ContactUserId;

            return contactDto;
        }
        public Contact ConvertToBllContact(ContactDto contactDto)
        {
            Contact contact = new Contact();
            contact.ContactId = contactDto.ContactId;
            contact.UserId = contactDto.UserId;
            contact.ContactUserId = contactDto.ContactUserId;

            return contact;
        }

        public List<ContactDto> GetContactsByUserId(int userId)
        {
            List<Contact> contacts = contactRepository.GetContactsByUserId(userId);
            List<ContactDto> contactDtos = new List<ContactDto>();

            foreach (Contact contact in contacts)
            {
                ContactDto contactDto = ConvertToDtoContact(contact);
                contactDtos.Add(contactDto);
            }

            return contactDtos;
        }

        public int GetContactId(int userId, int contactUserId)
        {
            int contactId;
            contactId = contactRepository.GetContactId(userId, contactUserId);
            return contactId;
        }

        public void AddContact(int userId, int contactUserId)
        {
            contactRepository.AddContact(userId, contactUserId);
        }

        /*public void DeleteContact(int userId, int contactId)
        {
            contactRepository.DeleteContact(userId, contactId);
        }*/


        //ContactService contactService = new ContactService();

        // Lấy danh sách liên hệ của một người dùng dựa trên ID người dùng
        //List<Contact> contacts = contactService.GetContactsByUserId(userId);

        // Thêm một liên hệ mới vào danh bạ của người dùng
        //contactService.AddContact(userId, contactUserId);

        // Xóa một liên hệ khỏi danh bạ của người dùng dựa trên ID người dùng và ID liên hệ
        //contactService.DeleteContact(userId, contactId);

    }
}
