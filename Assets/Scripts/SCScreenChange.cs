using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;

public class SCScreenChange : MonoBehaviour
{
    private static int sceneStatus;

    public SCScreenImage scScreenImage;

    /// <summary>
    /// スクリーン切り替えをナンバーで送信
    /// </summary>
    /// <param name="IsRight">右矢印で昇順</param>
    public void OnButtonClick(bool IsRight)
    {
        int listMaxLength = scScreenImage.sceneNames.Count;
        if (IsRight)
        {
            //右矢印で範囲外に行く時は最小番目に戻す
            sceneStatus = sceneStatus + 1 > listMaxLength ? 1 : sceneStatus++;
            scScreenImage.ChangeScreenNum(sceneStatus);
        }
        else
        {
            //左矢印で範囲外に行く時は最大番目に戻す
            sceneStatus = sceneStatus - 1 < 1 ? listMaxLength : sceneStatus--;
            scScreenImage.ChangeScreenNum(sceneStatus);
        }

    }
}