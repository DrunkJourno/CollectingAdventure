using Assets.Scripts;
using Assets.Scripts.Battle;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class MenuBehavior : MonoBehaviour {
    Scene battleScene;
    BattleSceneBehavior battleSceneBehavior;
    bool shouldBattle, areBattling;
	// Use this for initialization
	void Start () {
        SceneManager.LoadScene("Battle", LoadSceneMode.Additive);
        battleScene = SceneManager.GetSceneByName("Battle");
        shouldBattle = true;
    }
	
	// Update is called once per frame
	void Update () {
        if(areBattling)
        {
            return;
        }
        else if (shouldBattle && battleScene.isLoaded)
        {
            DisableRoots();
            battleSceneBehavior = battleScene.GetRootGameObjects().Select(x => x.GetComponent<BattleSceneBehavior>()).First(x => x != null);
            SceneManager.SetActiveScene(battleScene);
            battleSceneBehavior.Setup(
                new WildCombatant(
                    new Pidgey("1", new Stat(10,10), new Stat(10, 10), new Stat(10, 10), new Stat(10, 10), new Stat(10, 10))
                ),
                new PlayerCombatant(new Player(new ICreature[] {
                    new Pidgey("2", new Stat(15,15), new Stat(10, 10), new Stat(12,12), new Stat(10,10), new Stat(10,10))
                }))
            );
            areBattling = true;
            shouldBattle = false;
        }
    }

    private void DisableRoots()
    {
        foreach (var gameObject in SceneManager.GetActiveScene().GetRootGameObjects())
        {
            gameObject.SetActive(false);
        }
    }
}
