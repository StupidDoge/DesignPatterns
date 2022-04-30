using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPanel : MonoBehaviour
{
    [SerializeField] private ButtonAbility _button;

    private void OnEnable()
    {
        foreach (string name in AbilityFactory.GetAbilityNames())
        {
            var button = Instantiate(_button);
            button.gameObject.name = name + " button";
            button.SetAbilityName(name);
            button.transform.SetParent(transform);
        }
    }
}
