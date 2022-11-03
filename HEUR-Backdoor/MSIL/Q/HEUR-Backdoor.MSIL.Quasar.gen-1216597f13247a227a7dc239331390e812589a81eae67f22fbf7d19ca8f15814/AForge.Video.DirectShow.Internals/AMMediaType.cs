using System;
using System.Runtime.InteropServices;

namespace AForge.Video.DirectShow.Internals;

[StructLayout(LayoutKind.Sequential)]
[ComVisible(false)]
internal class AMMediaType : IDisposable
{
	public Guid MajorType;

	public Guid SubType;

	[MarshalAs(UnmanagedType.Bool)]
	public bool FixedSizeSamples = true;

	[MarshalAs(UnmanagedType.Bool)]
	public bool TemporalCompression;

	public int SampleSize = 1;

	public Guid FormatType;

	public IntPtr unkPtr;

	public int FormatSize;

	public IntPtr FormatPtr;

	~AMMediaType()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (FormatSize != 0 && FormatPtr != IntPtr.Zero)
		{
			Marshal.FreeCoTaskMem(FormatPtr);
			FormatSize = 0;
		}
		if (unkPtr != IntPtr.Zero)
		{
			Marshal.Release(unkPtr);
			unkPtr = IntPtr.Zero;
		}
	}
}
