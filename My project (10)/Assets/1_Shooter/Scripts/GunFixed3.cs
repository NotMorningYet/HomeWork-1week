using UnityEngine;

public class GunFixed3 : Gun
{
    public GameObject _bullet;
    private float _varianceDirection = 0.1f;
    protected override void Fire()
    {
        if (HaveAmmos())
        {
            for (int  i = 0; i < _bulletsPerShot; i++)
            {
                _currentAmmos = DecreaseAmmo(_currentAmmos);
                _bullet = Instantiate(_bulletPrefab, _firePosition, transform.rotation);
                _bullet.GetComponent<Bullet>().InitBullet(_firePosition, transform.forward + RandomizeDirection());
            }
            
            UIUpdate();
        }

    }

    protected override int DecreaseAmmo(int currentAmmo)
    {
        return currentAmmo-1;
    }

    private Vector3 RandomizeDirection()
    {
        var varianceVector = new Vector3(Random.Range(-_varianceDirection, _varianceDirection), Random.Range(-_varianceDirection, _varianceDirection), Random.Range(-_varianceDirection, _varianceDirection));
        return varianceVector;
    }
}
