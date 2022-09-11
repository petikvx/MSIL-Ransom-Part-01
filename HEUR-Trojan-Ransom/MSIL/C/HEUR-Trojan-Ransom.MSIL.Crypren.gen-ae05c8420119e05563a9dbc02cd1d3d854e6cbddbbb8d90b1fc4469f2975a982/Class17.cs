internal class Class17 : Class14
{
	private Class10 class10_0;

	private string string_1;

	public int int_0;

	public virtual Enum5 Enum5_0 => Enum5.const_0;

	public bool Boolean_0 => Enum5_0 == Enum5.const_0;

	public bool Boolean_1 => Enum5_0 == Enum5.const_3;

	public bool Boolean_2 => Enum5_0 == Enum5.const_1;

	public virtual Class10 Class10_0
	{
		get
		{
			return class10_0;
		}
		set
		{
			class10_0 = value;
		}
	}

	public virtual string String_1
	{
		get
		{
			if (string_1 == null && 0 == 0)
			{
				string_1 = base.String_0 + Class33.smethod_0("\uef7b\uef77", 61271) + Class10_0.String_0;
			}
			return string_1;
		}
	}

	public Class17(string string_2)
		: base(string_2)
	{
	}
}
