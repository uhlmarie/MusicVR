using System.Collections;
using UnityEngine;

public class PlayKeyRandom : MonoBehaviour

{
    public GameObject[] keys;
    public GameObject noKeyClicked;
    
    private void Start()

    {
        keys = GameObject.FindGameObjectsWithTag("PianoKeyAll");
    }

    private IEnumerator Random()

    {
        foreach (var key in keys)

        {
            int rn = UnityEngine.Random.Range(0, keys.Length);
            keys[rn].GetComponent<AudioSource>().Play();
            var highlightedKeyOutline = keys[rn].transform.GetChild(1).gameObject;
            var playableKey = keys[rn].transform.GetChild(0);

            highlightedKeyOutline.SetActive(true);
            yield return new WaitForSeconds(6f);
            var clickedKeys = GameObject.FindGameObjectsWithTag("keyClicked");

            if (!playableKey.CompareTag("keyClicked") && clickedKeys.Length > 0)
            {
                playableKey.GetComponent<AudioSource>().Play();
            }
            else if (!playableKey.CompareTag("keyClicked") && clickedKeys.Length == 0)
            {
                noKeyClicked.GetComponent<AudioSource>().Play();
            }
            highlightedKeyOutline.SetActive(!true);
            playableKey.gameObject.tag = "Untagged";

            foreach (var clickedKey in clickedKeys)
            {
                clickedKey.tag = "Untagged";
            }
            yield return new WaitForSeconds(6f);
        }
    }


    public void PlayRandom()
    {
        StartCoroutine(Random());
    }
}