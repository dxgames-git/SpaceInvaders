using UnityEngine;
using System.Collections;


public class EnemyController : MonoBehaviour {

    private Transform Alien;
    private float speed = 1f;

    private float timePassed;
    private float direction;

	// Use this for initialization
	void Start () {
        //Heesoo is a Newb   
        direction = 1f;
        timePassed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        float changeTime = 2 * Time.deltaTime;
        double constantTime = 0.5;
        transform.position += new Vector3(direction * Time.deltaTime * speed, 0, 0);
        timePassed += Time.deltaTime;
        if (timePassed > changeTime + 2)
        {
            direction *= -1;
            transform.position += new Vector3(0, -1 * (float)constantTime, 0);
            timePassed = 0f;
        }

    }

}

