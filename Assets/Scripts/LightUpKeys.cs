

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LightUpKeys : MonoBehaviour
{
    public GameObject[] Keys;
    private System.Random rand = new System.Random();
    public Material highlightMaterial;
    private Texture2D blankTexture;
    // Start is called before the first frame update
    void Start()
    {
        Keys = GameObject.FindGameObjectsWithTag("PianoKey");
        //blankTexture = new Texture2D(blankTexture.width, blankTexture.height, TextureFormat.ARGB32, false);
        lightUpKey();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void lightUpKey()
    {
        var min = 0;
        var max = Keys.Length;
        var keyToLightUp = rand.Next(min, max);
        Debug.Log("Old texture" +Keys[keyToLightUp].GetComponent<MeshRenderer>().material.mainTexture.name);
        Keys[keyToLightUp].GetComponent<Renderer>().material = highlightMaterial;
        //Keys[keyToLightUp].GetComponent<MeshRenderer>().material.mainTexture = blankTexture;
        Color test = new Color(0, 1, 0, 1);
        Keys[keyToLightUp].GetComponent<Material>().color = Color.green;

        Debug.Log("Current Color" + Keys[keyToLightUp].GetComponent<Material>().color);

        Debug.Log("Changed color of " + Keys[keyToLightUp].name);

    }
}
