using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ui_HPBarManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    public void ChangeHp(int hp, int maxHp)
    {
        _text.text = $"{hp}/{maxHp}";
    }
}
