using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMotionGateB : MonoBehaviour
{
    public static bool allAbordA;
    public static bool allAbordB;
    public Transform trainSit;
    public Transform trainPlace;
    public static float speed;
    // Start is called before the first frame update
    void Start()
    {
        //agent = GetComponent<NavMeshAgent>();
        allAbordA = false;
        allAbordB = false;
        speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        if (allAbordB)
            transform.position = Vector3.MoveTowards(transform.position, trainSit.position, step);

        if (allAbordA)
            transform.position = Vector3.MoveTowards(transform.position, trainPlace.position, step);
    }
}
