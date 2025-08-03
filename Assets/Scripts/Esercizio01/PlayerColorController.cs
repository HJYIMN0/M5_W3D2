using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColorController : MonoBehaviour
{
    [SerializeField] private Color[] _playerColor;

    private MeshRenderer _playerMesh;

    private int index = 0;
    //private Material _playerMat;

    private void Awake()
    {
        _playerMesh = GetComponent<MeshRenderer>();
        //_playerMat = _playerMesh.material;

        if (_playerColor.Length <= 0) Debug.Log("Bisogna aggiungere i colors!");
    }

    private void Start()
    {
        _playerMesh.material.color = _playerColor[0];
    }

    public void ChangeColor()
    {
        index++;
        if (index >= _playerColor.Length) index = 0;
        
        _playerMesh.material.color= _playerColor[index];

    }
}
