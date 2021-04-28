using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    /*Animator anim;

    public float rotSpeed = 10;
    private Vector3 moveDirection;

    private float timeCount = 0f;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        

        moveDirection = new Vector3(h, 0, v);
        moveDirection = Camera.main.transform.TransformDirection(moveDirection);
        moveDirection.y = 0;
        if(moveDirection != Vector3.zero)
        {
            Quaternion newRotation = Quaternion.LookRotation(moveDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation,newRotation,rotSpeed*Time.deltaTime);
        }*/
    /*if (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d"))
    {
        anim.SetBool("IsWalk", true);
    }
    else {
        anim.SetBool("IsWalk", false);
    }

    if (Input.GetKey(KeyCode.Space))
    {

        anim.SetBool("IsFly", true);

    }
    else
    {
        anim.SetBool("IsFly", false);
    }

    if (Input.GetKey("w"))
    {
        transform.Translate(Vector3.forward * 0.05f);
    }
    if (Input.GetKey("s"))
    {
        transform.Translate(Vector3.forward * -0.05f);
    }
    if (Input.GetKey("a"))
    {
        transform.Translate(Vector3.left * 0.1f);
    }
    if (Input.GetKey("d"))
    {
        transform.Translate(Vector3.left * -0.1f);
    }
    if (gameObject.GetComponent<Animator>().GetBool("IsFly") == true)
    {
        if (Input.GetKey("w"))
        {
            transform.Translate(Vector3.forward * 0.1f);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(Vector3.forward * -0.1f);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.left * 0.15f);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.left * -0.15f);
        }
    }


}*/
    public CharacterController controller;
    public Transform cam;
    public static float speed = 6f;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    Animator anim;
    AudioSource m_AudioSource;

    private void Start()
    {
        anim = GetComponent<Animator>();
        m_AudioSource = GetComponent<AudioSource>();
        speed = 6f;
    }

    private void Update()
    {
        if (CinHp.noHP==false && attack. startAnim== false)
        {
            
            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");
            Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
            

            
            
                if (( Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d")) )
            {
               anim.SetBool("IsWalk", true);
                if (!m_AudioSource.isPlaying)
                {
                    m_AudioSource.Play();
                }
            }
            else
            {
                anim.SetBool("IsWalk", false);
                m_AudioSource.Stop();
            }

            if ( Input.GetKey(KeyCode.Space) && StringthPower.overHeat==false )
            {
                anim.SetBool("IsFly", true);
                speed = 15f;
            }
            else
            {
                anim.SetBool("IsFly", false);
                speed = 6f;
            }

            if (direction.magnitude>=0.1f)
            {
                float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg+ cam.eulerAngles.y;
                float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
                transform.rotation = Quaternion.Euler(0f, angle, 0f);

                Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
                controller.Move(moveDir.normalized * speed * Time.deltaTime);
            }
            }
        
    
    }
}
