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
				int num = 469632740;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB31534Du) % 4u)
					{
					case 2u:
						num = ((int)num2 * -983246838) ^ -1718676474;
						continue;
					case 1u:
						result = defaultInstance;
						num = (int)((num2 * 439649671) ^ 0x1EE31D30);
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
			int num = -1185880926;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB8989678u) % 3u)
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
				num = ((int)num2 * -903765248) ^ -1089207618;
			}
		}
	}

	static SettingsBase smethod_0(SettingsBase settingsBase_0)
	{
		return SettingsBase.Synchronized(settingsBase_0);
	}
}
