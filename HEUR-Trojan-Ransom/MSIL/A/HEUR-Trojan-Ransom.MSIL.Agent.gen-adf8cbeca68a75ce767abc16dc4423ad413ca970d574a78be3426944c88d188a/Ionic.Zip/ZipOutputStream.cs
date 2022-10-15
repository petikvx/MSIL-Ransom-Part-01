using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Ionic.Crc;
using Ionic.Zlib;

namespace Ionic.Zip;

public class ZipOutputStream : Stream
{
	private EncryptionAlgorithm _encryption;

	private ZipEntryTimestamp _timestamp;

	internal string _password;

	private string _comment;

	private Stream _outputStream;

	private ZipEntry _currentEntry;

	internal Zip64Option _zip64;

	private Dictionary<string, ZipEntry> _entriesWritten;

	private int _entryCount;

	private ZipOption _alternateEncodingUsage = ZipOption.Default;

	private Encoding _alternateEncoding = Encoding.GetEncoding("IBM437");

	private bool _leaveUnderlyingStreamOpen;

	private bool _disposed;

	private bool _exceptionPending;

	private bool _anyEntriesUsedZip64;

	private bool _directoryNeededZip64;

	private CountingStream _outputCounter;

	private Stream _encryptor;

	private Stream _deflater;

	private CrcCalculatorStream _entryOutputStream;

	private bool _needToWriteEntryHeader;

	private string _name;

	private bool _DontIgnoreCase;

	internal ParallelDeflateOutputStream ParallelDeflater;

	private long _ParallelDeflateThreshold;

	private int _maxBufferPairs = 16;

	public string Password
	{
		set
		{
			if (_disposed)
			{
				_exceptionPending = true;
				throw new InvalidOperationException("The stream has been closed.");
			}
			_password = value;
			if (_password == null)
			{
				_encryption = EncryptionAlgorithm.None;
			}
			else if (_encryption == EncryptionAlgorithm.None)
			{
				_encryption = EncryptionAlgorithm.PkzipWeak;
			}
		}
	}

	public EncryptionAlgorithm Encryption
	{
		get
		{
			return _encryption;
		}
		set
		{
			if (_disposed)
			{
				_exceptionPending = true;
				throw new InvalidOperationException("The stream has been closed.");
			}
			if (value == EncryptionAlgorithm.Unsupported)
			{
				_exceptionPending = true;
				throw new InvalidOperationException("You may not set Encryption to that value.");
			}
			_encryption = value;
		}
	}

	public int CodecBufferSize { get; set; }

	public CompressionStrategy Strategy { get; set; }

	public ZipEntryTimestamp Timestamp
	{
		get
		{
			return _timestamp;
		}
		set
		{
			if (_disposed)
			{
				_exceptionPending = true;
				throw new InvalidOperationException("The stream has been closed.");
			}
			_timestamp = value;
		}
	}

	public CompressionLevel CompressionLevel { get; set; }

	public CompressionMethod CompressionMethod { get; set; }

	public string Comment
	{
		get
		{
			return _comment;
		}
		set
		{
			if (_disposed)
			{
				_exceptionPending = true;
				throw new InvalidOperationException("The stream has been closed.");
			}
			_comment = value;
		}
	}

	public Zip64Option EnableZip64
	{
		get
		{
			return _zip64;
		}
		set
		{
			if (_disposed)
			{
				_exceptionPending = true;
				throw new InvalidOperationException("The stream has been closed.");
			}
			_zip64 = value;
		}
	}

	public bool OutputUsedZip64 => _anyEntriesUsedZip64 || _directoryNeededZip64;

	public bool IgnoreCase
	{
		get
		{
			return !_DontIgnoreCase;
		}
		set
		{
			_DontIgnoreCase = !value;
		}
	}

	[Obsolete("Beginning with v1.9.1.6 of DotNetZip, this property is obsolete. It will be removed in a future version of the library. Use AlternateEncoding and AlternateEncodingUsage instead.")]
	public bool UseUnicodeAsNecessary
	{
		get
		{
			return _alternateEncoding == Encoding.UTF8 && AlternateEncodingUsage == ZipOption.AsNecessary;
		}
		set
		{
			if (value)
			{
				_alternateEncoding = Encoding.UTF8;
				_alternateEncodingUsage = ZipOption.AsNecessary;
			}
			else
			{
				_alternateEncoding = DefaultEncoding;
				_alternateEncodingUsage = ZipOption.Default;
			}
		}
	}

	[Obsolete("use AlternateEncoding and AlternateEncodingUsage instead.")]
	public Encoding ProvisionalAlternateEncoding
	{
		get
		{
			if (_alternateEncodingUsage == ZipOption.AsNecessary)
			{
				return _alternateEncoding;
			}
			return null;
		}
		set
		{
			_alternateEncoding = value;
			_alternateEncodingUsage = ZipOption.AsNecessary;
		}
	}

	public Encoding AlternateEncoding
	{
		get
		{
			return _alternateEncoding;
		}
		set
		{
			_alternateEncoding = value;
		}
	}

	public ZipOption AlternateEncodingUsage
	{
		get
		{
			return _alternateEncodingUsage;
		}
		set
		{
			_alternateEncodingUsage = value;
		}
	}

	public static Encoding DefaultEncoding => Encoding.GetEncoding("IBM437");

	public long ParallelDeflateThreshold
	{
		get
		{
			return _ParallelDeflateThreshold;
		}
		set
		{
			if (value != 0L && value != -1L && value < 65536L)
			{
				throw new ArgumentOutOfRangeException("value must be greater than 64k, or 0, or -1");
			}
			_ParallelDeflateThreshold = value;
		}
	}

	public int ParallelDeflateMaxBufferPairs
	{
		get
		{
			return _maxBufferPairs;
		}
		set
		{
			if (value < 4)
			{
				throw new ArgumentOutOfRangeException("ParallelDeflateMaxBufferPairs", "Value must be 4 or greater.");
			}
			_maxBufferPairs = value;
		}
	}

	internal Stream OutputStream => _outputStream;

	internal string Name => _name;

	public override bool CanRead => false;

	public override bool CanSeek => false;

	public override bool CanWrite => true;

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
			return _outputStream.Position;
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	public ZipOutputStream(Stream stream)
		: this(stream, leaveOpen: false)
	{
	}

	public ZipOutputStream(string fileName)
	{
		Stream stream = File.Open(fileName, FileMode.Create, FileAccess.ReadWrite, FileShare.None);
		_Init(stream, leaveOpen: false, fileName);
	}

	public ZipOutputStream(Stream stream, bool leaveOpen)
	{
		_Init(stream, leaveOpen, null);
	}

	private void _Init(Stream stream, bool leaveOpen, string name)
	{
		_outputStream = (stream.CanRead ? stream : new CountingStream(stream));
		CompressionLevel = CompressionLevel.Default;
		CompressionMethod = CompressionMethod.Deflate;
		_encryption = EncryptionAlgorithm.None;
		_entriesWritten = new Dictionary<string, ZipEntry>(StringComparer.Ordinal);
		_zip64 = Zip64Option.Default;
		_leaveUnderlyingStreamOpen = leaveOpen;
		Strategy = CompressionStrategy.Default;
		_name = name ?? "(stream)";
		ParallelDeflateThreshold = -1L;
	}

	public override string ToString()
	{
		return $"ZipOutputStream::{_name}(leaveOpen({_leaveUnderlyingStreamOpen})))";
	}

	private void InsureUniqueEntry(ZipEntry ze1)
	{
		if (_entriesWritten.ContainsKey(ze1.FileName))
		{
			_exceptionPending = true;
			throw new ArgumentException($"The entry '{ze1.FileName}' already exists in the zip archive.");
		}
	}

	public bool ContainsEntry(string name)
	{
		return _entriesWritten.ContainsKey(SharedUtilities.NormalizePathForUseInZipFile(name));
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		if (_disposed)
		{
			_exceptionPending = true;
			throw new InvalidOperationException("The stream has been closed.");
		}
		if (buffer == null)
		{
			_exceptionPending = true;
			throw new ArgumentNullException("buffer");
		}
		if (_currentEntry == null)
		{
			_exceptionPending = true;
			throw new InvalidOperationException("You must call PutNextEntry() before calling Write().");
		}
		if (_currentEntry.IsDirectory)
		{
			_exceptionPending = true;
			throw new InvalidOperationException("You cannot Write() data for an entry that is a directory.");
		}
		if (_needToWriteEntryHeader)
		{
			_InitiateCurrentEntry(finishing: false);
		}
		if (count != 0)
		{
			_entryOutputStream.Write(buffer, offset, count);
		}
	}

	public ZipEntry PutNextEntry(string entryName)
	{
		if (string.IsNullOrEmpty(entryName))
		{
			throw new ArgumentNullException("entryName");
		}
		if (_disposed)
		{
			_exceptionPending = true;
			throw new InvalidOperationException("The stream has been closed.");
		}
		_FinishCurrentEntry();
		_currentEntry = ZipEntry.CreateForZipOutputStream(entryName);
		_currentEntry._container = new ZipContainer(this);
		_currentEntry._BitField |= 8;
		_currentEntry.SetEntryTimes(DateTime.Now, DateTime.Now, DateTime.Now);
		_currentEntry.CompressionLevel = CompressionLevel;
		_currentEntry.CompressionMethod = CompressionMethod;
		_currentEntry.Password = _password;
		_currentEntry.Encryption = Encryption;
		_currentEntry.AlternateEncoding = AlternateEncoding;
		_currentEntry.AlternateEncodingUsage = AlternateEncodingUsage;
		if (entryName.EndsWith("/"))
		{
			_currentEntry.MarkAsDirectory();
		}
		_currentEntry.EmitTimesInWindowsFormatWhenSaving = (_timestamp & ZipEntryTimestamp.Windows) != 0;
		_currentEntry.EmitTimesInUnixFormatWhenSaving = (_timestamp & ZipEntryTimestamp.Unix) != 0;
		InsureUniqueEntry(_currentEntry);
		_needToWriteEntryHeader = true;
		return _currentEntry;
	}

	private void _InitiateCurrentEntry(bool finishing)
	{
		_entriesWritten.Add(_currentEntry.FileName, _currentEntry);
		_entryCount++;
		if (_entryCount > 65534 && _zip64 == Zip64Option.Default)
		{
			_exceptionPending = true;
			throw new InvalidOperationException("Too many entries. Consider setting ZipOutputStream.EnableZip64.");
		}
		_currentEntry.WriteHeader(_outputStream, finishing ? 99 : 0);
		_currentEntry.StoreRelativeOffset();
		if (!_currentEntry.IsDirectory)
		{
			_currentEntry.WriteSecurityMetadata(_outputStream);
			_currentEntry.PrepOutputStream(_outputStream, (!finishing) ? (-1) : 0, out _outputCounter, out _encryptor, out _deflater, out _entryOutputStream);
		}
		_needToWriteEntryHeader = false;
	}

	private void _FinishCurrentEntry()
	{
		if (_currentEntry != null)
		{
			if (_needToWriteEntryHeader)
			{
				_InitiateCurrentEntry(finishing: true);
			}
			_currentEntry.FinishOutputStream(_outputStream, _outputCounter, _encryptor, _deflater, _entryOutputStream);
			_currentEntry.PostProcessOutput(_outputStream);
			if (_currentEntry.OutputUsedZip64.HasValue)
			{
				_anyEntriesUsedZip64 |= _currentEntry.OutputUsedZip64.Value;
			}
			_outputCounter = null;
			_encryptor = (_deflater = null);
			_entryOutputStream = null;
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (_disposed)
		{
			return;
		}
		if (disposing && !_exceptionPending)
		{
			_FinishCurrentEntry();
			_directoryNeededZip64 = ZipOutput.WriteCentralDirectoryStructure(_outputStream, _entriesWritten.Values, 1u, _zip64, Comment, new ZipContainer(this));
			Stream stream = null;
			if (_outputStream is CountingStream countingStream)
			{
				stream = countingStream.WrappedStream;
				countingStream.Dispose();
			}
			else
			{
				stream = _outputStream;
			}
			if (!_leaveUnderlyingStreamOpen)
			{
				stream.Dispose();
			}
			_outputStream = null;
		}
		_disposed = true;
	}

	public override void Flush()
	{
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		throw new NotSupportedException("Read");
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException("Seek");
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException();
	}
}
