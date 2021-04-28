using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    public float RedLockDist = 50;
    public GameObject RedLock;
    public GameObject GreenLock;
    Transform Dragon;
    // Start is called before the first frame update
    void Start()
    {
        Dragon = GameObject.FindWithTag("Dragon").transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(transform.position, Dragon.position);
        if (dist <= RedLockDist)
        {
            RedLock.SetActive(true);
            GreenLock.SetActive(false);
        }
        else
        {
            GreenLock.SetActive(true);
            RedLock.SetActive(false);
        }
    }
}
