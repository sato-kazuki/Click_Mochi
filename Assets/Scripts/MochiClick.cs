using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MochiClick : MonoBehaviour
{
    //prefab���i�[���邽�߂̕ϐ�
    
    public MochiSpawn mochiSpawn;
    public MochiCount mochiCount;
    /// <summary>
    /// �{�^�����������Ƃ�prefab�𐶐�����
    private void Start()
    {

    }
    public void OnClick()
    {
        mochiSpawn.SpawnMochi();
        mochiCount.AddMochiCount();

    }
}
