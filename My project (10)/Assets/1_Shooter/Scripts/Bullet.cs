using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] public GameObject _prefab;
    [SerializeField] private float _speed;
    [SerializeField] private float _distance;

    private Vector3 _startPosition;
    private Vector3 _movingDirection;
    private float _SQRcoveredDistance;

    public void InitBullet(Vector3 startPosition, Vector3 movingDirection)
    {    
        _movingDirection = movingDirection;
        _startPosition = startPosition;
    }

    private void Update()
    {
        transform.Translate(_movingDirection * _speed * Time.deltaTime);
        _SQRcoveredDistance = (transform.position - _startPosition).sqrMagnitude;

        if (_SQRcoveredDistance >= _distance*_distance) 
            Destroy();
    }
    private void Destroy()
    {
        Destroy(gameObject);
    }
}
