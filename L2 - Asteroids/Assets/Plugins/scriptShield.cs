using UnityEngine;
using System.Collections;

public class scriptShield : MonoBehaviour {
    // Inspector variables
    public int shieldStrength = 2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (shieldStrength <= 0)
        {
            Destroy(gameObject);
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "asteroid")
        {
            shieldStrength -= 1;
        }
    }   
}
