using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GunScript : MonoBehaviour
{
    public float damage = 50;
    public Camera fpsCam;
    public float range = 100f;
    public ParticleSystem muzzleFlash;
    public AudioSource shot;
    public AudioSource shotball;
    public static int targetsHit;
    public static int targetsMiss;
    public TextMeshProUGUI targetsHitlbl;
    public TextMeshProUGUI targetsMisslbl, accuracylbl;
    public Slider accuracySlider;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shot.Play();
            Shoot();
        }
        
        {
            targetsMisslbl.text = "Missed: " + targetsMiss;
            
        }
        targetsHitlbl.text = "Targets Hit: " + targetsHit;
        int sum = targetsHit + targetsMiss;
        accuracySlider.value = targetsHit * 100 / sum;
        accuracylbl.text = "Accuracy: " + accuracySlider.value + "%";
    }

    void Shoot()
    {
        muzzleFlash.Play();
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
                shotball.Play();
                targetsHit = targetsHit + 1;
            }
            else
            {
                targetsMiss++;
            }
        }

    }
}
