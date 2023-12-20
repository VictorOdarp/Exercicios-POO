using System.Collections.Generic;

HashSet<string> set = new HashSet<string>();

set.Add(("TV"));
set.Add(("Notebook"));
set.Add(("Tablet"));

foreach (string s in set)
{
    Console.WriteLine(s);
}

SortedSet<int> a = new SortedSet<int>() { 0,2,3,4,5,6,7,8 };

SortedSet<int> b = new SortedSet<int>() { 1,2,3,4,5,10,6,7,8 };

PrintColletion(a);


// Union

SortedSet<int> c = new SortedSet<int>(a);

c.UnionWith(b);

PrintColletion(c);

// intersection

SortedSet<int> d = new SortedSet<int>(a);

d.IntersectWith(b);
PrintColletion(d);

//difference

SortedSet<int> e = new SortedSet<int>(a);

e.ExceptWith(b);
PrintColletion(e);


static void PrintColletion<T> (IEnumerable<T> collection)
{
    foreach (T o in collection)
    {
        Console.Write(o + " ");
        
    }
    Console.WriteLine();
    
    
}
