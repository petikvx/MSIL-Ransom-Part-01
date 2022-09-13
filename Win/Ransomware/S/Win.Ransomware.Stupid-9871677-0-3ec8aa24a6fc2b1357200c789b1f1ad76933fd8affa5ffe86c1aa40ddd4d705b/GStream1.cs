using System;
using System.IO;
using System.Text;
using Ionic.Zlib;

public class GStream1 : Stream
{
	public DateTime? nullable_0;

	private int int_0;

	internal Stream0 stream0_0;

	private bool bool_0;

	private bool bool_1;

	private string string_0;

	private string string_1;

	private int int_1;

	internal static readonly DateTime dateTime_0 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

	internal static readonly Encoding encoding_0 = Encoding.GetEncoding("iso-8859-1");

	public string String_0
	{
		get
		{
			return string_1;
		}
		set
		{
			if (bool_0)
			{
				throw new ObjectDisposedException("GZipStream");
			}
			string_1 = value;
		}
	}

	public string String_1
	{
		get
		{
			return string_0;
		}
		set
		{
			if (bool_0)
			{
				throw new ObjectDisposedException("GZipStream");
			}
			string_0 = value;
			if (string_0 != null)
			{
				if (string_0.IndexOf("/") != -1)
				{
					string_0 = string_0.Replace("/", "\\");
				}
				if (string_0.EndsWith("\\"))
				{
					throw new Exception("Illegal filename");
				}
				if (string_0.IndexOf("\\") != -1)
				{
					string_0 = Path.GetFileName(string_0);
				}
			}
		}
	}

	public int Int32_0 => int_1;

	public virtual FlushType FlushMode
	{
		get
		{
			return stream0_0.flushType_0;
		}
		set
		{
			if (bool_0)
			{
				throw new ObjectDisposedException("GZipStream");
			}
			stream0_0.flushType_0 = value;
		}
	}

	public int Int32_1
	{
		get
		{
			return stream0_0.int_0;
		}
		set
		{
			if (bool_0)
			{
				throw new ObjectDisposedException("GZipStream");
			}
			if (stream0_0.byte_0 != null)
			{
				throw new GException0("The working buffer is already set.");
			}
			if (value < 1024)
			{
				throw new GException0($"Don't be silly. {value} bytes?? Use a bigger buffer, at least {1024}.");
			}
			stream0_0.int_0 = value;
		}
	}

	public virtual long TotalIn => stream0_0.gclass5_0.long_0;

	public virtual long TotalOut => stream0_0.gclass5_0.long_1;

	public override bool CanRead
	{
		get
		{
			if (bool_0)
			{
				throw new ObjectDisposedException("GZipStream");
			}
			return stream0_0.stream_0.CanRead;
		}
	}

	public override bool CanSeek => false;

	public override bool CanWrite
	{
		get
		{
			if (bool_0)
			{
				throw new ObjectDisposedException("GZipStream");
			}
			return stream0_0.stream_0.CanWrite;
		}
	}

	public override long Length
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public override long Position
	{
		get
		{
			if (stream0_0.enum4_0 == Stream0.Enum4.const_0)
			{
				return stream0_0.gclass5_0.long_1 + int_0;
			}
			if (stream0_0.enum4_0 == Stream0.Enum4.const_1)
			{
				return stream0_0.gclass5_0.long_0 + stream0_0.int_1;
			}
			return 0L;
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public GStream1(Stream stream, CompressionMode mode)
		: this(stream, mode, CompressionLevel.Default, leaveOpen: false)
	{
	}

	public GStream1(Stream stream, CompressionMode mode, CompressionLevel level)
		: this(stream, mode, level, leaveOpen: false)
	{
	}

	public GStream1(Stream stream, CompressionMode mode, bool leaveOpen)
		: this(stream, mode, CompressionLevel.Default, leaveOpen)
	{
	}

	public GStream1(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen)
	{
		stream0_0 = new Stream0(stream, mode, level, ZlibStreamFlavor.GZIP, leaveOpen);
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (!bool_0)
			{
				if (disposing && stream0_0 != null)
				{
					stream0_0.Close();
					int_1 = stream0_0.Int32_0;
				}
				bool_0 = true;
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	public override void Flush()
	{
		if (bool_0)
		{
			throw new ObjectDisposedException("GZipStream");
		}
		stream0_0.Flush();
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (bool_0)
		{
			throw new ObjectDisposedException("GZipStream");
		}
		int result = stream0_0.Read(buffer, offset, count);
		if (!bool_1)
		{
			bool_1 = true;
			String_1 = stream0_0.string_0;
			String_0 = stream0_0.string_1;
		}
		return result;
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotImplementedException();
	}

	public override void SetLength(long value)
	{
		throw new NotImplementedException();
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		if (bool_0)
		{
			throw new ObjectDisposedException("GZipStream");
		}
		if (stream0_0.enum4_0 == Stream0.Enum4.const_2)
		{
			if (!stream0_0.Boolean_0)
			{
				throw new InvalidOperationException();
			}
			int_0 = method_0();
		}
		stream0_0.Write(buffer, offset, count);
	}

	private int method_0()
	{
		byte[] array = ((String_0 == null) ? null : encoding_0.GetBytes(String_0));
		byte[] array2 = ((String_1 == null) ? null : encoding_0.GetBytes(String_1));
		int num = ((String_0 != null) ? (array.Length + 1) : 0);
		int num2 = ((String_1 != null) ? (array2.Length + 1) : 0);
		byte[] array3 = new byte[10 + num + num2];
		int num3 = 0;
		num3 = 1;
		array3[0] = 31;
		num3 = 2;
		array3[1] = 139;
		num3 = 3;
		array3[2] = 8;
		byte b = 0;
		if (String_0 != null)
		{
			b = (byte)(b ^ 0x10u);
		}
		if (String_1 != null)
		{
			b = (byte)(b ^ 8u);
		}
		array3[num3++] = b;
		if (!nullable_0.HasValue)
		{
			nullable_0 = DateTime.Now;
		}
		Array.Copy(BitConverter.GetBytes((int)(nullable_0.Value - dateTime_0).TotalSeconds), 0, array3, num3, 4);
		num3 += 4;
		array3[num3++] = 0;
		array3[num3++] = byte.MaxValue;
		if (num2 != 0)
		{
			Array.Copy(array2, 0, array3, num3, num2 - 1);
			num3 += num2 - 1;
			array3[num3++] = 0;
		}
		if (num != 0)
		{
			Array.Copy(array, 0, array3, num3, num - 1);
			num3 += num - 1;
			array3[num3++] = 0;
		}
		stream0_0.stream_0.Write(array3, 0, array3.Length);
		return array3.Length;
	}

	public static byte[] smethod_0(string string_2)
	{
		using MemoryStream memoryStream = new MemoryStream();
		Stream stream_ = new GStream1(memoryStream, CompressionMode.Compress, CompressionLevel.BestCompression);
		Stream0.smethod_0(string_2, stream_);
		return memoryStream.ToArray();
	}

	public static byte[] smethod_1(byte[] byte_0)
	{
		using MemoryStream memoryStream = new MemoryStream();
		Stream stream_ = new GStream1(memoryStream, CompressionMode.Compress, CompressionLevel.BestCompression);
		Stream0.smethod_1(byte_0, stream_);
		return memoryStream.ToArray();
	}

	public static string smethod_2(byte[] byte_0)
	{
		using MemoryStream stream = new MemoryStream(byte_0);
		Stream stream_ = new GStream1(stream, CompressionMode.Decompress);
		return Stream0.smethod_2(byte_0, stream_);
	}

	public static byte[] smethod_3(byte[] byte_0)
	{
		using MemoryStream stream = new MemoryStream(byte_0);
		Stream stream_ = new GStream1(stream, CompressionMode.Decompress);
		return Stream0.smethod_3(byte_0, stream_);
	}
}
