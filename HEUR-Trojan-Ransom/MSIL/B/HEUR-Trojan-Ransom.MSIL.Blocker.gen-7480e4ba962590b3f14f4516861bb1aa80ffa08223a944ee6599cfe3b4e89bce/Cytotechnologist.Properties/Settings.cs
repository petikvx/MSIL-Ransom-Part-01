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
				int num = 2110479480;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7F30D4BDu) % 4u)
					{
					case 3u:
						num = (int)((num2 * 686315550) ^ 0xA8743B3);
						continue;
					case 1u:
						result = defaultInstance;
						num = ((int)num2 * -1600854357) ^ 0x1140CCED;
						continue;
					case 2u:
						break;
					default:
						return result;
					}
					break;
				}
			}
		}
	}

	static SettingsBase smethod_0(SettingsBase settingsBase_0)
	{
		return SettingsBase.Synchronized(settingsBase_0);
	}
}
