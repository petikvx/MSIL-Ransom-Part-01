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

	private static AMMediaType HoFU5qNXygpMSjSXG0a;

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
		P6o1qXZ1KbmFvnmyZjm();
	}

	internal static bool trTiLtNzb0YWZpWexlX()
	{
		return true;
	}

	internal static AMMediaType sX8ooHZtEpwyUIdspir()
	{
		return null;
	}

	internal static void V7xakGZxB7dt0mVgL6C(object object_0, bool disposing)
	{
	}

	internal static void QfXhhtZcWaM00h666Dl(IntPtr intptr_0)
	{
	}

	internal static bool kY1xppZHmiO0oJu5KWS(IntPtr intptr_0, IntPtr intptr_1)
	{
		return true;
	}

	internal static int ugKFTNZvNkPHXohB3hp(IntPtr intptr_0)
	{
		return 0;
	}

	internal static void YpPrElZPMc8aUK6vGWU()
	{
	}

	internal static void P6o1qXZ1KbmFvnmyZjm()
	{
	}
}
