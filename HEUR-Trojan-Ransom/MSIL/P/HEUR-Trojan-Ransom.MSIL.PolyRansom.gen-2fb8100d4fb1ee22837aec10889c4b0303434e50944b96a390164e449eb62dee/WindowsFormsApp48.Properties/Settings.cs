using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp48.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	internal static Settings AddDefinition;

	public static Settings Default
	{
		get
		{
			Settings result;
			while (true)
			{
				result = defaultInstance;
				if (_003CModule_003E_007B733d650e_002De456_002D45c0_002Da44d_002D64a1e0c75f2d_007D.m_dad296b59bcb4e1e9a447617e02d23c5 != 0)
				{
					switch (0)
					{
					case 1:
						continue;
					}
				}
				break;
			}
			return result;
		}
	}

	internal static bool ComputeDefinition()
	{
		return AddDefinition == null;
	}

	internal static Settings MoveDefinition()
	{
		return AddDefinition;
	}
}
