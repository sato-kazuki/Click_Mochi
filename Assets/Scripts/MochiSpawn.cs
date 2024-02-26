using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MochiSpawn : MonoBehaviour
{
    public GameObject mochiPrefab;
    public float autoSpawnInterval = 10;
    private float countTime = 0;

    public void SpawnMochi()
    {
        float x = Random.Range(-2, 2);
        while (x == 0)
        {
            x = Random.Range(-2, 2);
        }


        //�����_���Ȉʒu��prefab�𐶐�
        Instantiate(mochiPrefab, new Vector2(x,Random.Range(0, 2)), Quaternion.identity);
    }
    private void Update()
    {
        countTime += Time.deltaTime;
        if (countTime >= autoSpawnInterval)
        {
            // ����
            SpawnMochi();
            countTime = 0f; // �^�C�}�[�����Z�b�g
        }
    }
}
