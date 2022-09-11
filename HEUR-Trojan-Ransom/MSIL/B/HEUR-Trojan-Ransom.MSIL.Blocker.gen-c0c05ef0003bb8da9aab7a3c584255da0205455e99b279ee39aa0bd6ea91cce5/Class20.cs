using System;

internal abstract class Class20 : Class19
{
	private Class19 class19_1;

	public Class19 Class19_0 => class19_1;

	public override string String_0
	{
		get
		{
			return class19_1.String_0;
		}
		set
		{
			throw new NotSupportedException(Class35.smethod_0("\uf8e3\uf8e0\uf8e3\uf8e4\uf8ed\uf8a1\uf8ec\uf8b8", 63617));
		}
	}

	public override string String_1 => class19_1.String_1;

	public override Class12 Class12_0
	{
		get
		{
			return class19_1.Class12_0;
		}
		set
		{
			class19_1.Class12_0 = value;
		}
	}

	internal Class20(Class19 class19_2)
		: base(string.Empty)
	{
		class19_1 = class19_2;
	}
}
