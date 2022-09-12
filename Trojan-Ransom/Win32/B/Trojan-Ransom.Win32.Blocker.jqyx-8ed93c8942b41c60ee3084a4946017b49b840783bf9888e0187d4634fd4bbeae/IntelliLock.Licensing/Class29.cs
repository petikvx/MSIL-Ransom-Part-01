using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace IntelliLock.Licensing;

[Attribute1(CBPJIFOEJODEDAIKFEHLINCOJEILAOPJLPJM = true, MILJMOALDHJBDENJEIFBOPJBAHHFENPIBGJJ = true, GPLINEOBJKEEECKFEIKDKBKILCBHDFGDIEPC = true)]
internal class Class29
{
	internal static byte[] byte_0;

	public static bool smethod_0(byte[] byte_1)
	{
		lock (Class3.object_0)
		{
			if (new Class3().method_12(null, typeof(Class28), null, bool_16: true, bool_17: false, bool_18: false, bool_19: false, "", "", byte_1, bool_20: false, bool_21: true, bool_22: false) != null)
			{
				return true;
			}
			return false;
		}
	}

	public static byte[] smethod_1(byte[] byte_1)
	{
		byte_0 = new byte[0];
		lock (Class3.object_0)
		{
			new Class3().method_12(null, typeof(Class28), null, bool_16: true, bool_17: false, bool_18: false, bool_19: false, "", "", byte_1, bool_20: false, bool_21: false, bool_22: true);
		}
		return byte_0;
	}

	public static byte[] smethod_2(byte[] byte_1)
	{
		byte[] array = byte_1;
		byte[] array2 = array;
		SymmetricAlgorithm symmetricAlgorithm = Class1.smethod_8();
		symmetricAlgorithm.Mode = CipherMode.CBC;
		ICryptoTransform transform = symmetricAlgorithm.CreateEncryptor(Class3.byte_1, Class3.byte_2);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
		cryptoStream.Write(array2, 0, array2.Length);
		cryptoStream.FlushFinalBlock();
		array = memoryStream.ToArray();
		memoryStream.Close();
		return array;
	}

	public static byte[] smethod_3(byte[] byte_1)
	{
		try
		{
			SymmetricAlgorithm symmetricAlgorithm = Class1.smethod_8();
			symmetricAlgorithm.Mode = CipherMode.CBC;
			ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(Class3.byte_1, Class3.byte_2);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(byte_1, 0, byte_1.Length);
			cryptoStream.FlushFinalBlock();
			byte[] result = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
			return result;
		}
		catch
		{
			return null;
		}
	}

	public static byte[] smethod_4()
	{
		return Class1.smethod_9(smethod_5());
	}

	internal static byte[] smethod_5()
	{
		return Encoding.Unicode.GetBytes("<RSAKeyValue><Modulus>t0R+zt7wCeBClCmwRoOzVMQ4RbT7l4UXdrdrZ3hwYkE2LqCdBZujJLaZcoeozjRDu5zgr7slwKQpFQiQ3eu0vj07Khot/6fVgkTIoHQ58sn1weQnPy4DrvNYGuYTOT1ceNg+3vkFWrLdp8Mjo8gRNHRLqDKCMRATAWni5g/bvfVIJDmuNlF6dJqP2tHldZUoOfuIg5j+f1jO73oMSC6Hagm56i1oVDLjAusRgjY5+no8+bdhEE8JwxDFz2NA9pLo6uYX7K9eCb4N1vML6wUD5V/2kYIEO+vg0K+P987kceI78o5fwI2Hn8wSK5Bsl9aezOgUWtMbMOz+0izBKoDUGw==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
	}

	static Class29()
	{
		byte_0 = new byte[0];
	}
}
