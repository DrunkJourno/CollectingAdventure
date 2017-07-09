using System.Collections.Generic;

public class AttackCollection : LimitedCollection<Attack>
{
    public AttackCollection() : base(4)
    {
    }

    public AttackCollection(IEnumerable<Attack> attacks) : base(4, attacks)
    {
    }
}