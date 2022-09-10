using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Autodesk.ExpressTools.AliasEdit.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace Autodesk.ExpressTools.AliasEdit;

[StandardModule]
internal sealed class BnsStr
{
	public struct CPINFO
	{
		public int MaxCharSize;

		[VBFixedArray(2)]
		public byte[] DefaultChar;

		[VBFixedArray(12)]
		public byte[] LeadByte;

		public void Initialize()
		{
			DefaultChar = new byte[3];
			LeadByte = new byte[13];
		}
	}

	public struct REMOTE_NAME_INFO
	{
		public int pUniversalName;

		public int pConnectionName;

		public int pRemainingPath;
	}

	public const short MAX_DEFAULTCHAR = 2;

	public const short MAX_LEADBYTES = 12;

	public const short REMOTE_NAME_INFO_LEVEL = 2;

	public const short UNIVERSAL_NAME_INFO_LEVEL = 1;

	private const short ERROR_BAD_DEVICE = 1200;

	private const short ERROR_CONNECTION_UNAVAIL = 1201;

	private const short ERROR_EXTENDED_ERROR = 1208;

	private const short ERROR_MORE_DATA = 234;

	private const short ERROR_NOT_SUPPORTED = 50;

	private const short ERROR_NO_NET_OR_BAD_PATH = 1203;

	private const short ERROR_NO_NETWORK = 1222;

	private const short ERROR_NOT_CONNECTED = 2250;

	private const short NO_ERROR = 0;

	private const short DRIVE_REMOTE = 4;

	private static string[] LocalShares;

	public static bool LocalShareInit;

	private static string[] RemoteDrives;

	public static bool RemoteDrivesInit;

	private const int SHARD_PATH = 2;

	private const short CSIDL_RECENT = 8;

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetFullPathNameA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName, int nBufferLength, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpBuffer, ref int lpFilePart);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetTempFileNameA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszPath, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpPrefixString, int wUnique, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpTempFileName);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int ExpandEnvironmentStringsA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpSrc, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpDst, int nSize);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetPrivateProfileSectionA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpAppName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int WritePrivateProfileSectionA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpAppName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetPrivateProfileStringA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpApplicationName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpKeyName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpDefault, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int WritePrivateProfileStringA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpApplicationName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpKeyName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetTickCount();

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetTempPathA(int nBufferLength, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpBuffer);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetDriveTypeA([MarshalAs(UnmanagedType.VBByRefStr)] ref string nDrive);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetLogicalDriveStringsA(int nBufferLength, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpBuffer);

	[DllImport("mpr.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int WNetGetConnectionA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszLocalName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszRemoteName, ref int cbRemoteName);

	[DllImport("mpr.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int WNetGetUniversalNameA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpLocalPath, int dwInfoLevel, ref object lpBuffer, ref int lpBufferSize);

	[DllImport("apigid32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void agCopyData(ref object Source, ref object dest, int nCount);

	[DllImport("apigid32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern string agGetStringFromLPSTR([MarshalAs(UnmanagedType.VBByRefStr)] ref string src);

	[DllImport("apigid32.dll", CharSet = CharSet.Ansi, EntryPoint = "agGetStringFromLPSTR", ExactSpelling = true, SetLastError = true)]
	public static extern string agGetStringFromLPSTR_1(int ptr);

	[DllImport("apigid32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int agGetAddressForObject(ref object object_Renamed);

	[DllImport("shell32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SHAddToRecentDocs(int flags, [MarshalAs(UnmanagedType.VBByRefStr)] ref string Data);

	[DllImport("shell32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SHGetSpecialFolderLocation(int hwndOwner, int nFolder, ref int pidl);

	[DllImport("shell32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SHGetPathFromIDListA(int pidl, [MarshalAs(UnmanagedType.VBByRefStr)] ref string pszPath);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetCommandLineA();

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetOEMCP();

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetCPInfo(int CodePage, ref CPINFO lpCPInfo);

	public static bool Is2ByteSystem()
	{
		CPINFO lpCPInfo = default(CPINFO);
		int oEMCP = GetOEMCP();
		GetCPInfo(oEMCP, ref lpCPInfo);
		if (lpCPInfo.MaxCharSize > 1)
		{
			return true;
		}
		bool result = default(bool);
		return result;
	}

	public static string WhatsMyName()
	{
		string[] str_Renamed = new string[1];
		string cmd = agGetStringFromLPSTR_1(GetCommandLineA());
		int num = Conversions.ToInteger(acetParseCmdLine(ref cmd, ref str_Renamed));
		if (num >= 0)
		{
			return str_Renamed[0];
		}
		return "";
	}

	public static bool IsDirectory(ref string fna)
	{
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Invalid comparison between Unknown and I4
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				string str_Renamed;
				string str_Renamed2;
				string stripit;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 239:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_0013;
						case 4:
							goto IL_0026;
						case 5:
							goto IL_003a;
						case 6:
							goto IL_004e;
						case 7:
							goto IL_0059;
						case 8:
							goto IL_006a;
						case 9:
							goto IL_007d;
						case 10:
							goto IL_0090;
						case 11:
						case 12:
						case 13:
						case 14:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 15:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0090:
					num = 10;
					flag = true;
					break;
					IL_0007:
					num = 2;
					fna = sStrip(fna);
					goto IL_0013;
					IL_0013:
					num = 3;
					if (Operators.CompareString(fna, "", false) == 0)
					{
						break;
					}
					goto IL_0026;
					IL_0026:
					num = 4;
					str_Renamed = fna;
					stripit = "\\.";
					fna = RightStrip(str_Renamed, ref stripit);
					goto IL_003a;
					IL_003a:
					num = 5;
					str_Renamed2 = fna;
					stripit = "\\";
					fna = RightStrip(str_Renamed2, ref stripit);
					goto IL_004e;
					IL_004e:
					num = 6;
					fna = bnsGetFullPathName(ref fna);
					goto IL_0059;
					IL_0059:
					num = 7;
					fna = FindFile(fna, ".");
					goto IL_006a;
					IL_006a:
					num = 8;
					if (Operators.CompareString(fna, "", false) == 0)
					{
						break;
					}
					goto IL_007d;
					IL_007d:
					num = 9;
					if ((FileSystem.GetAttr(fna) & 0x10) <= 0)
					{
						break;
					}
					goto IL_0090;
					end_IL_0000_2:
					break;
				}
				num = 14;
				flag2 = flag;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 239;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		bool result = flag2;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string strAddExt(string fna, ref string ext)
	{
		fna = sStrip(fna);
		if (Operators.CompareString(fna, "", false) != 0)
		{
			string str_Renamed = GetFileExt(ref fna);
			if (!strEqual(ref str_Renamed, ref ext))
			{
				fna += ext;
			}
		}
		return fna;
	}

	public static bool AddFileToRecentDocuments(ref string fna)
	{
		if (SHAddToRecentDocs(2, ref fna) != 0)
		{
			return true;
		}
		bool result = default(bool);
		return result;
	}

	public static bool IsSameFile(string fna, string fna2)
	{
		if ((Strings.Len(fna) > 0) & (Strings.Len(fna2) > 0))
		{
			fna = bnsGetFullPathName(ref fna);
			fna2 = bnsGetFullPathName(ref fna2);
			if (strEqual(ref fna, ref fna2))
			{
				return true;
			}
			if ((Strings.InStr(1, fna, "\\", (CompareMethod)0) != 0) & (Strings.InStr(1, fna2, "\\", (CompareMethod)0) != 0))
			{
				bool refresh = false;
				string str_Renamed = UncName(ref fna, ref refresh);
				bool refresh2 = false;
				string str = UncName(ref fna2, ref refresh2);
				if (strEqual(ref str_Renamed, ref str))
				{
					return true;
				}
			}
		}
		bool result = default(bool);
		return result;
	}

	public static string UncName(ref string lpLocalPath, ref bool refresh = false)
	{
		return lpLocalPath;
	}

	public static string UNCtoLocalName(ref string unc, ref bool refresh = false)
	{
		return unc;
	}

	public static int GetRemoteDrives(ref string[] rd)
	{
		int num = 0;
		int num2 = 110;
		string lpBuffer = Strings.Space(110);
		int logicalDriveStringsA = GetLogicalDriveStringsA(110, ref lpBuffer);
		string[] strresult = new string[1];
		checked
		{
			if (logicalDriveStringsA > 0)
			{
				lpBuffer = Strings.Left(lpBuffer, logicalDriveStringsA);
				string delim = "\0";
				logicalDriveStringsA = StrDelim(ref delim, ref lpBuffer, ref strresult);
				if (logicalDriveStringsA >= 0)
				{
					rd = new string[logicalDriveStringsA + 1];
					int num3 = logicalDriveStringsA;
					for (num2 = 0; num2 <= num3; num2++)
					{
						if (IsNetDrive(strresult[num2]))
						{
							string text = strAddBackSlash(strresult[num2]);
							ref string strDriveLetter = ref strresult[num2];
							delim = "";
							string text2 = Drive2UNC(ref strDriveLetter, ref delim);
							if (Operators.CompareString(text2, "", false) != 0)
							{
								text = Strings.UCase(text);
								text2 = Strings.UCase(text2);
								rd[num] = text;
								rd[num] = text2;
								num++;
							}
						}
					}
					if (num > 0)
					{
						rd = (string[])Utils.CopyArray((Array)rd, (Array)new string[num - 1 + 1]);
					}
				}
			}
			return num - 1;
		}
	}

	public static bool IsNetDrive(object str_Renamed)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		bool flag = default(bool);
		int driveTypeA = default(int);
		bool flag2 = default(bool);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				string nDrive;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 120:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_000d;
						case 4:
							goto IL_001d;
						case 5:
							goto IL_002f;
						case 6:
							goto IL_0036;
						case 7:
						case 8:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 9:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0036:
					num = 6;
					flag = true;
					break;
					IL_0008:
					num = 2;
					flag = false;
					goto IL_000d;
					IL_000d:
					num = 3;
					str_Renamed = strRemoveBackSlash(Conversions.ToString(str_Renamed));
					goto IL_001d;
					IL_001d:
					num = 4;
					nDrive = Conversions.ToString(str_Renamed);
					driveTypeA = GetDriveTypeA(ref nDrive);
					goto IL_002f;
					IL_002f:
					num = 5;
					if (driveTypeA != 4)
					{
						break;
					}
					goto IL_0036;
					end_IL_0000_2:
					break;
				}
				num = 8;
				flag2 = flag;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 120;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		bool result = flag2;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string Drive2UNC(ref string strDriveLetter, ref string msg = "")
	{
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string lpszLocalName = default(string);
		string lpszRemoteName = default(string);
		int cbRemoteName = default(int);
		int num5 = default(int);
		int num6 = default(int);
		string text = default(string);
		string str_Renamed = default(string);
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
				case 702:
					{
						num2 = num;
						switch (num3)
						{
						case 2:
							break;
						case 1:
							goto IL_01f0;
						default:
							goto end_IL_0000;
						}
						goto IL_01aa;
					}
					IL_01f0:
					num4 = num2 + 1;
					num2 = 0;
					switch (num4)
					{
					case 1:
						break;
					case 2:
						goto IL_0008;
					case 3:
						goto IL_0013;
					case 4:
						goto IL_0024;
					case 5:
						goto IL_002f;
					case 6:
						goto IL_003e;
					case 8:
					case 9:
						goto IL_0044;
					case 10:
						goto IL_0051;
					case 12:
						goto IL_0068;
					case 13:
						goto IL_0075;
					case 15:
						goto IL_008c;
					case 16:
						goto IL_0099;
					case 18:
						goto IL_00b0;
					case 19:
						goto IL_00bd;
					case 21:
						goto IL_00d4;
					case 22:
						goto IL_00de;
					case 24:
						goto IL_00f2;
					case 25:
						goto IL_00ff;
					case 27:
						goto IL_0113;
					case 28:
						goto IL_0120;
					case 30:
						goto IL_0134;
					case 31:
						goto IL_0141;
					case 33:
						goto IL_0155;
					case 7:
					case 11:
					case 14:
					case 17:
					case 20:
					case 23:
					case 26:
					case 29:
					case 32:
					case 34:
					case 35:
						goto IL_015e;
					case 36:
						goto IL_016e;
					case 38:
						goto IL_017a;
					case 39:
						goto IL_017e;
					case 40:
						goto IL_018c;
					case 41:
						goto IL_0199;
					case 44:
						goto IL_01aa;
					case 45:
						goto end_IL_0000_2;
					default:
						goto end_IL_0000;
					case 37:
					case 42:
					case 43:
					case 46:
					case 47:
						goto end_IL_0000_3;
					}
					goto default;
					IL_01aa:
					num = 44;
					Interaction.MsgBox((object)("error trap: " + Information.Err().get_Description()), (MsgBoxStyle)64, (object)null);
					break;
					IL_0008:
					num = 2;
					lpszLocalName = strRemoveBackSlash(strDriveLetter);
					goto IL_0013;
					IL_0013:
					num = 3;
					lpszRemoteName = new string(' ', 255);
					goto IL_0024;
					IL_0024:
					num = 4;
					cbRemoteName = Strings.Len(lpszRemoteName);
					goto IL_002f;
					IL_002f:
					num = 5;
					num5 = WNetGetConnectionA(ref lpszLocalName, ref lpszRemoteName, ref cbRemoteName);
					goto IL_003e;
					IL_003e:
					num = 6;
					num6 = num5;
					goto IL_0044;
					IL_0044:
					num = 9;
					if (num6 == 1200)
					{
						goto IL_0051;
					}
					goto IL_0068;
					IL_0051:
					num = 10;
					msg += "Error: Bad Device";
					goto IL_015e;
					IL_0068:
					num = 12;
					if (num6 == 1201)
					{
						goto IL_0075;
					}
					goto IL_008c;
					IL_0075:
					num = 13;
					msg += "Error: Connection Un-Available";
					goto IL_015e;
					IL_008c:
					num = 15;
					if (num6 == 1208)
					{
						goto IL_0099;
					}
					goto IL_00b0;
					IL_0099:
					num = 16;
					msg += "Error: Extended Error";
					goto IL_015e;
					IL_00b0:
					num = 18;
					if (num6 == 234)
					{
						goto IL_00bd;
					}
					goto IL_00d4;
					IL_00bd:
					num = 19;
					msg += "Error: More Data";
					goto IL_015e;
					IL_00d4:
					num = 21;
					if (num6 == 50)
					{
						goto IL_00de;
					}
					goto IL_00f2;
					IL_00de:
					num = 22;
					msg += "Error: Feature not Supported";
					goto IL_015e;
					IL_00f2:
					num = 24;
					if (num6 == 1203)
					{
						goto IL_00ff;
					}
					goto IL_0113;
					IL_00ff:
					num = 25;
					msg += "Error: No Network Available or Bad Path";
					goto IL_015e;
					IL_0113:
					num = 27;
					if (num6 == 1222)
					{
						goto IL_0120;
					}
					goto IL_0134;
					IL_0120:
					num = 28;
					msg += "Error: No Network Available";
					goto IL_015e;
					IL_0134:
					num = 30;
					if (num6 == 2250)
					{
						goto IL_0141;
					}
					goto IL_0155;
					IL_0141:
					num = 31;
					msg += "Error: Not Connected";
					goto IL_015e;
					IL_0155:
					num = 33;
					if (num6 != 0)
					{
					}
					goto IL_015e;
					IL_015e:
					num = 35;
					if (Strings.Len(msg) != 0)
					{
						goto IL_016e;
					}
					goto IL_017a;
					IL_016e:
					num = 36;
					text = "";
					goto end_IL_0000_3;
					IL_017a:
					num = 38;
					goto IL_017e;
					IL_017e:
					num = 39;
					str_Renamed = Strings.Left(lpszRemoteName, cbRemoteName);
					goto IL_018c;
					IL_018c:
					num = 40;
					str_Renamed = StripNullString(ref str_Renamed);
					goto IL_0199;
					IL_0199:
					num = 41;
					text = strAddBackSlash(str_Renamed);
					goto end_IL_0000_3;
					end_IL_0000_2:
					break;
				}
				num = 45;
				ProjectData.ClearProjectError();
				if (num2 == 0)
				{
					throw ProjectData.CreateProjectError(-2146828268);
				}
				num2 = 0;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 702;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		string result = text;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool FileDelete(string fna)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 210:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_000c;
						case 4:
							goto IL_001c;
						case 5:
							goto IL_002e;
						case 6:
							goto IL_005b;
						case 7:
							goto IL_0064;
						case 8:
							goto IL_0080;
						case 9:
						case 10:
						case 11:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 12:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0080:
					num = 8;
					flag = true;
					break;
					IL_0007:
					num = 2;
					flag = false;
					goto IL_000c;
					IL_000c:
					num = 3;
					fna = FindFile(fna, ".");
					goto IL_001c;
					IL_001c:
					num = 4;
					if (Operators.CompareString(fna, "", false) == 0)
					{
						break;
					}
					goto IL_002e;
					IL_002e:
					num = 5;
					AttrMinus(fna, (object)(FileAttribute)1, (object)(FileAttribute)2, (object)(FileAttribute)4);
					goto IL_005b;
					IL_005b:
					num = 6;
					FileSystem.Kill(fna);
					goto IL_0064;
					IL_0064:
					num = 7;
					if (Operators.CompareString(FindFile(fna, "."), "", false) != 0)
					{
						break;
					}
					goto IL_0080;
					end_IL_0000_2:
					break;
				}
				num = 11;
				flag2 = flag;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 210;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		bool result = flag2;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool AttrPlus(string fna, params object[] att)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected I4, but got Unknown
		int try0000_dispatch = -1;
		int num2 = default(int);
		bool flag;
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					bool flag2 = false;
					int num3 = Information.UBound((Array)att, 1);
					fna = FindFile(fna, ".");
					if ((num3 >= 0) & (Operators.CompareString(fna, "", false) != 0))
					{
						int num4 = (int)FileSystem.GetAttr(fna);
						int num5 = num4;
						int num6 = num3;
						checked
						{
							for (int i = 0; i <= num6; i++)
							{
								int num7 = Conversions.ToInteger(att[i]);
								if ((~num4 & num7) != 0)
								{
									num4 += num7;
								}
							}
							if (num5 != num4)
							{
								FileSystem.SetAttr(fna, (FileAttribute)num4);
								flag2 = true;
							}
						}
					}
					flag = flag2;
					goto end_IL_0000;
				}
				case 145:
					num = -1;
					switch (num2)
					{
					case 2:
						Information.Err().Clear();
						flag = false;
						goto end_IL_0000;
					}
					break;
				}
				goto IL_00cb;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 145;
				continue;
			}
			break;
			IL_00cb:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool AttrMinus(string fna, params object[] att)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected I4, but got Unknown
		int try0000_dispatch = -1;
		int num2 = default(int);
		bool flag;
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					bool flag2 = false;
					int num3 = Information.UBound((Array)att, 1);
					fna = FindFile(fna, ".");
					if ((num3 >= 0) & (Operators.CompareString(fna, "", false) != 0))
					{
						int num4 = (int)FileSystem.GetAttr(fna);
						int num5 = num4;
						int num6 = num3;
						checked
						{
							for (int i = 0; i <= num6; i++)
							{
								int num7 = Conversions.ToInteger(att[i]);
								if ((num4 & num7) != 0)
								{
									num4 -= num7;
								}
							}
							if (num5 != num4)
							{
								FileSystem.SetAttr(fna, (FileAttribute)num4);
								flag2 = true;
							}
						}
					}
					flag = flag2;
					goto end_IL_0000;
				}
				case 144:
					num = -1;
					switch (num2)
					{
					case 2:
						Information.Err().Clear();
						flag = false;
						goto end_IL_0000;
					}
					break;
				}
				goto IL_00ca;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 144;
				continue;
			}
			break;
			IL_00ca:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static object strNL()
	{
		return "\r\n";
	}

	public static string strAddBackSlash(string str_Renamed)
	{
		if (Operators.CompareString(str_Renamed, "", false) != 0 && Operators.CompareString(Strings.Right(str_Renamed, 1), "\\", false) != 0)
		{
			str_Renamed += "\\";
		}
		return str_Renamed;
	}

	public static string strRemoveBackSlash(string str_Renamed)
	{
		if (Operators.CompareString(str_Renamed, "", false) != 0 && Operators.CompareString(Strings.Right(str_Renamed, 1), "\\", false) == 0)
		{
			str_Renamed = Strings.Left(str_Renamed, checked(Strings.Len(str_Renamed) - 1));
		}
		return str_Renamed;
	}

	public static string GenerateTempFileName(ref string path = "", ref string prefix = "", ref string ext = ".tmp")
	{
		if (Operators.CompareString(path, "", false) != 0)
		{
			path = FindFile(path, ".");
			path = strAddBackSlash(path);
		}
		if (Operators.CompareString(path, "", false) == 0)
		{
			path = WinTempDir();
		}
		if (Operators.CompareString(ext, "", false) == 0)
		{
			ext = ".tmp";
		}
		if (Operators.CompareString(Strings.Left(ext, 1), ".", false) != 0)
		{
			ext = "." + ext;
		}
		int num = 0;
		string text3;
		string text;
		do
		{
			checked
			{
				int num2 = GetTickCount() + num;
				num++;
				text = Strings.Right(Conversions.ToString(num2), 2);
				int num3 = Conversions.ToInteger(Strings.Right(Conversions.ToString(num2), 2));
				while (unchecked(num3 < 65 || num3 > 90))
				{
					num3 = ((num3 >= 65) ? ((int)Math.Round((double)num3 * 0.75)) : ((int)Math.Round((double)num3 * 2.0 + 1.0)));
				}
				string text2 = Conversions.ToString(Strings.Chr(num3));
				num2 = (int)Math.Round((double)num2 / 3.0);
				num3 = Conversions.ToInteger(Strings.Right(Conversions.ToString(num2), 2));
				text2 += Conversion.Hex(num3);
				text3 = path + prefix + text2 + text + ext;
				text = FindFile(text3, ".");
			}
		}
		while (!(Operators.CompareString(text, "", false) == 0 || num > 100));
		return text3;
	}

	public static string WinTempDir()
	{
		int num = 256;
		string lpBuffer = Strings.Space(256);
		num = GetTempPathA(256, ref lpBuffer);
		if (num > 0)
		{
			lpBuffer = Strings.Left(lpBuffer, num);
			return strAddBackSlash(lpBuffer);
		}
		return "";
	}

	public static int DirArray(ref string spec, ref string[] str_Renamed, ref int attr = 0)
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		int num3;
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0000_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						string filePath = GetFilePath(ref spec);
						int num4 = 100;
						str_Renamed = new string[101];
						string text = FileSystem.Dir(spec, (FileAttribute)attr);
						int num5 = 0;
						str_Renamed = (string[])Utils.CopyArray((Array)str_Renamed, (Array)new string[101]);
						while (Operators.CompareString(text, "", false) != 0)
						{
							if (num5 > num4)
							{
								num4 += 100;
							}
							str_Renamed[num5] = filePath + text;
							text = FileSystem.Dir();
							num5++;
						}
						str_Renamed = new string[1];
						str_Renamed = (string[])Utils.CopyArray((Array)str_Renamed, (Array)new string[num5 - 1 + 1]);
						if (num5 > 0)
						{
						}
						num3 = num5 - 1;
						goto end_IL_0000;
					}
					case 167:
						num = -1;
						switch (num2)
						{
						case 2:
							num3 = -1;
							goto end_IL_0000;
						}
						break;
					}
					goto IL_00e1;
				}
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 167;
				continue;
			}
			break;
			IL_00e1:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		int result = num3;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string StrDoubleQuote(string str_Renamed)
	{
		if (Strings.Len(str_Renamed) > 0)
		{
			if (Operators.CompareString(Strings.Left(str_Renamed, 1), "\"", false) != 0)
			{
				str_Renamed = "\"" + str_Renamed;
			}
			if (Operators.CompareString(Strings.Right(str_Renamed, 1), "\"", false) != 0)
			{
				str_Renamed += "\"";
			}
		}
		return str_Renamed;
	}

	public static bool strEqual(ref string str_Renamed, ref string str2)
	{
		if (Operators.CompareString(Strings.UCase(str_Renamed), Strings.UCase(str2), false) == 0)
		{
			return true;
		}
		return false;
	}

	public static string strToTabDelim(ref string[] str_Renamed)
	{
		string text = str_Renamed[0];
		int num = Information.UBound((Array)str_Renamed, 1);
		for (int i = 1; i <= num; i = checked(i + 1))
		{
			text = text + "\t" + str_Renamed[i];
		}
		return text;
	}

	public static int bnsDelay(ref int ticks)
	{
		int tickCount = GetTickCount();
		while (checked(GetTickCount() - tickCount) < ticks)
		{
			Application.DoEvents();
		}
		return ticks;
	}

	public static string StripNullString(ref string str_Renamed)
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

	public static int Acet_get_ini_Sect(ref string fna, ref string sect, ref string[] sectdata)
	{
		int num = 2500;
		Strings.Space(2500);
		string lpReturnedString = Strings.Space(2500);
		int num2 = 50;
		sectdata = new string[51];
		int num3 = GetPrivateProfileSectionA(ref sect, ref lpReturnedString, 2500, ref fna);
		checked
		{
			if (num3 > 0)
			{
				lpReturnedString = Strings.Left(lpReturnedString, num3);
				num3 = 0;
				num = 1;
				string text = "";
				int num4 = Strings.Len(lpReturnedString);
				for (num = 1; num <= num4; num++)
				{
					string text2 = Strings.Mid(lpReturnedString, num, 1);
					if (Operators.CompareString(text2, "\0", false) == 0)
					{
						if (num3 > num2)
						{
							num2 += 50;
							sectdata = (string[])Utils.CopyArray((Array)sectdata, (Array)new string[num2 + 1]);
						}
						if (Operators.CompareString(text, "", false) != 0)
						{
							sectdata[num3] = text;
						}
						text = "";
						num3++;
					}
					else
					{
						text += text2;
					}
				}
			}
			if (num3 > 0)
			{
				num3--;
				sectdata = (string[])Utils.CopyArray((Array)sectdata, (Array)new string[num3 + 1]);
			}
			else
			{
				num3 = -1;
			}
			return num3;
		}
	}

	public static bool Acet_put_ini_sect(ref string fna, ref string sect, ref string[] sectdata)
	{
		string text = "";
		int num = Information.UBound((Array)sectdata, 1);
		for (int i = 0; i <= num; i = checked(i + 1))
		{
			text = ((Operators.CompareString(text, "", false) == 0) ? sectdata[i] : (text + "\0" + sectdata[i]));
		}
		text += "\0\0";
		if (WritePrivateProfileSectionA(ref sect, ref text, ref fna) != 0)
		{
			return true;
		}
		return false;
	}

	public static string FindFile(string fna, string path = "")
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		string text = default(string);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					fna = sStrip(fna);
					string str_Renamed = fna;
					string stripit = "\"";
					fna = RightStrip(str_Renamed, ref stripit);
					string str_Renamed2 = fna;
					stripit = "\"";
					fna = LeftStrip(str_Renamed2, ref stripit);
					text = "";
					if (Operators.CompareString(fna, "", false) == 0)
					{
						break;
					}
					bool refresh = false;
					fna = UNCtoLocalName(ref fna, ref refresh);
					string text2 = FileSystem.Dir(fna, (FileAttribute)55);
					string[] strresult = new string[1];
					if (Strings.Len(text2) == 0)
					{
						string filePath = GetFilePath(ref fna);
						if (Operators.CompareString(filePath, "", false) == 0)
						{
							if (Information.IsNothing((object)path) | (Operators.CompareString(path, "", false) == 0))
							{
								path = Interaction.Environ("PATH");
								path = FileSystem.CurDir() + ";" + path;
							}
							stripit = "\"";
							string newstr = "";
							path = StrReplace(ref stripit, ref newstr, ref path);
							path = bnsExpandEnvironmentStrings(ref path);
							newstr = ";";
							int num3 = StrDelim(ref newstr, ref path, ref strresult);
							for (int i = 0; i <= num3; i = checked(i + 1))
							{
								if ((Operators.CompareString(Strings.Right(strresult[i], 1), "\\", false) != 0) & (Operators.CompareString(Strings.Right(strresult[i], 1), "/", false) != 0))
								{
									strresult[i] += "\\";
								}
								DirectoryInfo directoryInfo = ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectoryInfo(strresult[i]);
								FileInfo[] files = directoryInfo.GetFiles();
								FileInfo[] array = files;
								foreach (FileInfo fileInfo in array)
								{
									if (Operators.CompareString(fileInfo.get_Name(), fna, false) == 0)
									{
										text2 = fileInfo.FullName;
										i = num3;
										break;
									}
								}
							}
						}
					}
					else
					{
						text2 = bnsGetFullPathName(ref fna);
					}
					text = text2;
					break;
				}
				case 464:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto IL_020a;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 464;
				continue;
			}
			break;
			IL_020a:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		string result = text;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool Filename_Valid(ref string fna, ref bool validateDir = true)
	{
		if ((Operators.CompareString(fna, "", false) == 0) | (Strings.InStr(1, fna, "*", (CompareMethod)1) != 0) | (Strings.InStr(1, fna, "?", (CompareMethod)1) != 0) | (Strings.InStr(1, fna, "<", (CompareMethod)1) != 0) | (Strings.InStr(1, fna, "<", (CompareMethod)1) != 0) | (Strings.InStr(1, fna, "|", (CompareMethod)1) != 0))
		{
			return false;
		}
		if (validateDir)
		{
			string text = GetFilePath(ref fna);
			if (Operators.CompareString(text, "", false) == 0)
			{
				text = ".\\";
			}
			text = FindFile(text);
			if (Operators.CompareString(text, "", false) == 0)
			{
				return false;
			}
			return true;
		}
		return true;
	}

	public static string bnsGetFullPathName(ref string fna)
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		int lpFilePart = default(int);
		string text = default(string);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					string lpBuffer = Strings.Space(255);
					int fullPathNameA = GetFullPathNameA(ref fna, 255, ref lpBuffer, ref lpFilePart);
					lpBuffer = Strings.Left(lpBuffer, fullPathNameA);
					text = lpBuffer;
					break;
				}
				case 47:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto IL_0069;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 47;
				continue;
			}
			break;
			IL_0069:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		string result = text;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string GetFilePath(ref string fna)
	{
		int num = Strings.Len(fna);
		int num2 = 0;
		for (int i = 1; i <= num; i = checked(i + 1))
		{
			string text = Strings.Mid(fna, i, 1);
			if ((Operators.CompareString(text, "\\", false) == 0) | (Operators.CompareString(text, "/", false) == 0) | (Operators.CompareString(text, ":", false) == 0))
			{
				num2 = i;
			}
		}
		return Strings.Left(fna, num2);
	}

	public static string GetFileBaseName(ref string fna)
	{
		string result = "";
		int num = Strings.Len(GetFilePath(ref fna));
		int num2 = Strings.Len(GetFileExt(ref fna));
		checked
		{
			num2 = Strings.Len(fna) - num - num2;
			num++;
		}
		if (num2 >= 0 && num >= 0)
		{
			result = Strings.Mid(fna, num, num2);
		}
		return result;
	}

	public static string GetFileExt(ref string fna)
	{
		string result = "";
		if (Strings.Len(fna) > 1)
		{
			int i = 0;
			for (int num = Strings.Len(fna); num > 0 && i < 4; i = checked(i + 1))
			{
				if (Operators.CompareString(Strings.Mid(fna, num, 1), ".", false) == 0)
				{
					result = Strings.Mid(fna, num);
					num = -1;
				}
				else if ((Operators.CompareString(Strings.Mid(fna, num, 1), "\\", false) == 0) | (Operators.CompareString(Strings.Mid(fna, num, 1), "/", false) == 0))
				{
					num = -1;
				}
				num = checked(num - 1);
			}
		}
		return result;
	}

	public static string bnsExpandEnvironmentStrings(ref string str_Renamed)
	{
		string lpDst = Strings.Space(255);
		int nSize = 255;
		if (Strings.InStr(1, str_Renamed, "%", (CompareMethod)0) >= 1)
		{
			int num = ExpandEnvironmentStringsA(ref str_Renamed, ref lpDst, nSize);
			return Strings.Left(lpDst, num);
		}
		return str_Renamed;
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

	public static int GetCommandLine(ref string[] argarray, ref object MaxArgs = 20)
	{
		string cmd = Interaction.Command();
		return Conversions.ToInteger(acetParseCmdLine(ref cmd, ref argarray));
	}

	public static object acetParseCmdLine(ref string cmd, ref string[] str_Renamed)
	{
		str_Renamed = new string[1];
		int num = Strings.Len(cmd);
		int num2 = -1;
		str_Renamed = (string[])Utils.CopyArray((Array)str_Renamed, (Array)new string[0]);
		int num3 = num;
		checked
		{
			int num4 = default(int);
			bool flag = default(bool);
			for (int i = 1; i <= num3; i++)
			{
				string text = Strings.Mid(cmd, i, 1);
				if (Operators.CompareString(text, "\"", false) == 0)
				{
					num4++;
				}
				if (((double)num4 == Conversion.Fix((double)num4 / 2.0) * 2.0) & ((Operators.CompareString(text, " ", false) == 0) | (Operators.CompareString(text, "\t", false) == 0)))
				{
					flag = false;
					continue;
				}
				if (!flag)
				{
					num2++;
					if (Information.UBound((Array)str_Renamed, 1) < num2)
					{
					}
				}
				flag = true;
				if (Operators.CompareString(text, "\"", false) != 0)
				{
					str_Renamed[num2] += text;
				}
			}
			str_Renamed = new string[1];
			str_Renamed = (string[])Utils.CopyArray((Array)str_Renamed, (Array)new string[num2 + 1]);
			if (num2 >= 0)
			{
			}
			return num2;
		}
	}

	public static string LeftStrip(string str_Renamed, ref string stripit = " ")
	{
		int num = Strings.Len(str_Renamed);
		int num2 = Strings.Len(stripit);
		checked
		{
			while ((num >= num2) & (Operators.CompareString(Strings.Left(str_Renamed, num2), stripit, false) == 0))
			{
				num -= num2;
				str_Renamed = Strings.Mid(str_Renamed, num2 + 1, num);
			}
			return str_Renamed;
		}
	}

	public static string RightStrip(string str_Renamed, ref string stripit = " ")
	{
		int num = Strings.Len(str_Renamed);
		int num2 = Strings.Len(stripit);
		while ((num >= num2) & (Operators.CompareString(Strings.Right(str_Renamed, num2), stripit, false) == 0))
		{
			num = checked(num - num2);
			str_Renamed = Strings.Left(str_Renamed, num);
		}
		return str_Renamed;
	}

	public static string sStrip(string str_Renamed)
	{
		string oldstr = "\t";
		string newstr = " ";
		str_Renamed = StrReplace(ref oldstr, ref newstr, ref str_Renamed);
		string str_Renamed2 = str_Renamed;
		newstr = " ";
		str_Renamed = RightStrip(str_Renamed2, ref newstr);
		string str_Renamed3 = str_Renamed;
		newstr = " ";
		str_Renamed = LeftStrip(str_Renamed3, ref newstr);
		return str_Renamed;
	}

	public static int ReadTxtFile(ref string fna, ref string[] txt, ref int maxwait = 0)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		int num8 = default(int);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					bool validateDir;
					string ac;
					string fLock;
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0008;
					case 477:
						{
							num2 = num;
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0008;
							case 3:
								goto IL_0018;
							case 5:
							case 6:
								goto IL_0022;
							case 7:
								goto IL_003f;
							case 8:
								goto IL_0046;
							case 10:
							case 11:
								goto IL_0050;
							case 12:
								goto IL_005c;
							case 13:
								goto IL_0078;
							case 14:
							case 16:
								goto IL_0086;
							case 19:
								goto IL_008e;
							case 20:
								goto IL_009a;
							case 21:
								goto IL_00a2;
							case 22:
								goto IL_00b0;
							case 23:
							case 25:
							case 26:
								goto IL_00cf;
							case 27:
								goto IL_00d9;
							case 17:
							case 18:
							case 28:
								goto IL_00e1;
							case 29:
								goto IL_00ed;
							case 30:
								goto IL_0105;
							case 31:
								goto IL_010d;
							case 32:
							case 34:
							case 35:
								goto end_IL_0000_2;
							default:
								goto end_IL_0000;
							case 4:
							case 9:
							case 36:
								goto end_IL_0000_3;
							}
							goto default;
						}
						IL_00d9:
						num = 27;
						num5++;
						goto IL_00e1;
						IL_0008:
						num = 2;
						validateDir = true;
						if (!Filename_Valid(ref fna, ref validateDir))
						{
							goto IL_0018;
						}
						goto IL_0022;
						IL_0018:
						num = 3;
						num6 = -1;
						goto end_IL_0000_3;
						IL_0022:
						num = 6;
						ac = "r";
						fLock = "";
						num7 = acetOpen(ref fna, ref ac, ref fLock, ref maxwait);
						goto IL_003f;
						IL_003f:
						num = 7;
						if (num7 == 0)
						{
							goto IL_0046;
						}
						goto IL_0050;
						IL_0046:
						num = 8;
						num6 = -1;
						goto end_IL_0000_3;
						IL_0050:
						num = 11;
						num8 = (int)FileSystem.LOF(num7);
						goto IL_005c;
						IL_005c:
						num = 12;
						num8 = (int)Math.Round(Conversion.Fix((double)num8 / 80.0));
						goto IL_0078;
						IL_0078:
						num = 13;
						txt = new string[num8 + 1];
						goto IL_0086;
						IL_0086:
						num = 16;
						num5 = 0;
						goto IL_00e1;
						IL_00e1:
						num = 18;
						if (!FileSystem.EOF(num7))
						{
							goto IL_008e;
						}
						goto IL_00ed;
						IL_00ed:
						num = 29;
						FileSystem.FileClose(new int[1] { num7 });
						goto IL_0105;
						IL_0105:
						num = 30;
						if (num5 <= 0)
						{
							break;
						}
						goto IL_010d;
						IL_010d:
						num = 31;
						txt = (string[])Utils.CopyArray((Array)txt, (Array)new string[num5 - 1 + 1]);
						break;
						IL_008e:
						num = 19;
						text = FileSystem.LineInput(num7);
						goto IL_009a;
						IL_009a:
						num = 20;
						if (num5 > num8)
						{
							goto IL_00a2;
						}
						goto IL_00cf;
						IL_00a2:
						num = 21;
						num8 = Conversion.Fix(num8 + 80);
						goto IL_00b0;
						IL_00b0:
						num = 22;
						txt = (string[])Utils.CopyArray((Array)txt, (Array)new string[num8 + 1]);
						goto IL_00cf;
						IL_00cf:
						num = 26;
						txt[num5] = text;
						goto IL_00d9;
						end_IL_0000_2:
						break;
					}
					num = 35;
					num6 = num5 - 1;
					break;
				}
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 477;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		int result = num6;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static int WriteTxtFile(ref string fna, ref string[] txt, ref int maxwait = 0)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		int num8 = default(int);
		int num9 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				bool validateDir;
				string ac;
				string fLock;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 271:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0018;
						case 5:
						case 6:
							goto IL_0023;
						case 7:
							goto IL_002f;
						case 8:
							goto IL_004c;
						case 9:
							goto IL_0053;
						case 11:
						case 12:
							goto IL_005f;
						case 13:
							goto IL_006a;
						case 14:
							goto IL_0086;
						case 15:
							goto IL_0093;
						case 16:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 4:
						case 10:
						case 17:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0086:
					num = 14;
					num5 = checked(num5 + 1);
					goto IL_008e;
					IL_0008:
					num = 2;
					validateDir = true;
					if (!Filename_Valid(ref fna, ref validateDir))
					{
						goto IL_0018;
					}
					goto IL_0023;
					IL_0018:
					num = 3;
					num6 = -1;
					goto end_IL_0000_3;
					IL_0023:
					num = 6;
					num7 = Information.UBound((Array)txt, 1);
					goto IL_002f;
					IL_002f:
					num = 7;
					ac = "w";
					fLock = "";
					num8 = acetOpen(ref fna, ref ac, ref fLock, ref maxwait);
					goto IL_004c;
					IL_004c:
					num = 8;
					if (num8 == 0)
					{
						goto IL_0053;
					}
					goto IL_005f;
					IL_0053:
					num = 9;
					num6 = -1;
					goto end_IL_0000_3;
					IL_005f:
					num = 12;
					num9 = num7;
					num5 = 0;
					goto IL_008e;
					IL_008e:
					if (num5 <= num9)
					{
						goto IL_006a;
					}
					goto IL_0093;
					IL_0093:
					num = 15;
					FileSystem.FileClose(new int[1] { num8 });
					break;
					IL_006a:
					num = 13;
					FileSystem.PrintLine(num8, new object[1] { txt[num5] });
					goto IL_0086;
					end_IL_0000_2:
					break;
				}
				num = 16;
				num6 = checked(num5 - 1);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 271;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		int result = num6;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static int AppendTxtFile(ref string fna, ref string[] txt, ref int maxwait = 0)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		int num8 = default(int);
		int num9 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				bool validateDir;
				string ac;
				string fLock;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 274:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0018;
						case 5:
						case 6:
							goto IL_0022;
						case 7:
							goto IL_002e;
						case 8:
							goto IL_004b;
						case 9:
							goto IL_0052;
						case 11:
						case 12:
							goto IL_005d;
						case 13:
							goto IL_0069;
						case 14:
							goto IL_0086;
						case 15:
							goto IL_0096;
						case 16:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 4:
						case 10:
						case 17:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0086:
					num = 14;
					num5 = checked(num5 + 1);
					goto IL_0090;
					IL_0008:
					num = 2;
					validateDir = true;
					if (!Filename_Valid(ref fna, ref validateDir))
					{
						goto IL_0018;
					}
					goto IL_0022;
					IL_0018:
					num = 3;
					num6 = -1;
					goto end_IL_0000_3;
					IL_0022:
					num = 6;
					num7 = Information.UBound((Array)txt, 1);
					goto IL_002e;
					IL_002e:
					num = 7;
					ac = "a";
					fLock = "";
					num8 = acetOpen(ref fna, ref ac, ref fLock, ref maxwait);
					goto IL_004b;
					IL_004b:
					num = 8;
					if (num8 == 0)
					{
						goto IL_0052;
					}
					goto IL_005d;
					IL_0052:
					num = 9;
					num6 = -1;
					goto end_IL_0000_3;
					IL_005d:
					num = 12;
					num9 = num7;
					num5 = 0;
					goto IL_0090;
					IL_0090:
					if (num5 <= num9)
					{
						goto IL_0069;
					}
					goto IL_0096;
					IL_0096:
					num = 15;
					FileSystem.FileClose(new int[1] { num8 });
					break;
					IL_0069:
					num = 13;
					FileSystem.PrintLine(num8, new object[1] { txt[num5] });
					goto IL_0086;
					end_IL_0000_2:
					break;
				}
				num = 16;
				num6 = checked(num5 - 1);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 274;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		int result = num6;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static int acetOpen(ref string fna, ref string ac, ref string fLock = "", ref int maxwait = 0)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int number = default(int);
		int num5 = default(int);
		int ticks = default(int);
		int num6 = default(int);
		bool flag = default(bool);
		int num7 = default(int);
		string text = default(string);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
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
				case 1584:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						case 2:
							goto IL_05f6;
						default:
							goto end_IL_0000;
						}
						goto IL_03c5;
					}
					IL_03c5:
					num4 = num2 + 1;
					num2 = 0;
					switch (num4)
					{
					case 1:
						break;
					case 2:
						goto IL_0008;
					case 3:
						goto IL_0012;
					case 4:
						goto IL_001e;
					case 5:
						goto IL_0028;
					case 6:
						goto IL_002e;
					case 9:
						goto IL_0039;
					case 11:
					case 12:
						goto IL_0046;
					case 13:
						goto IL_005d;
					case 14:
						goto IL_007e;
					case 16:
					case 17:
						goto IL_0086;
					case 18:
						goto IL_009a;
					case 20:
						goto IL_00b0;
					case 21:
						goto IL_00c4;
					case 23:
						goto IL_00d7;
					case 24:
						goto IL_00eb;
					case 26:
						goto IL_00fe;
					case 27:
						goto IL_0112;
					case 29:
						goto IL_0125;
					case 30:
						goto IL_0139;
					case 15:
					case 19:
					case 22:
					case 25:
					case 28:
					case 31:
					case 32:
						goto IL_014a;
					case 34:
						goto IL_015a;
					case 35:
						goto IL_015e;
					case 36:
						goto IL_0165;
					case 39:
						goto IL_0171;
					case 40:
						goto IL_0188;
					case 41:
						goto IL_01a8;
					case 43:
					case 44:
						goto IL_01b0;
					case 45:
						goto IL_01c4;
					case 47:
						goto IL_01da;
					case 48:
						goto IL_01ee;
					case 50:
						goto IL_0201;
					case 51:
						goto IL_0215;
					case 53:
						goto IL_0228;
					case 54:
						goto IL_023c;
					case 56:
						goto IL_024f;
					case 57:
						goto IL_0263;
					case 42:
					case 46:
					case 49:
					case 52:
					case 55:
					case 58:
					case 59:
						goto IL_0274;
					case 61:
						goto IL_0284;
					case 62:
						goto IL_029b;
					case 63:
						goto IL_02bb;
					case 65:
					case 66:
						goto IL_02c3;
					case 67:
						goto IL_02d7;
					case 69:
						goto IL_02ed;
					case 70:
						goto IL_0301;
					case 72:
						goto IL_0314;
					case 73:
						goto IL_0328;
					case 75:
						goto IL_033b;
					case 76:
						goto IL_034f;
					case 78:
						goto IL_0362;
					case 79:
						goto IL_0376;
					case 64:
					case 68:
					case 71:
					case 74:
					case 77:
					case 80:
					case 81:
						goto IL_0387;
					case 83:
					case 84:
						goto IL_0394;
					case 85:
						goto IL_039b;
					case 7:
					case 8:
					case 10:
					case 33:
					case 37:
					case 38:
					case 60:
					case 82:
					case 86:
					case 87:
						goto IL_03a2;
					case 88:
					case 97:
					case 100:
					case 101:
					case 102:
					case 105:
					case 106:
						goto IL_03b9;
					default:
						goto end_IL_0000;
					case 99:
						goto IL_0586;
					case 98:
						goto IL_0598;
					case 95:
						goto IL_059e;
					case 94:
						goto IL_05aa;
					case 93:
						goto IL_05b7;
					case 92:
						goto IL_05c4;
					case 91:
						goto IL_05d2;
					case 90:
						goto IL_05e5;
					case 89:
						goto IL_05f6;
					case 0:
						goto end_IL_0000;
					case 96:
						goto IL_0614;
					case 103:
						goto IL_0620;
					case 104:
						goto IL_0624;
					case 107:
						goto end_IL_0000_2;
					}
					goto default;
					IL_05f6:
					num = 89;
					number = Information.Err().get_Number();
					goto IL_05e5;
					IL_05e5:
					num = 90;
					Information.Err().get_Description();
					goto IL_05d2;
					IL_05d2:
					num = 91;
					if (number == 55 || number == 70)
					{
						goto IL_05c4;
					}
					goto IL_0620;
					IL_0620:
					num = 103;
					goto IL_0624;
					IL_0624:
					num = 104;
					num5 = 0;
					goto IL_03b9;
					IL_05c4:
					num = 92;
					bnsDelay(ref ticks);
					goto IL_05b7;
					IL_05b7:
					num = 93;
					num6 = checked(num6 + ticks);
					goto IL_05aa;
					IL_05aa:
					num = 94;
					flag = !flag;
					goto IL_059e;
					IL_059e:
					num = 95;
					if (num6 < maxwait)
					{
						goto IL_0598;
					}
					goto IL_0614;
					IL_0614:
					num = 96;
					num5 = 0;
					goto IL_03b9;
					IL_0598:
					num = 98;
					goto IL_0586;
					IL_0586:
					num = 99;
					ProjectData.ClearProjectError();
					if (num2 == 0)
					{
						throw ProjectData.CreateProjectError(-2146828268);
					}
					goto IL_03c5;
					IL_039b:
					num = 85;
					flag = true;
					goto IL_03a2;
					IL_0008:
					num = 2;
					ticks = 200;
					goto IL_0012;
					IL_0012:
					num = 3;
					fLock = Strings.UCase(fLock);
					goto IL_001e;
					IL_001e:
					num = 4;
					num5 = FileSystem.FreeFile();
					goto IL_0028;
					IL_0028:
					num = 5;
					num6 = 0;
					goto IL_002e;
					IL_002e:
					num = 6;
					flag = false;
					goto IL_03a2;
					IL_03a2:
					num = 8;
					if (!flag & (num6 <= maxwait))
					{
						goto IL_0039;
					}
					goto IL_03b9;
					IL_03b9:
					num = 106;
					num7 = num5;
					goto end_IL_0000_2;
					IL_0039:
					num = 9;
					text = Strings.UCase(ac);
					goto IL_0046;
					IL_0046:
					num = 12;
					if (Operators.CompareString(text, "R", false) == 0)
					{
						goto IL_005d;
					}
					goto IL_0171;
					IL_005d:
					num = 13;
					if (Operators.CompareString(FindFile(fna, "."), "", false) != 0)
					{
						goto IL_007e;
					}
					goto IL_015a;
					IL_007e:
					num = 14;
					text2 = fLock;
					goto IL_0086;
					IL_0086:
					num = 17;
					if (Operators.CompareString(text2, "R", false) == 0)
					{
						goto IL_009a;
					}
					goto IL_00b0;
					IL_009a:
					num = 18;
					FileSystem.FileOpen(num5, fna, (OpenMode)1, (OpenAccess)(-1), (OpenShare)2, -1);
					goto IL_014a;
					IL_00b0:
					num = 20;
					if (Operators.CompareString(text2, "W", false) == 0)
					{
						goto IL_00c4;
					}
					goto IL_00d7;
					IL_00c4:
					num = 21;
					FileSystem.FileOpen(num5, fna, (OpenMode)1, (OpenAccess)(-1), (OpenShare)1, -1);
					goto IL_014a;
					IL_00d7:
					num = 23;
					if (Operators.CompareString(text2, "RW", false) == 0)
					{
						goto IL_00eb;
					}
					goto IL_00fe;
					IL_00eb:
					num = 24;
					FileSystem.FileOpen(num5, fna, (OpenMode)1, (OpenAccess)(-1), (OpenShare)0, -1);
					goto IL_014a;
					IL_00fe:
					num = 26;
					if (Operators.CompareString(text2, "S", false) == 0)
					{
						goto IL_0112;
					}
					goto IL_0125;
					IL_0112:
					num = 27;
					FileSystem.FileOpen(num5, fna, (OpenMode)1, (OpenAccess)(-1), (OpenShare)3, -1);
					goto IL_014a;
					IL_0125:
					num = 29;
					if (Operators.CompareString(text2, "", false) == 0)
					{
						goto IL_0139;
					}
					goto IL_014a;
					IL_0139:
					num = 30;
					FileSystem.FileOpen(num5, fna, (OpenMode)1, (OpenAccess)(-1), (OpenShare)(-1), -1);
					goto IL_014a;
					IL_014a:
					num = 32;
					flag = !flag;
					goto IL_03a2;
					IL_015a:
					num = 34;
					goto IL_015e;
					IL_015e:
					num = 35;
					num5 = 0;
					goto IL_0165;
					IL_0165:
					num = 36;
					flag = true;
					goto IL_03a2;
					IL_0171:
					num = 39;
					if (Operators.CompareString(text, "W", false) == 0)
					{
						goto IL_0188;
					}
					goto IL_0284;
					IL_0188:
					num = 40;
					AttrMinus(fna, (object)(FileAttribute)2);
					goto IL_01a8;
					IL_01a8:
					num = 41;
					text3 = fLock;
					goto IL_01b0;
					IL_01b0:
					num = 44;
					if (Operators.CompareString(text3, "R", false) == 0)
					{
						goto IL_01c4;
					}
					goto IL_01da;
					IL_01c4:
					num = 45;
					FileSystem.FileOpen(num5, fna, (OpenMode)2, (OpenAccess)(-1), (OpenShare)2, -1);
					goto IL_0274;
					IL_01da:
					num = 47;
					if (Operators.CompareString(text3, "W", false) == 0)
					{
						goto IL_01ee;
					}
					goto IL_0201;
					IL_01ee:
					num = 48;
					FileSystem.FileOpen(num5, fna, (OpenMode)2, (OpenAccess)(-1), (OpenShare)1, -1);
					goto IL_0274;
					IL_0201:
					num = 50;
					if (Operators.CompareString(text3, "RW", false) == 0)
					{
						goto IL_0215;
					}
					goto IL_0228;
					IL_0215:
					num = 51;
					FileSystem.FileOpen(num5, fna, (OpenMode)2, (OpenAccess)(-1), (OpenShare)0, -1);
					goto IL_0274;
					IL_0228:
					num = 53;
					if (Operators.CompareString(text3, "S", false) == 0)
					{
						goto IL_023c;
					}
					goto IL_024f;
					IL_023c:
					num = 54;
					FileSystem.FileOpen(num5, fna, (OpenMode)2, (OpenAccess)(-1), (OpenShare)3, -1);
					goto IL_0274;
					IL_024f:
					num = 56;
					if (Operators.CompareString(text3, "", false) == 0)
					{
						goto IL_0263;
					}
					goto IL_0274;
					IL_0263:
					num = 57;
					FileSystem.FileOpen(num5, fna, (OpenMode)2, (OpenAccess)(-1), (OpenShare)(-1), -1);
					goto IL_0274;
					IL_0274:
					num = 59;
					flag = !flag;
					goto IL_03a2;
					IL_0284:
					num = 61;
					if (Operators.CompareString(text, "A", false) == 0)
					{
						goto IL_029b;
					}
					goto IL_0394;
					IL_029b:
					num = 62;
					AttrMinus(fna, (object)(FileAttribute)2);
					goto IL_02bb;
					IL_02bb:
					num = 63;
					text4 = fLock;
					goto IL_02c3;
					IL_02c3:
					num = 66;
					if (Operators.CompareString(text4, "R", false) == 0)
					{
						goto IL_02d7;
					}
					goto IL_02ed;
					IL_02d7:
					num = 67;
					FileSystem.FileOpen(num5, fna, (OpenMode)8, (OpenAccess)(-1), (OpenShare)2, -1);
					goto IL_0387;
					IL_02ed:
					num = 69;
					if (Operators.CompareString(text4, "W", false) == 0)
					{
						goto IL_0301;
					}
					goto IL_0314;
					IL_0301:
					num = 70;
					FileSystem.FileOpen(num5, fna, (OpenMode)8, (OpenAccess)(-1), (OpenShare)1, -1);
					goto IL_0387;
					IL_0314:
					num = 72;
					if (Operators.CompareString(text4, "RW", false) == 0)
					{
						goto IL_0328;
					}
					goto IL_033b;
					IL_0328:
					num = 73;
					FileSystem.FileOpen(num5, fna, (OpenMode)8, (OpenAccess)(-1), (OpenShare)0, -1);
					goto IL_0387;
					IL_033b:
					num = 75;
					if (Operators.CompareString(text4, "S", false) == 0)
					{
						goto IL_034f;
					}
					goto IL_0362;
					IL_034f:
					num = 76;
					FileSystem.FileOpen(num5, fna, (OpenMode)8, (OpenAccess)(-1), (OpenShare)3, -1);
					goto IL_0387;
					IL_0362:
					num = 78;
					if (Operators.CompareString(text4, "", false) == 0)
					{
						goto IL_0376;
					}
					goto IL_0387;
					IL_0376:
					num = 79;
					FileSystem.FileOpen(num5, fna, (OpenMode)8, (OpenAccess)(-1), (OpenShare)(-1), -1);
					goto IL_0387;
					IL_0387:
					num = 81;
					flag = !flag;
					goto IL_03a2;
					IL_0394:
					num = 84;
					num5 = 0;
					goto IL_039b;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 1584;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		int result = num7;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static int strMemberPosition(ref string a, ref string[] b, ref bool ignorcase = false)
	{
		int result = -1;
		if (Information.UBound((Array)b, 1) >= 0)
		{
			int num = Information.UBound((Array)b, 1);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				if (Operators.CompareString(a, b[i], false) == 0)
				{
					result = i;
					i = Information.UBound((Array)b, 1);
				}
				else if (ignorcase && strEqual(ref a, ref b[i]))
				{
					result = i;
					i = Information.UBound((Array)b, 1);
				}
			}
		}
		return result;
	}

	public static object strSort(ref string[] txt)
	{
		int num = Information.UBound((Array)txt, 1);
		object result = null;
		bool flag = true;
		checked
		{
			while (flag)
			{
				flag = false;
				for (int i = 0; i < num; i++)
				{
					if (Operators.CompareString(txt[i], txt[i + 1], false) > 0)
					{
						string text = txt[i];
						txt[i] = txt[i + 1];
						txt[i + 1] = text;
						flag = true;
					}
				}
			}
			return result;
		}
	}

	public static object strReverse_Renamed(ref string[] txt)
	{
		object result = null;
		int num = Information.UBound((Array)txt, 1);
		checked
		{
			int num2 = (int)Math.Round(Conversion.Fix((double)(num + 1) / 2.0));
			for (int i = 0; i < num2; i++)
			{
				string text = txt[i];
				txt[i] = txt[num - i];
				txt[num - i] = text;
			}
			return result;
		}
	}

	public static string strFormat(ref string msg1, params object[] args)
	{
		int num = Information.UBound((Array)args, 1);
		checked
		{
			string[] str_Renamed = new string[num + 1];
			if (num >= 0)
			{
				int num2 = num;
				for (int i = 0; i <= num2; i++)
				{
					str_Renamed[i] = Conversions.ToString(args[i]);
				}
				return strFormatA(ref msg1, ref str_Renamed);
			}
			return msg1;
		}
	}

	public static string strFormatA(ref string msg1, ref string[] str_Renamed)
	{
		int tickCount = GetTickCount();
		string newstr = "Randy" + Conversions.ToString(tickCount) + "Kintzley";
		string mainstr = msg1;
		string oldstr = "%%";
		mainstr = StrReplace(ref oldstr, ref newstr, ref mainstr);
		checked
		{
			int num = Information.UBound((Array)str_Renamed, 1) + 1;
			int num2 = Information.UBound((Array)str_Renamed, 1);
			int num3 = Information.LBound((Array)str_Renamed, 1);
			for (tickCount = num2; tickCount >= num3; tickCount += -1)
			{
				string mainstr2 = str_Renamed[tickCount];
				oldstr = "%";
				mainstr2 = StrReplace(ref oldstr, ref newstr, ref mainstr2);
				string oldstr2 = "%" + Conversions.ToString(num);
				mainstr = StrReplace(ref oldstr2, ref mainstr2, ref mainstr);
				num--;
			}
			oldstr = "%";
			return StrReplace(ref newstr, ref oldstr, ref mainstr);
		}
	}
}
