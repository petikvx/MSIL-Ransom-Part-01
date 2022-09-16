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

	internal static AMMediaType NkQpGgerxrwyMTSFxlO;

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
		XJAWbOewTo2GKwYUa94();
	}

	internal static void SafrcReiUZg9NmnXXix(object object_0, bool disposing)
	{
	}

	internal static void EPiUGte9HuYSk5quVcI(object object_0)
	{
	}

	internal static bool QjR1eneElhBlv5aRcFF()
	{
		return true;
	}

	internal static AMMediaType fxKd4neOsjP45YCgC5u()
	{
		return null;
	}

	internal static bool yiQmOTe5O6WbxRYM3mC(IntPtr intptr_0, IntPtr intptr_1)
	{
		return true;
	}

	internal static int JWJFYie4MpxfHUOulT9(IntPtr intptr_0)
	{
		return 0;
	}

	internal static void c5Ku8pehkVCXyB9Abfn()
	{
	}

	internal static void XJAWbOewTo2GKwYUa94()
	{
	}
}
