using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace XZ2Studio.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Resources
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	internal Resources()
	{
	}

	[SpecialName]
	internal static ResourceManager smethod_0()
	{
		if (resourceManager_0 == null)
		{
			while (true)
			{
				int num = 77867202;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(~(num2 ^ 0xC2A2D9C) - 322015857))) % 3u)
					{
					case 1u:
						resourceManager_0 = new ResourceManager("XZ2Studio.Properties.Resources", typeof(Resources).Assembly);
						num = ((int)num3 * -202794051) ^ 0x467FF293;
						continue;
					case 0u:
						break;
					default:
						goto end_IL_005b;
					}
					break;
				}
				continue;
				end_IL_005b:
				break;
			}
		}
		return resourceManager_0;
	}

	[SpecialName]
	internal static CultureInfo smethod_1()
	{
		return cultureInfo_0;
	}

	[SpecialName]
	internal static void smethod_2(CultureInfo cultureInfo_1)
	{
		cultureInfo_0 = cultureInfo_1;
	}
}
