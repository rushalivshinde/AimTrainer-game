using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Gun[] loadout;
    public Transform weaponParent;
    private GameObject currentWeapon;
    public float damage = 100f;
   // public LayerMask canBeShot;
    private int currentIndex;
    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    //private float currentCooldown;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Equip(0);

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Equip(1);
        }

        if (currentWeapon != null)
        {


            if (Input.GetButtonDown("Fire1"))
            {
                shoot();
                //currentWeapon.transform.localPosition = Vector3.Lerp(currentWeapon.transform.localPosition, Vector3.zero, Time.deltaTime * 4f);
            }
        }

        void shoot()
        {
            muzzleFlash.Play();
            RaycastHit hit;
            
            if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, 1000f))
            {
                Debug.Log(hit.transform.name);
                Enemy bodys = hit.transform.GetComponent<Enemy>();
                if(bodys != null)
                {
                    bodys.TakeDamage(damage);
                }
            }
            
        }
        void Equip(int p_ind)
        {
            if (currentWeapon != null)
            {
                Destroy(currentWeapon);
            }
            GameObject t_newEquip = Instantiate(loadout[p_ind].prefab, weaponParent.position, weaponParent.rotation, weaponParent) as GameObject;
            t_newEquip.transform.localPosition = Vector3.zero;
            t_newEquip.transform.localEulerAngles = Vector3.zero;

            currentWeapon = t_newEquip;
        }
    }
}
