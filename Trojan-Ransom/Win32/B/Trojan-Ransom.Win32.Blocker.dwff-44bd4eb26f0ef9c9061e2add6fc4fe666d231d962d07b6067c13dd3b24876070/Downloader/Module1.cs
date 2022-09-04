using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Downloader;

[StandardModule]
internal sealed class Module1
{
	[DllImport("kernel32", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	private static extern int WritePrivateProfileStringW([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpApplicationName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpKeyName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

	[DllImport("kernel32", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	private static extern int GetPrivateProfileStringW([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpApplicationName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpKeyName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpDefault, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

	public static void writeIni(string iniFileName, string Section, string ParamName, string ParamVal)
	{
		WritePrivateProfileStringW(ref Section, ref ParamName, ref ParamVal, ref iniFileName);
	}

	public static string ReadIni(string IniFileName, string Section, string ParamName, string ParamDefault)
	{
		string lpReturnedString = Strings.Space(1024);
		long num = GetPrivateProfileStringW(ref Section, ref ParamName, ref ParamDefault, ref lpReturnedString, Strings.Len(lpReturnedString), ref IniFileName);
		return Strings.Left(lpReturnedString, checked((int)num));
	}

	public static object smethod_0()
	{
		Version version = Environment.OSVersion.Version;
		string result = "Bilinmiyor";
		if ((version.Major == 5) & (version.Minor == 1))
		{
			result = "Windows 2000";
		}
		if ((version.Major == 5) & (version.Minor == 1))
		{
			result = "Windows XP";
		}
		if ((version.Major == 6) & (version.Minor == 0))
		{
			result = "Windows Vista";
		}
		if ((version.Major == 6) & (version.Minor == 1))
		{
			result = "Windows 7";
		}
		if ((version.Major == 6) & (version.Minor == 2))
		{
			result = "Windows 8";
		}
		if ((version.Major == 6) & (version.Minor == 3))
		{
			result = "Windows 8.1";
		}
		return result;
	}

	public static string GetAVInformation(string strSystem)
	{
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		string empty = string.Empty;
		string empty2 = string.Empty;
		string empty3 = string.Empty;
		StringBuilder stringBuilder = new StringBuilder();
		try
		{
			empty = ((Operators.CompareString(strSystem, Environment.MachineName, false) != 0) ? strSystem : ".");
			empty2 = "\\root\\SecurityCenter2";
			empty3 = "Select * from AntiVirusProduct";
			object objectValue = RuntimeHelpers.GetObjectValue(Interaction.GetObject("winmgmts:\\\\" + empty + empty2, (string)null));
			object[] array = new object[1] { empty3 };
			bool[] array2 = new bool[1] { true };
			object obj = NewLateBinding.LateGet(objectValue, (Type)null, "ExecQuery", array, (string[])null, (Type[])null, array2);
			if (array2[0])
			{
				empty3 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			object objectValue2 = RuntimeHelpers.GetObjectValue(obj);
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ((IEnumerable)objectValue2).GetEnumerator();
				while (enumerator.MoveNext())
				{
					object objectValue3 = RuntimeHelpers.GetObjectValue(enumerator.Current);
					try
					{
						stringBuilder.AppendLine(NewLateBinding.LateGet(objectValue3, (Type)null, "displayname", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						stringBuilder.AppendLine("??\t\t\t??");
						ProjectData.ClearProjectError();
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message, "", (MessageBoxButtons)0, (MessageBoxIcon)48);
			ProjectData.ClearProjectError();
		}
		return stringBuilder.ToString();
	}

	public static object smethod_1()
	{
		return GetAVInformation(Environment.MachineName);
	}

	public static void BeniKopyala()
	{
	}
}
