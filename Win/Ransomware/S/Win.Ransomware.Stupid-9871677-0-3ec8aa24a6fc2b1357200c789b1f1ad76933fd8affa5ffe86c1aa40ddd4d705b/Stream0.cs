using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Ionic.Zlib;

internal class Stream0 : Stream
{
	internal enum Enum4
	{
		const_0,
		const_1,
		const_2
	}

	protected internal GClass5 gclass5_0;

	protected internal Enum4 enum4_0 = Enum4.const_2;

	protected internal FlushType flushType_0;

	protected internal ZlibStreamFlavor zlibStreamFlavor_0;

	protected internal CompressionMode compressionMode_0;

	protected internal CompressionLevel compressionLevel_0;

	protected internal bool bool_0;

	protected internal byte[] byte_0;

	protected internal int int_0 = 16384;

	protected internal byte[] byte_1 = new byte[1];

	protected internal Stream stream_0;

	protected internal CompressionStrategy compressionStrategy_0;

	private GClass12 gclass12_0;

	protected internal string string_0;

	protected internal string string_1;

	protected internal DateTime dateTime_0;

	protected internal int int_1;

	private bool bool_1;

	internal int Int32_0
	{
		get
		{
			if (gclass12_0 == null)
			{
				return 0;
			}
			return gclass12_0.Int32_0;
		}
	}

	protected internal bool Boolean_0 => compressionMode_0 == CompressionMode.Compress;

	private GClass5 GClass5_0
	{
		get
		{
			if (gclass5_0 == null)
			{
				bool flag = zlibStreamFlavor_0 == ZlibStreamFlavor.ZLIB;
				gclass5_0 = new GClass5();
				if (compressionMode_0 == CompressionMode.Decompress)
				{
					gclass5_0.method_1(flag);
				}
				else
				{
					gclass5_0.compressionStrategy_0 = compressionStrategy_0;
					gclass5_0.method_9(compressionLevel_0, flag);
				}
			}
			return gclass5_0;
		}
	}

	private byte[] Byte_0
	{
		get
		{
			if (byte_0 == null)
			{
				byte_0 = new byte[int_0];
			}
			return byte_0;
		}
	}

	public override bool CanRead => stream_0.CanRead;

	public override bool CanSeek => stream_0.CanSeek;

	public override bool CanWrite => stream_0.CanWrite;

	public override long Length => stream_0.Length;

	public override long Position
	{
		get
		{
			throw new NotImplementedException();
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public Stream0(Stream stream, CompressionMode compressionMode, CompressionLevel level, ZlibStreamFlavor flavor, bool leaveOpen)
	{
		flushType_0 = FlushType.None;
		stream_0 = stream;
		bool_0 = leaveOpen;
		compressionMode_0 = compressionMode;
		zlibStreamFlavor_0 = flavor;
		compressionLevel_0 = level;
		if (flavor == ZlibStreamFlavor.GZIP)
		{
			gclass12_0 = new GClass12();
		}
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		if (gclass12_0 != null)
		{
			gclass12_0.method_4(buffer, offset, count);
		}
		if (enum4_0 == Enum4.const_2)
		{
			enum4_0 = Enum4.const_0;
		}
		else if (enum4_0 != 0)
		{
			throw new GException0("Cannot Write after Reading.");
		}
		if (count == 0)
		{
			return;
		}
		GClass5_0.byte_0 = buffer;
		gclass5_0.int_0 = offset;
		gclass5_0.int_1 = count;
		bool flag = false;
		while (true)
		{
			gclass5_0.byte_1 = Byte_0;
			gclass5_0.int_2 = 0;
			gclass5_0.int_3 = byte_0.Length;
			int num = ((!Boolean_0) ? gclass5_0.method_4(flushType_0) : gclass5_0.method_13(flushType_0));
			if (num != 0 && num != 1)
			{
				break;
			}
			stream_0.Write(byte_0, 0, byte_0.Length - gclass5_0.int_3);
			flag = gclass5_0.int_1 == 0 && gclass5_0.int_3 != 0;
			if (zlibStreamFlavor_0 == ZlibStreamFlavor.GZIP && !Boolean_0)
			{
				flag = gclass5_0.int_1 == 8 && gclass5_0.int_3 != 0;
			}
			if (flag)
			{
				return;
			}
		}
		throw new GException0((Boolean_0 ? "de" : "in") + "flating: " + gclass5_0.string_0);
	}

	private void method_0()
	{
		if (gclass5_0 == null)
		{
			return;
		}
		if (enum4_0 == Enum4.const_0)
		{
			bool flag = false;
			do
			{
				gclass5_0.byte_1 = Byte_0;
				gclass5_0.int_2 = 0;
				gclass5_0.int_3 = byte_0.Length;
				int num = ((!Boolean_0) ? gclass5_0.method_4(FlushType.Finish) : gclass5_0.method_13(FlushType.Finish));
				if (num == 1 || num == 0)
				{
					if (byte_0.Length - gclass5_0.int_3 > 0)
					{
						stream_0.Write(byte_0, 0, byte_0.Length - gclass5_0.int_3);
					}
					flag = gclass5_0.int_1 == 0 && gclass5_0.int_3 != 0;
					if (zlibStreamFlavor_0 == ZlibStreamFlavor.GZIP && !Boolean_0)
					{
						flag = gclass5_0.int_1 == 8 && gclass5_0.int_3 != 0;
					}
					continue;
				}
				string text = (Boolean_0 ? "de" : "in") + "flating";
				if (gclass5_0.string_0 == null)
				{
					throw new GException0($"{text}: (rc = {num})");
				}
				throw new GException0(text + ": " + gclass5_0.string_0);
			}
			while (!flag);
			Flush();
			if (zlibStreamFlavor_0 == ZlibStreamFlavor.GZIP)
			{
				if (!Boolean_0)
				{
					throw new GException0("Writing with decompression is not supported.");
				}
				int int32_ = gclass12_0.Int32_0;
				stream_0.Write(BitConverter.GetBytes(int32_), 0, 4);
				int value = (int)(gclass12_0.Int64_0 & 0xFFFFFFFFL);
				stream_0.Write(BitConverter.GetBytes(value), 0, 4);
			}
		}
		else
		{
			if (enum4_0 != Enum4.const_1 || zlibStreamFlavor_0 != ZlibStreamFlavor.GZIP)
			{
				return;
			}
			if (Boolean_0)
			{
				throw new GException0("Reading with compression is not supported.");
			}
			if (gclass5_0.long_1 == 0L)
			{
				return;
			}
			byte[] array = new byte[8];
			if (gclass5_0.int_1 < 8)
			{
				Array.Copy(gclass5_0.byte_0, gclass5_0.int_0, array, 0, gclass5_0.int_1);
				int num2 = 8 - gclass5_0.int_1;
				int num3 = stream_0.Read(array, gclass5_0.int_1, num2);
				if (num2 != num3)
				{
					throw new GException0($"Missing or incomplete GZIP trailer. Expected 8 bytes, got {gclass5_0.int_1 + num3}.");
				}
			}
			else
			{
				Array.Copy(gclass5_0.byte_0, gclass5_0.int_0, array, 0, array.Length);
			}
			int num4 = BitConverter.ToInt32(array, 0);
			int int32_2 = gclass12_0.Int32_0;
			int num5 = BitConverter.ToInt32(array, 4);
			int num6 = (int)(gclass5_0.long_1 & 0xFFFFFFFFL);
			if (int32_2 != num4)
			{
				throw new GException0($"Bad CRC32 in GZIP trailer. (actual({int32_2:X8})!=expected({num4:X8}))");
			}
			if (num6 != num5)
			{
				throw new GException0($"Bad size in GZIP trailer. (actual({num6})!=expected({num5}))");
			}
		}
	}

	private void method_1()
	{
		if (GClass5_0 != null)
		{
			if (Boolean_0)
			{
				gclass5_0.method_14();
			}
			else
			{
				gclass5_0.method_5();
			}
			gclass5_0 = null;
		}
	}

	public override void Close()
	{
		if (stream_0 == null)
		{
			return;
		}
		try
		{
			method_0();
		}
		finally
		{
			method_1();
			if (!bool_0)
			{
				stream_0.Close();
			}
			stream_0 = null;
		}
	}

	public override void Flush()
	{
		stream_0.Flush();
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotImplementedException();
	}

	public override void SetLength(long value)
	{
		stream_0.SetLength(value);
	}

	private string method_2()
	{
		List<byte> list = new List<byte>();
		bool flag = false;
		do
		{
			if (stream_0.Read(byte_1, 0, 1) == 1)
			{
				if (byte_1[0] == 0)
				{
					flag = true;
				}
				else
				{
					list.Add(byte_1[0]);
				}
				continue;
			}
			throw new GException0("Unexpected EOF reading GZIP header.");
		}
		while (!flag);
		byte[] array = list.ToArray();
		return GStream1.encoding_0.GetString(array, 0, array.Length);
	}

	private int method_3()
	{
		int num = 0;
		byte[] array = new byte[10];
		int num2 = stream_0.Read(array, 0, array.Length);
		switch (num2)
		{
		case 0:
			return 0;
		default:
			throw new GException0("Not a valid GZIP stream.");
		case 10:
			if (array[0] == 31 && array[1] == 139 && array[2] == 8)
			{
				int num3 = BitConverter.ToInt32(array, 4);
				DateTime dateTime = GStream1.dateTime_0;
				dateTime_0 = dateTime.AddSeconds(num3);
				num += num2;
				if ((array[3] & 4) == 4)
				{
					num2 = stream_0.Read(array, 0, 2);
					num += num2;
					short num4 = (short)(array[0] + array[1] * 256);
					byte[] array2 = new byte[num4];
					num2 = stream_0.Read(array2, 0, array2.Length);
					if (num2 != num4)
					{
						throw new GException0("Unexpected end-of-file reading GZIP header.");
					}
					num += num2;
				}
				if ((array[3] & 8) == 8)
				{
					string_0 = method_2();
				}
				if ((array[3] & 0x10) == 16)
				{
					string_1 = method_2();
				}
				if ((array[3] & 2) == 2)
				{
					Read(byte_1, 0, 1);
				}
				return num;
			}
			throw new GException0("Bad GZIP header.");
		}
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (enum4_0 == Enum4.const_2)
		{
			if (!stream_0.CanRead)
			{
				throw new GException0("The stream is not readable.");
			}
			enum4_0 = Enum4.const_1;
			GClass5_0.int_1 = 0;
			if (zlibStreamFlavor_0 == ZlibStreamFlavor.GZIP)
			{
				int_1 = method_3();
				if (int_1 == 0)
				{
					return 0;
				}
			}
		}
		if (enum4_0 != Enum4.const_1)
		{
			throw new GException0("Cannot Read after Writing.");
		}
		if (count == 0)
		{
			return 0;
		}
		if (bool_1 && Boolean_0)
		{
			return 0;
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (offset < buffer.GetLowerBound(0))
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (offset + count > buffer.GetLength(0))
		{
			throw new ArgumentOutOfRangeException("count");
		}
		int num = 0;
		gclass5_0.byte_1 = buffer;
		gclass5_0.int_2 = offset;
		gclass5_0.int_3 = count;
		gclass5_0.byte_0 = Byte_0;
		do
		{
			if (gclass5_0.int_1 == 0 && !bool_1)
			{
				gclass5_0.int_0 = 0;
				gclass5_0.int_1 = stream_0.Read(byte_0, 0, byte_0.Length);
				if (gclass5_0.int_1 == 0)
				{
					bool_1 = true;
				}
			}
			num = (Boolean_0 ? gclass5_0.method_13(flushType_0) : gclass5_0.method_4(flushType_0));
			if (!bool_1 || num != -5)
			{
				if (num != 0 && num != 1)
				{
					throw new GException0(string.Format("{0}flating:  rc={1}  msg={2}", Boolean_0 ? "de" : "in", num, gclass5_0.string_0));
				}
				continue;
			}
			return 0;
		}
		while (((!bool_1 && num != 1) || gclass5_0.int_3 != count) && gclass5_0.int_3 > 0 && !bool_1 && num == 0);
		if (gclass5_0.int_3 > 0)
		{
			if (num != 0)
			{
			}
			if (bool_1 && Boolean_0)
			{
				num = gclass5_0.method_13(FlushType.Finish);
				if (num != 0 && num != 1)
				{
					throw new GException0($"Deflating:  rc={num}  msg={gclass5_0.string_0}");
				}
			}
		}
		num = count - gclass5_0.int_3;
		if (gclass12_0 != null)
		{
			gclass12_0.method_4(buffer, offset, num);
		}
		return num;
	}

	public static void smethod_0(string string_2, Stream stream_1)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_2);
		using (stream_1)
		{
			stream_1.Write(bytes, 0, bytes.Length);
		}
	}

	public static void smethod_1(byte[] byte_2, Stream stream_1)
	{
		using (stream_1)
		{
			stream_1.Write(byte_2, 0, byte_2.Length);
		}
	}

	public static string smethod_2(byte[] byte_2, Stream stream_1)
	{
		byte[] array = new byte[1024];
		Encoding uTF = Encoding.UTF8;
		using MemoryStream memoryStream = new MemoryStream();
		using (stream_1)
		{
			int count;
			while ((count = stream_1.Read(array, 0, array.Length)) != 0)
			{
				memoryStream.Write(array, 0, count);
			}
		}
		memoryStream.Seek(0L, SeekOrigin.Begin);
		return new StreamReader(memoryStream, uTF).ReadToEnd();
	}

	public static byte[] smethod_3(byte[] byte_2, Stream stream_1)
	{
		byte[] array = new byte[1024];
		using MemoryStream memoryStream = new MemoryStream();
		using (stream_1)
		{
			int count;
			while ((count = stream_1.Read(array, 0, array.Length)) != 0)
			{
				memoryStream.Write(array, 0, count);
			}
		}
		return memoryStream.ToArray();
	}
}
