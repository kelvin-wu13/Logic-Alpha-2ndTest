using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public GameObject bulletPrefab;
    public Transform firePoint;

    private int health = 3;
    private SpriteRenderer spriteRenderer;
    private float invulnerabilityTime = 2f;
    private float currentInvulnerabilityTime = 0f;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        GameManager.Instance.UpdateHealthUI(health);
    }

    void Update()
    {
        // Movement
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical).normalized;
        transform.Translate(movement * moveSpeed * Time.deltaTime);

        // Shooting
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }

        // Invulnerability timer
        if (currentInvulnerabilityTime > 0)
        {
            currentInvulnerabilityTime -= Time.deltaTime;
            // Make sprite semi-transparent when hit
            spriteRenderer.color = new Color(1f, 1f, 1f, 0.5f);
        }
        else
        {
            // Reset sprite opacity
            spriteRenderer.color = new Color(1f, 1f, 1f, 1f);
        }
    }

    void Shoot()
    {
        // Instantiate bullet at fire point
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if hit by enemy or enemy bullet
        if (collision.gameObject.CompareTag("EnemyBullet"))
        {
            TakeDamage();
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            TakeDamage();
            EnemyShip enemy = collision.gameObject.GetComponent<EnemyShip>();
            enemy?.Die();
            Debug.Log("TEST1");
        }

        if (collision.gameObject.CompareTag("Coin"))
        {
            GameManager.Instance.AddCoin();
            Destroy(collision.gameObject);
        }
    }

    public void TakeDamage()
    {
        if (currentInvulnerabilityTime <= 0)
        {
            health--;
            currentInvulnerabilityTime = invulnerabilityTime;

            // Update health UI
            GameManager.Instance.UpdateHealthUI(health);

            if (health <= 0)
            {
                Die();
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Collect coins
        if (other.CompareTag("Coin"))
        {
            GameManager.Instance.AddCoin();
            Destroy(other.gameObject);
        }
    }

    void Die()
    {
        // Implement game over logic
        Destroy(gameObject);
    }
}