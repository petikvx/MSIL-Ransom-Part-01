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
				int num = -2108081408;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC01DD07Du) % 4u)
					{
					case 3u:
						num = (int)(num2 * 441920066) ^ -1565487541;
						continue;
					case 1u:
						result = mySettings_0;
						num = (int)((num2 * 1437345495) ^ 0x42AA59A9);
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
