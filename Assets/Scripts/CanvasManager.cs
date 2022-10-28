using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{
    public Button button1;

    public void PlayGame()
    {
        SceneManager.LoadScene(0);
    }

    public void FinalGame()
    {
        SceneManager.LoadScene(2);
    }

}
