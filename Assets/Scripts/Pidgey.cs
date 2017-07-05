using System;

public class Pidgey : ICreature
{
    public Pidgey(string instanceId, int hp)
    {
        InstanceId = instanceId;
        HP = hp;
    }

    public int HP { get; set; }

    public string InstanceId { get; private set; }

    public int Speed { get; set; }

    public string TypeId
    {
        get
        {
            return "pidgey";
        }
    }
}