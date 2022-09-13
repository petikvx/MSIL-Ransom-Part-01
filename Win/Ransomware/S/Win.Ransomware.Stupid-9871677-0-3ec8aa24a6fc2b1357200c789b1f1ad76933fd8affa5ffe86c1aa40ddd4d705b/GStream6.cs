using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Ionic.Zip;
using Ionic.Zlib;

public class GStream6 : Stream
{
	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private CompressionStrategy compressionStrategy_0;

	[CompilerGenerated]
	private CompressionLevel compressionLevel_0;

	[CompilerGenerated]
	private CompressionMethod compressionMethod_0;

	private EncryptionAlgorithm encryptionAlgorithm_0;

	private ZipEntryTimestamp zipEntryTimestamp_0;

	internal string string_0;

	private string string_1;

	private Stream stream_0;

	private GClass8 gclass8_0;

	internal Zip64Option zip64Option_0;

	private Dictionary<string, GClass8> dictionary_0;

	private int int_1;

	private ZipOption zipOption_0;

	private Encoding encoding_0 = Encoding.GetEncoding("IBM437");

	private bool bool_0;

	private bool bool_1;

	private bool bool_2;

	private bool bool_3;

	private bool bool_4;

	private GStream4 gstream4_0;

	private Stream stream_1;

	private Stream stream_2;

	private GStream7 gstream7_0;

	private bool bool_5;

	private string string_2;

	private bool bool_6;

	internal GStream2 gstream2_0;

	private long long_0;

	private int int_2 = 16;

	public string Password
	{
		set
		{
			if (bool_1)
			{
				bool_2 = true;
				throw new InvalidOperationException("The stream has been closed.");
			}
			string_0 = value;
			if (string_0 == null)
			{
				encryptionAlgorithm_0 = EncryptionAlgorithm.None;
			}
			else if (encryptionAlgorithm_0 == EncryptionAlgorithm.None)
			{
				encryptionAlgorithm_0 = EncryptionAlgorithm.PkzipWeak;
			}
		}
	}

	public EncryptionAlgorithm EncryptionAlgorithm_0
	{
		get
		{
			return encryptionAlgorithm_0;
		}
		set
		{
			if (bool_1)
			{
				bool_2 = true;
				throw new InvalidOperationException("The stream has been closed.");
			}
			if (value == EncryptionAlgorithm.Unsupported)
			{
				bool_2 = true;
				throw new InvalidOperationException("You may not set Encryption to that value.");
			}
			encryptionAlgorithm_0 = value;
		}
	}

	public int Int32_0
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		set
		{
			int_0 = value;
		}
	}

	public CompressionStrategy CompressionStrategy_0
	{
		[CompilerGenerated]
		get
		{
			return compressionStrategy_0;
		}
		[CompilerGenerated]
		set
		{
			compressionStrategy_0 = value;
		}
	}

	public ZipEntryTimestamp ZipEntryTimestamp_0
	{
		get
		{
			return zipEntryTimestamp_0;
		}
		set
		{
			if (bool_1)
			{
				bool_2 = true;
				throw new InvalidOperationException("The stream has been closed.");
			}
			zipEntryTimestamp_0 = value;
		}
	}

	public CompressionLevel CompressionLevel_0
	{
		[CompilerGenerated]
		get
		{
			return compressionLevel_0;
		}
		[CompilerGenerated]
		set
		{
			compressionLevel_0 = value;
		}
	}

	public CompressionMethod CompressionMethod_0
	{
		[CompilerGenerated]
		get
		{
			return compressionMethod_0;
		}
		[CompilerGenerated]
		set
		{
			compressionMethod_0 = value;
		}
	}

	public string String_0
	{
		get
		{
			return string_1;
		}
		set
		{
			if (bool_1)
			{
				bool_2 = true;
				throw new InvalidOperationException("The stream has been closed.");
			}
			string_1 = value;
		}
	}

	public Zip64Option Zip64Option_0
	{
		get
		{
			return zip64Option_0;
		}
		set
		{
			if (bool_1)
			{
				bool_2 = true;
				throw new InvalidOperationException("The stream has been closed.");
			}
			zip64Option_0 = value;
		}
	}

	public bool Boolean_0
	{
		get
		{
			if (!bool_3)
			{
				return bool_4;
			}
			return true;
		}
	}

	public bool Boolean_1
	{
		get
		{
			return !bool_6;
		}
		set
		{
			bool_6 = !value;
		}
	}

	[Obsolete("Beginning with v1.9.1.6 of DotNetZip, this property is obsolete. It will be removed in a future version of the library. Use AlternateEncoding and AlternateEncodingUsage instead.")]
	public bool Boolean_2
	{
		get
		{
			if (encoding_0 == Encoding.UTF8)
			{
				return ZipOption_0 == ZipOption.AsNecessary;
			}
			return false;
		}
		set
		{
			if (value)
			{
				encoding_0 = Encoding.UTF8;
				zipOption_0 = ZipOption.AsNecessary;
			}
			else
			{
				encoding_0 = Encoding_2;
				zipOption_0 = ZipOption.Default;
			}
		}
	}

	[Obsolete("use AlternateEncoding and AlternateEncodingUsage instead.")]
	public Encoding Encoding_0
	{
		get
		{
			if (zipOption_0 == ZipOption.AsNecessary)
			{
				return encoding_0;
			}
			return null;
		}
		set
		{
			encoding_0 = value;
			zipOption_0 = ZipOption.AsNecessary;
		}
	}

	public Encoding Encoding_1
	{
		get
		{
			return encoding_0;
		}
		set
		{
			encoding_0 = value;
		}
	}

	public ZipOption ZipOption_0
	{
		get
		{
			return zipOption_0;
		}
		set
		{
			zipOption_0 = value;
		}
	}

	public static Encoding Encoding_2 => Encoding.GetEncoding("IBM437");

	public long Int64_0
	{
		get
		{
			return long_0;
		}
		set
		{
			if (value != 0L && value != -1L && value < 65536L)
			{
				throw new ArgumentOutOfRangeException("value must be greater than 64k, or 0, or -1");
			}
			long_0 = value;
		}
	}

	public int Int32_1
	{
		get
		{
			return int_2;
		}
		set
		{
			if (value < 4)
			{
				throw new ArgumentOutOfRangeException("ParallelDeflateMaxBufferPairs", "Value must be 4 or greater.");
			}
			int_2 = value;
		}
	}

	internal Stream Stream_0 => stream_0;

	internal string String_1 => string_2;

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
			return stream_0.Position;
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	public GStream6(Stream stream)
		: this(stream, leaveOpen: false)
	{
	}

	public GStream6(string fileName)
	{
		Stream stream_ = File.Open(fileName, FileMode.Create, FileAccess.ReadWrite, FileShare.None);
		method_0(stream_, bool_7: false, fileName);
	}

	public GStream6(Stream stream, bool leaveOpen)
	{
		method_0(stream, leaveOpen, null);
	}

	private void method_0(Stream stream_3, bool bool_7, string string_3)
	{
		stream_0 = (stream_3.CanRead ? stream_3 : new GStream4(stream_3));
		CompressionLevel_0 = CompressionLevel.Default;
		CompressionMethod_0 = CompressionMethod.Deflate;
		encryptionAlgorithm_0 = EncryptionAlgorithm.None;
		dictionary_0 = new Dictionary<string, GClass8>(StringComparer.Ordinal);
		zip64Option_0 = Zip64Option.Default;
		bool_0 = bool_7;
		CompressionStrategy_0 = CompressionStrategy.Default;
		string_2 = string_3 ?? "(stream)";
		Int64_0 = -1L;
	}

	public override string ToString()
	{
		return $"ZipOutputStream::{string_2}(leaveOpen({bool_0})))";
	}

	private void method_1(GClass8 gclass8_1)
	{
		if (dictionary_0.ContainsKey(gclass8_1.String_2))
		{
			bool_2 = true;
			throw new ArgumentException($"The entry '{gclass8_1.String_2}' already exists in the zip archive.");
		}
	}

	public bool method_2(string string_3)
	{
		return dictionary_0.ContainsKey(Class21.smethod_3(string_3));
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		if (bool_1)
		{
			bool_2 = true;
			throw new InvalidOperationException("The stream has been closed.");
		}
		if (buffer == null)
		{
			bool_2 = true;
			throw new ArgumentNullException("buffer");
		}
		if (gclass8_0 == null)
		{
			bool_2 = true;
			throw new InvalidOperationException("You must call PutNextEntry() before calling Write().");
		}
		if (gclass8_0.Boolean_4)
		{
			bool_2 = true;
			throw new InvalidOperationException("You cannot Write() data for an entry that is a directory.");
		}
		if (bool_5)
		{
			method_4(bool_7: false);
		}
		if (count != 0)
		{
			gstream7_0.Write(buffer, offset, count);
		}
	}

	public GClass8 method_3(string string_3)
	{
		if (string.IsNullOrEmpty(string_3))
		{
			throw new ArgumentNullException("entryName");
		}
		if (bool_1)
		{
			bool_2 = true;
			throw new InvalidOperationException("The stream has been closed.");
		}
		method_5();
		gclass8_0 = GClass8.smethod_8(string_3);
		gclass8_0.class27_0 = new Class27(this);
		gclass8_0.short_6 |= 8;
		gclass8_0.method_1(DateTime.Now, DateTime.Now, DateTime.Now);
		gclass8_0.CompressionLevel_0 = CompressionLevel_0;
		gclass8_0.CompressionMethod_0 = CompressionMethod_0;
		gclass8_0.String_4 = string_0;
		gclass8_0.EncryptionAlgorithm_0 = EncryptionAlgorithm_0;
		gclass8_0.Encoding_1 = Encoding_1;
		gclass8_0.ZipOption_0 = ZipOption_0;
		if (string_3.EndsWith("/"))
		{
			gclass8_0.method_2();
		}
		gclass8_0.Boolean_1 = (zipEntryTimestamp_0 & ZipEntryTimestamp.Windows) != 0;
		gclass8_0.Boolean_2 = (zipEntryTimestamp_0 & ZipEntryTimestamp.Unix) != 0;
		method_1(gclass8_0);
		bool_5 = true;
		return gclass8_0;
	}

	private void method_4(bool bool_7)
	{
		dictionary_0.Add(gclass8_0.String_2, gclass8_0);
		int_1++;
		if (int_1 > 65534 && zip64Option_0 == Zip64Option.Default)
		{
			bool_2 = true;
			throw new InvalidOperationException("Too many entries. Consider setting ZipOutputStream.EnableZip64.");
		}
		gclass8_0.method_47(stream_0, bool_7 ? 99 : 0);
		gclass8_0.method_62();
		if (!gclass8_0.Boolean_4)
		{
			gclass8_0.method_64(stream_0);
			gclass8_0.method_57(stream_0, (!bool_7) ? (-1) : 0, out gstream4_0, out stream_1, out stream_2, out gstream7_0);
		}
		bool_5 = false;
	}

	private void method_5()
	{
		if (gclass8_0 != null)
		{
			if (bool_5)
			{
				method_4(bool_7: true);
			}
			gclass8_0.method_54(stream_0, gstream4_0, stream_1, stream_2, gstream7_0);
			gclass8_0.method_55(stream_0);
			if (gclass8_0.Nullable_1.HasValue)
			{
				bool_3 |= gclass8_0.Nullable_1.Value;
			}
			gstream4_0 = null;
			stream_1 = (stream_2 = null);
			gstream7_0 = null;
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (bool_1)
		{
			return;
		}
		if (disposing && !bool_2)
		{
			method_5();
			bool_4 = Class26.smethod_0(stream_0, dictionary_0.Values, 1u, zip64Option_0, String_0, new Class27(this));
			Stream stream = null;
			if (stream_0 is GStream4 gStream)
			{
				stream = gStream.Stream_0;
				gStream.Dispose();
			}
			else
			{
				stream = stream_0;
			}
			if (!bool_0)
			{
				stream.Dispose();
			}
			stream_0 = null;
		}
		bool_1 = true;
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
