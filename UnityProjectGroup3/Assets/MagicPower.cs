using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicPower : MonoBehaviour
{

    public float speed  = 8f;
    public float lifeDuration = 2f;
    public static int Damage = 70;
    

    // Start is called before the first frame update
    void Start()
    {
        Destroy (gameObject, lifeDuration);
    }

    // Update is called once per frame
    void Update()
    {
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
