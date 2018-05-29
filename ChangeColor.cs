using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
	ParticleSystem par;
	Transform transfrom;
	// Use this for initialization
	void Start () {
		par = GetComponent<ParticleSystem> ();
		transfrom = GetComponent<Transform> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.UpArrow)) {
			transform.position += -transform.up * Time.deltaTime * 10;
			par.startColor = Color.red;
		}
		if (Input.GetKey(KeyCode.S)||Input.GetKey(KeyCode.DownArrow))
		{
			transform.position += transform.up * Time.deltaTime * 10;
			par.startColor = Color.blue;
		}
		if (Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position += -transform.right * Time.deltaTime * 10;
			par.startColor = Color.yellow;
		}
		if (Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.RightArrow))
		{
			transform.position += transform.right * Time.deltaTime * 10;
			par.startColor = Color.green;
		}
	}
}
