using System;

[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
public sealed class GAttribute3 : Attribute, GInterface0
{
	private int int_0;

	private int int_1;

	private string string_0;

	public string String_1 => string_0;

	public int Int32_0
	{
		get
		{
			return int_0;
		}
		set
		{
			if (1 == 0)
			{
			}
			if (value <= 0)
			{
				throw new ArgumentOutOfRangeException("MaxLength", "MaxLength property must be greater than zero.");
			}
			if (value < Int32_1)
			{
				throw new ArgumentException("MaxLength property must be greater than or equal to the MinLength property.", "MaxLength");
			}
			int_0 = value;
		}
	}

	public int Int32_1
	{
		get
		{
			return int_1;
		}
		set
		{
			if (1 == 0)
			{
			}
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException("MinLength", "MinLength property must be zero or greater.");
			}
			if (value > Int32_0)
			{
				throw new ArgumentException("MinLength property must be less than or equal to the MaxLength property.", "MinLength");
			}
			int_1 = value;
		}
	}

	public GAttribute3()
	{
		if (1 == 0)
		{
		}
		int_0 = int.MaxValue;
		string_0 = string.Empty;
		base._002Ector();
	}

	public bool imethod_0(object object_0)
	{
		bool result = true;
		int num = 0;
		string text = default(string);
		while (true)
		{
			switch (num)
			{
			case 4:
				result = false;
				num = 5;
				continue;
			case 2:
				result = false;
				num = 3;
				continue;
			case 1:
				if (!string.IsNullOrEmpty(text))
				{
					if (text.Length < int_1)
					{
						string_0 = $"The string '{text}' is less than the required length of {int_1} character(s).";
						num = 2;
						continue;
					}
					if (text.Length > int_0)
					{
						string_0 = $"The string '{text}' is greater than the maximum length of {int_0} character(s).";
						num = 4;
						continue;
					}
				}
				else
				{
					string_0 = "The string was null or empty so the length of it could not be evaluated.";
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
