using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    // Start is called before the first frame update
    public float health = 50f;

    public float uniformScaleMax = 3f;
    public float uniformScaleMin = .5f;
    public bool scaleUniforrmly = true;
    public float speed = 3;

    private void Start()
    {
        randomizeScale();

    }
    private void Update()
    {
        transform.Translate(transform.right * speed * Time.deltaTime);
       // Vector3 movementDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
       // movementDirection = Vector3.ClampMagnitude(movementDirection, 1);
        //transform.Translate(movementDirection * speed * Time.deltaTime);
    }
    public void Hit()
    {
        transform.position = new Vector3(Random.Range(-17, 17), Random.Range(9, -3), Random.Range(8, 22));
        

    }
    public void TakeDamage(float amount)
    {
        health -= amount;
        if(health <= 0f)
        {
            Die();
            
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

    void randomizeScale()
    {
        Vector3 randomizedScale = Vector3.one;

        if (scaleUniforrmly)
        {
            float uniformScale = Random.Range(uniformScaleMax, uniformScaleMin);
            randomizedScale = new Vector3(uniformScale, uniformScale, uniformScale);
        }
        transform.localScale = randomizedScale;
    }

}
