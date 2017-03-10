using UnityEngine;
using System.Collections;

public class Burbuja : MonoBehaviour {

	public GameObject burbujas;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision Col) {
		if(Col.gameObject.GetComponents<Burbuja>()!=null){
			Destroy (burbujas);
		}

	}
}
