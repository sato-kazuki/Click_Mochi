using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE_called : MonoBehaviour
{

    
    //[System.Serializable]
    //public class SElist
    //{
    //    public AudioClip audioClip;
    //}
    
    [SerializeField] List<AudioClip> selist = new List<AudioClip>();

    public void OnEvent(int num)
    {
        if (selist.Count < num) //指定番目がlist長を超えているか
        {
            Debug.Log("SEが見つかりません");
            return;
        }

        
        SE_Singleton.Instance.SEPlay(selist[num]);

    }
}
