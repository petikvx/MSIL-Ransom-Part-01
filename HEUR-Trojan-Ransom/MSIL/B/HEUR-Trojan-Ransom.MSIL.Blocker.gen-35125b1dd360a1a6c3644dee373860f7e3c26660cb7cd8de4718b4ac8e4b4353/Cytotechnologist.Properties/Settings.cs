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
				int num = 161618202;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x299C68B5u) % 4u)
					{
					case 3u:
						result = defaultInstance;
						num = ((int)num2 * -1578369450) ^ 0x64BB270F;
						continue;
					case 0u:
						num = ((int)num2 * -1284250750) ^ 0x4D3898C8;
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

	public Settings()
	{
		while (true)
		{
			int num = -462145867;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFCDA3E54u) % 3u)
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
				num = (int)((num2 * 2061686864) ^ 0x596D04C0);
			}
		}
	}

	static SettingsBase smethod_0(SettingsBase settingsBase_0)
	{
		return SettingsBase.Synchronized(settingsBase_0);
	}
}
