using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BattleSceneBehavior : MonoBehaviour {
    public GameObject Enemy;
    public GameObject Hero;
    public BattleEnemyMapping[] Loader;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Setup(ICombatant enemy, ICombatant hero)
    {
        Instantiate<BattleEnemy>(Loader.First(x => x.Id == enemy.GetStartingCreature().CreatureId).BattleEnemy, Enemy.transform, false);
        Instantiate<BattleEnemy>(Loader.First(x => x.Id == hero.GetStartingCreature().CreatureId).BattleEnemy, Hero.transform, false);
    }
}
