internal class Class15 : Class14
{
	public Enum1 enum1_0;

	public Class17[] class17_1;

	public Class17[] class17_2;

	public Class17 class17_3;

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

	public Class15(string string_1)
		: base(string_1)
	{
	}

	internal static int smethod_0(int int_0)
	{
		return int_0 switch
		{
			74 => -8, 
			76 => -32, 
			78 => -12, 
			66 => -29, 
			67 => -118, 
			68 => -124, 
			_ => -1, 
		};
	}
}
