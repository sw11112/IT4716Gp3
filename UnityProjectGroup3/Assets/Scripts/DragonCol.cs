using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragonCol : MonoBehaviour
{
    public int damage = 450;
    public static int DraHP = 1000;
    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        DraHP = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        if (DraHP <= 0)
        {
            anim.SetBool("NoHP", true);
            damage = 0;
            SceneManager.LoadScene(4);

        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.GetComponent<CinHp>().TakeDamage(damage);
        }
        if (other.tag == "NormalShoot")
        {
            DraHP -= MagicPower.Damage;
        }
    }
}
