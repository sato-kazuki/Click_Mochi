using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//シングルトンを継承する
public class ScoreData : MonoBehaviour
{
    [Serializable]public class MochiScore
    {
        public string mochiName;
        public int score;
    }
    // inspector上で扱えるスコアデータ
    [SerializeField] List<MochiScore> spawnList = new List<MochiScore>();

    // スコアデータを取得する
    public List<MochiScore> GetScoreData()
    {
        return spawnList;
    }
    // スコアデータを設定する
    public void SetScoreData(List<MochiScore> scoreData)
    {
        spawnList = scoreData;
    }
}
