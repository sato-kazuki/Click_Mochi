using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickGameStarter : MonoBehaviour
{
    
    void Start()
    {
        //BGM_Singleton�̃C���X�^���X���擾
        //
        BGM_Singleton.Instance.MusicChange("Town Theme.wav");
    }
}
