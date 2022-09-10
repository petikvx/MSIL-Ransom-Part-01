using System;
using System.Collections.Generic;
using System.Threading;

public static class GClass4
{
	public delegate void GDelegate2(bool invalidate);

	private const int int_0 = 50;

	private const int int_1 = 10;

	private static int int_2;

	private static bool bool_0;

	public static GClass5 gclass5_0 = new GClass5();

	private static List<GDelegate2> list_0 = new List<GDelegate2>();

	private static void smethod_0(IntPtr intptr_0, bool bool_1)
	{
		bool_0 = int_2 >= 50;
		int num = 0;
		bool flag = default(bool);
		List<GDelegate2> obj = default(List<GDelegate2>);
		while (true)
		{
			switch (num)
			{
			case 2:
				try
				{
					int num2 = 0;
					int num3 = 0;
					while (true)
					{
						switch (num3)
						{
						case 1:
							num2++;
							goto case 0;
						case 0:
							flag = num2 <= list_0.Count - 1;
							num3 = 2;
							continue;
						default:
							if (flag)
							{
								list_0[num2](bool_0);
								num3 = 1;
								continue;
							}
							break;
						}
						break;
					}
				}
				finally
				{
					Monitor.Exit(obj);
				}
				int_2 += 10;
				num = 3;
				break;
			case 1:
				if (!flag)
				{
					int_2 = 0;
				}
				Monitor.Enter(obj = list_0);
				num = 2;
				break;
			case 0:
				flag = !bool_0;
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	private static void smethod_1()
	{
		bool flag = list_0.Count != 0;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 0:
				if (!flag)
				{
					gclass5_0.method_1();
					num = 1;
				}
				else
				{
					gclass5_0.method_0(0u, 10u, smethod_0);
					num = 2;
				}
				break;
			default:
				return;
			}
		}
	}

	public static void smethod_2(GDelegate2 gdelegate2_0)
	{
		lock (list_0)
		{
			bool flag = !list_0.Contains(gdelegate2_0);
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 1:
					smethod_1();
					num = 2;
					break;
				case 0:
					if (flag)
					{
						list_0.Add(gdelegate2_0);
						num = 1;
						break;
					}
					return;
				default:
					return;
				}
			}
		}
	}

	public static void smethod_3(GDelegate2 gdelegate2_0)
	{
		lock (list_0)
		{
			bool flag = list_0.Contains(gdelegate2_0);
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 1:
					smethod_1();
					num = 2;
					break;
				case 0:
					if (flag)
					{
						list_0.Remove(gdelegate2_0);
						num = 1;
						break;
					}
					return;
				default:
					return;
				}
			}
		}
	}
}
