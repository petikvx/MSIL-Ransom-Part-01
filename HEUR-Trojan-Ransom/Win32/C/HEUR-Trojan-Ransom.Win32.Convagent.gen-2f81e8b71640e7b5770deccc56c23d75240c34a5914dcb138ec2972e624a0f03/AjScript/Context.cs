using System.Collections.Generic;
using AjScript.Language;

namespace AjScript;

public class Context : IContext
{
	private Dictionary<string, object> values;

	private IContext parent;

	public ReturnValue ReturnValue { get; set; }

	public Context()
		: this(null)
	{
	}

	public Context(IContext parent)
	{
		this.parent = parent;
		values = new Dictionary<string, object>();
	}

	public object GetValue(string name)
	{
		if (!values.ContainsKey(name))
		{
			if (parent != null)
			{
				return parent.GetValue(name);
			}
			return Undefined.Instance;
		}
		return values[name];
	}

	public void SetValue(string name, object value)
	{
		if (!values.ContainsKey(name) && parent != null)
		{
			parent.SetValue(name, value);
		}
		else
		{
			values[name] = value;
		}
	}

	public void DefineVariable(string name)
	{
		values[name] = Undefined.Instance;
	}
}
