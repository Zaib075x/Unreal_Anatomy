using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
    int sceneIndex;
    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKeyUp(KeyCode.Escape))
            {
                if (sceneIndex == 4)
                {
                    SceneManager.LoadScene("selection");
                }
                else if (sceneIndex == 0)
                {
                    Application.Quit();
                }
                else if (sceneIndex == 6 || sceneIndex == 7)
                {
                    SceneManager.LoadScene("hand");
                }
                else if (sceneIndex == 11 || sceneIndex == 12 || sceneIndex == 13 || sceneIndex == 14)
                {
                    SceneManager.LoadScene("InnerHeart");
                }
                else
                {
                    SceneManager.LoadScene(sceneIndex - 1);
                }
            }
        }
        
    }
}
