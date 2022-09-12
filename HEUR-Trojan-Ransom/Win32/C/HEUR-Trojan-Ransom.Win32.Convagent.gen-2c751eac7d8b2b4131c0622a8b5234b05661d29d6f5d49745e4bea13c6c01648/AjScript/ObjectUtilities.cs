using System;
using System.Collections;
using System.Reflection;
using AjScript.Language;

namespace AjScript;

public class ObjectUtilities
{
	public static void SetValue(object obj, string name, object value)
	{
		if (obj is IObject)
		{
			((IObject)obj).SetValue(name, value);
			return;
		}
		obj.GetType().InvokeMember(name, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.SetField | BindingFlags.SetProperty, null, obj, new object[1] { value });
	}

	public static object GetValue(object obj, string name)
	{
		if (obj is IObject)
		{
			return ((IObject)obj).GetValue(name);
		}
		return obj.GetType().InvokeMember(name, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.GetField | BindingFlags.GetProperty, null, obj, null);
	}

	public static object GetValue(object obj, string name, object[] parameters)
	{
		if (obj is IObject)
		{
			if (parameters == null)
			{
				return ((IObject)obj).GetValue(name);
			}
			return ((IObject)obj).Invoke(name, parameters);
		}
		return GetNativeValue(obj, name, parameters);
	}

	public static object GetNativeValue(object obj, string name, object[] parameters)
	{
		return obj.GetType().InvokeMember(name, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.GetField | BindingFlags.GetProperty, null, obj, parameters);
	}

	public static bool IsNumber(object obj)
	{
		if (!(obj is int) && !(obj is short) && !(obj is long) && !(obj is decimal) && !(obj is double) && !(obj is float))
		{
			return obj is byte;
		}
		return true;
	}

	public static object GetIndexedValue(object obj, object[] indexes)
	{
		if (obj is Array)
		{
			return GetIndexedValue((Array)obj, indexes);
		}
		if (obj is IList)
		{
			return GetIndexedValue((IList)obj, indexes);
		}
		if (obj is IDictionary)
		{
			return GetIndexedValue((IDictionary)obj, indexes);
		}
		if (obj is DynamicObject && indexes != null && indexes.Length == 1)
		{
			return ((DynamicObject)obj).GetValue((string)indexes[0]);
		}
		return GetValue(obj, "", indexes);
	}

	public static void SetIndexedValue(object obj, object[] indexes, object value)
	{
		if (obj is Array)
		{
			SetIndexedValue((Array)obj, indexes, value);
		}
		else if (obj is IList)
		{
			if (indexes.Length != 1)
			{
				throw new InvalidOperationException("Invalid number of subindices");
			}
			int num = (int)indexes[0];
			IList list = (IList)obj;
			if (list.Count == num)
			{
				list.Add(value);
			}
			else
			{
				list[num] = value;
			}
		}
		else
		{
			if (!(obj is IDictionary))
			{
				throw new InvalidOperationException($"Not indexed value of type {obj.GetType().ToString()}");
			}
			if (indexes.Length != 1)
			{
				throw new InvalidOperationException("Invalid number of subindices");
			}
			((IDictionary)obj)[indexes[0]] = value;
		}
	}

	public static void SetIndexedValue(Array array, object[] indexes, object value)
	{
		switch (indexes.Length)
		{
		default:
			throw new InvalidOperationException("Invalid number of subindices");
		case 1:
			array.SetValue(value, (int)indexes[0]);
			break;
		case 2:
			array.SetValue(value, (int)indexes[0], (int)indexes[1]);
			break;
		case 3:
			array.SetValue(value, (int)indexes[0], (int)indexes[1], (int)indexes[2]);
			break;
		}
	}

	private static object GetIndexedValue(Array array, object[] indexes)
	{
		return indexes.Length switch
		{
			1 => array.GetValue((int)indexes[0]), 
			2 => array.GetValue((int)indexes[0], (int)indexes[1]), 
			3 => array.GetValue((int)indexes[0], (int)indexes[1], (int)indexes[2]), 
			_ => throw new InvalidOperationException("Invalid number of subindices"), 
		};
	}

	private static object GetIndexedValue(IList list, object[] indexes)
	{
		if (indexes.Length != 1)
		{
			throw new InvalidOperationException("Invalid number of subindices");
		}
		return list[(int)indexes[0]];
	}

	private static object GetIndexedValue(IDictionary dictionary, object[] indexes)
	{
		if (indexes.Length != 1)
		{
			throw new InvalidOperationException("Invalid number of subindices");
		}
		return dictionary[indexes[0]];
	}
}
