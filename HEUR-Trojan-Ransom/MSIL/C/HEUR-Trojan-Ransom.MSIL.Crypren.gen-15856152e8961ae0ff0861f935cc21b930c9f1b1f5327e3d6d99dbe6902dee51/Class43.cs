using System;

internal abstract class Class43 : Class42
{
	private Class42 class42_1;

	public Class42 Class42_0 => class42_1;

	public override string String_0
	{
		get
		{
			return class42_1.String_0;
		}
		set
		{
			throw new NotSupportedException(Class58.smethod_0("\uf8e3\uf8e0\uf8e3\uf8e4\uf8ed\uf8a1\uf8ec\uf8b8", 63617));
		}
	}

	public override string String_1 => class42_1.String_1;

	public override Class35 Class35_0
	{
		get
		{
			return class42_1.Class35_0;
		}
		set
		{
			class42_1.Class35_0 = value;
		}
	}

	internal Class43(Class42 class42_2)
		: base(string.Empty)
	{
		class42_1 = class42_2;
	}
}
