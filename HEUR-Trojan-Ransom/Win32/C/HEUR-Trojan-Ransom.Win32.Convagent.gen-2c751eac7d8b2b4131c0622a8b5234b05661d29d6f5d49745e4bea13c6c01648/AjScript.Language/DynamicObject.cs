using System;
using System.Collections.Generic;
using System.Linq;

namespace AjScript.Language;

public class DynamicObject : IObject
{
	private Dictionary<string, object> values = new Dictionary<string, object>();

	private static string[] nativeMethods = new string[7] { "SetValue", "GetValue", "ToString", "GetNames", "Invoke", "GetHashCode", "Equals" };

	private IFunction function;

	public IFunction Function
	{
		get
		{
			return function;
		}
		internal set
		{
			function = value;
		}
	}

	public DynamicObject()
	{
	}

	public DynamicObject(IFunction function)
	{
		this.function = function;
	}

	public virtual void SetValue(string name, object value)
	{
		values[name] = value;
	}

	public virtual object GetValue(string name)
	{
		if (values.ContainsKey(name))
		{
			return values[name];
		}
		if (function == null)
		{
			return Undefined.Instance;
		}
		object value = function.GetValue("prototype");
		if (value != null && value != Undefined.Instance)
		{
			return ((IObject)value).GetValue(name);
		}
		return Undefined.Instance;
	}

	public virtual ICollection<string> GetNames()
	{
		return values.Keys;
	}

	public virtual bool IsNativeMethod(string name)
	{
		return nativeMethods.Contains(name);
	}

	public virtual object Invoke(string name, object[] parameters)
	{
		object value = GetValue(name);
		if ((value == null || value == Undefined.Instance) && IsNativeMethod(name))
		{
			return ObjectUtilities.GetNativeValue(this, name, parameters);
		}
		if (value != null && value != Undefined.Instance)
		{
			if (!(value is ICallable))
			{
				if (parameters == null)
				{
					return value;
				}
				throw new InvalidOperationException($"'{name}' is not a method");
			}
			return ((ICallable)value).Invoke(null, this, parameters);
		}
		throw new InvalidOperationException($"Unknown member '{name}'");
	}

	public virtual object Invoke(ICallable method, object[] parameters)
	{
		return method.Invoke(null, this, parameters);
	}
}
