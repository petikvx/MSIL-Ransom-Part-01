namespace ns39;

internal class Class25
{
	private static bool bool_0;

	private static object object_0;

	internal static void smethod_0()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		while (true)
		{
			if (!bool_0)
			{
				goto IL_000b;
			}
			int num2 = 1;
			if (smethod_2() != null)
			{
				num2 = num;
			}
			goto IL_001d;
			IL_000b:
			bool_0 = true;
			num2 = 0;
			if (smethod_2() != null)
			{
				break;
			}
			goto IL_001d;
			IL_001d:
			switch (num2)
			{
			case 4:
				break;
			case 2:
				continue;
			default:
				goto end_IL_004b;
			case 1:
			case 3:
				return;
			}
			goto IL_000b;
			continue;
			end_IL_004b:
			break;
		}
		try
		{
			Delegate110.smethod_0(Delegate18.smethod_0(5607598, Delegate18.delegate18_0), Delegate110.delegate110_0);
			if (smethod_2() != null)
			{
				switch (0)
				{
				}
			}
		}
		catch
		{
			int num3 = 0;
			if (!smethod_1())
			{
				int num4 = default(int);
				num3 = num4;
			}
			switch (num3)
			{
			}
		}
	}

	internal static bool smethod_1()
	{
		return object_0 == null;
	}

	internal static Class25 smethod_2()
	{
		return (Class25)object_0;
	}
}
