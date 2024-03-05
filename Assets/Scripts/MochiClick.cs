using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MochiClick : MonoBehaviour
{
    //prefabを格納するための変数
    
    public MochiSpawn mochiSpawn;
    public int addScore = 1;

    /// <summary>
    /// ボタンを押したときprefabを生成する
    /// </summary>
    public void OnClick()
    {
        ScoreData.addScore(addScore);
        mochiSpawn.SpawnMochi();
    }
}
