using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSpawnBase : MonoBehaviour
{
    public int cost;
    public float score;

    //Lv�\��������Ύg�p����
    public int level;

    private float addMagnification;  //�{��
    private int costMagnification;  //�K�v�R�X�g�{��
    public float Magnification { get => addMagnification; set => addMagnification = value; }
    public int CostMagnification { get => costMagnification; set => costMagnification = value; }

    private float _repeatSpan;      //�����Ԋu
    private float _timeElapsed;     //�o�ߎ���



    private void Start()
    {
        //�O�����狖�����܂Ŕ�\���̗\��
        //gameObject.SetActive(false);
        cost = 1;
        level = 0;
        score = 0;
        addMagnification = (float)10.0;
        costMagnification = 5;
        _repeatSpan = (float)1.0;
        StartCoroutine(RepeatFunction());
    }

    /// <summary>
    /// cost�����LvUp
    /// </summary>
    public void OnButtonClick()
    {
        if (ScoreData.score >= cost)
        {
            ScoreData.addScore(-1 * cost);
            cost += costMagnification;
            level++;
        }
        
    }


    /// <summary>
    /// ���bLv�~�{���̃X�R�A��Ԃ�
    /// </summary>
    /// <returns></returns>
    private IEnumerator RepeatFunction()
    {
        while (true)
        {
            _timeElapsed += Time.deltaTime;

            
            if (_timeElapsed >= _repeatSpan)
            {
                //����
                score += (level * addMagnification);
                if((int)(score / 1) > 0)
                {
                    ScoreData.addScore((int)(score / 1));
                    score = score % 1;
                }
                _timeElapsed = 0;
            }
            yield return null;
        }
    }

}
