using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MochiCount : MonoBehaviour
{
    //TextMeshProUGUI�̕ϐ���錾
    public TextMeshProUGUI mochiCountText;
    //�J�E���g�p�̕ϐ���錾
    public int mochiCount = 0;
    //�X�V����e�L�X�g�̑O�����̕ϐ���錾
    public string mochiCountString;
    //�X�V����e�L�X�g�̌�땔���̕ϐ���錾
    public string mochiCountString2;


    /// <summary>
    /// �J�E���g�𑝂₷
    /// </summary>
    public void AddMochiCount()
    {
        //�J�E���g�𑝂₷
        mochiCount++;
        //�e�L�X�g���X�V
        mochiCountText.text = mochiCountString + mochiCount.ToString() + mochiCountString2;
    }

}
