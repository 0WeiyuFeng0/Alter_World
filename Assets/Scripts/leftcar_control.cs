using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftcar_control : MonoBehaviour
{
    // Start is called before the first frame update
    private float targetGoal;
    void Start()
    {
        targetGoal = -19f;
        int pox = Random.Range(0, 5000);
        transform.position = new Vector3(pox, 0.28f, -6.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.z > targetGoal)
        {
            targetGoal = -19f;
            transform.position -= transform.forward * Time.deltaTime * 5f;
        }
        else
        {
            targetGoal = -6.0f;
            transform.position += transform.forward * Time.deltaTime * 5f;
        }

    }
}
