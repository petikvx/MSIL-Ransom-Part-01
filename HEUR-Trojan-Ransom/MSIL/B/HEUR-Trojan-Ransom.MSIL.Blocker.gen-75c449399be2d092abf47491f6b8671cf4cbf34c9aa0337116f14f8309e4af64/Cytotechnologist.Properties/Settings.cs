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
				int num = -1383635857;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDABF5C82u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -1955211496) ^ -1391067496;
						continue;
					case 1u:
						result = defaultInstance;
						num = (int)((num2 * 548474921) ^ 0x337E299C);
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
			int num = 1280765103;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x82AE87Fu) % 3u)
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
				num = (int)(num2 * 707213996) ^ -1652443479;
			}
		}
	}

	static SettingsBase smethod_0(SettingsBase settingsBase_0)
	{
		return SettingsBase.Synchronized(settingsBase_0);
	}
}
