using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSpawnBase : MonoBehaviour
{
    public int cost;
    public float score;

    //Lv表示があれば使用する
    public int level;

    private float addMagnification;  //倍率
    private int costMagnification;  //必要コスト倍率
    public float Magnification { get => addMagnification; set => addMagnification = value; }
    public int CostMagnification { get => costMagnification; set => costMagnification = value; }

    private float _repeatSpan;      //生成間隔
    private float _timeElapsed;     //経過時間



    private void Start()
    {
        //外部から許可されるまで非表示の予定
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
    /// cost消費してLvUp
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
    /// 毎秒Lv×倍率のスコアを返す
    /// </summary>
    /// <returns></returns>
    private IEnumerator RepeatFunction()
    {
        while (true)
        {
            _timeElapsed += Time.deltaTime;

            
            if (_timeElapsed >= _repeatSpan)
            {
                //処理
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
