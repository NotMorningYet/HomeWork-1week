using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameManager _gameManager;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("столкновение");
        _gameManager.PlayerCollisionDetected(other.gameObject);
        
        
    }
}
