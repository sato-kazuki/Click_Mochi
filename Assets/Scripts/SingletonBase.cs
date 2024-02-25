using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// �V���O���g���̊��N���X
/// </summary>
/// <typeparam name="T"></typeparam>
public abstract class SingletonBase<T> : MonoBehaviour where T : MonoBehaviour
{
    protected abstract bool dontDestroyOnLoad { get; }

    private static T instance;

    [Obsolete]
    public static T Instance
    {
        get
        {
            if (!instance)
            {
                Type t = typeof(T);
                instance = (T)FindObjectOfType(t);
                if (!instance)
                {
                    Debug.LogError(t + " is nothing.");
                }
            }
            return instance;
        }
    }

    [Obsolete]
    protected virtual void Awake()
    {
        if (this != Instance)
        {
            Destroy(this);
            return;
        }
        if (dontDestroyOnLoad)
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }
}