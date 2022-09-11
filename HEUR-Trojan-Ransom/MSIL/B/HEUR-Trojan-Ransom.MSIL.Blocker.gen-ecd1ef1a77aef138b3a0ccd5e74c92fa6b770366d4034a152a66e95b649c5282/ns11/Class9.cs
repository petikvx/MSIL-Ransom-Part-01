using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace ns11;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
[CompilerGenerated]
internal sealed class Class9 : ApplicationSettingsBase
{
	private static Class9 defaultInstance = (Class9)(object)SettingsBase.Synchronized((SettingsBase)(object)new Class9());

	public static Class9 Default
	{
		get
		{
			int num = 0;
			do
			{
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 1);
			return defaultInstance;
		}
	}
}
