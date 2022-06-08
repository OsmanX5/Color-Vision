using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using TMPro;
public class PhotonRooms : MonoBehaviourPunCallbacks
{
    public TMP_Text roomName;
    public TMP_Text RoomsDaialog;
    public GameObject CreatRoomObjects;
    public GameObject Leave;


    public void OnClick_CreateRoom()
    {
        RoomOptions options = new RoomOptions();
        options.MaxPlayers = 2;
        if(PhotonNetwork.IsConnected)
        PhotonNetwork.CreateRoom(roomName.text);
        else
            RoomsDaialog.text = "You are not connected check your Internet";
    }
    public void OnClick_JoinRoom()
    {
        if (PhotonNetwork.IsConnected)
        {
            PhotonNetwork.JoinRoom(roomName.text);
            PhotonNetwork.LoadLevel("Challenge");
        }
            
        else
            RoomsDaialog.text = "You are not connected check your Internet";
    }
    public void OnClick_LeaveTheRoom()
    {
        PhotonNetwork.LeaveRoom();
        CreatRoomObjects.SetActive(true);
        Leave.SetActive(false);
    }
    public override void OnJoinedRoom()
    {
        RoomsDaialog.text = $"Room created now Share this name # {roomName.text} # with your friend the game will start when he join in";
        CreatRoomObjects.SetActive(false);
        Leave.SetActive(true);
    }
    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        RoomsDaialog.text = message;
    }
    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        RoomsDaialog.text = message;
    }
}
