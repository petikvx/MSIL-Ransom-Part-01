using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns0;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Class5
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager XMeKRDOattcuzEDJVfeGRmVbTaqm
	{
		get
		{
			if (resourceManager_0 == null)
			{
				while (true)
				{
					int num = 77061374;
					while (true)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-(~(~(-num2) * 2129909747 - 709280465 + 878745348)))) % 3u)
						{
						case 1u:
							resourceManager_0 = new ResourceManager("ns0.Class5", typeof(Class5).Assembly);
							num = ((int)num3 * -1905339633) ^ 0x2EC566AD;
							continue;
						case 0u:
							break;
						default:
							goto end_IL_0063;
						}
						break;
					}
					continue;
					end_IL_0063:
					break;
				}
			}
			return resourceManager_0;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo mZLnoStEdZebgIUvHlIjikgCoCAF
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

	internal Class5()
	{
	}
}
