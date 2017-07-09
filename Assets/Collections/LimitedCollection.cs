using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class LimitedCollection<TItem> : IList<TItem> where TItem : class
{
    private readonly TItem[] _items;

    private int _count;
    public int Count { get { return _count; } }

    public int MaxCount { get; private set; }

    public bool IsReadOnly { get { return false; } }

    public TItem this[int index]
    {
        get
        {
            return _items[index];
        }

        set
        {
            _items[index] = value;
        }
    }

    public LimitedCollection(int maxCount)
    {
        MaxCount = maxCount;
        _items = GetEmptyArray();
    }

    public LimitedCollection(int maxCount, IEnumerable<TItem> items)
    {
        MaxCount = maxCount;
        if(items == null)
        {
            _items = GetEmptyArray();
        }
        else
        {
            _items = GetArray(items);
        }
    }

    private TItem[] GetArray(IEnumerable<TItem> items)
    {
        var itemArray = GetEmptyArray();

        int i = 0;
        var e = items.GetEnumerator();
        foreach (var item in items)
        {
            if (i == MaxCount)
            {
                throw new LimitedCollectionSizeException(MaxCount);
            }
            itemArray[i] = item;
        }

        return itemArray;
    }

    private TItem[] GetEmptyArray()
    {
        return new TItem[MaxCount];
    }

    public IEnumerator<TItem> GetEnumerator()
    {
        return ((IEnumerable<TItem>)_items).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return _items.GetEnumerator();
    }

    public int IndexOf(TItem item)
    {
        for(int i = 0; i < _count; i++)
        {
            if (_items[i] == item)
                return i;
        }

        return -1;
    }

    public void Insert(int index, TItem item)
    {
        if (_count == _items.Length)
            throw new LimitedCollectionSizeException(MaxCount);

        if(index > _count || index < 0)
        {
            throw new IndexOutOfRangeException();
        }

        for (int i = _count; i > index; i--)
        {
            _items[i] = _items[i - 1];
        }

        _items[index] = item;
        _count++;
    }

    public void RemoveAt(int index)
    {
        if (index >= _count || index < 0)
            throw new IndexOutOfRangeException();

        for (int i = index; i < _count - 1; i++)
        {
            _items[i] = _items[i + 1];
        }

        _items[_count - 1] = null;
        _count--;
    }

    public void Add(TItem item)
    {
        if(_count == _items.Length)
            throw new LimitedCollectionSizeException(MaxCount);
           
        _items[_count] = item;
        _count++;
    }

    public void Clear()
    {
        for(int i=0;i< _count; i++)
        {
            _items[i] = null;
        }
        _count = 0;
    }

    public bool Contains(TItem item)
    {
        for(int i=0;i< _count; i++)
        {
            if (_items[i] == item)
                return true;
        }

        return false;
    }

    public void CopyTo(TItem[] array, int arrayIndex)
    {
        if (array == null)
            throw new ArgumentNullException("array");
        if (array.Length - arrayIndex < _items.Length)
            throw new ArgumentException();
        if (arrayIndex < 0)
            throw new ArgumentOutOfRangeException("arrayIndex");

        for (int i = 0; i < _count; i++)
            array[i + arrayIndex] = _items[i];
    }

    public bool Remove(TItem item)
    {
        var index = IndexOf(item);
        if (index == -1)
            return false;

        RemoveAt(index);

        return true;
    }
}