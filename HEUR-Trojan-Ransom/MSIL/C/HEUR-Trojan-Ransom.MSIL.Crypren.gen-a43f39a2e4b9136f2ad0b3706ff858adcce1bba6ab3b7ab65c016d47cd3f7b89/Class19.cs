using System;
using System.Text;

internal sealed class Class19 : Class18
{
	private string string_2;

	public Class17[] class17_2;

	public override Enum5 Enum5_0 => Enum5.const_1;

	public bool Boolean_3
	{
		get
		{
			if (class17_2 != null)
			{
				return class17_2.Length != 0;
			}
			return false;
		}
	}

	public override string String_0
	{
		get
		{
			return base.String_0 + method_0();
		}
		set
		{
			throw new NotSupportedException(Class33.smethod_0("\ueaa8\ueaab\ueaa8\ueaaf\ueaa6\ueaea\ueaa7\ueafb\ueafa", 60106));
		}
	}

	public override string String_1 => String_0 + Class33.smethod_0("\ue26d\ue261", 57921) + Class10_0.String_0;

	public Class19(Class17 class17_3)
		: base(class17_3)
	{
	}

	private string method_0()
	{
		if (string_2 == null && 0 == 0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (Boolean_3 || 1 == 0)
			{
				stringBuilder.Append(Class33.smethod_0("\ue8f5", 59566));
				int num2 = default(int);
				while (true)
				{
					int num = Class13.smethod_4(38);
					while (true)
					{
						switch (num)
						{
						case 1:
							num2 = 0;
							num = Class13.smethod_4(37);
							continue;
						case 0:
							if (num2 == 0)
							{
								goto IL_00f1;
							}
							num = 2;
							goto case 2;
						case 3:
							stringBuilder.Append(Class33.smethod_0("\uf18a", 61862));
							goto IL_008d;
						case 2:
							{
								if (num2 > 0)
								{
									num = 3;
									goto case 3;
								}
								goto IL_008d;
							}
							IL_008d:
							stringBuilder.Append(Class33.smethod_0("\ue8f5", 59566));
							while (true)
							{
								switch (Class13.smethod_4(37))
								{
								default:
									continue;
								case 0:
								{
									stringBuilder.Append(class17_2[num2].String_1);
									int num3 = 1;
									goto case 1;
								}
								case 1:
								{
									stringBuilder.Append(Class33.smethod_0("\uf679", 63012));
									int num3 = 2;
									break;
								}
								case 2:
									break;
								}
								break;
							}
							num2++;
							goto IL_00f1;
							IL_00f1:
							if (num2 >= class17_2.Length)
							{
								goto end_IL_0060;
							}
							goto case 2;
						}
						break;
					}
					continue;
					end_IL_0060:
					break;
				}
				stringBuilder.Append(Class33.smethod_0("\uf679", 63012));
			}
			string_2 = stringBuilder.ToString();
		}
		return string_2;
	}
}
