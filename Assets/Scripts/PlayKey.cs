using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

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
    private int points;
    public TMP_Text pointsText;
    public GameObject noKeyClickedAudio;
    
    private void Start()

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

        points = 0;
    }


    private void Update()

    {
        pointsText.SetText("Punkte: " + points);
    }


    public void PlayAlleMeineEntchen()

    {
        StartCoroutine(AlleMeineEntchen());
    }


    private IEnumerator AlleMeineEntchen()

    {
        var alleMeineEntchenList = new List<GameObject>

        {
            keyC2, keyD, keyE2, keyF3, keyG, keyA2, keyA, keyA3, keyA2, keyG, keyA1, keyA, keyA, keyA3, keyG1, keyF,
            keyF, keyF2, keyF, keyE3, keyE, keyD, keyD2, keyD2, keyD1, keyC
        };

        foreach (var key in alleMeineEntchenList)
        {
            StartCoroutine(HighlightAndCheckForKey(key));
            yield return new WaitForSeconds(7f);
        }
    }
    
    public void StopAllRoutines()

    {
        GameObject.Find("MovingKey (1)").SetActive(false);
        StopAllCoroutines();
    }


    public void playHanschenKlein()

    {
        StartCoroutine(HaenschenKlein());
    }


    private IEnumerator HaenschenKlein()

    {
        var haenschenKleinList = new List<GameObject>
        {
            keyG, keyE2, keyE1, keyF3, keyD, keyD2, keyC, keyD1, keyE3, keyF3, keyG2, keyG, keyG3, keyG2, keyE1, keyE2,
            keyF3, keyD, keyD1, keyC3, keyE, keyG1, keyG3, keyC2
        };
        
        foreach (var key in haenschenKleinList)
        {
            StartCoroutine(HighlightAndCheckForKey(key));
            yield return new WaitForSeconds(7f);
        }
        applause.GetComponent<AudioSource>().Play();
    }


    private IEnumerator HighlightAndCheckForKey(GameObject keyToPlay)

    {
        keyToPlay.GetComponent<AudioSource>().Play();
        var highlightedKeyOutline = keyToPlay.transform.GetChild(1).gameObject;
        var playableKey = keyToPlay.transform.GetChild(0);
        
        highlightedKeyOutline.SetActive(true);
        
        yield return new WaitForSeconds(6f);
        
        var clickedKeys = GameObject.FindGameObjectsWithTag("keyClicked");

        if (playableKey.gameObject.CompareTag("keyClicked") && clickedKeys.Contains(playableKey.gameObject))
        {
            points += 1;
        }
        else if (!playableKey.gameObject.CompareTag("keyClicked") && clickedKeys.Length > 0)
        {
            playableKey.GetComponent<AudioSource>().Play();
        }
        
        else
        {
            noKeyClickedAudio.GetComponent<AudioSource>().Play();
        }
        
        highlightedKeyOutline.SetActive(!true);
        playableKey.gameObject.tag = "PianoKey";
        foreach (var clickedKey in clickedKeys)
        {
            clickedKey.tag = "PianoKey";
        }

        yield return new WaitForSeconds(6f);
    }
}