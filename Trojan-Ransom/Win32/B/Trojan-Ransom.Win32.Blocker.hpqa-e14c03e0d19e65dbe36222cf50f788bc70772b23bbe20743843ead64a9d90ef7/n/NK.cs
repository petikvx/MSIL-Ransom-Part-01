using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace n;

[StandardModule]
public sealed class NK
{
	public static string Key = "HKEY_CURRENT_USER\\Software\\nKey";

	public static Registry R;

	public static void SetValue(ref string N, ref string V)
	{
		Registry.SetValue(Key, N, V, RegistryValueKind.String);
	}

	public static string GetValue(ref string N, ref string DF)
	{
		string text = Conversions.ToString(Registry.GetValue(Key, N, null));
		if (Operators.CompareString(text, (string)null, false) == 0)
		{
			return DF;
		}
		return text;
	}

	public static void DeleteValue(ref string N)
	{
		Array array = Strings.Split(Key, "\\", -1, (CompareMethod)0);
		string name = Key.Replace(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"\\")), "");
		Registry.CurrentUser.OpenSubKey(name, writable: true)!.DeleteValue(N);
	}

	public static void CLEAR()
	{
		string sU = B.SU;
		B.SU = "*";
		if (Operators.CompareString(sU, "*", false) != 0)
		{
			try
			{
				Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue(sU);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue(sU);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		try
		{
			Array array = Strings.Split(Key, "\\", -1, (CompareMethod)0);
			Registry.CurrentUser.OpenSubKey("Software", writable: true)!.DeleteSubKey(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { checked(array.Length - 1) }, (string[])null)), throwOnMissingSubKey: false);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}
}
