using UnityEngine;
using System.Collections;

public class OberschichtBlockgenerator : MonoBehaviour {
    public GameObject Oberschicht;
    public Sprite Dirt;
	// Use this for initialization
	void Start () {
        if (gameObject.transform.position.x > PlayerPrefs.GetFloat("linkeWeltgroesse"))
        {
            Instantiate(Oberschicht, new Vector3(gameObject.transform.position.x - 0.5f, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);
        }
        if (Random.RandomRange(0,10) > 8)
        {
            Instantiate(Oberschicht, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y +0.5f, gameObject.transform.position.z), Quaternion.identity);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
