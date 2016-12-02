using UnityEngine;
using System.Collections;

public class DestroyByContact_ : MonoBehaviour {

	void OnTriggerEnter( Collider other )
	{
		if (other.tag == "Boundary" || other.tag == "Gravity" ) 
		{
			return;
		}

		Destroy (other.gameObject);
	}
}
