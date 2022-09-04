using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace ns5;

internal class Class9
{
	private static RijndaelManaged rijndaelManaged_0 = new RijndaelManaged
	{
		Mode = CipherMode.CBC,
		Padding = PaddingMode.Zeros,
		KeySize = 128,
		BlockSize = 128,
		IV = new byte[16]
	};

	public static byte[] smethod_0()
	{
		rijndaelManaged_0.GenerateKey();
		byte[] byte_ = new byte[rijndaelManaged_0.Key.Length];
		Array.Copy(rijndaelManaged_0.Key, 0, byte_, 0, rijndaelManaged_0.Key.Length);
		smethod_3(ref byte_);
		return byte_;
	}

	public static void smethod_1(ref byte[] byte_0)
	{
		try
		{
			using ICryptoTransform cryptoTransform = rijndaelManaged_0.CreateEncryptor();
			byte_0 = cryptoTransform.TransformFinalBlock(byte_0, 0, byte_0.Length);
		}
		catch
		{
		}
	}

	public static void smethod_2(ref byte[] byte_0)
	{
		try
		{
			using ICryptoTransform cryptoTransform = rijndaelManaged_0.CreateDecryptor();
			byte_0 = cryptoTransform.TransformFinalBlock(byte_0, 0, byte_0.Length);
		}
		catch
		{
		}
	}

	private static void smethod_3(ref byte[] byte_0)
	{
		for (int i = 1; i < byte_0.Length; i++)
		{
			byte_0[i] ^= byte_0[i - 1];
		}
	}

	public static void smethod_4(ref byte[] byte_0)
	{
		for (int num = byte_0.Length - 1; num > 0; num--)
		{
			byte_0[num] ^= byte_0[num - 1];
		}
	}

	public static void smethod_5()
	{
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr intptr_2 = IntPtr.Zero;
		IntPtr handle = Process.GetCurrentProcess().Handle;
		NtQueryInformationProcess(handle, 7, ref intptr_, 4u, null);
		NtQueryInformationProcess(handle, 31, ref intptr_2, 4u, null);
		if (intptr_ != IntPtr.Zero || intptr_2 == IntPtr.Zero)
		{
			Assembly.GetCallingAssembly().GetModules()[0].Assembly.EntryPoint!.Invoke(null, null);
		}
	}

	[DllImport("ntdll", CharSet = CharSet.Unicode)]
	private static extern bool NtQueryInformationProcess(IntPtr intptr_0, int int_0, ref IntPtr intptr_1, uint uint_0, object object_0);
}
