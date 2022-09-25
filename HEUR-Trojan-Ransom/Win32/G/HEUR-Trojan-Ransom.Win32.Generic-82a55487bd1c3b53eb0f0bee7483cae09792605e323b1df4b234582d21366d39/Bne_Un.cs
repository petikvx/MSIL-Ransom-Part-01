using System;
using System.IO;
using System.Runtime.InteropServices;

internal class Bne_Un
{
	private string LoadScalarVector128;

	private string D;

	private string Requires;

	private int get_EnforceLegacyJapaneseDateParsing;

	private static int IndentSize/* Not supported: data(03 00 00 00) */;

	private static int Genitive/* Not supported: data(05 00 00 00) */;

	private static int ITypeLib/* Not supported: data(2A 00 00 00) */;

	private static int PE32Plus/* Not supported: data(36 00 00 00) */;

	private static int BeginInvoke/* Not supported: data(ED 00 00 00) */;

	private static int ThreadPoolBoundHandleOverlapped/* Not supported: data(0D 04 00 00) */;

	private static int GetManifestResourceStream/* Not supported: data(01 00 00 00) */;

	private static int PinvokeImpl/* Not supported: data(08 00 00 00) */;

	private static int Machine/* Not supported: data(10 00 00 00) */;

	private static int HashUpdateParity/* Not supported: data(02 00 00 00) */;

	private static int ParamArrayAttribute/* Not supported: data(FF FF FF FF) */;

	private static int CurrencyGroupSeparator/* Not supported: data(24 BB 00 00) */;

	private static int MultiplyExtended/* Not supported: data(41 00 00 00) */;

	private static int Setter/* Not supported: data(FC FB 0C 00) */;

	private static int ExecutionAndPublicationViaConstructor/* Not supported: data(34 B4 FF FF) */;

	private static int ANSICodePage/* Not supported: data(E9 6A 03 00) */;

	private static int GetCharCount/* Not supported: data(04 03 00 00) */;

	private static int SetProvider/* Not supported: data(25 A1 FE FF) */;

	private static int WriteEventErrorCode/* Not supported: data(2B B5 F1 FF) */;

	private static int set_Exclude/* Not supported: data(02 00 00 00) */;

	private static int Item5/* Not supported: data(00 00 00 00) */;

	private static int Launch/* Not supported: data(01 00 00 00) */;

	private static int CancellationPending/* Not supported: data(03 00 00 00) */;

	private static int DateTimeToken/* Not supported: data(04 00 00 00) */;

	private static int Parameters/* Not supported: data(05 00 00 00) */;

	private static int Ldc_I4_0/* Not supported: data(20 00 00 00) */;

	private static int set_YearMonthPattern/* Not supported: data(61 01 00 00) */;

	private static int get_Encoding/* Not supported: data(39 A2 F3 FF) */;

	private static int set_AllInternalsVisible/* Not supported: data(36 FF FF FF) */;

	private static int DecoderReplacementFallback/* Not supported: data(45 44 FE FF) */;

	private static int Intersect/* Not supported: data(F7 AE 0E 00) */;

	private static int GetOrCreateValue/* Not supported: data(11 52 00 00) */;

	private static int lcid/* Not supported: data(AE 02 00 00) */;

	private static int Mul_Ovf_Un/* Not supported: data(53 0D 00 00) */;

	private static int GetAvailableThreads/* Not supported: data(B4 97 FA FF) */;

	private static int EventChannelAttribute/* Not supported: data(C3 44 48 00) */;

	private static int IsBmp/* Not supported: data(A9 FF FF FF) */;

	private static int GlobalCount/* Not supported: data(D1 45 00 00) */;

	private static int MetadataToken/* Not supported: data(3A 68 00 00) */;

	private static int M31/* Not supported: data(83 0E 00 00) */;

	private static int StoreAligned/* Not supported: data(A1 EA 5B 09) */;

	private static int Prelink/* Not supported: data(89 37 00 00) */;

	private static int Created/* Not supported: data(BE 01 00 00) */;

	private static int get_GenericTypeArguments/* Not supported: data(FC FB 0C 00) */;

	private static int __3__name/* Not supported: data(7D 03 00 00) */;

	private static int AllowThousands/* Not supported: data(40 E9 05 00) */;

	private static int Clamp/* Not supported: data(50 04 00 00) */;

	private static int Prefix3/* Not supported: data(63 13 01 00) */;

	private static int IsWaitNotificationRequired/* Not supported: data(DE BC 0A 00) */;

	private static int ComponentGuaranteesAttribute/* Not supported: data(FE FF FF FF) */;

	private static int Exclude/* Not supported: data(10 00 00 00) */;

	private static int get_CanSeek/* Not supported: data(08 00 00 00) */;

	private static int RuntimeModule/* Not supported: data(FF FF FF FF) */;

	private static int Concat/* Not supported: data(FA FF FF FF) */;

	private static int GetNestedType/* Not supported: data(0A 00 00 00) */;

	private static int AndNot/* Not supported: data(3D 00 00 00) */;

	private static int Reduce/* Not supported: data(42 00 00 00) */;

	private static int FindTypes/* Not supported: data(21 00 00 00) */;

	private static int FilterTypeName/* Not supported: data(FB FD BE 13) */;

	private static int TZifHead/* Not supported: data(77 E5 0B 00) */;

	private static int ResolveAssemblyToPath/* Not supported: data(A9 C8 03 00) */;

	private static int DesktopDirectory/* Not supported: data(60 9D BC FF) */;

	private static int idldesc/* Not supported: data(FA CD FA FF) */;

	private static int get_ParameterName/* Not supported: data(92 19 02 00) */;

	private static int UnobservedTaskExceptionEventArgs/* Not supported: data(F0 3F F3 FF) */;

	private static int HasNonZeroTail/* Not supported: data(C5 D9 04 00) */;

	private static int DISPPARAMS/* Not supported: data(8B F3 05 00) */;

	private static int destinationArray/* Not supported: data(08 12 0B 00) */;

	private static int SynchronizationContextAwaitTaskContinuation/* Not supported: data(7C A1 FE FF) */;

	private static int Period/* Not supported: data(FD A6 38 00) */;

	private static int ShiftLeftLogicalSaturateScalar/* Not supported: data(E7 36 A3 22) */;

	private static int ContinueWith/* Not supported: data(4B BC F7 FF) */;

	private static int NoWaiters/* Not supported: data(2F 0F 0F 00) */;

	private static int GetSatelliteAssembly/* Not supported: data(37 07 00 00) */;

	private static int INVOCATION_FLAGS_IS_DELEGATE_CTOR/* Not supported: data(56 69 F2 FF) */;

	private static int MD5/* Not supported: data(9B 53 08 00) */;

	private static int AssumeLocal/* Not supported: data(8F B2 02 00) */;

	private static int DelayPromise/* Not supported: data(89 6B 08 00) */;

	private static int get_TotalSeconds/* Not supported: data(D9 9D F7 FF) */;

	private static int DESCKIND_MAX/* Not supported: data(BF BC 60 03) */;

	private static int U6/* Not supported: data(97 42 06 00) */;

	private static int ComponentParseResult/* Not supported: data(84 A6 0E 00) */;

	private static int M41/* Not supported: data(D6 13 00 00) */;

	private static int Completing/* Not supported: data(4F D0 00 00) */;

	private static int ConsoleApplication/* Not supported: data(E4 12 00 00) */;

	private static int EnableEvent/* Not supported: data(BF FF EF FF) */;

	private static int Add_Ovf/* Not supported: data(47 73 F4 FF) */;

	private static int ExitAnyRead/* Not supported: data(F5 8A 05 00) */;

	private static int __9__10_0/* Not supported: data(69 8F 05 00) */;

	private static int LoaderAllocatorScout/* Not supported: data(AD 88 F4 FF) */;

	private static int EventBuilder/* Not supported: data(D3 3A 04 00) */;

	private static int Switch/* Not supported: data(E6 DA D9 00) */;

	private static int GetParentToken/* Not supported: data(FD 7F 00 00) */;

	private static int GetSByte/* Not supported: data(37 08 00 00) */;

	private static int UnderlyingField/* Not supported: data(38 58 0B 00) */;

	private static int Win32Marshal/* Not supported: data(97 8C FE FF) */;

	private static int Bake/* Not supported: data(7D 62 60 15) */;

	private static int get_PinnedObjectsCount/* Not supported: data(5D 0E EF FF) */;

	private static int PreserveSig/* Not supported: data(ED 49 6C 3D) */;

	private static int CreateInstanceLic/* Not supported: data(E5 FA FA FF) */;

	private static int Tags/* Not supported: data(A0 98 09 00) */;

	private static int ToHexString/* Not supported: data(20 05 0D 00) */;

	private static int MicrosoftTelemetry/* Not supported: data(F7 D2 F2 FF) */;

	private static int VolatileIntPtr/* Not supported: data(08 36 F6 FF) */;

	private static int TryDequeue/* Not supported: data(46 E5 00 00) */;

	private static int AddSaturateScalar/* Not supported: data(36 FE FF FF) */;

	private static int UtcSortPattern/* Not supported: data(34 F8 FF FF) */;

	private static int TraceOperation/* Not supported: data(C3 B8 0A 00) */;

	private static int IsHardwareAccelerated/* Not supported: data(58 9A 7B 44) */;

	private static int Is64BitOperatingSystem/* Not supported: data(50 11 06 00) */;

	private static int TickCount64/* Not supported: data(EA 38 06 00) */;

	private static int PublicProperties/* Not supported: data(7C 95 0B 00) */;

	private static int AssemblyRef/* Not supported: data(12 36 FB FF) */;

	private static int AnsiCodePage/* Not supported: data(7B 78 00 00) */;

	private static int Task_Start_AlreadyStarted/* Not supported: data(EB 44 F8 FF) */;

	private static int Arg_TypeNotSupported/* Not supported: data(1D BB 07 00) */;

	private static int LF/* Not supported: data(3E DA 50 24) */;

	private static int Local/* Not supported: data(BC FF FF FF) */;

	private static int StartupHookNameOrPath/* Not supported: data(59 1C 0D 00) */;

	private static int Action__15/* Not supported: data(64 1C DC DB) */;

	private static int Start/* Not supported: data(DD 3E FF FF) */;

	private static int RecursiveWriteCount/* Not supported: data(AD 72 FF FF) */;

	private static int Func__8/* Not supported: data(6A 2D 00 00) */;

	private static int LoaderAllocator/* Not supported: data(83 BF 03 00) */;

	private static int PropertyValue/* Not supported: data(E8 C8 07 00) */;

	public unsafe Bne_Un(string string_0, int int_0)
	{
		char[] array = new char[1] { '\u0004' };
		int[] array2 = new int[9] { 0, 3, 9635, -478183, 85986, 1312399711, -55743, -864391, -1766464 };
		int[] array3 = new int[Convert.ToInt32("1", 8)];
		array3[0 / FilterTypeName] = 3261;
		int[] array4 = array3;
		base._002Ector();
		LoadScalarVector128 = Environment.GetFolderPath((Environment.SpecialFolder)(array2[0] | (_003CModule_003E.KeyValuePair__2[232] + 53185) | 0x10));
		string text = char.ToString((char)(((0 != Convert.ToInt32("0", 16)) ? 412961 : (-9619)) * -1));
		string text2 = char.ToString((char)array2[Convert.ToInt32("2", 16)]);
		string text3 = char.ToString('■');
		string string_ = string.Concat("ꝄꝐ", char.ToString('\ua70d') + char.ToString('ꝗ') + "ꝛꝗ");
		object[] array5 = new object[6];
		array5[(nint)((Array)(object)string.Empty).LongLength] = (byte)(0xBE577u ^ (uint)TZifHead) != 0;
		array5[Convert.ToInt32("1", 16)] = 743;
		array5[set_Exclude] = 11759;
		array5[CancellationPending] = (char)Marshal.SizeOf(typeof(FastResourceComparer));
		array5[(uint)array[0]] = 140 << Convert.ToInt32("10", 2);
		array5[Parameters] = 'ᄱ';
		_003CModule_003E.TAIWANLUNISOLAR(ref string_, array5);
		string string_2 = string.Concat(text, text2 + text3 + string_);
		string string_3 = "乻";
		object[] array6 = new object[5];
		array6[0] = 'ʼ';
		array6[1] = "¤ӿ";
		array6[Convert.ToInt32("10", Convert.ToInt32("2", 16))] = 5532;
		array6[3] = Convert.ToInt32("37776157562", 8) ^ Convert.ToInt32("fff8dfaf", 16);
		int num = Marshal.SizeOf(typeof(IsValidText));
		array6[num] = 12146;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_3, array6);
		int num2 = Convert.ToInt32(string_3, 16);
		string string_4 = "栁栀";
		object[] array7 = new object[Convert.ToInt32("f82", 16) >> Convert.ToInt32("a", 16)];
		array7[0] = '㧇';
		array7[_003CModule_003E.ActivityOptions[196] - array2[3]] = string.Concat(char.ToString((char)Marshal.SizeOf(typeof(Sequential))), char.ToString('ú') + "\u000f\r");
		int num3 = Convert.ToInt32("2", 16);
		char c = (char)Convert.ToInt32("26024", 8);
		array7[num3] = (int)c;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_4, array7);
		object[] array8 = new object[num2 | Convert.ToInt32(string_4, 2)];
		string string_5 = "챦";
		object[] array9 = new object[0 | Marshal.SizeOf(typeof(IsValidText))];
		array9[checked(_003CModule_003E.get_PositiveSign[212] + 122702)] = string.Concat(char.ToString((char)Convert.ToInt32("1100110010101", 2)), char.ToString('\u008c') + "ˍz}");
		array9[array2[4] - 85985] = false;
		array9[648950 + Convert.ToInt32("37775414414", 8)] = Convert.ToInt32(char.ToString('8') + "2ed", Marshal.SizeOf(typeof(PrepareDelegate)));
		int num4 = array2[1];
		int num5 = default(int);
		switch (-247977 + ResolveAssemblyToPath)
		{
		case 0:
			num5 = 11140;
			break;
		case 1:
			num5 = Marshal.SizeOf(typeof(AnsiCharMarshaler));
			break;
		case 2:
			num5 = _003CModule_003E.ActivityOptions[197];
			break;
		}
		array9[num4] = (char)num5;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_5, array9);
		array8[Convert.ToInt32(string_5, 8)] = 6418;
		string string_6 = "蛐";
		object[] array10 = new object[(nint)((Array)(object)(char.ToString('\u032d') + ".\u0329")).LongLength];
		int item = Item5;
		_ = 0 * Convert.ToInt32("1040565", 8);
		int num6 = Convert.ToInt32("10010100111011", 2);
		array10[item] = (char)num6;
		array10[array2[5] / _003CModule_003E.KeyValuePair__2[233]] = false;
		int num7 = Convert.ToInt32("60646", 8);
		array10[2] = num7;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_6, array10);
		int num8;
		checked
		{
			num8 = Convert.ToInt32(string_6, Convert.ToInt32("10", 8)) & (1 * unchecked(1 * sizeof(sbyte)));
		}
		char c2 = (char)Convert.ToInt32("0", 16);
		array8[num8] = array4[(uint)c2] * ((-103075 & _003CModule_003E.ActivityOptions[198]) ^ ((array2[6] > 538116) ? 630483 : Convert.ToInt32("37776466130", 8)));
		string string_7 = "볦볞";
		object[] array11 = new object[Convert.ToInt32("5", 8)];
		int num9 = Convert.ToInt32("0", 8);
		checked
		{
			int num10 = default(int);
			switch (864391 + array2[7])
			{
			case 0:
				num10 = Convert.ToInt32("5323", 16);
				break;
			case 1:
				num10 = -318718;
				break;
			case 2:
				num10 = -876740;
				break;
			}
			array11[num9] = num10;
			array11[1] = 425686 + Convert.ToInt32("fff99595", 16);
		}
		array11[-2 * Convert.ToInt32("37777777777", 8)] = Convert.ToInt32("10001" + "010111000", 2);
		array11[3] = Convert.ToInt32(char.ToString('2') + char.ToString('6') + "46", 16);
		array11[4] = string.Concat(char.ToString('־'), char.ToString('\u009a'), char.ToString('ޜ') + "Ħ\u0018%");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_7, array11);
		IntPtr intPtr = (nint)((Array)(object)string_7).LongLength;
		int num11;
		checked
		{
			num11 = unchecked(DesktopDirectory % array2[8]) - (idldesc & -543260);
		}
		array8[(nint)intPtr] = (byte)num11 != 0;
		_003CModule_003E.GetMaxByteCount(ref string_2, array8);
		D = string_2;
		Requires = string_0;
		get_EnforceLegacyJapaneseDateParsing = int_0;
	}

	private unsafe void get_Week(string string_0, string string_1)
	{
		char[] array = new char[20]
		{
			'\u0002', '\0', '\u0001', '\u0006', '\u0003', '\u0004', '\u0005', '\u02f9', '촱', '䃵',
			'Ɔ', '椓', '礏', '⅋', '≚', '\b', 'n', 'A', 'ꍃ', '\u08f4'
		};
		int[] array2 = new int[62]
		{
			0, 1, 6, 3, 5, -1, 7, 359, 412, -609188,
			7199, 565872, -853078, 4694, 3418255, -315581, -774428, -283785, 15, 2,
			16, 8, 4, -3, 25, 539604, 67, 317, -24, -434938,
			180752426, 80074, 197175, -387527, -954916, 9016, 821, 28332, 363079, 28978,
			919, 788969, 269829, -985027, 93328, 377326, -160195, -30129, -5449, 14198,
			-300488, -328616, -12556, -3547475, 13817, 197951, 120394, -364393, 491173313, 13821,
			-789538, -906310
		};
		char[] array3 = new char[_003CModule_003E.KeyValuePair__2[4]];
		array3[0] = (char)(array2[0] | '\0');
		int num = ((Convert.ToInt32("156113", 8) == 56395) ? ((Array)(object)"\u0369").Length : array2[29]);
		array3[num] = (char)(3142352 >> Marshal.SizeOf(typeof(GetAbbreviatedDayName)));
		int num2 = ((Convert.ToInt32("124707", 8) != -6550) ? 2 : (-979665));
		array3[num2] = (char)Convert.ToInt32(char.ToString('1') + "01", 2);
		char c = (char)Convert.ToInt32("3", 8);
		array3[(uint)c] = '\u02df';
		array3[(nint)((Array)(object)(char.ToString('\u0311') + char.ToString('\u033e') + "\u0314\u0330")).LongLength] = '\u0002';
		array3[5] = array[Convert.ToInt32("5", 8)];
		array3[3 * Convert.ToInt32("2", 16)] = (char)_003CModule_003E.get_PositiveSign[52];
		char[] array4 = array3;
		int[] array5 = new int[11];
		array5[(uint)array[1]] = 1;
		array5[_003CModule_003E.ActivityOptions[2]] = 10 % array2[22];
		array5[Convert.ToInt32("12", 8) % 4] = 5;
		array5[_003CModule_003E.KeyValuePair__2[0]] = 152 * Convert.ToInt32("14", 8);
		array5[(nint)((Array)(object)(char.ToString('\u0306') + "\u0318\u032d\u0353")).LongLength] = 834;
		array5[~Convert.ToInt32("fffffffa", 16)] = 1496;
		array5[array2[2]] = 6;
		array5[array2[6]] = 247621;
		array5[Marshal.SizeOf(typeof(__c__DisplayClass0_6))] = 488954;
		int num3 = (array5[Marshal.SizeOf(typeof(VT_VOID))] = ((_003CModule_003E.KeyValuePair__2[234] > 362636) ? Convert.ToInt32("11111111111110110101010000010010", 2) : 6008));
		int num4 = (array5[10] = Convert.ToInt32("fffff612", 16));
		int[] array6 = array5;
		int num5 = get_EnforceLegacyJapaneseDateParsing;
		string string_2 = string.Concat(char.ToString((char)_003CModule_003E.ActivityOptions[199]), char.ToString('鷝'), char.ToString('鷝') + char.ToString('鷘') + "鶎鷝鷝鷝");
		object[] array7 = new object[2];
		array7[Convert.ToInt32("0", 8)] = Convert.ToInt32(char.ToString('5') + "eef", 16);
		array7[1] = "㖎\u093e";
		_003CModule_003E.TAIWANLUNISOLAR(ref string_2, array7);
		DateTime now;
		if (num5 == (Convert.ToInt32(string_2, 16) ^ (-237570 / (array2[30] / 180752426))))
		{
			using (StreamWriter streamWriter = File.AppendText(LoadScalarVector128 + D))
			{
				string text = char.ToString('쨺');
				string string_3 = "諱誼";
				object[] array8 = new object[4 | Parameters];
				array8[0 & array[1]] = Convert.ToInt32("3612075", 8) + -985536;
				array8[1] = (char)(Convert.ToInt32("5d7", 16) % Convert.ToInt32("1001010110", 2));
				array8[2] = (char)Marshal.SizeOf(typeof(BestFitMask));
				int num6 = default(int);
				switch (array2[31])
				{
				case 80073:
					num6 = array2[32];
					break;
				case 80074:
					num6 = Convert.ToInt32("21450", 8);
					break;
				case 80075:
					num6 = 108712;
					break;
				case 80076:
					num6 = 747221;
					break;
				}
				array8[3] = num6;
				array8[4] = 'ɣ';
				_003CModule_003E.TAIWANLUNISOLAR(ref string_3, array8);
				string text2 = text + string_3;
				string text3 = char.ToString('쩡');
				string text4 = char.ToString('쨺');
				string string_4 = string.Concat(char.ToString((char)Convert.ToInt32("e7d3", 16)), char.ToString('\ue79f'), char.ToString('\ue7c2') + "\ue7cf\ue7c2");
				object[] array9 = new object[3];
				array9[(int)array[1] % array2[33]] = false;
				int num7 = -67567 + Convert.ToInt32("107f0", 16);
				int num8 = default(int);
				switch (Convert.ToInt32("c6e3d", 16) - Convert.ToInt32("3067074", 8))
				{
				case 0:
					num8 = 869773;
					break;
				case 1:
					num8 = Convert.ToInt32("12615", 8);
					break;
				case 2:
					num8 = UnobservedTaskExceptionEventArgs;
					break;
				case 3:
					num8 = -885982;
					break;
				}
				array9[num7] = (char)num8;
				array9[2] = 6166;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_4, array9);
				string string_5 = string.Concat(text2, text3 + text4 + string_4);
				object[] array10 = new object[(checked(Convert.ToInt32("160420", 8) + -671207) ^ ((Convert.ToInt32("11111111111111110101100101000011", 2) > HasNonZeroTail) ? (-277220) : 613588)) * -1];
				array10[395941 - (Convert.ToInt32(char.ToString('f') + char.ToString('f') + "fa6dfd", 16) - checked(-364912 - Convert.ToInt32("1100000101100111000", 2)))] = array6[7] >> array6[6];
				array10[array6[checked(get_Encoding + 810439)]] = false;
				int currencyGroupSeparator = CurrencyGroupSeparator;
				int num9 = default(int);
				switch (390028 + ~DISPPARAMS)
				{
				case 0:
					num9 = 1;
					break;
				case 1:
					num9 = -968048;
					break;
				}
				array10[sizeof(short)] = currencyGroupSeparator * num9;
				_003CModule_003E.GetMaxByteCount(ref string_5, array10);
				string format = string_5;
				now = DateTime.Now;
				string text5 = char.ToString((char)(0x52CBBu ^ (uint)(-610915 - array2[34])));
				string string_6 = "㨭㨭";
				object[] array11 = new object[5];
				array11[Convert.ToInt32("10101001111", 2) >> 11] = Convert.ToInt32(char.ToString('1') + char.ToString('0') + "111110", _003CModule_003E.ActivityOptions[0]);
				array11[1] = Convert.ToInt32("10" + "10011", 2);
				array11[2] = checked(destinationArray - 723681);
				array11[3] = Ldc_I4_0;
				array11[Convert.ToInt32("4", 8)] = string.Concat(char.ToString('\u1fce'), char.ToString((char)Convert.ToInt32("1d", 16)), char.ToString('\u008a') + "\u008f\u0004\u0004");
				_003CModule_003E.TAIWANLUNISOLAR(ref string_6, array11);
				string text6 = string_6;
				string text7 = char.ToString('ጛ');
				string text8 = char.ToString((char)checked(-713847 - Convert.ToInt32("11111111111101010000100000111101", 2)));
				string string_7 = string.Concat(char.ToString((char)array2[35]), char.ToString('⍯') + char.ToString('⌦') + "⌦⌈");
				object[] array12 = new object[Convert.ToInt32("57731", 8) >> 13];
				array12[Convert.ToInt32("0", 8)] = array2[27] << Convert.ToInt32("1", 2);
				array12[1] = "ధ⇓";
				_003CModule_003E.TAIWANLUNISOLAR(ref string_7, array12);
				string string_8 = string.Concat(text5, text6, text7 + text8 + string_7);
				string text9 = char.ToString('\u0311');
				string text10 = char.ToString('\u030c');
				string string_9 = char.ToString((char)_003CModule_003E.KeyValuePair__2[235]) + "\uf62c\uf60a";
				object[] array13 = new object[6];
				array13[0] = '먏';
				array13[array2[1]] = Convert.ToInt32(char.ToString('1') + "3e1", Convert.ToInt32("10000", 2));
				array13[2] = string.Concat(char.ToString((char)Convert.ToInt32("c5", 16)), char.ToString((char)Convert.ToInt32("320", 8)), char.ToString('\a') + char.ToString('\v') + "\b\u0001\u0002");
				array13[(Convert.ToInt32("1100110101110", 2) <= -141787) ? 254301 : Convert.ToInt32("3", 16)] = 7954;
				array13[(nint)((Array)(object)(char.ToString('.') + "\u0336\u0308\u0329")).LongLength] = array2[36] << 1;
				array13[Convert.ToInt32("5", 8)] = (byte)((uint)array2[0] & (true ? 1u : 0u)) != 0;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_9, array13);
				object[] array14 = new object[(nint)((Array)(object)(text9 + text10 + string_9)).LongLength];
				int num10 = array6[sizeof(long)];
				int num12;
				checked
				{
					int num11 = default(int);
					switch (Marshal.SizeOf(typeof(UseHebrewParsing)) * (1 & Convert.ToInt32("1", 16)))
					{
					case 0:
						num11 = array[_003CModule_003E.get_PositiveSign[3]];
						break;
					case 1:
						num11 = -488954;
						break;
					case 2:
						num11 = 969578;
						break;
					case 3:
						num11 = array2[Convert.ToInt32("9", 16)];
						break;
					}
					num12 = num10 + num11;
				}
				int num13 = Convert.ToInt32("3777" + "6023516", 8) * (Convert.ToInt32("ffffffff", 16) * 1);
				string string_10 = string.Concat("ⅹⅿ", char.ToString('ⅽ') + "ⅼⅹⅺⅺ");
				object[] array15 = new object[4];
				array15[Convert.ToInt32("0", 8)] = array2[10];
				array15[1] = (byte)Convert.ToInt32("0", 8) != 0;
				int num14 = Convert.ToInt32("2", 16);
				array15[num14] = 561;
				array15[3] = 760;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_10, array15);
				string value = string_10;
				int fromBase = ((-42963 != Convert.ToInt32("37777654055", 8)) ? Marshal.SizeOf(typeof(WriteWaiterSignaled)) : 8);
				array14[num12] = num13 - Convert.ToInt32(value, fromBase);
				array14[checked(790225 - unchecked(-3912 * set_AllInternalsVisible))] = (char)ITypeLib;
				array14[(array2[3] & (10 % Convert.ToInt32("4", 8))) | (Convert.ToInt32(char.ToString('1') + char.ToString('2') + "7553645", Convert.ToInt32("10", 8)) >> ~array2[28])] = (byte)Marshal.SizeOf(typeof(IsTvOS)) != 0;
				array14[3 | ((Convert.ToInt32("9aeff", 16) & 0xB71BC) ^ 0x920BF)] = 0x349EA ^ (((Convert.ToInt32("37777617754", 8) == Convert.ToInt32("37777506054", 8)) ? 625572 : 225087) & 0x3D377);
				int num15 = default(int);
				if (0 == Convert.ToInt32("0", 16))
				{
					num15 = array4[5];
				}
				int num16 = num15;
				int[] loadVector = _003CModule_003E.LoadVector128;
				string string_11 = string.Concat("鄀酡", "酊酗", "鄜鄅" + "酼鄐鉿酫");
				object[] array16 = new object[2];
				array16[0] = Marshal.SizeOf(typeof(EventPipePayloadDecoder)) & 0x6D7D;
				array16[ShiftLeftLogicalSaturateScalar / 581121767] = Marshal.SizeOf(typeof(SpanHelpers)) & 0x29EC;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_11, array16);
				array14[num16] = loadVector[(nint)((Array)(object)string_11).LongLength];
				_003CModule_003E.GetMaxByteCount(ref string_8, array14);
				string text11 = string.Format(format, now.ToString(string_8), string_0);
				streamWriter.Write(text11 + string_1);
				string string_12 = "厡";
				object[] array17 = new object[Convert.ToInt32("11", 2) << Convert.ToInt32("1", 8)];
				array17[Convert.ToInt32("0", 2)] = Convert.ToInt32(char.ToString('1') + char.ToString('0') + "111", 2);
				array17[0 | _003CModule_003E.ActivityOptions[2]] = string.Concat(char.ToString('\u009a'), char.ToString('\0'), char.ToString('\f') + char.ToString('\u0081') + "\u0001\u0002");
				array17[2] = checked(_003CModule_003E.get_PositiveSign[201] * -1);
				array17[(uint)array[Convert.ToInt32("4", 8)]] = 7;
				array17[(nint)((Array)(object)(char.ToString('\u0341') + char.ToString('\u0304') + "\u0332\u0359")).LongLength] = (char)(Convert.ToInt32("10010001100", 2) >> 5);
				array17[634171575 / Convert.ToInt32("78f568b", 16)] = (byte)Convert.ToInt32("0", array[15]) != 0;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_12, array17);
				string string_13 = string_12;
				string string_14 = "◓◒";
				int num17 = ((array2[37] < 262635) ? 3 : array2[38]);
				object[] array18 = new object[num17];
				int num18 = ((((Convert.ToInt32("ffff61bf", 16) == -57404) ? 1 : 0) != array2[0]) ? _003CModule_003E.get_PositiveSign[213] : Convert.ToInt32("0", 2));
				array18[0] = (byte)num18 != 0;
				array18[sizeof(bool)] = _003CModule_003E.ActivityOptions[60];
				array18[sizeof(char) * Launch] = Convert.ToInt32(char.ToString('3') + char.ToString('3') + "57", 8);
				_003CModule_003E.TAIWANLUNISOLAR(ref string_14, array18);
				object[] array19 = new object[(uint)array4[Convert.ToInt32(string_14, 2)]];
				string string_15 = "腑";
				char c2 = (char)Convert.ToInt32("5", 8);
				object[] array20 = new object[(int)c2];
				array20[0] = string.Concat(char.ToString('\v'), char.ToString((char)Marshal.SizeOf(typeof(FractionalDigitsCount))), char.ToString('\0') + "\u0004\0\u0003");
				array20[array2[array2[1]]] = 0xFE0F ^ _003CModule_003E.ActivityOptions[200];
				array20[_003CModule_003E.ActivityOptions[0]] = string.Concat(char.ToString('Გ'), char.ToString((char)_003CModule_003E.KeyValuePair__2[236]), char.ToString('፬') + "ʲ\u0016\u00ad");
				array20[CancellationPending] = (int)array[9];
				array20[4] = (byte)_003CModule_003E.ActivityOptions[1] != 0;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_15, array20);
				int num19 = Convert.ToInt32(string_15, 16);
				int num20 = (((nint)1 != (nint)((Array)(object)string.Empty).LongLength) ? Convert.ToInt32(char.ToString('7') + "d7cb", 16) : array2[11]);
				int num21 = checked(num19 * num20);
				int num22 = ((5131 <= Convert.ToInt32("fff363f5", 16)) ? (-704419) : 27668);
				array19[num21] = 0x4EF5 & num22;
				array19[checked((-373574 - Convert.ToInt32("377" + "76563572", 8) >= (Convert.ToInt32("110111100111001110000110001001", 2) >> 9) - unchecked(Convert.ToInt32("1011111101001001111101100111110", 2) / GetSatelliteAssembly)) ? (861 * unchecked(-3335 % Convert.ToInt32("37777775312", 8))) : unchecked((_003CModule_003E.ActivityOptions[201] >> 2) / (Marshal.SizeOf(typeof(exception)) / (int)array[2])))] = (byte)array4[checked(853078 + array2[_003CModule_003E.ActivityOptions[8]])] != 0;
				array19[_003CModule_003E.LoadVector128[(Convert.ToInt32("10", 2) | 0) * Convert.ToInt32("1", 2)]] = 3455;
				string string_16 = "扣扣";
				object[] array21 = new object[(67459 != array2[39]) ? 2 : 459549];
				array21[_003CModule_003E.ActivityOptions[1] % -365393] = 1486;
				array21[sizeof(sbyte)] = '岄';
				_003CModule_003E.TAIWANLUNISOLAR(ref string_16, array21);
				array19[Convert.ToInt32(string_16, array4[Marshal.SizeOf(typeof(IsValidText))])] = BeginInvoke;
				array19[4] = ((7339 >= checked(-660591 + Convert.ToInt32(char.ToString('3') + "6cda", 16))) ? ((char)(-183961 - (Marshal.SizeOf(typeof(Stobj)) | -138670767))) : '켓');
				_003CModule_003E.GetMaxByteCount(ref string_13, array19);
				streamWriter.Write(string_13);
				return;
			}
		}
		int num23 = get_EnforceLegacyJapaneseDateParsing;
		string string_17 = "\ue397";
		object[] array22 = new object[4];
		array22[checked(Convert.ToInt32("11111111111111101110010101001100", 2) - -72372)] = _003CModule_003E.ActivityOptions[202] / 3126361;
		array22[1] = false;
		array22[ComponentGuaranteesAttribute * array2[5]] = char.ToString('痯') + "嫋\u0ff7";
		int num24 = Convert.ToInt32("3", 8);
		char c3 = (char)_003CModule_003E.get_PositiveSign[214];
		array22[num24] = (int)c3;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_17, array22);
		if (num23 == Convert.ToInt32(string_17, Machine))
		{
			char c4 = (char)_003CModule_003E.ActivityOptions[AndNot];
			string text12 = char.ToString(c4);
			string string_18 = "\uf642\uf60f";
			object[] array23 = new object[Parameters];
			array23[0] = (char)Convert.ToInt32(char.ToString('3') + char.ToString('4') + "65", Convert.ToInt32("8", 16));
			array23[_003CModule_003E.ActivityOptions[sizeof(short)]] = (char)array2[array2[21]];
			array23[2] = 1902;
			array23[3] = 3930;
			array23[4] = 4594;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_18, array23);
			string text13 = string_18;
			string string_19 = "텟턄";
			object[] array24 = new object[~_003CModule_003E.get_PositiveSign[110]];
			array24[Convert.ToInt32("11111111111110001010000110011000", 2) ^ _003CModule_003E.KeyValuePair__2[237]] = 2099;
			array24[5 % Marshal.SizeOf(typeof(ENODATA))] = (int)array[_003CModule_003E.KeyValuePair__2[4]];
			array24[2] = char.ToString('ז') + char.ToString((char)array2[40]) + "ŷv";
			_003CModule_003E.TAIWANLUNISOLAR(ref string_19, array24);
			string text14 = string_19;
			string string_20 = string.Concat(char.ToString('歲'), char.ToString('款') + char.ToString('正') + "歮正");
			object[] array25 = new object[6];
			array25[_003CModule_003E.ActivityOptions[1]] = 42842;
			array25[1] = 148;
			array25[~array2[23]] = false;
			array25[(nint)((Array)(object)(char.ToString('\u0335') + "\u0318\u032a")).LongLength] = set_YearMonthPattern;
			string string_21;
			int num25 = default(int);
			checked
			{
				array25[-2 * Convert.ToInt32("37777777776", 8)] = array2[Marshal.SizeOf(typeof(Prefix1))];
				array25[173 >> Convert.ToInt32("5", 8)] = 516;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_20, array25);
				string_21 = string.Concat(text12, text13, text14 + string_20);
				switch (INVOCATION_FLAGS_IS_DELEGATE_CTOR + 890541)
				{
				case 0:
					num25 = 256621;
					break;
				case 1:
					num25 = 297767;
					break;
				case 2:
					num25 = 677272;
					break;
				case 3:
					num25 = 235501;
					break;
				}
			}
			object[] array26 = new object[(num25 + -235498) * 2];
			int num26 = 737720 + ((-562712 + MD5 == -17021) ? Convert.ToInt32("377" + "75137110", ((Array)(object)"\u0352\u0301\u0353\u0317\u031e\u0339\u0323\u0332").Length) : DecoderReplacementFallback);
			int num27 = default(int);
			switch (Convert.ToInt32("fff26e5d", 16))
			{
			case -889251:
				num27 = Convert.ToInt32("1", 16);
				break;
			case -889250:
				num27 = array2[25];
				break;
			}
			array26[num26] = ~(-2988 / num27);
			char num28 = array4[GetManifestResourceStream];
			int[] loadVector2 = _003CModule_003E.LoadVector128;
			int num29 = default(int);
			switch (array[2] * array[2])
			{
			case 0:
				num29 = -846356;
				break;
			case 1:
				num29 = 11;
				break;
			case 2:
				num29 = 217042;
				break;
			case 3:
				num29 = Convert.ToInt32("11111111111110011110111110111010", 2) & -975089;
				break;
			}
			array26[(uint)num28] = (char)loadVector2[num29];
			int intersect = Intersect;
			int num30 = Convert.ToInt32("3323366", 8);
			int num31 = intersect & num30;
			string string_22 = string.Concat(char.ToString('泇') + "泇泇", char.ToString('沒') + "沔沘沑泂");
			object[] array27 = new object[(uint)array[3]];
			array27[(nint)((Array)(object)string.Empty).LongLength] = "ᴊ⌶";
			array27[(nint)((Array)(object)string.Empty).LongLength | 1] = (char)array2[Convert.ToInt32("15", 8)];
			array27[1 << Launch] = 'ĺ';
			array27[3] = Marshal.SizeOf(typeof(MultiplyAddNegatedScalar));
			array27[4] = 'ᐫ';
			array27[(nint)((Array)(object)(char.ToString('\u0301') + "\u036b\u0323\u031e\u030d")).LongLength] = false;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_22, array27);
			int num32 = checked(num31 + Convert.ToInt32(string_22, 16));
			int num33 = Marshal.SizeOf(typeof(Rdm));
			array26[num32] = num33;
			int num34 = default(int);
			switch (1794977387 / Convert.ToInt32("6a" + "fd2e6b", Exclude))
			{
			case 0:
				num34 = Convert.ToInt32("111" + "00011110001111000", sizeof(ushort));
				break;
			case 1:
				num34 = Convert.ToInt32("1000000" + "111110110", 2);
				break;
			}
			string string_23;
			checked
			{
				array26[num34 - unchecked((0xBEF1 & Convert.ToInt32("1100101110110110", 2)) + -2237)] = false;
				string_23 = "ꬌ";
			}
			object[] array28 = new object[Convert.ToInt32("37776717656", 8) + 286804];
			array28[0] = char.ToString('䤐') + "ʼ൛";
			array28[_003CModule_003E.ActivityOptions[203] ^ 0xE0752] = GetOrCreateValue;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_23, array28);
			int num35 = Convert.ToInt32(string_23, Item5 | 8);
			char c5 = (char)(~checked(-1019442 - _003CModule_003E.KeyValuePair__2[238]));
			array26[num35] = (int)c5;
			int genitive = Genitive;
			int num36 = Convert.ToInt32("37" + "774457101", 8) + 893823;
			array26[genitive] = (char)num36;
			_003CModule_003E.GetMaxByteCount(ref string_21, array26);
			string format2 = string_21;
			now = DateTime.Now;
			string text15 = char.ToString((char)(5075 % _003CModule_003E.get_PositiveSign[79]));
			string string_24 = "ⅩⅩ";
			object[] array29 = new object[Convert.ToInt32("0", 8) | 2];
			array29[0] = char.ToString('ʊ') + "\u0094Í";
			array29[1] = 7874;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_24, array29);
			string text16 = string_24;
			string string_25 = "\u1a57ᨀ";
			object[] array30 = new object[Convert.ToInt32("4", 8)];
			array30[0] = 4662;
			array30[1] = 874;
			array30[Convert.ToInt32("10", array2[19])] = false;
			int num37 = _003CModule_003E.ActivityOptions[204];
			array30[3] = num37;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_25, array30);
			string text17 = string_25;
			string string_26 = string.Concat(char.ToString(array[18]), char.ToString('ꌔ') + char.ToString('ꍝ') + "ꍝꍳ");
			object[] array31 = new object[Convert.ToInt32(char.ToString('1') + "01", 2)];
			array31[array2[0] | _003CModule_003E.ActivityOptions[1]] = (char)lcid;
			array31[1] = 20124;
			array31[(59574 <= Convert.ToInt32("3005d", 16)) ? 2 : (-272600)] = 38780767 >> Convert.ToInt32("1101", 2);
			array31[Convert.ToInt32("3", 8)] = 10233;
			array31[Marshal.SizeOf(typeof(GetHashCode)) + -399348] = string.Concat(char.ToString('ᆣ'), char.ToString('ĥ') + "\u0098\u0099\u001c\u00ad");
			_003CModule_003E.TAIWANLUNISOLAR(ref string_26, array31);
			string string_27 = string.Concat(text15, text16 + text17 + string_26);
			object[] array32;
			int num38;
			checked
			{
				array32 = new object[(-19785 * (-5 * array2[5]) == -98925) ? 4 : ((Convert.ToInt32("b208c", 16) ^ array2[41]) + _003CModule_003E.KeyValuePair__2[unchecked((uint)array[17])])];
				num38 = Marshal.SizeOf(typeof(InternalState)) ^ ((-88549 + array2[42]) | Convert.ToInt32(char.ToString('1') + "504073", 8));
			}
			char c6 = (char)(array[16] & 'S');
			char c7 = c6;
			array32[num38] = (int)c7;
			int num39 = _003CModule_003E.Dequeue[0];
			string string_28 = "붱";
			_003CModule_003E.TAIWANLUNISOLAR(ref string_28, new object[4]
			{
				1345,
				string.Concat("\u05c7\u02d2", char.ToString('Þ') + char.ToString('Ǟ') + "ĿǑ"),
				Marshal.SizeOf(typeof(get_HeapSizeBytes)),
				(char)(Marshal.SizeOf(typeof(V4)) | '⎈')
			});
			string value2 = string_28;
			char c8 = (char)((Array)(object)"\u0340\u0317\u033c\u0351\u0318\u0303\u033a\u0317").Length;
			array32[num39 * Convert.ToInt32(value2, c8)] = PE32Plus;
			int num40 = array6[sizeof(byte) * ((-84467 <= Marshal.SizeOf(typeof(TypeHandle))) ? 1 : Convert.ToInt32("52879", 16))];
			string text18 = char.ToString((char)MultiplyExtended);
			string text19 = char.ToString((char)(-454390 + Convert.ToInt32("9f167", 16) + -197214));
			string text20 = char.ToString((char)checked(-100482 - Convert.ToInt32("37777473576", 8)));
			string string_29 = string.Concat(char.ToString((char)Convert.ToInt32("61570", 8)), char.ToString('捺') + "捹捼");
			object[] array33 = new object[2 | sizeof(sbyte)];
			array33[0] = 6418;
			array33[Convert.ToInt32("5", 16) % 2] = 10583;
			array33[2] = _003CModule_003E.ActivityOptions[62];
			_003CModule_003E.TAIWANLUNISOLAR(ref string_29, array33);
			array32[num40] = string.Concat(text18, text19, text20 + string_29);
			int num41 = ((_003CModule_003E.get_PositiveSign[215] >= Convert.ToInt32("1011001000101001101", 2)) ? (-120250) : (-989194));
			int num42 = num41;
			array32[num42 - (Marshal.SizeOf(typeof(BindHandle)) | checked(-1350986805 + Convert.ToInt32("11111111111101110001000110001000", 2)))] = (char)checked(-719077 - unchecked((Convert.ToInt32("37765130274", 8) + -760690) % (-1439612 / Convert.ToInt32("1", 8))));
			_003CModule_003E.GetMaxByteCount(ref string_27, array32);
			string text21 = string.Format(format2, now.ToString(string_27), string_0);
			System.Console.Write(text21 + string_1);
			string string_30 = "낏";
			object[] array34 = new object[_003CModule_003E.get_PositiveSign[2]];
			array34[0] = '艘';
			array34[Convert.ToInt32("1", 8)] = 7;
			array34[Convert.ToInt32("11111111111111111111111111111110", 2) * array2[5]] = (byte)array2[0] != 0;
			int num43 = array2[3];
			array34[num43] = (char)Mul_Ovf_Un;
			array34[20 % sizeof(ulong)] = checked(985055 + array2[43]);
			_003CModule_003E.TAIWANLUNISOLAR(ref string_30, array34);
			string string_31 = string_30;
			object[] array35 = new object[(((array2[44] > -799945) ? 2129992470 : 722188) / Marshal.SizeOf(typeof(OriginalException))) ^ checked(249646 * Marshal.SizeOf(typeof(IsValidText)))];
			int num44 = default(int);
			switch (checked(_003CModule_003E.ActivityOptions[Convert.ToInt32("111111", 2)] + ~array2[45]))
			{
			case 0:
				num44 = -782193;
				break;
			}
			int num45 = -782193 - num44;
			int num46 = Convert.ToInt32("37775303176", 8) - -526271;
			int num47 = array2[46];
			int num48 = default(int);
			switch (checked(num46 - num47))
			{
			case 0:
				num48 = 875;
				break;
			}
			string text22 = char.ToString((char)num48);
			string text23 = char.ToString((char)(GetAvailableThreads ^ Convert.ToInt32(char.ToString('f') + "ffa9702", array2[20])));
			string string_32 = "屟崃";
			object[] array36 = new object[_003CModule_003E.get_PositiveSign[2] * 1];
			array36[array2[0] * AssumeLocal] = 3004;
			array36[1] = "·Ė";
			array36[2] = string.Concat("⊼ᅱ", char.ToString('ź') + char.ToString('\u0001') + "\b\u0010");
			array36[CancellationPending] = 3907;
			array36[-920122 + Convert.ToInt32("11100000101000111110", 2)] = 'ߔ';
			_003CModule_003E.TAIWANLUNISOLAR(ref string_32, array36);
			array35[num45] = text22 + text23 + string_32;
			string string_33 = "皘皙";
			object[] array37 = new object[_003CModule_003E.ActivityOptions[0]];
			array37[_003CModule_003E.ActivityOptions[1] % DelayPromise] = (char)Convert.ToInt32(char.ToString('7') + "27", Convert.ToInt32("10", 16));
			array37[sizeof(byte)] = Convert.ToInt32("100010110110001010", 2) % 57092;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_33, array37);
			string text24 = string_33;
			string string_34 = string.Concat(char.ToString('簌'), char.ToString('簌'), char.ToString('簍') + "簌簌簌簌簌簌");
			object[] array38 = new object[array2[4]];
			array38[Convert.ToInt32("0", 2)] = char.ToString((char)Convert.ToInt32("3487", 16)) + "ވ\u0329";
			int launch = Launch;
			int num49 = ((((Convert.ToInt32("11111111111111110001100101100100", 2) == -59036) ? 1 : 0) != _003CModule_003E.ActivityOptions[1]) ? 1388 : 655181);
			array38[launch] = num49;
			IntPtr intPtr = (nint)((Array)(object)"\u0336.").LongLength;
			int num50 = Convert.ToInt32("6001", 8);
			array38[(nint)intPtr] = (char)num50;
			array38[Convert.ToInt32("3", _003CModule_003E.KeyValuePair__2[2])] = (byte)checked(Convert.ToInt32("86227", 16) + get_TotalSeconds) != 0;
			array38[4] = (char)Marshal.SizeOf(typeof(IntervalSec));
			_003CModule_003E.TAIWANLUNISOLAR(ref string_34, array38);
			string value3 = text24 + string_34;
			int fromBase2 = default(int);
			switch (~Convert.ToInt32("37777777777", 8) / checked(346799 - Convert.ToInt32("1010100101011110111", 2)))
			{
			case 0:
				fromBase2 = (int)checked(2 * unchecked((nint)((Array)(object)"\u033d").LongLength));
				break;
			}
			array35[1] = Convert.ToInt32(value3, fromBase2);
			string string_35 = "㹎㸝";
			int parameters = Parameters;
			object[] array39 = new object[parameters];
			array39[0] = 7646;
			array39[Launch] = 'ᨮ';
			array39[1121043986 / Marshal.SizeOf(typeof(get_LongLength))] = (byte)Convert.ToInt32("0", Convert.ToInt32("10000", 2)) != 0;
			array39[3] = 254;
			array39[sizeof(uint)] = Convert.ToInt32(char.ToString('2') + char.ToString('0') + "26", 8);
			_003CModule_003E.TAIWANLUNISOLAR(ref string_35, array39);
			array35[(nint)((Array)(object)string_35).LongLength] = array6[checked(-5 * Convert.ToInt32("11111111111111111111111111111101", 2)) % (Convert.ToInt32("36", 8) % 12)];
			int num51 = Convert.ToInt32(char.ToString('3') + "77" + "75323517", 8);
			array35[checked(num51 + 678068)] = (byte)(~Convert.ToInt32("37" + "774305730", array[15]) - EventChannelAttribute % 1894478) != 0;
			array35[_003CModule_003E.get_PositiveSign[13] * -1 << GetManifestResourceStream] = (array2[5] & IsBmp) * -26;
			int num52 = ((-25311 > checked(Convert.ToInt32("11111111111111111000011100011011", 2) * -23)) ? 317212 : 2);
			array35[array6[num52]] = _003CModule_003E.CalendarType[6];
			_003CModule_003E.GetMaxByteCount(ref string_31, array35);
			System.Console.Write(string_31);
			return;
		}
		using (StreamWriter streamWriter2 = File.AppendText(LoadScalarVector128 + D))
		{
			string text25 = char.ToString('胂');
			string string_36 = "⚩⛤";
			object[] array40 = new object[3];
			array40[Item5] = 35037;
			array40[1] = 785;
			array40[Convert.ToInt32("2", 8)] = Convert.ToInt32(char.ToString('1') + char.ToString('a') + "32", 16);
			_003CModule_003E.TAIWANLUNISOLAR(ref string_36, array40);
			string text26 = text25 + string_36;
			string string_37 = "\ue374\ue32f";
			int num53 = ((array2[47] == -82201) ? 959339 : array2[4]);
			object[] array41 = new object[num53];
			array41[_003CModule_003E.ActivityOptions[205] - -472111] = Convert.ToInt32("11010" + "01100011", 2);
			array41[sizeof(bool)] = false;
			array41[2] = 7194;
			array41[3] = 10714;
			array41[Convert.ToInt32(char.ToString('1') + "00", 2)] = 918;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_37, array41);
			string text27 = string_37;
			string string_38 = string.Concat(char.ToString('\udfdc'), char.ToString('\udf90') + char.ToString('\udfcd') + "\udfc0\udfcd");
			object[] array42 = new object[5];
			array42[Item5] = (char)GlobalCount;
			array42[1] = char.ToString('7') + "Zɬ";
			int num54 = Convert.ToInt32("2", 16);
			array42[num54] = 564;
			array42[3] = '\u0fb8';
			array42[4] = 'Қ';
			_003CModule_003E.TAIWANLUNISOLAR(ref string_38, array42);
			string string_39 = string.Concat(text26, text27 + string_38);
			string text28 = char.ToString((char)Convert.ToInt32(char.ToString('1') + char.ToString('4') + "56", ((Array)(object)"\u0332\u0308\u033e\u036c\u033c\u032c\u0306\u0366").Length));
			string string_40 = "\uf8ea\uf8e0";
			object[] array43 = new object[array2[4]];
			array43[0] = array[10];
			array43[Launch] = (char)Marshal.SizeOf(typeof(Utf8Parser));
			array43[2] = char.ToString('呝') + "❤᰾";
			array43[CancellationPending] = string.Concat(char.ToString('બ'), char.ToString('᭷'), char.ToString('\u0318') + "ݺ7\u0081ƀ");
			array43[4] = 4792;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_40, array43);
			object[] array44 = new object[(nint)((Array)(object)(text28 + string_40)).LongLength];
			string text29 = char.ToString('4');
			string string_41 = char.ToString((char)Marshal.SizeOf(typeof(Reflect))) + char.ToString('ꏠ') + "ꏤꏡ";
			object[] array45 = new object[3];
			array45[(nint)((Array)(object)string.Empty).LongLength] = Convert.ToInt32("fffd91c8", 16) ^ -132532;
			array45[Convert.ToInt32("1", Convert.ToInt32("10", 2))] = '㡎';
			array45[_003CModule_003E.ActivityOptions[array2[0]]] = false;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_41, array45);
			array44[0] = Convert.ToInt32(text29 + string_41, 8);
			char c9 = (char)Marshal.SizeOf(typeof(UseHebrewParsing));
			array44[1 * c9] = false;
			string string_42 = "믮";
			object[] array46 = new object[3];
			array46[(Convert.ToInt32("10100011010101010", 2) > -793167) ? _003CModule_003E.ActivityOptions[1] : (-307305)] = '\u180f';
			array46[1] = Marshal.SizeOf(typeof(MultiplyRoundedDoublingBySelectedScalarAndAddSaturateHigh));
			array46[(uint)array[Item5]] = Convert.ToInt32(char.ToString('2') + "dc", 16);
			_003CModule_003E.TAIWANLUNISOLAR(ref string_42, array46);
			array44[array6[Convert.ToInt32(string_42, 8)]] = '㸆';
			_003CModule_003E.GetMaxByteCount(ref string_39, array44);
			string format3 = string_39;
			now = DateTime.Now;
			string text30 = char.ToString((char)array6[Convert.ToInt32("11110011001101010001010110111", 2) / DESCKIND_MAX]);
			string text31 = char.ToString((char)(1775197026 / Launch / checked(593359 - _003CModule_003E.get_PositiveSign[216])));
			string text32 = char.ToString('ᝋ');
			string text33 = char.ToString('\u1719');
			string string_43 = string.Concat("ꔍꔍ", char.ToString('ꕚ') + "ꔓꔓꔽ");
			object[] array47 = new object[Convert.ToInt32("3", 8)];
			array47[array2[array2[0]]] = 7090;
			array47[array2[1]] = (int)array[11];
			array47[2] = 11646;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_43, array47);
			string string_44 = string.Concat(text30, text31, text32 + text33 + string_43);
			int num55 = _003CModule_003E.LoadVector128[0];
			string string_45 = string.Concat(char.ToString('鿄'), char.ToString('鿫'), char.ToString('龬') + "鿌鿍");
			object[] array48 = new object[30370 - _003CModule_003E.get_PositiveSign[217]];
			array48[0] = 34630;
			array48[array2[1] * Launch] = ~array2[48];
			array48[(uint)array[0]] = (byte)((Array)(object)string.Empty).Length != 0;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_45, array48);
			object[] array49 = new object[num55 | (nint)((Array)(object)string_45).LongLength];
			string string_46 = "度";
			object[] array50 = new object[3];
			array50[(uint)array[Convert.ToInt32("1", 2)]] = 320;
			array50[1] = MetadataToken;
			array50[sizeof(short)] = string.Concat(char.ToString('⭟'), char.ToString((char)array2[49]), char.ToString('\u17be') + "࠸෬");
			_003CModule_003E.TAIWANLUNISOLAR(ref string_46, array50);
			string value4 = string_46;
			string string_47 = string.Concat(char.ToString((char)Marshal.SizeOf(typeof(ToShortDateString))), char.ToString('柡') + char.ToString('柕') + "柂柋枊枠极");
			object[] array51 = new object[Convert.ToInt32("1001000011101110111", 2) + -296818];
			array51[0] = (byte)checked(Convert.ToInt32("37777702024", 8) - -31724) != 0;
			array51[array2[50] + 300489] = M31;
			array51[2] = Convert.ToInt32("10010" + "1010010010", Convert.ToInt32("10", 2));
			array51[array2[18] % 6] = 1467;
			array51[4] = 1556;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_47, array51);
			int num56 = Convert.ToInt32(value4, ((Array)(object)string_47).Length);
			int num57 = 498259 * Convert.ToInt32("11111111111111111111111111111111", 2);
			int num58 = ((Convert.ToInt32("ffff1274", 16) > ComponentParseResult) ? Convert.ToInt32("11010011101000000010", 2) : 499163);
			checked
			{
				int num59 = num57 + num58;
				array49[num56] = num59;
				int num61;
				if (StoreAligned >> _003CModule_003E.KeyValuePair__2[7] < unchecked(336094212 / Convert.ToInt32("1346", 16)) - (Convert.ToInt32("fffbf7ef", 16) & -790553))
				{
					string string_48 = "깕";
					int num60 = ((1 != Item5) ? 3 : (-709271));
					object[] array52 = new object[num60];
					array52[0] = char.ToString('ԓ') + "ũť";
					array52[1] = 31277;
					array52[2] = 'ⱖ';
					_003CModule_003E.TAIWANLUNISOLAR(ref string_48, array52);
					num61 = Convert.ToInt32(string_48, 0xC & Convert.ToInt32("1010", 2));
				}
				else
				{
					num61 = unchecked(array2[(nint)((Array)(object)"\u0359\u0338\u0336\u0355\u0317\u030d\u0326\u033c\u0319\u032f\u0314\u0339\u0304\u0318").LongLength] % (0x1D00C1 ^ _003CModule_003E.get_PositiveSign[218]));
				}
				array49[num61] = Marshal.SizeOf(typeof(Undo));
				array49[2] = 359;
			}
			string text34 = char.ToString((char)((-5022 != Convert.ToInt32("37777766142", 8)) ? array2[51] : '\u034a'));
			string string_49 = "抅抨";
			object[] array53 = new object[(uint)array[4]];
			array53[Item5 % -334912] = Prelink;
			array53[1 * Marshal.SizeOf(typeof(UseHebrewParsing))] = Convert.ToInt32(char.ToString('1') + "0551", 8);
			array53[Convert.ToInt32("2", 16)] = 6313;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_49, array53);
			IntPtr intPtr2 = (nint)((Array)(object)(text34 + string_49)).LongLength;
			string string_50 = "\u245f⒨";
			object[] array54 = new object[Convert.ToInt32(char.ToString('1') + "10", 2)];
			array54[0] = string.Concat(char.ToString('¹'), char.ToString('\u0002'), char.ToString('\u001d') + char.ToString('\0') + "\0\u0002");
			int num62 = array[2];
			array54[num62] = string.Concat(char.ToString((char)M41), char.ToString('Ħ') + char.ToString('1') + "\u0001=");
			array54[checked(-927618 - Convert.ToInt32("fff1d87c", 16))] = (byte)Convert.ToInt32("0", 2) != 0;
			array54[_003CModule_003E.KeyValuePair__2[0]] = '\u09c5';
			array54[4] = Created;
			array54[(uint)array[6]] = Convert.ToInt32(char.ToString('1') + "474", 8);
			_003CModule_003E.TAIWANLUNISOLAR(ref string_50, array54);
			array49[(nint)intPtr2] = string_50;
			nint num63 = (nint)((Array)(object)string.Empty).LongLength;
			int num64 = ((34035 != Convert.ToInt32("13261", 8) * _003CModule_003E.ActivityOptions[86]) ? 4 : 766863);
			string string_51;
			object[] array55;
			checked
			{
				array49[num63 | num64] = unchecked((_003CModule_003E.ActivityOptions[206] - _003CModule_003E.get_PositiveSign[219]) * (Convert.ToInt32("1365017", 8) - 387598)) * -5;
				_003CModule_003E.GetMaxByteCount(ref string_44, array49);
				string text35 = string.Format(format3, now.ToString(string_44), string_0);
				streamWriter2.Write(text35 + string_1);
				string_51 = "㽹";
				array55 = new object[2];
				array55[0] = 29183;
			}
			array55[(uint)array[2]] = 15660;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_51, array55);
			string string_52 = string_51;
			object[] array56 = new object[array6[Convert.ToInt32(char.ToString('1') + char.ToString('0') + "0000110100110", ((Array)(object)"\u035a\u033d").Length) + -16805]];
			int num65 = 0 / (((-75143 >= Marshal.SizeOf(typeof(StringToCoTaskMemAuto))) ? 855955 : (-62)) * 1);
			char c10 = (char)(~(array2[52] & -714));
			array56[num65] = (int)c10;
			array56[Marshal.SizeOf(typeof(Struct0)) / (4487627 * _003CModule_003E.KeyValuePair__2[Convert.ToInt32("73", 8)])] = (char)(Convert.ToInt32(char.ToString('3') + "77" + "77772475", 8) * Convert.ToInt32("111" + "11111" + "111111111111111111010101", 2) % (_003CModule_003E.ActivityOptions[64] ^ -260348));
			_003CModule_003E.GetMaxByteCount(ref string_52, array56);
			streamWriter2.Write(string_52);
		}
		string text36 = char.ToString((char)(~Convert.ToInt32("ff" + "ffb0ec", sizeof(Guid))));
		string string_53 = char.ToString((char)Convert.ToInt32("100001011100100", 2)) + "䊩䋴";
		object[] array57 = new object[3];
		int num66 = ((Completing <= 791166) ? 87 : (-137759));
		array57[0] = num66;
		array57[(uint)array[Convert.ToInt32("2", 8)]] = Convert.ToInt32("1101101101001010011101111111111", 2) / 536467;
		array57[-741451 ^ Convert.ToInt32("fff4afb7", 16)] = (byte)Item5 != 0;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_53, array57);
		string text37 = string_53;
		string string_54 = string.Concat(char.ToString('蔩'), char.ToString((char)_003CModule_003E.get_PositiveSign[220]), char.ToString('蔯') + "蕲蕿蕲");
		object[] array58 = new object[4];
		array58[_003CModule_003E.ActivityOptions[1]] = '⥴';
		array58[1] = _003CModule_003E.ActivityOptions[65];
		array58[2] = 'Ů';
		array58[(uint)array[4]] = _003CModule_003E.ActivityOptions[207] ^ Convert.ToInt32("11111111111101100010111000000001", 2);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_54, array58);
		string string_55 = string.Concat(text36, text37 + string_54);
		string string_56 = "ﴁ";
		object[] array59 = new object[4];
		array59[Convert.ToInt32("0", 8)] = (byte)(Item5 / 170125449) != 0;
		array59[1] = 21285;
		array59[Marshal.SizeOf(typeof(appendNewLine)) ^ 0x9AA99] = 304286 >> array2[3];
		array59[array2[3]] = string.Concat(char.ToString((char)ConsoleApplication), char.ToString('P') + "Ȗ.\u0002\u0002");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_56, array59);
		object[] array60 = new object[Convert.ToInt32(string_56, 0 | (2 << Marshal.SizeOf(typeof(ENODATA))))];
		int num67 = array2[53] % -1418990;
		array60[num67 + (Convert.ToInt32(char.ToString('2') + char.ToString('1') + "51507", 8) | 0x21173)] = (char)(~array6[10]);
		int num72;
		string string_57;
		object[] array61;
		checked
		{
			array60[unchecked(Convert.ToInt32("111" + "11111101110000111011000011000", 2) % -1875344) + ~Convert.ToInt32(char.ToString('1') + "1111111111100011011000100110110", Convert.ToInt32("2", 8))] = unchecked((int)array4[3]);
			int num68 = Marshal.SizeOf(typeof(GetMethodBody));
			int num69 = (((EnableEvent & -1053787) - _003CModule_003E.KeyValuePair__2[Convert.ToInt32("1000010", 2)] >= (_003CModule_003E.ActivityOptions[Reduce] & -107609)) ? array4[6] : (unchecked(Marshal.SizeOf(typeof(Encode)) * _003CModule_003E.ActivityOptions[5]) - 33115));
			array60[num68] = num69;
			int[] loadVector3 = _003CModule_003E.LoadVector128;
			int num70 = ((array2[54] < _003CModule_003E.ActivityOptions[208]) ? 626604 : Convert.ToInt32("11111111111111111011011001001110", 2));
			int num71 = ((49392 != num70) ? 1 : _003CModule_003E.get_PositiveSign[80]);
			num72 = loadVector3[num71];
			string_57 = "앮앮";
			array61 = new object[6];
		}
		array61[(nint)((Array)(object)string.Empty).LongLength] = (byte)Convert.ToInt32("0", Convert.ToInt32("10000", 2)) != 0;
		array61[checked(Launch * 1)] = 7520;
		array61[Convert.ToInt32("2", Marshal.SizeOf(typeof(__c__DisplayClass0_6)))] = char.ToString('\u0a71') + "κȸ";
		array61[array2[_003CModule_003E.KeyValuePair__2[0]]] = (int)array[12];
		array61[(uint)array[5]] = ~Convert.ToInt32("37777766762", 8);
		array61[994651720 / Marshal.SizeOf(typeof(get_DeserializationInProgress))] = -194751 + array2[55];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_57, array61);
		string text38 = string_57;
		string string_58 = char.ToString('큽') + "큽큽";
		object[] array62 = new object[(uint)array[5]];
		string text39;
		string string_59;
		object[] array63;
		checked
		{
			array62[756921 + Add_Ovf] = 825;
			array62[-9627 ^ Convert.ToInt32("37777755144", 8)] = Convert.ToInt32(char.ToString('5') + char.ToString('0') + "306", Convert.ToInt32("8", 16));
			array62[ExitAnyRead - 363251] = 31229;
			array62[3] = 'ɐ';
			_003CModule_003E.TAIWANLUNISOLAR(ref string_58, array62);
			text39 = string_58;
			string_59 = string.Concat(char.ToString('⯳'), "⯳⯳", char.ToString('⯲') + char.ToString('⯲') + "⯲⯲⯲⯲");
			array63 = new object[Marshal.SizeOf(typeof(OverlappedData))];
			int num73 = ((21241 > Convert.ToInt32("16b4f", 16)) ? 790466 : 7869);
			array63[0] = num73;
			int num74 = ~_003CModule_003E.get_PositiveSign[13];
			int num75 = ((60065 != Convert.ToInt32("1110101010100001", 2)) ? (-813896) : 810);
			array63[num74] = num75;
		}
		array63[(uint)array[0]] = (byte)((uint)_003CModule_003E.ActivityOptions[1] & (false ? 1u : 0u)) != 0;
		array63[3] = (char)Convert.ToInt32(char.ToString('1') + "447", Convert.ToInt32("8", 16));
		array63[4] = 1717;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_59, array63);
		array60[num72] = (char)Convert.ToInt32(text38 + text39 + string_59, checked(unchecked(Convert.ToInt32("37777034237", 8) + 247651) * Convert.ToInt32("1", 2)));
		array60[checked(_003CModule_003E.KeyValuePair__2[array2[26]] - -486276) >> PinvokeImpl] = (char)(-763 * ParamArrayAttribute);
		_003CModule_003E.GetMaxByteCount(ref string_55, array60);
		string format4 = string_55;
		now = DateTime.Now;
		string text40 = char.ToString((char)('⾺' & Convert.ToInt32("316e", 16)));
		string string_60 = "\ude65\ude65";
		object[] array64 = new object[(_003CModule_003E.ActivityOptions[209] > Convert.ToInt32("2071010", 8)) ? (-439403) : CancellationPending];
		array64[0] = 15438;
		array64[checked(array2[56] + -120393)] = (byte)checked(array2[57] + __9__10_0) != 0;
		array64[2] = _003CModule_003E.get_PositiveSign[221] / Convert.ToInt32("73e8", 16);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_60, array64);
		string text41 = text40 + string_60;
		string text42 = char.ToString(array[13]);
		string text43 = char.ToString('ℜ');
		string string_61 = string.Concat(char.ToString('昐'), char.ToString('晇'), char.ToString('明') + "明映");
		object[] array65 = new object[checked(Convert.ToInt32("fff12b81", 16) - -971906)];
		array65[Convert.ToInt32("0", Convert.ToInt32("1000", 2))] = false;
		array65[1] = Convert.ToInt32(char.ToString('2') + "2262", Convert.ToInt32("10", 8));
		char c11 = (char)array2[19];
		array65[(int)c11] = (int)array[14];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_61, array65);
		string string_62 = string.Concat(text41, text42 + text43 + string_61);
		object[] array66 = new object[1556973480 / checked(10 * array2[1]) / (1608872596 / _003CModule_003E.ActivityOptions[Convert.ToInt32("17", 16)])];
		string string_63 = "䢗";
		object[] array67 = new object[LoaderAllocatorScout ^ -751448];
		array67[0] = "$\u0018";
		array67[Convert.ToInt32("37776354740", 8) + 402977] = (char)(3750 % Marshal.SizeOf(typeof(Ordinal)));
		array67[Marshal.SizeOf(typeof(ENODATA))] = EventBuilder >> 4;
		int num76 = array[4];
		array67[num76] = string.Concat(char.ToString('+'), char.ToString(')'), char.ToString('\u0006') + "\u0002\0\u0001\u0002");
		array67[Convert.ToInt32("4", 16)] = 'ű';
		_003CModule_003E.TAIWANLUNISOLAR(ref string_63, array67);
		int num77 = Convert.ToInt32(string_63, Convert.ToInt32(char.ToString('1') + "0000000110000", 2) >> (int)((Array)(object)(char.ToString('\u0343') + char.ToString('\u0363') + "\u0366\u0366\u0349\u034e\u0346\u0311\u0311")).LongLength);
		int num78 = ~(Switch >> array2[4]);
		string string_64 = string.Concat(char.ToString('\u17fa'), char.ToString('\u17fa') + char.ToString('\u17fa') + "ឥឭឫឮឤ");
		object[] array68 = new object[Convert.ToInt32("11", 2)];
		array68[0] = 3823;
		array68[(uint)array[2]] = 2221;
		array68[982346626 / array2[58]] = false;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_64, array68);
		array66[num77] = (char)(num78 - Convert.ToInt32(string_64, -404931 - Convert.ToInt32("fff9d22d", 16)));
		char c12 = (char)_003CModule_003E.ActivityOptions[85];
		array66[352046 >> (c12 & 0x16)] = array6[(45458 <= (0x59F69 & _003CModule_003E.KeyValuePair__2[239])) ? DateTimeToken : (128421 << array2[1])];
		string string_65 = "覶覷";
		object[] array69 = new object[5];
		array69[0xA9E0A ^ Marshal.SizeOf(typeof(AsGuid))] = 363;
		array69[1] = (byte)array2[0] != 0;
		array69[set_Exclude] = (char)checked(80 * Convert.ToInt32("3", 16));
		array69[Marshal.SizeOf(typeof(CharSetMask)) & 3] = 32959;
		array69[Convert.ToInt32("4", Exclude)] = Marshal.SizeOf(typeof(GREGORIAN_US));
		_003CModule_003E.TAIWANLUNISOLAR(ref string_65, array69);
		array66[Convert.ToInt32(string_65, (0x11010 | Convert.ToInt32("217125", 8)) - 73299)] = Marshal.SizeOf(typeof(Internal_002ERuntime_002ECompilerServices));
		_003CModule_003E.GetMaxByteCount(ref string_62, array66);
		string text44 = string.Format(format4, now.ToString(string_62), string_0);
		System.Console.Write(text44 + string_1);
		string string_66 = "繏";
		object[] array70 = new object[4];
		array70[0] = false;
		array70[Convert.ToInt32("1", 8)] = ~Convert.ToInt32("ffffd078", 16);
		int num79 = Marshal.SizeOf(typeof(ENODATA));
		array70[num79] = ((Convert.ToInt32("11111111111111111010100101100001", 2) > 108149) ? 906162 : array2[59]);
		array70[Convert.ToInt32("11", 2)] = GetParentToken & 0x5F7D;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_66, array70);
		string string_67 = string_66;
		string text45 = char.ToString('1');
		string string_68 = "眩眨";
		object[] array71 = new object[151077605 / Convert.ToInt32("163206541", 8)];
		array71[checked(Convert.ToInt32("0", 2) * 123862)] = Marshal.SizeOf(typeof(FUNCFLAG_FRESTRICTED));
		array71[Convert.ToInt32("1", ((Array)(object)"\u0357\u036d\u032f\u033e\u033c\u035e\u0314\u035a\u032f\u035c\u035a\u033e\u034b\u0351\u0352\u030a").Length)] = 10857;
		array71[sizeof(short)] = false;
		array71[Convert.ToInt32("3", 16)] = 0x890 & array[19];
		int num80 = Marshal.SizeOf(typeof(IsValidText));
		char c13 = (char)Convert.ToInt32("1100111101111", 2);
		array71[num80] = (int)c13;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_68, array71);
		object[] array72 = new object[Convert.ToInt32(text45 + string_68, HashUpdateParity)];
		string string_69 = "軃";
		object[] array73 = new object[~Convert.ToInt32("37777777773", 8)];
		array73[0] = 5649;
		char getSByte = (char)GetSByte;
		array73[1] = (char)(int)getSByte;
		array73[Convert.ToInt32("2", 8)] = (char)Convert.ToInt32(char.ToString('6') + "5320", 8);
		array73[Convert.ToInt32("3", 8)] = string.Concat(char.ToString((char)Convert.ToInt32("480", 16)), char.ToString('M'), char.ToString('ó') + char.ToString('\u0011') + "\u0006\0\u0003");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_69, array73);
		int num84 = default(int);
		switch (checked(Convert.ToInt32(string_69, 2) * ~(-791976 ^ Convert.ToInt32("c15a6", 16))))
		{
		case 0:
		{
			string string_70 = string.Concat("\u0a11ਐ", char.ToString('ਐ') + "\u0a11\u0a11ਐਐ", "\u0a11ਐ\u0a11\u0a11ਐ" + "ਐ\u0a11\u0a11ਐਐ\u0a11ਐਐ");
			object[] array74 = new object[Convert.ToInt32("6", 16)];
			int num85 = ((70300 > UnderlyingField) ? 656445 : 0);
			array74[num85] = false;
			array74[sizeof(bool)] = 164;
			array74[2] = (byte)((Array)(object)string.Empty).Length != 0;
			array74[3] = 18;
			array74[(uint)array[5]] = string.Concat(char.ToString('\n'), char.ToString('\u0012') + "\u0001\u0002");
			array74[5] = 2379;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_70, array74);
			num84 = Convert.ToInt32(string_70, 2);
			break;
		}
		case 1:
		{
			int num81 = ((Convert.ToInt32("37777514421", 8) >= 49394) ? (-433948) : Win32Marshal);
			bool num82 = num81 < -231643;
			char c14 = (char)((Array)(object)string.Empty).Length;
			int num83 = (((num82 ? 1 : 0) != (int)c14) ? array2[Convert.ToInt32("17", 8)] : Convert.ToInt32("0", array[15]));
			num84 = num83;
			break;
		}
		}
		array72[num84] = (array2[60] ^ Convert.ToInt32("3003145", 8)) * Convert.ToInt32("1", 16) * -5;
		array72[checked(-321759 - (452668 + array2[16]))] = Marshal.SizeOf(typeof(IsCompleted));
		string string_71 = "ꅏꅣ";
		object[] array75 = new object[Bake / 71727641];
		int num86 = Convert.ToInt32("0", 16);
		int num87 = ((-41157 >= Convert.ToInt32("10110110001011001100", 2)) ? 478976 : 2653);
		array75[num86] = num87;
		array75[906311 + array2[61]] = Convert.ToInt32("37777777701", 8) * -2;
		array75[Convert.ToInt32("2", 8)] = char.ToString('ໄ') + char.ToString('ᆤ') + "Ⱏ㒿";
		array75[3] = 0x1CEF & Convert.ToInt32("16f3", 16);
		array75[4] = char.ToString((char)Convert.ToInt32("11111010", 2)) + ">\u0012";
		_003CModule_003E.TAIWANLUNISOLAR(ref string_71, array75);
		array72[(nint)((Array)(object)string_71).LongLength] = false;
		checked
		{
			int num88 = 1059742 - Convert.ToInt32(char.ToString('1') + "1100000011110010001", 2) - ~unchecked(get_PinnedObjectsCount - Convert.ToInt32("37774231150", 8));
			int[] loadVector4 = _003CModule_003E.LoadVector128;
			int num89 = ((-22760 < Convert.ToInt32("4b1ce", 16)) ? 34 : (-407204));
			array72[num88] = loadVector4[num89] * 61;
		}
		array72[4] = (char)_003CModule_003E.CalendarType[-283792 ^ array2[17]];
		int num90 = array2[24];
		char c15 = (char)(num90 % 10);
		array72[(int)c15] = array6[Convert.ToInt32(char.ToString('1') + char.ToString('0') + "11000", Marshal.SizeOf(typeof(ENODATA))) >> 4];
		_003CModule_003E.GetMaxByteCount(ref string_67, array72);
		System.Console.Write(string_67);
	}

	public unsafe void Second(string string_0)
	{
		char[] array = new char[4] { '\u0003', 'Ǫ', '›', '\u0001' };
		int[] array2 = new int[15]
		{
			2, 0, -4, 175, 131501, 1778572, 805858644, -25342, -94479, 457277,
			-491497, 46496, 533790, -134307891, -397904
		};
		char[] array3 = new char[_003CModule_003E.ActivityOptions[2]];
		int num = 0 / PreserveSig;
		char c = (char)Marshal.SizeOf(typeof(CrossThreadDependencyNotification));
		array3[num] = c;
		char[] array4 = array3;
		int[] array5 = new int[Marshal.SizeOf(typeof(UseHebrewParsing))];
		array5[Convert.ToInt32("11111111111111110010000100001100", 2) - -57076] = 5;
		int[] array6 = array5;
		string requires = Requires;
		string text = char.ToString('\ued70');
		string text2 = char.ToString('\ued71');
		string text3 = char.ToString('\ued76');
		string string_ = "젳젡";
		object[] array7 = new object[4];
		array7[_003CModule_003E.KeyValuePair__2[240] >> 30] = '໘';
		array7[1] = "гΨ";
		array7[10 % DateTimeToken] = string.Concat(char.ToString('Ũ'), char.ToString((char)Convert.ToInt32("51", 8)), char.ToString('Õ') + char.ToString('\b') + "\0\u0003");
		array7[~array2[2]] = 3118;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_, array7);
		string string_2 = string.Concat(text, text2, text3 + string_);
		object[] array8 = new object[(-922304 ^ _003CModule_003E.ActivityOptions[67]) - (Convert.ToInt32("11001" + "10000010000100000001101000", 2) | -390240)];
		int num2 = get_GenericTypeArguments;
		int num3 = num2 - Setter;
		int num4 = ((Convert.ToInt32("111111" + "11111111111110101001001010", 2) != -5558) ? (0xBE92B & Convert.ToInt32("dfb59", 16)) : Convert.ToInt32(char.ToString('2') + "362", Convert.ToInt32("10", 16)));
		int num5 = num4;
		array8[num3] = num5;
		char c2 = (char)Marshal.SizeOf(typeof(ENODATA));
		int num6 = 5 % (int)c2;
		int num7;
		if (-92824 > _003CModule_003E.KeyValuePair__2[Marshal.SizeOf(typeof(workQueue))])
		{
			num7 = 2017;
		}
		else
		{
			int createInstanceLic = CreateInstanceLic;
			num7 = createInstanceLic;
		}
		string text4 = char.ToString((char)num7);
		string text5 = char.ToString(array4[256488 - Convert.ToInt32("764750", 8)]);
		string string_3 = "\u218c\u20d2";
		object[] array9 = new object[Convert.ToInt32(char.ToString('1') + "01", 2)];
		array9[0] = 3943;
		array9[1 & array[3]] = (int)array[Convert.ToInt32("1", 8)];
		array9[2] = string.Concat(char.ToString((char)_003CModule_003E.ActivityOptions[14]), char.ToString('Ң') + "Ǆǟ");
		array9[3] = '\u035b';
		array9[4] = string.Concat(char.ToString('í'), char.ToString((char)Convert.ToInt32("1001111", 2)), char.ToString('ʕ') + char.ToString('\u001e') + "^x");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_3, array9);
		array8[num6] = text4 + text5 + string_3;
		int num8;
		if (40495 == _003CModule_003E.get_PositiveSign[81] / 50096)
		{
			string string_4 = "嬲嬳";
			object[] array10 = new object[5];
			array10[array2[Convert.ToInt32("1", 16)]] = '刼';
			array10[Convert.ToInt32("1", 8) * 1] = 844;
			array10[2] = Convert.ToInt32(char.ToString('1') + "00", 2);
			array10[3] = 289;
			array10[Convert.ToInt32("4", 16)] = 'і';
			_003CModule_003E.TAIWANLUNISOLAR(ref string_4, array10);
			num8 = Convert.ToInt32(string_4, checked(Tags - 628894));
		}
		else
		{
			char c3 = (char)Convert.ToInt32("1011000110010001", 2);
			num8 = (((int)c3 >= 957395) ? (-677167) : 129253);
		}
		checked
		{
			array8[num8] = unchecked(Marshal.SizeOf(typeof(LongToString)) - (Convert.ToInt32("41057", 16) ^ 0x5576)) * unchecked(-717720 + Convert.ToInt32(char.ToString('2') + char.ToString('5') + "71626", 8));
		}
		int num9 = (3557140 >> array2[0]) ^ ((((36031 >= array2[4]) ? 681742 : _003CModule_003E.get_PositiveSign[222]) != -45008) ? (4446430 % array2[5]) : (-412375));
		int launch = Launch;
		array8[num9] = (byte)((uint)launch & (false ? 1u : 0u)) != 0;
		int num10 = array2[6];
		int num11 = ((((array2[7] == -25342) ? 1 : 0) != _003CModule_003E.ActivityOptions[1]) ? 13138 : Convert.ToInt32("10011010010001111001", 2));
		int num12;
		if (num10 / num11 == 61338)
		{
			num12 = -996068 + (142792 + ToHexString);
		}
		else
		{
			string string_5 = string.Concat(char.ToString('勇') + "勇勇勇", char.ToString('勇') + "勇勇", "勇勇勇勇勇勺勺勇勺勺勺" + "勺勺勺勺勇勺勺勇勺勺勇勺勇勺");
			object[] array11 = new object[6];
			array11[0] = 20004;
			array11[Convert.ToInt32("1", 16)] = string.Concat(char.ToString('ƻ'), char.ToString((char)array2[3]), char.ToString('\u0005') + "\u0003-");
			int num13 = ((Convert.ToInt32("fffef998", 16) > MicrosoftTelemetry) ? 2 : Marshal.SizeOf(typeof(GetVarIndexOfMemId)));
			array11[num13] = 4658;
			array11[(Convert.ToInt32("1110100010001101", 2) > -138037) ? 3 : (-49264)] = false;
			array11[checked(array2[9] - 457273)] = 8748;
			array11[(nint)((Array)(object)"\u0355\u0306\u0318.\u0331").LongLength * sizeof(byte)] = VolatileIntPtr - -671518;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_5, array11);
			num12 = Convert.ToInt32(string_5, 2);
		}
		array8[num12] = (char)Marshal.SizeOf(typeof(MultiplyBySelectedScalarWideningUpperAndAdd));
		_003CModule_003E.GetMaxByteCount(ref string_2, array8);
		if (requires == string_2)
		{
			string text6 = char.ToString('⤛');
			string text7 = char.ToString('⤚');
			string text8 = char.ToString('⤝');
			string string_6 = "箜箎";
			object[] array12 = new object[Convert.ToInt32("11111111111111011001101101010000", 2) - -156851];
			array12[0] = (char)Convert.ToInt32("11" + "00" + "011101100", 2);
			array12[0xB5A1 ^ array2[11]] = 6632;
			array12[GetNestedType % 4] = 'ῂ';
			_003CModule_003E.TAIWANLUNISOLAR(ref string_6, array12);
			string string_7 = string.Concat(text6, text7 + text8 + string_6);
			int num14 = ((Convert.ToInt32("110" + "111011011" + "0111110001100011000", Convert.ToInt32("2", 16)) / 63530 != Convert.ToInt32(char.ToString('1') + char.ToString('1') + "111111111111110110100111001110", Convert.ToInt32("2", 16))) ? checked((3250151 >> sizeof(uint)) - 203130) : (-679489));
			object[] array13 = new object[num14];
			int num15 = (Convert.ToInt32("22345ba9", 16) + Convert.ToInt32("11111111111111101011110010000011", 2)) / Convert.ToInt32("66" + "02633", 8) >> Convert.ToInt32(char.ToString('1') + char.ToString('1') + "0111", array2[0]) % 22;
			int num16;
			if (((Convert.ToInt32("3224041", 8) - 772141) & 0x1DA4D) != _003CModule_003E.CalendarType[25])
			{
				string string_8 = "\uf0ba\uf0ee";
				object[] array14 = new object[5];
				array14[Convert.ToInt32("0", Convert.ToInt32("8", 16))] = 2153;
				array14[(nint)((Array)(object)"\u034b").LongLength] = 'Q';
				array14[sizeof(short)] = checked(Marshal.SizeOf(typeof(NoGCRegion)) * Convert.ToInt32("1", 2));
				array14[(uint)array[0]] = TryDequeue;
				array14[Convert.ToInt32("17e51090", 16) / 100221988] = _003CModule_003E.ActivityOptions[69];
				_003CModule_003E.TAIWANLUNISOLAR(ref string_8, array14);
				num16 = Convert.ToInt32(string_8, 16);
			}
			else
			{
				num16 = 1462475 % (0x8E802 | array2[12]);
			}
			array13[num15] = num16;
			array13[checked(-19403 - ExecutionAndPublicationViaConstructor)] = -7863 * Convert.ToInt32(char.ToString('f') + char.ToString('f') + "ffffed", 16) >> array6[(nint)((Array)(object)string.Empty).LongLength];
			int num17 = ~(array2[13] & Convert.ToInt32("10111101111111101010110100011111", 2)) / Marshal.SizeOf(typeof(RunningContinuationList));
			int num18 = ((0 != Convert.ToInt32("0", 16)) ? (-983772) : Convert.ToInt32("4161", 8));
			int num19 = num18;
			string text9 = char.ToString((char)num19);
			string string_9 = "侴䉋";
			object[] array15 = new object[_003CModule_003E.KeyValuePair__2[0]];
			array15[0] = (int)array[_003CModule_003E.ActivityOptions[0]];
			array15[Convert.ToInt32("2457134", 8) ^ Convert.ToInt32("a5e5d", 16)] = (byte)checked(Convert.ToInt32("61250", 16) + array2[14]) != 0;
			array15[sizeof(char)] = string.Concat(char.ToString('ⅼ'), char.ToString('G'), char.ToString('\u0089') + "\v\0\0\u0002");
			_003CModule_003E.TAIWANLUNISOLAR(ref string_9, array15);
			array13[num17] = text9 + string_9;
			array13[IndentSize] = ~(Marshal.SizeOf(typeof(Prefetch0)) - Convert.ToInt32("37777775737", 8) * -689);
			_003CModule_003E.GetMaxByteCount(ref string_7, array13);
			get_Week(string_7, string_0);
		}
	}

	public unsafe void AutoResetEvent(string string_0)
	{
		char[] array = new char[9] { '\u0002', '\0', '\u0001', '\u0004', '\a', '#', '\u0817', '\u0005', 'ę' };
		int[] array2 = new int[25]
		{
			2, 0, 1, 8968, -66750, 9227, 511889, 6962, -329043888, 5,
			-3, -1, 10, 70, -51491, -502137, 720, 627292, 816595, -84398,
			-61839, 45672, -85518, 2740, 642361
		};
		char c = (char)_003CModule_003E.ActivityOptions[0];
		char[] array3 = new char[(uint)c];
		array3[Convert.ToInt32("1227536", 8) >> 21] = '\u0002';
		array3[1 * sizeof(bool)] = (char)(array[7] & array2[9]);
		char[] array4 = array3;
		int[] array5 = new int[1] { _003CModule_003E.ActivityOptions[sizeof(ushort)] };
		string requires = Requires;
		string text = char.ToString('攨');
		string text2 = char.ToString((char)checked(Marshal.SizeOf(typeof(Stable)) * Convert.ToInt32("57", _003CModule_003E.get_PositiveSign[3])));
		string text3 = char.ToString('攮');
		string string_ = "疫疹";
		object[] array6 = new object[119816 >> Convert.ToInt32("17", 8)];
		array6[Convert.ToInt32("0", array2[0])] = 'ຎ';
		array6[1] = char.ToString('ò') + "\u0096|";
		int num = Convert.ToInt32("0", 16) | 2;
		int num2 = default(int);
		switch (checked(Convert.ToInt32("37775560204", 8) - Convert.ToInt32("fff6e084", 16)))
		{
		case 0:
			num2 = 0;
			break;
		}
		array6[num] = (byte)num2 != 0;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_, array6);
		string string_2 = string.Concat(text, text2, text3 + string_);
		char c2 = (char)(Launch | '\u0001');
		object[] array7 = new object[(uint)array4[(int)c2]];
		string string_3 = string.Concat(char.ToString('먭'), char.ToString('멸') + char.ToString('멾') + "먢멿");
		object[] array8 = new object[_003CModule_003E.get_PositiveSign[2]];
		array8[0 * _003CModule_003E.ActivityOptions[210]] = 40368;
		array8[array2[2]] = false;
		array8[Convert.ToInt32("37775726432", 8) ^ -545512] = checked(_003CModule_003E.ActivityOptions[27] * 17);
		array8[3] = (char)checked(-2920 * Convert.ToInt32("37777777776", 8));
		array8[Convert.ToInt32("4", 8)] = 397;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_3, array8);
		int num3 = -507278 + Convert.ToInt32(string_3, 16);
		string text4 = char.ToString('\u0097');
		string text5 = char.ToString((char)(((-458 == AddSaturateScalar) ? ((char)FindTypes) : '娪') | Marshal.SizeOf(typeof(TryWriteUInt64LittleEndian))));
		string text6 = char.ToString((char)checked(-17 * RuntimeModule));
		string text7 = char.ToString('¢');
		string string_4 = char.ToString((char)Convert.ToInt32("3f17", 16)) + "㼎㼍";
		object[] array9 = new object[3];
		char c3 = array[1];
		array9[(uint)c3] = 6253;
		array9[1] = false;
		array9[(49029 == Convert.ToInt32("110037", 8)) ? 563419 : set_Exclude] = ~Convert.ToInt32("ffffd95e", 16);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_4, array9);
		array7[num3] = string.Concat(text4, text5, text6 + text7 + string_4);
		char c4 = (char)_003CModule_003E.KeyValuePair__2[155];
		array7[array5[(int)c4 >> (int)array[4]]] = 912;
		string string_5 = "Ὓ";
		object[] array10 = new object[3];
		array10[0] = string.Concat(char.ToString('Θ'), char.ToString('ώ') + "ɏÍ");
		array10[1] = (int)array[6];
		array10[array2[0]] = char.ToString('ؠ') + "ڄ.";
		_003CModule_003E.TAIWANLUNISOLAR(ref string_5, array10);
		char num4 = array4[Convert.ToInt32(string_5, ((Array)(object)("\u0327\u0307\u0350\u0347\u033c\u032e\u0300" + "\u034d\u033b\u032e\u0306\u032b\u0323\u035b\u0321\u0329")).Length)];
		string string_6 = string.Concat(char.ToString('ꪈ') + char.ToString('ꪈ') + "ꪈꪈꪈꪈ", char.ToString('ꪈ') + "ꪈꪈ" + "ꪈꪈꪈꪈꪈꪈꪈꪈꪈꪉꪉꪈꪈꪉꪉꪈꪉꪉꪉꪉꪉꪉꪈ");
		object[] array11 = new object[Convert.ToInt32("4", 16)];
		array11[0] = '⯺';
		array11[Marshal.SizeOf(typeof(UseHebrewParsing))] = 2178;
		array11[array2[0]] = 29337;
		char c5 = (char)Convert.ToInt32("3", 16);
		array11[(uint)c5] = Convert.ToInt32("1040", 8) | 0x3A4;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_6, array11);
		array7[(uint)num4] = ~Convert.ToInt32(string_6, 2);
		int num5 = Marshal.SizeOf(typeof(CharSetMask));
		char c6 = (char)checked(num5 * 1);
		int num6 = c6;
		string string_7 = "⊮☸";
		object[] array12 = new object[set_Exclude];
		array12[(uint)array[1]] = string.Concat(char.ToString((char)Convert.ToInt32("77", 16)), char.ToString('\u0018') + "8\u0012\0\u0001\u0005");
		array12[1] = array2[(nint)((Array)(object)"\u0314\u0301\u035c").LongLength];
		_003CModule_003E.TAIWANLUNISOLAR(ref string_7, array12);
		array7[num6] = string_7;
		string text8 = char.ToString('1');
		string string_8 = "戢戢";
		object[] array13 = new object[6];
		int num7 = array[1];
		array13[num7] = 2601;
		array13[1] = false;
		array13[(uint)array[0]] = 2311;
		array13[3] = 13447;
		array13[Marshal.SizeOf(typeof(IsValidText))] = Convert.ToInt32("7177", 8) & Convert.ToInt32("110100101011", 2);
		array13[Parameters] = 3632;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_8, array13);
		array7[Convert.ToInt32(text8 + string_8, -2 * (Convert.ToInt32("37777777777", 8) * Launch))] = 9583;
		_003CModule_003E.GetMaxByteCount(ref string_2, array7);
		if (requires == string_2)
		{
			string string_9 = string.Concat(char.ToString('ﯤ') + char.ToString('ﯤ') + "ﯤﯤﯥﯥﯥ", "ﯤﯥﯤ" + "ﯤﯥﯥﯤﯤﯥ");
			object[] array14 = new object[5];
			array14[0] = 8181;
			array14[Marshal.SizeOf(typeof(UseHebrewParsing))] = (byte)Convert.ToInt32("0", 2) != 0;
			checked
			{
				array14[Convert.ToInt32("11111111111100110101011001111001", 2) + 829833] = _003CModule_003E.KeyValuePair__2[array2[13]];
				int num8 = ((((73730 == Marshal.SizeOf(typeof(S9))) ? 1u : 0u) != array[1]) ? 3 : 834875);
				array14[num8] = 80134 + array2[14];
				array14[4] = 2955;
				_003CModule_003E.TAIWANLUNISOLAR(ref string_9, array14);
			}
			string text9 = char.ToString((char)Convert.ToInt32(string_9, Convert.ToInt32("2", 8)));
			string text10 = char.ToString('\uf161');
			string string_10 = "焯焦";
			object[] array15 = new object[Convert.ToInt32("100110000101111000", 2) ^ Convert.ToInt32("460575", 8)];
			array15[(nint)((Array)(object)string.Empty).LongLength] = char.ToString('ᢨ') + "ॸ⿄";
			array15[Launch] = 'ᅊ';
			array15[2] = (byte)((uint)Item5 & (true ? 1u : 0u)) != 0;
			array15[3] = "%\u0012";
			array15[(uint)array[3]] = char.ToString('\u0a03') + "༐ώ";
			_003CModule_003E.TAIWANLUNISOLAR(ref string_10, array15);
			string string_11 = text9 + text10 + string_10;
			object[] array16 = new object[checked(Convert.ToInt32(char.ToString('2') + char.ToString('3') + "44055", 8) - 641071) * _003CModule_003E.CalendarType[Marshal.SizeOf(typeof(FractionalDigitsCount))]];
			string string_12 = "፩";
			object[] array17 = new object[(nint)((Array)(object)(char.ToString('\u0355') + char.ToString('\u030e') + "\u036e\u0321\u0366")).LongLength];
			array17[0] = false;
			array17[Convert.ToInt32("1", 2)] = 2334;
			array17[2] = 0x188 | array2[16];
			array17[3] = 'Џ';
			array17[4] = (char)(_003CModule_003E.ActivityOptions[211] | _003CModule_003E.ActivityOptions[212]);
			_003CModule_003E.TAIWANLUNISOLAR(ref string_12, array17);
			int num9 = Convert.ToInt32(string_12, 8) % (Convert.ToInt32(char.ToString('1') + "11011" + "1101011111011", 2) & 0x4ABFB);
			string text11 = char.ToString((char)_003CModule_003E.LoadVector128[(uint)array[5]]);
			string string_13 = "憴攬";
			object[] array18 = new object[_003CModule_003E.get_PositiveSign[0]];
			array18[0] = Convert.ToInt32(char.ToString('1') + char.ToString('0') + "0001", 2);
			array18[Convert.ToInt32("37774420407", 8) + 909050] = 'â';
			array18[2] = '\u02de';
			array18[3] = (byte)((Array)(object)string.Empty).Length != 0;
			array18[checked(-1992 - UtcSortPattern)] = "\u00a0\u0084";
			array18[(nint)((Array)(object)(char.ToString('\u0322') + char.ToString('\u0325') + "\u0321\u033a\u0342")).LongLength] = char.ToString('\u0002') + "\u0006\v";
			_003CModule_003E.TAIWANLUNISOLAR(ref string_13, array18);
			array16[num9] = text11 + string_13;
			int num10 = ((-66750 != array2[4]) ? Convert.ToInt32(char.ToString('f') + char.ToString('f') + "f51cd5", 16) : (array2[2] & 1));
			int num11 = ((((Convert.ToInt32("111111111" + "11111" + "111010100101000001", array[0]) == -59090) ? 1 : 0) == (array2[1] | 0)) ? 1 : 521146);
			int num12 = num10 & num11;
			string string_14 = char.ToString((char)Convert.ToInt32("1101111000111100", 2)) + "\ude3d\ude38";
			object[] array19 = new object[(nint)((Array)(object)(char.ToString('\u032c') + char.ToString('\u036d') + "\u030a\u034f\u0347\u0312")).LongLength];
			array19[Item5 << 17] = (char)__3__name;
			array19[array2[2]] = 10043;
			array19[checked(2 * sizeof(byte))] = 8098;
			array19[3] = 30275;
			array19[Convert.ToInt32("11111111111111011111100100111101", 2) + 132807] = false;
			array19[5] = 0x1DF3 & _003CModule_003E.get_PositiveSign[223];
			_003CModule_003E.TAIWANLUNISOLAR(ref string_14, array19);
			string text12 = char.ToString((char)Convert.ToInt32(string_14, sizeof(long)));
			string text13 = char.ToString((char)(~(Convert.ToInt32("fffc2010", 16) - -253678)));
			string text14 = char.ToString('%');
			string text15 = char.ToString((char)(_003CModule_003E.get_PositiveSign[8] % array2[12]));
			string string_15 = "\ue1bc\ue1be";
			object[] array20 = new object[Marshal.SizeOf(typeof(AsyncLocalValueMap)) + -950957];
			array20[0] = Convert.ToInt32("60423", 8);
			array20[1749201245 >> Marshal.SizeOf(typeof(AssemblyNameProxy))] = false;
			array20[_003CModule_003E.ActivityOptions[0]] = _003CModule_003E.KeyValuePair__2[241] * -9;
			array20[3] = array2[Parameters];
			array20[4] = (char)('㿛' & Convert.ToInt32("10110111010111", 2));
			_003CModule_003E.TAIWANLUNISOLAR(ref string_15, array20);
			array16[num12] = string.Concat(text12, text13, text14 + text15 + string_15);
			char c7 = (char)sizeof(short);
			char num13 = c7;
			string text16 = char.ToString((char)(Convert.ToInt32("12", 16) | checked(unchecked((int)array[8]) * 2)));
			int num14 = default(int);
			switch (Convert.ToInt32("11001", 2) % 10 % (int)array[Convert.ToInt32("0", 16)])
			{
			case 0:
			{
				int num15 = Convert.ToInt32("fffec536", 16);
				num14 = num15;
				break;
			}
			case 1:
				num14 = Convert.ToInt32(char.ToString('2') + "e7", Convert.ToInt32("10", 16));
				break;
			case 2:
				num14 = Marshal.SizeOf(typeof(id));
				break;
			}
			string text17 = char.ToString((char)num14);
			string text18 = char.ToString('\n');
			string string_16 = "肐肈";
			object[] array21 = new object[checked(TraceOperation - Convert.ToInt32("10101011100010111101", 2))];
			array21[0] = (byte)array2[(uint)array[2]] != 0;
			array21[Convert.ToInt32("1", Convert.ToInt32("10", 16))] = 163;
			array21[2] = 4891;
			array21[checked(array2[10] * -1)] = 18060;
			array21[4] = char.ToString((char)Marshal.SizeOf(typeof(NextBytes))) + "ٺi";
			array21[~Concat] = 4971;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_16, array21);
			array16[(uint)num13] = string.Concat(text16, text17, text18 + string_16);
			int num16 = default(int);
			switch (85837374 / Marshal.SizeOf(typeof(MinorRevision)))
			{
			case 0:
				num16 = -508535;
				break;
			case 1:
				num16 = Convert.ToInt32("0", 16);
				break;
			}
			int num17 = default(int);
			switch (checked(num16 * 257082))
			{
			case 0:
				num17 = Marshal.SizeOf(typeof(PublicationOnly)) << 3;
				break;
			}
			int num18 = num17;
			bool num19 = Marshal.SizeOf(typeof(__9__57_1)) > -515955;
			int num20 = default(int);
			switch (Convert.ToInt32("99a21", 16))
			{
			case 629280:
				num20 = _003CModule_003E.get_PositiveSign[224];
				break;
			case 629281:
				num20 = 0;
				break;
			case 629282:
				num20 = -269491;
				break;
			}
			int num21 = (((num19 ? 1 : 0) != num20) ? AllowThousands : (-232584));
			array16[3] = num18 / num21;
			_003CModule_003E.GetMaxByteCount(ref string_11, array16);
			get_Week(string_11, string_0);
			return;
		}
		string requires2 = Requires;
		string text19 = char.ToString((char)checked(-4573 * unchecked(Convert.ToInt32("fffffffb", 16) % -2)));
		int num22 = ((((-34309 < array2[6]) ? 1 : 0) != Item5) ? 4570 : Convert.ToInt32(char.ToString('3') + char.ToString('7') + "774733767", get_CanSeek));
		string text20 = char.ToString((char)num22);
		string string_17 = "⦵⦼";
		object[] array22 = new object[Convert.ToInt32(char.ToString('1') + "10", 2)];
		array22[Convert.ToInt32("0", 16)] = true;
		char c8 = (char)Marshal.SizeOf(typeof(ParentName));
		array22[1] = (int)c8;
		array22[sizeof(char)] = (byte)((uint)Item5 | (false ? 1u : 0u)) != 0;
		array22[3] = Convert.ToInt32(char.ToString('1') + char.ToString('7') + "367", 8);
		array22[Convert.ToInt32("4", 8)] = (char)(~Convert.ToInt32("ffffee4b", 16));
		array22[5] = 930;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_17, array22);
		string string_18 = text19 + text20 + string_17;
		string string_19 = string.Concat(char.ToString((char)Convert.ToInt32("111011000110100", 2)), char.ToString((char)Convert.ToInt32("111011000110100", 2)), char.ToString('瘴') + "瘴瘴癦癥癠");
		object[] array23 = new object[3];
		array23[0] = string.Concat("ʅƇ", char.ToString('Ó') + "W\u009b\u0010");
		array23[Convert.ToInt32("1", Exclude)] = 827388 - array2[18];
		array23[(nint)((Array)(object)"\u033a\u033a\u0325").LongLength & Convert.ToInt32("2", 16)] = IsHardwareAccelerated / 63859;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_19, array23);
		int num23 = (int)((Convert.ToInt32(string_19, _003CModule_003E.KeyValuePair__2[242] / 132354813) >= 752929) ? (Convert.ToInt32("37772663412", 8) * 1 + _003CModule_003E.ActivityOptions[Convert.ToInt32("106", 8)]) : ((nint)((Array)(object)(char.ToString('\u032a') + char.ToString('\u033e') + "\u0306\u0354")).LongLength | Convert.ToInt32("4", 8)));
		object[] array24 = new object[num23];
		int aNSICodePage = ANSICodePage;
		int num24 = default(int);
		switch (Convert.ToInt32("0", 16) * -65678)
		{
		case 0:
			num24 = 1119885;
			break;
		case 1:
			num24 = 598292;
			break;
		case 2:
			num24 = -190685;
			break;
		}
		int num25 = aNSICodePage ^ (num24 % (0xC482 | Is64BitOperatingSystem));
		string text21 = char.ToString((char)(checked(TickCount64 - 406757) << -759163 + PublicProperties));
		string text22 = char.ToString('ĵ');
		string string_20 = char.ToString((char)_003CModule_003E.KeyValuePair__2[243]) + "膻臾";
		object[] array25 = new object[(nint)((Array)(object)(char.ToString('.') + char.ToString('\u035f') + "\u032ah\u0336\u032e")).LongLength];
		int num26 = _003CModule_003E.ActivityOptions[sizeof(sbyte)];
		int num27 = ((-32354 > Marshal.SizeOf(typeof(DynamicMethod))) ? (-616355) : 0);
		array25[num26] = (byte)num27 != 0;
		string string_21;
		object[] array26;
		checked
		{
			array25[1 * unchecked((int)array[2])] = 15785;
			array25[2] = string.Concat(char.ToString('މ'), char.ToString('\u0015') + "\u000e\u0003\0\u0002");
			array25[unchecked(Marshal.SizeOf(typeof(MdSigCallingConvention)) % 6)] = 5377;
			array25[283074 >> Convert.ToInt32("10000", 2)] = Convert.ToInt32("110" + "001001111", 2);
			array25[Convert.ToInt32("4506e", 16) + -282729] = array2[Marshal.SizeOf(typeof(Prefix1))];
			_003CModule_003E.TAIWANLUNISOLAR(ref string_20, array25);
			array24[num25] = string.Concat(text21, text22 + string_20);
			string_21 = "胮";
			array26 = new object[3];
			array26[-84398 ^ array2[19]] = 9181;
		}
		array26[(uint)array[(nint)((Array)(object)"\u033c\u0314").LongLength]] = ((array2[20] <= 95817) ? 12854 : (-83988));
		array26[(nint)((Array)(object)"\u034a\u0322").LongLength] = 10956;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_21, array26);
		int num28 = Convert.ToInt32(string_21, Convert.ToInt32("10", 16));
		string string_22 = char.ToString('鷱') + "鷰鷰";
		int num29 = ((63326 != Marshal.SizeOf(typeof(DefinedTypes))) ? (-368130) : 3);
		object[] array27 = new object[num29];
		int num30 = 0 << Convert.ToInt32("1", 16);
		char c9 = (char)Convert.ToInt32("11011111010", 2);
		array27[num30] = c9;
		array27[Convert.ToInt32("1", 2)] = 1354;
		array27[_003CModule_003E.get_PositiveSign[225] >> 20] = char.ToString('軛') + "ȫv";
		_003CModule_003E.TAIWANLUNISOLAR(ref string_22, array27);
		string text23 = string_22;
		string string_23 = string.Concat(char.ToString((char)Convert.ToInt32("131150", 8)), char.ToString((char)array2[21]), char.ToString('뉨') + "뉩뉨뉨뉨뉩");
		object[] array28 = new object[6];
		char c10 = (char)Convert.ToInt32("0", 16);
		array28[(int)c10] = 35142;
		array28[sizeof(bool)] = Marshal.SizeOf(typeof(RemoveAll));
		array28[array2[0]] = string.Concat(char.ToString('\u1cda'), char.ToString('ȑ') + "·c");
		array28[3] = 'ę';
		array28[4] = false;
		array28[(nint)((array2[22] == -85518) ? ((Array)(object)"\u032a\u0344\u030a\u033a\u033b").LongLength : (-114172))] = checked(AssemblyRef + _003CModule_003E.KeyValuePair__2[244]);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_23, array28);
		array24[num28] = Convert.ToInt32(text23 + string_23, 2);
		array24[0x6769B ^ (0xB59C9 ^ ~_003CModule_003E.get_PositiveSign[226])] = 0x80 | GetCharCount;
		array24[checked(36755 + (array2[8] | -1814269856))] = (byte)(Convert.ToInt32(char.ToString('7') + char.ToString('6') + "59a", sizeof(decimal)) * Convert.ToInt32("11111111" + "111" + "111111111111111111111", 2) - -484762) != 0;
		_003CModule_003E.GetMaxByteCount(ref string_18, array24);
		if (requires2 == string_18)
		{
			string string_24 = string.Concat(char.ToString((char)Convert.ToInt32("15545", 8)), char.ToString('᭣') + "᭥᭢᭡");
			object[] array29 = new object[6];
			array29[Convert.ToInt32("0", 16) % AnsiCodePage] = 2043;
			array29[1] = 785;
			array29[Convert.ToInt32("2", 16)] = string.Concat(char.ToString('ē'), char.ToString('¶') + char.ToString('\u0005') + "\r\u0006\0\u0002");
			array29[Convert.ToInt32("3", 16)] = 596480088 / Convert.ToInt32("100110100100001110001", 2);
			array29[-2 * _003CModule_003E.get_PositiveSign[13]] = (byte)(~array2[11]) != 0;
			array29[5] = string.Concat(char.ToString('"'), char.ToString((char)array2[23]), char.ToString(',') + "Ĕt");
			_003CModule_003E.TAIWANLUNISOLAR(ref string_24, array29);
			string text24 = char.ToString((char)Convert.ToInt32(string_24, Task_Start_AlreadyStarted + Arg_TypeNotSupported));
			string text25 = char.ToString((char)((Convert.ToInt32("1111111" + "1111111110001101010101011", 2) != -58709) ? 4294018502u : '䔟'));
			string string_25 = "饮饧";
			object[] array30 = new object[Marshal.SizeOf(typeof(CharSetMask))];
			int num31 = Convert.ToInt32("0", 16);
			int num32 = ((82724 != Convert.ToInt32("37777524105", 8)) ? 14227 : (-783998));
			array30[num31] = num32;
			array30[1 * (nint)((Array)(object)"\u0336").LongLength] = (char)Convert.ToInt32(char.ToString('6') + "6711", 8);
			array30[2] = string.Concat(char.ToString('⇘'), char.ToString('ᓿ'), char.ToString('\u0012') + "\u0013\u0010\u0011");
			_003CModule_003E.TAIWANLUNISOLAR(ref string_25, array30);
			string string_26 = text24 + text25 + string_25;
			int[] loadVector = _003CModule_003E.LoadVector128;
			object[] array31;
			checked
			{
				int num33 = default(int);
				switch (array2[24] - Convert.ToInt32("2346470", 8))
				{
				case 0:
					num33 = 722933;
					break;
				case 1:
					num33 = -413121;
					break;
				}
				array31 = new object[loadVector[num33 + 413123]];
			}
			int num34 = (checked(Marshal.SizeOf(typeof(Struct4)) * 13) | 0x15ED9) + SetProvider;
			int lF = LF;
			char c11 = (char)(lF / 82491);
			array31[num34] = (char)(int)c11;
			string string_27 = "Ế";
			object[] array32 = new object[3];
			array32[_003CModule_003E.ActivityOptions[1] << 4] = ~Convert.ToInt32("37777761425", 8);
			array32[Marshal.SizeOf(typeof(UseHebrewParsing))] = string.Concat(char.ToString('('), char.ToString('\u0014'), char.ToString('\u001c') + "/5");
			array32[_003CModule_003E.ActivityOptions[0]] = (char)(1149153380 / Convert.ToInt32("1000111110111010000110100", 2));
			_003CModule_003E.TAIWANLUNISOLAR(ref string_27, array32);
			IntPtr intPtr = (nint)((Array)(object)string_27).LongLength;
			int num35 = checked(Marshal.SizeOf(typeof(WidenAsciiToUtf16)) - Marshal.SizeOf(typeof(UserProfile))) * ((_003CModule_003E.KeyValuePair__2[245] != Convert.ToInt32("11111111111111101100100111111000", 2)) ? Convert.ToInt32("9", 16) : (-473471));
			array31[(nint)intPtr] = num35;
			_003CModule_003E.GetMaxByteCount(ref string_26, array31);
			get_Week(string_26, string_0);
		}
	}

	public unsafe void CanonicalBasis(string string_0)
	{
		char[] array = new char[4] { '\0', '\u0001', '\u0004', 'ဂ' };
		int[] array2 = new int[15]
		{
			2, 0, -72150, 718620, -512457, 16, -10, 58525, -7191, 595922,
			135030, -496178, 48665, -597096, 8980
		};
		char[] array3 = new char[2];
		array3[(nint)((Array)(object)string.Empty).LongLength] = 'ഭ';
		array3[1] = (char)sizeof(ulong);
		char[] array4 = array3;
		int[] array5 = new int[Convert.ToInt32("2", 8)];
		array5[0] = Convert.ToInt32(char.ToString('1') + "0000", sizeof(short));
		array5[checked(array2[7] - 58524)] = -16878;
		int[] array6 = array5;
		string requires = Requires;
		string string_ = string.Concat(char.ToString('Į'), char.ToString('Ī'), char.ToString('ī') + "įĬ");
		object[] array7 = new object[2];
		array7[array2[1]] = char.ToString('\u001e') + "\u0016,";
		array7[1] = '¿';
		_003CModule_003E.TAIWANLUNISOLAR(ref string_, array7);
		string text = char.ToString((char)Convert.ToInt32(string_, _003CModule_003E.get_PositiveSign[3]));
		string text2 = char.ToString((char)Marshal.SizeOf(typeof(get_GenericParameterPosition)));
		string string_2 = char.ToString('盹') + "盤盹";
		object[] array8 = new object[Convert.ToInt32(char.ToString('1') + "00", 2)];
		array8[0] = string.Concat(char.ToString('\u1b81'), char.ToString('ඤ') + "ǀ\t");
		array8[checked(Convert.ToInt32("37774473625", 8) - -886892)] = string.Concat(char.ToString('\u0730'), char.ToString((char)_003CModule_003E.get_PositiveSign[113]), char.ToString('Ɵ') + char.ToString('|') + "ǹ\u007f");
		array8[2] = (byte)checked(-772787 + Marshal.SizeOf(typeof(GetEnumName))) != 0;
		array8[15 % Convert.ToInt32("6", 8)] = checked(-118 * Local);
		_003CModule_003E.TAIWANLUNISOLAR(ref string_2, array8);
		string string_3 = string.Concat(text, text2 + string_2);
		int num = checked((Marshal.SizeOf(typeof(Double)) - 104805) * Convert.ToInt32("fff" + "fffff", 16));
		string string_4 = string.Concat(char.ToString('瞧') + "瞧瞧瞧", char.ToString('瞧') + char.ToString('瞧') + "瞧瞧瞧", char.ToString('瞧') + "瞧瞧瞧瞧瞧瞧瞧瞧瞧瞧瞧瞧瞧瞧瞧瞧瞧瞧瞧瞧瞧瞧");
		object[] array9 = new object[Marshal.SizeOf(typeof(ENODATA))];
		int num2 = Convert.ToInt32("386cb9f2", 16) >> Convert.ToInt32("1e", 16);
		int num3 = default(int);
		switch (Convert.ToInt32("12", 8) % 4)
		{
		case 0:
			num3 = Marshal.SizeOf(typeof(StackTraceHiddenAttribute));
			break;
		case 1:
			num3 = Convert.ToInt32("11111111111111111110110001001101", 2);
			break;
		case 2:
			num3 = 10907;
			break;
		case 3:
			num3 = 483108;
			break;
		}
		array9[num2] = num3;
		array9[Convert.ToInt32("5", 16) % 2] = -839518 + StartupHookNameOrPath;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_4, array9);
		object[] array10 = new object[checked(num * Convert.ToInt32(string_4, Convert.ToInt32("2", 16)))];
		int num4 = ~((Convert.ToInt32(char.ToString('f') + char.ToString('f') + "feac79", 16) != -814487 - Convert.ToInt32("37775177754", 8)) ? (-1) : (-318399));
		int num5;
		if ((((Action__15 | -1381835722) / 1 > array2[8] / 1 - -619938) ? 1 : 0) == ((4163 <= Convert.ToInt32("37" + "77" + "6172624", 8)) ? (-68668) : 0))
		{
			num5 = ~checked(Convert.ToInt32("fff5a693", 16) + 678126);
		}
		else
		{
			int num6 = ((57352 != Marshal.SizeOf(typeof(ZipLow)) - Marshal.SizeOf(typeof(DefaultDependencyAttribute))) ? 235298 : _003CModule_003E.KeyValuePair__2[71]);
			num5 = num6;
		}
		array10[num4] = num5;
		string string_5 = string.Concat(char.ToString('圑') + char.ToString('圑') + "圑圐圑圑圐圑", char.ToString('圑') + "圐圑圐圑" + "圐圑圐圑圑圑圑圐圐圑圑圑圑圐圑圑圐圑");
		object[] array11 = new object[_003CModule_003E.KeyValuePair__2[246] + -208090];
		array11[array2[9] ^ 0x917D2] = 'ࢮ';
		array11[1350183759 >> Convert.ToInt32("11110", 2)] = 'Ӄ';
		array11[array2[Convert.ToInt32("0", 8)]] = 18863;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_5, array11);
		int num8 = default(int);
		checked
		{
			array10[unchecked(Convert.ToInt32(string_5, array2[0]) / ((822650070 << _003CModule_003E.ActivityOptions[2]) | (0x40441040 | Marshal.SizeOf(typeof(IsolatedComponentLoadContext)))))] = unchecked(checked(270493 - array2[10]) + Convert.ToInt32("1111111111" + "1111011110100101011000", array2[0])) * -1;
			switch (array2[1] * -513778)
			{
			default:
			{
				int num7 = default(int);
				switch (unchecked(num7 * -1))
				{
				case 0:
					num8 = -1017877 + Convert.ToInt32("101000001111001011", 2);
					goto end_IL_05ab;
				case 1:
					num8 = 816863 + array2[11];
					goto end_IL_05ab;
				case 2:
					break;
				default:
					goto end_IL_05ab;
				}
				goto IL_05f3;
			}
			case 0:
				{
					int num7 = -2;
					goto IL_05f3;
				}
				IL_05f3:
				num8 = 40198;
				break;
				end_IL_05ab:
				break;
			}
		}
		int num11;
		if (num8 < WriteEventErrorCode)
		{
			int num9 = array2[Convert.ToInt32("2", 16)];
			int num10 = ((1 != array2[1]) ? (-753732) : Start);
			num11 = num9 & num10;
		}
		else
		{
			string string_6 = "⼲⼳";
			object[] array12 = new object[Marshal.SizeOf(typeof(ENODATA)) << 1];
			array12[0] = (char)Convert.ToInt32(char.ToString('1') + char.ToString('6') + "2f", array2[5]);
			array12[(nint)((Array)(object)"\u0340").LongLength] = string.Concat(char.ToString('\u0cd1'), char.ToString('ʎ'), char.ToString('u') + "\\\n!\u0006");
			int num12 = default(int);
			switch (Convert.ToInt32("2651166300", 8) / 189953632)
			{
			case 0:
				num12 = _003CModule_003E.KeyValuePair__2[247];
				break;
			case 1:
				num12 = 631951;
				break;
			case 2:
				num12 = 2;
				break;
			}
			array12[num12] = (char)Clamp;
			array12[3] = 1059;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_6, array12);
			num11 = Convert.ToInt32(string_6, Convert.ToInt32("3", 8) & array2[0]);
		}
		int num13 = num11;
		int num14 = ((Prefix3 != Marshal.SizeOf(typeof(FileNotFoundException))) ? (-17308) : array2[3]);
		array10[num13] = (char)(num14 >> (int)array4[1]);
		array10[3] = '\u0a50';
		_003CModule_003E.GetMaxByteCount(ref string_3, array10);
		if (requires != string_3)
		{
			string text3 = char.ToString((char)((Convert.ToInt32("21076724", 8) >> 6) % 28054));
			string text4 = char.ToString((char)_003CModule_003E.Dequeue[Convert.ToInt32("151", 8) % 42]);
			string text5 = char.ToString('㛎');
			string string_7 = string.Concat(char.ToString('킭'), char.ToString('킪') + "킭키");
			object[] array13 = new object[5];
			array13[0] = string.Concat(char.ToString('\u0015'), char.ToString('à'), char.ToString('?') + char.ToString('Ĕ') + "Q@");
			array13[Convert.ToInt32("fffc323a", 16) - -249287] = 1569;
			array13[0 | Marshal.SizeOf(typeof(ENODATA))] = Convert.ToInt32(char.ToString('1') + char.ToString('2') + "1412", 8);
			array13[3 & _003CModule_003E.KeyValuePair__2[0]] = ((RecursiveWriteCount > 831751) ? Convert.ToInt32("37775424673", 8) : 14971);
			array13[4] = (byte)Convert.ToInt32("0", get_CanSeek) != 0;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_7, array13);
			string string_8 = string.Concat(text3, text4, text5 + string_7);
			string string_9 = "\uea4f";
			object[] array14 = new object[(uint)array[2]];
			checked
			{
				array14[0] = Func__8 * 1;
				array14[1 * Convert.ToInt32("1", 16)] = '㌘';
				array14[2] = 0xF9FD & Convert.ToInt32("105776", 8);
			}
			array14[3] = (byte)array[0] != 0;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_9, array14);
			int num15 = Convert.ToInt32(string_9, 2 << CancellationPending);
			int num16 = Marshal.SizeOf(typeof(OpenExisting)) % 10;
			object[] array15 = new object[num15 | num16];
			int num17 = 952231824 / Marshal.SizeOf(typeof(ConvertToUtf32));
			int num18 = ((-61981 >= Convert.ToInt32("37" + "777403752", 8)) ? (2712561 >> Convert.ToInt32("10101", 2)) : array2[sizeof(int)]);
			int num19 = default(int);
			switch (checked(num17 * num18))
			{
			case 0:
				num19 = 188492 << (int)array[1];
				break;
			case 1:
				num19 = 0;
				break;
			case 2:
				num19 = 87049;
				break;
			}
			int num20 = num19;
			string text6 = char.ToString((char)(array2[6] * Convert.ToInt32("fffffffb", 16)));
			string string_10 = char.ToString((char)array2[12]) + "븕븛";
			object[] array16 = new object[4];
			array16[Convert.ToInt32("0", 8)] = char.ToString('兗') + "һ\u02c5";
			array16[1] = (byte)Convert.ToInt32("0", 8) != 0;
			array16[2] = string.Concat(char.ToString('䲩'), char.ToString('շ'), char.ToString('\u001d') + "#F");
			array16[245638 - LoaderAllocator] = 'ኰ';
			_003CModule_003E.TAIWANLUNISOLAR(ref string_10, array16);
			array15[num20] = (char)Convert.ToInt32(text6 + string_10, array6[Convert.ToInt32("0", 8)]);
			int[] dequeue = _003CModule_003E.Dequeue;
			int item = Item5;
			int num21 = dequeue[item * -949528];
			string string_11 = "䧘";
			object[] array17 = new object[4];
			array17[0] = string.Concat("\u001fz", char.ToString(' ') + "ū\u0013A\n");
			array17[1] = (char)checked(Convert.ToInt32("37774363614", 8) + 928525);
			array17[Convert.ToInt32("2", 8)] = '౿';
			array17[3] = 10318;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_11, array17);
			array15[num21] = (int)array4[Convert.ToInt32(string_11, 0xCDED0 ^ _003CModule_003E.ActivityOptions[213])];
			string string_12 = "뚢";
			object[] array18 = new object[checked(597102 + array2[13])];
			array18[0] = (char)(_003CModule_003E.get_PositiveSign[227] & 'ኮ');
			array18[1] = 26506;
			array18[2] = 3271;
			int num22 = ((-60341 != _003CModule_003E.ActivityOptions[214]) ? 3 : (-98393));
			array18[num22] = (char)Convert.ToInt32(char.ToString('d') + "94", 16);
			array18[4] = (byte)(Convert.ToInt32("0", 16) * -536460) != 0;
			array18[5] = char.ToString(array[3]) + "Ђ\u0dfb";
			_003CModule_003E.TAIWANLUNISOLAR(ref string_12, array18);
			array15[Convert.ToInt32(string_12, sizeof(long)) | (sizeof(byte) << (int)array[Marshal.SizeOf(typeof(UseHebrewParsing))])] = (char)Marshal.SizeOf(typeof(EventResetMode));
			array15[_003CModule_003E.LoadVector128[1]] = (char)Marshal.SizeOf(typeof(get_Constructor));
			string string_13 = "鱨";
			object[] array19 = new object[Marshal.SizeOf(typeof(CharSetMask))];
			char c = (char)((Array)(object)string.Empty).Length;
			array19[(int)c] = Marshal.SizeOf(typeof(LazyCancellation));
			array19[82448777 >> Convert.ToInt32("11010", 2)] = checked(-905873 + Convert.ToInt32("e3033", 16));
			int num23 = set_Exclude;
			int num24 = array2[14];
			array19[num23] = num24;
			_003CModule_003E.TAIWANLUNISOLAR(ref string_13, array19);
			int num25 = Convert.ToInt32(string_13, (int)(0xE & (nint)((Array)(object)("\u032d\u0321\u0325" + "\u035a.\u033e\u0328\u031d")).LongLength));
			int num26 = default(int);
			switch (0 % array6[Convert.ToInt32("1", 8)])
			{
			case 0:
				num26 = 737;
				break;
			}
			array15[num25] = num26;
			_003CModule_003E.GetMaxByteCount(ref string_8, array15);
			get_Week(string_8, string_0);
		}
	}

	public unsafe void GetImplTypeFlags(string string_0)
	{
		char[] array = new char[1] { '\0' };
		int[] array2 = new int[2] { 1, 6464 };
		char[] array3 = new char[checked(array2[0] * 1)];
		array3[0] = 'ӓ';
		char[] array4 = array3;
		int[] array5 = new int[sizeof(sbyte)];
		array5[Convert.ToInt32("0", Convert.ToInt32("10", 16))] = 2;
		int[] array6 = array5;
		string text = char.ToString(array4[Convert.ToInt32("0", Convert.ToInt32("10", 8))]);
		string text2 = char.ToString('ӄ');
		string text3 = char.ToString((char)('\u05ee' & Marshal.SizeOf(typeof(Iso4217MonetarySymbol))));
		string string_ = "ԽԠ";
		object[] array7 = new object[2];
		array7[(uint)array[Item5]] = 133;
		array7[(nint)((Array)(object)"\u0323").LongLength] = 'ş';
		_003CModule_003E.TAIWANLUNISOLAR(ref string_, array7);
		string string_2 = string.Concat(text, text2 + text3 + string_);
		object[] array8 = new object[array6[0] * (703711 - IsWaitNotificationRequired)];
		int num = _003CModule_003E.LoadVector128[checked(-510184 + PropertyValue)];
		string string_3 = string.Concat("愌愈", char.ToString('愈'), "愈愊" + "愎愈意愌愊愎");
		object[] array9 = new object[5];
		array9[Item5] = (char)(array2[1] | '\u1926');
		array9[Marshal.SizeOf(typeof(UseHebrewParsing))] = string.Concat(char.ToString('ত'), char.ToString('ݪ') + "\u0339ٸ\u030c");
		array9[2] = 635;
		array9[(nint)((Array)(object)(char.ToString('\u034b') + "\u030a\u0306")).LongLength] = 7787;
		int dateTimeToken = DateTimeToken;
		int num2 = default(int);
		switch (checked(252464 + Convert.ToInt32("11111111111111000010010111010000", 2)))
		{
		case 0:
			num2 = 2344;
			break;
		}
		array9[dateTimeToken] = num2;
		_003CModule_003E.TAIWANLUNISOLAR(ref string_3, array9);
		array8[num % Convert.ToInt32(string_3, 8)] = ThreadPoolBoundHandleOverlapped;
		int num3 = 0 | ((Convert.ToInt32(char.ToString('5') + "467", 16) <= Convert.ToInt32("11111111111111000111110000110101", 2) + -503196) ? (-875070) : (_003CModule_003E.get_PositiveSign[2] % 2));
		string string_4 = "㠯㢪";
		object[] array10 = new object[4];
		array10[Convert.ToInt32("0", 16)] = 9534;
		array10[array2[0]] = 209;
		array10[2] = char.ToString('\u0c44') + char.ToString('غ') + "\0\u0006";
		array10[_003CModule_003E.KeyValuePair__2[0]] = string.Concat(char.ToString('\r'), char.ToString('\n') + "\u0001\0\u0002");
		_003CModule_003E.TAIWANLUNISOLAR(ref string_4, array10);
		array8[num3] = string_4;
		_003CModule_003E.GetMaxByteCount(ref string_2, array8);
		get_Week(string_2, string_0);
	}
}
