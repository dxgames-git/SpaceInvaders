using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed = 3f;
    public Transform projectile;
    private bool shot = false;

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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
        }
        
    }

    void LaunchProjectile()
    {

    }

    void FixedUpdate ()
    {
        if (shot)
        {
            LaunchProjectile();
        }
    }

    //Daniel Choi is a demigod and deminoob

}
