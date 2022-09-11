using System.Text;

internal sealed class Class61 : Class57
{
	private int int_1;

	public int Int32_0 => int_1;

	public override Enum20 Enum20_0 => Enum20.const_3;

	public override string String_0 => base.String_0 + method_0();

	public override string String_1 => base.String_0 + method_0() + Class72.smethod_0("\ue26d\ue261", 57921) + Class49_0.String_0;

	public Class61(Class56 class56_2, int int_2)
		: base(class56_2)
	{
		int_1 = int_2;
	}

	private string method_0()
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num2 = default(int);
		while (true)
		{
			int num = Class52.smethod_4(39);
			while (true)
			{
				switch (num)
				{
				case 2:
					stringBuilder.Append(Class72.smethod_0("\ue8f5", 59566));
					num = 0;
					goto IL_0020;
				case 0:
					goto IL_0020;
				case 3:
					if (num2 == 0)
					{
						goto IL_006f;
					}
					num = 1;
					goto case 1;
				case 4:
					stringBuilder.Append(Class72.smethod_0("\uf18a", 61862));
					goto IL_006b;
				case 1:
					{
						if (num2 < int_1 - 1)
						{
							num = 4;
							goto case 4;
						}
						goto IL_006b;
					}
					IL_006f:
					if (num2 >= int_1)
					{
						stringBuilder.Append(Class72.smethod_0("\uf679", 63012));
						return stringBuilder.ToString();
					}
					goto case 1;
					IL_006b:
					num2++;
					goto IL_006f;
				}
				break;
				IL_0020:
				num2 = 0;
				num = Class52.smethod_4(40);
			}
		}
	}
}
