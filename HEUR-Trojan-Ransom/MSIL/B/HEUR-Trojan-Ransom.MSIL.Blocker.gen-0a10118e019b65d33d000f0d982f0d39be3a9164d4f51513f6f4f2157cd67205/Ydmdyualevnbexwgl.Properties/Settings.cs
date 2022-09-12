using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Ydmdyualevnbexwgl.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings m_a = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	private static Settings ChangeException;

	static Settings()
	{
		if (_003CModule_003E_007Ba75b27da_002Da501_002D4f51_002Dae75_002D3cf277e407e8_007D.m_543a2587f4c24572a7a85fce5275db64 == 0)
		{
			switch (0)
			{
			}
		}
	}

	public static Settings a()
	{
		return Settings.m_a;
	}

	internal static bool CreateException()
	{
		return ChangeException == null;
	}

	internal static Settings CheckException()
	{
		return ChangeException;
	}
}
