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
        if (selist.Count < num) //Žw’è”Ô–Ú‚ªlist’·‚ð’´‚¦‚Ä‚¢‚é‚©
        {
            Debug.Log("SE‚ªŒ©‚Â‚©‚è‚Ü‚¹‚ñ");
            return;
        }

        
        SE_Singleton.Instance.SEPlay(selist[num]);

    }
}
