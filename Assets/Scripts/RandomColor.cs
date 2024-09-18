using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    public Renderer renderers;
    public Material[] mattochoose;
    // Start is called before the first frame update
    void Start()
    {
        //Color newColor = Random.ColorHSV(0f, .25f, 0.4f, 1f);
        //ApplyMaterial(newColor, 0);

        renderers.material = mattochoose[Random.Range(0, mattochoose.Length)];
    }


    // Update is called once per frame
    /*private void ApplyMaterial(Color color, int targetMaterianIndex)
    {
        Material generatedMaterial = new Material(Shader.Find("Standard"));
        generatedMaterial.SetColor("_Color", color);
        for(int i=0; i<renderers.Length; i++)
        {
            renderers[i].material = generatedMaterial;
        }
    }*/
}
