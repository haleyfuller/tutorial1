using UnityEngine;
using System.Collections;

public class Factory : MonoBehaviour
{
	public Observer hazard;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;


	void Start()
	{
		
		StartCoroutine( SpawnWaves ());
	}

	IEnumerator SpawnWaves()
	{
		int rand;
		while(true)
		{
			for (int i = 0; i < hazardCount; i++) 
			{
				Vector3 spawnPosition = new Vector3 (spawnValues.x, spawnValues.y, Random.Range (-spawnValues.z, spawnValues.z));
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (hazard, spawnPosition, spawnRotation);

				rand = Random.Range (1, 4);

				if( rand == 1 )
					hazard.myBehav = new JitterBehavior ();
				else if( rand == 2 )
					hazard.myBehav = new StraightBehavior ();
				else if( rand == 3 )
					hazard.myBehav = new AngleBehavior ();

				yield return new WaitForSeconds (spawnWait);
			}
		}
	}
		
}
