using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Tsjxretch.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings settings_0 = (Settings)DestroyDic(new Settings());

	private static Settings ManageDic;

	public Settings()
	{
		int num = 0;
		if (_003CModule_003E_007B97c19ca2_002Dd30d_002D4926_002Db319_002D0f9297a6a699_007D.m_cb97231acb484e769859f57c677af3db != 0)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
	}

	public static Settings smethod_0()
	{
		return settings_0;
	}

	internal static bool NewDic()
	{
		return ManageDic == null;
	}

	internal static Settings SortDic()
	{
		return ManageDic;
	}

	internal static object DestroyDic(object object_0)
	{
		return SettingsBase.Synchronized((SettingsBase)object_0);
	}
}
