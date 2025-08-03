using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class LifeController : MonoBehaviour
{
    public int maxHp = 100;
    public int hp;
    public bool _maxHpOnStart = true;

    public UnityEvent<int, int> _onHpChanged;

    private void Start()
    {
        if (_maxHpOnStart) hp = maxHp;

        _onHpChanged?.Invoke(hp, maxHp);
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.M))
        {
            TakeDamage(5);
        }
    }

    public void Heal(int amount)
    {
        int oldHp = hp;
        hp = Mathf.Min(hp + amount, maxHp);
        if (oldHp != hp) _onHpChanged?.Invoke(hp, maxHp);
    }

    public void TakeDamage(int dmg)
    {
        int oldhp = hp;
        hp = Mathf.Clamp(hp, 0, hp - dmg); 
        if (oldhp != hp) _onHpChanged?.Invoke(hp, maxHp);
    }
}
