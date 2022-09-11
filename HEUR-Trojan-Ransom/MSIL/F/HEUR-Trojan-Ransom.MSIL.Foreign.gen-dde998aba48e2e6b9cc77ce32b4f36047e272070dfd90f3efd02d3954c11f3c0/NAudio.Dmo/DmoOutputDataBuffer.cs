using System;
using System.Runtime.InteropServices;

namespace NAudio.Dmo;

[StructLayout(LayoutKind.Sequential, Pack = 8)]
public struct DmoOutputDataBuffer : IDisposable
{
	[MarshalAs(UnmanagedType.Interface)]
	private IMediaBuffer pBuffer;

	private DmoOutputDataBufferFlags dwStatus;

	private long rtTimestamp;

	private long referenceTimeDuration;

	public IMediaBuffer MediaBuffer
	{
		get
		{
			return pBuffer;
		}
		internal set
		{
			pBuffer = value;
		}
	}

	public int Length => ((MediaBuffer)pBuffer).Length;

	public DmoOutputDataBufferFlags StatusFlags
	{
		get
		{
			return dwStatus;
		}
		internal set
		{
			dwStatus = value;
		}
	}

	public long Timestamp
	{
		get
		{
			return rtTimestamp;
		}
		internal set
		{
			rtTimestamp = value;
		}
	}

	public long Duration
	{
		get
		{
			return referenceTimeDuration;
		}
		internal set
		{
			referenceTimeDuration = value;
		}
	}

	public bool MoreDataAvailable => (StatusFlags & DmoOutputDataBufferFlags.Incomplete) == DmoOutputDataBufferFlags.Incomplete;

	public DmoOutputDataBuffer(int maxBufferSize)
	{
		pBuffer = new MediaBuffer(maxBufferSize);
		dwStatus = DmoOutputDataBufferFlags.None;
		rtTimestamp = 0L;
		referenceTimeDuration = 0L;
	}

	public void Dispose()
	{
		if (pBuffer != null)
		{
			((MediaBuffer)pBuffer).Dispose();
			pBuffer = null;
			GC.SuppressFinalize(this);
		}
	}

	public void RetrieveData(byte[] data, int offset)
	{
		((MediaBuffer)pBuffer).RetrieveData(data, offset);
	}
}
