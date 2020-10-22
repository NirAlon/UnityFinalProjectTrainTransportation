using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TrainMovement : MonoBehaviour
{
    public float speed, angularSpeed,vMove;
    public static bool stopOnDeck;
    public bool handbraek;
    CharacterController cController;
    //Rigidbody rBody;
    public GameObject cubeCamera;
    GameObject cubeCameraS;
    GameObject cubeCameraW;
    public bool changeDiraction;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.5f;
        angularSpeed = 10f;
        cController = GetComponent<CharacterController>();
        //rBody = GetComponent<Rigidbody>();
        changeDiraction = false;
        stopOnDeck = false;
        handbraek = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Vertical"))
        {
            vMove = Input.GetAxis("Vertical") *speed;
            cController.Move(transform.TransformDirection(Vector3.forward * vMove));
            if (Input.GetKey(KeyCode.S)&&!changeDiraction)
            {
                cubeCameraS = GameObject.FindGameObjectWithTag("cubeCameraS");
                cubeCamera.transform.position = cubeCameraS.transform.position;
                cubeCamera.transform.Rotate(0, 180, 0);
                changeDiraction = true;
            }
            if (Input.GetKey(KeyCode.W) && changeDiraction)
            {
                cubeCameraW = GameObject.FindGameObjectWithTag("cubeCameraW");
                cubeCamera.transform.position = cubeCameraW.transform.position;
                cubeCamera.transform.Rotate(0, 180, 0);
                changeDiraction = false;
            }
        }
    }
}
