using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class road_generate : MonoBehaviour
{
    public GameObject rightRoad;
    public GameObject leftRoad;
    public GameObject trapRoad;
    public GameObject bonusobject;
    public GameObject poisonobject;
    public GameObject healthobject;
    public GameObject turtleobject;
    public GameObject Barrierobject;
    public GameObject RoadConeobject;
    public GameObject Barrierobject2;
    public GameObject powerPoleobject;
    public GameObject powerPipeobject;
    public GameObject Prop_DoNotEnter_Sign;
    public GameObject bridge;
    public GameObject bottleshield;
    public GameObject GiveWaySign;
    public GameObject Roadcone2;
    public AudioClip backgroundmusic;
    public GameObject stone1;
    public GameObject stone2;
    public GameObject stone3;
    public GameObject ground1;
    public GameObject ground2;

    // Start is called before the first frame update
    void Start()
    {
        backgroundmusic.LoadAudioData();
        for (int i=1;i<=1000;i++)
        {
            int trap = Random.Range(0, 20);
            if (trap >= 1)
            {
                Instantiate(rightRoad, new Vector3(20f + i * 5f, 0f, 0f), new Quaternion(0, 0, 0, 0), rightRoad.transform.parent);
            }
            else
            {
                Instantiate(trapRoad, new Vector3(15f + i * 5f, 0f, 0f), new Quaternion(0, 0, 0, 0), trapRoad.transform.parent);
                i += 2;
            }
            
        }
        for (int j = 1; j <= 1000; j++)
        {
            int trapleft = Random.Range(0, 20);
            if (trapleft >= 1)
            {
                Instantiate(leftRoad, new Vector3(15f + j * 5f, 0f, -20f), new Quaternion(0, 180, 0, 0), leftRoad.transform.parent);
            }
            else
            {
                Instantiate(trapRoad, new Vector3(30f + j * 5f, 0f, -20f), new Quaternion(0, 180, 0, 0), trapRoad.transform.parent);
                j += 2;
            }
        }

        for(int h=1; h<=300;h++)
        {
            int bonusPosX= Random.Range(0, 5000);
            int bonusPosZ= Random.Range(300, 1700);
            float RealbonusPosZ = -bonusPosZ / 100;
            Instantiate(bonusobject, new Vector3(bonusPosX,0.19f, RealbonusPosZ), new Quaternion(0, 0, 0, 0), bonusobject.transform.parent);
        }

        for (int k = 1; k <= 100; k++)
        {
            int bonusPosX = Random.Range(0, 5000);
            int bonusPosZ = Random.Range(300, 1700);
            float RealbonusPosZ = -bonusPosZ / 100;
            Instantiate(poisonobject, new Vector3(bonusPosX, -0.35f, RealbonusPosZ), new Quaternion(0, 0, 0, 0), poisonobject.transform.parent);
        }

        for (int l = 1; l <= 100; l++)
        {
            int bonusPosX = Random.Range(0, 5000);
            int bonusPosZ = Random.Range(300, 1700);
            float RealbonusPosZ = -bonusPosZ / 100;
            Instantiate(healthobject, new Vector3(bonusPosX, -0.35f, RealbonusPosZ), new Quaternion(0, 0, 0, 0), healthobject.transform.parent);
        }

        for (int l = 1; l <= 100; l++)
        {
            int bonusPosX = Random.Range(0, 5000);
            int bonusPosZ = Random.Range(300, 1700);
            float RealbonusPosZ = -bonusPosZ / 100;
            Instantiate(bottleshield, new Vector3(bonusPosX, -0.35f, RealbonusPosZ), new Quaternion(0, 0, 0, 0), bottleshield.transform.parent);
        }
        for (int l = 1; l <= 70; l++)
        {
            int bonusPosX = Random.Range(0, 5000);
            int bonusPosZ = Random.Range(300, 1700);
            float RealbonusPosZ = -bonusPosZ / 100;
            Instantiate(turtleobject, new Vector3(bonusPosX, 8.940697e-08f, RealbonusPosZ), new Quaternion(0, 0, 0, 0), turtleobject.transform.parent);
        }

        for (int l = 1; l <= 70; l++)
        {
            int bonusPosX = Random.Range(0, 5000);
            int bonusPosZ = Random.Range(300, 1700);
            int rotate= Random.Range(100, 130);
            float RealbonusPosZ = -bonusPosZ / 100;
            Instantiate(Barrierobject, new Vector3(bonusPosX, -0.2825317f, RealbonusPosZ), Barrierobject.transform.rotation, Barrierobject.transform.parent);
        }

        for (int l = 1; l <= 70; l++)
        {
            int bonusPosX = Random.Range(0, 5000);
            int bonusPosZ = Random.Range(300, 1700);
            int rotate = Random.Range(100, 130);
            float RealbonusPosZ = -bonusPosZ / 100;
            Instantiate(RoadConeobject, new Vector3(bonusPosX, -0.2825317f, RealbonusPosZ), RoadConeobject.transform.rotation, RoadConeobject.transform.parent);
        }
        for (int l = 1; l <= 70; l++)
        {
            int bonusPosX = Random.Range(0, 5000);
            int bonusPosZ = Random.Range(300, 1700);
            int rotate = Random.Range(100, 130);
            float RealbonusPosZ = -bonusPosZ / 100;
            Instantiate(Barrierobject2, new Vector3(bonusPosX, -0.2825317f, RealbonusPosZ), Barrierobject2.transform.rotation, Barrierobject2.transform.parent);
        }
        for (int l = 0; l <= 399; l++)
        {
            Instantiate(powerPoleobject, new Vector3(-7.423345f+ l*12.5f ,-0, -0.2454433f), powerPoleobject.transform.rotation, powerPoleobject.transform.parent);
            Instantiate(powerPoleobject, new Vector3(-7.423345f + l * 12.5f, -0, -19.41f), powerPoleobject.transform.rotation, powerPoleobject.transform.parent);
        }
        for (int l = 0; l <= 133; l++)
        {
            Instantiate(powerPipeobject, new Vector3(5.950225f + l * 8.3503f, 9.015297f, -0.2454433f), powerPipeobject.transform.rotation, powerPipeobject.transform.parent);
            Instantiate(powerPipeobject, new Vector3(5.950225f + l * 8.3503f, 9.015297f, -19.41f), powerPipeobject.transform.rotation, powerPipeobject.transform.parent);
        }
        for (int l = 1; l <= 70; l++)
        {
            int bonusPosX = Random.Range(0, 5000);
            int bonusPosZ = Random.Range(300, 1700);
            int rotate = Random.Range(100, 130);
            float RealbonusPosZ = -bonusPosZ / 100;
            Instantiate(Prop_DoNotEnter_Sign, new Vector3(bonusPosX, 0f, RealbonusPosZ), Prop_DoNotEnter_Sign.transform.rotation, Prop_DoNotEnter_Sign.transform.parent);
        }

        for (int l = 0; l <= 35; l++)
        {
            int a = Random.Range(0, 20);
            Instantiate(bridge, new Vector3(40f+l*200+a*10,0, -10.05f), bridge.transform.rotation, bridge.transform.parent);
        }
        for (int l = 0; l <= 30; l++)
        {
            int a = Random.Range(0, 20);
            Instantiate(GiveWaySign, new Vector3(40f + l * 200 + a * 10, 0, -18.48f), GiveWaySign.transform.rotation, GiveWaySign.transform.parent);
        }
        for (int l = 1; l <= 70; l++)
        {
            int bonusPosX = Random.Range(0, 5000);
            int bonusPosZ = Random.Range(300, 1700);
            int rotate = Random.Range(100, 130);
            float RealbonusPosZ = -bonusPosZ / 100;
            Instantiate(Roadcone2, new Vector3(bonusPosX, -0.3f, RealbonusPosZ), Roadcone2.transform.rotation, Roadcone2.transform.parent);
        }
        for (int l = 1; l <= 50; l++)
        {
            int bonusPosX = Random.Range(0, 5000);
            int bonusPosZ = Random.Range(300, 1700);
            int rotate = Random.Range(100, 130);
            float RealbonusPosZ = -bonusPosZ / 100;
            Instantiate(stone1, new Vector3(bonusPosX, 0.1f, RealbonusPosZ), stone1.transform.rotation, stone1.transform.parent);
        }
        for (int l = 1; l <= 50; l++)
        {
            int bonusPosX = Random.Range(0, 5000);
            int bonusPosZ = Random.Range(300, 1700);
            int rotate = Random.Range(100, 130);
            float RealbonusPosZ = -bonusPosZ / 100;
            Instantiate(stone2, new Vector3(bonusPosX, 0.1f, RealbonusPosZ), stone2.transform.rotation, stone2.transform.parent);
        }
        for (int l = 1; l <= 50; l++)
        {
            int bonusPosX = Random.Range(0, 5000);
            int bonusPosZ = Random.Range(300, 1700);
            int rotate = Random.Range(100, 130);
            float RealbonusPosZ = -bonusPosZ / 100;
            Instantiate(stone3, new Vector3(bonusPosX, 0.1f, RealbonusPosZ), stone3.transform.rotation, stone3.transform.parent);
        }
        for (int i = 1; i <= 1000; i++)
        {
            int hill = Random.Range(0, 20);
            if (hill >= 6)
            {
                Instantiate(ground1, new Vector3(4.24f + i * 25f, 0f, 13.13f), new Quaternion(0, 0, 0, 0), rightRoad.transform.parent);
            }
            else
            {
                Instantiate(ground2, new Vector3(4.24f + i * 25f, 0f, 13.13f), new Quaternion(0, 0, 0, 0), trapRoad.transform.parent);
               
            }
           
        }
        for (int j = 1; j <= 200; j++)
        {
            int hillleft = Random.Range(0, 20);
            if (hillleft >= 8)
            {
                Instantiate(ground1, new Vector3(4.24f + j * 25f, 0f, -33.62f), new Quaternion(0, 180, 0, 0), leftRoad.transform.parent);
            }
            else
            {
                Instantiate(ground2, new Vector3(4.24f + j * 25f, 0f, -33.62f), new Quaternion(0, 180, 0, 0), trapRoad.transform.parent);
                
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
