internal class Class56 : Class53
{
	private Class49 class49_0;

	private string string_1;

	public int int_0;

	public virtual Enum20 Enum20_0 => Enum20.const_0;

	public bool Boolean_0 => Enum20_0 == Enum20.const_0;

	public bool Boolean_1 => Enum20_0 == Enum20.const_3;

	public bool Boolean_2 => Enum20_0 == Enum20.const_1;

	public virtual Class49 Class49_0
	{
		get
		{
			return class49_0;
		}
		set
		{
			class49_0 = value;
		}
	}

	public virtual string String_1
	{
		get
		{
			if (string_1 == null && 0 == 0)
			{
				string_1 = base.String_0 + Class72.smethod_0("\ue26d\ue261", 57921) + Class49_0.String_0;
			}
			return string_1;
		}
	}

	public Class56(string string_2)
		: base(string_2)
	{
	}
}
