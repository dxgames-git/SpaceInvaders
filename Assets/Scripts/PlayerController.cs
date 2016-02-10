using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed = 3f;
    private Rigidbody2D playerBody;
    private Transform player;

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
    }

    void FixedUpdate ()
    {
        /*
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += new Vector3(-1 * Time.deltaTime * speed, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += new Vector3(1 * Time.deltaTime * speed, 0, 0);
        }*/
    }

    //Daniel Choi is a demigod and deminoob

}
