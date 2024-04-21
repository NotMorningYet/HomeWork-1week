using UnityEngine;

public abstract class Gun : MonoBehaviour
{
    [SerializeField] public GameObject _bulletPrefab;

   
    public string _gunName;
    public bool _isInfinite;
    public int _maxAmmos;
    public int _currentAmmos;
    public int _bulletsPerShot;
    public bool _isActive;

    protected Vector3 _fireDirection;
    protected Vector3 _firePosition;

    public void Initialize(string gunName, bool isInfinite, int maxAmmos, int currentAmmos, int bulletPerShot, bool isActive)
    {        
    
        _gunName = gunName;
        _isInfinite = isInfinite;
        _maxAmmos = maxAmmos;
        _currentAmmos = currentAmmos;
        _bulletsPerShot = bulletPerShot;
        _isActive = isActive;
        _fireDirection = transform.forward.normalized;
        _firePosition = transform.position;
    }
    protected void UIUpdate()
    {
        Debug.Log($"Оружие {_gunName}, патронов {_currentAmmos}");
    }

    protected bool HaveAmmos()
    {
        return _currentAmmos >= _bulletsPerShot;
    }

    public void Activate()
    {
        _isActive = true;
        gameObject.SetActive(true);
    }

    public void DeActivate()
    {
        _isActive = false;
        gameObject.SetActive(false);

    }

    private void Update()
    {
        if (_isActive == false)
            return;
        
        if (Input.GetKeyDown(KeyCode.Space))
        {        
            Fire();
        }               
    }

    protected abstract void Fire();

    protected abstract int DecreaseAmmo(int _currentAmmos);
}
