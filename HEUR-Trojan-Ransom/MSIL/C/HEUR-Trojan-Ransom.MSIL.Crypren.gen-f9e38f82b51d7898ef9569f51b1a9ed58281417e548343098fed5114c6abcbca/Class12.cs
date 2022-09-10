internal sealed class Class12 : Class11
{
	public Enum2 enum2_0;

	public Class13[] class13_4;

	public Class27[] class27_0;

	public int int_0;

	public long long_0;

	public object object_0;

	internal Class25 class25_0;

	public bool Boolean_2
	{
		get
		{
			return (enum2_0 & Enum2.flag_9) == Enum2.flag_9;
		}
		set
		{
			if (value || 1 == 0)
			{
				enum2_0 |= Enum2.flag_9;
			}
			else
			{
				enum2_0 &= ~Enum2.flag_9;
			}
		}
	}

	public bool Boolean_3
	{
		get
		{
			return (enum2_0 & Enum2.flag_10) == Enum2.flag_10;
		}
		set
		{
			if (value || 1 == 0)
			{
				enum2_0 |= Enum2.flag_10;
			}
			else
			{
				enum2_0 &= ~Enum2.flag_10;
			}
		}
	}

	public bool Boolean_4
	{
		get
		{
			return (enum2_0 & Enum2.flag_8) == Enum2.flag_8;
		}
		set
		{
			if (value || 1 == 0)
			{
				enum2_0 |= Enum2.flag_8;
			}
			else
			{
				enum2_0 &= ~Enum2.flag_8;
			}
		}
	}

	public bool Boolean_5
	{
		get
		{
			return (enum2_0 & Enum2.flag_11) == Enum2.flag_11;
		}
		set
		{
			if (value || 1 == 0)
			{
				enum2_0 |= Enum2.flag_11;
			}
			else
			{
				enum2_0 &= ~Enum2.flag_11;
			}
		}
	}

	public Class12(string string_1)
		: base(string_1)
	{
		int_0 = 8;
	}
}
