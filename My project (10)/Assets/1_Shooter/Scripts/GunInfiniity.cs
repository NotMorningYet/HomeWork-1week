using UnityEngine;

public class GunInfinity : Gun
{
    public GameObject _bullet;

    protected override void Fire()
    {
        if (HaveAmmos())
        {
            _currentAmmos = DecreaseAmmo(_currentAmmos);
            _bullet = Instantiate(_bulletPrefab, _firePosition, transform.rotation);
            _bullet.GetComponent<Bullet>().InitBullet(_firePosition, transform.forward);

            UIUpdate();
        }

    }

    protected override int DecreaseAmmo(int currentAmmo)
    {
        return currentAmmo;
    }

}