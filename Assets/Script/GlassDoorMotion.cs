using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassDoorMotion : MonoBehaviour
{
    public bool npcAllAbordA;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        npcAllAbordA = NPCMotionGateA.allAbordA;
    }

    // Update is called once per frame
    void Update()
    {
        npcAllAbordA = NPCMotionGateA.allAbordA;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GateATrigger"))
        {
            if(!NPCMotionGateA.allAbordB)
            NPCMotionGateA.allAbordA = true;
            
            //TrainMovement.stopOnDeck = true;
            
            animator.SetTrigger("Open");
            
            if (NPCMotionGateB.allAbordB)
            {
                NPCMotionGateB.allAbordA = true;
            }

        }
        if (other.CompareTag("GateBTrigger"))
        {

            NPCMotionGateB.allAbordB = true;
            NPCMotionGateB.allAbordA = false;

            NPCMotionGateA.allAbordA = false;
            NPCMotionGateA.allAbordB = true;
            
            //TrainMovement.stopOnDeck = true;
            animator.SetTrigger("Open");

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (npcAllAbordA) { 
        animator.SetTrigger("Close");
        TrainMovement.stopOnDeck = false; ;
        }
    }
}
