using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere : MonoBehaviour
{
    [SerializeField] private GameObject _sphere;
    [SerializeField] private Vector3 _offset;

    private void Start()
    {
        _offset = transform.position - _sphere.transform.position;
    }

    private void LateUpdate()
    {
        transform.position = _sphere.transform.position + _offset;
    }

}
