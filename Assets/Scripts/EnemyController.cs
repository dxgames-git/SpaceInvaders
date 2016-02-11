using UnityEngine;
using System.Collections;


public class EnemyController : MonoBehaviour {

    private Transform Alien;
    private float speed = 20f;
    private float direction;
    private float timePassed;
	// Use this for initialization
	void Start () {
        //Heesoo is a God  
        direction = 1f;
    }

    // Update is called once per frame
    void Update()
    {   if (timePassed > 1)
        {
            transform.position += new Vector3(direction * Time.deltaTime * speed, 0, 0);
            timePassed = 0f;
        }
        timePassed += Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Walls")
        {
            direction *= -1f;
        }
        else if (coll.gameObject.tag == "Projectile")
        {
            Destroy(coll.gameObject);
        }

    }

}

