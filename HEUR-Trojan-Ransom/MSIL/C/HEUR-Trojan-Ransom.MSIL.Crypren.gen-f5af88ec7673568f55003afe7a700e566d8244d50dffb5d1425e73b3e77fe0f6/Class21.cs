using System;

internal abstract class Class21 : Class20
{
	private Class20 class20_1;

	public Class20 Class20_0 => class20_1;

	public override string String_0
	{
		get
		{
			return class20_1.String_0;
		}
		set
		{
			throw new NotSupportedException(Class36.smethod_0("\uf8e3\uf8e0\uf8e3\uf8e4\uf8ed\uf8a1\uf8ec\uf8b8", 63617));
		}
	}

	public override string String_1 => class20_1.String_1;

	public override Class13 Class13_0
	{
		get
		{
			return class20_1.Class13_0;
		}
		set
		{
			class20_1.Class13_0 = value;
		}
	}

	internal Class21(Class20 class20_2)
		: base(string.Empty)
	{
		class20_1 = class20_2;
	}
}
