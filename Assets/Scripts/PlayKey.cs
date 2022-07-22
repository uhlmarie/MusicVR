using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class PlayKey : MonoBehaviour
{
    private GameObject keyC;
    private GameObject keyD;
    private GameObject keyE;
    private GameObject keyF;
    private GameObject keyG;
    private GameObject keyA;
    private GameObject keyD1;
    private GameObject keyE1;
    private GameObject keyG1;
    private GameObject keyA1;
    private GameObject keyC2;
    private GameObject keyD2;
    private GameObject keyE2;
    private GameObject keyF2;
    private GameObject keyG2;
    private GameObject keyA2;
    private GameObject keyC3;
    private GameObject keyE3;
    private GameObject keyF3;
    private GameObject keyG3;
    private GameObject keyA3;
    public GameObject applause;
    public GameObject done;



    // Start is called before the first frame update
    void Start()
    {
        keyC = GameObject.Find("C");
        keyD = GameObject.Find("D");
        keyE = GameObject.Find("E");
        keyF = GameObject.Find("F");
        keyG = GameObject.Find("G");
        keyA = GameObject.Find("A");
        keyD1 = GameObject.Find("D1");
        keyE1 = GameObject.Find("E1");
        keyG1 = GameObject.Find("G1");
        keyA1 = GameObject.Find("A1");
        keyC2 = GameObject.Find("C2");
        keyD2 = GameObject.Find("D2");
        keyE2 = GameObject.Find("E2");
        keyF2 = GameObject.Find("F2");
        keyG2 = GameObject.Find("G2");
        keyA2 = GameObject.Find("A2");
        keyC3 = GameObject.Find("C3");
        keyE3 = GameObject.Find("E3");
        keyF3 = GameObject.Find("F3");
        keyG3 = GameObject.Find("G3");
        keyA3 = GameObject.Find("A3");
 

        

        done.SetActive(false);
 
    }

    IEnumerator alleMeineEntchen()
    {
        StartCoroutine(HighlightAndCheckForKey(keyC2));
        //keyC2.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        StartCoroutine(HighlightAndCheckForKey(keyD));
        yield return new WaitForSeconds(3f);
        keyE2.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyF3.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyG.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyG.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyA2.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyA.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyA3.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyA2.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyG.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyA1.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyA.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyA.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyA3.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyG1.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyF.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyF.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyF2.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyF.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyE3.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyE.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyD.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyD2.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyD2.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyD1.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyC.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        done.SetActive(true);
        applause.GetComponent<AudioSource>().Play();
    }

    public void PlayAlleMeineEntchen()
    {
        StartCoroutine(alleMeineEntchen());
    }

    public void StopAllRoutines()
    {
        var arrows = GameObject.FindGameObjectsWithTag("Arrow");
        foreach (var arrow in arrows)
        {
            arrow.gameObject.SetActive(!true);
        }
        StopAllCoroutines();
    }

    IEnumerator hanschenKlein()
    {
        keyG.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyE2.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyE1.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyF3.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyD.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyD2.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyC.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyD1.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyE3.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyF3.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyG2.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyG.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyG3.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyG2.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyE1.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyE2.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyF3.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyD.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyD1.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyC3.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyE.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyG1.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyG3.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        keyC2.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        done.SetActive(true);
        applause.GetComponent<AudioSource>().Play();

    }

    public void playHanschenKlein()
    {
        StartCoroutine(hanschenKlein());
    }

    public IEnumerator HighlightAndCheckForKey(GameObject keyToPlay)
    {
        keyToPlay.GetComponent<AudioSource>().Play();
        keyToPlay.transform.GetChild(1).gameObject.SetActive(true);
        keyToPlay.transform.GetChild(0).gameObject.tag = "highlighted";
        yield return new WaitForSeconds(3f);
        if ((keyToPlay.transform.GetChild(0).name != "keyClicked" && keyToPlay.transform.GetChild(0).gameObject.tag == "highlighted")
            || (keyToPlay.transform.GetChild(0).name == "keyClicked" && keyToPlay.transform.GetChild(0).gameObject.tag != "highlighted")
            || (keyToPlay.transform.GetChild(0).name != "keyClicked" && keyToPlay.transform.GetChild(0).gameObject.tag != "highlighted")
            )
        {
            keyToPlay.transform.GetChild(0).GetComponent<AudioSource>().Play();
            yield return new WaitForSeconds(2f);
        }
        keyToPlay.transform.GetChild(1).gameObject.SetActive(!true);
        keyToPlay.transform.GetChild(0).gameObject.tag = "PianoKey";
        keyToPlay.transform.GetChild(0).name = "MovingKey";
    }
}
