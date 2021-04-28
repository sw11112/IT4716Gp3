using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QAttack : MonoBehaviour
{
    public float speed = 8f;
    public float lifeDuration = 2f;
    public static int Damage = 160;
    public static int MagicAmount = 1;
    public float coolDownTime = 8.0f;
    public float AA;
    public bool noPower = false;


    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeDuration);
        AA=0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        AA += Time.deltaTime;
        if (MagicAmount<1)
        {
           
            
        }
        Debug.Log(AA);

        if (AA>= coolDownTime)
        {
            Debug.Log("Hi");
            MagicAmount = 1;
            AA = 0;
        }

        //make sure magic power is moving
        transform.position += transform.forward * speed * Time.deltaTime;

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Dragon")
        {
            DragonCol.DraHP -= Damage;
        }

    }
}
