using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns0;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[CompilerGenerated]
[DebuggerNonUserCode]
internal class Class2
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			ResourceManager result = default(ResourceManager);
			ResourceManager resourceManager = default(ResourceManager);
			while (true)
			{
				int num = 1350359603;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x72DF4DDu) % 8u)
					{
					case 7u:
						num = (int)((num2 * 1485581587) ^ 0x4F341D0D);
						continue;
					case 6u:
					{
						int num3;
						int num4;
						if (resourceManager_0 == null)
						{
							num3 = 668035579;
							num4 = 668035579;
						}
						else
						{
							num3 = 544352516;
							num4 = 544352516;
						}
						num = num3 ^ (int)(num2 * 348805190);
						continue;
					}
					case 5u:
						result = resourceManager_0;
						num = 1581175884;
						continue;
					case 4u:
						resourceManager_0 = resourceManager;
						num = ((int)num2 * -22849597) ^ -1473378786;
						continue;
					case 2u:
						num = (int)((num2 * 1025160560) ^ 0x4D65735D);
						continue;
					case 0u:
						resourceManager = new ResourceManager("ns0.Class2", typeof(Class2).Assembly);
						num = (int)(num2 * 402177737) ^ -710103559;
						continue;
					case 3u:
						break;
					default:
						return result;
					}
					break;
				}
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
	{
		get
		{
			return cultureInfo_0;
		}
		set
		{
			cultureInfo_0 = value;
		}
	}

	internal Class2()
	{
	}
}
