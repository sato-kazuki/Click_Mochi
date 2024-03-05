using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MochiCount : MonoBehaviour
{
    //TextMeshProUGUIの変数を宣言
    public TextMeshProUGUI mochiCountText;
    //カウント用の変数を宣言
    public int mochiCount = 0;
    //更新するテキストの前部分の変数を宣言
    public string mochiCountString;
    //更新するテキストの後ろ部分の変数を宣言
    public string mochiCountString2;


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
        //テキストを更新
        mochiCountText.text = mochiCountString + mochiCount.ToString() + mochiCountString2;
    }

}
