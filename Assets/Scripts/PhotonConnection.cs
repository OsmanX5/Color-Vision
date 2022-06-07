using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class PhotonConnection : MonoBehaviourPunCallbacks
{
    public void OnClick_Connect()
    {
        PhotonNetwork.ConnectUsingSettings();
    }
}
