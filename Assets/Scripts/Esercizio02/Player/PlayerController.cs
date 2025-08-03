using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _rb;

    [SerializeField] private float _speed = 5f;

    private float h;
    private float v;
    private Vector3 _dir;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        if (_rb == null) Debug.Log("Manca il rigidbody!");
    }

    private void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        if (h != 0 || v != 0)
        {
            _dir = new Vector3(h, 0, v).normalized;
        }
       

    }

    private void FixedUpdate()
    {
        if (_dir != Vector3.zero)
        {
            _rb.MovePosition(transform.position + _dir * _speed * Time.fixedDeltaTime);
        }
    }
}
