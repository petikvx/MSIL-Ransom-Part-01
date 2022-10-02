using System;

internal abstract class Class18 : Class17
{
	private Class17 class17_1;

	public Class17 Class17_0 => class17_1;

	public override string String_0
	{
		get
		{
			return class17_1.String_0;
		}
		set
		{
			throw new NotSupportedException(Class33.smethod_0("\uf65e\uf65d\uf65e\uf659\uf650\uf61c\uf651\uf605", 63036));
		}
	}

	public override string String_1 => class17_1.String_1;

	public override Class10 Class10_0
	{
		get
		{
			return class17_1.Class10_0;
		}
		set
		{
			class17_1.Class10_0 = value;
		}
	}

	internal Class18(Class17 class17_2)
		: base(string.Empty)
	{
		class17_1 = class17_2;
	}
}
