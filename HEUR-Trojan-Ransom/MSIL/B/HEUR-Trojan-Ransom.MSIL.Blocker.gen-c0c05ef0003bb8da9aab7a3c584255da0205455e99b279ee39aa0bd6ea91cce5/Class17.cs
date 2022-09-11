internal class Class17 : Class16
{
	public Enum9 enum9_0;

	public Class19[] class19_1;

	public Class19[] class19_2;

	public Class19 class19_3;

	public bool Boolean_0
	{
		get
		{
			return (enum9_0 & Enum9.const_0) == Enum9.const_0;
		}
		set
		{
			if (value || 1 == 0)
			{
				enum9_0 |= Enum9.const_0;
			}
			else
			{
				enum9_0 &= (Enum9)(-2);
			}
		}
	}

	public bool Boolean_1
	{
		get
		{
			return (enum9_0 & Enum9.const_1) == Enum9.const_1;
		}
		set
		{
			if (value || 1 == 0)
			{
				enum9_0 |= Enum9.const_1;
			}
			else
			{
				enum9_0 &= (Enum9)(-3);
			}
		}
	}

	public Class17(string string_1)
		: base(string_1)
	{
	}
}
