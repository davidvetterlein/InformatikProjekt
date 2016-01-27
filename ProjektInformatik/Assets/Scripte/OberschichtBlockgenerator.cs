using UnityEngine;
using System.Collections;

public class OberschichtBlockgenerator : MonoBehaviour {
    public GameObject Oberschicht;
    public Sprite Dirt;
    public GameObject Grund;
    int zufall = 0;
	// Use this for initialization
	void Start () {
        zufall = Random.RandomRange(0, 10);
        if (zufall > 8)
        {
            Instantiate(Grund, new Vector3(gameObject.transform.position.x -0.5f, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);
            Instantiate(Oberschicht, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y +0.5f, gameObject.transform.position.z), Quaternion.identity);
            gameObject.GetComponent<SpriteRenderer>().sprite = Dirt;
        }
        if (zufall <= 8 && gameObject.transform.position.x > PlayerPrefs.GetFloat("linkeWeltgroesse"))
        {
            Instantiate(Oberschicht, new Vector3(gameObject.transform.position.x - 0.5f, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
