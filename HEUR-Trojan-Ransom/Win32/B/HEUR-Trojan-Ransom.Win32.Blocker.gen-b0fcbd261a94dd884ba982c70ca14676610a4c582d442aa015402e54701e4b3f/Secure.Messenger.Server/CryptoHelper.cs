using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Security.Cryptography;
using Secure.Messenger.Shared;

namespace Secure.Messenger.Server;

public class CryptoHelper
{
	public static bool SendData(NetworkStream strm, MessageData mes)
	{
		IFormatter iformatter_ = (IFormatter)CryptoHelper.smethod_0();
		MemoryStream memoryStream = CryptoHelper.smethod_1();
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = null;
		CryptoStream cryptoStream = null;
		try
		{
			byte[] array = new byte[16];
			CryptoHelper.smethod_2((Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			byte[] byte_ = array;
			byte[] array2 = new byte[16];
			CryptoHelper.smethod_2((Array)array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			byte[] byte_2 = array2;
			tripleDESCryptoServiceProvider = CryptoHelper.smethod_3();
			cryptoStream = CryptoHelper.smethod_5((Stream)memoryStream, CryptoHelper.smethod_4((SymmetricAlgorithm)tripleDESCryptoServiceProvider, byte_, byte_2), CryptoStreamMode.Write);
			CryptoHelper.smethod_6(iformatter_, (Stream)cryptoStream, (object)mes);
			CryptoHelper.smethod_7(cryptoStream);
			byte[] byte_3 = CryptoHelper.smethod_8(memoryStream);
			int num = (int)CryptoHelper.smethod_9((Stream)memoryStream);
			byte[] byte_4 = CryptoHelper.smethod_10(num);
			CryptoHelper.smethod_11((Stream)strm, byte_4, 0, 4);
			CryptoHelper.smethod_11((Stream)strm, byte_3, 0, num);
			return true;
		}
		catch (Exception)
		{
			return false;
		}
		finally
		{
			CryptoHelper.smethod_12((Stream)strm);
			CryptoHelper.smethod_13((Stream)cryptoStream);
			CryptoHelper.smethod_13((Stream)memoryStream);
		}
	}

	public static MessageData ReceiveData(NetworkStream strm)
	{
		MemoryStream stream_ = CryptoHelper.smethod_1();
		byte[] array = new byte[16];
		CryptoHelper.smethod_2((Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		byte[] byte_ = array;
		byte[] array2 = new byte[16];
		CryptoHelper.smethod_2((Array)array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		byte[] byte_2 = array2;
		TripleDESCryptoServiceProvider symmetricAlgorithm_ = CryptoHelper.smethod_3();
		CryptoStream cryptoStream = CryptoHelper.smethod_5((Stream)stream_, CryptoHelper.smethod_14((SymmetricAlgorithm)symmetricAlgorithm_, byte_, byte_2), CryptoStreamMode.Write);
		byte[] byte_3 = new byte[2048];
		int num = CryptoHelper.smethod_15((Stream)strm, byte_3, 0, 4);
		int num2 = CryptoHelper.smethod_16(byte_3, 0);
		int num3 = 0;
		while (num2 > 0)
		{
			num = CryptoHelper.smethod_15((Stream)strm, byte_3, 0, num2);
			CryptoHelper.smethod_11((Stream)cryptoStream, byte_3, num3, num);
			num3 += num;
			num2 -= num;
		}
		CryptoHelper.smethod_7(cryptoStream);
		IFormatter iformatter_ = (IFormatter)CryptoHelper.smethod_0();
		CryptoHelper.smethod_17((Stream)stream_, 0L);
		MessageData messageData = new MessageData(string.Empty);
		try
		{
			messageData = (MessageData)CryptoHelper.smethod_18(iformatter_, (Stream)stream_);
		}
		catch (SerializationException)
		{
			return null;
		}
		CryptoHelper.smethod_13((Stream)stream_);
		return messageData;
	}

	static SoapFormatter smethod_0()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new SoapFormatter();
	}

	static MemoryStream smethod_1()
	{
		return new MemoryStream();
	}

	static void smethod_2(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
	}

	static TripleDESCryptoServiceProvider smethod_3()
	{
		return new TripleDESCryptoServiceProvider();
	}

	static ICryptoTransform smethod_4(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1)
	{
		return symmetricAlgorithm_0.CreateEncryptor(byte_0, byte_1);
	}

	static CryptoStream smethod_5(Stream stream_0, ICryptoTransform icryptoTransform_0, CryptoStreamMode cryptoStreamMode_0)
	{
		return new CryptoStream(stream_0, icryptoTransform_0, cryptoStreamMode_0);
	}

	static void smethod_6(IFormatter iformatter_0, Stream stream_0, object object_0)
	{
		iformatter_0.Serialize(stream_0, object_0);
	}

	static void smethod_7(CryptoStream cryptoStream_0)
	{
		cryptoStream_0.FlushFinalBlock();
	}

	static byte[] smethod_8(MemoryStream memoryStream_0)
	{
		return memoryStream_0.GetBuffer();
	}

	static long smethod_9(Stream stream_0)
	{
		return stream_0.Length;
	}

	static byte[] smethod_10(int int_0)
	{
		return BitConverter.GetBytes(int_0);
	}

	static void smethod_11(Stream stream_0, byte[] byte_0, int int_0, int int_1)
	{
		stream_0.Write(byte_0, int_0, int_1);
	}

	static void smethod_12(Stream stream_0)
	{
		stream_0.Flush();
	}

	static void smethod_13(Stream stream_0)
	{
		stream_0.Close();
	}

	static ICryptoTransform smethod_14(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1)
	{
		return symmetricAlgorithm_0.CreateDecryptor(byte_0, byte_1);
	}

	static int smethod_15(Stream stream_0, byte[] byte_0, int int_0, int int_1)
	{
		return stream_0.Read(byte_0, int_0, int_1);
	}

	static int smethod_16(byte[] byte_0, int int_0)
	{
		return BitConverter.ToInt32(byte_0, int_0);
	}

	static void smethod_17(Stream stream_0, long long_0)
	{
		stream_0.Position = long_0;
	}

	static object smethod_18(IFormatter iformatter_0, Stream stream_0)
	{
		return iformatter_0.Deserialize(stream_0);
	}
}
