using UnityEngine;
using System.Collections;

public abstract class state
{
	public abstract void changeState(Train t);
}

public class forwardstate : state
{
	public override void changeState(Train t)
	{
		t.myMover = new forwardmovement();
	}
}

public class backwardstate : state
{
	public override void changeState(Train t)
	{
		t.myMover = new backmovement();
	}
}

public class stopstate : state
{
	public override void changeState(Train t)
	{
		t.myMover = new nomovement();
	}
}

public class faststate : state
{
	public override void changeState(Train t)
	{
		t.myMover = new fastmovement();
	}
}


public class Command : MonoBehaviour 
{
	state myState;

	state holderForwardState = new forwardstate ();
	state holderBackState = new backwardstate ();
	state holderStopState = new stopstate ();
	state holderFastState = new faststate ();

	public Train t;

	Ray ray;
	RaycastHit hit;



	void Update () 
	{

		if( Input.GetMouseButtonDown( 0 ) )
		{
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(ray, out hit))
			{
				if (hit.collider.name == "StopBall") {
					myState = holderStopState;
					myState.changeState (t);
				}
				if (hit.collider.name == "ForBall") {
						myState = holderForwardState;
						myState.changeState (t);
				}
				if (hit.collider.name == "BackBall") {
					myState = holderBackState;
					myState.changeState (t);
				}
				if (hit.collider.name == "RandomBall") {
					int num = Random.Range (1, 4);
					if (num == 1) {
						myState = holderStopState;
						myState.changeState (t);
					}
					if (num == 2) {
						myState = holderForwardState;
						myState.changeState (t);
					}
					if (num == 3) {
						myState = holderBackState;
						myState.changeState (t);
					}
				}
				if (hit.collider.name == "ExtraBall") {
					myState = holderFastState;
					myState.changeState (t);
				}
			}
		}
			

	}

	
}
