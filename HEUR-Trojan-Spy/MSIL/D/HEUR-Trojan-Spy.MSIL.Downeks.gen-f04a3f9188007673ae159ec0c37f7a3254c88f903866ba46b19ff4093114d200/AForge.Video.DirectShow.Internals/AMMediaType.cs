using System;
using System.Runtime.InteropServices;
using dg3ypDAonQcOidMs0w;

namespace AForge.Video.DirectShow.Internals;

[StructLayout(LayoutKind.Sequential)]
[ComVisible(false)]
internal class AMMediaType : IDisposable
{
	public Guid MajorType;

	public Guid SubType;

	[MarshalAs(UnmanagedType.Bool)]
	public bool FixedSizeSamples;

	[MarshalAs(UnmanagedType.Bool)]
	public bool TemporalCompression;

	public int SampleSize;

	public Guid FormatType;

	public IntPtr unkPtr;

	public int FormatSize;

	public IntPtr FormatPtr;

	internal static AMMediaType eoktaMiB4aoIK3137uh;

	~AMMediaType()
	{
	}

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	static AMMediaType()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		TAD6uFi9ZrDjb5ulTrS();
	}

	internal static void pjVGTti5lCbHUGiTwpC(object object_0, bool disposing)
	{
	}

	internal static void DZF4RCiJXlPGs5U8q5Q(object object_0)
	{
	}

	internal static bool yVSPsnifS08UsyumN6w()
	{
		return true;
	}

	internal static AMMediaType XbEDaaiGhJijnrebOuQ()
	{
		return null;
	}

	internal static void QRRDPRiWeLhP11CV0EB(object object_0)
	{
	}

	internal static bool N9Um6hiHJ2bQGyhAgh7(IntPtr intptr_0, IntPtr intptr_1)
	{
		return true;
	}

	internal static int MDIJFhiZW7e0okcGxeZ(IntPtr intptr_0)
	{
		return 0;
	}

	internal static void oFtd0Kil6gY4c8YM4mM()
	{
	}

	internal static void TAD6uFi9ZrDjb5ulTrS()
	{
	}
}
