using System;
using System.Text;

internal sealed class Class21 : Class20
{
	private string string_2;

	public Class19[] class19_2;

	public override Enum13 Enum13_0 => Enum13.const_1;

	public bool Boolean_3
	{
		get
		{
			if (class19_2 != null)
			{
				return class19_2.Length != 0;
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
			throw new NotSupportedException(Class35.smethod_0("\uf3ce\uf3cd\uf3ce\uf3c9\uf3c0\uf38c\uf3c1\uf39d\uf39c", 62380));
		}
	}

	public override string String_1 => String_0 + Class35.smethod_0("\ue71e\ue712", 59186) + Class12_0.String_0;

	public Class21(Class19 class19_3)
		: base(class19_3)
	{
	}

	private string method_0()
	{
		if (string_2 == null && 0 == 0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (Boolean_3 || 1 == 0)
			{
				stringBuilder.Append(Class35.smethod_0("\ueec4", 61087));
				int num = default(int);
				while (true)
				{
					switch (Class41.smethod_0(92))
					{
					default:
						continue;
					case 0:
					{
						num = 0;
						int num2 = 2;
						goto case 2;
					}
					case 2:
					{
						if (num == 0)
						{
							goto IL_00ec;
						}
						int num2 = 1;
						goto case 1;
					}
					case 3:
						stringBuilder.Append(Class35.smethod_0("\ue5c6", 58858));
						goto IL_0088;
					case 1:
						{
							if (num > 0)
							{
								int num2 = 3;
								goto case 3;
							}
							goto IL_0088;
						}
						IL_00ec:
						if (num >= class19_2.Length)
						{
							break;
						}
						goto case 1;
						IL_0088:
						stringBuilder.Append(Class35.smethod_0("\ueec4", 61087));
						while (true)
						{
							switch (Class41.smethod_0(79))
							{
							default:
								continue;
							case 1:
							{
								stringBuilder.Append(class19_2[num].String_1);
								int num3 = 0;
								goto case 0;
							}
							case 0:
							{
								stringBuilder.Append(Class35.smethod_0("\uef69", 61236));
								int num3 = 2;
								break;
							}
							case 2:
								break;
							}
							break;
						}
						num++;
						goto IL_00ec;
					}
					break;
				}
				stringBuilder.Append(Class35.smethod_0("\uef69", 61236));
			}
			string_2 = stringBuilder.ToString();
		}
		return string_2;
	}
}
