using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            battleSceneBehavior = battleScene.GetRootGameObjects().Select(x => x.GetComponent<BattleSceneBehavior>()).First(x => x != null);
            SceneManager.SetActiveScene(battleScene);
            battleSceneBehavior.Setup(new Wild(new Pidgey("1", 10)));
            areBattling = true;
            shouldBattle = false;
        }
    }
}
