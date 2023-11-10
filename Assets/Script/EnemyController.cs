using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public float speed = 1f;

    // testing variables
    private bool up = true;
    private Vector3 startingPos;

    // Start is called before the first frame update
    void Start()
    {
        startingPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (up)
        {
            transform.position += Vector3.forward * Time.deltaTime * speed;
        } 
        else
        {
            transform.position += Vector3.back * Time.deltaTime * speed;
        }

        if (transform.position.z >= startingPos.z + 5f || transform.position.z <= startingPos.z - 1f) up = !up;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }
}
