internal sealed class Class41 : Class40
{
	public Enum13 enum13_0;

	public Class42[] class42_4;

	public Class56[] class56_0;

	public int int_0;

	public long long_0;

	public object object_0;

	internal Class54 class54_0;

	public bool Boolean_2
	{
		get
		{
			return (enum13_0 & Enum13.flag_9) == Enum13.flag_9;
		}
		set
		{
			if (value || 1 == 0)
			{
				enum13_0 |= Enum13.flag_9;
			}
			else
			{
				enum13_0 &= ~Enum13.flag_9;
			}
		}
	}

	public bool Boolean_3
	{
		get
		{
			return (enum13_0 & Enum13.flag_10) == Enum13.flag_10;
		}
		set
		{
			if (value || 1 == 0)
			{
				enum13_0 |= Enum13.flag_10;
			}
			else
			{
				enum13_0 &= ~Enum13.flag_10;
			}
		}
	}

	public bool Boolean_4
	{
		get
		{
			return (enum13_0 & Enum13.flag_8) == Enum13.flag_8;
		}
		set
		{
			if (value || 1 == 0)
			{
				enum13_0 |= Enum13.flag_8;
			}
			else
			{
				enum13_0 &= ~Enum13.flag_8;
			}
		}
	}

	public bool Boolean_5
	{
		get
		{
			return (enum13_0 & Enum13.flag_11) == Enum13.flag_11;
		}
		set
		{
			if (value || 1 == 0)
			{
				enum13_0 |= Enum13.flag_11;
			}
			else
			{
				enum13_0 &= ~Enum13.flag_11;
			}
		}
	}

	public Class41(string string_1)
		: base(string_1)
	{
		int_0 = 8;
	}
}
