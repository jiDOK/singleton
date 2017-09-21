using UnityEngine;

public class GM_Trigger : MonoBehaviour
{

    private void Awake()
    {
        //GameManager gameManager = GameManager.instance;
    }

    void Start()
    {
        // request GameManager even though there is none instantiated
        GameManager gameManager = GameManager.instance;
    }

}
