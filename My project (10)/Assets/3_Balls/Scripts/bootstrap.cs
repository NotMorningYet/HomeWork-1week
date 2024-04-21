using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class bootstrap : MonoBehaviour
{
    [SerializeField] public GameObject _world;
    [SerializeField] public GameObject _menu;

    [SerializeField] private Player _player;
    [SerializeField] private GameManager _gameManager;

   
    void Awake()
    {
        _world.SetActive(false);
    }

}
