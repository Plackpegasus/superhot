using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 1f;

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
        // Rotate enemies to main camera
        Vector3 directionToCamera = Camera.main.transform.position - transform.position;
        directionToCamera.y = 0; // Ensure the enemy only rotates around the y-axis
        Quaternion lookRotation = Quaternion.LookRotation(directionToCamera);
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * speed);

        // The movement code is commented out
        /*
        if (up)
        {
            transform.position += Vector3.forward * Time.deltaTime * speed;
        }
        else
        {
            transform.position += Vector3.back * Time.deltaTime * speed;
        }

        if (transform.position.z >= startingPos.z + 5f || transform.position.z <= startingPos.z - 1f) up = !up;
        */
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }
}
