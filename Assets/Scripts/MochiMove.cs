using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UIElements;

public class MochiMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform mochi;
    public CircleCollider2D circleCollider2D;
    public int destroylimit = 8;

    private int destroycount = 0;
    
    public const float transformSize = 0.01f;

    void Start()
    {

        //�����_���ȕ����ɔ�΂�
        float x = Random.Range(-4, 4);
        while (x==0) {
            x = Random.Range(-4, 4);
        }
        rb.AddForce(new Vector2(x, Random.Range(5, 10)), ForceMode2D.Impulse);
        //��]��������
        rb.AddTorque(Random.Range(-2, 2), ForceMode2D.Impulse);

    }

    /// <summary>
    /// �Փ˂����Ƃ��̏���
    /// 
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (destroycount > destroylimit) {
            circleCollider2D.enabled = false;
        }
        destroycount++;
    }

    /// ��ʊO�ɏo�������
    /// 

    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
