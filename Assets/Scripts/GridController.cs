using UnityEngine;
using System.Collections;

public class GridController : MonoBehaviour
{

    float speed = 20f;
    public float direction;
    public float timePassed;
    public int whatToShoot;

    public
    int[] intList;
    int count = 6;

    // Use this for initialization
    void Start()
    {
        intList = new int[count];

        direction = 1f;
        for (int i = 0; i < count; i++)
        {
            intList[i] = i;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (timePassed > 1)
        {
            whatToShoot = Random.Range(0, count);
            while (intList[whatToShoot] == 420)
            {
                whatToShoot = Random.Range(0, count);
            }
        }
    }

}
