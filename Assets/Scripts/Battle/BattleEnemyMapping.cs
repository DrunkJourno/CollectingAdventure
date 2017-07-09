[System.Serializable]
public class BattleEnemyMapping
{
    public string Id;
    public BattleEnemy BattleEnemy;

    public BattleEnemyMapping(string id, BattleEnemy enemy)
    {
        Id = id;
        BattleEnemy = enemy;
    }
}