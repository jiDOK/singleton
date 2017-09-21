using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public KeyCode loadKey;

    void Update()
    {
        if (Input.GetKeyDown(loadKey))
        {
            SceneManager.LoadScene("Level01");
        }
    }

}
