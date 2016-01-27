using UnityEngine;
using System.Collections;

public class UnterschichtGenerator : MonoBehaviour {
    public GameObject Unterschicht;
    public GameObject Grund;
	// Use this for initialization
	void Start () {
        if (gameObject.transform.position.y > PlayerPrefs.GetFloat("untereWeltgroesse"))
        {
            Instantiate(Unterschicht, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y -0.5f, gameObject.transform.position.z), Quaternion.identity);
        }

        Instantiate(Grund, new Vector3(gameObject.transform.position.x - 0.5f, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
