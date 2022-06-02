using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PhotonConnection : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Connecting");
        PhotonNetwork.GameVersion = "0";
        PhotonNetwork.ConnectUsingSettings();
    }
    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to master");
    }
    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.Log("Disconnected");
    }
    public void MakeChallenge()
    {
        if (!PhotonNetwork.IsConnected)
        {
            Debug.Log("You are disconnected can't create a room");
            return;
        }
        RoomOptions options = new RoomOptions();
        options.MaxPlayers = 2;
        PhotonNetwork.JoinOrCreateRoom("challenge", options, TypedLobby.Default);
    }
    public override void OnJoinedRoom()
    {
        Debug.Log("Room created");
    }
    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        Debug.Log(message);
    }
}
