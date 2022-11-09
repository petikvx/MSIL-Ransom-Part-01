using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Nbuujxdbv.Properties;

[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
internal class Resources
{
	private static ResourceManager model;

	private static CultureInfo list;

	private static Resources InitContext;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			int num = 2;
			while (true)
			{
				bool flag = model == null;
				int num2 = 1;
				if (_003CModule_003E_007Bce07eb46_002D7fe1_002D4ead_002Dbc61_002D86bf4ccd807c_007D.m_7fc74166f48c44758e6e2820600e8622 == 0)
				{
					goto IL_003e;
				}
				goto IL_0042;
				IL_0042:
				while (true)
				{
					switch (num2)
					{
					case 1:
						if (flag)
						{
							goto IL_000f;
						}
						goto default;
					case 2:
						break;
					default:
						return model;
					}
					break;
					IL_000f:
					ResourceManager resourceManager = (model = new ResourceManager("Nbuujxdbv.Properties.Resources", typeof(Resources).Assembly));
					num2 = 0;
					if (_003CModule_003E_007Bce07eb46_002D7fe1_002D4ead_002Dbc61_002D86bf4ccd807c_007D.m_1ea0f64528614d1e83b1ab65fdfcf922 == 0)
					{
						continue;
					}
					goto IL_003e;
				}
				continue;
				IL_003e:
				num2 = num;
				goto IL_0042;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return list;
		}
		set
		{
			list = value;
		}
	}

	internal static string MSISMBService => ResourceManager.GetString("MSISMBService", list);

	internal static string MSISuperIOService => ResourceManager.GetString("MSISuperIOService", list);

	internal Resources()
	{
	}

	internal static bool AssetContext()
	{
		return InitContext == null;
	}

	internal static Resources DisableContext()
	{
		return InitContext;
	}
}
