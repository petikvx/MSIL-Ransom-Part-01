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
				int num = 142120666;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x26891052u) % 3u)
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
					num = (int)(num2 * 1134048785) ^ -8206264;
				}
			}
		}
	}

	static SettingsBase smethod_0(SettingsBase settingsBase_0)
	{
		return SettingsBase.Synchronized(settingsBase_0);
	}
}
