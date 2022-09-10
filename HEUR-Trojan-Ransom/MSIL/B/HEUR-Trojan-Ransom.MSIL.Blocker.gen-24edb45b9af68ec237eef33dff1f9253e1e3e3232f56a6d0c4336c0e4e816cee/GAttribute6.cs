using System;

[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
public sealed class GAttribute6 : Attribute, GInterface0
{
	private string string_0;

	public string String_1 => string_0;

	public GAttribute6()
	{
		if (1 == 0)
		{
		}
		string_0 = string.Empty;
		base._002Ector();
	}

	public bool imethod_0(object object_0)
	{
		Type type = object_0.GetType();
		int num = 0;
		bool flag = default(bool);
		while (true)
		{
			switch (num)
			{
			case 1:
				if (type.IsEnum)
				{
					if (Enum.IsDefined(type, object_0))
					{
						flag = true;
						num = 2;
						continue;
					}
					if (object_0.ToString()!.Contains(","))
					{
						flag = true;
					}
				}
				break;
			case 0:
				flag = false;
				num = 1;
				continue;
			}
			break;
		}
		if (!flag)
		{
			string_0 = $"The value '{(int)object_0}' is not defined in the {type.Name} enumeration.";
		}
		return flag;
	}
}
