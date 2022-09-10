using System;

[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
public sealed class GAttribute8 : Attribute, GInterface0
{
	private string string_0;

	public string String_1 => string_0;

	public GAttribute8()
	{
		if (1 == 0)
		{
		}
		string_0 = string.Empty;
		base._002Ector();
	}

	public bool imethod_0(object object_0)
	{
		bool result = false;
		int num = 0;
		while (num == 0)
		{
			if (object_0 == null)
			{
				string_0 = "The property is set to a null value.";
				num = 1;
				continue;
			}
			result = true;
			break;
		}
		return result;
	}
}
