using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSpawnBase : MonoBehaviour
{
    public int cost;
    public float score;

    
    public int level;

    [SerializeField]private float addMagnification;  //倍率
    [SerializeField] private int costMagnification;  //必要コスト倍率
    public float Magnification { get => addMagnification; set => addMagnification = value; }
    public int CostMagnification { get => costMagnification; set => costMagnification = value; }



    private void Start()
    {
        //外部から許可されるまで非表示の予定
        //gameObject.SetActive(false);
        cost = 0;
        level = 0;
        score = 0;
        addMagnification = (float)10.0;
        costMagnification = 5;
        
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
            ScoreData.addScorePerS((int)(level * addMagnification));
        }
        
    }




}
