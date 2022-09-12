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
				int num = -407121519;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF34DAF7Cu) % 4u)
					{
					case 1u:
						result = defaultInstance;
						num = ((int)num2 * -278059304) ^ 0x14F16C78;
						continue;
					case 0u:
						num = ((int)num2 * -1351244034) ^ 0x2884198E;
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
			int num = -442126561;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCCFC9BE4u) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0008:
				num = (int)(num2 * 1172043396) ^ -1294676242;
			}
		}
	}

	static SettingsBase smethod_0(SettingsBase settingsBase_0)
	{
		return SettingsBase.Synchronized(settingsBase_0);
	}
}
