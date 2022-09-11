namespace ns0;

internal class Class6
{
	public delegate void Delegate0();

	private static Class7 class7_0;

	static Class6()
	{
		class7_0 = new Class7();
		class7_0.method_0(Form1.smethod_5);
		class7_0.method_0(Form1.smethod_4);
		class7_0.method_0(Form1.smethod_0);
		class7_0.method_0(Form1.smethod_1);
		class7_0.method_0(Form1.smethod_3);
	}

	public static void smethod_0(int[] int_0)
	{
		try
		{
			int num = 0;
			while (true)
			{
				int num2;
				int num3;
				if (num >= class7_0.Count)
				{
					num2 = -122739205;
					num3 = -122739205;
				}
				else
				{
					num2 = 92813128;
					num3 = 92813128;
				}
				while (true)
				{
					int num4 = num2;
					switch ((uint)(~(num4 + -93421226) ^ 0x6E4B0F0C) % 4u)
					{
					case 1u:
						class7_0[int_0[num]]();
						num++;
						num2 = -1630723046;
						continue;
					case 0u:
						num2 = 92813128;
						continue;
					default:
						return;
					case 3u:
						break;
					case 2u:
						return;
					}
					break;
				}
			}
		}
		catch
		{
		}
	}
}
