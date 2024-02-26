using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MochiClick : MonoBehaviour
{
    //prefab‚ğŠi”[‚·‚é‚½‚ß‚Ì•Ï”
    
    public MochiSpawn mochiSpawn;
    public MochiCount mochiCount;
    /// <summary>
    /// ƒ{ƒ^ƒ“‚ğ‰Ÿ‚µ‚½‚Æ‚«prefab‚ğ¶¬‚·‚é
    private void Start()
    {

    }
    public void OnClick()
    {
        mochiSpawn.SpawnMochi();
        mochiCount.AddMochiCount();

    }
}
