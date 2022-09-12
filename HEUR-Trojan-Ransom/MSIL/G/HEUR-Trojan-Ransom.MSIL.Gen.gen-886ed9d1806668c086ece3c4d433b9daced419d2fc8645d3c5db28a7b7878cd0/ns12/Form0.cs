using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using GameOverlay.Drawing;
using VisualPlus.Events;
using VisualPlus.Structure;
using VisualPlus.Toolkit.Controls.Interactivity;
using VisualPlus.Toolkit.Controls.Layout;
using VisualPlus.Toolkit.VisualBase;
using ns10;
using ns49;
using ns5;

namespace ns12;

internal class Form0 : Form
{
	private struct Struct7
	{
		public uint uint_0;

		public int int_0;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	private struct Struct8
	{
		public Struct7 struct7_0;

		public uint uint_0;
	}

	private struct Struct9
	{
		public int int_0;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
		public Struct8[] struct8_0;
	}

	internal struct Struct10
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public IntPtr intptr_0;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;

		public int int_0;

		public uint uint_6;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string string_0;
	}

	private object object_0;

	private object object_1;

	private object object_2;

	private object object_3;

	private object object_4;

	private IntPtr intptr_0;

	private Struct0 struct0_0;

	private long long_0;

	private long long_1;

	private long long_2;

	private long long_3;

	private long long_4;

	private long long_5;

	private long long_6;

	private long long_7;

	private int int_0;

	private long long_8;

	private long long_9;

	private long long_10;

	private long long_11;

	private long long_12;

	private Struct5 struct5_0;

	private long long_13;

	private long long_14;

	private object object_5;

	private int int_1;

	private int int_2;

	private int int_3;

	private DateTime dateTime_0;

	private bool bool_0;

	private object object_6;

	public static Color color_0;

	private object object_7;

	private object object_8;

	private object object_9;

	private object object_10;

	private object object_11;

	private object object_12;

	private object object_13;

	private object object_14;

	private object object_15;

	private object object_16;

	private object object_17;

	private object object_18;

	private object object_19;

	private object object_20;

	private object object_21;

	private object object_22;

	private object object_23;

	private object object_24;

	private object object_25;

	private object object_26;

	private object object_27;

	private object object_28;

	private object object_29;

	private object object_30;

	private object object_31;

	private object object_32;

	private object object_33;

	private object object_34;

	private object object_35;

	private object object_36;

	private object object_37;

	private object object_38;

	private object object_39;

	private object object_40;

	private object object_41;

	private object object_42;

	private object object_43;

	private object object_44;

	private object object_45;

	private object object_46;

	private object object_47;

	private object object_48;

	private object object_49;

	private object object_50;

	private object object_51;

	private object object_52;

	private object object_53;

	private object object_54;

	private object object_55;

	private object object_56;

	private object object_57;

	private object object_58;

	private object object_59;

	private object object_60;

	private object object_61;

	private object object_62;

	private object object_63;

	private object object_64;

	private object object_65;

	private object object_66;

	private object object_67;

	private object object_68;

	private object object_69;

	private object object_70;

	private object object_71;

	private object object_72;

	private object object_73;

	private object object_74;

	private object object_75;

	private object object_76;

	private object object_77;

	private object object_78;

	private object object_79;

	private object object_80;

	private object object_81;

	private object object_82;

	private object object_83;

	private object object_84;

	private object object_85;

	private object object_86;

	private object object_87;

	private object object_88;

	private object object_89;

	private object object_90;

	private object object_91;

	private object object_92;

	private object object_93;

	private object object_94;

	private object object_95;

	private object object_96;

	private object object_97;

	private object object_98;

	private object object_99;

	private object object_100;

	private object object_101;

	private object object_102;

	private object object_103;

	private object object_104;

	private object object_105;

	private object object_106;

	private object object_107;

	private object object_108;

	private object object_109;

	private object object_110;

	private object object_111;

	private object object_112;

	private object object_113;

	private object object_114;

	private object object_115;

	private object object_116;

	private object object_117;

	private object object_118;

	private object object_119;

	private object object_120;

	private object object_121;

	private object object_122;

	private object object_123;

	private object object_124;

	private object object_125;

	private object object_126;

	private object object_127;

	private object object_128;

	private object object_129;

	private object object_130;

	private object object_131;

	private object object_132;

	private object object_133;

	private object object_134;

	private object object_135;

	private object object_136;

	private object object_137;

	private object object_138;

	private object object_139;

	private object object_140;

	private object object_141;

	private object object_142;

	private object object_143;

	private object object_144;

	internal object object_145;

	internal object object_146;

	internal object object_147;

	internal object object_148;

	private object object_149;

	private object object_150;

	private object object_151;

	private object object_152;

	private object object_153;

	internal static object object_154;

	private void method_0(object sender, EventArgs e)
	{
	}

	private void method_1()
	{
	}

	private void method_2()
	{
	}

	private IntPtr method_3()
	{
		return (IntPtr)(object)null;
	}

	private IntPtr method_4()
	{
		return (IntPtr)(object)null;
	}

	private bool method_5()
	{
		return true;
	}

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr GetWindow(IntPtr intptr_1, uint uint_0);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool GetWindowRect(IntPtr intptr_1, out Struct0 struct0_1);

	[DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern IntPtr FindWindow(string string_0, string string_1);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindowEx(IntPtr intptr_1, uint uint_0, string string_0, string string_1);

	[DllImport("user32.dll")]
	public static extern bool GetAsyncKeyState(Keys keys_0);

	[DllImport("advapi32", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool OpenProcessToken(IntPtr intptr_1, int int_4, ref IntPtr intptr_2);

	[DllImport("kernel32", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool CloseHandle(IntPtr intptr_1);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool LookupPrivilegeValue(string string_0, string string_1, ref Struct7 struct7_0);

	[DllImport("advapi32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool AdjustTokenPrivileges(IntPtr intptr_1, [MarshalAs(UnmanagedType.Bool)] bool bool_1, ref Struct9 struct9_0, uint uint_0, IntPtr intptr_2, IntPtr intptr_3);

	[DllImport("KERNEL32.DLL ")]
	public static extern IntPtr CreateToolhelp32Snapshot(uint uint_0, uint uint_1);

	[DllImport("KERNEL32.DLL ")]
	public static extern int Process32First(IntPtr intptr_1, ref Struct10 struct10_0);

	[DllImport("KERNEL32.DLL ")]
	public static extern int Process32Next(IntPtr intptr_1, ref Struct10 struct10_0);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	public static extern void mouse_event(long long_15, long long_16, long long_17, long long_18, long long_19);

	private void method_6(object sender, EventArgs e)
	{
	}

	private void method_7(object sender, EventArgs e)
	{
	}

	[DllImport("user32.dll", EntryPoint = "mouse_event")]
	public static extern void mouse_event_1(uint uint_0, int int_4, int int_5, uint uint_1, UIntPtr uintptr_0);

	private void method_8(object sender, FormClosingEventArgs e)
	{
	}

	private void method_9(object sender, EventArgs e)
	{
	}

	private void method_10(object sender, EventArgs e)
	{
	}

	private void method_11(object sender, EventArgs e)
	{
	}

	private void method_12(object sender, EventArgs e)
	{
	}

	private void method_13(object sender, EventArgs e)
	{
	}

	private void method_14(object sender, EventArgs e)
	{
	}

	private void method_15(object sender, EventArgs e)
	{
	}

	private void method_16(object sender, EventArgs e)
	{
	}

	private void method_17(object sender, EventArgs e)
	{
	}

	private void method_18(object sender, EventArgs e)
	{
	}

	private void method_19(object sender, EventArgs e)
	{
	}

	private void method_20(object sender, EventArgs e)
	{
	}

	private void method_21(object sender, EventArgs e)
	{
	}

	private void method_22(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_23(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_24(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_25(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_26(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_27(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_28(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_29(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_30(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_31(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_32(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_33(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_34(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_35(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_36(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_37(object sender, EventArgs e)
	{
	}

	private void method_38(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_39(object sender, PaintEventArgs e)
	{
	}

	private void method_40(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_41(object sender, EventArgs e)
	{
	}

	private void method_42(object sender, EventArgs e)
	{
	}

	private void method_43(object sender, EventArgs e)
	{
	}

	private void method_44(object sender, EventArgs e)
	{
	}

	private void method_45(object sender, EventArgs e)
	{
	}

	private void method_46(object sender, EventArgs e)
	{
	}

	private void method_47(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_48(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_49(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_50(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_51(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_52(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_53(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_54(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_55(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_56(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_57(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_58(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_59(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_60(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_61(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_62(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_63(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_64(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_65(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_66(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_67(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_68(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_69(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_70(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_71(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_72(object sender, EventArgs e)
	{
	}

	private void method_73(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_74(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_75(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_76(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_77(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_78(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_79(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_80(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_81(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_82(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_83(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_84(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_85(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_86(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_87(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_88(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_89(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_90(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_91(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_92(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_93(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_94(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_95(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_96(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_97(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_98(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_99(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_100(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_101(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_102(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_103(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_104(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_105(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_106(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_107(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_108(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_109(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_110(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_111(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_112(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_113(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_114(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_115(object sender, PaintEventArgs e)
	{
	}

	private void method_116(object sender, EventArgs e)
	{
	}

	private void method_117(object sender, MouseEventArgs e)
	{
	}

	private void method_118(object sender, MouseEventArgs e)
	{
	}

	private void method_119(object sender, MouseEventArgs e)
	{
	}

	private void method_120(object sender, EventArgs e)
	{
	}

	private void method_121(object sender, PaintEventArgs e)
	{
	}

	private void method_122(object sender, PaintEventArgs e)
	{
	}

	private void method_123(object sender, EventArgs e)
	{
	}

	private void method_124(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_125(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_126(object sender, EventArgs e)
	{
	}

	private void method_127(ToggleEventArgs toggleEventArgs_0)
	{
	}

	private void method_128(object sender, EventArgs e)
	{
	}

	private void method_129(object sender, EventArgs e)
	{
	}

	private void method_130(object sender, EventArgs e)
	{
	}

	private void method_131(object sender, EventArgs e)
	{
	}

	private void method_132(object sender, EventArgs e)
	{
	}

	public List<string> method_133(string string_0, string string_1)
	{
		return null;
	}

	private void method_134(object sender, FormClosedEventArgs e)
	{
	}

	private void method_135(object sender, EventArgs e)
	{
	}

	private void method_136(object sender, EventArgs e)
	{
	}

	private void method_137(object sender, EventArgs e)
	{
	}

	private void method_138(object sender, EventArgs e)
	{
	}

	private void method_139(object sender, EventArgs e)
	{
	}

	private void method_140(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	private void method_141()
	{
	}

	static Form0()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		Class25.smethod_22();
		Class25.smethod_13();
		Delegate11.smethod_0(Delegate11.delegate11_0);
		Delegate11.smethod_0(Delegate11.delegate11_2);
		color_0 = Delegate22.smethod_0(Delegate22.delegate22_2);
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static Form0 smethod_1()
	{
		return null;
	}

	internal static object smethod_2(object object_155)
	{
		return null;
	}

	internal static object smethod_3(object object_155)
	{
		return null;
	}

	internal static object smethod_4(object object_155)
	{
		return null;
	}

	internal static object smethod_5(object object_155)
	{
		return null;
	}

	internal static object smethod_6(object object_155)
	{
		return null;
	}

	internal static object smethod_7(object object_155)
	{
		return null;
	}

	internal static void smethod_8(object object_155, ControlBoxType controlBoxType_0)
	{
	}

	internal static void smethod_9(object object_155, CheckType checkType_0)
	{
	}

	internal static void smethod_10(object object_155, ValueDivisor valueDivisor_0)
	{
	}

	internal static void smethod_11(object object_155, ButtonStyles buttonStyles_0)
	{
	}

	internal static object smethod_12(object object_155)
	{
		return null;
	}

	internal static void smethod_13(object object_155, GroupBoxStyle groupBoxStyle_0)
	{
	}

	internal static object smethod_14(object object_155)
	{
		return null;
	}
}
