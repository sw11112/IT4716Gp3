using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CinHp : MonoBehaviour
{
    public Animator anim;
    public static int healthpoint = 450;
    public static bool noHP = false;
    public Text playerHP;
    void Start()
    {
        anim = GetComponent<Animator>();
        //playerHP = GetComponent<Text>();
        healthpoint = 450;
        
    }

    // Update is called once per frame
    void Update()
    {
        playerHP.text = healthpoint.ToString();
        if (healthpoint <= 0 )
        {
            healthpoint = 0;
            anim.SetBool("NoHP", true);
            noHP = true;
            SceneManager.LoadScene(3);
            
        }
    }

    public void TakeDamage(int amount)
    {
        healthpoint -= amount;
    }
}
