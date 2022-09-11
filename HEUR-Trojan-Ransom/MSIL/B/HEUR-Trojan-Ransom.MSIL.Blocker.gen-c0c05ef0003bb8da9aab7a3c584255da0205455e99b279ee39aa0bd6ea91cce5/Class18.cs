internal sealed class Class18 : Class17
{
	public Enum10 enum10_0;

	public Class19[] class19_4;

	public Class33[] class33_0;

	public int int_0;

	public long long_0;

	public object object_0;

	internal Class31 class31_0;

	public bool Boolean_2
	{
		get
		{
			return (enum10_0 & Enum10.flag_9) == Enum10.flag_9;
		}
		set
		{
			if (value || 1 == 0)
			{
				enum10_0 |= Enum10.flag_9;
			}
			else
			{
				enum10_0 &= ~Enum10.flag_9;
			}
		}
	}

	public bool Boolean_3
	{
		get
		{
			return (enum10_0 & Enum10.flag_10) == Enum10.flag_10;
		}
		set
		{
			if (value || 1 == 0)
			{
				enum10_0 |= Enum10.flag_10;
			}
			else
			{
				enum10_0 &= ~Enum10.flag_10;
			}
		}
	}

	public bool Boolean_4
	{
		get
		{
			return (enum10_0 & Enum10.flag_8) == Enum10.flag_8;
		}
		set
		{
			if (value || 1 == 0)
			{
				enum10_0 |= Enum10.flag_8;
			}
			else
			{
				enum10_0 &= ~Enum10.flag_8;
			}
		}
	}

	public bool Boolean_5
	{
		get
		{
			return (enum10_0 & Enum10.flag_11) == Enum10.flag_11;
		}
		set
		{
			if (value || 1 == 0)
			{
				enum10_0 |= Enum10.flag_11;
			}
			else
			{
				enum10_0 &= ~Enum10.flag_11;
			}
		}
	}

	public Class18(string string_1)
		: base(string_1)
	{
		int_0 = 8;
	}
}
