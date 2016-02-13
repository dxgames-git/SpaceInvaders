using UnityEngine;
using System.Collections;

public class ProjectileController : MonoBehaviour {

    public int projDirection;

    float timePassed;
    Collider2D projColl;
    ProjectileLauncher playerScript;

	// Use this for initialization
	void Start ()
    {
        timePassed = 0f;

        GameObject test = GameObject.FindGameObjectWithTag("Responsible");
        GameObject theShooter = test.transform.parent.gameObject;
        if (test.name.Equals("TheAlienTest"))
        {
            playerScript = theShooter.GetComponent<EnemyController>();
            projDirection = -1;
        }
        else
        {
            playerScript = theShooter.GetComponent<PlayerController>();
            projDirection = 1;
        }
        DestroyImmediate(test);

        projColl = gameObject.GetComponent<BoxCollider2D>();
        projColl.isTrigger = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (playerScript.isShot())
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
        if (playerScript.isShot())
        {
            if (timePassed > 2f)
            {
                playerScript.changeShot(false);
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
        else if (coll.gameObject.tag == "Player")
        {
            gameObject.GetComponent<AudioSource>().Play();
            Destroy(coll.gameObject);
            Destroy(gameObject);
        }
    }

}
