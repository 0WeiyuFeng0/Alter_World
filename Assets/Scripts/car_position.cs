using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car_position : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int pox = Random.Range(0, 5000);
        transform.position = new Vector3(pox, -1.02f, -13.36f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
