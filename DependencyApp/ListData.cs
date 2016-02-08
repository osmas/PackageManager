using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyApp
{
    class ListData
    {
        static List<string> _list; // Static List instance

    static ListData()
    {
	//
	// Allocate the list.
	//
	_list = new List<string>();
    }

    public static void Record(string value)
    {
	//
	// Record this value in the list.
	//
        // Search for this element.
        if (!_list.Contains(value))
        {
            _list.Add(value);
        }

	

    }

    public static void ClearAll()
    {
        _list.Clear();
    }

    public static void SortData()
    {
        _list.Sort();
    }


    public static void Display()
    {
	//
	// Write out the results.
	//
	foreach (var value in _list)
	{
	    Console.Write(value + " ");
	}
    }
    }
}
