using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class Launcher : MonoBehaviourPunCallbacks
{
 
    string _gameVersion = "test";   //�Q�[���̃o�[�W�����B�d�l���قȂ�o�[�W�����ƂȂ����Ƃ��̓o�[�W������ύX���Ȃ��ƃG���[����������B
   

    //���O�C���{�^�����������Ƃ��Ɏ��s�����
    public void Connect()
    {

           PhotonNetwork.ConnectUsingSettings();
            //Photon�ɐڑ�����
            Debug.Log("Photon�ɐڑ����܂����B");
        OnJoinedLobby();



    }
  

    //Auto-JoinLobby�Ƀ`�F�b�N�����Ă����Photon�ɐڑ���OnJoinLobby()���Ă΂��B
    public override void OnJoinedLobby()
    {
        Debug.Log("���r�[�ɓ���܂����B");
        //Random�ŕ�����I�сA�����ɓ���i�������������OnPhotonRandomJoinFailed���Ă΂��j
        var roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 6;
        PhotonNetwork.JoinOrCreateRoom("Room", roomOptions, TypedLobby.Default);
    }

    //JoinRandomRoom�����s�����Ƃ��ɌĂ΂��
    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        Debug.Log($"���[���ւ̎Q���Ɏ��s���܂���: {message}");

    }


    public override void OnJoinedRoom()
    {
        Debug.Log("���[���֎Q�����܂���");
        PhotonNetwork.LoadLevel("test");
    }



}
