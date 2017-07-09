public interface ICreature
{
    string CreatureId { get; }
    string InstanceId { get; }

    Stat HP { get; }
    Stat Speed { get; }
    Stat Attack { get; }
    Stat SpecialAttack { get; }
    Stat Defense { get; }
    bool CanBeActive { get; }
}