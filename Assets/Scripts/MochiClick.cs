using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MochiClick : MonoBehaviour
{
    //prefab‚ğŠi”[‚·‚é‚½‚ß‚Ì•Ï”
    
    public MochiSpawn mochiSpawn;
    public int addScore = 1;

    /// <summary>
    /// ƒ{ƒ^ƒ“‚ğ‰Ÿ‚µ‚½‚Æ‚«prefab‚ğ¶¬‚·‚é
    /// </summary>
    public void OnClick()
    {
        ScoreData.addScore(addScore);
        mochiSpawn.SpawnMochi();
    }
}
