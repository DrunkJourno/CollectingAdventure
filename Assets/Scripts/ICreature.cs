public interface ICreature
{
    string TypeId { get; }
    string InstanceId { get; }
    int HP { get; set; }
    int Speed { get; set; }
}