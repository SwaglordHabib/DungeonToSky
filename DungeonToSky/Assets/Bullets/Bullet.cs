using UnityEngine;

public class Bullet : BulletStats
{
    public Rigidbody2D Rb;

    // TODO For now, later use weapon modifier
    private double SpeedModifier = 0.4;

    public void Fire(Transform FirePoint, GameObject projectilePreFab, double SpeedModifier)
    {
        Instantiate(projectilePreFab, FirePoint.position, FirePoint.rotation);
    }

    void Start()
    {
        Vector3 direction = Input.mousePosition;
        direction.z = 0f;
        direction = Camera.main.ScreenToWorldPoint(direction);
        direction = ((Vector2)direction - (Vector2)transform.position).normalized;

        Rb.velocity = new Vector2(direction.x * BulletSpeed * (float)SpeedModifier, direction.y * BulletSpeed * (float)SpeedModifier);

        this.transform.rotation = Quaternion.AngleAxis(Mathf.Atan2(Rb.velocity.y, Rb.velocity.x) * Mathf.Rad2Deg, Vector3.forward);

        Destroy(gameObject, 2);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        Destroy(gameObject);
    }
}

public class BulletStats : MonoBehaviour
{
    public float BulletSpeed = 2f;
}