using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MochiClick : MonoBehaviour
{
    //prefab���i�[���邽�߂̕ϐ�
    
    public MochiSpawn mochiSpawn;
    public int addScore = 1;

    /// <summary>
    /// �{�^�����������Ƃ�prefab�𐶐�����
    /// </summary>
    public void OnClick()
    {
        ScoreData.addScore(addScore);
        mochiSpawn.SpawnMochi();
    }
}
