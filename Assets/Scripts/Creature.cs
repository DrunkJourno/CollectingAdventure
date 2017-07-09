using System;
using System.Collections.Generic;

public class Creature : ICreature
{
    public Creature(string creatureId, string instanceId, Stat hp, Stat speed, Stat attack, Stat specialAttack, Stat defense)
    {
        CreatureId = creatureId;
        InstanceId = instanceId;
        HP = hp;
        Speed = speed;
        Attack = attack;
        SpecialAttack = specialAttack;
        Defense = defense;
    }

    public string CreatureId { get; private set; }
    public string InstanceId { get; private set; }
    public Stat HP { get; private set; }
    public Stat Speed { get; private set; }
    public Stat Attack { get; private set; }
    public Stat SpecialAttack { get; private set; }
    public Stat Defense { get; private set; }

    public AttackCollection Attacks { get; private set; }

    public bool CanBeActive
    {
        get
        {
            return HP.Current > 0;
        }
    }
}