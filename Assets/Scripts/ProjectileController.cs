using UnityEngine;
using System.Collections;

public class ProjectileController : MonoBehaviour {

    public float projDirection;

    float timePassed;
    Collider2D projColl;

    PlayerController playerScript;

	// Use this for initialization
	void Start ()
    {
        timePassed = 0f;
        projDirection = 1f;

        GameObject thePlayer = GameObject.Find("Player");
        playerScript = thePlayer.GetComponent<PlayerController>();
        projColl = gameObject.GetComponent<BoxCollider2D>();
        projColl.isTrigger = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (playerScript.Shot)
        {
            if (timePassed > 0.1f && timePassed < 0.3f)
            {
                projColl.isTrigger = false;
            }
            if (timePassed > 1f)
            {
                Destroy(gameObject);
            }
        }
        else
        {
            projColl.isTrigger = true;
        }
    }

    void FixedUpdate()
    {
        if (playerScript.Shot)
        {
            if (timePassed > 2f)
            {
                playerScript.Shot = false;
                timePassed = 0f;
            }
            transform.position += new Vector3(0, 9f * Time.deltaTime * projDirection, 0);
            timePassed += Time.deltaTime;
        }
        else
        {
            Destroy(transform.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Aliens")
        {
            Destroy(coll.gameObject);
            Destroy(gameObject);
            projColl.isTrigger = true;
        }
    }

}
