internal class Class13 : Class10
{
	private Class6 class6_0;

	private string string_1;

	public int int_0;

	public virtual Enum5 Enum5_0 => Enum5.const_0;

	public bool Boolean_0 => Enum5_0 == Enum5.const_0;

	public bool Boolean_1 => Enum5_0 == Enum5.const_3;

	public bool Boolean_2 => Enum5_0 == Enum5.const_1;

	public virtual Class6 Class6_0
	{
		get
		{
			return class6_0;
		}
		set
		{
			class6_0 = value;
		}
	}

	public virtual string String_1
	{
		get
		{
			if (string_1 == null && 0 == 0)
			{
				string_1 = base.String_0 + Class29.smethod_0("\ue26d\ue261", 57921) + Class6_0.String_0;
			}
			return string_1;
		}
	}

	public Class13(string string_2)
		: base(string_2)
	{
	}
}
