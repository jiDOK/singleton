using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonV1 : MonoBehaviour
{
    public static SingletonV1 instance { get; private set; }

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }


}
