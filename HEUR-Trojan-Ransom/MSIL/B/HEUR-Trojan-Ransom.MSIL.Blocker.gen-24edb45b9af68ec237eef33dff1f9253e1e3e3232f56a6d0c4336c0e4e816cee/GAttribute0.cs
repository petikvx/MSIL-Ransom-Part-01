using System;

[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
public sealed class GAttribute0 : Attribute, GInterface0
{
	private string string_0;

	public string String_1 => string_0;

	public GAttribute0()
	{
		if (1 == 0)
		{
		}
		string_0 = string.Empty;
		base._002Ector();
	}

	public bool imethod_0(object object_0)
	{
		bool flag = false;
		int num = 0;
		string text = default(string);
		while (true)
		{
			switch (num)
			{
			case 1:
				if (text != null)
				{
					if (text != string.Empty)
					{
						flag = true;
						num = 2;
						continue;
					}
				}
				else
				{
					flag = true;
				}
				break;
			case 0:
				if (object_0 != null)
				{
					text = object_0 as string;
					num = 1;
					continue;
				}
				break;
			}
			break;
		}
		if (!flag)
		{
			string_0 = "The property is empty or null.";
		}
		return flag;
	}
}
