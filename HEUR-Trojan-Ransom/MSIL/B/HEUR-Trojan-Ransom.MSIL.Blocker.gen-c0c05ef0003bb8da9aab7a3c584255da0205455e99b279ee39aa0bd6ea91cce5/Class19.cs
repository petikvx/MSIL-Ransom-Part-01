internal class Class19 : Class16
{
	private Class12 class12_0;

	private string string_1;

	public int int_0;

	public virtual Enum13 Enum13_0 => Enum13.const_0;

	public bool Boolean_0 => Enum13_0 == Enum13.const_0;

	public bool Boolean_1 => Enum13_0 == Enum13.const_3;

	public bool Boolean_2 => Enum13_0 == Enum13.const_1;

	public virtual Class12 Class12_0
	{
		get
		{
			return class12_0;
		}
		set
		{
			class12_0 = value;
		}
	}

	public virtual string String_1
	{
		get
		{
			if (string_1 == null && 0 == 0)
			{
				string_1 = base.String_0 + Class35.smethod_0("\uef7b\uef77", 61271) + Class12_0.String_0;
			}
			return string_1;
		}
	}

	public Class19(string string_2)
		: base(string_2)
	{
	}
}
