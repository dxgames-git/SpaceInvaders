using UnityEngine;
using System.Collections;


public class EnemyController : MonoBehaviour {

    private Transform Alien;
    private float speed = 1f;
 
	// Use this for initialization
	void Start () {
        //Heesoo is a Newb   
    }
}
	
	// Update is called once per frame
	void Update () {
    transform.position = new Vector3(-1 * Time.deltaTime * speed, 1 * Time.deltaTime * speed, 0);
}
}
