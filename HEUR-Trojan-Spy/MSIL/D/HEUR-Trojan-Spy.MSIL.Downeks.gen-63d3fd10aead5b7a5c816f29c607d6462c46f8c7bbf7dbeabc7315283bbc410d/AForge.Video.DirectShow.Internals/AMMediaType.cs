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

	private static AMMediaType eVl25DraCKXQ482YTWW;

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
		AHG4ihrUVq4dPlwQYhg();
	}

	internal static void jHmoJOrE0VhpoB86TGN(object object_0, bool disposing)
	{
	}

	internal static bool IcygT8r4RD9pwF35D9K()
	{
		return true;
	}

	internal static AMMediaType JskMAsrbl0nLcIpD2yr()
	{
		return null;
	}

	internal static void THGmlVrBLaSg0e07IC9(object object_0)
	{
	}

	internal static bool wbohTPrT5HAjySld2vb(IntPtr intptr_0, IntPtr intptr_1)
	{
		return true;
	}

	internal static int lSVNqDrZHNERnlh9Pos(IntPtr intptr_0)
	{
		return 0;
	}

	internal static void JNLukJrgAxResbKsZXJ()
	{
	}

	internal static void qW2qLQrFZYNvNeJnolN()
	{
	}

	internal static void AHG4ihrUVq4dPlwQYhg()
	{
	}
}
