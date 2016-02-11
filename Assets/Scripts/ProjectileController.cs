using UnityEngine;
using System.Collections;

public class ProjectileController : MonoBehaviour {

    public float projDirection;
    public bool hitTarget = false;

    float timePassed;
    Collider2D projColl;
    PlayerController playerScript;
	// Use this for initialization
	void Start () {
        GameObject thePlayer = GameObject.Find("Player");
        playerScript = thePlayer.GetComponent<PlayerController>();
        projColl = gameObject.GetComponent<BoxCollider2D>();
        projColl.isTrigger = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (playerScript.Shot)
        {
            if (playerScript.timePassed > 0.1f && playerScript.timePassed < 0.3f)
            {
                projColl.isTrigger = false;
            }
        }
        else
        {
            projColl.isTrigger = true;
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Aliens")
        {
            Destroy(coll.gameObject);
            playerScript.CreateNewProjectile();
            projColl.isTrigger = true;
        }
        hitTarget = true;
    }

}
