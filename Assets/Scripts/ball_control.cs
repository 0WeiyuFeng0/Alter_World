
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_control : MonoBehaviour
{
    public  GameObject ball;
    public bool jump = false;
    private Rigidbody rd;
    public float force = 3.5f;
    public float speed = 35f;
    public float forceForward = 100;
    public Material poison;
    public Material originStatus;
    public bool poisonstatus = false;
    public bool returnStatus = false;
    public bool jumpStatus = false;
    public bool jumpPress = false;
    public GameObject shieldappear;
    public AudioSource soundeffect;
    public AudioClip soundcoin;
    public AudioClip soundhurt;
    public AudioClip failure;
    public bool closeshield = false;
    private float gamescore;

    float poisonTimer = 3.5f;
    float currenty ;
    Vector3 orginPos;
    Vector3 upv;
                          // Use this for initialization
    void Start()
    {
        rd = GetComponent<Rigidbody>();
        orginPos = ball.transform.position;
        global_variable.ori_position = orginPos;
        upv = new Vector3(0, 0, 0);
        currenty = rd.velocity.y;
    }

    // Update is called once per frame
    void Update()
    {
        // float h = Input.GetAxis("Horizontal");

        //rd.AddForce(new Vector3(0.1f, 0, 0) * forceForward);
        
        float v = Input.GetAxis("Horizontal");
        // rd.AddForce(new Vector3(0, 0, -v) * force);
        if (global_variable.isPause == false)
        {
            gamescore += speed;
            global_variable.score = gamescore / 100;
        }
        if (Input.GetKeyDown(KeyCode.Space) && !jump &&!jumpPress)
        {
            rd.velocity = new Vector3(0.2f * speed, 10f, -v * 0.3f * speed);
            jumpPress = true;
            jump= true;
        }
        if(!global_variable.isshield&& !closeshield)
        {
            GameObject shield = GameObject.Find("shield");
            shield.SetActive(false);
            closeshield = true;
        }
        currenty = rd.velocity.y;
        rd.velocity =  new Vector3(0.2f * speed, currenty, -v*0.2f * speed) ;
        if (Input.GetKeyDown(KeyCode.S) && jump)
        {
            rd.AddForce(0, -180, 0, ForceMode.Impulse);
        }
        
        speed += 0.05f;

        if(poisonstatus)
        {
            poisonTimer -= Time.deltaTime;
            if(poisonTimer<0)
            {
                poisonstatus = false;
                returnStatus = true;

            }

        }
        if(returnStatus)
        {
            ball.GetComponent<MeshRenderer>().material = originStatus;
            poisonTimer = 3.5f;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        
        if(other.tag=="obstacle"|| other.tag == "bridge")
        {
            if (!global_variable.isshield)
            {
                //ball.transform.position = orginPos;
                global_variable.live--;
                speed = 35f;
                soundeffect.Stop();
                soundeffect.clip = soundhurt;
                soundeffect.Play();
            }
            else
            {
                global_variable.isshield = false;
                /*  GameObject shield = GameObject.Find("shield");
                  shield.SetActive(false);*/
                closeshield = false;
                soundeffect.Stop();
                soundeffect.clip = soundhurt;
                soundeffect.Play();
            }


        }
        if (other.tag == "bonus")
        {
            other.gameObject.SetActive(false);
            global_variable.getcoins++;
            soundeffect.Stop();
            soundeffect.clip = soundcoin;
            soundeffect.Play();
        }
        if(other.tag=="poison" )
        {
            if(!global_variable.isshield)
            {
                other.gameObject.SetActive(false);
                ball.GetComponent<MeshRenderer>().material = poison;
                global_variable.live--;
                
                poisonstatus = true;
                returnStatus = false;
            }
            else
            {
                other.gameObject.SetActive(false);
                global_variable.isshield = false;
                closeshield = false;
                /*  GameObject shield = GameObject.Find("shield");
                  shield.SetActive(false);*/
            }

        }
        if(other.tag=="health")
        {
            other.gameObject.SetActive(false);
            global_variable.live++;
        }
        if(other.tag=="shield")
        {
            if(!global_variable.isshield)
            {
                other.gameObject.SetActive(false);
                global_variable.isshield = true;
                shieldappear.SetActive(true);
            }
            else
            {
                other.gameObject.SetActive(false);
            }
            
        }
        if(other.tag=="roadwork")
        {
            global_variable.live = 0;
            soundeffect.Stop();
            soundeffect.clip = failure;
            soundeffect.Play();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "flour")
        {
            jump = false;
            jumpPress = false;
        }
    }

}

