internal class Class42 : Class39
{
	private Class35 class35_0;

	private string string_1;

	public int int_0;

	public virtual Enum16 Enum16_0 => Enum16.const_0;

	public bool Boolean_0 => Enum16_0 == Enum16.const_0;

	public bool Boolean_1 => Enum16_0 == Enum16.const_3;

	public bool Boolean_2 => Enum16_0 == Enum16.const_1;

	public virtual Class35 Class35_0
	{
		get
		{
			return class35_0;
		}
		set
		{
			class35_0 = value;
		}
	}

	public virtual string String_1
	{
		get
		{
			if (string_1 == null && 0 == 0)
			{
				string_1 = base.String_0 + Class58.smethod_0("\uef7b\uef77", 61271) + Class35_0.String_0;
			}
			return string_1;
		}
	}

	public Class42(string string_2)
		: base(string_2)
	{
	}
}
