using UnityEngine;
using System.Collections;

public abstract class movement
{
	public abstract void move( Transform t );
}
	
public class backmovement : movement
{
	public override void move( Transform t )
	{
		if (t.position.x > -5.75) {
			t.position = t.position + t.right * -.01f;
		}
	}
}

public class forwardmovement : movement
{
	public override void move( Transform t )
	{
		if (t.position.x < 5.75) {
			t.position = t.position + t.right * .01f;
		}
	}
}

public class nomovement : movement
{
	public override void move( Transform t )
	{
		t.position = t.position;
	}
}
	
public class fastmovement : movement
{
	public override void move( Transform t )
	{
		if (t.position.x < 5.75) {
			t.position = t.position + t.right * .1f;
		}
	}
}

public class Train : MonoBehaviour 
{
	public movement myMover = new forwardmovement ();

	void Start () {
	}
	
	// Update is called once per frame
	void Update () 
	{
		myMover.move (transform);
	}
}