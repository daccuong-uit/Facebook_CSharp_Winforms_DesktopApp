using DAL.Models.Main;
using DAL.Repositories.Main;
using DTO.Main;
using System.Collections.Generic;
using System;
using DAL.Models;

public class FriendsService
{
    private readonly FriendsRepository friendsRepository;

    public FriendsService()
    {
        friendsRepository = new FriendsRepository();
    }

    public FriendRequestDto ConvertToDtoFriend(FriendRequest friendRequest)
    {
        FriendRequestDto friendRequestDto = new FriendRequestDto();
        friendRequestDto.RequestId = friendRequest.RequestId;
        friendRequestDto.SenderId = friendRequest.SenderId;
        friendRequestDto.ReceiverId = friendRequest.ReceiverId;
        friendRequestDto.Status = friendRequest.Status;
        friendRequestDto.SendAt = friendRequest.SendAt;
        return friendRequestDto;
    }

    public FriendRequest ConvertToBllFriend(FriendRequestDto friendRequestDto)
    {
        FriendRequest friendRequest = new FriendRequest();
        friendRequest.RequestId = friendRequestDto.RequestId;
        friendRequest.SenderId = friendRequestDto.SenderId;
        friendRequest.ReceiverId = friendRequestDto.ReceiverId;
        friendRequest.Status = friendRequestDto.Status;
        friendRequest.SendAt = friendRequestDto.SendAt;
        return friendRequest;
    }

    public void SendFriendRequest(int senderId, int receiverId)
    {
        friendsRepository.SendFriendRequest(senderId, receiverId);
    }
    public void AcceptFriendRequest(int requestId)
    {
        friendsRepository.AcceptFriendRequest(requestId);
    }
    public void RejectFriendRequest(int requestId)
    {
        friendsRepository.RejectFriendRequest(requestId);
    }
    public int GetRequestIdBySenderAndReceiver(int senderId, int receiverId)
    {
        return friendsRepository.GetRequestIdBySenderAndReceiver(senderId, receiverId);
    }

    public List<FriendRequestDto> GetFriendsList(int userId)
    {
        List<FriendRequest> friendItems = friendsRepository.GetFriendsList(userId);
        List<FriendRequestDto> friendsDtoList = new List<FriendRequestDto>();

        foreach (FriendRequest friendItem in friendItems)
        {
            FriendRequestDto friendsDto = ConvertToDtoFriend(friendItem);
            friendsDtoList.Add(friendsDto);
        }

        return friendsDtoList;
    }
    public List<int> GetFriendsIds(int currentUserId)
    {
        return friendsRepository.GetFriendsIds(currentUserId);
    }
    public List<FriendRequestDto> GetPendingFriendRequests(int userId)
    {
        List<FriendRequest> friendItems = friendsRepository.GetPendingFriendRequests(userId);
        List<FriendRequestDto> friendsDtoList = new List<FriendRequestDto>();

        foreach (FriendRequest friendItem in friendItems)
        {
            FriendRequestDto friendsDto = ConvertToDtoFriend(friendItem);
            friendsDtoList.Add(friendsDto);
        }

        return friendsDtoList;
    }

    public void DeleteFriend(int sender, int receiver)
    {
        friendsRepository.DeleteFriend(sender, receiver);
    }
}