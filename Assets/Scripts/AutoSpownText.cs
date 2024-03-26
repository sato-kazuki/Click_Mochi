using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Drawing;

public class AutoSpownText : MonoBehaviour
{
    //TextMeshProUGUIの変数を宣言
    public TextMeshProUGUI autoSpownText;
    public string costText;
    public string levelText;
    public string pointText;

    public void Start()
    {
        costText = "必要量:0";
        levelText = "規模:0";
        pointText = "産出量 0g/s";
        autoSpownText.text = costText + "\n" + levelText + "\n" + pointText;
    }

    public void CostUp(int cost)
    {
        costText = "必要量:" + cost.ToString();
        autoSpownText.text = costText + "\n" + levelText + "\n" + pointText;
    }
    public void LevelUp(int level)
    {
        levelText = "規模:" + level.ToString();
        autoSpownText.text = costText + "\n" + levelText + "\n" + pointText;
    }
    public void PointUp(int point)
    {
        levelText = "産出量 " + point.ToString() + "g/s";
        autoSpownText.text = costText + "\n" + levelText + "\n" + pointText;
    }
}
