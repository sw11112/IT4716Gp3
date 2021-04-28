using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SwitchScene : MonoBehaviour
{
    //jump Scene
    public void NextScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

}
