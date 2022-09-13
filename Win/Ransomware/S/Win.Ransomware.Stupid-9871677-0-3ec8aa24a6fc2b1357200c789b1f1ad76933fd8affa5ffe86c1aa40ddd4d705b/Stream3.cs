using System;
using System.IO;
using System.Runtime.CompilerServices;
using Ionic.Zip;

internal class Stream3 : Stream
{
	private enum Enum5
	{
		const_0,
		const_1,
		const_2
	}

	private Enum5 enum5_0;

	private bool bool_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private string string_3;

	private uint uint_0;

	private uint uint_1;

	private int int_0;

	private Stream stream_0;

	[CompilerGenerated]
	private bool bool_1;

	public bool Boolean_0
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
		[CompilerGenerated]
		set
		{
			bool_1 = value;
		}
	}

	public uint UInt32_0
	{
		get
		{
			return uint_0;
		}
		private set
		{
			uint_0 = value;
			string_2 = null;
		}
	}

	public string String_0
	{
		get
		{
			if (string_2 == null)
			{
				string_2 = method_0(UInt32_0);
			}
			return string_2;
		}
	}

	public string String_1 => string_3;

	public override bool CanRead
	{
		get
		{
			if (enum5_0 == Enum5.const_1 && stream_0 != null)
			{
				return stream_0.CanRead;
			}
			return false;
		}
	}

	public override bool CanSeek
	{
		get
		{
			if (stream_0 != null)
			{
				return stream_0.CanSeek;
			}
			return false;
		}
	}

	public override bool CanWrite
	{
		get
		{
			if (enum5_0 == Enum5.const_2 && stream_0 != null)
			{
				return stream_0.CanWrite;
			}
			return false;
		}
	}

	public override long Length => stream_0.Length;

	public override long Position
	{
		get
		{
			return stream_0.Position;
		}
		set
		{
			stream_0.Position = value;
		}
	}

	private Stream3()
	{
		bool_0 = false;
	}

	public static Stream3 smethod_0(string string_4, uint uint_2, uint uint_3)
	{
		Stream3 stream = new Stream3();
		stream.enum5_0 = Enum5.const_1;
		stream.UInt32_0 = uint_2;
		stream.uint_1 = uint_3;
		stream.string_0 = string_4;
		stream.method_2();
		return stream;
	}

	public static Stream3 smethod_1(string string_4, int int_1)
	{
		Stream3 stream = new Stream3
		{
			enum5_0 = Enum5.const_2,
			UInt32_0 = 0u,
			string_0 = string_4,
			int_0 = int_1,
			string_1 = Path.GetDirectoryName(string_4)
		};
		if (stream.string_1 == "")
		{
			stream.string_1 = ".";
		}
		stream.method_3(0u);
		return stream;
	}

	public static Stream smethod_2(string string_4, uint uint_2)
	{
		if (uint_2 >= 99)
		{
			throw new ArgumentOutOfRangeException("diskNumber");
		}
		return File.Open($"{Path.Combine(Path.GetDirectoryName(string_4), Path.GetFileNameWithoutExtension(string_4))}.z{uint_2 + 1:D2}", FileMode.Open, FileAccess.ReadWrite, FileShare.None);
	}

	private string method_0(uint uint_2)
	{
		if (uint_2 >= 99)
		{
			bool_0 = true;
			throw new OverflowException("The number of zip segments would exceed 99.");
		}
		return $"{Path.Combine(Path.GetDirectoryName(string_0), Path.GetFileNameWithoutExtension(string_0))}.z{uint_2 + 1:D2}";
	}

	public uint method_1(int int_1)
	{
		if (stream_0.Position + int_1 > int_0)
		{
			return UInt32_0 + 1;
		}
		return UInt32_0;
	}

	public override string ToString()
	{
		return string.Format("{0}[{1}][{2}], pos=0x{3:X})", "ZipSegmentedStream", String_0, enum5_0.ToString(), Position);
	}

	private void method_2()
	{
		if (stream_0 != null)
		{
			stream_0.Dispose();
		}
		if (UInt32_0 + 1 == uint_1)
		{
			string_2 = string_0;
		}
		stream_0 = File.OpenRead(String_0);
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (enum5_0 != Enum5.const_1)
		{
			bool_0 = true;
			throw new InvalidOperationException("Stream Error: Cannot Read.");
		}
		int num = stream_0.Read(buffer, offset, count);
		int num2 = num;
		while (true)
		{
			if (num2 != count)
			{
				if (stream_0.Position == stream_0.Length)
				{
					if (UInt32_0 + 1 == uint_1)
					{
						break;
					}
					UInt32_0++;
					method_2();
					offset += num2;
					count -= num2;
					num2 = stream_0.Read(buffer, offset, count);
					num += num2;
					continue;
				}
				bool_0 = true;
				throw new ZipException($"Read error in file {String_0}");
			}
			return num;
		}
		return num;
	}

	private void method_3(uint uint_2)
	{
		if (stream_0 != null)
		{
			stream_0.Dispose();
			if (File.Exists(String_0))
			{
				File.Delete(String_0);
			}
			File.Move(string_3, String_0);
		}
		if (uint_2 != 0)
		{
			UInt32_0 += uint_2;
		}
		Class21.smethod_16(string_1, out stream_0, out string_3);
		if (UInt32_0 == 0)
		{
			stream_0.Write(BitConverter.GetBytes(134695760), 0, 4);
		}
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		if (enum5_0 != Enum5.const_2)
		{
			bool_0 = true;
			throw new InvalidOperationException("Stream Error: Cannot Write.");
		}
		if (Boolean_0)
		{
			if (stream_0.Position + count > int_0)
			{
				method_3(1u);
			}
		}
		else
		{
			while (stream_0.Position + count > int_0)
			{
				int num = int_0 - (int)stream_0.Position;
				stream_0.Write(buffer, offset, num);
				method_3(1u);
				count -= num;
				offset += num;
			}
		}
		stream_0.Write(buffer, offset, count);
	}

	public long method_4(uint uint_2, long long_0)
	{
		if (uint_2 >= 99)
		{
			throw new ArgumentOutOfRangeException("diskNumber");
		}
		if (enum5_0 != Enum5.const_2)
		{
			bool_0 = true;
			throw new ZipException("bad state.");
		}
		if (uint_2 == UInt32_0)
		{
			return stream_0.Seek(long_0, SeekOrigin.Begin);
		}
		if (stream_0 != null)
		{
			stream_0.Dispose();
			if (File.Exists(string_3))
			{
				File.Delete(string_3);
			}
		}
		for (uint num = UInt32_0 - 1; num > uint_2; num--)
		{
			string path = method_0(num);
			if (File.Exists(path))
			{
				File.Delete(path);
			}
		}
		UInt32_0 = uint_2;
		for (int i = 0; i < 3; i++)
		{
			try
			{
				string_3 = Class21.smethod_17();
				File.Move(String_0, string_3);
			}
			catch (IOException)
			{
				if (i == 2)
				{
					throw;
				}
				continue;
			}
			break;
		}
		stream_0 = new FileStream(string_3, FileMode.Open);
		return stream_0.Seek(long_0, SeekOrigin.Begin);
	}

	public override void Flush()
	{
		stream_0.Flush();
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		return stream_0.Seek(offset, origin);
	}

	public override void SetLength(long value)
	{
		if (enum5_0 != Enum5.const_2)
		{
			bool_0 = true;
			throw new InvalidOperationException();
		}
		stream_0.SetLength(value);
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (stream_0 != null)
			{
				stream_0.Dispose();
				if (enum5_0 != Enum5.const_2)
				{
				}
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}
}
