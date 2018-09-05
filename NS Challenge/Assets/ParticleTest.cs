using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleTest : MonoBehaviour {

	public void RandomTeleport()
    {
        Vector3 cur_position = transform.position; 
        gameObject.transform.position = new Vector3(cur_position.x, Random.Range(0, 4), cur_position.z);
    }
}
