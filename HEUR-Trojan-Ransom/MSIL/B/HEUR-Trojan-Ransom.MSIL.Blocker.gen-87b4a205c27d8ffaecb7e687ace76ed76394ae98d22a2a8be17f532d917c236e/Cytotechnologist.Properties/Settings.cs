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
			Settings result = defaultInstance;
			while (true)
			{
				int num = 2119178530;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2BA0B362u) % 3u)
					{
					case 1u:
						goto IL_0008;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0008:
					num = ((int)num2 * -1196397127) ^ -307474696;
				}
			}
		}
	}

	static SettingsBase smethod_0(SettingsBase settingsBase_0)
	{
		return SettingsBase.Synchronized(settingsBase_0);
	}
}
