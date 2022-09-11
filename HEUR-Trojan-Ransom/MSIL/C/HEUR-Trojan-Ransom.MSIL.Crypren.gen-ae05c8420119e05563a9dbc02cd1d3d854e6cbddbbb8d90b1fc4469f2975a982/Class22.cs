using System.Text;

internal sealed class Class22 : Class18
{
	private int int_1;

	public int Int32_0 => int_1;

	public override Enum5 Enum5_0 => Enum5.const_3;

	public override string String_0 => base.String_0 + method_0();

	public override string String_1 => base.String_0 + method_0() + Class33.smethod_0("\uec60\uec6c", 60492) + Class10_0.String_0;

	public Class22(Class17 class17_2, int int_2)
		: base(class17_2)
	{
		int_1 = int_2;
	}

	private string method_0()
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num2 = default(int);
		while (true)
		{
			switch (Class39.smethod_0(82))
			{
			case 2:
			{
				stringBuilder.Append(Class33.smethod_0("\uf329", 62322));
				int num = 0;
				goto case 0;
			}
			case 0:
			{
				num2 = 0;
				int num = 1;
				goto case 1;
			}
			case 1:
			{
				if (num2 == 0)
				{
					goto IL_006a;
				}
				int num = 3;
				goto case 3;
			}
			case 4:
				stringBuilder.Append(Class33.smethod_0("\uf8cc", 63712));
				goto IL_0066;
			case 3:
				{
					if (num2 < int_1 - 1)
					{
						int num = 4;
						goto case 4;
					}
					goto IL_0066;
				}
				IL_0066:
				num2++;
				goto IL_006a;
				IL_006a:
				if (num2 >= int_1)
				{
					stringBuilder.Append(Class33.smethod_0("\uf26b", 62006));
					return stringBuilder.ToString();
				}
				goto case 3;
			}
		}
	}
}
