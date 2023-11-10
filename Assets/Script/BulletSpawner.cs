using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public Camera cam;
    public GameObject bulletPrefab;

    [SerializeField]
    private float gunCooldown = 3f;
    private float passedCooldownTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time > passedCooldownTime)
        {
            Vector3 spawnPosition = cam.transform.position + cam.transform.forward;
            Instantiate(bulletPrefab, spawnPosition, cam.transform.rotation);

            passedCooldownTime = Time.time + gunCooldown;
        }
    }
}
