using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns10;
using ns21;
using ns22;
using ns5;

namespace ns6;

[SuppressUnmanagedCodeSecurity]
internal sealed class Class119 : Class112
{
	private Struct30 struct30_0 = new Struct30(0);

	private Struct30 struct30_1 = new Struct30(0);

	private Struct29 struct29_0 = new Struct29(0);

	private bool bool_0;

	private string string_0;

	[NonSerialized]
	internal static GetString getString_1;

	public override string PluginName => getString_1(107376091);

	protected override void vmethod_1()
	{
		string text = string.Empty;
		int platform = (int)Environment.OSVersion.Platform;
		if (platform != 4 && platform != 128)
		{
			if (Environment.OSVersion.Platform == PlatformID.MacOSX)
			{
				text = getString_1(107370503);
			}
		}
		else
		{
			text = getString_1(107370544);
		}
		if (!string.IsNullOrEmpty(text))
		{
			throw new MySqlException(string.Format(Class121.WinAuthNotSupportOnPlatform, text));
		}
		base.vmethod_1();
	}

	public override string vmethod_5()
	{
		string text = base.vmethod_5();
		if (string.IsNullOrEmpty(text))
		{
			return getString_1(107370522);
		}
		return text;
	}

	protected override byte[] vmethod_4(byte[] byte_1)
	{
		if (byte_1 == null)
		{
			method_6();
		}
		byte[] byte_2 = null;
		if (bool_0)
		{
			method_5(out byte_2, byte_1, out bool_0);
		}
		if (bool_0 && byte_2 != null && byte_2.Length != 0)
		{
			return byte_2;
		}
		FreeCredentialsHandle(ref struct30_0);
		DeleteSecurityContext(ref struct30_1);
		return null;
	}

	private void method_5(out byte[] byte_1, byte[] byte_2, out bool bool_1)
	{
		byte_1 = null;
		bool_1 = true;
		Struct26 struct26_ = new Struct26(12288);
		Struct29 struct29_ = new Struct29(0);
		int num = -1;
		try
		{
			uint uint_ = 0u;
			if (byte_2 == null)
			{
				num = InitializeSecurityContext(ref struct30_0, IntPtr.Zero, string_0, 0, 0, 0, IntPtr.Zero, 0, out struct30_1, out struct26_, out uint_, out struct29_);
			}
			else
			{
				Struct26 struct26_2 = new Struct26(byte_2);
				try
				{
					num = InitializeSecurityContext_1(ref struct30_0, ref struct30_1, string_0, 0, 0, 0, ref struct26_2, 0, out struct30_1, out struct26_, out uint_, out struct29_);
				}
				finally
				{
					struct26_2.System_002EIDisposable_002EDispose();
				}
			}
			if (4115 == num || 4116 == num)
			{
				CompleteAuthToken(ref struct30_1, ref struct26_);
			}
			if (num != 0 && num != 590610 && num != 4115 && num != 4116)
			{
				throw new MySqlException(getString_1(107369961) + num);
			}
			byte_1 = struct26_.method_0();
		}
		finally
		{
			struct26_.System_002EIDisposable_002EDispose();
		}
		bool_1 = num != 0 && num != 4115;
	}

	private void method_6()
	{
		bool_0 = true;
		int num = AcquireCredentialsHandle(null, getString_1(107369892), 2, IntPtr.Zero, IntPtr.Zero, 0, IntPtr.Zero, ref struct30_0, ref struct29_0);
		if (num != 0)
		{
			throw new MySqlException(getString_1(107369911) + num);
		}
	}

	[DllImport("secur32", CharSet = CharSet.Unicode)]
	private static extern int AcquireCredentialsHandle(string string_1, string string_2, int int_0, IntPtr intptr_0, IntPtr intptr_1, int int_1, IntPtr intptr_2, ref Struct30 struct30_2, ref Struct29 struct29_1);

	[DllImport("secur32", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern int InitializeSecurityContext(ref Struct30 struct30_2, IntPtr intptr_0, string string_1, int int_0, int int_1, int int_2, IntPtr intptr_1, int int_3, out Struct30 struct30_3, out Struct26 struct26_0, out uint uint_0, out Struct29 struct29_1);

	[DllImport("secur32", CharSet = CharSet.Unicode, EntryPoint = "InitializeSecurityContext", SetLastError = true)]
	private static extern int InitializeSecurityContext_1(ref Struct30 struct30_2, ref Struct30 struct30_3, string string_1, int int_0, int int_1, int int_2, ref Struct26 struct26_0, int int_3, out Struct30 struct30_4, out Struct26 struct26_1, out uint uint_0, out Struct29 struct29_1);

	[DllImport("secur32", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern int CompleteAuthToken(ref Struct30 struct30_2, ref Struct26 struct26_0);

	[DllImport("secur32.Dll", CharSet = CharSet.Unicode)]
	public static extern int QueryContextAttributes(ref Struct30 struct30_2, uint uint_0, out Struct31 struct31_0);

	[DllImport("secur32.Dll", CharSet = CharSet.Unicode)]
	public static extern int FreeCredentialsHandle(ref Struct30 struct30_2);

	[DllImport("secur32.Dll", CharSet = CharSet.Unicode)]
	public static extern int DeleteSecurityContext(ref Struct30 struct30_2);

	static Class119()
	{
		Strings.CreateGetStringDelegate(typeof(Class119));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_1(107399602), getString_1(107399597)).Replace(getString_1(107399560), getString_1(107399555)));
		if (!StrongNameSignatureVerificationEx_1(uri.LocalPath, bool_1: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_1(107399550)))
		{
			throw new SecurityException(getString_1(107399525));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx_1([MarshalAs(UnmanagedType.LPWStr)] string string_1, [MarshalAs(UnmanagedType.Bool)] bool bool_1, [MarshalAs(UnmanagedType.Bool)] out bool bool_2);
}
