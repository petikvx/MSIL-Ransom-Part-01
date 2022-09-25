using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

internal class MaxPairwiseScalar
{
	private static List<string> SourceException = new List<string>();

	private static int RequestOptional/* Not supported: data(00 00 00 00) */;

	private static int IID/* Not supported: data(02 00 00 00) */;

	private static int get_IsAssembly/* Not supported: data(EE 43 00 00) */;

	private static int ShiftRightAndInsert/* Not supported: data(01 00 00 00) */;

	private static int OK/* Not supported: data(0E 00 00 00) */;

	private static int Magic/* Not supported: data(1B 77 01 00) */;

	private static int remove_ModuleResolve/* Not supported: data(8C 28 00 00) */;

	private static int Cond_Branch/* Not supported: data(C6 70 FF FF) */;

	private static int ESPIPE/* Not supported: data(40 1B 00 00) */;

	private static int ToArray/* Not supported: data(A8 02 00 00) */;

	private static int System_002ECollections_002EObjectModel/* Not supported: data(02 00 00 00) */;

	private static int Conv_Ovf_U8/* Not supported: data(00 00 00 00) */;

	private static int CrossProcess/* Not supported: data(01 00 00 00) */;

	private static int get_DateTime/* Not supported: data(06 00 00 00) */;

	private static int GenericEqualityComparer__1/* Not supported: data(03 00 00 00) */;

	private static int ICollection/* Not supported: data(04 00 00 00) */;

	private static int System_002EThreading_002ETasks_002ESources/* Not supported: data(05 00 00 00) */;

	private static int CharCount/* Not supported: data(08 00 00 00) */;

	private static int CompilerGeneratedAttribute/* Not supported: data(97 00 00 00) */;

	private static int get_ExecutionContext/* Not supported: data(21 06 FA FF) */;

	private static int ClearCachedData/* Not supported: data(D4 DC FF FF) */;

	private static int set_InitLocals/* Not supported: data(AA 3F 0B 00) */;

	private static int Started/* Not supported: data(B1 40 00 00) */;

	private static int WriteIntPtr/* Not supported: data(2B 87 00 00) */;

	private static int ExtractNarrowingLower/* Not supported: data(43 DE E8 FF) */;

	private static int LAHashKeyToTrackers/* Not supported: data(C3 0E 00 00) */;

	private static int Byte01/* Not supported: data(23 01 00 00) */;

	private static int ComputeHash32OrdinalIgnoreCase/* Not supported: data(08 FC F8 FF) */;

	private static int SysLogPriority/* Not supported: data(AD EF FE FF) */;

	private static int get_AssemblyFullName/* Not supported: data(D4 2C 00 00) */;

	private static int set_Infrastructure/* Not supported: data(38 02 00 00) */;

	private static int AddPairwiseScalar/* Not supported: data(4F 17 F6 FF) */;

	private static int DebuggerVisualizerAttribute/* Not supported: data(A2 20 DD 36) */;

	private static int IsThreadOwnerTrackingEnabled/* Not supported: data(9E 02 00 00) */;

	private static int UtcOffset/* Not supported: data(A1 71 03 00) */;

	private static int HideScheduler/* Not supported: data(FE FF FF FF) */;

	private static int CriticalHandleZeroOrMinusOneIsInvalid/* Not supported: data(FD FF FF FF) */;

	private static int ExecuteAssemblyByName/* Not supported: data(FA FF FF FF) */;

	private static int OnStop/* Not supported: data(0A 00 00 00) */;

	private static int GetNextTextElement/* Not supported: data(0B 00 00 00) */;

	private static int SetHandled/* Not supported: data(3B 00 00 00) */;

	private static int Conv_R_Un/* Not supported: data(3F 00 00 00) */;

	private static int YieldAwaitable/* Not supported: data(32 00 00 00) */;

	private static int CollectionsMarshal/* Not supported: data(37 00 00 00) */;

	private static int get_IsField/* Not supported: data(78 01 00 00) */;

	private static int FastMod/* Not supported: data(59 00 00 00) */;

	private static int get_ReferenceValue/* Not supported: data(8A 1A F1 FF) */;

	private static int LeadingSignCount/* Not supported: data(3F 5A F4 FF) */;

	private static int Endfilter/* Not supported: data(9C 65 FC FF) */;

	private static int AsDecimal/* Not supported: data(36 B5 02 00) */;

	private static int StandardFormat/* Not supported: data(E0 2F 00 00) */;

	private static int _systemTimeZones/* Not supported: data(FB B5 FE FF) */;

	private static int ConvertToVector256Double/* Not supported: data(12 EF FA FF) */;

	private static int AppContext/* Not supported: data(69 0E 0B 00) */;

	private static int set_MonthDayPattern/* Not supported: data(8F E8 FE FF) */;

	private static int ExtractNarrowingSaturateLower/* Not supported: data(80 F1 FB FF) */;

	private static int ObjectName/* Not supported: data(7B 13 0A 00) */;

	private static int get_Tool/* Not supported: data(A5 C0 03 00) */;

	private static int User/* Not supported: data(67 FF FF FF) */;

	private static int FileAttributes/* Not supported: data(CF 5D 00 00) */;

	private static int HeapSizeBytes/* Not supported: data(66 54 09 00) */;

	private static int MinusOne/* Not supported: data(4F 47 00 00) */;

	private static int SpecifyKind/* Not supported: data(41 01 09 00) */;

	private static int get_UseStd3AsciiRules/* Not supported: data(EF A5 FF FF) */;

	private static int AbsoluteCompareGreaterThanOrEqual/* Not supported: data(A2 34 FF FF) */;

	private static int UnorderedNotLessThanOrEqualSignaling/* Not supported: data(5B 6D 00 00) */;

	private static int O_RDONLY/* Not supported: data(B4 2B 02 00) */;

	private static int MinNumberPairwiseScalar/* Not supported: data(D9 83 02 00) */;

	private static int get_Types/* Not supported: data(DD 6C FB FF) */;

	private static int InsertScalar/* Not supported: data(3E 1A B4 03) */;

	private static int TypeForwardedFromAttribute/* Not supported: data(13 04 04 00) */;

	private static int EventPipeSessionInfo/* Not supported: data(23 E5 FF FF) */;

	private static int TYPEFLAG_FNONEXTENSIBLE/* Not supported: data(27 B8 F8 FF) */;

	private static int AllowTrailingSign/* Not supported: data(83 CC 02 00) */;

	private static int ELEMENT_TYPE_U1/* Not supported: data(B1 3F 06 00) */;

	private static int TryEnterReadLock/* Not supported: data(08 04 76 30) */;

	private static int AssemblyLoadEventHandler/* Not supported: data(FE 8C 06 00) */;

	private static int System_002EReflection/* Not supported: data(5F 3A 01 00) */;

	private static int MultiplyAddScalar/* Not supported: data(3F 7C F8 FF) */;

	private static int BindToField/* Not supported: data(A9 F9 FF FF) */;

	private static int get_IsDynamicCodeCompiled/* Not supported: data(CA 5A 0C 00) */;

	private static int VARFLAGS/* Not supported: data(68 53 09 7D) */;

	private static int BindingRedirects/* Not supported: data(EF 36 F2 FF) */;

	private unsafe static void ISymUnmanagedDocumentWriter()
	{
		char[] array = new char[19]
		{
			'\u0002', '\0', '\u0001', '\u0005', '\b', '碶', '℀', '⦻', '\u0006', '\u0003',
			'n', '8', 'M', 'J', '燼', '䵭', 'ᛝ', '퍻', '㯈'
		};
		int[] array2 = new int[39]
		{
			2, 0, 1, 3, 4, 5, 16, 26029, 54077650, 60994,
			-11, 18121, 1563, 4043, -580814, 11, 57, -13900, -3025, -130956,
			1567733010, -87380, 1205366, -629757, -827639, 27117, 889670219, 56831, 622443, -411053,
			-310451, -88144, 385018, 60288, -49026, 142261, -118461, -462716, 411548265
		};
		char c = (char)Marshal.SizeOf(typeof(UseHebrewParsing));
		char[] array3 = new char[(uint)c];
		array3[Conv_Ovf_U8 | 0] = (char)checked(get_ReferenceValue - -976251);
		char[] array4 = array3;
		int[] array5 = new int[Convert.ToInt32(char.ToString('1') + "10", 2)];
		checked
		{
			array5[0 * LeadingSignCount] = 1;
			int num = default(int);
			switch (Convert.ToInt32("11111111111110100011011111101111", 2) + Convert.ToInt32("1011100100000010100", 2))
			{
			case 0:
				num = 806254;
				break;
			case 1:
				num = 139258;
				break;
			case 2:
				num = -317766;
				break;
			case 3:
				num = _003CModule_003E.ActivityOptions[1];
				break;
			}
			array5[1] = num;
			array5[HideScheduler * -1] = Convert.ToInt32(char.ToString('1') + "110", 2);
		}
		array5[3] = 1232286792 / Convert.ToInt32("9d2f4", 16);
		array5[4] = -590330 % Endfilter;
		array5[Convert.ToInt32("5", 16)] = 839 * Convert.ToInt32("ffffffff", 16);
		int[] array6 = array5;
		string string_ = "ਗ਼ਜ਼";
		object[] array7 = new object[checked(_003CModule_003E.KeyValuePair__2[216] + 594401)];
		array7[Convert.ToInt32("0", array[4])] = (byte)Convert.ToInt32("0", 16) != 0;
		array7[(-5457 >= Convert.ToInt32("11111111111111001011011100111001", 2)) ? sizeof(bool) : 240010] = 933;
		array7[2] = Convert.ToInt32("101" + "11001", Convert.ToInt32("10", 2));
		array7[Convert.ToInt32("3", 16)] = "\u0088\u0017";
		array7[6 & (nint)((Array)(object)"\u0333\u031f\u0355\u0349").LongLength] = (char)Convert.ToInt32("63", 8);
		array7[5] = 'Թ';
		_003CModule_003E.TAIWANLUNISOLAR(ref string_, array7);
		string folderPath = Environment.GetFolderPath((Environment.SpecialFolder)Convert.ToInt32(string_, sizeof(double)));
		string folderPath2 = Environment.GetFolderPath((Environment.SpecialFolder)checked(Convert.ToInt32("7343ba9b", 16) + 601102 - -904862 >> -475994 - ((array2[17] > -884244) ? (-476020) : 399148)));
		List<string> sourceException = SourceException;
		string text = char.ToString((char)(Convert.ToInt32("16" + "35342", 8) + Convert.ToInt32("37" + char.ToString('7') + "76315045", sizeof(long))));
		string text2 = char.ToString((char)checked(_003CModule_003E.ActivityOptions[unchecked((uint)array[11])] + get_ExecutionContext));
		string string_2 = "꾧꾽";
		object[] array8 = new object[4];
		array8[0] = false;
		array8[Marshal.SizeOf(typeof(UseHebrewParsing))] = Convert.ToInt32(char.ToString('1') + "93d", Convert.ToInt32("10000", 2));
		array8[Convert.ToInt32("2", sizeof(double))] = ((-64547 < Convert.ToInt32("11101101101111110111", 2)) ? 11864 : (-304237));
		int num2 = ((array2[18] != _003CModule_003E.ActivityOptions[186]) ? Convert.ToInt32("3300", 16) : 286427);
		array8[3] = num2;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_2, array8);
		string text3 = string_2;
		string string_3 = string.Concat(char.ToString('⚁'), char.ToString('⚍') + "⚐⚆");
		object[] array9 = new object[(nint)((Array)(object)"\u0351\u034b").LongLength];
		char c2 = (char)Marshal.SizeOf(typeof(get_WrappedObject));
		array9[0] = (int)c2;
		char c3 = (char)Convert.ToInt32("11100101101110", 2);
		array9[1] = (int)c3;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_3, array9);
		string string_4 = string.Concat(text, text2, text3 + string_3);
		string string_5 = char.ToString('혍') + "혌혌";
		object[] array10 = new object[130962 + array2[19]];
		array10[checked(-802674 - Convert.ToInt32("fff3c08e", 16))] = Convert.ToInt32("10" + "00" + "00010100100", 2);
		array10[checked(array2[2] * Marshal.SizeOf(typeof(UseHebrewParsing)))] = array2[20] / 148039;
		array10[Convert.ToInt32("2", 8)] = Convert.ToInt32(char.ToString('1') + char.ToString('0') + "11000111", Convert.ToInt32("2", 16));
		array10[3 & array[9]] = (char)array2[7];
		array10[array2[4]] = (char)(0xFFFBDDACu ^ (uint)Convert.ToInt32("fffbde6a", 16));
		array10[5] = false;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_5, array10);
		object[] array11 = new object[Convert.ToInt32(string_5, Marshal.SizeOf(typeof(ENODATA))) * 1];
		array11[0] = _003CModule_003E.Dequeue[9009 + ClearCachedData];
		char shiftRightAndInsert = (char)ShiftRightAndInsert;
		array11[(uint)shiftRightAndInsert] = 9696;
		int iID = IID;
		string text4 = char.ToString((char)array6[2]);
		string text5 = char.ToString((char)array6[3]);
		string text6 = char.ToString('Ģ');
		string string_6 = string.Concat(char.ToString('咹'), char.ToString('咺') + "咻咹");
		object[] array12 = new object[6];
		array12[array2[1]] = (byte)Conv_Ovf_U8 != 0;
		int num3 = ((array2[21] == -87380) ? 1 : Marshal.SizeOf(typeof(TargetType)));
		array12[num3] = "ਝ\u02f8";
		array12[-997193 ^ Convert.ToInt32("fff0c8b5", 16)] = string.Concat(char.ToString((char)_003CModule_003E.ActivityOptions[187]), char.ToString('\u0826') + "\u0012\t");
		array12[Convert.ToInt32("3", 16)] = 1271;
		array12[sizeof(uint)] = (char)Convert.ToInt32(char.ToString('5') + "222", 8);
		array12[5] = Marshal.SizeOf(typeof(set_DisplayName)) << 1;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_6, array12);
		array11[iID] = string.Concat(text4, text5, text6 + string_6);
		int num5;
		int num7;
		string string_7;
		object[] array13;
		checked
		{
			int num4 = default(int);
			switch (unchecked((nint)((Array)(object)string.Empty).LongLength) * unchecked(Convert.ToInt32("755febf0", 16) / 4638))
			{
			case 0:
				num4 = Convert.ToInt32("3777" + "7563742", 8);
				break;
			case 1:
				num4 = -366374;
				break;
			}
			if (num4 <= ((_003CModule_003E.ActivityOptions[188] - -952905) & set_InitLocals))
			{
				num5 = ~(-648027 ^ Convert.ToInt32("9e359", 16));
			}
			else
			{
				int num6 = (((0x3F7C & Marshal.SizeOf(typeof(DebugActivityId))) <= _003CModule_003E.get_PositiveSign[69]) ? (-433695) : (array2[22] - 707825));
				num5 = num6;
			}
			num7 = ((_003CModule_003E.get_PositiveSign[70] <= -991633) ? 680089 : (-21));
			string_7 = string.Concat(char.ToString('톇'), char.ToString('톇'), "톇톇" + "톇톇톇퇓");
			array13 = new object[array2[Convert.ToInt32("5", 16)]];
			array13[0] = char.ToString('挶') + "ժ൦";
		}
		array13[array2[23] - Convert.ToInt32("37775462002", 8)] = Convert.ToInt32(char.ToString('3') + char.ToString('1') + "721", sizeof(long));
		int num8 = 3 & Marshal.SizeOf(typeof(ENODATA));
		char c4 = (char)Marshal.SizeOf(typeof(get_IsMultiDimensionalArray));
		array13[num8] = (int)c4;
		array13[array2[3]] = 845428968 / AsDecimal;
		array13[Marshal.SizeOf(typeof(IsValidText))] = string.Concat(char.ToString((char)sizeof(sbyte)), char.ToString('e'), char.ToString('\u034a') + char.ToString('\u030a') + "\u0001\u0017");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_7, array13);
		List<string> sourceException2;
		string string_8;
		object[] array14;
		checked
		{
			array11[num5] = num7 * Convert.ToInt32(string_7, Convert.ToInt32(char.ToString('1') + "0000", Convert.ToInt32("10", 2)));
			_003CModule_003E.GetMaxByteCount(ref string_4, array11);
			sourceException.Add(folderPath + string_4);
			sourceException2 = SourceException;
			string_8 = "䶋䶳";
			array14 = new object[6];
			array14[0 & Convert.ToInt32("1", 8)] = array2[24] + 828001;
			array14[1] = char.ToString('É') + "\a2";
			array14[sizeof(ushort)] = '³';
			array14[6293 >> GetNextTextElement] = string.Concat(char.ToString('ǆ'), char.ToString('Ϸ'), char.ToString('\t') + "Ā\u0081");
		}
		array14[sizeof(float)] = (byte)(0 % Convert.ToInt32("2516534", 8)) != 0;
		array14[Convert.ToInt32("11001", 2) % 10] = 'ʩ';
		_003CModule_003E.TAIWANLUNISOLAR(ref string_8, array14);
		string text7 = string_8;
		string text8 = char.ToString((char)Started);
		string string_9 = "㛟㛏";
		object[] array15 = new object[2];
		int num9 = -833247 - Convert.ToInt32("11111111111100110100100100100001", 2);
		char c5 = array[14];
		array15[num9] = (char)(int)c5;
		array15[1] = 1144;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_9, array15);
		string text9 = text8 + string_9;
		string string_10 = "⟪⟷";
		object[] array16 = new object[6];
		array16[0] = 1735;
		array16[(uint)array[2]] = false;
		int num10 = ((13476 >= Convert.ToInt32("37774612715", 8)) ? 2 : 159464);
		array16[num10] = 'Å';
		array16[(nint)((Array)(object)(char.ToString('\u0335') + "\u036d\u0338")).LongLength] = _003CModule_003E.KeyValuePair__2[217] >> Convert.ToInt32("100", 2);
		array16[4] = string.Concat("ឈ\u001c", char.ToString('ϧ') + char.ToString('%') + "\u0003\u001e\u000e");
		array16[5] = 1489;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_10, array16);
		string text10 = string_10;
		string text11 = char.ToString((char)Marshal.SizeOf(typeof(Ldelem_I)));
		string string_11 = string.Concat(char.ToString('㗵'), char.ToString('㗷'), char.ToString('㗸') + "㗷㗤㗯");
		object[] array17 = new object[Convert.ToInt32("3", array2[6])];
		array17[0] = char.ToString('ጽ') + "Æ4";
		array17[1] = 'ছ';
		array17[Marshal.SizeOf(typeof(ENODATA))] = (char)((StandardFormat < _003CModule_003E.KeyValuePair__2[218]) ? 4294904689u : '坼');
		_003CModule_003E.TAIWANLUNISOLAR(ref string_11, array17);
		string string_12 = string.Concat(text7, text9, text10 + text11 + string_11);
		int num11 = 23154791 >> Convert.ToInt32("8", 16);
		string string_13 = string.Concat("\uffd9\uffd8", char.ToString('\uffd9') + "\uffd9\uffd8", "\uffd8\uffd8\uffd8" + "\uffd9\uffd8\uffd9\uffd8\uffd9\uffd8\uffd8\uffd8\uffd8");
		object[] array18 = new object[_003CModule_003E.KeyValuePair__2[219] ^ -565905];
		array18[(uint)array[1]] = false;
		array18[1] = WriteIntPtr;
		array18[2] = 30909;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_13, array18);
		int num12 = default(int);
		switch (num11 - Convert.ToInt32(string_13, _003CModule_003E.ActivityOptions[0]))
		{
		case 0:
			num12 = 6;
			break;
		}
		object[] array19 = new object[num12];
		int[] loadVector = _003CModule_003E.LoadVector128;
		int num13 = Convert.ToInt32("5b781", 16);
		string string_14;
		checked
		{
			int num14 = loadVector[num13 + -374657];
			int num15 = ((((Magic > _003CModule_003E.LoadVector128[(_systemTimeZones <= 731534) ? 31 : 885094]) ? 1 : 0) != array6[1]) ? 175439 : (Convert.ToInt32("1001" + "11101" + "1011100011", 2) - 324208));
			array19[num14] = num15;
			string_14 = "\ue7dc";
		}
		object[] array20 = new object[Convert.ToInt32("10011110011001001100", 2) + -648776];
		array20[0 << OnStop] = false;
		array20[sizeof(byte)] = string.Concat(char.ToString('ᄟ'), char.ToString('[') + "\\F¥");
		char num16 = array[0];
		int num17 = array2[25];
		array20[(uint)num16] = (char)num17;
		int num18 = array2[(nint)((Array)(object)".\u036a\u0332").LongLength];
		int num19 = default(int);
		switch (-391882 - Convert.ToInt32("fffa0534", 16))
		{
		case 0:
			num19 = 94740;
			break;
		case 1:
			num19 = -786877;
			break;
		case 2:
			num19 = 26627;
			break;
		}
		array20[num18] = num19;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_14, array20);
		IntPtr intPtr = (nint)((Array)(object)string_14).LongLength;
		int num20 = ((Convert.ToInt32("37777562024", 8) <= -800238) ? 914658 : 403);
		array19[(nint)intPtr] = ~checked(num20 * -1);
		int num21 = Convert.ToInt32("37" + "77" + "7764464", Marshal.SizeOf(typeof(__c__DisplayClass0_6))) * _003CModule_003E.get_PositiveSign[71];
		string string_15 = "촉";
		object[] array21 = new object[Convert.ToInt32("5", 16)];
		array21[_003CModule_003E.ActivityOptions[1] & Convert.ToInt32("0", 8)] = 12452;
		array21[array2[26] / Convert.ToInt32("35074a4b", 16)] = (byte)(Convert.ToInt32("cc5d3", 16) + Convert.ToInt32("11111111111100110011101000101101", 2)) != 0;
		array21[2] = "㒒凰";
		int num22 = Convert.ToInt32("3", 8);
		int num23 = (((nint)1 != (nint)((Array)(object)string.Empty).LongLength) ? 3390 : (-143003));
		array21[num22] = num23;
		array21[4] = string.Concat(char.ToString('ߞ'), char.ToString((char)Marshal.SizeOf(typeof(CleanupCode))), char.ToString('Ĉ') + "\0\u0002");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_15, array21);
		int num24 = num21 >> Convert.ToInt32(string_15, Marshal.SizeOf(typeof(PrepareDelegate)));
		string text12 = char.ToString((char)('Ů' & _003CModule_003E.KeyValuePair__2[61]));
		string text13 = char.ToString((char)OK);
		string text14 = char.ToString((char)checked(_003CModule_003E.get_PositiveSign[202] - -991035));
		string text15 = char.ToString('\u0004');
		string string_16 = "嗡嗢";
		object[] array22 = new object[checked(291150 - Convert.ToInt32("1000111000101001010", 2))];
		array22[80 >> (int)((Array)(object)"\u0341\u0356\u0356\u0368\u0332\u0333\u0342\u0306").LongLength] = "\u001a&";
		array22[1] = string.Concat(char.ToString('ச'), char.ToString('ƕ') + "\u001cY\u001e\r");
		int num25 = Marshal.SizeOf(typeof(set_Task));
		array22[2] = (char)num25;
		array22[3] = 18337;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_16, array22);
		array19[num24] = string.Concat(text12, text13, text14 + text15 + string_16);
		int num26 = 1688784336 / ((Convert.ToInt32(char.ToString('2') + "47410", 8) > (Convert.ToInt32("11010011111011111101", 2) & 0x8F7E0)) ? _003CModule_003E.get_PositiveSign[72] : 562928112);
		_ = 0 * (0x1E422100 | Convert.ToInt32("f5bc2712", 16));
		int num27 = Convert.ToInt32("a", 16);
		int num28 = ((95358 != 97647439 >> num27) ? (_003CModule_003E.KeyValuePair__2[62] * 38) : 0);
		array19[num26] = (byte)num28 != 0;
		int convertToVector256Double = ConvertToVector256Double;
		int num29 = -393685 & convertToVector256Double;
		string string_17 = string.Concat(char.ToString('늉'), char.ToString('늍'), "늍늍" + char.ToString('늌') + "늋늌늌늍늍늌");
		object[] array23 = new object[array2[4]];
		array23[0] = "涶㜐";
		array23[1] = 886;
		char c6 = array[0];
		array23[(int)c6] = char.ToString(':') + "\u0015ހ";
		array23[Convert.ToInt32("1e9", 16) >> 7] = (char)checked(Convert.ToInt32("37776160441", 8) - -467342);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_17, array23);
		array19[num29 - Convert.ToInt32(string_17, 8)] = checked(1800094 - unchecked(766031 - _003CModule_003E.KeyValuePair__2[220])) >> 973527084 / ((84642 > Convert.ToInt32("66216", 8)) ? 108169676 : (-875879));
		int num30 = 0 | Marshal.SizeOf(typeof(OnlyOnCanceled));
		int num31 = remove_ModuleResolve;
		int num32 = ((checked(544134 - Convert.ToInt32("1747717", 8)) >= 113211) ? (-795484) : 9491);
		array19[num30] = num31 | num32;
		_003CModule_003E.GetMaxByteCount(ref string_12, array19);
		sourceException2.Add(folderPath + string_12);
		List<string> sourceException3 = SourceException;
		string string_18 = "䳊䳲";
		object[] array24 = new object[3];
		array24[0 * Marshal.SizeOf(typeof(PauseTimePercentage))] = checked(8146 * sizeof(short));
		array24[CrossProcess] = (byte)Convert.ToInt32("0", Convert.ToInt32("10000", 2)) != 0;
		array24[~CriticalHandleZeroOrMinusOneIsInvalid] = 19878;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_18, array24);
		string text16 = string_18;
		string string_19 = "礝礇";
		object[] array25 = new object[checked(_003CModule_003E.KeyValuePair__2[221] + -246006)];
		array25[Conv_Ovf_U8] = (byte)(0 % AppContext) != 0;
		array25[1] = _003CModule_003E.get_PositiveSign[73];
		array25[2] = 6653;
		array25[array2[3]] = Convert.ToInt32(char.ToString('1') + char.ToString('5') + "161", _003CModule_003E.get_PositiveSign[3]);
		array25[2 << sizeof(byte)] = Convert.ToInt32("374107", 8) % 51638;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_19, array25);
		string text17 = string_19;
		string text18 = char.ToString((char)(array2[27] & _003CModule_003E.KeyValuePair__2[222]));
		string text19 = char.ToString((char)checked(49587 * Convert.ToInt32("1", 16)));
		string string_20 = string.Concat(char.ToString(array[15]), char.ToString('䵻') + char.ToString('䵯') + "䵫䵽");
		object[] array26 = new object[System_002ECollections_002EObjectModel];
		array26[0] = _003CModule_003E.KeyValuePair__2[Conv_R_Un];
		array26[Convert.ToInt32("1", 8) * 1] = _003CModule_003E.get_PositiveSign[(uint)array[13]];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_20, array26);
		string string_21 = string.Concat(text16, text17, text18 + text19 + string_20);
		int num33 = default(int);
		checked
		{
			switch (unchecked((int)array[1]) * -553049)
			{
			case 0:
				num33 = ((Array)(object)"\u0338\u034b\u036d").Length;
				break;
			case 1:
				num33 = -136761;
				break;
			case 2:
				num33 = -664468;
				break;
			}
		}
		char c7 = (char)num33;
		char num34 = c7;
		char c8 = (char)array2[2];
		object[] array27;
		string string_22;
		object[] array28;
		char num35;
		checked
		{
			array27 = new object[unchecked((int)num34) * unchecked((int)c8)];
			string_22 = "⨬";
			array28 = new object[5];
			num35 = array[Convert.ToInt32("1", 8)];
		}
		char c9 = (char)Convert.ToInt32("28e1", 16);
		array28[(uint)num35] = (int)c9;
		int num36 = array2[2];
		array28[num36] = 2;
		int num37 = array2[0];
		array28[num37] = string.Concat("\u001aS", char.ToString('G') + char.ToString('|') + "\u0001\0\a");
		array28[3] = false;
		array28[4] = (byte)checked(1 * CrossProcess) != 0;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_22, array28);
		string value = string_22;
		char c10 = array[4];
		array27[Convert.ToInt32(value, c10)] = (byte)(array6[Marshal.SizeOf(typeof(Vector128__1)) - 95267] % (59697 + (Convert.ToInt32("101101100000101000001000000", 2) >> 10))) != 0;
		string string_23 = "棇";
		object[] array29 = new object[Convert.ToInt32(char.ToString('1') + "01", System_002ECollections_002EObjectModel)];
		int conv_Ovf_U = Conv_Ovf_U8;
		array29[conv_Ovf_U] = false;
		array29[(uint)array[2]] = (char)(29214 >> Convert.ToInt32("10", 2));
		array29[_003CModule_003E.ActivityOptions[0]] = (char)(Convert.ToInt32("1283", 16) | 'ȇ');
		int num38 = ((array[16] <= -617946) ? 414493 : 3);
		array29[num38] = 10665;
		char c11 = (char)_003CModule_003E.ActivityOptions[3];
		array29[(uint)c11] = Convert.ToInt32("1001011110101110", 2) >> 3;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_23, array29);
		IntPtr intPtr2 = (nint)((Array)(object)string_23).LongLength;
		string text20 = char.ToString((char)_003CModule_003E.get_PositiveSign[30]);
		string string_24 = char.ToString('箿') + "箱篯";
		_003CModule_003E.TAIWANLUNISOLAR(ref string_24, new object[2]
		{
			(int)array[5],
			"cɰ"
		});
		array27[(nint)intPtr2] = Convert.ToInt32(text20 + string_24, 865242400 / array2[8]);
		char c12 = (char)(_003CModule_003E.KeyValuePair__2[0] & (1 << Marshal.SizeOf(typeof(UseHebrewParsing))));
		int num39 = c12;
		int num40 = ExtractNarrowingLower % -606386;
		string string_25 = string.Concat(char.ToString('༽') + char.ToString('༽') + "༽༽༽", char.ToString('༽') + "༽༽", "༽༽༽༽༽༼༽༼༽" + "༽༼༽༼༽༼༼༼༽༼༽༽༼༽༼");
		object[] array30 = new object[checked(-709913 + Convert.ToInt32("10101101010100011111", 2))];
		array30[0] = Marshal.SizeOf(typeof(SetSource));
		array30[865577 + Convert.ToInt32("37774545330", 8)] = Convert.ToInt32(char.ToString('1') + "07", 8);
		array30[2] = 'ǈ';
		array30[1954 >> Marshal.SizeOf(typeof(VT_VOID))] = false;
		array30[Marshal.SizeOf(typeof(ReadDecimal)) / 412572636] = (char)Convert.ToInt32("b4", 16);
		array30[5] = string.Concat(char.ToString((char)_003CModule_003E.KeyValuePair__2[223]), char.ToString('ښ') + "F\u0003t");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_25, array30);
		array27[num39] = checked(num40 - Convert.ToInt32(string_25, 2));
		_003CModule_003E.GetMaxByteCount(ref string_21, array27);
		sourceException3.Add(folderPath + string_21);
		List<string> sourceException4 = SourceException;
		string text21 = char.ToString(array[17]);
		string text22 = char.ToString('퍻');
		string string_26 = "鑝鑢";
		object[] array31 = new object[Convert.ToInt32("2", CharCount)];
		array31[get_Tool - Convert.ToInt32("3c0a5", 16)] = 9781;
		array31[Convert.ToInt32("1", 16)] = (int)array[(uint)array[8]];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_26, array31);
		string text23 = text21 + text22 + string_26;
		string text24 = char.ToString((char)Convert.ToInt32("1101" + "001" + "101000010", 2));
		string string_27 = string.Concat(char.ToString((char)Convert.ToInt32("1011001101011100", 2)), char.ToString('덏') + "댎덽");
		object[] array32 = new object[ICollection];
		array32[Convert.ToInt32("0", 2)] = Convert.ToInt32(char.ToString('1') + "d2b", 16);
		array32[Marshal.SizeOf(typeof(UseHebrewParsing))] = (char)(User * -33);
		int num41 = ((-98158 >= Convert.ToInt32("e428b", 16)) ? (-223493) : 2);
		array32[num41] = '⍧';
		array32[3] = _003CModule_003E.get_PositiveSign[75];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_27, array32);
		string text25 = text24 + string_27;
		string text26 = char.ToString('퍈');
		string string_28 = string.Concat(char.ToString('鈉'), char.ToString('鈛') + "鈘鈎鈝");
		object[] array33 = new object[(Convert.ToInt32("37777674223", 8) >= array2[28]) ? (-366771) : 4];
		array33[Convert.ToInt32("0", 16)] = (char)checked(_003CModule_003E.KeyValuePair__2[224] - -900775);
		array33[Marshal.SizeOf(typeof(UseHebrewParsing))] = Convert.ToInt32("10111110110001001001", 2) - 778819;
		array33[checked(-251424 - Convert.ToInt32("11111111111111000010100111011110", 2))] = (char)(Convert.ToInt32("3373", 8) & 'ڡ');
		char c13 = (char)Convert.ToInt32("0", 2);
		array33[3] = (byte)c13 != 0;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_28, array33);
		string text27 = string_28;
		string string_29 = string.Concat("觹觀", "觓觬觹觮觽" + "覼觏觨觽觾觰觹");
		object[] array34 = new object[3];
		int conv_Ovf_U2 = Conv_Ovf_U8;
		int num42 = _003CModule_003E.KeyValuePair__2[225];
		array34[conv_Ovf_U2] = num42;
		int num43 = _003CModule_003E.ActivityOptions[189];
		array34[1] = (char)num43;
		array34[1210756254 / Marshal.SizeOf(typeof(Medium))] = (byte)Convert.ToInt32("0", _003CModule_003E.get_PositiveSign[3]) != 0;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_29, array34);
		string string_30 = string.Concat(text23, text25, text26 + text27 + string_29);
		int num44 = ((-63893 < ((array[18] <= -55369) ? 417209 : 206899)) ? (-1) : 898213);
		object[] array35 = new object[-2 * num44];
		string string_31 = "붦";
		object[] obj = new object[4]
		{
			Marshal.SizeOf(typeof(JittedMethodILToNativeMapKeyword)) + array2[29],
			null,
			null,
			null
		};
		char num45 = array[2];
		char c14 = (char)_003CModule_003E.ActivityOptions[102];
		obj[(uint)num45] = (int)c14;
		char c15 = (char)Convert.ToInt32("2", 8);
		obj[(int)c15] = '浽';
		obj[3] = char.ToString((char)Convert.ToInt32("201", 8)) + char.ToString((char)Convert.ToInt32("10100001", 2)) + "Sa";
		_003CModule_003E.TAIWANLUNISOLAR(ref string_31, obj);
		array35[Convert.ToInt32(string_31, 2)] = ~Cond_Branch;
		array35[sizeof(sbyte)] = get_IsAssembly;
		_003CModule_003E.GetMaxByteCount(ref string_30, array35);
		sourceException4.Add(folderPath + string_30);
		List<string> sourceException5 = SourceException;
		string text28 = char.ToString((char)((FileAttributes >= 907461) ? 4294626985u : '\uee76'));
		string text29 = char.ToString((char)(0xFFFBAD20u ^ (uint)array2[30]));
		string string_32 = string.Concat("痌痌", char.ToString('痄') + char.ToString('痏') + "痆痿");
		object[] array36 = new object[Convert.ToInt32(char.ToString('1') + "01", 2)];
		array36[0] = (char)((uint)Convert.ToInt32("cc972", 16) ^ 0xCDAC4u);
		array36[(uint)array[2]] = 2651;
		array36[2] = '\u009b';
		array36[GenericEqualityComparer__1] = false;
		array36[Marshal.SizeOf(typeof(IsValidText))] = "恫ᱲ";
		_003CModule_003E.TAIWANLUNISOLAR(ref string_32, array36);
		string text30 = text28 + text29 + string_32;
		string text31 = char.ToString('\uee69');
		string text32 = char.ToString((char)array2[9]);
		string string_33 = char.ToString('䧻') + "䧦䧤";
		object[] obj2 = new object[2]
		{
			(char)Convert.ToInt32(char.ToString('7') + "6750", array[4]),
			null
		};
		char crossProcess = (char)CrossProcess;
		obj2[(uint)crossProcess] = (int)array[Convert.ToInt32("7", 16)];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_33, obj2);
		string text33 = text31 + text32 + string_33;
		string string_34 = string.Concat("黠黙", char.ToString('黐') + char.ToString('黶') + "黠黷");
		object[] array37 = new object[Convert.ToInt32(char.ToString('1') + "01", Convert.ToInt32("10", 2))];
		int num46 = Convert.ToInt32("0", 16);
		int num47 = default(int);
		switch (checked(1 * Convert.ToInt32("1", 16)))
		{
		case 0:
			num47 = 137346;
			break;
		case 1:
			num47 = 2980;
			break;
		}
		array37[num46] = num47;
		array37[1] = 5286;
		array37[HideScheduler * -1] = string.Concat(char.ToString('ɻ'), char.ToString('\v') + ";`");
		array37[Marshal.SizeOf(typeof(MdSigCallingConvention)) % 6] = 19780;
		array37[Convert.ToInt32(char.ToString('1') + "00", 2)] = false;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_34, array37);
		string text34 = string_34;
		string string_35 = string.Concat(char.ToString('\ud91c'), "\ud978\ud95d", "\ud948\ud95d\ud960" + "\ud978\ud959\ud95a\ud95d\ud949\ud950\ud948");
		object[] array38 = new object[3];
		array38[0 % Convert.ToInt32("37776270205", 8)] = 'ர';
		array38[Convert.ToInt32("1", 8)] = '⩝';
		array38[2] = 265;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_35, array38);
		string string_36 = string.Concat(text30, text33, text34 + string_35);
		char c16 = (char)(0x3C759u ^ (uint)Marshal.SizeOf(typeof(GetBits)));
		object[] array39 = new object[(int)c16];
		string string_37 = "垉";
		object[] array40 = new object[3];
		array40[0] = char.ToString('\u2fed') + "ŗſ";
		array40[Convert.ToInt32("1", 16)] = (byte)((Array)(object)string.Empty).Length != 0;
		array40[(nint)((Array)(object)"\u033a\u034f").LongLength] = string.Concat(char.ToString('ᾶ'), char.ToString('Ѵ') + "\u0089C");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_37, array40);
		int num48 = Convert.ToInt32(string_37, checked(CharCount * Convert.ToInt32("1", 8) * CrossProcess));
		string string_38 = "꾲긩";
		object[] array41 = new object[(nint)((Array)(object)(char.ToString('\u032c') + "\u0354\u033b\u0308")).LongLength];
		int num49 = array2[1];
		array41[num49] = Convert.ToInt32("ff", 16) & 0xFF;
		array41[1] = 228;
		array41[array2[31] + 88146] = 42240;
		array41[GenericEqualityComparer__1] = 1614;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_38, array41);
		string text35 = string_38;
		string text36 = char.ToString((char)((uint)Convert.ToInt32("1001100010111110100", 2) ^ 0x4C58Du));
		string string_39 = char.ToString('娇') + "娕娒";
		object[] array42 = new object[3];
		array42[_003CModule_003E.ActivityOptions[1]] = 3394;
		array42[1] = string.Concat(char.ToString('\u085f'), char.ToString('᭴') + "ǫ]ĭ");
		array42[(nint)((Array)(object)"\u036c.").LongLength] = _003CModule_003E.ActivityOptions[array2[16]];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_39, array42);
		array39[num48] = string.Concat(text35, text36 + string_39);
		int num50 = Marshal.SizeOf(typeof(IsTvOS));
		string text37 = char.ToString((char)(((Convert.ToInt32("422f", 16) < HeapSizeBytes) ? 78782952 : 855641) / Convert.ToInt32(char.ToString('5') + "7242", 8)));
		string text38 = char.ToString((char)((Convert.ToInt32("37776771133", 8) + 267448) * 4));
		string string_40 = "喥弄";
		object[] array43 = new object[6];
		array43[(uint)array[CrossProcess]] = -381239 + array2[32];
		array43[sizeof(bool)] = Byte01;
		array43[2] = char.ToString((char)Convert.ToInt32("1000001111100", 2)) + "ش\u030f";
		array43[Convert.ToInt32("3", 8)] = false;
		array43[ICollection] = 5580;
		int num51;
		int num52 = default(int);
		checked
		{
			array43[432661 + Convert.ToInt32("37776262760", 8)] = 1675;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_40, array43);
			array39[num50] = text37 + text38 + string_40;
			num51 = 1424 >> (-459775 ^ ComputeHash32OrdinalIgnoreCase);
			switch (unchecked(-600080 % Convert.ToInt32("fffc5660", 16)) - (Convert.ToInt32("3241560", 8) + -989248))
			{
			case 0:
				num52 = array2[10];
				break;
			case 1:
				num52 = 227897;
				break;
			}
		}
		array39[num51] = (char)checked(-59 * num52);
		int num53;
		int num55 = default(int);
		checked
		{
			num53 = (((0x2400 | array2[33]) < -674915) ? Convert.ToInt32("11111111111101001001101001000101", 2) : (Marshal.SizeOf(typeof(DaylightName)) * unchecked((int)array[10])));
			int num54 = default(int);
			switch (Convert.ToInt32("37777550210", 8) - -77688)
			{
			case 0:
				num54 = 557360;
				goto IL_22b1;
			case 1:
				num54 = Convert.ToInt32("11111111111101000011011101101000", 2);
				goto default;
			default:
				switch (num54 + -557360)
				{
				case 0:
					break;
				default:
					goto end_IL_2275;
				}
				goto IL_22b1;
			case 2:
				{
					num54 = -68999;
					break;
				}
				IL_22b1:
				num55 = Convert.ToInt32("101111111001111111", 2) & 0x26B4F;
				break;
				end_IL_2275:
				break;
			}
		}
		int num56 = num53 - num55;
		string text39 = char.ToString((char)(Convert.ToInt32("ec153", 16) + -966939));
		string text40 = char.ToString('7');
		string string_41 = "⩐⨂";
		object[] array44 = new object[4 & Convert.ToInt32("5", 16)];
		array44[checked(Convert.ToInt32("e8271", 16) + -950897)] = string.Concat(char.ToString('Ō'), char.ToString((char)SetHandled), char.ToString('ɮ') + "\u001du¤");
		array44[sizeof(sbyte)] = (char)Marshal.SizeOf(typeof(GetDecimal));
		array44[sizeof(char)] = (byte)array2[Marshal.SizeOf(typeof(UseHebrewParsing))] != 0;
		array44[3] = 8517;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_41, array44);
		string value2 = text39 + text40 + string_41;
		string string_42 = string.Concat(char.ToString('䝎'), char.ToString((char)MinusOne), char.ToString('䝏') + "䝏䝏");
		object[] array45 = new object[(uint)array[3]];
		array45[Convert.ToInt32("1", 2) & 0] = 531;
		array45[1] = 1487 * Convert.ToInt32("10", 2);
		array45[2] = 661;
		int num57 = _003CModule_003E.KeyValuePair__2[Conv_Ovf_U8];
		int num58 = Convert.ToInt32("10111100000010", 2);
		array45[num57] = num58;
		array45[Convert.ToInt32("7", 16) & 4] = string.Concat("ޡh", char.ToString('\u001a') + char.ToString('\0') + "\u000e\u0006");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_42, array45);
		array39[num56] = Convert.ToInt32(value2, Convert.ToInt32(string_42, sizeof(char)));
		int num59 = array6[4] - _003CModule_003E.Dequeue[20];
		int num60 = array6[5];
		int num61 = ((63567 == Convert.ToInt32(char.ToString('1') + "101" + "000001100111", 2)) ? 119223 : (-3));
		array39[num59] = checked(num60 * num61);
		char c17 = (char)Convert.ToInt32(char.ToString('1') + char.ToString('2') + "75", 8);
		char num62 = c17;
		string string_43 = "ば";
		object[] array46 = new object[-293875 + _003CModule_003E.ActivityOptions[190]];
		int num63 = Convert.ToInt32("762453", 8) - 255275;
		int num64 = _003CModule_003E.get_PositiveSign[203];
		array46[num63] = num64;
		array46[array2[2]] = 1766;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_43, array46);
		int num65 = (int)num62 >> Convert.ToInt32(string_43, array2[6]);
		int num66 = Convert.ToInt32("1010100011011010011111101111010", 2);
		array39[num65] = ((-85098 < num66 / 4314) ? ((byte)(SysLogPriority - 13943 * _003CModule_003E.KeyValuePair__2[20]) != 0) : ((byte)(0xB9E07u ^ (uint)(Marshal.SizeOf(typeof(WriteInt16BigEndian)) >> 1)) != 0));
		_003CModule_003E.GetMaxByteCount(ref string_36, array39);
		sourceException5.Add(folderPath2 + string_36);
		List<string> sourceException6 = SourceException;
		string text41 = char.ToString((char)checked(13109 * array2[2]));
		string string_44 = string.Concat("睁睱", char.ToString('睢'), char.ToString('睵') + "睦睐" + "睬睥睷睴睢睱睦睟");
		object[] array47 = new object[6];
		array47[220623 + Convert.ToInt32("11111111111111001010001000110001", 2)] = Convert.ToInt32(char.ToString('1') + "7732", array[4]);
		array47[checked(array2[2] * 1)] = (char)(-589040 + SpecifyKind);
		array47[Convert.ToInt32("10", 2)] = false;
		array47[-23054 - get_UseStd3AsciiRules] = 2435;
		nint num67 = (nint)((Array)(object)"\u0339\u0347\u0331\u0306\u0349\u035c\u0303\u0305\u0351\u0365\u0355\u030c\u0365\u0344\u0347\u035c\u0346\u036f\u0359\u0347").LongLength % 8;
		char c18 = (char)Marshal.SizeOf(typeof(Begin));
		array47[num67] = (int)c18;
		array47[~ExecuteAssemblyByName] = "\u0b47Ɍ";
		_003CModule_003E.TAIWANLUNISOLAR(ref string_44, array47);
		string text42 = string_44;
		string string_45 = string.Concat(char.ToString('糷') + char.ToString('糇') + "糔糃糐", char.ToString('粘') + "糷糇糚糂", "糆糐糇糩" + "糠糆糐糇粕糱糔糁糔糩糱糐糓糔糀糙糁");
		object[] array48 = new object[2];
		array48[Convert.ToInt32("0", ((Array)(object)"\u036b\u0337.\u035b\u033e\u0332\u033a.\u036d\u032a\u0332\u0347\u0341\u0304\u0311\u0353").Length)] = _003CModule_003E.get_PositiveSign[(uint)array[12]];
		array48[Convert.ToInt32("1", sizeof(double))] = array2[array2[15]];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_45, array48);
		string string_46 = string.Concat(text41, text42 + string_45);
		object[] array49 = new object[(uint)array4[0]];
		int num68 = 0 % Convert.ToInt32(char.ToString('3') + char.ToString('7') + "774162223", 8) * _003CModule_003E.LoadVector128[32];
		int num69 = _003CModule_003E.CalendarType[_003CModule_003E.KeyValuePair__2[30]];
		int num70 = ((((AbsoluteCompareGreaterThanOrEqual > 817651) ? 1 : 0) != Conv_Ovf_U8) ? Convert.ToInt32("fffb6cda", 16) : 8);
		checked
		{
			array49[num68] = num69 * (num70 >> unchecked((int)array[2]));
		}
		char c19 = (char)array6[Convert.ToInt32("37777254666", 8) ^ -173642];
		int num71 = c19;
		string string_47 = "䆍䃮";
		object[] array50 = new object[5];
		array50[Convert.ToInt32("0", 16)] = 'ⴿ';
		array50[1] = (char)Convert.ToInt32(char.ToString('1') + "130", 8);
		array50[2] = array2[12];
		array50[3] = "ܙP";
		array50[4] = string.Concat(char.ToString('ʍ'), char.ToString((char)Convert.ToInt32("1001", 2)), char.ToString('w') + char.ToString('@') + "))");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_47, array50);
		string text43 = string_47;
		string text44 = char.ToString((char)Convert.ToInt32("0", Convert.ToInt32("2", 8)));
		string string_48 = char.ToString((char)UnorderedNotLessThanOrEqualSignaling) + "浙浟";
		object[] array51 = new object[2];
		array51[_003CModule_003E.ActivityOptions[1]] = Convert.ToInt32(char.ToString('5') + char.ToString('0') + "757", 8);
		array51[1] = -208171 ^ Convert.ToInt32("37777144676", 8);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_48, array51);
		array49[num71] = string.Concat(text43, text44 + string_48);
		int[] loadVector2 = _003CModule_003E.LoadVector128;
		string string_49 = "ۆ";
		object[] array52 = new object[4];
		array52[array2[CrossProcess]] = (char)('Ş' & Convert.ToInt32("627", 8));
		array52[Marshal.SizeOf(typeof(UseHebrewParsing))] = 196448142 / _003CModule_003E.get_PositiveSign[204];
		int num72 = array2[Convert.ToInt32("0", 8)];
		int num73 = default(int);
		switch (array2[35] - O_RDONLY)
		{
		case 0:
			num73 = -584623;
			break;
		case 1:
			num73 = 504;
			break;
		}
		array52[num72] = (char)num73;
		array52[3] = Convert.ToInt32("87", Convert.ToInt32("20", 8));
		_003CModule_003E.TAIWANLUNISOLAR(ref string_49, array52);
		array49[loadVector2[Convert.ToInt32(string_49, Marshal.SizeOf(typeof(ENODATA)) << 3)]] = 'ఘ';
		int num74 = ((-54132 < MinNumberPairwiseScalar) ? (-99515) : Convert.ToInt32("11111111111100111000010111110111", 2));
		int num75 = ((((num74 > 694445) ? 1 : 0) != (Convert.ToInt32("11111111111110000001110100001010", 2) ^ Convert.ToInt32("fff81d0a", 16))) ? Convert.ToInt32(char.ToString('a') + char.ToString('0') + "edb", 16) : (-4));
		array49[~num75] = _003CModule_003E.Dequeue[get_DateTime & (1314844614 / _003CModule_003E.KeyValuePair__2[227])];
		string string_50 = "暓";
		int num76 = default(int);
		switch (-294537 - Convert.ToInt32("11111111111110111000000101110111", 2))
		{
		case 0:
			num76 = 6;
			break;
		case 1:
			num76 = 737917;
			break;
		case 2:
			num76 = array2[36];
			break;
		}
		object[] array53 = new object[num76];
		array53[_003CModule_003E.ActivityOptions[1]] = (byte)(0xA132Au ^ (uint)_003CModule_003E.get_PositiveSign[205]) != 0;
		int num77 = default(int);
		switch (checked(Convert.ToInt32("fff917ad", 16) + 452692))
		{
		case 0:
			num77 = Convert.ToInt32("fffbf1e8", 16);
			break;
		case 1:
			num77 = 1;
			break;
		case 2:
			num77 = 937271;
			break;
		}
		array53[num77] = 'ņ';
		array53[Convert.ToInt32("fffffffe", 16) * -1] = ')';
		array53[(-14436 != Convert.ToInt32("ffffc79c", 16)) ? (-527553) : 3] = -442131 ^ Convert.ToInt32("37776214431", 8);
		array53[4] = char.ToString('ԁ') + char.ToString('ø') + "Ȟ\u001c";
		array53[5] = string.Concat("Ɣ;", char.ToString('¶') + "\u0019\u0006a\b");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_50, array53);
		int num78 = Convert.ToInt32(string_50, 2) | 4;
		string text45 = char.ToString((char)Convert.ToInt32("31", 16));
		string text46 = char.ToString((char)Marshal.SizeOf(typeof(get_BaseDirectory)));
		string string_51 = "\ue18d\ue18b";
		object[] array54 = new object[6];
		array54[Conv_Ovf_U8] = 43791;
		array54[3792710 >> Convert.ToInt32("10101", 2)] = string.Concat(char.ToString('\u00b4'), char.ToString('\u02e7') + "ȹÉ");
		array54[2] = 3165;
		array54[15 % Convert.ToInt32("6", 8)] = '↋';
		array54[4] = (byte)((Array)(object)string.Empty).Length != 0;
		array54[5] = string.Concat(char.ToString('F'), char.ToString((char)FastMod), char.ToString('\u0083') + "\u0017ÏL");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_51, array54);
		string value3 = text45 + text46 + string_51;
		int num79 = Convert.ToInt32("c004", 16);
		array49[num78] = (char)Convert.ToInt32(value3, checked(-49140 + num79));
		_003CModule_003E.GetMaxByteCount(ref string_46, array49);
		sourceException6.Add(folderPath2 + string_46);
		List<string> sourceException7 = SourceException;
		string text47 = char.ToString((char)checked(_003CModule_003E.get_PositiveSign[206] + 950885));
		string string_52 = string.Concat(char.ToString((char)Marshal.SizeOf(typeof(LocaleNumberData))), "\ue9dc\ue9d3", "\ue9d9\ue9d8" + "\ue9c5\ue9e1\ue9e4\ue9dc\ue9d3");
		object[] array55;
		checked
		{
			array55 = new object[unchecked((nint)((Array)(object)"\u0306\u032b").LongLength) * array2[2]];
			array55[0] = get_AssemblyFullName;
		}
		array55[1] = (char)array2[13];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_52, array55);
		string text48 = text47 + string_52;
		string string_53 = char.ToString('䦬') + "䦭䦰";
		object[] array56 = new object[5310330 >> (int)((Array)(object)"\u0331\u035c\u030a.\u036e\u036e\u0303\u0352.\u033b\u0359\u0351\u0367\u0331\u0356\u032f.\u0347\u0348\u0321").LongLength];
		array56[0] = CollectionsMarshal % _003CModule_003E.KeyValuePair__2[106];
		array56[Marshal.SizeOf(typeof(UseHebrewParsing))] = 155;
		array56[Convert.ToInt32("10", Convert.ToInt32("10", 2))] = Convert.ToInt32("1001110" + "001000011", 2);
		array56[3] = true;
		array56[sizeof(float) * 1] = (byte)array[1] != 0;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_53, array56);
		string text49 = string_53;
		string string_54 = string.Concat(char.ToString('\ude30') + "\ude00\ude1d\ude05\ude01", "\ude17\ude00\ude2e\ude27\ude01\ude17" + "\ude00\ude52\ude36\ude13\ude06\ude13\ude2e\ude36\ude17\ude14\ude13\ude07\ude1e\ude06");
		object[] obj3 = new object[3] { 95, null, null };
		string string_55;
		checked
		{
			int num80 = default(int);
			switch (Convert.ToInt32("11111111111101011110100010110111", 2) - -661321)
			{
			case 0:
				num80 = Marshal.SizeOf(typeof(Meta));
				break;
			case 1:
				num80 = -633641;
				break;
			}
			obj3[1] = num80;
			obj3[Convert.ToInt32("10", sizeof(short))] = Convert.ToInt32("11111111111111111111010110101001", 2) * -1;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_54, obj3);
			string_55 = string.Concat(text48, text49 + string_54);
		}
		char c20 = (char)set_Infrastructure;
		object[] array57 = new object[(int)c20 >> 35 % (7 << Convert.ToInt32("1", 16))];
		int requestOptional = RequestOptional;
		string string_56 = string.Concat("뒡뒥", char.ToString('뒥'), char.ToString('뒥') + char.ToString('뒥') + "뒥뒥뒥뒥뒥뒥");
		object[] array58 = new object[(nint)((Array)(object)(char.ToString('.') + "\u030a\u0344")).LongLength];
		array58[Convert.ToInt32("0", 16) << 13] = 'ꌾ';
		array58[sizeof(sbyte)] = (byte)((nint)((Array)(object)string.Empty).LongLength / 657922217) != 0;
		array58[Marshal.SizeOf(typeof(get_Trademark)) + Convert.ToInt32("fff731ca", 16)] = char.ToString('\u0dff') + char.ToString('\u0300') + "6\u001f";
		_003CModule_003E.TAIWANLUNISOLAR(ref string_56, array58);
		array57[requestOptional] = (byte)(~Convert.ToInt32(string_56, CharCount)) != 0;
		int num81 = array6[0 % (-34939 & Convert.ToInt32("11111111111100101101101101000101", 2))];
		int num82;
		if (checked(495294 + _003CModule_003E.KeyValuePair__2[228]) < Convert.ToInt32(char.ToString('f') + char.ToString('f') + "fe66be", 16))
		{
			num82 = ((-53639 < Convert.ToInt32("11111111111111111100111100011111", 2)) ? 763039 : Convert.ToInt32("fff71799", 16));
		}
		else
		{
			int num83 = (((nint)1 != (nint)((Array)(object)string.Empty).LongLength) ? 222999 : array2[37]);
			num82 = num83;
		}
		string string_57 = string.Concat(char.ToString((char)Convert.ToInt32("1010010010101101", 2)), char.ToString('꒭') + char.ToString('꒬') + "꒭꒭꒬", "꒭꒭꒬" + "꒬꒭꒭꒬꒭꒭꒬꒬꒬");
		char c21 = (char)Marshal.SizeOf(typeof(IsValidText));
		object[] array59 = new object[(uint)c21];
		array59[0] = Convert.ToInt32("100" + "0001100001101", 2);
		array59[1] = CompilerGeneratedAttribute;
		int num84;
		int num85;
		checked
		{
			array59[Convert.ToInt32("3024647", 8) - 797093] = string.Concat(char.ToString('\u031c'), char.ToString('É') + "S×u");
			array59[_003CModule_003E.KeyValuePair__2[0]] = '᭴';
			_003CModule_003E.TAIWANLUNISOLAR(ref string_57, array59);
			array57[num81] = num82 ^ Convert.ToInt32(string_57, 2);
			num84 = unchecked(_003CModule_003E.ActivityOptions[58] % (Convert.ToInt32("7fffc", 16) & 0x6F366)) + unchecked(-1009566 - _003CModule_003E.ActivityOptions[59]);
			num85 = ((Convert.ToInt32(char.ToString('1') + "52311", array[4]) <= array2[14]) ? (-808956) : ((-6575 >= Convert.ToInt32("ebcce", 16)) ? 17927 : Convert.ToInt32("45567c30", 16)));
		}
		array57[num84] = num85 / 594732;
		string string_58 = "⩣";
		object[] array60 = new object[1646193060 / array2[38]];
		array60[Convert.ToInt32("1", 8) & 0] = (byte)((Array)(object)string.Empty).Length != 0;
		array60[1] = 300302 + get_Types;
		array60[System_002ECollections_002EObjectModel] = InsertScalar >> 17;
		array60[(nint)((Array)(object)"\u033c\u0324\u031d").LongLength & 3] = 9867;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_58, array60);
		char c22 = (char)Convert.ToInt32(string_58, 8);
		array57[(int)c22] = '솯';
		_003CModule_003E.GetMaxByteCount(ref string_55, array57);
		sourceException7.Add(folderPath2 + string_55);
	}

	public unsafe static List<string> RawDefaultValue()
	{
		char[] array = new char[13]
		{
			'\0', '\u0001', '\u0005', '䡞', '\uef02', '\u07ae', '\u0002', '\u0010', '\a', '\r',
			'翳', '槥', 'ö'
		};
		int[] array2 = new int[25]
		{
			2, 0, 3, 7, 504, 3372, 850, 173490, 25431, 9294,
			81539, 5, 6194, 5767, 37759, 7999, -98451, -386886, 451166, -168124,
			125592, 25907505, 101648435, -32, 316961
		};
		char[] array3 = new char[1];
		array3[Convert.ToInt32("0", 16)] = 'ⰼ';
		char[] array4 = array3;
		int[] array5 = new int[(nint)((Array)(object)"\u036b").LongLength];
		int num = ((((array2[12] > Convert.ToInt32("fff71e0b", 16)) ? 1 : 0) == array2[1]) ? (-786079) : 0);
		array5[num] = 1;
		int[] array6 = array5;
		ISymUnmanagedDocumentWriter();
		List<string> list = new List<string>();
		int num4 = default(int);
		int num9 = default(int);
		int num12 = default(int);
		int num17 = default(int);
		int num21 = default(int);
		int num33 = default(int);
		foreach (string item in SourceException)
		{
			if (!Directory.Exists(item))
			{
				continue;
			}
			string text = char.ToString((char)Convert.ToInt32(char.ToString('4') + "59c", 16));
			string string_ = char.ToString('쌡') + "쌂쌎";
			object[] array7 = new object[4];
			array7[Convert.ToInt32("0", 2) / 287884971] = Convert.ToInt32("10" + "1011101111011", 2);
			array7[1] = string.Concat(char.ToString('\u059b'), char.ToString('\u008e') + "ڌ=Jƅ");
			array7[~CriticalHandleZeroOrMinusOneIsInvalid] = Convert.ToInt32(char.ToString('1') + char.ToString('c') + "b4", 16);
			array7[3] = 957;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_, array7);
			string text2 = text + string_;
			string string_2 = "⍉⍄";
			object[] array8 = new object[Convert.ToInt32("10", Convert.ToInt32("2", 8))];
			array8[0] = 25469;
			array8[1] = '\u036b';
			_003CModule_003E.TAIWANLUNISOLAR(ref string_2, array8);
			string text3 = string_2;
			string string_3 = string.Concat("㴊㵹", char.ToString('㵞') + "㵅㵘㵋");
			object[] array9 = new object[30 % Convert.ToInt32("1100", 2)];
			array9[_003CModule_003E.ActivityOptions[(uint)array[1]]] = false;
			int num2 = checked(sizeof(byte) * 1);
			int num3 = ((Convert.ToInt32("37777655310", 8) >= -850502) ? 2394 : Marshal.SizeOf(typeof(SuppressUnmanagedCodeSecurityAttribute)));
			array9[num2] = (char)num3;
			array9[2] = 'ᤓ';
			array9[3] = 3039;
			array9[4] = array[3];
			array9[_003CModule_003E.get_PositiveSign[2]] = 'ɀ';
			_003CModule_003E.TAIWANLUNISOLAR(ref string_3, array9);
			string text4 = string_3;
			string string_4 = string.Concat(char.ToString('雄') + "集雿", char.ToString('雏') + char.ToString('集') + "雕集雏雇雁");
			object[] array10 = new object[Convert.ToInt32("6d58b86c", 16) / 305755154];
			array10[array2[1]] = false;
			array10[Convert.ToInt32("1", Convert.ToInt32("1000", 2))] = 21136;
			array10[checked(263189 - TypeForwardedFromAttribute)] = array2[5];
			IntPtr intPtr = (nint)((Array)(object)(char.ToString('\u034d') + "\u034b\u0366")).LongLength;
			checked
			{
				switch (unchecked((int)array[1]) * sizeof(sbyte))
				{
				case 0:
					num4 = 634989;
					break;
				case 1:
					num4 = 1537;
					break;
				}
			}
			array10[(nint)intPtr] = num4;
			array10[4] = '䦦';
			array10[(nint)((Array)(object)(char.ToString('\u0354') + "\u0319\u0336\u0344\u030d")).LongLength] = string.Concat(char.ToString((char)array2[13]), char.ToString('Ō') + char.ToString('ޥ') + "ºώ");
			_003CModule_003E.TAIWANLUNISOLAR(ref string_4, array10);
			string string_5 = string.Concat(text2, text3, text4 + string_4);
			string text5 = char.ToString((char)array2[6]);
			string text6 = char.ToString((char)Marshal.SizeOf(typeof(TraceLoggingDataCollector)));
			string string_6 = char.ToString((char)array2[14]) + "逜鍵";
			object[] array11 = new object[_003CModule_003E.KeyValuePair__2[array2[1]]];
			array11[0] = string.Concat(char.ToString('崋'), char.ToString('ê') + "\u06e0ċЫ");
			array11[(uint)array[1]] = (byte)(Conv_Ovf_U8 << 14) != 0;
			array11[Convert.ToInt32("10", 2)] = 9767;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_6, array11);
			object[] array12 = new object[(nint)((Array)(object)(text5 + text6 + string_6)).LongLength];
			nint num5 = (nint)((Array)(object)string.Empty).LongLength | (((24586 != _003CModule_003E.ActivityOptions[191]) ? _003CModule_003E.KeyValuePair__2[229] : 173490) ^ array2[7]);
			char c = (char)Marshal.SizeOf(typeof(ReferenceEquals));
			char c2 = ((c == -33122) ? '祿' : ((char)_003CModule_003E.ActivityOptions[1]));
			array12[num5] = (byte)c2 != 0;
			string string_7 = string.Concat(char.ToString('愔') + char.ToString('愐') + "愒愒", char.ToString('愔') + char.ToString('愗') + "愐愕愖愔愓");
			object[] array13 = new object[Convert.ToInt32("11", 2)];
			array13[0] = 22721;
			int num6 = ((83632 == Marshal.SizeOf(typeof(get_Delta))) ? 1 : (-24777));
			array13[num6] = 'ࠋ';
			int num7 = Convert.ToInt32("2", 8);
			array13[num7] = 'Y';
			_003CModule_003E.TAIWANLUNISOLAR(ref string_7, array13);
			array12[Convert.ToInt32(string_7, 40 % Convert.ToInt32("10", 16)) / checked(Convert.ToInt32(char.ToString('6') + char.ToString('f') + "db53c8", 16) + 654598)] = (char)(_003CModule_003E.LoadVector128[Convert.ToInt32(char.ToString('1') + "00001", System_002ECollections_002EObjectModel)] - Marshal.SizeOf(typeof(GetILOffset)));
			int num8 = array2[2] & Convert.ToInt32("3", 8) & 2;
			string text7 = char.ToString('1');
			string string_8 = "鮄鮃";
			object[] array14 = new object[5];
			array14[Convert.ToInt32("0", 16)] = _003CModule_003E.get_PositiveSign[207] * array[8];
			array14[(nint)((Array)(object)"\u0354").LongLength] = string.Concat(char.ToString('\u0361'), char.ToString('?'), char.ToString('\0') + "B ");
			array14[2] = char.ToString('ݝ') + "aƽ";
			array14[_003CModule_003E.KeyValuePair__2[0]] = string.Concat(char.ToString('⿏'), char.ToString('ⵞ') + "ႁж¢");
			array14[Marshal.SizeOf(typeof(OverlappedData)) & 4] = false;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_8, array14);
			array12[num8] = Convert.ToInt32(text7 + string_8, checked(904536 - _003CModule_003E.KeyValuePair__2[64]));
			switch (array2[15] - 689543 + Convert.ToInt32("10100" + "110011001001000", 2))
			{
			case 0:
				num9 = Convert.ToInt32("0", 2);
				break;
			case 1:
				num9 = 864807 - Convert.ToInt32("111100011001001010", 2);
				break;
			}
			int num10 = num9;
			int num11 = ((20290 > AddPairwiseScalar) ? 258716 : 169041);
			switch (checked(num10 * num11))
			{
			case 0:
			{
				string string_9 = "魀魀";
				char c3 = (char)array2[11];
				object[] array15 = new object[(int)c3];
				array15[-881067 + _003CModule_003E.get_PositiveSign[208]] = '⻎';
				array15[CrossProcess] = '↲';
				array15[941887802 / Convert.ToInt32("1c12089d", 16)] = 14537;
				array15[397550 >> Marshal.SizeOf(typeof(LunarCalendar))] = (char)LAHashKeyToTrackers;
				char c4 = (char)Convert.ToInt32("100", 2);
				array15[(int)c4] = char.ToString('\u02d4') + "`1";
				_003CModule_003E.TAIWANLUNISOLAR(ref string_9, array15);
				num12 = Convert.ToInt32(string_9, System_002ECollections_002EObjectModel);
				break;
			}
			case 1:
				num12 = 457640;
				break;
			}
			array12[num12] = _003CModule_003E.LoadVector128[Marshal.SizeOf(typeof(VT_VOID)) & (nint)((Array)(object)("\u0347\u031d\u0347\u0339" + "\u0347.\u0324\u0324\u0311\u033f\u035f")).LongLength];
			string text8 = char.ToString('\u034f');
			string text9 = char.ToString((char)(1949066054 / Marshal.SizeOf(typeof(SEP_HourSuff))));
			string string_10 = "亮䶩";
			object[] array16 = new object[Marshal.SizeOf(typeof(CharSetMask))];
			array16[0] = (char)Convert.ToInt32(char.ToString('1') + "01010100110", 2);
			array16[1] = string.Concat(char.ToString('ᶥ'), "\u05c2ʧ" + "ƚÓ$^");
			array16[2] = checked(EventPipeSessionInfo * -1);
			_003CModule_003E.TAIWANLUNISOLAR(ref string_10, array16);
			IntPtr intPtr2 = (nint)((Array)(object)(text8 + text9 + string_10)).LongLength;
			string text10 = char.ToString('ᖧ');
			string text11 = char.ToString('ᒇ');
			string text12 = char.ToString('۴');
			string string_11 = "㹠さ";
			object[] array17 = new object[2];
			array17[TYPEFLAG_FNONEXTENSIBLE + 477145] = Marshal.SizeOf(typeof(NoPrecision));
			array17[Convert.ToInt32("1", 2)] = Convert.ToInt32(char.ToString('1') + "000" + "1111111111", 2);
			_003CModule_003E.TAIWANLUNISOLAR(ref string_11, array17);
			array12[(nint)intPtr2] = string.Concat(text10, text11, text12 + string_11);
			_003CModule_003E.GetMaxByteCount(ref string_5, array12);
			string path = item + string_5;
			DirectoryInfo directoryInfo = new DirectoryInfo(path);
			char c5 = (char)(Convert.ToInt32("1ae91", 16) % 44090);
			string text13 = char.ToString((char)(int)c5);
			string text14 = char.ToString((char)(AllowTrailingSign - 161386));
			string string_12 = char.ToString((char)Convert.ToInt32("1111100010001011", 2)) + "\uf883\uf885";
			object[] array18 = new object[Marshal.SizeOf(typeof(IsValidText))];
			array18[0] = array[10] & 0x5BA3;
			array18[1] = Convert.ToInt32(char.ToString('4') + "36", 8);
			array18[Marshal.SizeOf(typeof(ENODATA))] = 2617;
			int num13 = _003CModule_003E.KeyValuePair__2[0];
			array18[num13] = string.Concat(char.ToString('ȉ'), char.ToString('䈰') + "Ŀɞ");
			_003CModule_003E.TAIWANLUNISOLAR(ref string_12, array18);
			string string_13 = string.Concat(text13, text14 + string_12);
			char c6 = (char)(array2[Marshal.SizeOf(typeof(CharSetMask))] & Convert.ToInt32("100", 2));
			object[] array19 = new object[(int)c6];
			int num14 = Conv_Ovf_U8 * 447714;
			string string_14 = string.Concat("쇀쇀쇀" + "쇀쇀" + "쇀쇀쇀쇀쇀쇀쇀쇁쇀", "쇁쇁쇁쇀쇁쇁쇁" + "쇀쇁쇁쇁쇁쇀쇀쇀쇁쇀쇀");
			object[] array20 = new object[sizeof(short)];
			array20[0] = (char)Convert.ToInt32(char.ToString('1') + "10" + "0010101111", Convert.ToInt32("10", 2));
			array20[Convert.ToInt32("1", 16)] = "涏㮳";
			_003CModule_003E.TAIWANLUNISOLAR(ref string_14, array20);
			int num15 = num14 % Convert.ToInt32(string_14, 2);
			string string_15 = "섌섍";
			object[] array21 = new object[System_002ECollections_002EObjectModel];
			array21[(uint)array[array2[1]]] = checked(unchecked((int)array[11]) * 1);
			char c7 = (char)Marshal.SizeOf(typeof(UseHebrewParsing));
			array21[(uint)c7] = 22360;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_15, array21);
			string text15 = string_15;
			string string_16 = string.Concat(char.ToString((char)_003CModule_003E.get_PositiveSign[209]), "盡盠" + "盠盠盠盠盡盠盠盡盠");
			object[] array22 = new object[Convert.ToInt32("6", _003CModule_003E.KeyValuePair__2[2])];
			array22[0] = string.Concat("ॲӨ", char.ToString('Ֆ') + "\u009b\u0011)");
			array22[1] = (char)(array2[17] + ELEMENT_TYPE_U1);
			array22[(-51744 > Convert.ToInt32("dc721", 16)) ? 538660 : 2] = false;
			array22[3] = 'ɸ';
			array22[4] = 1638;
			array22[System_002EThreading_002ETasks_002ESources] = 258;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_16, array22);
			string value = text15 + string_16;
			string string_17 = "뇼";
			object[] array23 = new object[checked(_003CModule_003E.ActivityOptions[192] + -672757)];
			array23[(Marshal.SizeOf(typeof(StringSerializer)) > 76694) ? 530587 : 0] = char.ToString('逨') + "çƞ";
			array23[sizeof(bool)] = 7969;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_17, array23);
			array19[num15] = Convert.ToInt32(value, Convert.ToInt32(string_17, 8));
			int num16 = DebuggerVisualizerAttribute + 482678;
			switch (Marshal.SizeOf(typeof(get_Channel)))
			{
			case 138893:
				num17 = 938278682;
				break;
			}
			array19[num16 / (num17 & (TryEnterReadLock | 0x26E27AB8))] = 543;
			string string_18 = "廆";
			object[] array24 = new object[6];
			array24[0] = 20120;
			array24[1] = string.Concat(char.ToString('Ð'), char.ToString('ǁ'), char.ToString('0') + char.ToString('\a') + "\u0018*");
			array24[2] = 'د';
			array24[checked(738042 - _003CModule_003E.ActivityOptions[193])] = (char)IsThreadOwnerTrackingEnabled;
			array24[124492 - _003CModule_003E.get_PositiveSign[210]] = (byte)((Array)(object)string.Empty).Length != 0;
			array24[(uint)array[Convert.ToInt32("2", 16)]] = Convert.ToInt32(char.ToString('4') + "88", 16);
			_003CModule_003E.TAIWANLUNISOLAR(ref string_18, array24);
			int num18 = 1 << Convert.ToInt32(string_18, -429308 + AssemblyLoadEventHandler);
			int num19 = checked(UtcOffset - Convert.ToInt32(char.ToString('3') + char.ToString('1') + "72410", 8));
			int num20 = Convert.ToInt32(char.ToString('c') + "360d", 16);
			switch (0 % Convert.ToInt32("11111111111100111111111001010100", 2))
			{
			case 0:
				num21 = _003CModule_003E.ActivityOptions[194];
				break;
			case 1:
				num21 = System_002EReflection;
				break;
			}
			array19[num18] = num19 + (num20 - num21);
			char c8 = (char)(116093373 - Convert.ToInt32("c8e9c", 16) >> 25);
			char num22 = c8;
			string text16 = char.ToString('\u0f72');
			string text17 = char.ToString((char)ESPIPE);
			string text18 = char.ToString((char)('\u0088' | Convert.ToInt32("101", 8)));
			string text19 = char.ToString((char)_003CModule_003E.ActivityOptions[8]);
			string string_19 = char.ToString((char)Convert.ToInt32("11101001111111", 2)) + "㩿㩹";
			object[] array25 = new object[5];
			array25[Convert.ToInt32("11111111111101001101100010000100", 2) ^ -731004] = checked(Marshal.SizeOf(typeof(IsExpired)) * Convert.ToInt32("1101", 2));
			array25[Convert.ToInt32("11000110011000110000", 2) - 812591] = checked(MultiplyAddScalar + 494561);
			array25[2] = 7315;
			array25[3] = (char)array2[4];
			array25[Convert.ToInt32("4", 16)] = ~BindToField;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_19, array25);
			array19[(uint)num22] = string.Concat(text16, text17, text18 + text19 + string_19);
			_003CModule_003E.GetMaxByteCount(ref string_13, array19);
			FileInfo[] files = directoryInfo.GetFiles(string_13);
			int num23 = RequestOptional * checked(Convert.ToInt32("3777" + "4002014", 8) + unchecked(1127915 % array2[18]));
			while (num23 < files.Length)
			{
				FileInfo fileInfo = files[num23];
				string input = fileInfo.OpenText().ReadToEnd();
				string text20 = char.ToString((char)array2[8]);
				string string_20 = string.Concat(char.ToString('놪'), char.ToString('놁'), char.ToString('뇛') + "놫농");
				object[] array26 = new object[2];
				int conv_Ovf_U = Conv_Ovf_U8;
				int num24 = Convert.ToInt32("133223", 8);
				array26[conv_Ovf_U] = num24;
				array26[1] = string.Concat(char.ToString('\u05ba'), char.ToString('ൖ') + char.ToString('ǻ') + "\u05ccƐ");
				_003CModule_003E.TAIWANLUNISOLAR(ref string_20, array26);
				string text21 = text20 + string_20;
				string string_21 = "崟崙";
				object[] obj = new object[3] { 'Ƽ', null, null };
				int num25 = Marshal.SizeOf(typeof(UseHebrewParsing));
				obj[num25] = string.Concat(char.ToString('㮟'), char.ToString('\u0018') + char.ToString('\u00a0') + "\f\0\u0002");
				obj[2] = false;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_21, obj);
				string text22 = string_21;
				string text23 = char.ToString('捱');
				string text24 = char.ToString('捐');
				string string_22 = string.Concat(char.ToString('\ue9a6') + "\ue9d3\ue9d4\ue9ff\ue9a5", char.ToString('\ue9d5') + "\ue9f3\ue9be\ue9f5\ue9d4\ue9a6\ue9d3\ue9d4\ue9ff\ue9a5\ue9d5\ue9f3\ue9ba\ue9bf\ue9f5");
				object[] array27 = new object[6];
				array27[Conv_Ovf_U8] = Convert.ToInt32(char.ToString('3') + "9a", 16);
				array27[1] = "\u0019Ì";
				array27[2] = false;
				array27[array2[2]] = 445 << Marshal.SizeOf(typeof(UseHebrewParsing));
				array27[4] = Convert.ToInt32("4226160", 8) >> (int)((Array)(object)".\u031c\u0366\u0313\u0365\u0365\u0361\u0318").LongLength;
				array27[-757520 + Convert.ToInt32("2707425", 8)] = string.Concat(char.ToString('≐'), char.ToString('ᬰ') + char.ToString('⓺') + "\u0de4Ø)");
				_003CModule_003E.TAIWANLUNISOLAR(ref string_22, array27);
				string string_23 = string.Concat(text21, text22, text23 + text24 + string_22);
				object[] array28 = new object[_003CModule_003E.LoadVector128[IID]];
				string string_24 = "䪀";
				object[] array29 = new object[Convert.ToInt32("3", 8)];
				array29[0] = array2[Convert.ToInt32("1001", 2)];
				int num26 = checked(416912 + Convert.ToInt32("fff9a371", 16));
				int num27 = Convert.ToInt32("0", 8);
				array29[num26] = (byte)num27 != 0;
				array29[0 | Convert.ToInt32("2", 8)] = '♢';
				_003CModule_003E.TAIWANLUNISOLAR(ref string_24, array29);
				int num28 = Convert.ToInt32(string_24, 80 % (Convert.ToInt32("4", 16) << 3));
				string string_25 = string.Concat("弥弥", "弥弥弥弥弥弥弥" + "弥弥弥弥弥弤弤弥弥弥弥弥弤弤弥弥弤弥弥弤弥弤弤");
				int num29 = ((-96670 <= Convert.ToInt32("fff78007", 16)) ? (-68952) : 4);
				object[] array30 = new object[num29];
				array30[Convert.ToInt32("0", 2)] = false;
				array30[_003CModule_003E.get_PositiveSign[211] ^ _003CModule_003E.KeyValuePair__2[230]] = Marshal.SizeOf(typeof(get_InnerException)) - Convert.ToInt32("1110011000100000000", 2);
				array30[2 & Convert.ToInt32("3", 8)] = get_IsField & 0x17B;
				array30[3] = '啭';
				_003CModule_003E.TAIWANLUNISOLAR(ref string_25, array30);
				int shiftRightAndInsert;
				checked
				{
					array28[num28] = Convert.ToInt32(string_25, ((Array)(object)"\u032d\u0302").Length) + unchecked((-441510 ^ array2[19]) - array[4]);
					shiftRightAndInsert = ShiftRightAndInsert;
				}
				array28[shiftRightAndInsert] = (int)array4[0];
				_003CModule_003E.GetMaxByteCount(ref string_23, array28);
				foreach (Match item2 in Regex.Matches(input, string_23))
				{
					list.Add(item2.Value);
				}
				string string_26 = "굇굌";
				object[] array31 = new object[3];
				array31[-809674 + get_IsDynamicCodeCompiled] = 31538;
				array31[(Convert.ToInt32("32550", 8) >= 853113) ? (-967080) : CrossProcess] = 'ఏ';
				array31[array2[Convert.ToInt32("0", 2)]] = (byte)array2[Convert.ToInt32("1", 2)] != 0;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_26, array31);
				string text25 = string_26;
				string string_27 = char.ToString('딺') + char.ToString('땩') + "딸땩";
				char c9 = (char)Marshal.SizeOf(typeof(ENODATA));
				object[] array32 = new object[(uint)c9];
				array32[0] = Convert.ToInt32("bb67b", 16) >> 14;
				array32[-629587 + Convert.ToInt32("2315524", 8)] = '듚';
				_003CModule_003E.TAIWANLUNISOLAR(ref string_27, array32);
				string text26 = char.ToString((char)Convert.ToInt32(string_27, 16));
				string string_28 = "꧶ꦄ";
				object[] array33 = new object[sizeof(ushort) | 0];
				array33[0] = (char)(VARFLAGS / array2[20]);
				array33[1] = string.Concat(char.ToString((char)_003CModule_003E.ActivityOptions[195]), char.ToString('\t') + char.ToString('\u0484') + "\u008f\u0333P");
				_003CModule_003E.TAIWANLUNISOLAR(ref string_28, array33);
				string text27 = string_28;
				string string_29 = "ꓢꓥ";
				object[] array34 = new object[Convert.ToInt32("6", Convert.ToInt32("10000", 2))];
				array34[0] = char.ToString('\u008f') + char.ToString('\u0004') + "\u0004\t";
				array34[1] = char.ToString('X') + "\u0012Y";
				array34[(nint)((Array)(object)"\u032e\u0323").LongLength] = string.Concat("Ϟ\u0367", char.ToString('ʍ') + "k\u0006\u0006\b");
				int num30 = ((-19338 <= Convert.ToInt32("10111010110011111010", 2)) ? Marshal.SizeOf(typeof(IList)) : (-369529));
				array34[3] = num30;
				array34[Convert.ToInt32(char.ToString('1') + "00", 2)] = char.ToString('ě') + "ǡ\u0093";
				array34[5] = false;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_29, array34);
				string text28 = string_29;
				string string_30 = string.Concat("⇄↞", char.ToString('⇮') + "⇈↋ↇ⇎");
				object[] array35 = new object[3];
				array35[0] = (int)(525 * (nint)((Array)(object)"\u030a").LongLength);
				array35[checked(1 * _003CModule_003E.ActivityOptions[2])] = Convert.ToInt32(char.ToString('5') + "02", 16);
				array35[Convert.ToInt32("a", 16) % 4] = Convert.ToInt32("4c9", 16);
				_003CModule_003E.TAIWANLUNISOLAR(ref string_30, array35);
				string string_31 = string.Concat(text25, text26, text27 + text28 + string_30);
				int num31 = -2 / (Convert.ToInt32("5", 16) % 2);
				int num32 = ((((Convert.ToInt32("1010000101111011011", 2) + -261320 > array2[10]) ? 1 : 0) != Convert.ToInt32("0", Convert.ToInt32("20", 8))) ? 629005 : (-1));
				object[] array36 = new object[num31 * num32];
				switch (-544776 + checked(-317963 - Convert.ToInt32("3777" + "4552755", 8)))
				{
				case 0:
					num33 = checked(Convert.ToInt32("0", 16) * 568330);
					break;
				}
				int num34 = num33;
				char yieldAwaitable = (char)YieldAwaitable;
				string text29 = char.ToString(yieldAwaitable);
				string text30 = char.ToString((char)(1321282755 / array2[21]));
				string string_32 = char.ToString('䏤') + "䏢䏦";
				object[] array37 = new object[Convert.ToInt32("1101000000101000", 2) >> (int)array[9]];
				array37[0] = 1019;
				array37[Convert.ToInt32("1", 2)] = 284;
				int num35 = ((-30565 > Convert.ToInt32("11111111111111111010111001111101", 2)) ? BindingRedirects : array[6]);
				array37[num35] = array[12] * 4;
				array37[3] = (char)Marshal.SizeOf(typeof(CompareNotLessThanOrEqual));
				array37[4] = false;
				array37[System_002EThreading_002ETasks_002ESources] = '\u0ab1';
				_003CModule_003E.TAIWANLUNISOLAR(ref string_32, array37);
				string value2 = text29 + text30 + string_32;
				string string_33 = "⽱";
				object[] array38 = new object[_003CModule_003E.get_PositiveSign[(uint)array[6]]];
				array38[Convert.ToInt32("0", array[6])] = _003CModule_003E.get_PositiveSign[78];
				array38[_003CModule_003E.KeyValuePair__2[231] / array2[22]] = Convert.ToInt32(char.ToString('1') + "71", sizeof(double));
				array38[array2[0]] = 31;
				int num36 = Convert.ToInt32("3", 16);
				array38[num36] = string.Concat(char.ToString('ϋ'), char.ToString((char)Marshal.SizeOf(typeof(UseHebrewParsing))), char.ToString('\0') + "\0\u0002");
				array38[_003CModule_003E.ActivityOptions[3]] = ~array2[23];
				_003CModule_003E.TAIWANLUNISOLAR(ref string_33, array38);
				array36[num34] = Convert.ToInt32(value2, Convert.ToInt32(string_33, ((Array)(object)("\u0326\u0367\u0347\u0327" + "\u0316\u032e\u0320\u036c\u033a\u0355\u0347\u032e\u0358\u0304\u031d\u0353")).Length));
				int num37 = array6[checked(Convert.ToInt32("0", array[7]) * (1247699 - Marshal.SizeOf(typeof(Tuesday))))];
				string text31 = char.ToString((char)ToArray);
				string text32 = char.ToString((char)Marshal.SizeOf(typeof(EditorBrowsableState)));
				string string_34 = "胺肦";
				object[] array39 = new object[4];
				array39[0] = 'ʭ';
				array39[Convert.ToInt32("1", System_002ECollections_002EObjectModel)] = 25314;
				array39[Marshal.SizeOf(typeof(ENODATA))] = 320;
				array39[3] = char.ToString('ष') + "ၓY";
				_003CModule_003E.TAIWANLUNISOLAR(ref string_34, array39);
				array36[num37] = text31 + text32 + string_34;
				_003CModule_003E.GetMaxByteCount(ref string_31, array36);
				foreach (Match item3 in Regex.Matches(input, string_31))
				{
					list.Add(item3.Value);
				}
				int num38 = num23;
				string string_35 = "\ue873";
				object[] array40 = new object[(nint)((Array)(object)(char.ToString('\u0354') + char.ToString('\u0358') + "\u034e\u033c\u0314\u0343")).LongLength];
				array40[array2[24] ^ 0x4D621] = (byte)((Array)(object)string.Empty).Length != 0;
				array40[Convert.ToInt32("1", 2)] = Convert.ToInt32("1101" + "010101", 2);
				array40[0 | sizeof(short)] = 22434;
				array40[3] = string.Concat(char.ToString('Є'), char.ToString('\u0015'), char.ToString('ȣ') + char.ToString('\u0003') + "6\u001a\u0010");
				array40[4] = array[Convert.ToInt32("5", 8)];
				array40[5] = 32510;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_35, array40);
				num23 = num38 + Convert.ToInt32(string_35, checked(Marshal.SizeOf(typeof(Ble_Un)) + Convert.ToInt32("100010001001110010", 2)) ^ (Convert.ToInt32("10000000000100000100", 2) | 0xBA106));
			}
		}
		return list;
	}
}
