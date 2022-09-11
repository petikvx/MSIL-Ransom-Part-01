using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns0;

[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal class Class10
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (resourceManager_0 == null)
			{
				while (true)
				{
					int num = -1749032795;
					while (true)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)((num2 ^ -1828340063) - 801146658) ^ 0x81FCC43Eu) % 3u)
						{
						case 1u:
							resourceManager_0 = new ResourceManager("ns0.Class10", typeof(Class10).Assembly);
							num = (int)((num3 * 1308386573) ^ 0x28DA4D76);
							continue;
						case 2u:
							break;
						default:
							goto end_IL_005f;
						}
						break;
					}
					continue;
					end_IL_005f:
					break;
				}
			}
			return resourceManager_0;
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

	internal Class10()
	{
	}
}
