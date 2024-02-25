using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MochiClick : MonoBehaviour
{
    //prefabを格納するための変数
    [SerializeField]
    public GameObject mochiPrefab;
    public Vector2 mochiPosition;
    public MochiCount mochiCount;
    /// <summary>
    /// ボタンを押したときprefabを生成する
    private void Start()
    {

    }
    public void OnClick()
    {
        float x = Random.Range(-2, 2);
        while (x == 0)
        {
            x = Random.Range(-2, 2);
        }
        
        
        //ランダムな位置にprefabを生成
        Instantiate(mochiPrefab, new Vector2(x,mochiPosition.y + Random.Range(1, 2)), Quaternion.identity);
        mochiCount.AddMochiCount();

    }
}
