using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class PlayKey : MonoBehaviour
{

    List<GameObject> keys = new List<GameObject>();
    private GameObject keyC;
    private GameObject keyD;
    private GameObject keyE;
    private GameObject keyF;
    private GameObject keyG;
    private GameObject keyA;
    public Material highlightMaterial;
    // Start is called before the first frame update
    async void Start()
    {
        keyC = GameObject.Find("C");
        keyD = GameObject.Find("D");
        keyE = GameObject.Find("E");
        keyF = GameObject.Find("F");
        keyG = GameObject.Find("G");
        keyA = GameObject.Find("A");

    }
  
    IEnumerator setDelay()
    {
        keyC.GetComponent<AudioSource>().Play();
        var childC = keyC.transform.GetChild(0).gameObject;
        childC.GetComponent<Renderer>().material = highlightMaterial;
        yield return new WaitForSeconds(1f);
        keyD.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(1f);
        keyE.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(1f);
        keyF.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(1f);
        keyG.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(1f);
        keyG.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(1f);
        keyA.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(0.5f);
        keyA.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(0.5f);
        keyA.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(0.5f);
        keyA.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(0.5f);
        keyG.GetComponent<AudioSource>().Play();
    }

    public void OnHandPressTriggered()
    {
        StartCoroutine(setDelay());
    }
}
