using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MochiCount : MonoBehaviour
{
    //TextMeshProUGUIの変数を宣言
    public TextMeshProUGUI mochiCountText;
    //現在の質量
    public int mochiCount = 0;
    //現在の質量単位
    public string countUnit = "";
    //現在の質量毎秒
    public int mochiCountPerS = 0;
    //現在の質量単位毎秒
    public string countUnitPerS = "";
    //更新するテキストの前部分の変数を宣言
    public string mochiCountString; // "g("
    //更新するテキストの後ろ部分の変数を宣言
    public string mochiCountString2; // "/s)"


    private void Start()
    {
        ScoreData.getScoreData += AddMochiCount;
    }


    /// <summary>
    /// カウントを増やす
    /// </summary>
    public void AddMochiCount()
    {

        //カウントを取得・更新
        mochiCount = ScoreData.score;
        mochiCountPerS = ScoreData.scorePerS;
        //テキストを更新
        mochiCountText.text = mochiCount.ToString() + countUnit + mochiCountString + mochiCountPerS.ToString() + countUnitPerS + mochiCountString2;
    }

}
