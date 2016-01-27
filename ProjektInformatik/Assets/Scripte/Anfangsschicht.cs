using UnityEngine;
using System.Collections;

public class Anfangsschicht : MonoBehaviour {
    public GameObject Oberschicht;
    public GameObject Unterschicht;
	// Use this for initialization
	void Start () {
        Instantiate(Oberschicht, new Vector3(gameObject.transform.position.x -0.5f, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);
        Instantiate(Unterschicht, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y -0.5f, gameObject.transform.position.z), Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
