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


    
    private float _timeElapsed;     //�o�ߎ���


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
    /// ���b�X�R�A��Ԃ�
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

    //[Obsolute]inspector��List��ǉ��E�ҏW����X�N���v�g
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
