using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

public class GClass1
{
	private const string string_0 = "123";

	private string string_1;

	private string string_2;

	private Rijndael rijndael_0;

	[CompilerGenerated]
	private string string_3;

	private Rijndael Rijndael_0
	{
		get
		{
			if (rijndael_0 == null)
			{
				method_0();
			}
			return rijndael_0;
		}
		set
		{
			rijndael_0 = value;
		}
	}

	public string String_0
	{
		[CompilerGenerated]
		get
		{
			return string_3;
		}
		[CompilerGenerated]
		set
		{
			string_3 = value;
		}
	}

	public GClass1(string key, string saltKey)
	{
		string_1 = key;
		string_2 = saltKey;
	}

	public GClass1(string key)
		: this(key, null)
	{
	}

	public GClass1()
	{
	}

	private void method_0()
	{
		rijndael_0 = Rijndael.Create();
		if (string.IsNullOrEmpty(string_2))
		{
			string_2 = "123";
		}
		byte[] bytes = Encoding.Unicode.GetBytes(string_2);
		PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(string_1, bytes);
		rijndael_0.Key = passwordDeriveBytes.GetBytes(32);
		rijndael_0.IV = passwordDeriveBytes.GetBytes(16);
	}

	public string method_1(string string_4)
	{
		if (Rijndael_0 == null)
		{
			return null;
		}
		byte[] bytes = Encoding.Unicode.GetBytes(string_4);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, Rijndael_0.CreateEncryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(bytes, 0, bytes.Length);
		cryptoStream.Close();
		byte[] inArray = memoryStream.ToArray();
		String_0 = string.Concat(memoryStream);
		memoryStream.Close();
		return string.Concat(Convert.ToBase64String(inArray));
	}

	public string method_2(string string_4)
	{
		if (Rijndael_0 == null)
		{
			return null;
		}
		string result = null;
		try
		{
			byte[] array = Convert.FromBase64String(string_4);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, Rijndael_0.CreateDecryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			byte[] array2 = memoryStream.ToArray();
			result = Encoding.Unicode.GetString(array2, 0, array2.Length);
			return result;
		}
		catch
		{
			return result;
		}
	}

	public void method_3(string string_4, string string_5)
	{
		StreamWriter streamWriter = null;
		try
		{
			using (streamWriter = new StreamWriter(string_5, append: false))
			{
				streamWriter.Write(method_1(string_4));
			}
		}
		catch
		{
		}
	}

	public string method_4(string string_4)
	{
		if (!File.Exists(string_4))
		{
			return null;
		}
		string result = null;
		StreamReader streamReader = null;
		try
		{
			using (streamReader = new StreamReader(string_4))
			{
				result = method_2(streamReader.ReadToEnd());
			}
			return result;
		}
		catch
		{
		}
		return null;
	}
}
