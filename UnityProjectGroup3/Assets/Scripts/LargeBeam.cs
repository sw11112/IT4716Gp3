using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeBeam : MonoBehaviour
{
    public float speed = 100f;
    public float lifeDuration = 4f;
    public static int Damage = 90;
    Vector3 temp;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeDuration);
    }

    // Update is called once per frame
    void Update()
    {
        //make sure magic power is moving
        temp = transform.localScale;
        temp.z -= speed;
        transform.localScale = temp;

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Dragon")
        {
            DragonCol.DraHP -= Damage;
        }

    }
}
