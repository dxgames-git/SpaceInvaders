using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed = 3f;
    public Transform projectile;

	private float timePassed;
	private bool Shot;
    private Rigidbody2D playerBody;

	// Use this for initialization
	void Start ()
    {
		Shot = false;
		timePassed = 0f;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-1 * Time.deltaTime * speed, 0, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1 * Time.deltaTime * speed, 0, 0);
        }
		if (Input.GetKeyDown(KeyCode.Space)) 
		{
			Shot = true;
		} 

    }

	void FixedUpdate()
	{
		if (Shot) {
			if (timePassed > 0.5) {
				Shot = false;
				timePassed = 0f;
			}
			projectile.position += new Vector3 (0, 3 * speed * Time.deltaTime, 0);
			timePassed += Time.deltaTime;
		} 
		else
		{
			projectile.position = transform.position;
		}
	}

}
