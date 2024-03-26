using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.EventSystems;


public class ScoreData : MonoBehaviour
{
    public delegate void ScoreDataCallback();
    public static event ScoreDataCallback getScoreData;

    

    [SerializeField]
    public static int score;
    [SerializeField]
    public static int scorePerS;


    
    private float _timeElapsed;     //経過時間


    private void Start()
    {
        StartCoroutine(RepeatFunction());
    }

    public static void addScore(int addscore)
    {
        score += addscore;
        getScoreData.Invoke();
    }
    public static void addScorePerS(int addscorePerS)
    {
        scorePerS += addscorePerS;
        getScoreData.Invoke();
    }


    /// <summary>
    /// 毎秒スコアを返す
    /// </summary>
    /// <returns></returns>
    private IEnumerator RepeatFunction()
    {
        while (true)
        {
            _timeElapsed += Time.deltaTime;


            if (_timeElapsed >= 1)
            {
                addScore(scorePerS);
                _timeElapsed = 0;
            }
            yield return null;
        }
    }

    //[Obsolute]inspectorでListを追加・編集するスクリプト
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
