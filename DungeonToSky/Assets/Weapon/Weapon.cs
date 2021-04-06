using UnityEngine;

public class Weapon: WeaponStats, IWeapon
{
    void IWeapon.Attack(Transform FirePoint, GameObject projectilePreFab)
    {
        Bullet.Fire(FirePoint, projectilePreFab, BulletSpeedModifier);
    }
}

public class WeaponStats : MonoBehaviour
{
    public WeaponStats()
    {
        Bullet = new Bullet();
    }

    public Bullet Bullet;
    public double BulletSpeedModifier = 10;
}

public interface IWeapon
{    void Attack(Transform FirePoint, GameObject projectilePreFab);
}