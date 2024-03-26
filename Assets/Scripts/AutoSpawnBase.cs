using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSpawnBase : MonoBehaviour
{
    public int cost;
    public float score;

    
    public int level;

    [SerializeField]private float addMagnification;  //�{��
    [SerializeField] private int costMagnification;  //�K�v�R�X�g�{��
    public float Magnification { get => addMagnification; set => addMagnification = value; }
    public int CostMagnification { get => costMagnification; set => costMagnification = value; }



    private void Start()
    {
        //�O�����狖�����܂Ŕ�\���̗\��
        //gameObject.SetActive(false);
        cost = 0;
        level = 0;
        score = 0;
        addMagnification = (float)10.0;
        costMagnification = 5;
        
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
            ScoreData.addScorePerS((int)(level * addMagnification));
        }
        
    }




}
