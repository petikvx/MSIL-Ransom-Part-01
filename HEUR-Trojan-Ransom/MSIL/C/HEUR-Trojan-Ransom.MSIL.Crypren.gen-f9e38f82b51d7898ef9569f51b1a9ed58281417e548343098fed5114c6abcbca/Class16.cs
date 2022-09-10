internal sealed class Class16 : Class14
{
	public override Enum5 Enum5_0 => Enum5.const_2;

	public override string String_0 => base.String_0 + Class29.smethod_0("\uf578", 62802);

	public override string String_1 => base.String_0 + Class29.smethod_0("\ue504\ue502\ue50e", 58670) + Class6_0.String_0;

	public Class16(Class13 class13_2)
		: base(class13_2)
	{
	}

	internal static int smethod_0(int int_1)
	{
		return int_1 switch
		{
			46 => -32, 
			22 => -27, 
			26 => -59, 
			27 => -58, 
			28 => -9, 
			30 => -53, 
			31 => -60, 
			32 => -23, 
			35 => -51, 
			36 => -18, 
			37 => -62, 
			_ => -1, 
		};
	}
}
