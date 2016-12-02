using UnityEngine;
using System.Collections;

public class Observer : MonoBehaviour
{

	public float speed;
	public Behavior myBehav;// = new StraightBehavior();

	void Start()
	{
		GetComponent<Rigidbody> ().velocity = transform.right * speed * (-1f);
		myBehav.move (transform);
	}

	
	void FixedUpdate()
	{
		myBehav.move (transform);
	}
}
