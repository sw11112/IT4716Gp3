using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{

    public Animator anim;
    public static bool startAnim=false;
    public GameObject magicPower;
    public GameObject Q;
    public GameObject LargeB;
    public float timeDelay=0;
    public float animStartTime=0;
    public int lastkeyinput;

    //give the period of the time to input secont space bar
    public float inD = 0.5f;

    //Timer to count the time of the second spacebar input of the attack animation cancle
    public float startContTime=0f;

    //"countCan" is use in (<"cancle attack animations">) with spacebar double click
    //usage of "bool countCan" is start count time of the    (<"Second  Spacebar Input">).
    public static bool countCan=false;
    public GameObject Cam;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (startAnim == true)
        {
            animStartTime += Time.deltaTime;
        }else
        {
            animStartTime = 0;
        }

        //2 is Close Combat
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            
            anim.SetTrigger("RightClick");
            startAnim = true;
            //set the bullet start shooting time
            timeDelay = 0.2f;
            //record the key input 2 is Close Combat
            lastkeyinput = 2;
        }

        //1 is Normal Shoot
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            
            anim.SetTrigger("LeftClick");
            startAnim = true;
            //set the bullet start shooting time
            timeDelay = 0.75f;
            //record the key input 1 is Normal Shoot
            lastkeyinput = 1;
        }

        //3 is Q TAK
        if (Input.GetKeyDown(KeyCode.Q))
        {
            
            anim.SetTrigger("Q");
            startAnim = true;
            timeDelay = 2f;
            //record the key input 3 is Q TAK
            lastkeyinput = 3;
        }


        //4 is Large Beam Shoot
        if (Input.GetKeyDown(KeyCode.E))
        {
            anim.SetTrigger("E");
            startAnim = true;
            timeDelay = 0.3f;
            //record the key input 4 is Large Beam Shoot
            lastkeyinput = 4;
        }

        

        if ((lastkeyinput == 1 && (animStartTime >= timeDelay))&& startAnim == true)
        {
            GameObject Atk1 = Instantiate(magicPower);
            Atk1.transform.position = transform.position + transform.forward;
            startAnim = false;
            Atk1.transform.rotation = Cam.transform.rotation;
        }

        if ((lastkeyinput == 3 && (animStartTime >= timeDelay)) && startAnim == true && QAttack.MagicAmount>0)
        {
            QAttack.MagicAmount =0;
            GameObject Atk2 = Instantiate(Q);
            Atk2.transform.position = transform.position + transform.forward;
            startAnim = false;
            Atk2.transform.rotation = Cam.transform.rotation;
        }

        if ((lastkeyinput == 4 && (animStartTime >= timeDelay)) && startAnim == true)
        {
            GameObject Atk4 = Instantiate(LargeB);
            Atk4.transform.position = transform.position + transform.forward;
            startAnim = false;
            Atk4.transform.rotation = Cam.transform.rotation;
        }

        //use space bar double click to cancle the attack but not animation
        if (Input.GetKeyDown(KeyCode.Space))
        {
            countCan = true;
        }
        if (countCan == true)
        {
            startContTime += Time.deltaTime;
        }
        if (startContTime <= inD && Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("IsSSCancle");
            startAnim = false;
            countCan = false;
        }
    }

}
