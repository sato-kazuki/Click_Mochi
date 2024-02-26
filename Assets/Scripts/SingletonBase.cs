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
            // �C���X�^���X�����ɑ��݂��邩�ǂ������m�F
            if (instance == null)
            {
                // �C���X�^���X��������Ȃ��ꍇ�͐V����GameObject���쐬���A���̏�ɃR���|�[�l���g��ǉ�
                GameObject singletonObject = new GameObject(typeof(T).Name);
                instance = singletonObject.AddComponent<T>();
                DontDestroyOnLoad(singletonObject);
            }
            return instance;
        }
    }

    protected virtual void Awake()
    {
        // �C���X�^���X���������݂���ꍇ�͎��g��j������
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            // �C���X�^���X�����݂��Ȃ��ꍇ�͎��g���C���X�^���X�Ƃ��Đݒ肵�A�V�[���J�ڎ��ɔj������Ȃ��悤�ɂ���
            instance = this as T;
            DontDestroyOnLoad(gameObject);
        }
    }
}

///// <summary>
///// �V���O���g���̊��N���X
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