using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject Ball;
    private Vector3 Offset;
    // Start is called before the first frame update
    void Start()
    {
        Offset = new Vector3(gameObject.transform.position.x - Ball.transform.position.x, gameObject.transform.position.y - Ball.transform.position.y, gameObject.transform.position.z - Ball.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = Ball.transform.position + Offset;
    }
}
