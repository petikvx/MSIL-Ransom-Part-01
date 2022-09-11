using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;
using ns3;

namespace ns7;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
[CompilerGenerated]
internal sealed class Class8 : ApplicationSettingsBase
{
	private static Class8 defaultInstance = (Class8)(object)Class1.Class2.smethod_1<SettingsBase>((SettingsBase)(object)new Class8(), 407, (short)415);

	public static Class8 Default
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
