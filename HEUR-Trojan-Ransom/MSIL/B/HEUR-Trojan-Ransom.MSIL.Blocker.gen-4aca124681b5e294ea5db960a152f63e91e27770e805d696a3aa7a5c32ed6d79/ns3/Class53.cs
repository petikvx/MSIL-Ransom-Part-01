using System;
using System.IO;
using System.Security.Cryptography;
using System.Xml;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns8;

namespace ns3;

internal sealed class Class53
{
	public static string string_0;

	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] smethod_0(byte[] byte_0, string string_1)
	{
		if (string_1.StartsWith(getString_0(107390443)))
		{
			string_0 = getString_0(107390406);
			return null;
		}
		RijndaelManaged rijndaelManaged = null;
		RSACryptoServiceProvider rSACryptoServiceProvider = null;
		MemoryStream memoryStream = null;
		CryptoStream cryptoStream = null;
		byte[] result;
		try
		{
			rijndaelManaged = new RijndaelManaged();
			rSACryptoServiceProvider = new RSACryptoServiceProvider();
			smethod_1(rSACryptoServiceProvider, string_1);
			rijndaelManaged.GenerateKey();
			rijndaelManaged.GenerateIV();
			byte[] array = new byte[48];
			Buffer.BlockCopy(rijndaelManaged.Key, 0, array, 0, 32);
			Buffer.BlockCopy(rijndaelManaged.IV, 0, array, 32, 16);
			memoryStream = new MemoryStream();
			try
			{
				byte[] array2 = rSACryptoServiceProvider.Encrypt(array, fOAEP: false);
				memoryStream.WriteByte(1);
				memoryStream.WriteByte(Convert.ToByte(array2.Length / 8));
				memoryStream.Write(array2, 0, array2.Length);
			}
			catch (CryptographicException)
			{
				try
				{
					byte[] array3 = new byte[16];
					byte[] array4 = new byte[16];
					Buffer.BlockCopy(rijndaelManaged.Key, 0, array3, 0, 16);
					Buffer.BlockCopy(rijndaelManaged.Key, 16, array4, 0, 16);
					byte[] array5 = rSACryptoServiceProvider.Encrypt(array3, fOAEP: false);
					byte[] array6 = rSACryptoServiceProvider.Encrypt(array4, fOAEP: false);
					byte[] array7 = rSACryptoServiceProvider.Encrypt(rijndaelManaged.IV, fOAEP: false);
					memoryStream.WriteByte(2);
					memoryStream.WriteByte(Convert.ToByte(array5.Length / 8));
					memoryStream.Write(array5, 0, array5.Length);
					memoryStream.Write(array6, 0, array6.Length);
					memoryStream.Write(array7, 0, array7.Length);
					goto end_IL_00c1;
				}
				catch (CryptographicException)
				{
					string_0 = getString_0(107390857);
					result = null;
				}
				goto end_IL_003b;
				end_IL_00c1:;
			}
			cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.FlushFinalBlock();
			result = memoryStream.ToArray();
			end_IL_003b:;
		}
		catch (Exception ex3)
		{
			string_0 = getString_0(107390619) + ex3.Message;
			result = null;
		}
		finally
		{
			rijndaelManaged?.Clear();
			rSACryptoServiceProvider?.Clear();
			memoryStream?.Close();
			cryptoStream?.Close();
		}
		return result;
	}

	private static void smethod_1(RSACryptoServiceProvider rsacryptoServiceProvider_0, string string_1)
	{
		RSAParameters parameters = default(RSAParameters);
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(string_1);
		if (xmlDocument.DocumentElement!.Name.Equals(getString_0(107384598)))
		{
			foreach (XmlNode childNode in xmlDocument.DocumentElement!.ChildNodes)
			{
				string name = childNode.Name;
				switch (Class56.smethod_0(name))
				{
				case 684613497u:
					if (name == getString_0(107384555))
					{
						parameters.DP = Convert.FromBase64String(childNode.InnerText);
					}
					break;
				case 667835878u:
					if (name == getString_0(107384518))
					{
						parameters.DQ = Convert.FromBase64String(childNode.InnerText);
					}
					break;
				case 2183145318u:
					if (name == getString_0(107384536))
					{
						parameters.Exponent = Convert.FromBase64String(childNode.InnerText);
					}
					break;
				case 1898057334u:
					if (name == getString_0(107384513))
					{
						parameters.InverseQ = Convert.FromBase64String(childNode.InnerText);
					}
					break;
				case 3557560316u:
					if (name == getString_0(107395731))
					{
						parameters.Q = Convert.FromBase64String(childNode.InnerText);
					}
					break;
				case 3238785555u:
					if (name == getString_0(107395579))
					{
						parameters.D = Convert.FromBase64String(childNode.InnerText);
					}
					break;
				case 3883103162u:
					if (name == getString_0(107384549))
					{
						parameters.Modulus = Convert.FromBase64String(childNode.InnerText);
					}
					break;
				case 3574337935u:
					if (name == getString_0(107395609))
					{
						parameters.P = Convert.FromBase64String(childNode.InnerText);
					}
					break;
				}
			}
			rsacryptoServiceProvider_0.ImportParameters(parameters);
			return;
		}
		throw new Exception(getString_0(107384532));
	}

	static Class53()
	{
		Strings.CreateGetStringDelegate(typeof(Class53));
	}
}
