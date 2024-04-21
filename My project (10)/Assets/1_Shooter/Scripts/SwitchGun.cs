using System.Collections.Generic;
using UnityEngine;

public class SwitchGun : MonoBehaviour
{
    [SerializeField] private List<Gun> _gunList;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            GunsDeactivating();
            _gunList[0].Activate();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            GunsDeactivating();
            _gunList[1].Activate();
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            GunsDeactivating();
            _gunList[2].Activate();
        }
    }

    private void GunsDeactivating()
    {
        foreach (Gun gun in _gunList)
        {
            if (gun._isActive)
                gun.DeActivate();
        }
 
    }
}
