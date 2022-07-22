using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayKeyRandom : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] keys;
    public GameObject applause;



    private void Start()
    {
        keys = GameObject.FindGameObjectsWithTag("PianoKeyAll");

    }
    IEnumerator random()
    {
        for (int i = 0; i < keys.Length; i++)
        {
            int rn = Random.Range(0, keys.Length);
            keys[rn].GetComponent<AudioSource>().Play();
            keys[rn].transform.GetChild(1).gameObject.SetActive(true);
            keys[rn].transform.GetChild(0).gameObject.tag = "highlighted";
            yield return new WaitForSeconds(3f);
            if ((keys[rn].transform.GetChild(0).name != "keyClicked" && keys[rn].transform.GetChild(0).gameObject.tag == "highlighted") 
                || (keys[rn].transform.GetChild(0).name == "keyClicked" && keys[rn].transform.GetChild(0).gameObject.tag != "highlighted") 
                || (keys[rn].transform.GetChild(0).name != "keyClicked" && keys[rn].transform.GetChild(0).gameObject.tag != "highlighted")
                )
            {
                keys[rn].transform.GetChild(0).GetComponent<AudioSource>().Play();
            }
            keys[rn].transform.GetChild(1).gameObject.SetActive(!true);
            keys[rn].transform.GetChild(0).gameObject.tag = "Untagged";
            Debug.Log("Layer should be default");
            keys[rn].transform.GetChild(0).name = "MovingKey";
            Debug.Log("Name should be Movingkey");

        }
        yield return new WaitForSeconds(3f);
        applause.GetComponent<AudioSource>().Play();
    }
    public void PlayRandom()
    {
        StartCoroutine(random());
    }
}

