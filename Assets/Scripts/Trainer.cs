using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Trainer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject targetPrefab;
    public static Trainer instance;
    public static bool gameOver;
    public static int targetsHit = 1;
   // public static int accuracy;
    public static int targetsMissed = 1;
    public GameObject PistolGun;

    public Slider accuracySlider;
    //public static List<GameObject> targets = new List<GameObject>();

    public TextMeshProUGUI targetsHitlbl, targetsMissedlbl, accuracylbl;


    void Start()
    {
        SpawnTargets();
        gameOver = false;
        instance = this;
    }


    // Update is called once per frame
    void Update()
    {
        int sum = targetsHit + targetsMissed;
        accuracySlider.value = targetsHit * 100 / sum;


        targetsHitlbl.text = "Targets Hit: " + targetsHit;
        targetsMissedlbl.text = "Targets Missed: " + targetsMissed;
        accuracylbl.text = "Accuracy: " + accuracySlider.value + "%";

       // if (Input.GetButtonDown("Fire"))
     //   {
           // Instantiate(PistolGun, PistolGun.transform.position, PistolGun.transform.rotation);
       // }
        if (gameOver == true)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(0);
                targetsHit = 1;
                targetsMissed = 1;
            }
        }


    }
    public void SpawnTargets()
    {
        Vector3 randomSpawn = new Vector3(Random.Range(-3, 2), Random.Range(4, 1), Random.Range(11, 8));
        Instantiate(targetPrefab, randomSpawn, Quaternion.identity);
    }
}
