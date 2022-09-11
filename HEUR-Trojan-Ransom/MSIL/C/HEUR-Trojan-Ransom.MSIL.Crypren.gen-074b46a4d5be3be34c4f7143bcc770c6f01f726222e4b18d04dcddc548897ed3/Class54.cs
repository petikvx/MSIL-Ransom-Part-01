internal class Class54 : Class53
{
	public Enum16 enum16_0;

	public Class56[] class56_1;

	public Class56[] class56_2;

	public Class56 class56_3;

	public bool Boolean_0
	{
		get
		{
			return (enum16_0 & Enum16.const_0) == Enum16.const_0;
		}
		set
		{
			if (value || 1 == 0)
			{
				enum16_0 |= Enum16.const_0;
			}
			else
			{
				enum16_0 &= (Enum16)(-2);
			}
		}
	}

	public bool Boolean_1
	{
		get
		{
			return (enum16_0 & Enum16.const_1) == Enum16.const_1;
		}
		set
		{
			if (value || 1 == 0)
			{
				enum16_0 |= Enum16.const_1;
			}
			else
			{
				enum16_0 &= (Enum16)(-3);
			}
		}
	}

	public Class54(string string_1)
		: base(string_1)
	{
	}
}
