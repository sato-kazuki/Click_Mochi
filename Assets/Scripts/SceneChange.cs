using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    
    private string sceneName;

    public string SceneName { get => sceneName; set => sceneName = value; }

    //ƒV[ƒ“‚ğ‘JˆÚ
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
