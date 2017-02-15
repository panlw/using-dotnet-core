using System;
using System.Reflection;
using System.Collections.Generic;

/// <summary>
/// Abstract class for classes providing static Lists binding to connection
/// based WPF GUI elements such as ComboBox, ListBox, DataGrid...
/// </summary>
/// <typeparam name="T">The Type contained in the list</typeparam>
/// <typeparam name="I">The Type of the inheriting class</typeparam>
public abstract class AbstractSingletonList<T, I> : List<T>
{
    /// <summary>
    /// The list variable to implement singleton behaviour.
    /// </summary>
    private static I _list;

    /// <summary>
    /// Arbitrary lock object for the static All getter below to prevent
    /// any race conditions for this singleton.
    /// </summary>
    private static object _lockObject = new object();

    /// <summary>
    /// Get all objects in this list in a Singleton pattern.
    /// This invokes the child object. As I've set it up here
    /// only the constructor is called from a static metod.
    /// </summary>
    public static I All
    {
        get
        {
            if (_list == null)
            {
                lock (_lockObject)
                {
                    if (_list == null)
                    {
                        Type t = typeof(I);
                        ConstructorInfo ci = t.GetConstructor(new Type[] {});
                        object o = ci.Invoke(new object[] {});
                        _list = (I)o;
                    }
                }
            }
            return _list;
        }
    }
}
