using System;

[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
public sealed class GAttribute1 : Attribute, GInterface0
{
	private bool bool_0;

	private string[] string_0;

	private string string_1;

	public string String_1 => string_1;

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

	public string[] String_0
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

	public GAttribute1()
	{
		if (1 == 0)
		{
		}
		string_1 = string.Empty;
		base._002Ector();
	}

	public bool imethod_0(object object_0)
	{
		bool result = false;
		int num = 0;
		string strA = default(string);
		string text = default(string);
		int num2 = default(int);
		string[] array = default(string[]);
		while (true)
		{
			switch (num)
			{
			case 4:
				if (string.Compare(strA, text, Boolean_0) == 0)
				{
					result = true;
					num = 5;
					continue;
				}
				num2++;
				goto case 3;
			case 3:
				if (num2 < array.Length)
				{
					strA = array[num2];
					num = 4;
					continue;
				}
				break;
			case 2:
				num2 = 0;
				num = 3;
				continue;
			case 1:
				if (!string.IsNullOrEmpty(text) && String_0 != null && String_0.Length > 0)
				{
					array = String_0;
					num = 2;
					continue;
				}
				break;
			case 0:
				text = object_0 as string;
				num = 1;
				continue;
			}
			break;
		}
		return result;
	}
}
