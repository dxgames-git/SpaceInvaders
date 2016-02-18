using UnityEngine;
using System.Collections;

public class GridController : MonoBehaviour {

    float speed = 20f;
    public float direction;
    public float timePassed;
    public int whatToShoot;

    // Use this for initialization
    void Start ()
    {
        direction = 1f;
        timePassed = 0f;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (timePassed > 1)
        {
            transform.position += new Vector3(direction * Time.deltaTime * speed, 0, 0);
            timePassed = 0f;
        }
        timePassed += Time.deltaTime;
    }
}
