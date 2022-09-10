using System;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Autodesk.ExpressTools.AliasEdit.Autodesk.ExpressTools.AliasEdit;

[StandardModule]
internal sealed class BnsReg
{
	private struct SECURITY_ATTRIBUTES
	{
		public int nLength;

		public int lpSecurityDescriptor;

		public bool bInheritHandle;
	}

	private struct FILETIME
	{
		public int dwLowDateTime;

		public int dwHighDateTime;
	}

	private const int STANDARD_RIGHTS_ALL = 2031616;

	private const short KEY_QUERY_VALUE = 1;

	private const short KEY_SET_VALUE = 2;

	private const short KEY_CREATE_SUB_KEY = 4;

	private const short KEY_ENUMERATE_SUB_KEYS = 8;

	private const short KEY_NOTIFY = 16;

	private const short KEY_CREATE_LINK = 32;

	private const int SYNCHRONIZE = 1048576;

	private const int READ_CONTROL = 131072;

	private const int STANDARD_RIGHTS_READ = 131072;

	private const short REG_BINARY = 3;

	private const short REG_DWORD_BIG_ENDIAN = 5;

	private const short REG_DWORD_LITTLE_ENDIAN = 4;

	private const short REG_EXPAND_SZ = 2;

	private const short REG_LINK = 6;

	private const short REG_MULTI_SZ = 7;

	private const short REG_NONE = 0;

	private const short REG_RESOURCE_LIST = 8;

	public const short REG_SZ = 1;

	public const short REG_DWORD = 4;

	private const short REG_OPTION_NON_VOLATILE = 0;

	private const short REG_OPTION_VOLATILE = 1;

	private const short ERROR_SUCCESS = 0;

	private const short ERROR_ACCESS_DENIED = 5;

	private const short ERROR_NO_MORE_ITEMS = 259;

	private const int HKEY_CLASSES_ROOT = int.MinValue;

	private const int HKEY_LOCAL_MACHINE = -2147483646;

	private const int HKEY_CURRENT_USER = -2147483647;

	private const int HKEY_CURRENT_CONFIG = -2147483643;

	private const bool KEY_ALL_ACCESS = true;

	private const bool KEY_READ = true;

	private static ResourceManager resManager = frmAlias.DefInstance.resManager;

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int RegOpenKeyExA(int hkey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpSubKey, int ulOptions, int samDesired, ref int phkResult);

	[DllImport("advapi32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int RegQueryValueExA(int hkey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpValueName, int lpReserved, ref int lpType, [MarshalAs(UnmanagedType.VBByRefStr)] ref string szData, ref int lpcbData);

	[DllImport("advapi32", CharSet = CharSet.Ansi, EntryPoint = "RegQueryValueExA", ExactSpelling = true, SetLastError = true)]
	private static extern int RegQueryValueExA_1(int hkey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpValueName, int lpReserved, ref int lpType, ref int szData, ref int lpcbData);

	[DllImport("advapi32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int RegSetValueExA(int hkey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpValueName, int Reserved, int dwType, [MarshalAs(UnmanagedType.VBByRefStr)] ref string szData, int cbData);

	[DllImport("advapi32", CharSet = CharSet.Ansi, EntryPoint = "RegSetValueExA", ExactSpelling = true, SetLastError = true)]
	private static extern int RegSetValueExA_1(int hkey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpValueName, int Reserved, int dwType, ref byte lpData, int cbData);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int RegCloseKey(int hkey);

	[DllImport("advapi32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int RegCreateKeyExA(int hkey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpSubKey, int Reserved, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpClass, int dwOptions, int samDesired, ref SECURITY_ATTRIBUTES lpSecurityAttributes, ref int phkResult, ref int lpdwDisposition);

	[DllImport("shell32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int FindExecutableA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFile, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpDirectory, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpResult);

	public static bool ExtAssociate(string ext, string appexe, ref string idstr)
	{
		if (!((Operators.CompareString(ext, "", false) == 0) | (Operators.CompareString(appexe, "", false) == 0) | (Operators.CompareString(idstr, "", false) == 0)))
		{
			if (Operators.CompareString(Strings.Left(ext, 1), ".", false) != 0)
			{
				ext = "." + ext;
			}
			appexe = BnsStr.FindFile(appexe, ".");
			if (Operators.CompareString(appexe, "", false) != 0)
			{
				string text = "HKEY_CLASSES_ROOT\\" + ext;
				string key = text;
				string name = "";
				object val_Renamed = idstr;
				int typ = 1;
				bool num = acet_RegistryWrite(key, ref name, ref val_Renamed, ref typ);
				idstr = Conversions.ToString(val_Renamed);
				bool result = num;
				if (num)
				{
					text = "HKEY_CLASSES_ROOT\\" + idstr + "\\shell\\open\\command";
					string key2 = text;
					name = "";
					val_Renamed = BnsStr.StrDoubleQuote(appexe) + " " + BnsStr.StrDoubleQuote("%1");
					typ = 1;
					result = acet_RegistryWrite(key2, ref name, ref val_Renamed, ref typ);
				}
				return result;
			}
		}
		bool result2 = default(bool);
		return result2;
	}

	public static bool WriteToRecentFileList(ref string appname, string fna)
	{
		string[] fna2 = new string[1];
		bool refresh = false;
		fna = BnsStr.UNCtoLocalName(ref fna, ref refresh);
		int num = ReadRecentFileList(ref appname, ref fna2);
		checked
		{
			fna2 = (string[])Utils.CopyArray((Array)fna2, (Array)new string[num + 1]);
			if (num >= 0)
			{
				refresh = true;
				int num2 = BnsStr.strMemberPosition(ref fna, ref fna2, ref refresh);
				if (num2 >= 0)
				{
					int num3 = num - 1;
					for (int i = num2; i <= num3; i++)
					{
						fna2[i] = fna2[i + 1];
					}
					num--;
				}
				if (num < 3)
				{
					num++;
				}
				for (int i = num; i >= 1; i += -1)
				{
					fna2[i] = fna2[i - 1];
				}
			}
			else
			{
				num = 0;
			}
			fna2[0] = fna;
			string key = "HKEY_CURRENT_USER\\SOFTWARE\\Autodesk\\" + appname + "\\Recent File List";
			int num4 = num;
			bool result = default(bool);
			for (int i = 0; i <= num4; i++)
			{
				string name = "File" + Conversions.ToString(i + 1);
				string[] array = fna2;
				int num5 = i;
				object val_Renamed = array[num5];
				int typ = 1;
				bool num6 = acet_RegistryWrite(key, ref name, ref val_Renamed, ref typ);
				fna2[num5] = Conversions.ToString(val_Renamed);
				result = num6;
			}
			return result;
		}
	}

	public static int ReadRecentFileList(ref string appname, ref string[] fna)
	{
		fna = new string[1];
		int num = -1;
		string keypath = "HKEY_CURRENT_USER\\SOFTWARE\\Autodesk\\" + appname + "\\Recent File List";
		string text = "File";
		int num2 = 1;
		checked
		{
			string text2;
			do
			{
				string name = text + Conversions.ToString(num2);
				object def = "";
				text2 = Conversions.ToString(acet_RegistryRead(keypath, ref name, ref def));
				if (Operators.CompareString(text2, "", false) != 0)
				{
					num++;
					fna = (string[])Utils.CopyArray((Array)fna, (Array)new string[num + 1]);
					fna[num] = text2;
				}
				num2++;
			}
			while (Operators.CompareString(text2, "", false) != 0);
			return num;
		}
	}

	public static bool WriteFormLocationToReg(ref string appname, ref Form frm)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected I4, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Invalid comparison between I4 and Unknown
		int num = (int)frm.get_WindowState();
		if (num != 0)
		{
			frm.set_WindowState((FormWindowState)0);
		}
		string text = Conversions.ToString(((Control)frm).get_Left()) + " " + Conversions.ToString(((Control)frm).get_Top()) + " " + Conversions.ToString(((Control)frm).get_Width()) + " " + Conversions.ToString(((Control)frm).get_Height());
		if (num != (int)frm.get_WindowState())
		{
			frm.set_WindowState((FormWindowState)num);
		}
		string key = "HKEY_CURRENT_USER\\SOFTWARE\\Autodesk\\" + appname + "\\Application Window";
		string name = "Position";
		object val_Renamed = text;
		int typ = 1;
		acet_RegistryWrite(key, ref name, ref val_Renamed, ref typ);
		text = Conversions.ToString(val_Renamed);
		name = "Show";
		val_Renamed = Conversions.ToString(num);
		typ = 1;
		return acet_RegistryWrite(key, ref name, ref val_Renamed, ref typ);
	}

	public static bool SetFormLocationFromReg(ref string appname, ref Form frm)
	{
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Invalid comparison between Unknown and I4
		string[] strresult = new string[1];
		string keypath = "HKEY_CURRENT_USER\\SOFTWARE\\Autodesk\\" + appname + "\\Application Window";
		string name = "Position";
		object def = "";
		string strmain = Conversions.ToString(acet_RegistryRead(keypath, ref name, ref def));
		name = "Show";
		def = "";
		string text = Conversions.ToString(acet_RegistryRead(keypath, ref name, ref def));
		if ((Operators.CompareString(strmain, "", false) != 0) & (Operators.CompareString(text, "", false) != 0))
		{
			name = " ";
			int num = StrDelim(ref name, ref strmain, ref strresult);
			if (num >= 3)
			{
				int num2 = ((!Versioned.IsNumeric((object)strresult[0])) ? ((Control)frm).get_Left() : Conversions.ToInteger(strresult[0]));
				int num3 = ((!Versioned.IsNumeric((object)strresult[1])) ? ((Control)frm).get_Top() : Conversions.ToInteger(strresult[1]));
				int num4 = ((!Versioned.IsNumeric((object)strresult[2])) ? ((Control)frm).get_Width() : Conversions.ToInteger(strresult[2]));
				int num5 = ((!Versioned.IsNumeric((object)strresult[3])) ? ((Control)frm).get_Height() : Conversions.ToInteger(strresult[3]));
				num = (Versioned.IsNumeric((object)text) ? Conversions.ToInteger(text) : 0);
				if ((int)frm.get_WindowState() != 0)
				{
					frm.set_WindowState((FormWindowState)0);
				}
				((Control)frm).SetBounds(num2, num3, num4, num5);
				frm.set_WindowState((FormWindowState)num);
				return true;
			}
		}
		bool result = default(bool);
		return result;
	}

	public static string GetAssociatedApp(ref string fna)
	{
		string lpDirectory = Strings.Space(255);
		string lpResult = Strings.Space(255);
		int num = FindExecutableA(ref fna, ref lpDirectory, ref lpResult);
		if (num <= 32)
		{
			return "";
		}
		return StripNullString(ref lpResult);
	}

	private static string StripNullString(ref string str_Renamed)
	{
		int i = 1;
		string text = "";
		checked
		{
			for (; i <= Strings.Len(str_Renamed); i++)
			{
				string text2 = Strings.Mid(str_Renamed, i, 1);
				if (Operators.CompareString(text2, "\0", false) != 0)
				{
					text += text2;
				}
				else
				{
					i = Strings.Len(str_Renamed) + 1;
				}
			}
			return text;
		}
	}

	public static bool acet_setvar_str(ref string name, ref string val_Renamed, ref int flag = 0)
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		string name2 = Strings.UCase(name);
		string text = val_Renamed;
		int flag2 = flag;
		bool result = false;
		text = "STR__" + text;
		if (flag2 <= 0)
		{
			flag2 = 2;
		}
		while (flag2 > 0)
		{
			string text2 = acet_setvar_key(ref flag2);
			object val_Renamed2 = text;
			int typ = 1;
			bool num = acet_RegistryWrite(text2, ref name2, ref val_Renamed2, ref typ);
			text = Conversions.ToString(val_Renamed2);
			if (!num)
			{
				result = false;
				flag2 = 0;
				Interaction.MsgBox((object)(resManager.GetString("REG_CALLACET") + text2), (MsgBoxStyle)0, (object)null);
			}
			else
			{
				result = true;
			}
		}
		return result;
	}

	public static bool acet_setvar_int(ref string name, ref int val_Renamed, ref int flag = 0)
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		string name2 = Strings.UCase(name);
		string text = "INT__" + Conversions.ToString(val_Renamed);
		int flag2 = flag;
		bool result = false;
		if (flag2 <= 0)
		{
			flag2 = 2;
		}
		while (flag2 > 0)
		{
			string text2 = acet_setvar_key(ref flag2);
			if (Operators.CompareString(text2, "", false) != 0)
			{
				object val_Renamed2 = text;
				int typ = 1;
				bool num = acet_RegistryWrite(text2, ref name2, ref val_Renamed2, ref typ);
				text = Conversions.ToString(val_Renamed2);
				if (!num)
				{
					Interaction.MsgBox((object)(resManager.GetString("REG_ERRWRITE") + text2), (MsgBoxStyle)0, (object)null);
					flag2 = 0;
					result = false;
				}
				else
				{
					result = true;
				}
			}
			else
			{
				Interaction.MsgBox((object)(resManager.GetString("REG_INVALIDFLAG") + name + " " + text), (MsgBoxStyle)0, (object)null);
				flag2 = 0;
				result = false;
			}
		}
		return result;
	}

	public static bool acet_setvar_real(ref string name, ref double val_Renamed, ref int flag = 0)
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		string name2 = Strings.UCase(name);
		string text = "REAL_" + Conversions.ToString(val_Renamed);
		int flag2 = flag;
		bool result = false;
		if (flag2 <= 0)
		{
			flag2 = 2;
		}
		while (flag2 > 0)
		{
			string text2 = acet_setvar_key(ref flag2);
			if (Operators.CompareString(text2, "", false) != 0)
			{
				object val_Renamed2 = text;
				int typ = 1;
				bool num = acet_RegistryWrite(text2, ref name2, ref val_Renamed2, ref typ);
				text = Conversions.ToString(val_Renamed2);
				if (!num)
				{
					Interaction.MsgBox((object)(resManager.GetString("REG_ERRWRITE") + text2), (MsgBoxStyle)0, (object)null);
					flag2 = 0;
					result = false;
				}
				else
				{
					result = true;
				}
			}
			else
			{
				Interaction.MsgBox((object)(resManager.GetString("REG_INVALIDFLAG") + name + " " + text), (MsgBoxStyle)0, (object)null);
				flag2 = 0;
				result = false;
			}
		}
		return result;
	}

	public static object acet_getvar(ref string name, ref int flag = 0, ref object def = 0)
	{
		object obj = null;
		string name2 = Strings.UCase(name);
		int flag2 = flag;
		if (flag2 <= 0)
		{
			flag2 = 6;
		}
		while (flag2 > 0)
		{
			string text = acet_setvar_key(ref flag2);
			if (Operators.CompareString(text, "", false) != 0)
			{
				object def2 = "";
				obj = RuntimeHelpers.GetObjectValue(acet_RegistryRead(text, ref name2, ref def2));
				obj = ((Strings.Len(RuntimeHelpers.GetObjectValue(obj)) < 5) ? "" : ((Operators.CompareString(Strings.UCase(Strings.Left(Conversions.ToString(obj), 5)), "STR__", false) == 0) ? Strings.Mid(Conversions.ToString(obj), 6) : ((Operators.CompareString(Strings.UCase(Strings.Left(Conversions.ToString(obj), 5)), "INT__", false) == 0) ? ((object)Conversions.ToInteger(Strings.Mid(Conversions.ToString(obj), 6))) : ((Operators.CompareString(Strings.UCase(Strings.Left(Conversions.ToString(obj), 5)), "REAL_", false) != 0) ? "" : ((object)Conversions.ToDouble(Strings.Mid(Conversions.ToString(obj), 6)))))));
				if (Operators.ConditionalCompareObjectNotEqual(obj, (object)"", false))
				{
					flag2 = 0;
				}
			}
			else
			{
				flag2 = 0;
				obj = "";
			}
		}
		if (Operators.ConditionalCompareObjectEqual(obj, (object)"", false))
		{
			obj = RuntimeHelpers.GetObjectValue(def);
		}
		return RuntimeHelpers.GetObjectValue(obj);
	}

	public static string acet_setvar_key(ref int flag)
	{
		string text = "HKEY_CURRENT_USER\\" + AcadProductKey();
		if ((2u & (uint)flag) != 0)
		{
			text = text + "\\Profiles\\" + GetCurrentAcadProfile();
			checked
			{
				flag -= 2;
			}
		}
		else if ((4u & (uint)flag) != 0)
		{
			text += "\\FixedProfile";
			checked
			{
				flag -= 4;
			}
		}
		else
		{
			flag = -1;
		}
		if (flag >= 0)
		{
			return text + "\\General";
		}
		return "";
	}

	public static string AcadTempdir(ref string profilename = "")
	{
		if (Operators.CompareString(profilename, "", false) == 0)
		{
			profilename = GetCurrentAcadProfile();
		}
		string keypath = "HKEY_CURRENT_USER\\" + AcadProductKey() + "\\Profiles\\General Configuration";
		string name = "TempDirectory";
		object def = BnsStr.WinTempDir();
		string text = Conversions.ToString(acet_RegistryRead(keypath, ref name, ref def));
		if (Strings.Len(text) > 0 && Operators.CompareString(Strings.Right(text, 1), "\\", false) != 0)
		{
			text += "\\";
		}
		return text;
	}

	public static object acet_RegistryRead(string keypath, ref string name, ref object def)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int hkey = default(int);
		string szData = default(string);
		int lpcbData = default(int);
		int num5 = default(int);
		int phkResult = default(int);
		int lpType = default(int);
		int szData2 = default(int);
		object obj = default(object);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num4;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 2;
					goto IL_0008;
				case 452:
					{
						num2 = num;
						switch (num3)
						{
						case 2:
							break;
						case 1:
							goto IL_0116;
						default:
							goto end_IL_0000;
						}
						goto IL_00e8;
					}
					IL_0116:
					num4 = num2 + 1;
					num2 = 0;
					switch (num4)
					{
					case 1:
					case 4:
					case 10:
					case 14:
					case 20:
					case 25:
						break;
					case 2:
						goto IL_0008;
					case 3:
						goto IL_0016;
					case 5:
					case 6:
						goto IL_0020;
					case 7:
						goto IL_002f;
					case 8:
						goto IL_003a;
					case 9:
						goto IL_004a;
					case 11:
					case 12:
						goto IL_0055;
					case 13:
						goto IL_0069;
					case 15:
					case 16:
						goto IL_0071;
					case 17:
						goto IL_007a;
					case 18:
						goto IL_0086;
					case 19:
						goto IL_009a;
					case 21:
					case 22:
					case 23:
						goto IL_00a2;
					case 24:
						goto IL_00ae;
					case 26:
					case 27:
						goto IL_00b6;
					case 28:
						goto IL_00bf;
					case 30:
						goto IL_00d0;
					case 31:
						goto IL_00d4;
					case 34:
						goto IL_00e8;
					case 35:
						goto IL_00f1;
					case 36:
						goto IL_00f9;
					case 37:
					case 38:
						goto end_IL_0000_2;
					default:
						goto end_IL_0000;
					case 29:
					case 32:
					case 33:
					case 39:
						goto end_IL_0000_3;
					}
					goto default;
					IL_0008:
					num = 2;
					keypath = hkeyPathFormat(ref keypath, ref hkey);
					goto IL_0016;
					IL_0016:
					num = 3;
					if (hkey != 0)
					{
						goto IL_0020;
					}
					goto IL_00e8;
					IL_0020:
					num = 6;
					szData = Strings.Space(4096);
					goto IL_002f;
					IL_002f:
					num = 7;
					lpcbData = Strings.Len(szData);
					goto IL_003a;
					IL_003a:
					num = 8;
					num5 = RegOpenKeyExA(hkey, ref keypath, 0, 1, ref phkResult);
					goto IL_004a;
					IL_004a:
					num = 9;
					if (num5 == 0)
					{
						goto IL_0055;
					}
					goto IL_00e8;
					IL_0055:
					num = 12;
					num5 = RegQueryValueExA(phkResult, ref name, 0, ref lpType, ref szData, ref lpcbData);
					goto IL_0069;
					IL_0069:
					num = 13;
					if (num5 == 0)
					{
						goto IL_0071;
					}
					goto IL_00e8;
					IL_0071:
					num = 16;
					if (lpType == 4)
					{
						goto IL_007a;
					}
					goto IL_00a2;
					IL_007a:
					num = 17;
					lpcbData = Strings.Len(szData2);
					goto IL_0086;
					IL_0086:
					num = 18;
					num5 = RegQueryValueExA_1(phkResult, ref name, 0, ref lpType, ref szData2, ref lpcbData);
					goto IL_009a;
					IL_009a:
					num = 19;
					if (num5 == 0)
					{
						goto IL_00a2;
					}
					goto IL_00e8;
					IL_00a2:
					num = 23;
					num5 = RegCloseKey(phkResult);
					goto IL_00ae;
					IL_00ae:
					num = 24;
					if (num5 == 0)
					{
						goto IL_00b6;
					}
					goto IL_00e8;
					IL_00b6:
					num = 27;
					if (lpType == 4)
					{
						goto IL_00bf;
					}
					goto IL_00d0;
					IL_00bf:
					num = 28;
					obj = szData2;
					goto end_IL_0000_3;
					IL_00d0:
					num = 30;
					goto IL_00d4;
					IL_00d4:
					num = 31;
					obj = Strings.Left(szData, checked(lpcbData - 1));
					goto end_IL_0000_3;
					IL_00e8:
					num = 34;
					if (phkResult == 0)
					{
						break;
					}
					goto IL_00f1;
					IL_00f1:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_00f9;
					IL_00f9:
					num = 36;
					RegCloseKey(phkResult);
					break;
					end_IL_0000_2:
					break;
				}
				num = 38;
				obj = RuntimeHelpers.GetObjectValue(def);
				break;
				end_IL_0000:;
			}
			catch (object obj2) when (obj2 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0000_dispatch = 452;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		object result = obj;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool acet_RegistryWrite(string key, ref string name, ref object val_Renamed, ref int typ = 1)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string key2 = default(string);
		int hkey = default(int);
		int num5 = default(int);
		SECURITY_ATTRIBUTES lpSecurityAttributes = default(SECURITY_ATTRIBUTES);
		int phkResult = default(int);
		int lpdwDisposition = default(int);
		int num6 = default(int);
		byte[] array = default(byte[]);
		int num8 = default(int);
		bool flag = default(bool);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num4;
				int hkey2;
				int hkey3;
				string lpClass;
				int num7;
				object object_Renamed;
				object dest;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 2;
					goto IL_0008;
				case 560:
					{
						num2 = num;
						switch (num3)
						{
						case 2:
							break;
						case 1:
							goto IL_0192;
						default:
							goto end_IL_0000;
						}
						goto IL_016a;
					}
					IL_0192:
					num4 = num2 + 1;
					num2 = 0;
					switch (num4)
					{
					case 1:
					case 5:
					case 9:
					case 25:
						break;
					case 2:
						goto IL_0008;
					case 3:
						goto IL_000e;
					case 4:
						goto IL_001c;
					case 6:
					case 7:
						goto IL_0027;
					case 8:
						goto IL_0047;
					case 10:
					case 11:
						goto IL_0052;
					case 12:
						goto IL_005b;
					case 13:
						goto IL_0067;
					case 15:
						goto IL_0095;
					case 16:
						goto IL_00b0;
					case 17:
						goto IL_00bd;
					case 18:
					case 20:
						goto IL_00d0;
					case 21:
						goto IL_00ee;
					case 22:
						goto IL_0126;
					case 14:
					case 23:
					case 24:
						goto IL_0145;
					case 26:
					case 27:
						goto IL_014e;
					case 28:
						goto IL_015b;
					case 30:
						goto IL_016a;
					case 31:
						goto IL_0173;
					case 32:
						goto IL_017b;
					case 33:
					case 34:
						goto end_IL_0000_2;
					default:
						goto end_IL_0000;
					case 29:
					case 35:
						goto end_IL_0000_3;
					}
					goto default;
					IL_0008:
					num = 2;
					key2 = key;
					goto IL_000e;
					IL_000e:
					num = 3;
					key2 = hkeyPathFormat(ref key2, ref hkey);
					goto IL_001c;
					IL_001c:
					num = 4;
					if (hkey != 0)
					{
						goto IL_0027;
					}
					goto IL_016a;
					IL_0027:
					num = 7;
					hkey2 = hkey;
					lpClass = "";
					num5 = RegCreateKeyExA(hkey2, ref key2, 0, ref lpClass, 0, -1, ref lpSecurityAttributes, ref phkResult, ref lpdwDisposition);
					goto IL_0047;
					IL_0047:
					num = 8;
					if (num5 == 0)
					{
						goto IL_0052;
					}
					goto IL_016a;
					IL_0052:
					num = 11;
					if (typ == 1)
					{
						goto IL_005b;
					}
					goto IL_0095;
					IL_005b:
					num = 12;
					Conversions.ToString(val_Renamed);
					goto IL_0067;
					IL_0067:
					num = 13;
					hkey3 = phkResult;
					lpClass = Conversions.ToString(val_Renamed);
					num5 = RegSetValueExA(hkey3, ref name, 0, 1, ref lpClass, checked(Strings.Len(RuntimeHelpers.GetObjectValue(val_Renamed)) + 1));
					goto IL_0145;
					IL_0095:
					num = 15;
					if ((typ == 4) & Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(val_Renamed)))
					{
						goto IL_00b0;
					}
					goto IL_0145;
					IL_00b0:
					num = 16;
					num6 = Conversions.ToInteger(val_Renamed);
					goto IL_00bd;
					IL_00bd:
					num = 17;
					array = new byte[checked(Strings.Len(num6) + 1)];
					goto IL_00d0;
					IL_00d0:
					num = 20;
					object_Renamed = num6;
					num7 = BnsStr.agGetAddressForObject(ref object_Renamed);
					num6 = Conversions.ToInteger(object_Renamed);
					num8 = num7;
					goto IL_00ee;
					IL_00ee:
					num = 21;
					object_Renamed = num8;
					dest = array[0];
					BnsStr.agCopyData(ref object_Renamed, ref dest, Strings.Len(num6));
					array[0] = Conversions.ToByte(dest);
					num8 = Conversions.ToInteger(object_Renamed);
					goto IL_0126;
					IL_0126:
					num = 22;
					num5 = RegSetValueExA_1(phkResult, ref name, 0, typ, ref array[0], Strings.Len(num6));
					goto IL_0145;
					IL_0145:
					num = 24;
					if (num5 == 0)
					{
						goto IL_014e;
					}
					goto IL_016a;
					IL_014e:
					num = 27;
					num5 = RegCloseKey(phkResult);
					goto IL_015b;
					IL_015b:
					num = 28;
					flag = num5 == 0;
					goto end_IL_0000_3;
					IL_016a:
					num = 30;
					if (phkResult == 0)
					{
						break;
					}
					goto IL_0173;
					IL_0173:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_017b;
					IL_017b:
					num = 32;
					RegCloseKey(phkResult);
					break;
					end_IL_0000_2:
					break;
				}
				num = 34;
				flag = false;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 560;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		bool result = flag;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private static string hkeyPathFormat(ref string key, ref int hkey)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		string result = "";
		string mainstr = key;
		string oldstr = "/";
		string newstr = "\\";
		mainstr = StrReplace(ref oldstr, ref newstr, ref mainstr);
		while (Operators.CompareString(Strings.Left(mainstr, 1), "\\", false) == 0)
		{
			mainstr = Strings.Mid(mainstr, 2);
		}
		string[] strresult = new string[1];
		newstr = "\\";
		int num = StrDelim(ref newstr, ref mainstr, ref strresult);
		if (num < 0)
		{
			Interaction.MsgBox((object)(resManager.GetString("REG_HKEYERR") + mainstr), (MsgBoxStyle)0, (object)null);
		}
		else
		{
			string text = strresult[0];
			text = Strings.UCase(text);
			switch (text)
			{
			case "HKEY_CLASSES_ROOT":
				hkey = int.MinValue;
				goto default;
			case "HKEY_LOCAL_MACHINE":
				hkey = -2147483646;
				goto default;
			case "HKEY_CURRENT_USER":
				hkey = -2147483647;
				goto default;
			case "HKEY_CURRENT_CONFIG":
				hkey = -2147483643;
				goto default;
			case null:
			case "":
				Interaction.MsgBox((object)(resManager.GetString("REG_ERRMAIN") + text), (MsgBoxStyle)0, (object)null);
				hkey = 0;
				result = "";
				break;
			default:
			{
				mainstr = "";
				int num2 = Information.UBound((Array)strresult, 1);
				for (num = 1; num <= num2; num = checked(num + 1))
				{
					mainstr = mainstr + "\\" + strresult[num];
				}
				while ((Strings.Len(mainstr) >= 1) & (Operators.CompareString(Strings.Left(mainstr, 1), "\\", false) == 0))
				{
					mainstr = Strings.Mid(mainstr, 2);
				}
				result = mainstr;
				break;
			}
			}
		}
		return result;
	}

	public static string acadcurver()
	{
		string name = "CurVer";
		string text = "HKEY_CURRENT_USER\\SOFTWARE\\Autodesk\\AutoCAD\\";
		string keypath = text;
		object def = "";
		string text2 = Conversions.ToString(acet_RegistryRead(keypath, ref name, ref def));
		if (Strings.Len(text2) > 0)
		{
			name = Strings.Mid(text2, 2);
			if (Versioned.IsNumeric((object)name) && Conversions.ToDouble(name) < 15.0)
			{
				text = "HKEY_CURRENT_USER\\SOFTWARE\\Autodesk\\AutoCAD\\R16.0\\";
				name = "CurVer";
				string keypath2 = text;
				def = "";
				if (Operators.ConditionalCompareObjectNotEqual(acet_RegistryRead(keypath2, ref name, ref def), (object)"", false))
				{
					text2 = "R16.0";
				}
			}
		}
		return text2;
	}

	public static string acadcurvercookie()
	{
		string name = "CurVer";
		string text = acadcurver();
		if (Strings.Len(text) > 0)
		{
			text = "HKEY_CURRENT_USER\\SOFTWARE\\Autodesk\\AutoCAD\\" + text;
			string keypath = text;
			object def = "";
			text = Conversions.ToString(acet_RegistryRead(keypath, ref name, ref def));
		}
		return text;
	}

	public static string GetAcadExpressDirectory()
	{
		string text = GetAcadLocation();
		if (Operators.CompareString(text, "", false) != 0)
		{
			text = Strings.Left(text, checked(Strings.Len(text) - 8));
			text += "Express\\";
			text = BnsStr.FindFile(text);
		}
		return text;
	}

	public static string GetAcadLocation()
	{
		string text = "SOFTWARE\\Autodesk\\AutoCAD\\";
		string text2 = acadcurver();
		string text3 = acadcurvercookie();
		string name = "AcadLocation";
		string text4;
		if ((Operators.CompareString(text2, "", false) != 0) & (Operators.CompareString(text3, "", false) != 0))
		{
			text = "HKEY_CURRENT_USER\\" + text + text2 + "\\" + text3;
			string keypath = text;
			object def = "";
			text4 = Conversions.ToString(acet_RegistryRead(keypath, ref name, ref def));
			if (Operators.CompareString(text4, "", false) != 0)
			{
				text4 += "\\acad.exe";
			}
		}
		else
		{
			text4 = "";
		}
		return text4;
	}

	public static string GetCurrentAcadProfile()
	{
		string text = "SOFTWARE\\Autodesk\\AutoCAD\\";
		string text2 = acadcurver();
		string text3 = acadcurvercookie();
		string name = "";
		if ((Operators.CompareString(text2, "", false) != 0) & (Operators.CompareString(text3, "", false) != 0))
		{
			text = "HKEY_CURRENT_USER\\" + text + text2 + "\\" + text3 + "\\Profiles";
			string keypath = text;
			object def = "";
			return Conversions.ToString(acet_RegistryRead(keypath, ref name, ref def));
		}
		return "";
	}

	public static string AcadProductKey()
	{
		return "Software\\Autodesk\\AutoCAD\\" + acadcurver() + "\\" + acadcurvercookie();
	}

	public static string GetAcadPathFromProfile(ref string profile)
	{
		string text = "SOFTWARE\\Autodesk\\AutoCAD\\";
		string text2 = acadcurver();
		string text3 = acadcurvercookie();
		string name = "ACAD";
		if ((Operators.CompareString(text2, "", false) != 0) & (Operators.CompareString(text3, "", false) != 0))
		{
			text = "HKEY_CURRENT_USER\\" + text + text2 + "\\" + text3 + "\\Profiles\\" + profile + "\\General";
			string keypath = text;
			object def = "";
			return Conversions.ToString(acet_RegistryRead(keypath, ref name, ref def));
		}
		return "";
	}

	public static string AcadDefWindowPos()
	{
		string name = "Position";
		string text = acadcurver() + "";
		string text2 = acadcurvercookie() + "";
		string keypath = "HKEY_CURRENT_USER\\Software\\Autodesk\\AutoCAD\\" + text + "\\" + text2 + "\\FixedProfile\\Application Window\\";
		object def = "";
		string text3 = Conversions.ToString(acet_RegistryRead(keypath, ref name, ref def));
		return text3 + "";
	}

	public static string StrReplace(ref string oldstr, ref string newstr, ref string mainstr)
	{
		if (Operators.CompareString(oldstr, "", false) == 0)
		{
			return mainstr;
		}
		if (Strings.InStr(1, mainstr, oldstr, (CompareMethod)0) == 0)
		{
			return mainstr;
		}
		Strings.Len(newstr);
		int num = Strings.Len(oldstr);
		int num2 = Strings.Len(mainstr);
		string text = "";
		string text2 = "";
		int num3 = 1;
		checked
		{
			while (num3 <= Strings.Len(mainstr) - num + 1)
			{
				text = Strings.Mid(mainstr, num3, num);
				if (Operators.CompareString(text, oldstr, false) == 0)
				{
					text2 += newstr;
					num3 += num;
				}
				else
				{
					text2 += Strings.Mid(mainstr, num3, 1);
					num3++;
				}
			}
			return text2 + Strings.Mid(mainstr, num3, num2 - num3 + 1);
		}
	}

	public static int StrDelim(ref string delim, ref string strmain, ref string[] strresult)
	{
		checked
		{
			strresult = new string[Strings.Len(strmain) + 1 + 1];
			int num = Strings.Len(delim);
			int num2 = Strings.Len(strmain);
			int num3 = 1;
			int num4 = 0;
			for (int num5 = Strings.InStr(1, strmain, delim, (CompareMethod)0); num5 > 0; num5 = Strings.InStr(num3, strmain, delim, (CompareMethod)0))
			{
				strresult[num4] = Strings.Mid(strmain, num3, num5 - num3);
				num3 = num5 + num;
				num4++;
			}
			strresult[num4] = Strings.Mid(strmain, num3, num2 - num3 + 1);
			strresult = (string[])Utils.CopyArray((Array)strresult, (Array)new string[num4 + 1]);
			return num4;
		}
	}
}
