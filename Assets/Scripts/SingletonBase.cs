using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SingletonBase<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;

    public static T Instance
    {
        get
        {
            // インスタンスが既に存在するかどうかを確認
            if (instance == null)
            {
                // インスタンスが見つからない場合は新しいGameObjectを作成し、その上にコンポーネントを追加
                GameObject singletonObject = new GameObject(typeof(T).Name);
                instance = singletonObject.AddComponent<T>();
                DontDestroyOnLoad(singletonObject);
            }
            return instance;
        }
    }

    protected virtual void Awake()
    {
        // インスタンスが複数存在する場合は自身を破棄する
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            // インスタンスが存在しない場合は自身をインスタンスとして設定し、シーン遷移時に破棄されないようにする
            instance = this as T;
            DontDestroyOnLoad(gameObject);
        }
    }
}

///// <summary>
///// シングルトンの基底クラス
///// </summary>
///// <typeparam name="T"></typeparam>
//public abstract class SingletonBase<T> : MonoBehaviour where T : MonoBehaviour
//{
//    //public abstract bool dontDestroyOnLoad { get; }

//    private static T instance;


//    public static T Instance
//    {
//        get
//        {
//            if (!instance)
//            {
//                //Type t = typeof(T);
//                //instance = (T)FindObjectOfType(t);
//                //if (!instance)
//                //{
//                //    Debug.LogError(t + " is nothing.");
//                //}
//                instance = FindObjectOfType<T>();

//            }
//            return instance;
//        }
//    }


//    protected virtual void Awake()
//    {
//        if (this != Instance)
//        {
//            Destroy(this);
//            return;
//        }
//        if (dontDestroyOnLoad)
//        {
//            DontDestroyOnLoad(gameObject);
//        }
//    }
//}