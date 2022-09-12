using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace ns0;

internal class Class0
{
	private readonly Random random_0 = new Random();

	private readonly bool bool_0 = false;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string string_0;

	public string EncryptionKey
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		private set
		{
			string_0 = value;
		}
	}

	public Class0()
	{
		EncryptionKey = method_9(20);
	}

	public Class0(string string_1)
	{
		EncryptionKey = string_1;
	}

	public void method_0(int int_0, out string string_1, out string string_2)
	{
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
		string_1 = rSACryptoServiceProvider.ToXmlString(includePrivateParameters: false);
		string_2 = rSACryptoServiceProvider.ToXmlString(includePrivateParameters: true);
	}

	public byte[] method_1(byte[] byte_0, int int_0, string string_1)
	{
		if (byte_0 == null || byte_0.Length == 0)
		{
			throw new ArgumentException("Data are empty", "data");
		}
		int num = method_10(int_0);
		if (byte_0.Length > num)
		{
			throw new ArgumentException($"Maximum data length is {num}", "data");
		}
		if (!method_11(int_0))
		{
			throw new ArgumentException("Key size is not valid", "keySize");
		}
		if (string.IsNullOrEmpty(string_1))
		{
			throw new ArgumentException("Key is null or empty", "publicKeyXml");
		}
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
		rSACryptoServiceProvider.FromXmlString(string_1);
		return rSACryptoServiceProvider.Encrypt(byte_0, bool_0);
	}

	public byte[] method_2(byte[] byte_0, int int_0, string string_1)
	{
		if (byte_0 == null || byte_0.Length == 0)
		{
			throw new ArgumentException("Data are empty", "data");
		}
		if (!method_11(int_0))
		{
			throw new ArgumentException("Key size is not valid", "keySize");
		}
		if (string.IsNullOrEmpty(string_1))
		{
			throw new ArgumentException("Key is null or empty", "publicAndPrivateKeyXml");
		}
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
		rSACryptoServiceProvider.FromXmlString(string_1);
		return rSACryptoServiceProvider.Decrypt(byte_0, bool_0);
	}

	public void method_3(string string_1)
	{
		Stream stream = new FileStream(string_1, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		byte[] array = new byte[stream.Length];
		using (BinaryReader binaryReader = new BinaryReader(stream))
		{
			using BinaryWriter binaryWriter = new BinaryWriter(stream);
			binaryReader.BaseStream.Position = 0L;
			array = binaryReader.ReadBytes((int)stream.Length);
			binaryWriter.BaseStream.Position = 0L;
			array = method_7(array, method_12(EncryptionKey));
			binaryWriter.Write(array);
		}
		stream.Close();
		stream.Dispose();
	}

	public void method_4(string string_1)
	{
		Stream stream = new FileStream(string_1, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		byte[] array = new byte[stream.Length];
		using (BinaryReader binaryReader = new BinaryReader(stream))
		{
			using BinaryWriter binaryWriter = new BinaryWriter(stream);
			binaryReader.BaseStream.Position = 0L;
			array = binaryReader.ReadBytes((int)stream.Length);
			binaryWriter.BaseStream.Position = 0L;
			array = method_8(array, method_12(EncryptionKey));
			binaryWriter.Write(array);
		}
		stream.Close();
		stream.Dispose();
	}

	public void method_5(string string_1)
	{
		Stream stream = new FileStream(string_1, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		byte[] array = new byte[1024];
		using (BinaryReader binaryReader = new BinaryReader(stream))
		{
			using BinaryWriter binaryWriter = new BinaryWriter(stream);
			binaryReader.BaseStream.Position = 0L;
			array = binaryReader.ReadBytes(1024);
			binaryWriter.BaseStream.Position = 0L;
			array = method_7(array, method_12(EncryptionKey));
			binaryWriter.Write(array);
		}
		stream.Close();
		stream.Dispose();
	}

	public void method_6(string string_1)
	{
		Stream stream = new FileStream(string_1, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		byte[] array = new byte[1024];
		using (BinaryReader binaryReader = new BinaryReader(stream))
		{
			using BinaryWriter binaryWriter = new BinaryWriter(stream);
			binaryReader.BaseStream.Position = 0L;
			array = binaryReader.ReadBytes(1024);
			binaryWriter.BaseStream.Position = 0L;
			array = method_8(array, method_12(EncryptionKey));
			binaryWriter.Write(array);
		}
		stream.Close();
		stream.Dispose();
	}

	private byte[] method_7(byte[] byte_0, byte[] byte_1)
	{
		byte[] array = new byte[byte_0.Length];
		int num = 0;
		for (int i = 0; i < byte_0.Length; i++)
		{
			array[i] = (byte)(byte_0[i] + byte_1[num]);
			num = ((byte_1[num + 1] != 0) ? (num + 1) : 0);
		}
		return array;
	}

	private byte[] method_8(byte[] byte_0, byte[] byte_1)
	{
		byte[] array = new byte[byte_0.Length];
		int num = 0;
		for (int i = 0; i < byte_0.Length; i++)
		{
			array[i] = (byte)(byte_0[i] - byte_1[num]);
			num = ((byte_1[num + 1] != 0) ? (num + 1) : 0);
		}
		return array;
	}

	private string method_9(int int_0)
	{
		string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
		string text2 = "";
		for (int i = 0; i < int_0; i++)
		{
			text2 += text[random_0.Next(text.Length)];
		}
		return text2;
	}

	private int method_10(int int_0)
	{
		if (bool_0)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private bool method_11(int int_0)
	{
		return int_0 >= 384 && int_0 <= 16384 && int_0 % 8 == 0;
	}

	private byte[] method_12(string string_1)
	{
		byte[] array = new byte[string_1.Length * 2];
		Buffer.BlockCopy(string_1.ToCharArray(), 0, array, 0, array.Length);
		return array;
	}

	private string method_13(byte[] byte_0)
	{
		char[] array = new char[byte_0.Length / 2];
		Buffer.BlockCopy(byte_0, 0, array, 0, byte_0.Length);
		return new string(array);
	}
}
