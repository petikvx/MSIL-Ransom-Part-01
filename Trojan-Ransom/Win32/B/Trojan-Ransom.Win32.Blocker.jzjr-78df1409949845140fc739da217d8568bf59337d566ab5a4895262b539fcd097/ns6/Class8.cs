using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns6;

[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[CompilerGenerated]
internal sealed class Class8
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
					int num = -39346412;
					while (true)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(num2 * -1634740305 - 2035594756 - 2008400560)) % 3u)
						{
						case 1u:
							resourceManager_0 = new ResourceManager("P4ZGiZBA\\\\{Q8\\+8)L#jxW`S<r$", typeof(Class8).Assembly);
							num = (int)((num3 * 674129134) ^ 0x12C21F7F);
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

	internal Class8()
	{
	}
}
