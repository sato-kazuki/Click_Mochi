using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.U2D;
using static Unity.Burst.Intrinsics.X86;

public class BGM_Singleton : SingletonBase<BGM_Singleton>
{
    //ファイルパス
    private const string FILE_PATH = "Assets/Audios/";

    AudioSource audiosource;


    void Start()
    {
        audiosource = this.gameObject.GetComponent<AudioSource>();
        
    }

    /// <summary>
    /// BGMを変更する
    /// 
    /// </summary>
    /// <param name="musicname">ファイル名</param>
    public async void MusicChange(string musicname)
    {
        string filename = FILE_PATH + musicname;
        AudioClip afterMusic = await Addressables.LoadAssetAsync<AudioClip>(filename).Task;
        Debug.Log(filename);
        if (afterMusic == default)
        {
            // defaultであれば、ロードに失敗している
            Debug.LogError("ロードに失敗しました");
        }
        audiosource.clip = afterMusic;
        audiosource.Play();
        Addressables.Release(afterMusic);
    }
}