using UnityEngine;
using System.Collections;

public class Burbuja : MonoBehaviour {
	public Color colorStart = Color.red;
	public Color colorEnd = Color.green;
	public float duration = 1.0F;
	public GameObject burbujas;
	public Renderer rnd;

	// Use this for initialization
	void Start () {
		rnd = GetComponent<Renderer> ();
		rnd.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		float lerp = Mathf.PingPong(Time.time, duration) / duration;
		rnd.material.color = Color.Lerp(colorStart, colorEnd, lerp);
	}

	void OnCollisionEnter(Collision Col) {
		if(Col.gameObject.GetComponents<Burbuja>()!=null){
			Destroy (burbujas);
		}

	}
}
