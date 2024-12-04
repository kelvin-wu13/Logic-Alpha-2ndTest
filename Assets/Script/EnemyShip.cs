using UnityEngine;

public class EnemyShip : MonoBehaviour
{
    public float speed = 3f;
    public float shootInterval = 2f;
    public int health = 1;
    public GameObject bulletPrefab;
    public Transform firePoint;
    public GameObject explosionEffect;
    public GameObject coinPrefab;
    public int coinDropAmount = 1;

    private float shootTimer = 0f;

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        // Automatic shooting
        shootTimer += Time.deltaTime;
        if (shootTimer >= shootInterval)
        {
            Shoot();
            shootTimer = 0f;
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if hit by player bullet
        if (collision.gameObject.CompareTag("PlayerBullet"))
        {
            TakeDamage();
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            TakeDamage();
            Debug.Log("Test2");
        }

    }

    public void TakeDamage()
    {
        health--;
        if (health <= 0)
        {
        // Spawn explosion effect
        if (explosionEffect != null)
        {
            GameObject explosionInstance = Instantiate(explosionEffect, transform.position, Quaternion.identity);
            Destroy(explosionInstance,1f);
        }

        // Drop coins
        for (int i = 0; i < coinDropAmount; i++)
        {
            Vector2 randomOffset = Random.insideUnitCircle * 0.5f;
            Instantiate(coinPrefab, (Vector2)transform.position + randomOffset, Quaternion.identity);
        }

        // Destroy enemy ship
        Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}