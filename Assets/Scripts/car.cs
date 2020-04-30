using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    // Start is called before the first frame update
    public float targetGoal;
    void Start()
    {
        targetGoal = -1.4f;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < targetGoal)
        {
            targetGoal = -1.4f;
            transform.position += transform.forward * Time.deltaTime * 5f;
        }
        else
        {
            targetGoal = -13f;
            transform.position -= transform.forward * Time.deltaTime * 5f;
        }

    }
}
