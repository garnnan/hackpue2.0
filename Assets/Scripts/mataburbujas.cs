using UnityEngine;
using System.Collections;

public class mataburbujas : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision Col) {
		if(Col.gameObject.GetComponents<Burbuja>()!=null){
			Debug.Log ("mataste burbujas");
		}

	}
}
