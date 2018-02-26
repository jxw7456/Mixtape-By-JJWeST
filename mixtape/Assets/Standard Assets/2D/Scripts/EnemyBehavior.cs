using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour {

    public Transform target;
    public Vector3 move = new Vector3(0.1f, 0.0f, 0.0f);
    public bool goingLeft = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        if (goingLeft)
        {
            transform.position = target.position - move;

            if (transform.position.x <= 62.5f)
            {
                goingLeft = false;
            }
        }        

        else
        {
            transform.position = target.position + move;

            if (transform.position.x >= 84.0f)
            {
                goingLeft = true;
            }           
        }
    }
}
