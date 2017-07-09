using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    public class Player
    {
        private readonly CreatureBank _creatureBank;
        public CreatureBank CreatureBank {  get { return _creatureBank; } }

        public Player(IEnumerable<ICreature> creaturesOnHand)
        {
            _creatureBank = new CreatureBank(creaturesOnHand);
        }
    }
}
