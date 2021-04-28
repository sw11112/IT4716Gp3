using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SScene : MonoBehaviour
{
    public float Timer=0;
    public GameObject Button;

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer>3)
        {
            ShowButton();
        }
        
    }
    public void NextScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void ShowButton()
    {
        Button.SetActive(true);
    }
}
