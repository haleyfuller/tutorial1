using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public float speed;

	void Start()
	{
		GetComponent<Rigidbody> ().velocity = transform.right * speed * (-1f);
	}

	void FixedUpdate()
	{
		Vector3 vec = new Vector3(Random.Range(-0.3f, 3.0f), Random.Range(-0.3f, 3.0f), Random.Range(-0.3f, 3.0f));
		GetComponent<Rigidbody> ().transform.position = vec;

	}
}
