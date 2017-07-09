using System;

public class WildCombatant : ICombatant
{
    public readonly ICreature _creature;

    public WildCombatant(ICreature creature)
    {
        _creature = creature;
    }

    public ICreature GetStartingCreature()
    {
        return _creature;
    }
}