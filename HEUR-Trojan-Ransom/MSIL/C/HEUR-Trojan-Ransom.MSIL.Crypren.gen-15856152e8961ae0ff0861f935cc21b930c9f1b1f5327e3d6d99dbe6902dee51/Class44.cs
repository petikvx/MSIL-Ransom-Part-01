using System;
using System.Text;

internal sealed class Class44 : Class43
{
	private string string_2;

	public Class42[] class42_2;

	public override Enum16 Enum16_0 => Enum16.const_1;

	public bool Boolean_3
	{
		get
		{
			if (class42_2 != null)
			{
				return class42_2.Length != 0;
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
			throw new NotSupportedException(Class58.smethod_0("\uf3ce\uf3cd\uf3ce\uf3c9\uf3c0\uf38c\uf3c1\uf39d\uf39c", 62380));
		}
	}

	public override string String_1 => String_0 + Class58.smethod_0("\ue71e\ue712", 59186) + Class35_0.String_0;

	public Class44(Class42 class42_3)
		: base(class42_3)
	{
	}

	private string method_0()
	{
		if (string_2 == null && 0 == 0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (Boolean_3 || 1 == 0)
			{
				stringBuilder.Append(Class58.smethod_0("\ueec4", 61087));
				int num = default(int);
				while (true)
				{
					switch (Class64.smethod_0(92))
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
						stringBuilder.Append(Class58.smethod_0("\ue5c6", 58858));
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
						if (num >= class42_2.Length)
						{
							break;
						}
						goto case 1;
						IL_0088:
						stringBuilder.Append(Class58.smethod_0("\ueec4", 61087));
						while (true)
						{
							switch (Class64.smethod_0(79))
							{
							default:
								continue;
							case 1:
							{
								stringBuilder.Append(class42_2[num].String_1);
								int num3 = 0;
								goto case 0;
							}
							case 0:
							{
								stringBuilder.Append(Class58.smethod_0("\uef69", 61236));
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
				stringBuilder.Append(Class58.smethod_0("\uef69", 61236));
			}
			string_2 = stringBuilder.ToString();
		}
		return string_2;
	}
}
