using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class Launcher : MonoBehaviourPunCallbacks
{
 
    string _gameVersion = "test";   //ゲームのバージョン。仕様が異なるバージョンとなったときはバージョンを変更しないとエラーが発生する。
   

    //ログインボタンを押したときに実行される
    public void Connect()
    {

           PhotonNetwork.ConnectUsingSettings();
            //Photonに接続する
            Debug.Log("Photonに接続しました。");
        OnJoinedLobby();



    }
  

    //Auto-JoinLobbyにチェックを入れているとPhotonに接続後OnJoinLobby()が呼ばれる。
    public override void OnJoinedLobby()
    {
        Debug.Log("ロビーに入りました。");
        //Randomで部屋を選び、部屋に入る（部屋が無ければOnPhotonRandomJoinFailedが呼ばれる）
        var roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 6;
        PhotonNetwork.JoinOrCreateRoom("Room", roomOptions, TypedLobby.Default);
    }

    //JoinRandomRoomが失敗したときに呼ばれる
    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        Debug.Log($"ルームへの参加に失敗しました: {message}");

    }


    public override void OnJoinedRoom()
    {
        Debug.Log("ルームへ参加しました");
        PhotonNetwork.LoadLevel("test");
    }



}
