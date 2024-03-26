using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Drawing;

public class AutoSpownText : MonoBehaviour
{
    //TextMeshProUGUI�̕ϐ���錾
    public TextMeshProUGUI autoSpownText;
    public string costText;
    public string levelText;
    public string pointText;

    public void Start()
    {
        costText = "�K�v��:0";
        levelText = "�K��:0";
        pointText = "�Y�o�� 0g/s";
        autoSpownText.text = costText + "\n" + levelText + "\n" + pointText;
    }

    public void CostUp(int cost)
    {
        costText = "�K�v��:" + cost.ToString();
        autoSpownText.text = costText + "\n" + levelText + "\n" + pointText;
    }
    public void LevelUp(int level)
    {
        levelText = "�K��:" + level.ToString();
        autoSpownText.text = costText + "\n" + levelText + "\n" + pointText;
    }
    public void PointUp(int point)
    {
        levelText = "�Y�o�� " + point.ToString() + "g/s";
        autoSpownText.text = costText + "\n" + levelText + "\n" + pointText;
    }
}
