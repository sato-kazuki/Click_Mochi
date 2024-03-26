using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MochiCount : MonoBehaviour
{
    //TextMeshProUGUI�̕ϐ���錾
    public TextMeshProUGUI mochiCountText;
    //���݂̎���
    public int mochiCount = 0;
    //���݂̎��ʒP��
    public string countUnit = "";
    //���݂̎��ʖ��b
    public int mochiCountPerS = 0;
    //���݂̎��ʒP�ʖ��b
    public string countUnitPerS = "";
    //�X�V����e�L�X�g�̑O�����̕ϐ���錾
    public string mochiCountString; // "g("
    //�X�V����e�L�X�g�̌�땔���̕ϐ���錾
    public string mochiCountString2; // "/s)"


    private void Start()
    {
        ScoreData.getScoreData += AddMochiCount;
    }


    /// <summary>
    /// �J�E���g�𑝂₷
    /// </summary>
    public void AddMochiCount()
    {

        //�J�E���g���擾�E�X�V
        mochiCount = ScoreData.score;
        mochiCountPerS = ScoreData.scorePerS;
        //�e�L�X�g���X�V
        mochiCountText.text = mochiCount.ToString() + countUnit + mochiCountString + mochiCountPerS.ToString() + countUnitPerS + mochiCountString2;
    }

}
