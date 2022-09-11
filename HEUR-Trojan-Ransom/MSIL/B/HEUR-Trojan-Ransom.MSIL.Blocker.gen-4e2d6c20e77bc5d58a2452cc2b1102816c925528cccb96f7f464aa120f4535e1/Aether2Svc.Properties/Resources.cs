using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Aether2Svc.Properties;

[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal class Resources
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
					int num = 2026961629;
					while (true)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~((((num2 ^ -846390726) * -1166858855) ^ -1135706175) * 842272441) * 1766512633) ^ 0x34DAF416u) % 3u)
						{
						case 2u:
							resourceManager_0 = new ResourceManager("Aether2Svc.Properties.Resources", typeof(Resources).Assembly);
							num = ((int)num3 * -1499280500) ^ -184099089;
							continue;
						case 0u:
							break;
						default:
							goto end_IL_0072;
						}
						break;
					}
					continue;
					end_IL_0072:
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

	internal Resources()
	{
	}
}
