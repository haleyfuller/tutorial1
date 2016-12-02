using UnityEngine;
using System.Collections;



[System.Serializable]
public abstract class Behavior //: MonoBehaviour
{
	public float speed;
	public abstract void move(Transform t);
};

[System.Serializable]
public class JitterBehavior : Behavior
{
	public override void move(Transform t)
	{
		t.GetComponent<Rigidbody> ().velocity = t.right * speed * (-1f);
		float randomNum = Random.Range (-0.01f, 0.01f);
		t.Translate( randomNum, randomNum, randomNum );

	}
};

[System.Serializable]
public class StraightBehavior : Behavior
{
	public override void move(Transform t)
	{
		t.GetComponent<Rigidbody> ().velocity = t.right * speed * (-1f);
	}

};

[System.Serializable]
public class AngleBehavior : Behavior 
{
	public override void move(Transform t)
	{
		t.GetComponent<Rigidbody> ().velocity = t.right * speed * (-1f);
		float randomNum = Random.Range (0f, 3f);
		t.Rotate (randomNum, randomNum, randomNum);
	}	
};

