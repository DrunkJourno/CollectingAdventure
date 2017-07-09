using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Battle
{
    public class PlayerCombatant : ICombatant
    {
        private readonly Player _player;

        public PlayerCombatant(Player player)
        {
            _player = player;
        }

        public ICreature GetStartingCreature()
        {
            return _player.CreatureBank.GetActiveCreature();
        }
    }
}
