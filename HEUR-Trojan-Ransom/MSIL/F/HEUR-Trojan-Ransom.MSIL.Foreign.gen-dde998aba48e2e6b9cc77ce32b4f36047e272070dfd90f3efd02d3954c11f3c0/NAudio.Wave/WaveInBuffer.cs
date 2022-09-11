using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

internal sealed class WaveInBuffer : IDisposable
{
	private readonly WaveHeader header;

	private readonly int bufferSize;

	private readonly byte[] buffer;

	private GCHandle hBuffer;

	private IntPtr waveInHandle;

	private GCHandle hHeader;

	private GCHandle hThis;

	[NonSerialized]
	internal static GetString _001C;

	public byte[] Data => buffer;

	public bool Done => (header.flags & WaveHeaderFlags.Done) == WaveHeaderFlags.Done;

	public bool InQueue => (header.flags & WaveHeaderFlags.InQueue) == WaveHeaderFlags.InQueue;

	public int BytesRecorded => header.bytesRecorded;

	public int BufferSize => bufferSize;

	public WaveInBuffer(IntPtr waveInHandle, int bufferSize)
	{
		this.bufferSize = bufferSize;
		buffer = new byte[bufferSize];
		hBuffer = GCHandle.Alloc(buffer, GCHandleType.Pinned);
		this.waveInHandle = waveInHandle;
		header = new WaveHeader();
		hHeader = GCHandle.Alloc(header, GCHandleType.Pinned);
		header.dataBuffer = hBuffer.AddrOfPinnedObject();
		header.bufferLength = bufferSize;
		header.loops = 1;
		hThis = GCHandle.Alloc(this);
		header.userData = (IntPtr)hThis;
		MmException.Try(WaveInterop.waveInPrepareHeader(waveInHandle, header, Marshal.SizeOf((object)header)), _001C(107384920));
	}

	public void Reuse()
	{
		MmException.Try(WaveInterop.waveInUnprepareHeader(waveInHandle, header, Marshal.SizeOf((object)header)), _001C(107384859));
		MmException.Try(WaveInterop.waveInPrepareHeader(waveInHandle, header, Marshal.SizeOf((object)header)), _001C(107384920));
		MmException.Try(WaveInterop.waveInAddBuffer(waveInHandle, header, Marshal.SizeOf((object)header)), _001C(107384318));
	}

	~WaveInBuffer()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		GC.SuppressFinalize(this);
		Dispose(disposing: true);
	}

	protected void Dispose(bool disposing)
	{
		if (waveInHandle != IntPtr.Zero)
		{
			WaveInterop.waveInUnprepareHeader(waveInHandle, header, Marshal.SizeOf((object)header));
			waveInHandle = IntPtr.Zero;
		}
		if (hHeader.IsAllocated)
		{
			hHeader.Free();
		}
		if (hBuffer.IsAllocated)
		{
			hBuffer.Free();
		}
		if (hThis.IsAllocated)
		{
			hThis.Free();
		}
	}

	static WaveInBuffer()
	{
		Strings.CreateGetStringDelegate(typeof(WaveInBuffer));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _001C(107398540), _001C(107398503)), _001C(107398498), _001C(107398493)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _001C(107398520)))
		{
			return;
		}
		throw new SecurityException(_001C(107398463));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
