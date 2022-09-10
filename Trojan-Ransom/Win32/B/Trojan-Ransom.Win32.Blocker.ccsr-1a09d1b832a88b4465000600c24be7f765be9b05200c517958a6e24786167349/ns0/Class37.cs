using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.Zip;

namespace ns0;

internal sealed class Class37
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1602)]
	private struct Struct28
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	public static Bitmap smethod_0(string string_1)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		Stream stream = default(Stream);
		Bitmap val = default(Bitmap);
		try
		{
			try
			{
				stream = Class21.smethod_0(Class24.smethod_1(75, 112), "SmartAssembly.SmartUsageWithUI.Resources." + string_1 + ".png", 491, 432);
				val = ((stream == null) ? ((Bitmap)null) : new Bitmap(stream));
				return val;
			}
			catch
			{
				val = null;
				return val;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, stream, val, string_1);
			throw;
		}
	}

	static Class37()
	{
		DESCryptoIndirector.smethod_0();
		char_1 = new char[801];
		char[] array = new char[8];
		array[6] = 'ໞ';
		array[2] = '⛱';
		array[3] = '\u082d';
		array[0] = '㤖';
		array[5] = 'ᡑ';
		array[4] = '\u0952';
		array[7] = '૦';
		array[1] = 'ᮞ';
		string_0 = new string[33];
		char_0 = array;
	}

	internal static void smethod_1(WebClientProtocol webClientProtocol_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 94:
				webClientProtocol_0.set_Url(string_1);
				return;
			}
		}
	}

	internal static IntPtr smethod_2(Font font_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 58:
				return font_0.ToHfont();
			}
		}
	}

	internal static Delegate smethod_3(IntPtr intptr_0, Type type_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 53:
				return Marshal.GetDelegateForFunctionPointer(intptr_0, type_0);
			}
		}
	}

	internal static void smethod_4(Control control_0, bool bool_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 121:
				control_0.set_Visible(bool_0);
				return;
			}
		}
	}

	internal static byte[] smethod_5(MemoryStream memoryStream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 16:
				return memoryStream_0.ToArray();
			}
		}
	}

	internal static bool smethod_6(IntPtr intptr_0, IntPtr intptr_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 121:
				return intptr_0 != intptr_1;
			}
		}
	}

	internal static long smethod_7(Stream stream_0, long long_0, SeekOrigin seekOrigin_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 75:
				return stream_0.Seek(long_0, seekOrigin_0);
			}
		}
	}

	internal static int smethod_8(string string_1, char char_2, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 59:
				return string_1.IndexOf(char_2);
			}
		}
	}
}
