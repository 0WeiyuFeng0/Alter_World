using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_pos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float pox= Random.Range(0, 200);
        float poz = Random.Range(-11, 1);
        transform.position = new Vector3(pox, 0f, poz);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
