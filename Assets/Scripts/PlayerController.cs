using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed = 5f;
    private Rigidbody2D playerBody;
    private Transform player;
    

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector2(-1 * speed * Time.deltaTime, 0);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector2(1 * speed * Time.deltaTime, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {

        }
    }

    //Daniel Choi is a demigod and deminoob

}
