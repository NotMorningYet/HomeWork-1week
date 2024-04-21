using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private GunFixed1 _gunFixed1;
    [SerializeField] private GunFixed3 _gunFixed3;
    [SerializeField] private GunInfinity _gunInfinity;
    
    void Awake()
    {
        _gunFixed1.Initialize("������������ �������, ��������� �������", false, 50, 50, 1, true);
        _gunFixed3.Initialize("������������ �������, ������� �������", false, 50, 50, 3, false);
        _gunInfinity.Initialize("����������� �������, ��������� �������", true, 100, 100, 1, false);

        _gunFixed3.gameObject.SetActive(false);
        _gunInfinity.gameObject.SetActive(false);



    }

}
