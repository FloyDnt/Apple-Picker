using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void SceneChanger(string _sceneName)
    {
        SceneManager.LoadScene(_sceneName);
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
