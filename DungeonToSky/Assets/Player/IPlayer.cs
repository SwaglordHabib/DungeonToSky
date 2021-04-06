using UnityEngine;

public class Player : MonoBehaviour
{
    public Stats Stats;

    public IWeapon Weapon;

    public Player()
    {
        Weapon = new Weapon();
        Stats = new Stats();
    }

    public Rigidbody2D player;

    public Transform FirePoint;

    public GameObject projectilePreFab;

    public SpriteRenderer Sr;

    public Vector2 Movement;  

    public void Attack()
    {
        if (Weapon != null)
        {
            Weapon.Attack(FirePoint, projectilePreFab);
        }
        else
        {
            // TODO: Normal attacks   
        }
    }

    public bool Facing { get; set; } = true;
    public bool IsDead { get => Stats.Hp == 0; }
}

public class Stats
{
    public ushort Hp = 48;
    public ushort MaxHp = 48;

    public float movementSpeed = 8f;

}