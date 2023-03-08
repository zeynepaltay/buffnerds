using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilitie : MonoBehaviour
{
    enum EffectType
    {
        Damage,
        Heal,
        Buff,
        Debuff
    }
    enum TargettingType
    {
        EnemySingleTarget,
        AllySingleTarget,
        AllyMultiTarget,
        EnemyMultiTarget,
        Ground
    }
    enum AreaType
    {
        Area,Target
    }
    float cooldown;
    float cost;

    public Abilitie() { }

}
