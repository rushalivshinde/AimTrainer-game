using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class DontshootTarget : MonoBehaviour
{
    public GameObject RandomBall;
    public Camera aimCam;
    int score = 0;
    public TextMeshProUGUI scorelbl;

    //public float damage = 50;
    // Start is called before the first frame update
    void Start()
    {

        RandomTarget();
        

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            if (Physics.Raycast(aimCam.transform.position, aimCam.transform.forward, out hit))
            {
                Debug.Log(hit.transform.name);
                Target target = hit.transform.GetComponent<Target>();
                if (target != null)
                {
                    target.Hit();
                    score++;
                }
                //Material mat = RandomColor.GetComponent()Material;

            }

        }
        scorelbl.text = "Targets Hit: " + score;
    }
    void RandomTarget()
    {
        Vector3 randomSpawn = new Vector3(Random.Range(-4, 4), Random.Range(1, 6), Random.Range(4, 1)) + transform.position;
        Instantiate(RandomBall, randomSpawn, Quaternion.identity);
    }
    
}
