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
				int num = -1843808196;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD08EDD23u) % 4u)
					{
					case 3u:
						result = defaultInstance;
						num = (int)((num2 * 1632906654) ^ 0x744AE223);
						continue;
					case 2u:
						num = (int)(num2 * 737265883) ^ -1219882544;
						continue;
					case 0u:
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
			int num = -1997760814;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB438922Fu) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0008:
				num = ((int)num2 * -156475304) ^ 0x3EB88819;
			}
		}
	}

	static SettingsBase smethod_0(SettingsBase settingsBase_0)
	{
		return SettingsBase.Synchronized(settingsBase_0);
	}
}
