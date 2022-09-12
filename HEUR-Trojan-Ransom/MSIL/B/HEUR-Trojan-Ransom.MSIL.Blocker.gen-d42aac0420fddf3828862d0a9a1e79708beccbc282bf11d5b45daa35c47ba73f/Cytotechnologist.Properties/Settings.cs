using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Cytotechnologist.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.0.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)(object)Settings.smethod_0((SettingsBase)(object)new Settings());

	public static Settings Default
	{
		get
		{
			Settings result = default(Settings);
			while (true)
			{
				int num = -1995339948;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBE2200C5u) % 4u)
					{
					case 2u:
						num = (int)(num2 * 1488820164) ^ -1470040755;
						continue;
					case 1u:
						result = defaultInstance;
						num = ((int)num2 * -1426443664) ^ 0x374B3057;
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

	public Settings()
	{
		while (true)
		{
			int num = -1712772915;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE760D2A3u) % 3u)
				{
				case 2u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0008:
				num = ((int)num2 * -1607290258) ^ 0x54C0D011;
			}
		}
	}

	static SettingsBase smethod_0(SettingsBase settingsBase_0)
	{
		return SettingsBase.Synchronized(settingsBase_0);
	}
}
