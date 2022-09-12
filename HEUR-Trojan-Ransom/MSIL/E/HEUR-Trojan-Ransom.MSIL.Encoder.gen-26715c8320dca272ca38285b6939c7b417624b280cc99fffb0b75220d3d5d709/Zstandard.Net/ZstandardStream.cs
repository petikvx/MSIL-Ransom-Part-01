using System;
using System.Buffers;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;

namespace Zstandard.Net;

public class ZstandardStream : Stream
{
	private Stream stream;

	private CompressionMode mode;

	private bool leaveOpen;

	private bool isClosed = false;

	private bool isDisposed = false;

	private bool isInitialized = false;

	private IntPtr zstream;

	private uint zstreamInputSize;

	private uint zstreamOutputSize;

	private byte[] data;

	private bool dataDepleted = false;

	private bool dataSkipRead = false;

	private int dataPosition = 0;

	private int dataSize = 0;

	private ZstandardInterop.Buffer outputBuffer = new ZstandardInterop.Buffer();

	private ZstandardInterop.Buffer inputBuffer = new ZstandardInterop.Buffer();

	private ArrayPool<byte> arrayPool = ArrayPool<byte>.Shared;

	public static Version Version
	{
		get
		{
			int num = (int)ZstandardInterop.ZSTD_versionNumber();
			return new Version(num / 10000 % 100, num / 100 % 100, num % 100);
		}
	}

	public static int MaxCompressionLevel => ZstandardInterop.ZSTD_maxCLevel();

	public int CompressionLevel { get; set; } = 6;


	public ZstandardDictionary CompressionDictionary { get; set; } = null;


	public override bool CanRead => stream.CanRead && mode == CompressionMode.Decompress;

	public override bool CanWrite => stream.CanWrite && mode == CompressionMode.Compress;

	public override bool CanSeek => false;

	public override long Length
	{
		get
		{
			throw new NotSupportedException();
		}
	}

	public override long Position
	{
		get
		{
			throw new NotSupportedException();
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	public ZstandardStream(Stream stream, CompressionMode mode, bool leaveOpen = false)
	{
		this.stream = stream ?? throw new ArgumentNullException("stream");
		this.mode = mode;
		this.leaveOpen = leaveOpen;
		if (mode == CompressionMode.Compress)
		{
			zstreamInputSize = ZstandardInterop.ZSTD_CStreamInSize().ToUInt32();
			zstreamOutputSize = ZstandardInterop.ZSTD_CStreamOutSize().ToUInt32();
			zstream = ZstandardInterop.ZSTD_createCStream();
			data = arrayPool.Rent((int)zstreamOutputSize);
		}
		if (mode == CompressionMode.Decompress)
		{
			zstreamInputSize = ZstandardInterop.ZSTD_DStreamInSize().ToUInt32();
			zstreamOutputSize = ZstandardInterop.ZSTD_DStreamOutSize().ToUInt32();
			zstream = ZstandardInterop.ZSTD_createDStream();
			data = arrayPool.Rent((int)zstreamInputSize);
		}
	}

	public ZstandardStream(Stream stream, int compressionLevel, bool leaveOpen = false)
		: this(stream, CompressionMode.Compress, leaveOpen)
	{
		CompressionLevel = compressionLevel;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (!isDisposed)
		{
			if (!isClosed)
			{
				ReleaseResources(flushStream: false);
			}
			arrayPool.Return(data);
			isDisposed = true;
			data = null;
		}
	}

	public override void Close()
	{
		if (!isClosed)
		{
			try
			{
				ReleaseResources(flushStream: true);
			}
			finally
			{
				isClosed = true;
				base.Close();
			}
		}
	}

	private void ReleaseResources(bool flushStream)
	{
		if (mode == CompressionMode.Compress)
		{
			try
			{
				if (flushStream)
				{
					ProcessStream(delegate(IntPtr zcs, ZstandardInterop.Buffer buffer)
					{
						ZstandardInterop.ThrowIfError(ZstandardInterop.ZSTD_flushStream(zcs, buffer));
					});
					ProcessStream(delegate(IntPtr zcs, ZstandardInterop.Buffer buffer)
					{
						ZstandardInterop.ThrowIfError(ZstandardInterop.ZSTD_endStream(zcs, buffer));
					});
					stream.Flush();
				}
				return;
			}
			finally
			{
				ZstandardInterop.ZSTD_freeCStream(zstream);
				if (!leaveOpen)
				{
					stream.Close();
				}
			}
		}
		if (mode == CompressionMode.Decompress)
		{
			ZstandardInterop.ZSTD_freeDStream(zstream);
			if (!leaveOpen)
			{
				stream.Close();
			}
		}
	}

	public override void Flush()
	{
		if (mode == CompressionMode.Compress)
		{
			ProcessStream(delegate(IntPtr zcs, ZstandardInterop.Buffer buffer)
			{
				ZstandardInterop.ThrowIfError(ZstandardInterop.ZSTD_flushStream(zcs, buffer));
			});
			stream.Flush();
		}
		if (mode == CompressionMode.Decompress)
		{
			dataDepleted = false;
			dataSkipRead = false;
		}
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (!CanRead)
		{
			throw new NotSupportedException();
		}
		GCHandle gCHandle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
		GCHandle gCHandle2 = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			int num = 0;
			if (!isInitialized)
			{
				isInitialized = true;
				if (CompressionDictionary == null)
				{
					ZstandardInterop.ZSTD_initDStream(zstream);
				}
				else
					ZstandardInterop.ZSTD_initDStream_usingDDict(zstream, CompressionDictionary.GetDecompressionDictionary());
			}
			while (count > 0)
			{
				int num2 = dataSize - dataPosition;
				if (num2 <= 0 && !dataDepleted && !dataSkipRead)
				{
					dataSize = stream.Read(data, 0, (int)zstreamInputSize);
					dataDepleted = dataSize <= 0;
					dataPosition = 0;
					num2 = ((!dataDepleted) ? dataSize : 0);
					dataSkipRead = true;
				}
				inputBuffer.Data = ((num2 <= 0) ? IntPtr.Zero : Marshal.UnsafeAddrOfPinnedArrayElement((Array)data, dataPosition));
				inputBuffer.Size = ((num2 <= 0) ? UIntPtr.Zero : new UIntPtr((uint)num2));
				inputBuffer.Position = UIntPtr.Zero;
				outputBuffer.Data = Marshal.UnsafeAddrOfPinnedArrayElement((Array)buffer, offset);
				outputBuffer.Size = new UIntPtr((uint)count);
				outputBuffer.Position = UIntPtr.Zero;
				ZstandardInterop.ThrowIfError(ZstandardInterop.ZSTD_decompressStream(zstream, outputBuffer, inputBuffer));
				int num3 = (int)outputBuffer.Position.ToUInt32();
				if (num3 == 0)
				{
					if (dataDepleted)
					{
						break;
					}
					dataSkipRead = false;
				}
				num += num3;
				offset += num3;
				count -= num3;
				int num4 = (int)inputBuffer.Position.ToUInt32();
				dataPosition += num4;
			}
			return num;
		}
		finally
		{
			gCHandle.Free();
			gCHandle2.Free();
		}
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		if (!CanWrite)
		{
			throw new NotSupportedException();
		}
		GCHandle gCHandle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
		GCHandle gCHandle2 = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			if (!isInitialized)
			{
				isInitialized = true;
				UIntPtr code = ((CompressionDictionary == null) ? ZstandardInterop.ZSTD_initCStream(zstream, CompressionLevel) : ZstandardInterop.ZSTD_initCStream_usingCDict(zstream, CompressionDictionary.GetCompressionDictionary(CompressionLevel)));
				ZstandardInterop.ThrowIfError(code);
			}
			while (count > 0)
			{
				uint value = Math.Min((uint)count, zstreamInputSize);
				outputBuffer.Data = Marshal.UnsafeAddrOfPinnedArrayElement((Array)data, 0);
				outputBuffer.Size = new UIntPtr(zstreamOutputSize);
				outputBuffer.Position = UIntPtr.Zero;
				inputBuffer.Data = Marshal.UnsafeAddrOfPinnedArrayElement((Array)buffer, offset);
				inputBuffer.Size = new UIntPtr(value);
				inputBuffer.Position = UIntPtr.Zero;
				ZstandardInterop.ThrowIfError(ZstandardInterop.ZSTD_compressStream(zstream, outputBuffer, inputBuffer));
				int count2 = (int)outputBuffer.Position.ToUInt32();
				stream.Write(data, 0, count2);
				int num = (int)inputBuffer.Position.ToUInt32();
				offset += num;
				count -= num;
			}
		}
		finally
		{
			gCHandle.Free();
			gCHandle2.Free();
		}
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotImplementedException();
	}

	public override void SetLength(long value)
	{
		throw new NotImplementedException();
	}

	private void ProcessStream(Action<IntPtr, ZstandardInterop.Buffer> outputAction)
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			outputBuffer.Data = Marshal.UnsafeAddrOfPinnedArrayElement((Array)data, 0);
			outputBuffer.Size = new UIntPtr(zstreamOutputSize);
			outputBuffer.Position = UIntPtr.Zero;
			outputAction(zstream, outputBuffer);
			int count = (int)outputBuffer.Position.ToUInt32();
			stream.Write(data, 0, count);
		}
		finally
		{
			gCHandle.Free();
		}
	}
}
