using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

public class SCScreenImage : MonoBehaviour
{
    public Image image;

    public List<string> sceneNames = new List<string>();
    public List<string> screenImagePath = new List<string>();
    public SceneChange sceneChange;


    private void Start()
    {
        image = GetComponent<Image>();


        if (sceneNames.Count <= 0)
        {
            sceneNames.Add("ShootingScene");
        }
        if (screenImagePath.Count <= 0)
        {
            screenImagePath.Add("ShootingImage");
        }
        //sceneChangeにデフォルトの遷移先シーン名とイメージをセット
        ChangeScreenNum(1);
    }

    public void ChangeScreenNum(int num)
    {
        //sceneChangeにデフォルトの遷移先シーン名をセット
        sceneChange.SceneName = sceneNames[num];
        //scScreenChangeにデフォルトのイメージをセット
        Addressables.LoadAssetAsync<Image>(screenImagePath[num]).Completed += handle =>
        {
            image = handle.Result;
        };
    }

    /// <summary>
    /// ScreenImageを受け取った名前で更新する
    /// </summary>
    /// <param name="name"></param>
    public void ChangeImage(string name)
    {
        Addressables.LoadAssetAsync<Image>(name).Completed += handle =>
        {
            image = handle.Result;
        };
        
        
    }
}
