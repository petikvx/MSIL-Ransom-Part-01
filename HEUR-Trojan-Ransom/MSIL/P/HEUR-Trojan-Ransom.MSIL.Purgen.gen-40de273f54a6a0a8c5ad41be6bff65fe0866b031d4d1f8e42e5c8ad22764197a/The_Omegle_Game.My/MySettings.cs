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
				int num = -591200137;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA39C27ADu) % 3u)
					{
					case 2u:
						goto IL_0003;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0003:
					result = mySettings_0;
					num = (int)((num2 * 2137633284) ^ 0xDD15445);
				}
			}
		}
	}

	static SettingsBase smethod_0(SettingsBase settingsBase_0)
	{
		return SettingsBase.Synchronized(settingsBase_0);
	}
}
