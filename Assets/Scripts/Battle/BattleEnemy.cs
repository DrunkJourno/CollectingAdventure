using UnityEngine;

public class BattleEnemy : MonoBehaviour
{
    private ICreature _creature;

    void SetCreature(ICreature creature)
    {
        _creature = creature;
    }
}