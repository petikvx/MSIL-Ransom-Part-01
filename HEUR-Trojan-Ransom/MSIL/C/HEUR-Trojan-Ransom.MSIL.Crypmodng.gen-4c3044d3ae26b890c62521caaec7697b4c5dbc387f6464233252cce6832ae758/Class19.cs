using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

[StandardModule]
internal sealed class Class19
{
	private static string string_0;

	private static string string_1;

	private static string string_2;

	private static string string_3;

	public static string string_4;

	public static string string_5;

	public static string string_6;

	private static string string_7;

	private static string string_8;

	private static string string_9;

	public static string string_10;

	public static string string_11;

	public static void smethod_0()
	{
		do
		{
			/*Error: starg 0 (out-of-bounds)*/;
		}
		while (((ushort[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] == 0 || /*Error near IL_000d: Stack underflow*/<= /*Error near IL_000d: Stack underflow*/);
		/*Error: Unexpected end of block*/;
	}

	public static extern void smethod_1();

	public static object smethod_2(string string_12)
	{
		//Discarded unreachable code: IL_0008, IL_000f, IL_0013, IL_0018
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I8
		//IL_0012: Expected O, but got I4
		//IL_0020: Incompatible stack heights: 0 vs 1
		nuint num = checked((nuint)/*Error near IL_0001: Stack underflow*/);
		uint num2 = ((uint[])/*Error near IL_0002: Stack underflow*/)[num];
		_ = /*Error near IL_0003: Stack underflow*// num2;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	public static void smethod_3(string string_12, string string_13)
	{
		//Discarded unreachable code: IL_0006, IL_0012, IL_0018, IL_001f, IL_0029, IL_002f, IL_0034
		//IL_000d: Invalid comparison between Unknown and F4
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected F8, but got I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected I4, but got I8
		while (true)
		{
		}
	}

	public static extern void smethod_4(string string_12, string string_13);

	public unsafe static string smethod_5(int int_0)
	{
		//Discarded unreachable code: IL_0007, IL_000c, IL_0012, IL_0019, IL_001e, IL_0023
		//IL_0002: Expected I4, but got F8
		double num = (double)/*Error near IL_0001: Stack underflow*/;
		*(short*)(nint)/*Error near IL_0002: Stack underflow*/ = (short)(int)num;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	[DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int FindWindow([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_12, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_13);

	[DllImport("User32", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern void SetWindowPos(int int_0, int int_1, int int_2, int int_3, int int_4, int int_5, int int_6);

	public static extern string smethod_6(ref string string_12);

	public static extern void smethod_7(bool bool_0);

	public static byte[] smethod_8(byte[] byte_0, byte[] byte_1)
	{
		//Discarded unreachable code: IL_0005, IL_0017
		//IL_0012: Incompatible stack heights: 0 vs 2
		/*Error: Invalid metadata token*/;
	}

	public static extern string smethod_9(string string_12);

	static string smethod_10()
	{
		return Environment.MachineName;
	}

	static string smethod_11(object object_0)
	{
		return ((string)object_0).ToString();
	}

	static object smethod_12()
	{
		return Class13.Class12_0;
	}

	static object smethod_13(object object_0)
	{
		return ((ServerComputer)object_0).get_Info();
	}

	static string smethod_14(object object_0)
	{
		return ((ComputerInfo)object_0).get_OSFullName();
	}

	static string smethod_15()
	{
		return Environment.UserName;
	}

	static string smethod_16()
	{
		return Class22.smethod_1();
	}

	static double smethod_17(double double_0)
	{
		return Math.Cos(double_0);
	}

	static int smethod_18(double double_0)
	{
		return Convert.ToInt32(double_0);
	}

	static string smethod_19()
	{
		return Class22.smethod_2();
	}

	static string smethod_20()
	{
		return Class22.smethod_3();
	}

	static double smethod_21(double double_0)
	{
		return Math.Log10(double_0);
	}

	static string smethod_22()
	{
		return Class22.smethod_4();
	}

	static double smethod_23(double double_0)
	{
		return Math.Log(double_0);
	}

	static string smethod_24()
	{
		return Class22.smethod_5();
	}

	static double smethod_25(double double_0)
	{
		return Math.Sqrt(double_0);
	}

	static string smethod_26()
	{
		return Class22.smethod_6();
	}

	static double smethod_27(double double_0)
	{
		return Math.Floor(double_0);
	}

	static string smethod_28()
	{
		return Class22.smethod_7();
	}

	static string smethod_29()
	{
		return Class22.smethod_8();
	}

	static string smethod_30()
	{
		return Class22.smethod_9();
	}

	static double smethod_31(double double_0)
	{
		return Math.Round(double_0);
	}

	static string smethod_32()
	{
		return Class22.smethod_10();
	}

	static string smethod_33()
	{
		return Class22.smethod_11();
	}

	static double smethod_34(double double_0)
	{
		return Math.Ceiling(double_0);
	}

	static string smethod_35()
	{
		return Class22.smethod_12();
	}

	static string smethod_36()
	{
		return Class22.smethod_13();
	}

	static double smethod_37(double double_0)
	{
		return Math.Truncate(double_0);
	}

	static string smethod_38()
	{
		return Class22.smethod_14();
	}

	static string smethod_39()
	{
		return Class22.smethod_15();
	}

	static string smethod_40()
	{
		return Class22.smethod_16();
	}

	static string smethod_41()
	{
		return Class22.smethod_17();
	}

	static string smethod_42()
	{
		return Class22.smethod_18();
	}

	static string smethod_43()
	{
		return Class22.smethod_19();
	}

	static string smethod_44()
	{
		return Class22.smethod_20();
	}

	static double smethod_45(double double_0)
	{
		return Math.Abs(double_0);
	}

	static string smethod_46()
	{
		return Class22.smethod_21();
	}

	static string smethod_47()
	{
		return Class22.smethod_22();
	}

	static string smethod_48()
	{
		return Class22.smethod_23();
	}

	static string smethod_49()
	{
		return Class22.smethod_24();
	}

	static string smethod_50()
	{
		return Class22.smethod_25();
	}

	static string smethod_51()
	{
		return Class22.smethod_26();
	}

	static string smethod_52()
	{
		return Class22.smethod_27();
	}

	static double smethod_53(double double_0)
	{
		return Math.Sin(double_0);
	}

	static string smethod_54()
	{
		return Class22.smethod_28();
	}

	static double smethod_55(double double_0)
	{
		return Math.Tanh(double_0);
	}

	static string smethod_56()
	{
		return Class22.smethod_29();
	}

	static double smethod_57(double double_0)
	{
		return Math.Tan(double_0);
	}

	static string smethod_58()
	{
		return Class22.smethod_30();
	}

	static string smethod_59()
	{
		return Class22.smethod_31();
	}

	static string smethod_60()
	{
		return Class22.smethod_32();
	}

	static string smethod_61()
	{
		return Class22.smethod_33();
	}

	static string smethod_62()
	{
		return Class22.smethod_34();
	}

	static string smethod_63()
	{
		return Class22.smethod_35();
	}

	static string smethod_64()
	{
		return Class22.smethod_36();
	}

	static string smethod_65()
	{
		return Class22.smethod_37();
	}

	static string smethod_66()
	{
		return Class22.smethod_38();
	}

	static string smethod_67()
	{
		return Class22.smethod_39();
	}

	static string smethod_68()
	{
		return Class22.smethod_40();
	}

	static string smethod_69()
	{
		return Class22.smethod_41();
	}

	static string smethod_70()
	{
		return Class22.smethod_42();
	}

	static string smethod_71()
	{
		return Class22.smethod_43();
	}

	static string smethod_72()
	{
		return Class22.smethod_44();
	}

	static string smethod_73()
	{
		return Class22.smethod_45();
	}

	static string smethod_74()
	{
		return Class22.smethod_46();
	}

	static string smethod_75()
	{
		return Class22.smethod_47();
	}

	static string smethod_76()
	{
		return Class22.smethod_48();
	}

	static string smethod_77()
	{
		return Class22.smethod_49();
	}

	static string smethod_78()
	{
		return Class22.smethod_50();
	}

	static string smethod_79()
	{
		return Class22.smethod_51();
	}

	static string smethod_80()
	{
		return Class22.smethod_52();
	}

	static string smethod_81()
	{
		return Class22.smethod_53();
	}

	static string smethod_82()
	{
		return Class22.smethod_54();
	}

	static string smethod_83()
	{
		return Class22.smethod_55();
	}

	static string smethod_84()
	{
		return Class22.smethod_56();
	}

	static string smethod_85()
	{
		return Class22.smethod_57();
	}

	static string smethod_86()
	{
		return Class22.smethod_58();
	}

	static string smethod_87()
	{
		return Class22.smethod_59();
	}

	static string smethod_88()
	{
		return Class22.smethod_60();
	}

	static string smethod_89()
	{
		return Class22.smethod_61();
	}

	static string smethod_90()
	{
		return Class22.smethod_62();
	}

	static string smethod_91()
	{
		return Class22.smethod_63();
	}

	static string smethod_92()
	{
		return Class22.smethod_64();
	}

	static string smethod_93()
	{
		return Class22.smethod_65();
	}

	static string smethod_94()
	{
		return Class22.smethod_66();
	}

	static string smethod_95()
	{
		return Class22.smethod_67();
	}

	static string smethod_96()
	{
		return Class22.smethod_68();
	}

	static string smethod_97()
	{
		return Class22.smethod_69();
	}

	static string smethod_98()
	{
		return Class22.smethod_70();
	}

	static string smethod_99()
	{
		return Class22.smethod_71();
	}

	static string smethod_100()
	{
		return Class22.smethod_72();
	}

	static string smethod_101()
	{
		return Class22.smethod_73();
	}

	static string smethod_102()
	{
		return Class22.smethod_74();
	}

	static string smethod_103()
	{
		return Class22.smethod_75();
	}

	static string smethod_104()
	{
		return Class22.smethod_76();
	}

	static string smethod_105()
	{
		return Class22.smethod_77();
	}

	static string smethod_106()
	{
		return Class22.smethod_78();
	}

	static string smethod_107()
	{
		return Class22.smethod_79();
	}

	static string smethod_108()
	{
		return Class22.smethod_80();
	}

	static string smethod_109()
	{
		return Class22.smethod_81();
	}

	static string smethod_110()
	{
		return Class22.smethod_82();
	}

	static string smethod_111()
	{
		return Class22.smethod_83();
	}

	static string smethod_112()
	{
		return Class22.smethod_84();
	}

	static string smethod_113()
	{
		return Class22.smethod_85();
	}

	static string smethod_114()
	{
		return Class22.smethod_86();
	}

	static string smethod_115()
	{
		return Class22.smethod_87();
	}

	static string smethod_116()
	{
		return Class22.smethod_88();
	}

	static string smethod_117()
	{
		return Class22.smethod_89();
	}

	static string smethod_118()
	{
		return Class22.smethod_90();
	}

	static string smethod_119()
	{
		return Class22.smethod_91();
	}

	static string smethod_120()
	{
		return Class22.smethod_92();
	}

	static string smethod_121()
	{
		return Class22.smethod_93();
	}

	static string smethod_122()
	{
		return Class22.smethod_94();
	}

	static string smethod_123()
	{
		return Class22.smethod_95();
	}

	static string smethod_124()
	{
		return Class22.smethod_96();
	}

	static string smethod_125()
	{
		return Class22.smethod_97();
	}

	static string smethod_126()
	{
		return Class22.smethod_98();
	}

	static string smethod_127()
	{
		return Class22.smethod_99();
	}

	static string smethod_128()
	{
		return Class22.smethod_100();
	}

	static string smethod_129()
	{
		return Class22.smethod_101();
	}

	static string smethod_130()
	{
		return Class22.smethod_102();
	}

	static string smethod_131()
	{
		return Class22.smethod_103();
	}

	static string smethod_132()
	{
		return Class22.smethod_104();
	}

	static string smethod_133()
	{
		return Class22.smethod_105();
	}

	static string smethod_134()
	{
		return Class22.smethod_106();
	}

	static string smethod_135()
	{
		return Class22.smethod_107();
	}

	static string smethod_136()
	{
		return Class22.smethod_108();
	}

	static string smethod_137()
	{
		return Class22.smethod_109();
	}

	static string smethod_138()
	{
		return Class22.smethod_110();
	}

	static string smethod_139()
	{
		return Class22.smethod_111();
	}

	static string smethod_140()
	{
		return Class22.smethod_112();
	}

	static string smethod_141()
	{
		return Class22.smethod_113();
	}

	static string smethod_142()
	{
		return Class22.smethod_114();
	}

	static string smethod_143()
	{
		return Class22.smethod_115();
	}

	static string smethod_144()
	{
		return Class22.smethod_116();
	}

	static string smethod_145()
	{
		return Class22.smethod_117();
	}

	static string smethod_146()
	{
		return Class22.smethod_118();
	}

	static string smethod_147()
	{
		return Class22.smethod_119();
	}

	static string smethod_148()
	{
		return Class22.smethod_120();
	}

	static string smethod_149()
	{
		return Class22.smethod_121();
	}

	static string smethod_150()
	{
		return Class22.smethod_122();
	}

	static string smethod_151()
	{
		return Class22.smethod_123();
	}

	static string smethod_152()
	{
		return Class22.smethod_124();
	}

	static string smethod_153()
	{
		return Class22.smethod_125();
	}

	static string smethod_154()
	{
		return Class22.smethod_126();
	}

	static string smethod_155()
	{
		return Class22.smethod_127();
	}

	static string smethod_156()
	{
		return Class22.smethod_128();
	}

	static string smethod_157()
	{
		return Class22.smethod_129();
	}

	static string smethod_158()
	{
		return Class22.smethod_130();
	}

	static string smethod_159()
	{
		return Class22.smethod_131();
	}

	static string smethod_160()
	{
		return Class22.smethod_132();
	}

	static string smethod_161()
	{
		return Class22.smethod_133();
	}

	static string smethod_162()
	{
		return Class22.smethod_134();
	}

	static string smethod_163()
	{
		return Class22.smethod_135();
	}

	static string smethod_164()
	{
		return Class22.smethod_136();
	}

	static string smethod_165()
	{
		return Class22.smethod_137();
	}

	static string smethod_166()
	{
		return Class22.smethod_138();
	}

	static string smethod_167()
	{
		return Class22.smethod_139();
	}

	static string smethod_168()
	{
		return Class22.smethod_140();
	}

	static string smethod_169()
	{
		return Class22.smethod_141();
	}

	static string smethod_170()
	{
		return Class22.smethod_142();
	}

	static string smethod_171()
	{
		return Class22.smethod_143();
	}

	static string smethod_172()
	{
		return Class22.smethod_144();
	}

	static string smethod_173()
	{
		return Class22.smethod_145();
	}

	static string smethod_174()
	{
		return Class22.smethod_146();
	}

	static string smethod_175()
	{
		return Class22.smethod_147();
	}

	static string smethod_176()
	{
		return Class22.smethod_148();
	}

	static string smethod_177()
	{
		return Class22.smethod_149();
	}

	static string smethod_178()
	{
		return Class22.smethod_150();
	}

	static string smethod_179()
	{
		return Class22.smethod_151();
	}

	static string smethod_180()
	{
		return Class22.smethod_152();
	}

	static string smethod_181()
	{
		return Class22.smethod_153();
	}

	static string smethod_182()
	{
		return Class22.smethod_154();
	}

	static string smethod_183()
	{
		return Class22.smethod_155();
	}

	static string smethod_184()
	{
		return Class22.smethod_156();
	}

	static string smethod_185()
	{
		return Class22.smethod_157();
	}

	static string smethod_186()
	{
		return Class22.smethod_158();
	}

	static string smethod_187()
	{
		return Class22.smethod_159();
	}

	static string smethod_188()
	{
		return Class22.smethod_160();
	}

	static string smethod_189()
	{
		return Class22.smethod_161();
	}

	static string smethod_190()
	{
		return Class22.smethod_162();
	}

	static string smethod_191()
	{
		return Class22.smethod_163();
	}

	static string smethod_192()
	{
		return Class22.smethod_164();
	}

	static string smethod_193()
	{
		return Class22.smethod_165();
	}

	static string smethod_194()
	{
		return Class22.smethod_166();
	}

	static string smethod_195()
	{
		return Class22.smethod_167();
	}

	static string smethod_196()
	{
		return Class22.smethod_168();
	}

	static string smethod_197()
	{
		return Class22.smethod_169();
	}

	static string smethod_198()
	{
		return Class22.smethod_170();
	}

	static string smethod_199()
	{
		return Class22.smethod_171();
	}

	static string smethod_200()
	{
		return Class22.smethod_172();
	}

	static string smethod_201()
	{
		return Class22.smethod_173();
	}

	static string smethod_202()
	{
		return Class22.smethod_174();
	}

	static string smethod_203()
	{
		return Class22.smethod_175();
	}

	static string smethod_204()
	{
		return Class22.smethod_176();
	}

	static string smethod_205()
	{
		return Class22.smethod_177();
	}

	static string smethod_206()
	{
		return Class22.smethod_178();
	}

	static string smethod_207()
	{
		return Class22.smethod_179();
	}

	static string smethod_208()
	{
		return Class22.smethod_180();
	}

	static string smethod_209()
	{
		return Class22.smethod_181();
	}

	static string smethod_210()
	{
		return Class22.smethod_182();
	}

	static string smethod_211()
	{
		return Class22.smethod_183();
	}

	static string smethod_212()
	{
		return Class22.smethod_184();
	}

	static string smethod_213()
	{
		return Class22.smethod_185();
	}

	static string smethod_214()
	{
		return Class22.smethod_186();
	}

	static string smethod_215()
	{
		return Class22.smethod_187();
	}

	static string smethod_216()
	{
		return Class22.smethod_188();
	}

	static string smethod_217()
	{
		return Class22.smethod_189();
	}

	static string smethod_218()
	{
		return Class22.smethod_190();
	}

	static string smethod_219()
	{
		return Class22.smethod_191();
	}

	static string smethod_220()
	{
		return Class22.smethod_192();
	}

	static string smethod_221()
	{
		return Class22.smethod_193();
	}

	static string smethod_222()
	{
		return Class22.smethod_194();
	}

	static string smethod_223()
	{
		return Class22.smethod_195();
	}

	static string smethod_224()
	{
		return Class22.smethod_196();
	}

	static string smethod_225()
	{
		return Class22.smethod_197();
	}

	static string smethod_226()
	{
		return Class22.smethod_198();
	}

	static string smethod_227()
	{
		return Class22.smethod_199();
	}

	static string smethod_228()
	{
		return Class22.smethod_200();
	}

	static string smethod_229()
	{
		return Class22.smethod_201();
	}

	static string smethod_230()
	{
		return Class22.smethod_202();
	}

	static string smethod_231()
	{
		return Class22.smethod_203();
	}

	static string smethod_232()
	{
		return Class22.smethod_204();
	}

	static string smethod_233()
	{
		return Class22.smethod_205();
	}

	static string smethod_234()
	{
		return Class22.smethod_206();
	}

	static string smethod_235()
	{
		return Class22.smethod_207();
	}

	static string smethod_236()
	{
		return Class22.smethod_208();
	}

	static string smethod_237()
	{
		return Class22.smethod_209();
	}

	static string smethod_238()
	{
		return Class22.smethod_210();
	}

	static string smethod_239()
	{
		return Class22.smethod_211();
	}

	static string smethod_240()
	{
		return Class22.smethod_212();
	}

	static string smethod_241()
	{
		return Class22.smethod_213();
	}

	static string smethod_242(string[] string_12)
	{
		return string.Concat(string_12);
	}

	static string smethod_243()
	{
		return Class22.smethod_214();
	}

	static string smethod_244()
	{
		return Class22.smethod_215();
	}

	static string smethod_245()
	{
		return Class22.smethod_216();
	}

	static string smethod_246()
	{
		return Class22.smethod_217();
	}

	static string smethod_247(int int_0)
	{
		return smethod_5(int_0);
	}

	static string smethod_248()
	{
		return Class22.smethod_218();
	}

	static string smethod_249(string string_12, string string_13, string string_14)
	{
		return string_12 + string_13 + string_14;
	}

	static string smethod_250()
	{
		return Class22.smethod_219();
	}

	static string smethod_251()
	{
		return Environment.NewLine;
	}

	static string smethod_252()
	{
		return Class22.smethod_220();
	}

	static string smethod_253()
	{
		return Class22.smethod_231();
	}

	static string smethod_254(string string_12, string string_13)
	{
		return string_12 + string_13;
	}

	static string smethod_255()
	{
		return Class22.smethod_232();
	}

	static string smethod_256(string string_12)
	{
		return smethod_9(string_12);
	}

	static void smethod_257(string string_12, string string_13)
	{
		File.WriteAllText(string_12, string_13);
	}

	static void smethod_258()
	{
		ProjectData.ClearProjectError();
	}

	static string smethod_259()
	{
		return Class22.smethod_233();
	}

	static object smethod_260(string string_12)
	{
		return smethod_2(string_12);
	}

	static void smethod_261(string string_12, string string_13)
	{
		smethod_4(string_12, string_13);
	}

	static object smethod_262(string string_12)
	{
		return Process.Start(string_12);
	}

	static void smethod_263()
	{
		smethod_1();
	}

	static void smethod_264(Exception exception_0)
	{
		ProjectData.SetProjectError(exception_0);
	}

	static object smethod_265(int int_0)
	{
		return ProjectData.CreateProjectError(int_0);
	}

	static string smethod_266()
	{
		return Class22.smethod_234();
	}

	static string smethod_267()
	{
		return Class22.smethod_235();
	}

	static string smethod_268(string string_12, string string_13, string string_14, string string_15)
	{
		return string_12 + string_13 + string_14 + string_15;
	}

	static string smethod_269()
	{
		return Class22.smethod_236();
	}

	static string smethod_270()
	{
		return Class22.smethod_237();
	}

	static string smethod_271()
	{
		return Class22.smethod_238();
	}

	static string smethod_272()
	{
		return Class22.smethod_239();
	}

	static string smethod_273()
	{
		return Class22.smethod_240();
	}

	static string smethod_274()
	{
		return Class22.smethod_241();
	}

	static string smethod_275()
	{
		return Class22.smethod_242();
	}

	static string smethod_276()
	{
		return Class22.smethod_243();
	}

	static string smethod_277()
	{
		return Class22.smethod_244();
	}

	static string smethod_278()
	{
		return Class22.smethod_245();
	}

	static string smethod_279()
	{
		return Class22.smethod_246();
	}

	static string smethod_280()
	{
		return Class22.smethod_247();
	}

	static string smethod_281()
	{
		return Class22.smethod_248();
	}

	static string smethod_282()
	{
		return Class22.smethod_249();
	}

	static string smethod_283()
	{
		return Class22.smethod_250();
	}

	static string smethod_284()
	{
		return Class22.smethod_251();
	}

	static void smethod_285(string string_12, string[] string_13)
	{
		File.WriteAllLines(string_12, string_13);
	}

	static byte[] smethod_286(string string_12)
	{
		return File.ReadAllBytes(string_12);
	}

	static object smethod_287()
	{
		return Encoding.UTF8;
	}

	static byte[] smethod_288(object object_0, string string_12)
	{
		return ((Encoding)object_0).GetBytes(string_12);
	}

	static object smethod_289()
	{
		return SHA256.Create();
	}

	static byte[] smethod_290(object object_0, byte[] byte_0)
	{
		return ((HashAlgorithm)object_0).ComputeHash(byte_0);
	}

	static byte[] smethod_291(byte[] byte_0, byte[] byte_1)
	{
		return smethod_8(byte_0, byte_1);
	}

	static void smethod_292(string string_12, byte[] byte_0)
	{
		File.WriteAllBytes(string_12, byte_0);
	}

	static void smethod_293(string string_12, string string_13)
	{
		File.Move(string_12, string_13);
	}

	static string[] smethod_294(string string_12)
	{
		return Directory.GetFiles(string_12);
	}

	static string[] smethod_295(string string_12)
	{
		return Directory.GetDirectories(string_12);
	}

	static string smethod_296(string string_12)
	{
		return Path.GetExtension(string_12);
	}

	static bool smethod_297(object object_0, string string_12)
	{
		return ((string)object_0).Contains(string_12);
	}

	static void smethod_298(string string_12, string string_13)
	{
		smethod_3(string_12, string_13);
	}

	static object smethod_299()
	{
		return new StringBuilder();
	}

	static object smethod_300()
	{
		return new Random();
	}

	static int smethod_301(object object_0)
	{
		return ((string)object_0).Length;
	}

	static int smethod_302(object object_0, int int_0)
	{
		return ((Random)object_0).Next(int_0);
	}

	static char smethod_303(object object_0, int int_0)
	{
		return ((string)object_0)[int_0];
	}

	static object smethod_304(object object_0, char char_0)
	{
		return ((StringBuilder)object_0).Append(char_0);
	}

	static int smethod_305(ref int int_0)
	{
		return Interlocked.Decrement(ref int_0);
	}

	static int smethod_306(int int_0, int int_1)
	{
		return Math.Max(int_0, int_1);
	}

	static string smethod_307(object object_0)
	{
		return ((StringBuilder)object_0).ToString();
	}

	static string smethod_308(byte[] byte_0)
	{
		return Convert.ToBase64String(byte_0);
	}

	static string smethod_309()
	{
		return Class22.smethod_252();
	}

	static object smethod_310()
	{
		return new MemoryStream();
	}

	static object smethod_311()
	{
		return new RijndaelManaged();
	}

	static void smethod_312(object object_0, int int_0)
	{
		((SymmetricAlgorithm)object_0).KeySize = int_0;
	}

	static void smethod_313(object object_0, int int_0)
	{
		((SymmetricAlgorithm)object_0).BlockSize = int_0;
	}

	static object smethod_314(byte[] byte_0, byte[] byte_1, int int_0)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, int_0);
	}

	static int smethod_315(object object_0)
	{
		return ((SymmetricAlgorithm)object_0).KeySize;
	}

	static byte[] smethod_316(object object_0, int int_0)
	{
		return ((Rfc2898DeriveBytes)object_0).GetBytes(int_0);
	}

	static void smethod_317(object object_0, byte[] byte_0)
	{
		((SymmetricAlgorithm)object_0).Key = byte_0;
	}

	static int smethod_318(object object_0)
	{
		return ((SymmetricAlgorithm)object_0).BlockSize;
	}

	static void smethod_319(object object_0, byte[] byte_0)
	{
		((SymmetricAlgorithm)object_0).IV = byte_0;
	}

	static void smethod_320(object object_0, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_0).Mode = cipherMode_0;
	}

	static object smethod_321(object object_0)
	{
		return ((SymmetricAlgorithm)object_0).CreateEncryptor();
	}

	static object smethod_322(object object_0, object object_1, CryptoStreamMode cryptoStreamMode_0)
	{
		return new CryptoStream((Stream)object_0, (ICryptoTransform)object_1, cryptoStreamMode_0);
	}

	static void smethod_323(object object_0, byte[] byte_0, int int_0, int int_1)
	{
		((CryptoStream)object_0).Write(byte_0, int_0, int_1);
	}

	static void smethod_324(object object_0)
	{
		((Stream)object_0).Close();
	}

	static void smethod_325(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}

	static byte[] smethod_326(object object_0)
	{
		return ((MemoryStream)object_0).ToArray();
	}

	static string smethod_327(char char_0)
	{
		return Conversions.ToString(char_0);
	}

	static int smethod_328(string string_12)
	{
		return Strings.Asc(string_12);
	}

	static string smethod_329(int int_0)
	{
		return Conversion.Hex(int_0);
	}

	static string smethod_330()
	{
		return Class22.smethod_253();
	}

	static object smethod_331(object object_0, string string_12)
	{
		return ((StringBuilder)object_0).Append(string_12);
	}

	static int smethod_332(object object_0)
	{
		return ((StringBuilder)object_0).Length;
	}

	static string smethod_333(object object_0, int int_0, int int_1)
	{
		return ((string)object_0).Substring(int_0, int_1);
	}
}
