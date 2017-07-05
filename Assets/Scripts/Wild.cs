public class Wild
{
    public ICreature Creature { get; private set; }

    public Wild(ICreature creature)
    {
        Creature = creature;
    }
}