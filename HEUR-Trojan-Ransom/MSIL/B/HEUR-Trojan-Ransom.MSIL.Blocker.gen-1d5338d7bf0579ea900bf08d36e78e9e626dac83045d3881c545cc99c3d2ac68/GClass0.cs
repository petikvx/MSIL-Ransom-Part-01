using System;

public class GClass0
{
	public static Type type_0 = null;

	private static bool smethod_0(ref byte[] byte_0)
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected I4, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected I4, but got Unknown
		//IL_009c: Incompatible stack heights: 0 vs 1
		//IL_00a3: Incompatible stack heights: 0 vs 1
		try
		{
			bool result = default(bool);
			GClass1 gClass = default(GClass1);
			while (true)
			{
				int num = -636840442;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA99B5EB9u) % 5u)
					{
					case 4u:
						result = true;
						num = ((int)num2 * -1810161536) ^ -103465541;
						continue;
					case 3u:
						byte_0 = gClass.method_2(byte_0);
						num = (int)(num2 * 1213715689) ^ -1451251326;
						continue;
					case 1u:
						gClass = new GClass1();
						num = (int)(num2 * 685484327) ^ -968980656;
						continue;
					case 2u:
						break;
					default:
						return result;
					case 0u:
						return result;
					}
					break;
				}
			}
		}
		catch
		{
			while (true)
			{
				_ = -1570417013;
				while (true)
				{
					_003F val = /*Error near IL_0078: Stack underflow*/^ -1449435463;
					uint num2 = (uint)(int)val;
					switch (val % 3)
					{
					case 2:
						_ = ((int)num2 * -1974988500) ^ -98147985;
						continue;
					case 0:
						break;
					default:
						return false;
					}
					break;
				}
			}
		}
	}

	public static void smethod_1()
	{
		GClass2 gClass = default(GClass2);
		while (true)
		{
			int num = -1088553731;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x92A8CDBEu) % 4u)
				{
				case 3u:
					gClass = new GClass2();
					num = (int)(num2 * 75223412) ^ -790581494;
					continue;
				case 0u:
					gClass.Assembly_0 = typeof(Form1).Assembly;
					gClass.method_1(smethod_0);
					num = ((int)num2 * -1969986910) ^ 0x1998C6B;
					continue;
				case 2u:
					break;
				default:
					type_0 = gClass.method_2(0);
					return;
				}
				break;
			}
		}
	}
}
