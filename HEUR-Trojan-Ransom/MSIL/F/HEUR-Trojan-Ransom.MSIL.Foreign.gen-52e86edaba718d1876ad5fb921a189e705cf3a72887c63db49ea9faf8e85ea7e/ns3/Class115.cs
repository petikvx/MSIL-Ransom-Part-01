using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns21;
using ns22;

namespace ns3;

internal class Class115 : Class112
{
	protected byte[] byte_1;

	[NonSerialized]
	internal static GetString getString_1;

	public override string PluginName => getString_1(107368781);

	protected override byte[] vmethod_4(byte[] byte_2)
	{
		byte_1 = byte_2;
		return method_5();
	}

	public override object vmethod_6()
	{
		if (base.Settings.SslMode != 0)
		{
			byte[] bytes = base.Encoding.GetBytes(base.Settings.Password);
			byte[] array = new byte[bytes.Length + 2];
			Array.Copy(bytes, 0, array, 1, bytes.Length);
			array[0] = (byte)(bytes.Length + 1);
			array[^1] = 0;
			return array;
		}
		if (base.Settings.Password.Length == 0)
		{
			return new byte[1];
		}
		if (byte_1 == null)
		{
			return new byte[1] { 1 };
		}
		if (!base.Settings.AllowPublicKeyRetrieval)
		{
			throw new MySqlException(Class121.RSAPublicKeyRetrievalNotEnabled);
		}
		byte[] array2 = method_6(base.Settings.Password, byte_0, byte_1);
		if (array2 != null && array2.Length == 1 && array2[0] == 0)
		{
			return null;
		}
		return array2;
	}

	private byte[] method_5()
	{
		if (base.Settings.SslMode != 0)
		{
			byte[] bytes = base.Encoding.GetBytes(base.Settings.Password);
			byte[] array = new byte[bytes.Length + 1];
			Array.Copy(bytes, 0, array, 0, bytes.Length);
			array[bytes.Length] = 0;
			return array;
		}
		return vmethod_6() as byte[];
	}

	private byte[] method_6(string string_0, byte[] byte_2, byte[] byte_3)
	{
		if (string_0.Length == 0)
		{
			return new byte[1];
		}
		byte[] rgb = method_7(Encoding.Default.GetBytes(string_0), byte_2);
		return (MySqlPemReader.smethod_0(byte_3) ?? throw new MySqlException(Class121.UnableToReadRSAKey)).Encrypt(rgb, fOAEP: true);
	}

	protected byte[] method_7(byte[] byte_2, byte[] byte_3)
	{
		byte[] array = new byte[byte_2.Length + 1];
		Array.Copy(byte_2, 0, array, 0, byte_2.Length);
		array[byte_2.Length] = 0;
		byte[] array2 = new byte[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array2[i] = (byte)(array[i] ^ byte_3[i % byte_3.Length]);
		}
		return array2;
	}

	static Class115()
	{
		Strings.CreateGetStringDelegate(typeof(Class115));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_1(107398023), getString_1(107398018)).Replace(getString_1(107397981), getString_1(107397976)));
		if (!StrongNameSignatureVerificationEx_1(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_1(107397971)))
		{
			throw new SecurityException(getString_1(107397946));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx_1([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
