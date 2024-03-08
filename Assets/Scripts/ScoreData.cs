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

    //inspectorでListを追加・編集するスクリプト
    //[Serializable]
    //public class MochiScore
    //{
    //    public string mochiName;
    //    public int score;
    //}
    //// inspector上で扱えるスコアデータ
    //[SerializeField] List<MochiScore> spawnList = new List<MochiScore>();

    //// スコアデータを取得する
    //public List<MochiScore> GetScoreData()
    //{
    //    return spawnList;
    //}
    //// スコアデータを設定する
    //public void SetScoreData(List<MochiScore> scoreData)
    //{
    //    spawnList = scoreData;
    //}


}
