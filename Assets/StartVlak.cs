using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartVlak : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject GroenVlak;
    public GameObject RoodVlak;
    private void OnTriggerEnter()
    {
        GroenVlak.SetActive(true);
        RoodVlak.SetActive(false);
    }
       
}
