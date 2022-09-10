using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace Publisher.Track;

public class Sender
{
	private string tag = null;

	private string prefix = null;

	private string prices;

	private static string prm_key = "iwPTwg1zz24cJPE/gmZ2QQXtloDYg1EvYZL8XWs5+bU=";

	private static string prm_iv = "nYzT0lUc5GclTDkjF2w/MMvPyZ7zZmOacQM8FVR8i8U=";

	public Sender(string prefix, string tag, string prices)
	{
		U0fcEBNFP4SlSUFDZbb(this);
		UvpH2sNC9SvTvZPbveM();
		if (zNcuHCN6WwD8Zx6Juyi())
		{
			this.tag = tag;
		}
		this.prefix = prefix;
		this.prices = (string)NSGUuGNa1vPtmQhaxAp(prices, ',', '.');
	}

	public string getResponse()
	{
		string object_ = (string)oLnRYqNbH8hQLfuX06R(new string[9]
		{
			"{\"prefix\":\"",
			prefix,
			"\",\"tag\":\"",
			tag,
			"\",\"country\":\"",
			(string)hOY20FNU0WeFhi34TU9(),
			"\",\"prices\":\"",
			prices,
			"\"}"
		});
		HttpWebRequest object_2 = (HttpWebRequest)F0XL94NscdyS0Al2PgV(CommonConfig.TrackUrl);
		UYmLNqNiqsPRxweP6iA(object_2, DecompressionMethods.GZip);
		Vs7ijeNGtAb0B4gQNCP(object_2, "POST");
		DDbOfYNMtqjj7jMgQ78(object_2, "application/x-www-form-urlencoded");
		string object_3 = (string)PoYPGZNHMSQglD86VSa("order=\"", fSnh3CNDcVDlOfjHOFq(object_), "\"");
		byte[] array = (byte[])zFxfbQZJIJDMp1SjogK(vKAx7wNz5UQC33lNktQ(), object_3);
		CQTSnuZNAcDaxPfFjkB(object_2, array.Length);
		Stream object_4 = (Stream)YMecviZZuaJBu77nE7T(object_2);
		EotVSqZucQCDxv4CFjo(object_4, array, 0, array.Length);
		WebResponse object_5 = (WebResponse)z9G5aoZQYwRKWVqF4St(object_2);
		Stream stream = (Stream)bHjRNkZ9J6v7ap5xcAP(object_5);
		StreamReader streamReader = new StreamReader(stream);
		string result = streamReader.ReadToEnd();
		UvpH2sNC9SvTvZPbveM();
		if (zNcuHCN6WwD8Zx6Juyi())
		{
			JmoihgZnxuiMI8u6x1h(stream);
		}
		rlmx5HZKKLlYke5wgCW(streamReader);
		return result;
	}

	public static string Encrypt(string prm_text_to_encrypt)
	{
		RijndaelManaged object_ = default(RijndaelManaged);
		CryptoStream cryptoStream = default(CryptoStream);
		byte[] object_4 = default(byte[]);
		string result = default(string);
		byte[] bytes = default(byte[]);
		while (true)
		{
			zNcuHCN6WwD8Zx6Juyi();
			if (UvpH2sNC9SvTvZPbveM())
			{
				goto IL_0116;
			}
			goto IL_00ec;
			IL_00ec:
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			yhWqlVZ7EgAWVt7CTxb(rijndaelManaged, PaddingMode.PKCS7);
			osNGfHZEXAAD8MuHZy9(rijndaelManaged, CipherMode.CBC);
			DQwYyTZqPHU4toDdbgw(rijndaelManaged, 256);
			tqAe9pZol9espyyq5sS(rijndaelManaged, 256);
			object_ = rijndaelManaged;
			goto IL_0116;
			IL_0116:
			while (true)
			{
				IL_0116_2:
				byte[] object_2 = (byte[])FKyrrIZ0FPshGZQHNR9(prm_key);
				while (true)
				{
					byte[] object_3 = (byte[])FKyrrIZ0FPshGZQHNR9(prm_iv);
					while (true)
					{
						IL_00d1:
						ICryptoTransform transform = (ICryptoTransform)e8pixlZh6Hsf0b7hO8j(object_, object_2, object_3);
						while (true)
						{
							IL_00bc:
							MemoryStream memoryStream = new MemoryStream();
							int num = 7;
							if (!zNcuHCN6WwD8Zx6Juyi())
							{
								break;
							}
							while (true)
							{
								switch (num)
								{
								case 10:
									break;
								case 13:
									vvMD3XZmgfy3Wb9KH2j(cryptoStream);
									goto case 12;
								case 12:
									object_4 = (byte[])Sj7H8wZemv6uItUV7YR(memoryStream);
									goto case 8;
								case 8:
									result = (string)G729d8Z4I2j4CdsM5iH(object_4);
									num = 14;
									if (UvpH2sNC9SvTvZPbveM())
									{
									}
									continue;
								case 7:
									cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
									goto default;
								default:
									bytes = ((Encoding)dVlkKaZllIXecmfEqB6()).GetBytes(prm_text_to_encrypt);
									num = 5;
									if (!UvpH2sNC9SvTvZPbveM())
									{
										continue;
									}
									goto IL_00ec;
								case 5:
									cryptoStream.Write(bytes, 0, bytes.Length);
									goto case 13;
								case 9:
									goto IL_00bc;
								case 0:
									goto IL_00d1;
								case 11:
									goto end_IL_00bc;
								case 1:
								case 3:
									goto IL_00ec;
								case 2:
								case 6:
									goto IL_0116_2;
								case 14:
									return result;
								}
								break;
							}
							goto end_IL_00de;
							continue;
							end_IL_00bc:
							break;
						}
						break;
					}
					continue;
					end_IL_00de:
					break;
				}
				break;
			}
		}
	}

	internal static void U0fcEBNFP4SlSUFDZbb(object object_0)
	{
		object_0._002Ector();
	}

	internal static object NSGUuGNa1vPtmQhaxAp(object object_0, char char_0, char char_1)
	{
		return ((string)object_0).Replace(char_0, char_1);
	}

	internal static bool zNcuHCN6WwD8Zx6Juyi()
	{
		return true;
	}

	internal static bool UvpH2sNC9SvTvZPbveM()
	{
		return false;
	}

	internal static object hOY20FNU0WeFhi34TU9()
	{
		return CommonConfig.Country;
	}

	internal static object oLnRYqNbH8hQLfuX06R(object object_0)
	{
		return string.Concat((string?[])object_0);
	}

	internal static object F0XL94NscdyS0Al2PgV(object object_0)
	{
		return WebRequest.Create((string)object_0);
	}

	internal static void UYmLNqNiqsPRxweP6iA(object object_0, DecompressionMethods decompressionMethods_0)
	{
		((HttpWebRequest)object_0).AutomaticDecompression = decompressionMethods_0;
	}

	internal static void Vs7ijeNGtAb0B4gQNCP(object object_0, object object_1)
	{
		((WebRequest)object_0).Method = (string)object_1;
	}

	internal static void DDbOfYNMtqjj7jMgQ78(object object_0, object object_1)
	{
		((WebRequest)object_0).ContentType = (string?)object_1;
	}

	internal static object fSnh3CNDcVDlOfjHOFq(object object_0)
	{
		return Encrypt((string)object_0);
	}

	internal static object PoYPGZNHMSQglD86VSa(object object_0, object object_1, object object_2)
	{
		return (string?)object_0 + (string?)object_1 + (string?)object_2;
	}

	internal static object vKAx7wNz5UQC33lNktQ()
	{
		return Encoding.UTF8;
	}

	internal static object zFxfbQZJIJDMp1SjogK(object object_0, object object_1)
	{
		return ((Encoding)object_0).GetBytes((string)object_1);
	}

	internal static void CQTSnuZNAcDaxPfFjkB(object object_0, long long_0)
	{
		((WebRequest)object_0).ContentLength = long_0;
	}

	internal static object YMecviZZuaJBu77nE7T(object object_0)
	{
		return ((WebRequest)object_0).GetRequestStream();
	}

	internal static void EotVSqZucQCDxv4CFjo(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static object z9G5aoZQYwRKWVqF4St(object object_0)
	{
		return ((WebRequest)object_0).GetResponse();
	}

	internal static object bHjRNkZ9J6v7ap5xcAP(object object_0)
	{
		return ((WebResponse)object_0).GetResponseStream();
	}

	internal static void JmoihgZnxuiMI8u6x1h(object object_0)
	{
		((Stream)object_0).Dispose();
	}

	internal static void rlmx5HZKKLlYke5wgCW(object object_0)
	{
		((TextReader)object_0).Dispose();
	}

	internal static void yhWqlVZ7EgAWVt7CTxb(object object_0, PaddingMode paddingMode_0)
	{
		((SymmetricAlgorithm)object_0).Padding = paddingMode_0;
	}

	internal static void osNGfHZEXAAD8MuHZy9(object object_0, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_0).Mode = cipherMode_0;
	}

	internal static void DQwYyTZqPHU4toDdbgw(object object_0, int int_0)
	{
		((SymmetricAlgorithm)object_0).KeySize = int_0;
	}

	internal static void tqAe9pZol9espyyq5sS(object object_0, int int_0)
	{
		((SymmetricAlgorithm)object_0).BlockSize = int_0;
	}

	internal static object FKyrrIZ0FPshGZQHNR9(object object_0)
	{
		return Convert.FromBase64String((string)object_0);
	}

	internal static object e8pixlZh6Hsf0b7hO8j(object object_0, object object_1, object object_2)
	{
		return ((SymmetricAlgorithm)object_0).CreateEncryptor((byte[])object_1, (byte[]?)object_2);
	}

	internal static object dVlkKaZllIXecmfEqB6()
	{
		return Encoding.ASCII;
	}

	internal static void vvMD3XZmgfy3Wb9KH2j(object object_0)
	{
		((CryptoStream)object_0).FlushFinalBlock();
	}

	internal static object Sj7H8wZemv6uItUV7YR(object object_0)
	{
		return ((MemoryStream)object_0).ToArray();
	}

	internal static object G729d8Z4I2j4CdsM5iH(object object_0)
	{
		return Convert.ToBase64String((byte[])object_0);
	}
}
