using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DDown : MonoBehaviour
{

    public void OpenHeart()
    {
        SceneManager.LoadScene("hand");
    }
    public void OpenHand() 
    { 
            SceneManager.LoadScene("ground");
    }
    public void OpenInnerHeart()
    {
        SceneManager.LoadScene("InnerHeart");
    }

   
}
