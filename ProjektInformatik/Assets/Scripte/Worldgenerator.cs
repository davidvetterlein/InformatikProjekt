using UnityEngine;
using System.Collections;

public class Worldgenerator : MonoBehaviour {
    public GameObject Startblock;                                                       //Erster Block Variablen
    public Vector3 startStartblock;
                                                                                        //Weltgroessen Variablen
    public int linkeWeltgroesse = 0;
    //public int rechteWeltgroesse = 0;
    //public int obereWeltgroesse = 0;
    public int untereWeltgroesse = 0;

    // Use this for initialization
    void Start () {       
        PlayerPrefs.SetFloat("linkeWeltgroesse", linkeWeltgroesse);                       //Weltgroessen
        //PlayerPrefs.SetInt("rechteWeltgroesse", rechteWeltgroesse);
        //PlayerPrefs.SetInt("obereWeltgroesse", obereWeltgroesse);
        PlayerPrefs.SetFloat("untereWeltgroesse", untereWeltgroesse);

        Instantiate(Startblock, startStartblock, Quaternion.identity);                  //Erster Block
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
