using System;

[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
public sealed class GAttribute4 : Attribute, GInterface0
{
	private long long_0;

	private long long_1;

	private string string_0;

	public string String_1 => string_0;

	public long Int64_0
	{
		get
		{
			return long_0;
		}
		set
		{
			if (1 == 0)
			{
			}
			if (value <= Int64_1)
			{
				throw new ArgumentException("The max range cannot be set to a value lower than or equal to the minimum range.");
			}
			long_0 = value;
		}
	}

	public long Int64_1
	{
		get
		{
			return long_1;
		}
		set
		{
			if (1 == 0)
			{
			}
			if (value >= Int64_0)
			{
				throw new ArgumentException("the min range cannot be set to a value that is greater than or equal to the maximum range.");
			}
			long_1 = value;
		}
	}

	public GAttribute4()
	{
		if (1 == 0)
		{
		}
		long_0 = long.MaxValue;
		long_1 = long.MinValue;
		string_0 = string.Empty;
		base._002Ector();
	}

	public bool imethod_0(object object_0)
	{
		bool result = false;
		int num = 0;
		Type type = default(Type);
		long num2 = default(long);
		while (true)
		{
			switch (num)
			{
			case 1:
				if (type.IsValueType)
				{
					num2 = (long)Convert.ChangeType(object_0, typeof(long));
					num = 2;
					continue;
				}
				break;
			case 0:
				type = object_0.GetType();
				num = 1;
				continue;
			default:
				if (num2 <= Int64_0 && num2 >= Int64_1)
				{
					result = true;
				}
				break;
			}
			break;
		}
		return result;
	}
}
