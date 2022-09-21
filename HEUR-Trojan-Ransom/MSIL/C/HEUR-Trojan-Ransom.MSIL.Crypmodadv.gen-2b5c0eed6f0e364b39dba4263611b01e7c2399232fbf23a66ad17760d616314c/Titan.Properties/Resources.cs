using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Titan.Properties;

[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
[CompilerGenerated]
internal class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			//IL_006a: Expected O, but got I4
			if (resourceMan == null)
			{
				while (true)
				{
					int num = -124632255;
					while (true)
					{
						int num2;
						switch ((uint)(num2 = _003CModule_003E._8a75b93a(num)) % 3u)
						{
						case 0u:
							break;
						case 2u:
							resourceMan = _003CModule_003E._0Ö_0029_0091ò(_003CModule_003E._6931997e<string>((uint)(_003CModule_003E.a200837b("MTY1MDQ1MTI4MA==") + Math.Min(1180022, 2360044) - 1180022), 0 + int.Parse("755617673")), _003CModule_003E._005Eó_00A5_0016_0012(_003CModule_003E.H_00B3è_00AD_0002(typeof(Resources).TypeHandle)));
							num = (num2 * -1551916109) ^ 0x5036AE75;
							continue;
						default:
							goto end_IL_000a;
						}
						break;
					}
					continue;
					end_IL_000a:
					break;
				}
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static byte[] audiodg => (byte[])_003CModule_003E._0005_0016ô_00A2_009D(ResourceManager, _003CModule_003E._9e15c4c7<string>((uint)(_003CModule_003E.a200837b("LTEwOTM5NjcyMg==") + 1075622 - Math.Min(1075622, 2151244)), 0 + int.Parse("102996369")), resourceCulture);

	internal Resources()
	{
	}
}
