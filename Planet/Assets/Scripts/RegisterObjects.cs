using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class RegisterObjects : MonoBehaviour 
{
	List < Collider > observers; 

	public RegisterObjects()
	{
		observers = new List <Collider>();
	}

	void OnTriggerEnter( Collider other )
	{
		observers.Add (other);

	}
		
	void OnTriggerExit( Collider other )
	{
		observers.Remove (other);
	}

	void notifyObservers()
	{
		for (int i = 0; i < observers.Count; i++) 
		{
			Collider o = observers [i]; 

			Vector3 diff = o.transform.position - transform.position;

			diff.Normalize();

			o.transform.position -= diff * .005f;
		}
	}

	void Update()
	{
		for (int i = 0; i < observers.Count; i++) 
		{
			if (observers [i] == null)
				observers.Remove (observers [i]);
		}
	}

	void FixedUpdate()
	{
		notifyObservers ();
	}

}

