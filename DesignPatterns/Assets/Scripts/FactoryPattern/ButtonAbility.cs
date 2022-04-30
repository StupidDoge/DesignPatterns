using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonAbility : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    public void SetAbilityName(string name)
    {
        _text.text = name;
    }

    public void UseAbility()
    {
        AbilityFactory.GetAbility(_text.text).Process();
    }
}
