internal class Class40 : Class39
{
	public Enum12 enum12_0;

	public Class42[] class42_1;

	public Class42[] class42_2;

	public Class42 class42_3;

	public bool Boolean_0
	{
		get
		{
			return (enum12_0 & Enum12.const_0) == Enum12.const_0;
		}
		set
		{
			if (value || 1 == 0)
			{
				enum12_0 |= Enum12.const_0;
			}
			else
			{
				enum12_0 &= (Enum12)(-2);
			}
		}
	}

	public bool Boolean_1
	{
		get
		{
			return (enum12_0 & Enum12.const_1) == Enum12.const_1;
		}
		set
		{
			if (value || 1 == 0)
			{
				enum12_0 |= Enum12.const_1;
			}
			else
			{
				enum12_0 &= (Enum12)(-3);
			}
		}
	}

	public Class40(string string_1)
		: base(string_1)
	{
	}
}
