using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarriageMovment : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        {
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("NPCA"))
        {
            ShowInfo.passangersNumber++;
            NPCMotionGateA.speed = 100f;
        }
        if (other.CompareTag("NPCB"))
        {
            ShowInfo.passangersNumber++;
            NPCMotionGateB.speed = 100f;
        }
    }
    

    void OnTriggerExit(Collider other)
    {
        ShowInfo.passangersNumber--;
        NPCMotionGateA.speed = 5f;
    }
}
