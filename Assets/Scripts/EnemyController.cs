using UnityEngine;
using System.Collections;


public class EnemyController : MonoBehaviour, ProjectileLauncher
{

    private Transform Alien;
    private float speed = 20f;
    private float direction;
    private float timePassed;

    public bool Shot;
    private Transform projectile;
    public Transform whatToCopy;

    // Use this for initialization
    void Start () {
        //Heesoo is a God  
        Shot = false;
        direction = 1f;
    }

    // Update is called once per frame
    void Update()
    {   if (timePassed > 1)
        {
            transform.position += new Vector3(direction * Time.deltaTime * speed, 0, 0);
            timePassed = 0f;
            Shot = true;
            CreateNewProjectile();
        }
        timePassed += Time.deltaTime;

        //test
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Shot = true;
            //CreateNewProjectile();
        }

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Walls")
        {
            direction *= -1f;
        }
        else if (coll.gameObject.tag == "Projectile")
        {
            gameObject.GetComponent<AudioSource>().Play();
            Destroy(coll.gameObject);
            Kill();
            Destroy(gameObject, 0.3f);
        }

    }

    void Kill()
    {
        Destroy(gameObject.GetComponent<BoxCollider2D>());
        Destroy(gameObject.GetComponent<SpriteRenderer>());
        Destroy(gameObject.GetComponent<Rigidbody2D>());
    }

    public void CreateNewProjectile()
    {
        projectile = Instantiate(whatToCopy, transform.position, transform.rotation) as Transform;
        projectile.position = transform.position;
        GameObject test = new GameObject("TheAlienTest");
        test.transform.parent = transform;
        test.tag = "Responsible";
    }

    public bool isShot()
    {
        return Shot;
    }

    public void changeShot(bool a)
    {
        Shot = a;
    }

    public string toString()
    {
        return "Alien";
    }

}

