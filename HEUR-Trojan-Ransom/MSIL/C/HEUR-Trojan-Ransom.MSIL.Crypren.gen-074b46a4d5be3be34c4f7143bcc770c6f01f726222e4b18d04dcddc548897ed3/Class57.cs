using System;

internal abstract class Class57 : Class56
{
	private Class56 class56_1;

	public Class56 Class56_0 => class56_1;

	public override string String_0
	{
		get
		{
			return class56_1.String_0;
		}
		set
		{
			throw new NotSupportedException(Class72.smethod_0("\uf65e\uf65d\uf65e\uf659\uf650\uf61c\uf651\uf605", 63036));
		}
	}

	public override string String_1 => class56_1.String_1;

	public override Class49 Class49_0
	{
		get
		{
			return class56_1.Class49_0;
		}
		set
		{
			class56_1.Class49_0 = value;
		}
	}

	internal Class57(Class56 class56_2)
		: base(string.Empty)
	{
		class56_1 = class56_2;
	}
}
