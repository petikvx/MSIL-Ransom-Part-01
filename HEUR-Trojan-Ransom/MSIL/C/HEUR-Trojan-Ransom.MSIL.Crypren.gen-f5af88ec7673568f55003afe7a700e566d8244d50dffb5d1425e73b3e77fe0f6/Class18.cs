internal class Class18 : Class17
{
	public Enum1 enum1_0;

	public Class20[] class20_1;

	public Class20[] class20_2;

	public Class20 class20_3;

	public bool Boolean_0
	{
		get
		{
			return (enum1_0 & Enum1.const_0) == Enum1.const_0;
		}
		set
		{
			if (value || 1 == 0)
			{
				enum1_0 |= Enum1.const_0;
			}
			else
			{
				enum1_0 &= (Enum1)(-2);
			}
		}
	}

	public bool Boolean_1
	{
		get
		{
			return (enum1_0 & Enum1.const_1) == Enum1.const_1;
		}
		set
		{
			if (value || 1 == 0)
			{
				enum1_0 |= Enum1.const_1;
			}
			else
			{
				enum1_0 &= (Enum1)(-3);
			}
		}
	}

	public Class18(string string_1)
		: base(string_1)
	{
	}
}
