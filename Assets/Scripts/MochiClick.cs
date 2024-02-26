using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MochiClick : MonoBehaviour
{
    //prefabを格納するための変数
    
    public MochiSpawn mochiSpawn;
    public MochiCount mochiCount;
    /// <summary>
    /// ボタンを押したときprefabを生成する
    private void Start()
    {

    }
    public void OnClick()
    {
        mochiSpawn.SpawnMochi();
        mochiCount.AddMochiCount();

    }
}
