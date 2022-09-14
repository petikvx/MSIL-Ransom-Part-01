using System;
using System.IO;
using System.Security.Cryptography;
using Ionic.Zip;
using ns0;
using ns5;
using ns7;

namespace ns1;

internal sealed class Stream3 : Stream
{
	private Class19 class19_0;

	private Stream stream_0;

	private Enum5 enum5_0;

	internal int int_0;

	internal bool bool_0;

	internal HMACSHA1 hmacsha1_0;

	internal RijndaelManaged rijndaelManaged_0;

	internal ICryptoTransform icryptoTransform_0;

	internal byte[] byte_0 = new byte[16];

	internal byte[] byte_1 = new byte[16];

	internal long long_0;

	internal long long_1;

	internal byte[] byte_2;

	internal int int_1;

	private byte[] byte_3;

	private object object_0 = new object();

	bool Stream.CanRead
	{
		get
		{
			if (enum5_0 != Enum5.const_1)
			{
				return false;
			}
			return true;
		}
	}

	bool Stream.CanSeek => false;

	bool Stream.CanWrite => enum5_0 == Enum5.const_0;

	long Stream.Length
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	long Stream.Position
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

	internal Stream3(Stream stream_1, Class19 class19_1, long long_2, Enum5 enum5_1)
		: this(stream_1, class19_1, enum5_1)
	{
		long_0 = long_2;
	}

	internal Stream3(Stream stream_1, Class19 class19_1, Enum5 enum5_1)
	{
		class19_0 = class19_1;
		stream_0 = stream_1;
		enum5_0 = enum5_1;
		int_0 = 1;
		if (class19_0 == null)
		{
			throw new BadPasswordException("Supply a password to use AES encryption.");
		}
		int num = Class6.smethod_645(class19_0).Length * 8;
		if (num != 256 && num != 128 && num != 192)
		{
			throw new ArgumentOutOfRangeException("keysize", "size of key must be 128, 192, or 256");
		}
		hmacsha1_0 = new HMACSHA1(Class6.smethod_431(class19_0));
		rijndaelManaged_0 = new RijndaelManaged();
		rijndaelManaged_0.BlockSize = 128;
		rijndaelManaged_0.KeySize = num;
		rijndaelManaged_0.Mode = CipherMode.ECB;
		rijndaelManaged_0.Padding = PaddingMode.None;
		byte[] rgbIV = new byte[16];
		icryptoTransform_0 = rijndaelManaged_0.CreateEncryptor(Class6.smethod_645(class19_0), rgbIV);
		if (enum5_0 == Enum5.const_0)
		{
			byte_3 = new byte[2048];
			byte_2 = new byte[16];
		}
	}

	int Stream.Read(byte[] buffer, int offset, int count)
	{
		if (enum5_0 == Enum5.const_0)
		{
			throw new NotSupportedException();
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", "Must not be less than zero.");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", "Must not be less than zero.");
		}
		if (buffer.Length < offset + count)
		{
			throw new ArgumentException("The buffer is too small");
		}
		int count2 = count;
		if (long_1 >= long_0)
		{
			return 0;
		}
		long num = long_0 - long_1;
		if (num < count)
		{
			count2 = (int)num;
		}
		int num2 = stream_0.Read(buffer, offset, count2);
		Class6.smethod_396(count2, buffer, this, offset);
		long_1 += num2;
		return num2;
	}

	void Stream.Write(byte[] buffer, int offset, int count)
	{
		if (bool_0)
		{
			throw new InvalidOperationException("The final block has already been transformed.");
		}
		if (enum5_0 == Enum5.const_1)
		{
			throw new NotSupportedException();
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", "Must not be less than zero.");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", "Must not be less than zero.");
		}
		if (buffer.Length < offset + count)
		{
			throw new ArgumentException("The offset and count are too large");
		}
		if (count == 0)
		{
			return;
		}
		if (count + int_1 <= 16)
		{
			Buffer.BlockCopy(buffer, offset, byte_2, int_1, count);
			int_1 += count;
			return;
		}
		int num = count;
		int num2 = offset;
		if (int_1 != 0)
		{
			int num3 = 16 - int_1;
			if (num3 > 0)
			{
				Buffer.BlockCopy(buffer, offset, byte_2, int_1, num3);
				num -= num3;
				num2 += num3;
			}
			Class6.smethod_663(this, byte_2, 0);
			stream_0.Write(byte_2, 0, 16);
			long_1 += 16L;
			int_1 = 0;
		}
		int num4 = (num - 1) / 16;
		int_1 = num - num4 * 16;
		Buffer.BlockCopy(buffer, num2 + num - int_1, byte_2, 0, int_1);
		num -= int_1;
		long_1 += num;
		if (num4 <= 0)
		{
			return;
		}
		do
		{
			int num5 = byte_3.Length;
			if (num5 > num)
			{
				num5 = num;
			}
			Buffer.BlockCopy(buffer, num2, byte_3, 0, num5);
			Class6.smethod_220(byte_3, num5, this, 0);
			stream_0.Write(byte_3, 0, num5);
			num -= num5;
			num2 += num5;
		}
		while (num > 0);
	}

	void Stream.Close()
	{
		if (int_1 > 0)
		{
			Class6.smethod_179(this);
			stream_0.Write(byte_2, 0, int_1);
			long_1 += int_1;
			int_1 = 0;
		}
		stream_0.Close();
	}

	void Stream.Flush()
	{
		stream_0.Flush();
	}

	long Stream.Seek(long offset, SeekOrigin origin)
	{
		throw new NotImplementedException();
	}

	void Stream.SetLength(long value)
	{
		throw new NotImplementedException();
	}
}
