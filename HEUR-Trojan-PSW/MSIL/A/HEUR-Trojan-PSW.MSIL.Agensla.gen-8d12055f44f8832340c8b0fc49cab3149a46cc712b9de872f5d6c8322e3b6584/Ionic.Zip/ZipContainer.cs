using System;
using System.IO;
using System.Text;
using Ionic.Zlib;

namespace Ionic.Zip;

internal class ZipContainer
{
	private ZipFile _zf;

	private ZipOutputStream _zos;

	private ZipInputStream _zis;

	public ZipFile ZipFile => _zf;

	public ZipOutputStream ZipOutputStream => _zos;

	public string Name
	{
		get
		{
			if (_zf != null)
			{
				return _zf.Name;
			}
			if (_zis != null)
			{
				throw new NotSupportedException();
			}
			return _zos.Name;
		}
	}

	public string Password
	{
		get
		{
			if (_zf != null)
			{
				return _zf._Password;
			}
			if (_zis != null)
			{
				return _zis._Password;
			}
			return _zos._password;
		}
	}

	public Zip64Option Zip64
	{
		get
		{
			if (_zf != null)
			{
				return _zf._zip64;
			}
			if (_zis != null)
			{
				throw new NotSupportedException();
			}
			return _zos._zip64;
		}
	}

	public int BufferSize
	{
		get
		{
			if (_zf != null)
			{
				return _zf.BufferSize;
			}
			if (_zis != null)
			{
				throw new NotSupportedException();
			}
			return 0;
		}
	}

	public ParallelDeflateOutputStream ParallelDeflater
	{
		get
		{
			if (_zf != null)
			{
				return _zf.ParallelDeflater;
			}
			if (_zis != null)
			{
				return null;
			}
			return _zos.ParallelDeflater;
		}
		set
		{
			if (_zf != null)
			{
				_zf.ParallelDeflater = value;
			}
			else if (_zos != null)
			{
				_zos.ParallelDeflater = value;
			}
		}
	}

	public long ParallelDeflateThreshold
	{
		get
		{
			if (_zf != null)
			{
				return _zf.ParallelDeflateThreshold;
			}
			return _zos.ParallelDeflateThreshold;
		}
	}

	public int ParallelDeflateMaxBufferPairs
	{
		get
		{
			if (_zf != null)
			{
				return _zf.ParallelDeflateMaxBufferPairs;
			}
			return _zos.ParallelDeflateMaxBufferPairs;
		}
	}

	public int CodecBufferSize
	{
		get
		{
			if (_zf != null)
			{
				return _zf.CodecBufferSize;
			}
			if (_zis != null)
			{
				return _zis.CodecBufferSize;
			}
			return _zos.CodecBufferSize;
		}
	}

	public CompressionStrategy Strategy
	{
		get
		{
			if (_zf != null)
			{
				return _zf.Strategy;
			}
			return _zos.Strategy;
		}
	}

	public Zip64Option UseZip64WhenSaving
	{
		get
		{
			if (_zf != null)
			{
				return _zf.UseZip64WhenSaving;
			}
			return _zos.EnableZip64;
		}
	}

	public Encoding AlternateEncoding
	{
		get
		{
			if (_zf != null)
			{
				return _zf.AlternateEncoding;
			}
			if (_zos != null)
			{
				return _zos.AlternateEncoding;
			}
			return null;
		}
	}

	public Encoding DefaultEncoding
	{
		get
		{
			if (_zf != null)
			{
				return ZipFile.DefaultEncoding;
			}
			if (_zos != null)
			{
				return ZipOutputStream.DefaultEncoding;
			}
			return null;
		}
	}

	public ZipOption AlternateEncodingUsage
	{
		get
		{
			if (_zf != null)
			{
				return _zf.AlternateEncodingUsage;
			}
			if (_zos != null)
			{
				return _zos.AlternateEncodingUsage;
			}
			return ZipOption.Default;
		}
	}

	public Stream ReadStream
	{
		get
		{
			if (_zf != null)
			{
				return _zf.ReadStream;
			}
			return _zis.ReadStream;
		}
	}

	public ZipContainer(object o)
	{
		_zf = o as ZipFile;
		_zos = o as ZipOutputStream;
		_zis = o as ZipInputStream;
	}
}
