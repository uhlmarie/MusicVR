using System.Collections;

using System.Linq;

using UnityEngine;



public class PlayKeyRandom : MonoBehaviour

{

    public GameObject[] keys;

    public GameObject applause;

    public GameObject noKeyClicked;





    private void Start()

    {

        keys = GameObject.FindGameObjectsWithTag("PianoKeyAll");

    }



    private IEnumerator Random()

    {

        //TODO: converted for i to foreach because index was never used.

        foreach (var key in keys)

        {

            int rn = UnityEngine.Random.Range(0, keys.Length);

            keys[rn].GetComponent<AudioSource>().Play();

            //TODO: extracted to variables for better readability

            var highlightedKeyOutline = keys[rn].transform.GetChild(1).gameObject;

            var playableKey = keys[rn].transform.GetChild(0);



            highlightedKeyOutline.SetActive(true);

            //TODO: removed keyClicked name and only checked for tag. Also removed "highlighted" tag.

            yield return new WaitForSeconds(6f);

            //TODO: alle gedrückten Keys ermitteln

            var clickedKeys = GameObject.FindGameObjectsWithTag("keyClicked");

            if (!playableKey.CompareTag("keyClicked") && clickedKeys.Length > 0)

            {

                //Falsche Taste

                playableKey.GetComponent<AudioSource>().Play();
               
            }

            else if (!playableKey.CompareTag("keyClicked") && clickedKeys.Length == 0)

            {

                //TODO: zu langsam sound einfügen?
                noKeyClicked.GetComponent<AudioSource>().Play();
                Debug.Log("Too slow.");

                //too slow

            }


            Debug.Log("now after conditionals");
            highlightedKeyOutline.SetActive(!true);

         

            playableKey.gameObject.tag = "Untagged";

            foreach (var clickedKey in clickedKeys)

            {

                clickedKey.tag = "Untagged";

            }

            yield return new WaitForSeconds(6f);

        }



        //yield return new WaitForSeconds(5f);

        //applause.GetComponent<AudioSource>().Play();

    }



    public void PlayRandom()

    {

        StartCoroutine(Random());

    }

}