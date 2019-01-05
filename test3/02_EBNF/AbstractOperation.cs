using System;
using System.Collections.Generic;

public abstract class AbstractOperation<T>
{
    protected List<T> p = new List<T> ();
    public AbstractOperation (T [] parts)
    {
        p.AddRange (parts);
    }
    public IEnumerable<T> Parts { get { return p; } }
    public void Add (T part)
    {
        p.Add (part);
    }
    public int Count { get { return p.Count; } }
    public T this [int index] { get { return p [index]; } }
    public T GetTheOnlyChild ()
    {
        if (p.Count != 1) {
            throw new ApplicationException ();
        }
        return p [0];
    }
}
