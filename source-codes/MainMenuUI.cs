using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    // Start is called before the first frame update
    public void OpenApp()
    {
        SceneManager.LoadScene("selection");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
