using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Instance { get; private set; }

    [SerializeField] private bool dontDestroyOnLoad = false;

    protected virtual void Awake()
    {
        if (Instance != null)
        {
            DestroyImmediate(gameObject);
            return;
        }

        Instance = GetComponent<T>();

        if (dontDestroyOnLoad) DontDestroyOnLoad(gameObject);

        SetupOnAwake();
    }

    protected virtual void SetupOnAwake()
    {

    }
}



