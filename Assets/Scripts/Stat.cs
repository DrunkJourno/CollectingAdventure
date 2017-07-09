public class Stat
{
    public int Base { get; set; }
    public int Current { get; set; }

    public Stat(int @base, int current)
    {
        Base = @base;
        Current = current;
    }
}