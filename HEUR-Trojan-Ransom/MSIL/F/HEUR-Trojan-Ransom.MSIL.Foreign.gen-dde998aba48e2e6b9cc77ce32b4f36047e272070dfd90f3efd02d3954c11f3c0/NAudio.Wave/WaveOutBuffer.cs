using System;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

internal sealed class WaveOutBuffer : IDisposable
{
	private readonly WaveHeader header;

	private readonly int bufferSize;

	private readonly byte[] buffer;

	private readonly IWaveProvider waveStream;

	private readonly object waveOutLock;

	private GCHandle hBuffer;

	private IntPtr hWaveOut;

	private GCHandle hHeader;

	private GCHandle hThis;

	[NonSerialized]
	internal static GetString _0013;

	public bool InQueue => (header.flags & WaveHeaderFlags.InQueue) == WaveHeaderFlags.InQueue;

	public int BufferSize => bufferSize;

	public WaveOutBuffer(IntPtr hWaveOut, int bufferSize, IWaveProvider bufferFillStream, object waveOutLock)
	{
		this.bufferSize = bufferSize;
		buffer = new byte[bufferSize];
		hBuffer = GCHandle.Alloc(buffer, GCHandleType.Pinned);
		this.hWaveOut = hWaveOut;
		waveStream = bufferFillStream;
		this.waveOutLock = waveOutLock;
		header = new WaveHeader();
		hHeader = GCHandle.Alloc(header, GCHandleType.Pinned);
		header.dataBuffer = hBuffer.AddrOfPinnedObject();
		header.bufferLength = bufferSize;
		header.loops = 1;
		hThis = GCHandle.Alloc(this);
		header.userData = (IntPtr)hThis;
		lock (waveOutLock)
		{
			MmException.Try(WaveInterop.waveOutPrepareHeader(hWaveOut, header, Marshal.SizeOf((object)header)), _0013(107384342));
		}
	}

	~WaveOutBuffer()
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
		if (hWaveOut != IntPtr.Zero)
		{
			lock (waveOutLock)
			{
				WaveInterop.waveOutUnprepareHeader(hWaveOut, header, Marshal.SizeOf((object)header));
			}
			hWaveOut = IntPtr.Zero;
		}
	}

	internal bool OnDone()
	{
		int num;
		lock (waveStream)
		{
			num = waveStream.Read(buffer, 0, buffer.Length);
		}
		if (num == 0)
		{
			return false;
		}
		for (int i = num; i < buffer.Length; i++)
		{
			buffer[i] = 0;
		}
		WriteToWaveOut();
		return true;
	}

	private void WriteToWaveOut()
	{
		MmResult mmResult;
		lock (waveOutLock)
		{
			mmResult = WaveInterop.waveOutWrite(hWaveOut, header, Marshal.SizeOf((object)header));
		}
		if (mmResult != 0)
		{
			throw new MmException(mmResult, _0013(107384281));
		}
		GC.KeepAlive(this);
	}

	static WaveOutBuffer()
	{
		Strings.CreateGetStringDelegate(typeof(WaveOutBuffer));
	}
}
