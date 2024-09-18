using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Gun", menuName ="Gun")]
public class Gun : ScriptableObject
{

    public string Gname;
    public float firerate;
    public float recoil;
    public float bloom;
    public float aimSpeed;
    public float kickbackk;
    public GameObject prefab;
    // Start is called before the first frame update

}
