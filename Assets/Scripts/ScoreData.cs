using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class ScoreData : MonoBehaviour
{
    public delegate void ScoreDataCallback();
    public static event ScoreDataCallback getScoreData;

    public static int score;

    public static void addScore(int addscore)
    {
        score += addscore;
        getScoreData.Invoke();
    }

    //inspector��List��ǉ��E�ҏW����X�N���v�g
    //[Serializable]
    //public class MochiScore
    //{
    //    public string mochiName;
    //    public int score;
    //}
    //// inspector��ň�����X�R�A�f�[�^
    //[SerializeField] List<MochiScore> spawnList = new List<MochiScore>();

    //// �X�R�A�f�[�^���擾����
    //public List<MochiScore> GetScoreData()
    //{
    //    return spawnList;
    //}
    //// �X�R�A�f�[�^��ݒ肷��
    //public void SetScoreData(List<MochiScore> scoreData)
    //{
    //    spawnList = scoreData;
    //}


}
