using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace ShTepler.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings settings_0 = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	public static Settings Default
	{
		get
		{
			Settings result = default(Settings);
			while (true)
			{
				int num = -581691303;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA207F38Cu) % 4u)
					{
					case 3u:
						num = ((int)num2 * -558234244) ^ -1731507318;
						continue;
					case 1u:
						result = settings_0;
						num = (int)(num2 * 1816002144) ^ -377837837;
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
			int num = 2102322748;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x54DBAA41u) % 3u)
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
				num = ((int)num2 * -2144192773) ^ -2103820201;
			}
		}
	}
}
