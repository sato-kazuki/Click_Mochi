using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MochiClick : MonoBehaviour
{
    //prefab���i�[���邽�߂̕ϐ�
    [SerializeField]
    public GameObject mochiPrefab;
    public Vector2 mochiPosition;
    public MochiCount mochiCount;
    /// <summary>
    /// �{�^�����������Ƃ�prefab�𐶐�����
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
        
        
        //�����_���Ȉʒu��prefab�𐶐�
        Instantiate(mochiPrefab, new Vector2(x,mochiPosition.y + Random.Range(1, 2)), Quaternion.identity);
        mochiCount.AddMochiCount();

    }
}
