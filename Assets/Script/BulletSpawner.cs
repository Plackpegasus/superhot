using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public Camera cam;
    public GameObject bulletPrefab;
    GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 spawnPosition = cam.transform.position + cam.transform.forward;
            bullet = Instantiate(bulletPrefab, spawnPosition, cam.transform.rotation);
        }
    }
}
