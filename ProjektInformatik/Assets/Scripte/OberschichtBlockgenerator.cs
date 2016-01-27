using UnityEngine;
using System.Collections;

public class OberschichtBlockgenerator : MonoBehaviour {
    public GameObject Oberschichtoben;
    public GameObject Oberschichtunten;
    public Sprite Dirt;
    public GameObject Grund;
    int zufall = 0;
    int wechsel = 0;
	// Use this for initialization
	void Start () {
        zufall = Random.RandomRange(0, 10);
        wechsel = Random.RandomRange(0, 15);

        if (wechsel > 9)
        {
            gameObject.tag = "unten";
        } else if( wechsel <= 9)
        {
            gameObject.tag = "oben";
        }

        if (zufall > 8 && gameObject.tag == "oben")
        {
            //Instantiate(Grund, new Vector3(gameObject.transform.position.x -0.5f, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);
            Instantiate(Oberschichtoben, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y +0.5f, gameObject.transform.position.z), Quaternion.identity);
            gameObject.GetComponent<SpriteRenderer>().sprite = Dirt;
        }
        if (zufall > 8 && gameObject.tag == "unten")
        {
            //Instantiate(Grund, new Vector3(gameObject.transform.position.x - 0.5f, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);
            Instantiate(Oberschichtunten, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 0.5f, gameObject.transform.position.z), Quaternion.identity);
            //gameObject.GetComponent<SpriteRenderer>().sprite = Dirt;
        }

        if (zufall <= 8 && gameObject.transform.position.x > PlayerPrefs.GetFloat("linkeWeltgroesse") && gameObject.tag == "oben")
        {
            Instantiate(Oberschichtoben, new Vector3(gameObject.transform.position.x - 0.5f, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);
        }
        if (zufall <= 8 && gameObject.transform.position.x > PlayerPrefs.GetFloat("linkeWeltgroesse") && gameObject.tag == "unten")
        {
            Instantiate(Oberschichtunten, new Vector3(gameObject.transform.position.x - 0.5f, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
