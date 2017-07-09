using System.Collections.Generic;

namespace Assets.Scripts
{
    public class CreatureBank : LimitedCollection<ICreature>
    {
        public CreatureBank() : base(6)
        {

        }

        public CreatureBank(IEnumerable<ICreature> creatures)
            : base(6, creatures)
        {

        }

        public ICreature GetActiveCreature()
        {
            foreach(var creature in this)
            {
                if (creature.CanBeActive)
                {
                    return creature;
                }
            }

            return null;
        }
    }
}