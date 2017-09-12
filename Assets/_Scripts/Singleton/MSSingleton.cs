using UnityEngine;

public class MSSingleton<T> : MonoBehaviour where T : MSSingleton<T>
{
    private static T instance;
    public static T Instance
    {
        get
        {
            return instance;
        }
    }

    /// <summary>
    /// Returns whether the instance has been initialized or not.
    /// </summary>
    public static bool IsInitialized
    {
        get
        {
            return instance != null;
        }
    }

    /// <summary>
    /// Base awake method that sets the singleton's unique instance.
    /// </summary>
    protected virtual void Awake()
    {
        if (instance != null)
        {
            Debug.LogErrorFormat("Trying to instantiate a second instance of singleton class {0}", GetType().Name);
            //Destroy(gameObject);
        }
        else
        {
            instance = (T)this;
            //DontDestroyOnLoad(gameObject);
        }
    }

    protected virtual void OnDestroy()
    {
        if (instance == this)
        {
            instance = null;
        }
    }
}

