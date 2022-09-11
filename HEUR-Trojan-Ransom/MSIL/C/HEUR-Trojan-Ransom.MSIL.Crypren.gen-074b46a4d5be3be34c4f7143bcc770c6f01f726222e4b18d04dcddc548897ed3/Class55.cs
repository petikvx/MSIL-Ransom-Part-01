internal sealed class Class55 : Class54
{
	public Enum17 enum17_0;

	public Class56[] class56_4;

	public Class70[] class70_0;

	public int int_0;

	public long long_0;

	public object object_0;

	internal Class68 class68_0;

	public bool Boolean_2
	{
		get
		{
			return (enum17_0 & Enum17.flag_9) == Enum17.flag_9;
		}
		set
		{
			if (value || 1 == 0)
			{
				enum17_0 |= Enum17.flag_9;
			}
			else
			{
				enum17_0 &= ~Enum17.flag_9;
			}
		}
	}

	public bool Boolean_3
	{
		get
		{
			return (enum17_0 & Enum17.flag_10) == Enum17.flag_10;
		}
		set
		{
			if (value || 1 == 0)
			{
				enum17_0 |= Enum17.flag_10;
			}
			else
			{
				enum17_0 &= ~Enum17.flag_10;
			}
		}
	}

	public bool Boolean_4
	{
		get
		{
			return (enum17_0 & Enum17.flag_8) == Enum17.flag_8;
		}
		set
		{
			if (value || 1 == 0)
			{
				enum17_0 |= Enum17.flag_8;
			}
			else
			{
				enum17_0 &= ~Enum17.flag_8;
			}
		}
	}

	public bool Boolean_5
	{
		get
		{
			return (enum17_0 & Enum17.flag_11) == Enum17.flag_11;
		}
		set
		{
			if (value || 1 == 0)
			{
				enum17_0 |= Enum17.flag_11;
			}
			else
			{
				enum17_0 &= ~Enum17.flag_11;
			}
		}
	}

	public Class55(string string_1)
		: base(string_1)
	{
		int_0 = 8;
	}
}
