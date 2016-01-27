using UnityEngine;
using System.Collections;

public class Grundschicht : MonoBehaviour {
    public GameObject Grund;
	// Use this for initialization
	void Start () {
	    if(gameObject.transform.position.x > PlayerPrefs.GetFloat("linkeWeltgroesse"))
        {
            Instantiate(Grund, new Vector3(gameObject.transform.position.x - 0.5f, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
