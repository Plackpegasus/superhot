using UnityEngine;
using UnityEngine.UI;

public class BulletSpawnerPlayer : BulletSpawner
{
    public Image crosshair;
    private float crosshairRotation = 90f;

    // Start is called before the first frame update
    void Start()
    {
        crosshairRotation = crosshairRotation / gunCooldown;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            spawnBullet();

            // TODO: gun crosshair spin
            // crosshair.rectTransform.rotation += Quaternion.Euler(new Vector3(0,0,crosshairRotation));
        }
    }
}
