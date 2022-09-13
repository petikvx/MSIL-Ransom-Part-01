using System;
using System.IO;
using Ionic.Zip;

internal class Class23
{
	private uint[] uint_0 = new uint[3] { 305419896u, 591751049u, 878082192u };

	private GClass12 gclass12_0 = new GClass12();

	private byte Byte_0
	{
		get
		{
			ushort num = (ushort)((ushort)(uint_0[2] & 0xFFFFu) | 2u);
			return (byte)(num * (num ^ 1) >> 8);
		}
	}

	private Class23()
	{
	}

	public static Class23 smethod_0(string string_0)
	{
		Class23 @class = new Class23();
		if (string_0 == null)
		{
			throw new BadPasswordException("This entry requires a password.");
		}
		@class.method_2(string_0);
		return @class;
	}

	public static Class23 smethod_1(string string_0, GClass8 gclass8_0)
	{
		Stream stream_ = gclass8_0.stream_0;
		gclass8_0.byte_3 = new byte[12];
		byte[] byte_ = gclass8_0.byte_3;
		Class23 @class = new Class23();
		if (string_0 == null)
		{
			throw new BadPasswordException("This entry requires a password.");
		}
		@class.method_2(string_0);
		GClass8.smethod_13(stream_, byte_);
		byte[] array = @class.method_0(byte_, byte_.Length);
		if (array[11] != (byte)((gclass8_0.int_2 >> 24) & 0xFF))
		{
			if ((gclass8_0.short_6 & 8) != 8)
			{
				throw new BadPasswordException("The password did not match.");
			}
			if (array[11] != (byte)((gclass8_0.int_1 >> 8) & 0xFF))
			{
				throw new BadPasswordException("The password did not match.");
			}
		}
		return @class;
	}

	public byte[] method_0(byte[] byte_0, int int_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException("cipherText");
		}
		if (int_0 > byte_0.Length)
		{
			throw new ArgumentOutOfRangeException("length", "Bad length during Decryption: the length parameter must be smaller than or equal to the size of the destination array.");
		}
		byte[] array = new byte[int_0];
		for (int i = 0; i < int_0; i++)
		{
			byte b = (byte)(byte_0[i] ^ Byte_0);
			method_3(b);
			array[i] = b;
		}
		return array;
	}

	public byte[] method_1(byte[] byte_0, int int_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException("plaintext");
		}
		if (int_0 > byte_0.Length)
		{
			throw new ArgumentOutOfRangeException("length", "Bad length during Encryption: The length parameter must be smaller than or equal to the size of the destination array.");
		}
		byte[] array = new byte[int_0];
		for (int i = 0; i < int_0; i++)
		{
			byte byte_ = byte_0[i];
			array[i] = (byte)(byte_0[i] ^ Byte_0);
			method_3(byte_);
		}
		return array;
	}

	public void method_2(string string_0)
	{
		byte[] array = Class21.smethod_5(string_0);
		for (int i = 0; i < string_0.Length; i++)
		{
			method_3(array[i]);
		}
	}

	private void method_3(byte byte_0)
	{
		uint_0[0] = (uint)gclass12_0.method_2((int)uint_0[0], byte_0);
		uint_0[1] = uint_0[1] + (byte)uint_0[0];
		uint_0[1] = uint_0[1] * 134775813 + 1;
		uint_0[2] = (uint)gclass12_0.method_2((int)uint_0[2], (byte)(uint_0[1] >> 24));
	}
}
