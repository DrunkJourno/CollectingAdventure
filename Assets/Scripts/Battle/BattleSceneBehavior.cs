using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BattleSceneBehavior : MonoBehaviour {
    public BattleEnemy Enemy;
    public BattleHero Hero;
    public BattleEnemyMapping[] Loader;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Setup(Wild wild)
    {
        Enemy = Instantiate<BattleEnemy>(Loader.First(x => x.Id == wild.Creature.TypeId).BattleEnemy);
    }
}
