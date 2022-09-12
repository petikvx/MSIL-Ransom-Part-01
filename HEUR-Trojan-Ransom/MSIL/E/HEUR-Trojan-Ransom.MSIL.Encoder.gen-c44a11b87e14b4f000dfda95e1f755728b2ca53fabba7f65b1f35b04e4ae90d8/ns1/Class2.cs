using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace ns1;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
internal sealed class Class2 : ApplicationSettingsBase
{
	private static Class2 class2_0 = (Class2)(object)SettingsBase.Synchronized((SettingsBase)(object)new Class2());

	public static Class2 Class2_0 => class2_0;

	private static string smethod_0(string string_0)
	{
		int length = string_0.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = string_0[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		return string.Intern(new string(array));
	}
}
