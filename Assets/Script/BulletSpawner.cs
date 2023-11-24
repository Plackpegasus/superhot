using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletSpawner : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject bulletPrefab;

    public Image crosshair;

    [SerializeField]
    private float gunCooldown = 3f;
    private float passedCooldownTime;
    private float crosshairRotation = 90f;

    // Start is called before the first frame update
    void Start()
    {
        crosshairRotation = crosshairRotation / gunCooldown;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time > passedCooldownTime)
        {
            Vector3 spawnPosition = spawnPoint.position + spawnPoint.forward;
            Instantiate(bulletPrefab, spawnPosition, spawnPoint.rotation);

            passedCooldownTime = Time.time + gunCooldown;

            // TODO: gun crosshair spin
            // crosshair.rectTransform.rotation += Quaternion.Euler(new Vector3(0,0,crosshairRotation));
        }
    }
}
