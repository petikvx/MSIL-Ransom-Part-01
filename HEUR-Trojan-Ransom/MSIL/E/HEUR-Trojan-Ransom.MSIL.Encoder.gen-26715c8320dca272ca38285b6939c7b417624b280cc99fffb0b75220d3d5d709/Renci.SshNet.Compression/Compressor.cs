using System;
using System.IO;
using Renci.SshNet.Security;

namespace Renci.SshNet.Compression;

public abstract class Compressor : Algorithm, IDisposable
{
	private readonly ZlibStream _compressor;

	private readonly ZlibStream _decompressor;

	private MemoryStream _compressorStream;

	private MemoryStream _decompressorStream;

	private bool _isDisposed;

	protected bool IsActive { get; set; }

	protected Session Session { get; private set; }

	protected Compressor()
	{
		_compressorStream = new MemoryStream();
		_decompressorStream = new MemoryStream();
		_compressor = new ZlibStream(_compressorStream, CompressionMode.Compress);
		_decompressor = new ZlibStream(_decompressorStream, CompressionMode.Decompress);
	}

	public virtual void Init(Session session)
	{
		Session = session;
	}

	public virtual byte[] Compress(byte[] data)
	{
		return Compress(data, 0, data.Length);
	}

	public virtual byte[] Compress(byte[] data, int offset, int length)
	{
		if (!IsActive)
		{
			if (offset == 0 && length == data.Length)
			{
				return data;
			}
			byte[] array = new byte[length];
			Buffer.BlockCopy(data, offset, array, 0, length);
			return array;
		}
		_compressorStream.SetLength(0L);
		_compressor.Write(data, offset, length);
		return _compressorStream.ToArray();
	}

	public virtual byte[] Decompress(byte[] data)
	{
		return Decompress(data, 0, data.Length);
	}

	public virtual byte[] Decompress(byte[] data, int offset, int length)
	{
		if (!IsActive)
		{
			if (offset == 0 && length == data.Length)
			{
				return data;
			}
			byte[] array = new byte[length];
			Buffer.BlockCopy(data, offset, array, 0, length);
			return array;
		}
		_decompressorStream.SetLength(0L);
		_decompressor.Write(data, offset, length);
		return _decompressorStream.ToArray();
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!_isDisposed && disposing)
		{
			MemoryStream compressorStream = _compressorStream;
			if (compressorStream != null)
			{
				compressorStream.Dispose();
				_compressorStream = null;
			}
			MemoryStream decompressorStream = _decompressorStream;
			if (decompressorStream != null)
			{
				decompressorStream.Dispose();
				_decompressorStream = null;
			}
			_isDisposed = true;
		}
	}

	~Compressor()
	{
		Dispose(disposing: false);
	}
}
