using System;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
public sealed class GAttribute5 : Attribute
{
	private string string_0;

	private bool bool_0;

	private bool bool_1;

	public string String_0
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	public bool Boolean_0
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	public bool Boolean_1
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
		}
	}

	public GAttribute5()
	{
		if (1 == 0)
		{
		}
		this._002Ector(null, bool_2: false, bool_3: false);
	}

	public GAttribute5(string string_1)
	{
		if (1 == 0)
		{
		}
		this._002Ector(string_1, bool_2: false, bool_3: false);
	}

	public GAttribute5(bool bool_2)
	{
		if (1 == 0)
		{
		}
		this._002Ector(null, bool_2, bool_3: false);
	}

	public GAttribute5(string string_1, bool bool_2)
	{
		if (1 == 0)
		{
		}
		this._002Ector(string_1, bool_2, bool_3: false);
	}

	public GAttribute5(string string_1, bool bool_2, bool bool_3)
	{
		if (1 == 0)
		{
		}
		base._002Ector();
		string_0 = string_1;
		bool_0 = bool_2;
		bool_1 = bool_3;
	}
}
