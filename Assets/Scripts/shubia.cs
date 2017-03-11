using UnityEngine;
using System.Collections;

public class shubia : MonoBehaviour {

	public float xi = 0,yi = 10,xf=100,cantidad = 10,zi=0,zf=100;
	public GameObject burbujas;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < cantidad; i++) {
			burbujas.transform.position = new Vector3 (Random.Range (xi, xf) , yi,Random.Range(zi,zf));
			Instantiate (burbujas);
		}
	}
}
