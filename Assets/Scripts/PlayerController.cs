using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed = 3f;
    private Transform projectile;
    public Transform whatToCopy;

    public bool Shot;
    private Rigidbody2D playerBody;

    // Use this for initialization
    void Start()
    {
        Shot = false;
    }

    // Update is called once per frame
    void Update()
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
            CreateNewProjectile();
        }
    }

    public void CreateNewProjectile()
    {
        projectile = Instantiate(whatToCopy, transform.position, transform.rotation) as Transform;
        projectile.position = transform.position;
    }

}