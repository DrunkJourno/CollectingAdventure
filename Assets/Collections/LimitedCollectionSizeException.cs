using System;
using System.Runtime.Serialization;

[Serializable]
internal class LimitedCollectionSizeException : Exception
{
    public LimitedCollectionSizeException(int maxSize) : base("Collection can only hold up to " + maxSize + " elements")
    {

    }
}