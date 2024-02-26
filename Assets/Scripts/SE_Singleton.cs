using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.U2D;
using static Unity.Burst.Intrinsics.X86;

public class SE_Singleton : SingletonBase<SE_Singleton>
{
    private const string FILE_PATH = "Assets/Audios/";

    AudioSource audiosource;

    

    void Start()
    {
        audiosource = this.gameObject.GetComponent<AudioSource>();

    }

    public async void MusicChange(string musicname)
    {
        string filename = FILE_PATH + musicname;
        AudioClip afterMusic = await Addressables.LoadAssetAsync<AudioClip>(filename).Task;
        Debug.Log(filename);
        if (afterMusic == default)
        {
            // default�ł���΁A���[�h�Ɏ��s���Ă���
            Debug.LogError("���[�h�Ɏ��s���܂���");
        }
        audiosource.clip = afterMusic;
        audiosource.Play();
        Addressables.Release(afterMusic);
    }
}