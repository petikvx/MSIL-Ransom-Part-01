using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace The_Omegle_Game.My;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings mySettings_0 = (MySettings)(object)MySettings.smethod_0((SettingsBase)(object)new MySettings());

	public static MySettings Default
	{
		get
		{
			MySettings result = default(MySettings);
			while (true)
			{
				int num = -1767185905;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBF48FA92u) % 4u)
					{
					case 3u:
						num = (int)((num2 * 1983899397) ^ 0x7087CB9);
						continue;
					case 1u:
						result = mySettings_0;
						num = (int)(num2 * 1697989986) ^ -1154965713;
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
