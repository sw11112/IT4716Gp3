using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float CameraMoveSpeed = 120.0f;
    public GameObject CameraFollowObject;
    Vector3 FollowPos;
    public float clampangle = 80.0f;
    public float inputSensitivity = 150.0f;
    public GameObject CameraObj;
    public GameObject PlayerObj;
    public float camDistanceXToPlayer;
    public float camDistanceYToPlayer;
    public float camDistanceZToPlayer;
    public float mouseX;
    public float mouseY;
    public float rotY=0.0f;
    public float rotX=0.0f;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 rot = transform.localRotation.eulerAngles;
        rotY = rot.y;
        rotX = rot.x;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

    // Update is called once per frame
    void Update()
    {
        mouseY = Input.GetAxis("MouseX");
        mouseX = Input.GetAxis("MouseY");

        rotY += mouseY * inputSensitivity * Time.deltaTime;
        rotX += mouseX * inputSensitivity * Time.deltaTime;

        rotX = Mathf.Clamp(rotX, -clampangle, clampangle);

        Quaternion localRotation = Quaternion.Euler(-rotX, rotY, 0.0f);
        transform.rotation = localRotation;
    }

    private void LateUpdate()
    {
        CameraUpdater ();
    }
    void CameraUpdater()
    {
        //set the target object to follow
        //Transform target = CameraFollowObject.transform;

        //move towards the game object that is the target
        float step = CameraMoveSpeed * Time.deltaTime;

        //transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }
}
