using UnityEngine;

public class BulletSpawnerEnemy : BulletSpawner
{
    private GameObject player;

    void Start() 
    {
        player = GameObject.FindWithTag("Player");

        // enemies should not start to shoot straight away & all at once
        passedCooldownTime = Time.time + Random.Range(gunCooldown, gunCooldown * 2);
    }

    // Update is called once per frame
    void Update()
    {
        //spawnBullet();
                
        RaycastHit hit;
        Debug.DrawRay(spawnPoint.position, player.transform.position - transform.position, Color.yellow);

        // Does the ray intersect any objects excluding the player layer
        // if (Physics.Raycast(spawnPoint.position, player.transform.position - transform.position, out hit, Mathf.Infinity))
        // {
        //     Debug.DrawRay(spawnPoint.position, player.transform.position - transform.position * hit.distance, Color.yellow);
        //     Debug.Log("Did Hit");
        // }
        // else
        // {
        //     Debug.DrawRay(spawnPoint.position, player.transform.position - transform.position * 1000, Color.white);
        //     Debug.Log("Did not Hit");
        // }
    }
}
