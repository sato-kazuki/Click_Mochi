using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Drawing;

public class AutoSpownText : MonoBehaviour
{
    //TextMeshProUGUIÇÃïœêîÇêÈåæ
    public TextMeshProUGUI autoSpownText;
    public string costText;
    public string levelText;
    public string pointText;

    public void Start()
    {
        costText = "cost:0";
        levelText = "level:0";
        pointText = "point 0Mo/s";
        autoSpownText.text = costText + "\n" + levelText + "\n" + pointText;
    }

    public void CostUp(int cost)
    {
        costText = "Cost:" + cost.ToString();
        autoSpownText.text = costText + "\n" + levelText + "\n" + pointText;
    }
    public void LevelUp(int level)
    {
        levelText = "Level:" + level.ToString();
        autoSpownText.text = costText + "\n" + levelText + "\n" + pointText;
    }
    public void PointUp(int point)
    {
        levelText = "point " + point.ToString() + "Mo/s";
        autoSpownText.text = costText + "\n" + levelText + "\n" + pointText;
    }
}
