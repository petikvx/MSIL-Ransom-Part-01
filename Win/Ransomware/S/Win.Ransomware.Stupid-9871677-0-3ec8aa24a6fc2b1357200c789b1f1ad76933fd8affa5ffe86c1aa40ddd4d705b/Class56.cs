internal sealed class Class56
{
	public static string smethod_0(GStruct0 gstruct0_0)
	{
		return $"Hostname: {gstruct0_0.String_0}\nUsername: {gstruct0_0.String_1}\nPassword: {gstruct0_0.String_2}\n\n";
	}

	public static string smethod_1(Struct0 struct0_0)
	{
		return $"{struct0_0.String_0}\tTRUE\t{struct0_0.String_2}\tFALSE\t{struct0_0.String_3}\t{struct0_0.String_1}\t{struct0_0.String_5}\r\n";
	}

	public static string smethod_2(Struct4 struct4_0)
	{
		if (!string.IsNullOrEmpty(struct4_0.String_0))
		{
			return $"### {struct4_0.String_1} ### ({struct4_0.String_0})\n";
		}
		return $"### {struct4_0.String_1} ###\n";
	}
}
