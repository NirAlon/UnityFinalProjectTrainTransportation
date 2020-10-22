using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowInfo : MonoBehaviour
{
    // Start is called before the first frame update
    public static int passangersNumber = 0;
    public Text passengersCountText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        passengersCountText.text = "Number of passangers on train : " + passangersNumber; 
    }
}
