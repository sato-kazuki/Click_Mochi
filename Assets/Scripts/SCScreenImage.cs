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
            screenImagePath.Add("ShootingSceneImage");
        }
        //sceneChangeにデフォルトの遷移先シーン名とイメージをセット
        ChangeScreenNum(0);
    }

    public void ChangeScreenNum(int num)
    {
        //sceneChangeに遷移先シーン名をセット
        sceneChange.SceneName = sceneNames[num];
        //scScreenChangeにイメージをセット
        Addressables.LoadAssetAsync<Sprite>(screenImagePath[num]).Completed += handle =>
        {
            image.sprite = handle.Result;
        };
    }


}
