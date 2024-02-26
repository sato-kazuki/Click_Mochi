using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�V���O���g�����p������
public class ScoreData : MonoBehaviour
{
    [Serializable]public class MochiScore
    {
        public string mochiName;
        public int score;
    }
    // inspector��ň�����X�R�A�f�[�^
    [SerializeField] List<MochiScore> spawnList = new List<MochiScore>();

    // �X�R�A�f�[�^���擾����
    public List<MochiScore> GetScoreData()
    {
        return spawnList;
    }
    // �X�R�A�f�[�^��ݒ肷��
    public void SetScoreData(List<MochiScore> scoreData)
    {
        spawnList = scoreData;
    }
}
