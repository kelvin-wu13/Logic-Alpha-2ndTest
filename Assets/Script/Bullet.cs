using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public float lifetime = 2f;
    public bool isEnemyBullet = false;
    private Vector2 direction;

    void Start()
    {
        // Set direction based on bullet type
        direction = isEnemyBullet ? Vector2.down : Vector2.up;
        
        // Destroy bullet after lifetime
        Destroy(gameObject, lifetime);
    }

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (isEnemyBullet)
        {
            if (other.CompareTag("Player"))
            {
                PlayerController player = other.GetComponent<PlayerController>();
                if (player != null)
                {
                    player.TakeDamage();
                }
                Destroy(gameObject);
            }
        }
        else  // Player bullet
        {
            if (other.CompareTag("Enemy"))
            {
                EnemyShip enemy = other.GetComponent<EnemyShip>();
                if (enemy != null)
                {
                    enemy.TakeDamage();
                }
                Destroy(gameObject);
            }
        }

        // Destroy on wall or other obstacles
        if (other.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }
}