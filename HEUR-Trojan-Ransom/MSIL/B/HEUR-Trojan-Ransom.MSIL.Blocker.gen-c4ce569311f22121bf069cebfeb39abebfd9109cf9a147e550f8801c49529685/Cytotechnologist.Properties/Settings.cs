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
				int num = -560246618;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF87426FFu) % 4u)
					{
					case 3u:
						num = (int)((num2 * 1067838757) ^ 0x3D77FB3A);
						continue;
					case 1u:
						result = defaultInstance;
						num = ((int)num2 * -1148555584) ^ 0x7628AAC0;
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

	static SettingsBase smethod_0(SettingsBase settingsBase_0)
	{
		return SettingsBase.Synchronized(settingsBase_0);
	}
}
