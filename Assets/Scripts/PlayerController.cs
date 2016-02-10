using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed = 3f;
    public Transform projectile;

    private bool shot = false;
    private float timePassed = 0f;
    private Rigidbody2D playerBody;

	// Use this for initialization
	void Start ()
    {
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
        if (Input.GetKeyDown(KeyCode.Space) && shot == false)
        {
            shot = true;
            timePassed = 0f;
        }       
        
        if (shot == false)
        {
            projectile.position = transform.position;
        }

    }

    void LaunchProjectile()
    {
        projectile.position += new Vector3(0, 3 * speed * Time.deltaTime, 0);
        timePassed += Time.deltaTime;
    }

    void FixedUpdate ()
    {
        if (shot)
        {
            if (timePassed > 0.5)
            {
                shot = false;
                timePassed = 0f;
            }
            else
            {
                LaunchProjectile();
            }
        }
        else
        {
            projectile.position = transform.position;
        }
    }

    //Daniel Choi is a demigod and deminoob

}
