using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loseCond : MonoBehaviour {

	public GameObject textPrefab;
	public GameObject canvas;
	private GameObject textEnd;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider colider) {
		Debug.Log("detect colision");
		textEnd = Instantiate(textPrefab);
		textEnd.transform.SetParent(canvas.GetComponent<Transform> ());
		textEnd.transform.localPosition = new Vector3(0.5f,0.5f,0.5f);
	}
}
