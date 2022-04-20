using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxappear : MonoBehaviour
{
    public int countCollisions = 0;
    public GameObject Box;
    public float remainder;

    //private void OnTriggerEnter()
    //{
    //    Cube1.SetActive(true);
    //}


    private void OnTriggerEnter()
    {
        // if (gameObject.name == "HMIversion" || gameObject.name == "HMIField")
        countCollisions++;
    }

    void Fixedupdate()
    {
        remainder = countCollisions +1 ;
        if (countCollisions % 2 == 0)
        {
            Box.SetActive(false);
        }

        if (countCollisions % 2 != 0)
        {
            Box.SetActive(true);
        }

    }
}
