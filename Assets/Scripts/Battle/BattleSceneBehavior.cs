using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BattleSceneBehavior : MonoBehaviour {
    public BattleEnemy Enemy;
    public BattleEnemy Hero;
    public BattleEnemyMapping[] Loader;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Setup(ICombatant enemy, ICombatant hero)
    {
        Enemy = Instantiate<BattleEnemy>(Loader.First(x => x.Id == enemy.GetStartingCreature().CreatureId).BattleEnemy);
        Hero = Instantiate<BattleEnemy>(Loader.First(x => x.Id == enemy.GetStartingCreature().CreatureId).BattleEnemy);
    }
}
