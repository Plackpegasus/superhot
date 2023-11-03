using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public float speed = 1f;

    private bool up = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (up)
        {
            transform.position += Vector3.up * Time.deltaTime * speed;
        } 
        else
        {
            transform.position -= Vector3.up * Time.deltaTime * speed;
        }

        if (transform.position.y >= 5f || transform.position.y <= 1f) up = !up;
    }
}
