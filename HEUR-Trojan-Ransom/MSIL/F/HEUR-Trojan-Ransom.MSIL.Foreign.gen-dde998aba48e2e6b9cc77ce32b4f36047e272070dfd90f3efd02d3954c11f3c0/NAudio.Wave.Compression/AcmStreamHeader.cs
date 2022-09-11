using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave.Compression;

internal sealed class AcmStreamHeader : IDisposable
{
	private AcmStreamHeaderStruct streamHeader;

	private byte[] sourceBuffer;

	private GCHandle hSourceBuffer;

	private byte[] destBuffer;

	private GCHandle hDestBuffer;

	private IntPtr streamHandle;

	private bool firstTime;

	private bool disposed;

	[NonSerialized]
	internal static GetString _0096;

	public byte[] SourceBuffer => sourceBuffer;

	public byte[] DestBuffer => destBuffer;

	public AcmStreamHeader(IntPtr streamHandle, int sourceBufferLength, int destBufferLength)
	{
		streamHeader = new AcmStreamHeaderStruct();
		sourceBuffer = new byte[sourceBufferLength];
		hSourceBuffer = GCHandle.Alloc(sourceBuffer, GCHandleType.Pinned);
		destBuffer = new byte[destBufferLength];
		hDestBuffer = GCHandle.Alloc(destBuffer, GCHandleType.Pinned);
		this.streamHandle = streamHandle;
		firstTime = true;
	}

	private void Prepare()
	{
		streamHeader.cbStruct = Marshal.SizeOf((object)streamHeader);
		streamHeader.sourceBufferLength = sourceBuffer.Length;
		streamHeader.sourceBufferPointer = hSourceBuffer.AddrOfPinnedObject();
		streamHeader.destBufferLength = destBuffer.Length;
		streamHeader.destBufferPointer = hDestBuffer.AddrOfPinnedObject();
		MmException.Try(AcmInterop.acmStreamPrepareHeader(streamHandle, streamHeader, 0), _0096(107415272));
	}

	private void Unprepare()
	{
		streamHeader.sourceBufferLength = sourceBuffer.Length;
		streamHeader.sourceBufferPointer = hSourceBuffer.AddrOfPinnedObject();
		streamHeader.destBufferLength = destBuffer.Length;
		streamHeader.destBufferPointer = hDestBuffer.AddrOfPinnedObject();
		MmResult mmResult = AcmInterop.acmStreamUnprepareHeader(streamHandle, streamHeader, 0);
		if (mmResult != 0)
		{
			throw new MmException(mmResult, _0096(107415239));
		}
	}

	public void Reposition()
	{
		firstTime = true;
	}

	public int Convert(int bytesToConvert, out int sourceBytesConverted)
	{
		Prepare();
		try
		{
			streamHeader.sourceBufferLength = bytesToConvert;
			streamHeader.sourceBufferLengthUsed = bytesToConvert;
			AcmStreamConvertFlags streamConvertFlags = (firstTime ? (AcmStreamConvertFlags.BlockAlign | AcmStreamConvertFlags.Start) : AcmStreamConvertFlags.BlockAlign);
			MmException.Try(AcmInterop.acmStreamConvert(streamHandle, streamHeader, streamConvertFlags), _0096(107415206));
			firstTime = false;
			sourceBytesConverted = streamHeader.sourceBufferLengthUsed;
		}
		finally
		{
			Unprepare();
		}
		return streamHeader.destBufferLengthUsed;
	}

	public void Dispose()
	{
		GC.SuppressFinalize(this);
		Dispose(disposing: true);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!disposed)
		{
			sourceBuffer = null;
			destBuffer = null;
			hSourceBuffer.Free();
			hDestBuffer.Free();
		}
		disposed = true;
	}

	~AcmStreamHeader()
	{
		Dispose(disposing: false);
	}

	static AcmStreamHeader()
	{
		Strings.CreateGetStringDelegate(typeof(AcmStreamHeader));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0096(107398870), _0096(107398833)), _0096(107398828), _0096(107398823)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0096(107398850)))
		{
			return;
		}
		throw new SecurityException(_0096(107398793));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
