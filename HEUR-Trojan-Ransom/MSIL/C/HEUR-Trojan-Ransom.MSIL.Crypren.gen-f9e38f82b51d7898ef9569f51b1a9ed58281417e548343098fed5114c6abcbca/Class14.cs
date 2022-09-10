using System;

internal abstract class Class14 : Class13
{
	private Class13 class13_1;

	public Class13 Class13_0 => class13_1;

	public override string String_0
	{
		get
		{
			return class13_1.String_0;
		}
		set
		{
			throw new NotSupportedException(Class29.smethod_0("\uf65e\uf65d\uf65e\uf659\uf650\uf61c\uf651\uf605", 63036));
		}
	}

	public override string String_1 => class13_1.String_1;

	public override Class6 Class6_0
	{
		get
		{
			return class13_1.Class6_0;
		}
		set
		{
			class13_1.Class6_0 = value;
		}
	}

	internal Class14(Class13 class13_2)
		: base(string.Empty)
	{
		class13_1 = class13_2;
	}
}
