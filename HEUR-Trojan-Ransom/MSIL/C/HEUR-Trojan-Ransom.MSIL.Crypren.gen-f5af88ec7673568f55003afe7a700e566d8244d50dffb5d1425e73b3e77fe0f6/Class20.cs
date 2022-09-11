internal class Class20 : Class17
{
	private Class13 class13_0;

	private string string_1;

	public int int_0;

	public virtual Enum5 Enum5_0 => Enum5.const_0;

	public bool Boolean_0 => Enum5_0 == Enum5.const_0;

	public bool Boolean_1 => Enum5_0 == Enum5.const_3;

	public bool Boolean_2 => Enum5_0 == Enum5.const_1;

	public virtual Class13 Class13_0
	{
		get
		{
			return class13_0;
		}
		set
		{
			class13_0 = value;
		}
	}

	public virtual string String_1
	{
		get
		{
			if (string_1 == null && 0 == 0)
			{
				string_1 = base.String_0 + Class36.smethod_0("\uef7b\uef77", 61271) + Class13_0.String_0;
			}
			return string_1;
		}
	}

	public Class20(string string_2)
		: base(string_2)
	{
	}

	internal static int smethod_0(int int_1)
	{
		return int_1 switch
		{
			111 => -56, 
			112 => -53, 
			84 => -16, 
			85 => -14, 
			86 => -15, 
			87 => -26, 
			92 => -12, 
			93 => -6, 
			95 => -61, 
			96 => -60, 
			98 => -64, 
			100 => -57, 
			101 => -59, 
			102 => -63, 
			_ => -1, 
		};
	}
}
