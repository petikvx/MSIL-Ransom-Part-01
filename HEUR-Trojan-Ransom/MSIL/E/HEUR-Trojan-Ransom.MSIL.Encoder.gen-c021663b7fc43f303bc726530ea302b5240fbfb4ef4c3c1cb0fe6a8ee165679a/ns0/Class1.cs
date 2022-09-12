using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace ns0;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
[CompilerGenerated]
internal sealed class Class1 : ApplicationSettingsBase
{
	private static Class1 class1_0 = (Class1)(object)SettingsBase.Synchronized((SettingsBase)(object)new Class1());

	public static Class1 Class1_0 => class1_0;

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
