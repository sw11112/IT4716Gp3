using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StringthPower : MonoBehaviour
{
    public static float cinSP = 5;
    public Slider slider;
    public static bool overHeat = false;
    public Image image;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = cinSP;
        slider.minValue = 0;
        anim = GetComponent<Animator>();
        image.GetComponent<Image>().color = new Color32(0, 255, 225, 255);
    }

    // Update is called once per frame
    void Update()
    {
        if (cinSP >= 5)
        {
            cinSP = 5;
            overHeat = false;
            
        }        
        //walk or fly situations
        //1.not overheat and can fly or walk      
        if (cinSP <0)
        {
            cinSP = 0;
            overHeat = true;
            move.speed = 0;
                        
        }
         else if (cinSP>0 && gameObject.GetComponent<Animator>().GetBool("IsFly") == true&&overHeat==false)
        {
            //2.flying decrease the SP
            cinSP -=  1.75f*Time.deltaTime;
            
        }
        else if (cinSP > 0 && gameObject.GetComponent<Animator>().GetBool("IsFly") == false&&overHeat==false)
        {
            //3.fly a little but not reach 0 and after lose the space it increase the SP
            cinSP += 2* Time.deltaTime;
            
        }
        if ((overHeat == true && cinSP < 10) || (overHeat == true && cinSP < 10 && (Input.GetKey(KeyCode.Space) || Input.GetKeyDown(KeyCode.Space))))
        {
            //4.flying and reach the 0 of SP and cannot fly until SP return to 1
            CanNotFly();
            cinSP += Time.deltaTime;
            
        }
        slider.value = cinSP;
        
    }
    
    void CanFly()
    {
        anim.SetBool("IsFly", true);
    }
    void CanNotFly()
    {
        anim.SetBool("IsFly", false);
    }

    
}
