using System;
using System.Collections.Generic;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Text;

namespace triPOS_vbnet;

public class AuthorizationHeader
{
	internal const string ValidUrlCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.~";

	internal const string ValidUrlCharactersRFC1738 = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.";

	internal static Dictionary<int, string> RFCEncodingSchemes = new Dictionary<int, string>
	{
		{ 3986, "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.~" },
		{ 1738, "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_." }
	};

	private string m_Algorithm;

	private string m_Credential;

	private string m_Nonce;

	private string m_RequestDate;

	private string m_Signature;

	private string m_SignedHeaders;

	private string m_Version;

	public string Algorithm
	{
		get
		{
			return m_Algorithm;
		}
		set
		{
			m_Algorithm = value;
		}
	}

	public string Credential
	{
		get
		{
			return m_Credential;
		}
		set
		{
			m_Credential = value;
		}
	}

	public string Nonce
	{
		get
		{
			return m_Nonce;
		}
		set
		{
			m_Nonce = value;
		}
	}

	public string RequestDate
	{
		get
		{
			return m_RequestDate;
		}
		set
		{
			m_RequestDate = value;
		}
	}

	public string Signature
	{
		get
		{
			return m_Signature;
		}
		set
		{
			m_Signature = value;
		}
	}

	public string SignedHeaders
	{
		get
		{
			return m_SignedHeaders;
		}
		set
		{
			m_SignedHeaders = value;
		}
	}

	public string Version
	{
		get
		{
			return m_Version;
		}
		set
		{
			m_Version = value;
		}
	}

	public AuthorizationHeader(string xauthorization)
	{
		string[] array = xauthorization.Split(new char[1] { ',' });
		Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
		string[] array2 = array;
		foreach (string text in array2)
		{
			string[] array3 = text.Split(new char[1] { '=' });
			dictionary.Add(array3[0].Trim(), array3[1].Trim());
		}
		if (dictionary.ContainsKey("version"))
		{
			Version = dictionary["version"];
		}
		if (dictionary.ContainsKey("algorithm"))
		{
			Algorithm = dictionary["algorithm"];
		}
		if (dictionary.ContainsKey("credential"))
		{
			Credential = dictionary["credential"];
		}
		if (dictionary.ContainsKey("signedheaders"))
		{
			SignedHeaders = dictionary["signedheaders"];
		}
		if (dictionary.ContainsKey("nonce"))
		{
			Nonce = dictionary["nonce"];
		}
		if (dictionary.ContainsKey("signature"))
		{
			Signature = dictionary["signature"];
		}
		if (dictionary.ContainsKey("requestdate"))
		{
			RequestDate = dictionary["requestdate"];
		}
	}

	public AuthorizationHeader(string version, string algorithm, string credential, string signedHeaders, string nonce, string requestDate, string signature)
	{
		Version = version;
		Algorithm = algorithm;
		Credential = credential;
		SignedHeaders = signedHeaders;
		Nonce = nonce;
		RequestDate = requestDate;
		Signature = signature;
	}

	public override string ToString()
	{
		return $"Version={Version}, Algorithm={Algorithm}, Credential={Credential}, SignedHeaders={SignedHeaders}, Nonce={Nonce}, RequestDate={RequestDate}, Signature={Signature}";
	}

	private static string CreateHmacSignature(string data, string key, string algorithm)
	{
		KeyedHashAlgorithm keyedHashAlgorithm = null;
		algorithm = algorithm.ToLower();
		keyedHashAlgorithm = algorithm switch
		{
			"tp-hmac-sha512" => KeyedHashAlgorithm.Create("HMACSHA512"), 
			"tp-hmac-sha384" => KeyedHashAlgorithm.Create("HMACSHA384"), 
			"tp-hmac-sha256" => KeyedHashAlgorithm.Create("HMACSHA256"), 
			"tp-hmac-sha1" => KeyedHashAlgorithm.Create("HMACSHA1"), 
			"tp-hmac-md5" => KeyedHashAlgorithm.Create("HMACMD5"), 
			_ => throw new AuthenticationException(Convert.ToString("Invalid signature algorithm: ") + algorithm), 
		};
		keyedHashAlgorithm.Key = Encoding.UTF8.GetBytes(key);
		byte[] data2 = keyedHashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(data));
		return ToHex(data2, lowercase: true);
	}

	private static string CreateUtf8(string input)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(input);
		return Encoding.UTF8.GetString(bytes);
	}

	private static string GetCanonicalHeaders(string canonicalSignedHeaders, HttpRequestHeaders headers)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
		string[] array = canonicalSignedHeaders.Split(new char[1] { ';' });
		string[] array2 = array;
		foreach (string text in array2)
		{
			if (dictionary.ContainsKey(text))
			{
				stringBuilder.Append($"{text}:{dictionary[text]}\n");
			}
		}
		string text2 = stringBuilder.ToString();
		if (text2.EndsWith("\n"))
		{
			text2 = text2.Substring(0, checked(text2.Length - 1));
		}
		return text2;
	}

	private static string GetCanonicalQueryString(Uri target)
	{
		string empty = string.Empty;
		if (!string.IsNullOrEmpty(target.Query))
		{
			HttpValueCollection httpValueCollection = HttpUtility.ParseQueryString(target.Query);
			if (httpValueCollection.Count > 0)
			{
			}
		}
		return empty;
	}

	private static string GetCanonicalSignedHeaders(HttpRequestHeaders headers)
	{
		StringBuilder stringBuilder = new StringBuilder();
		List<string> list = new List<string>();
		list.Sort();
		foreach (string item in list)
		{
			if (stringBuilder.Length > 0)
			{
				stringBuilder.Append($";{item}");
			}
			else
			{
				stringBuilder.Append($"{item}");
			}
		}
		return stringBuilder.ToString();
	}

	private static string GetCanonicalUri(Uri target)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string absolutePath = target.AbsolutePath;
		string text = absolutePath.Substring(absolutePath.IndexOf("/api/", StringComparison.OrdinalIgnoreCase));
		if (!string.IsNullOrEmpty(text))
		{
			if (!text.StartsWith("/"))
			{
				text = $"/{text}";
			}
			if (text.EndsWith("/"))
			{
				text = text.TrimEnd(new char[1] { '/' });
			}
			stringBuilder.Append(text);
		}
		return stringBuilder.ToString();
	}

	private static string HexEncodeHash(string data, string algorithm)
	{
		HashAlgorithm hashAlgorithm = null;
		algorithm = algorithm.ToLower();
		return ToHex((algorithm switch
		{
			"tp-hmac-sha512" => HashAlgorithm.Create("SHA512"), 
			"tp-hmac-sha384" => HashAlgorithm.Create("SHA384"), 
			"tp-hmac-sha256" => HashAlgorithm.Create("SHA256"), 
			"tp-hmac-sha1" => HashAlgorithm.Create("SHA1"), 
			"tp-hmac-md5" => HashAlgorithm.Create("MD5"), 
			_ => throw new AuthenticationException(Convert.ToString("Invalid signature algorithm: ") + algorithm), 
		}).ComputeHash(Encoding.UTF8.GetBytes(data)), lowercase: true);
	}

	private static string ToHex(byte[] data, bool lowercase)
	{
		StringBuilder stringBuilder = new StringBuilder();
		checked
		{
			int num = data.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				stringBuilder.Append(data[i].ToString(lowercase ? "x2" : "X2"));
			}
			return stringBuilder.ToString();
		}
	}

	private static string UrlEncode(string data, bool path)
	{
		return UrlEncode(3986, data, path);
	}

	private static string UrlEncode(int rfcNumber, string data, bool path)
	{
		StringBuilder stringBuilder = new StringBuilder(checked(data.Length * 2));
		string value = "";
		if (!RFCEncodingSchemes.TryGetValue(rfcNumber, out value))
		{
			value = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.~";
		}
		string text = value + (path ? "/:" : string.Empty);
		foreach (char value2 in data)
		{
			if (text.IndexOf(value2) != -1)
			{
				stringBuilder.Append(value2);
			}
			else
			{
				stringBuilder.Append("%").Append($"{Convert.ToInt32(value2):X2}");
			}
		}
		return stringBuilder.ToString();
	}
}
