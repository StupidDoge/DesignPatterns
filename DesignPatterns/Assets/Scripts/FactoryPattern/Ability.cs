using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

public abstract class Ability
{
    public abstract string Name { get; }

    public abstract void Process();
}

public class AttackAbility : Ability
{
    public override string Name => "fire";

    public override void Process()
    {
        Debug.Log("fire");
    }
}

public class HealAbility : Ability
{
    public override string Name => "heal";

    public override void Process()
    {
        Debug.Log("heal");
    }
}

public class LaughAbility : Ability
{
    public override string Name => "laugh";

    public override void Process()
    {
        Debug.Log("ehehe");
    }
}

public static class AbilityFactory
{
    private static Dictionary<string, Type> _abilitiesByNames;
    private static bool _isInitialized => _abilitiesByNames != null;

    private static void InitializeFactory()
    {
        if (_isInitialized)
            return;

        var abilityTypes = Assembly.GetAssembly(typeof(Ability)).GetTypes()
            .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(Ability)));

        _abilitiesByNames = new Dictionary<string, Type>();

        foreach (var type in abilityTypes)
        {
            var tempEffect = Activator.CreateInstance(type) as Ability;
            _abilitiesByNames.Add(tempEffect.Name, type);
        }
    }

    public static Ability GetAbility(string AbilityType)
    {
        InitializeFactory();

        if (_abilitiesByNames.ContainsKey(AbilityType))
        {
            Type type = _abilitiesByNames[AbilityType];
            var ability = Activator.CreateInstance(type) as Ability;
            return ability;
        }

        return null;
    }

    internal static IEnumerable<string> GetAbilityNames()
    {
        Debug.Log("Test");
        InitializeFactory();
        return _abilitiesByNames.Keys;
    }
}
