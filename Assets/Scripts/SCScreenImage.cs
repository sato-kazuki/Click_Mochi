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
        //sceneChange�Ƀf�t�H���g�̑J�ڐ�V�[�����ƃC���[�W���Z�b�g
        ChangeScreenNum(1);
    }

    public void ChangeScreenNum(int num)
    {
        //sceneChange�Ƀf�t�H���g�̑J�ڐ�V�[�������Z�b�g
        sceneChange.SceneName = sceneNames[num];
        //scScreenChange�Ƀf�t�H���g�̃C���[�W���Z�b�g
        Addressables.LoadAssetAsync<Image>(screenImagePath[num]).Completed += handle =>
        {
            image = handle.Result;
        };
    }

    /// <summary>
    /// ScreenImage���󂯎�������O�ōX�V����
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
