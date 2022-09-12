namespace ns50;

internal class Class29
{
	private static bool bool_0;

	internal static object object_0;

	internal static void smethod_0()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		int num4 = default(int);
		int num6 = default(int);
		while (true)
		{
			int num2;
			if (bool_0)
			{
				num2 = 1;
				if (smethod_2() != null)
				{
					goto IL_000b;
				}
				goto IL_000f;
			}
			goto IL_002a;
			IL_000f:
			switch (num2)
			{
			case 3:
				break;
			case 2:
				continue;
			default:
				try
				{
					Delegate120.smethod_0(Delegate19.smethod_0(5692372, Delegate19.delegate19_0), Delegate120.delegate120_0);
					int num3 = 0;
					if (!smethod_1())
					{
						num3 = num4;
					}
					switch (num3)
					{
					}
					return;
				}
				catch
				{
					int num5 = 0;
					if (smethod_2() != null)
					{
						num5 = num6;
					}
					switch (num5)
					{
					}
					return;
				}
			case 1:
			case 4:
				return;
			}
			goto IL_002a;
			IL_002a:
			bool_0 = true;
			num2 = 0;
			if (smethod_2() != null)
			{
				goto IL_000b;
			}
			goto IL_000f;
			IL_000b:
			num2 = num;
			goto IL_000f;
		}
	}

	internal static bool smethod_1()
	{
		return object_0 == null;
	}

	internal static Class29 smethod_2()
	{
		return (Class29)object_0;
	}
}
