using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private Transform _shootPoint;
    [SerializeField] private Bullet _bulletTemplate;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(_bulletTemplate, _shootPoint);
        }
    }

}
