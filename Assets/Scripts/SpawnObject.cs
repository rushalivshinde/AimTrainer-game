using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public Vector2 center;
    public Vector2 size;

    public GameObject itemToSpread;

    
    // Start is called before the first frame update
    void Start()
    {
        //SpreadItem();
        InvokeRepeating("SpreadItem", 1.0f, 0.8f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpreadItem()
    {
        Vector3 randomSpawn = new Vector3(Random.Range(-3, 4), Random.Range(1, 5), Random.Range(4, 1)) + transform.position;
        GameObject clone = Instantiate(itemToSpread, randomSpawn, Quaternion.identity);
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawCube(center, size);
    }
}
