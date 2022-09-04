using System.Security.Cryptography;
using System.Text;

namespace Handyware;

internal class Hash
{
	public static string MD5(string input)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] bytes = Encoding.UTF8.GetBytes(input);
		bytes = mD5CryptoServiceProvider.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array = bytes;
		foreach (byte b in array)
		{
			stringBuilder.Append(b.ToString("x2").ToLower());
		}
		return stringBuilder.ToString();
	}

	public static string MD5(string input, string inputEncoding)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] bytes;
		StringBuilder stringBuilder;
		byte[] array;
		switch (inputEncoding)
		{
		case "UTF7":
			bytes = Encoding.UTF7.GetBytes(input);
			goto IL_009d;
		case "UTF32":
			bytes = Encoding.UTF32.GetBytes(input);
			goto IL_009d;
		case "Unicode":
			bytes = Encoding.Unicode.GetBytes(input);
			goto IL_009d;
		case "ASCII":
			bytes = Encoding.ASCII.GetBytes(input);
			goto IL_009d;
		case "UTF8":
			bytes = Encoding.UTF8.GetBytes(input);
			goto IL_009d;
		default:
			{
				return "";
			}
			IL_009d:
			bytes = mD5CryptoServiceProvider.ComputeHash(bytes);
			stringBuilder = new StringBuilder();
			array = bytes;
			foreach (byte b in array)
			{
				stringBuilder.Append(b.ToString("x2").ToLower());
			}
			return stringBuilder.ToString();
		}
	}

	public static string MD5(string input, string inputEncoding, out string Error)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] bytes;
		StringBuilder stringBuilder;
		byte[] array;
		string result;
		switch (inputEncoding)
		{
		case "UTF7":
			bytes = Encoding.UTF7.GetBytes(input);
			goto IL_009d;
		case "UTF32":
			bytes = Encoding.UTF32.GetBytes(input);
			goto IL_009d;
		case "Unicode":
			bytes = Encoding.Unicode.GetBytes(input);
			goto IL_009d;
		case "ASCII":
			bytes = Encoding.ASCII.GetBytes(input);
			goto IL_009d;
		case "UTF8":
			bytes = Encoding.UTF8.GetBytes(input);
			goto IL_009d;
		default:
			{
				Error = "inputEncoding: ASCII Unicode UTF7 UTF8 UTF32";
				return "";
			}
			IL_009d:
			bytes = mD5CryptoServiceProvider.ComputeHash(bytes);
			stringBuilder = new StringBuilder();
			array = bytes;
			foreach (byte b in array)
			{
				stringBuilder.Append(b.ToString("x2").ToLower());
			}
			result = stringBuilder.ToString();
			Error = "";
			return result;
		}
	}

	public static string MD5(byte[] input)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		input = mD5CryptoServiceProvider.ComputeHash(input);
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array = input;
		foreach (byte b in array)
		{
			stringBuilder.Append(b.ToString("x2").ToLower());
		}
		return stringBuilder.ToString();
	}

	public static string SHA1(string input)
	{
		SHA1CryptoServiceProvider sHA1CryptoServiceProvider = new SHA1CryptoServiceProvider();
		byte[] bytes = Encoding.UTF8.GetBytes(input);
		bytes = sHA1CryptoServiceProvider.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array = bytes;
		foreach (byte b in array)
		{
			stringBuilder.Append(b.ToString("x2").ToLower());
		}
		return stringBuilder.ToString();
	}

	public static string SHA1(string input, string inputEncoding)
	{
		SHA1CryptoServiceProvider sHA1CryptoServiceProvider = new SHA1CryptoServiceProvider();
		byte[] bytes;
		StringBuilder stringBuilder;
		byte[] array;
		switch (inputEncoding)
		{
		case "UTF7":
			bytes = Encoding.UTF7.GetBytes(input);
			goto IL_009d;
		case "UTF32":
			bytes = Encoding.UTF32.GetBytes(input);
			goto IL_009d;
		case "Unicode":
			bytes = Encoding.Unicode.GetBytes(input);
			goto IL_009d;
		case "ASCII":
			bytes = Encoding.ASCII.GetBytes(input);
			goto IL_009d;
		case "UTF8":
			bytes = Encoding.UTF8.GetBytes(input);
			goto IL_009d;
		default:
			{
				return "";
			}
			IL_009d:
			bytes = sHA1CryptoServiceProvider.ComputeHash(bytes);
			stringBuilder = new StringBuilder();
			array = bytes;
			foreach (byte b in array)
			{
				stringBuilder.Append(b.ToString("x2").ToLower());
			}
			return stringBuilder.ToString();
		}
	}

	public static string SHA1(string input, string inputEncoding, out string Error)
	{
		SHA1CryptoServiceProvider sHA1CryptoServiceProvider = new SHA1CryptoServiceProvider();
		byte[] bytes;
		StringBuilder stringBuilder;
		byte[] array;
		string result;
		switch (inputEncoding)
		{
		case "UTF7":
			bytes = Encoding.UTF7.GetBytes(input);
			goto IL_009d;
		case "UTF32":
			bytes = Encoding.UTF32.GetBytes(input);
			goto IL_009d;
		case "Unicode":
			bytes = Encoding.Unicode.GetBytes(input);
			goto IL_009d;
		case "ASCII":
			bytes = Encoding.ASCII.GetBytes(input);
			goto IL_009d;
		case "UTF8":
			bytes = Encoding.UTF8.GetBytes(input);
			goto IL_009d;
		default:
			{
				Error = "inputEncoding: ASCII Unicode UTF7 UTF8 UTF32";
				return "";
			}
			IL_009d:
			bytes = sHA1CryptoServiceProvider.ComputeHash(bytes);
			stringBuilder = new StringBuilder();
			array = bytes;
			foreach (byte b in array)
			{
				stringBuilder.Append(b.ToString("x2").ToLower());
			}
			result = stringBuilder.ToString();
			Error = "";
			return result;
		}
	}

	public static string SHA1(byte[] input)
	{
		SHA1CryptoServiceProvider sHA1CryptoServiceProvider = new SHA1CryptoServiceProvider();
		input = sHA1CryptoServiceProvider.ComputeHash(input);
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array = input;
		foreach (byte b in array)
		{
			stringBuilder.Append(b.ToString("x2").ToLower());
		}
		return stringBuilder.ToString();
	}

	public static string SHA256(string input)
	{
		SHA256CryptoServiceProvider sHA256CryptoServiceProvider = new SHA256CryptoServiceProvider();
		byte[] bytes = Encoding.UTF8.GetBytes(input);
		bytes = sHA256CryptoServiceProvider.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array = bytes;
		foreach (byte b in array)
		{
			stringBuilder.Append(b.ToString("x2").ToLower());
		}
		return stringBuilder.ToString();
	}

	public static string SHA256(string input, string inputEncoding)
	{
		SHA256CryptoServiceProvider sHA256CryptoServiceProvider = new SHA256CryptoServiceProvider();
		byte[] bytes;
		StringBuilder stringBuilder;
		byte[] array;
		switch (inputEncoding)
		{
		case "UTF7":
			bytes = Encoding.UTF7.GetBytes(input);
			goto IL_009d;
		case "UTF32":
			bytes = Encoding.UTF32.GetBytes(input);
			goto IL_009d;
		case "Unicode":
			bytes = Encoding.Unicode.GetBytes(input);
			goto IL_009d;
		case "ASCII":
			bytes = Encoding.ASCII.GetBytes(input);
			goto IL_009d;
		case "UTF8":
			bytes = Encoding.UTF8.GetBytes(input);
			goto IL_009d;
		default:
			{
				return "";
			}
			IL_009d:
			bytes = sHA256CryptoServiceProvider.ComputeHash(bytes);
			stringBuilder = new StringBuilder();
			array = bytes;
			foreach (byte b in array)
			{
				stringBuilder.Append(b.ToString("x2").ToLower());
			}
			return stringBuilder.ToString();
		}
	}

	public static string SHA256(string input, string inputEncoding, out string Error)
	{
		SHA256CryptoServiceProvider sHA256CryptoServiceProvider = new SHA256CryptoServiceProvider();
		byte[] bytes;
		StringBuilder stringBuilder;
		byte[] array;
		string result;
		switch (inputEncoding)
		{
		case "UTF7":
			bytes = Encoding.UTF7.GetBytes(input);
			goto IL_009d;
		case "UTF32":
			bytes = Encoding.UTF32.GetBytes(input);
			goto IL_009d;
		case "Unicode":
			bytes = Encoding.Unicode.GetBytes(input);
			goto IL_009d;
		case "ASCII":
			bytes = Encoding.ASCII.GetBytes(input);
			goto IL_009d;
		case "UTF8":
			bytes = Encoding.UTF8.GetBytes(input);
			goto IL_009d;
		default:
			{
				Error = "inputEncoding: ASCII Unicode UTF7 UTF8 UTF32";
				return "";
			}
			IL_009d:
			bytes = sHA256CryptoServiceProvider.ComputeHash(bytes);
			stringBuilder = new StringBuilder();
			array = bytes;
			foreach (byte b in array)
			{
				stringBuilder.Append(b.ToString("x2").ToLower());
			}
			result = stringBuilder.ToString();
			Error = "";
			return result;
		}
	}

	public static string SHA256(byte[] input)
	{
		SHA256CryptoServiceProvider sHA256CryptoServiceProvider = new SHA256CryptoServiceProvider();
		input = sHA256CryptoServiceProvider.ComputeHash(input);
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array = input;
		foreach (byte b in array)
		{
			stringBuilder.Append(b.ToString("x2").ToLower());
		}
		return stringBuilder.ToString();
	}

	public static string SHA384(string input)
	{
		SHA384CryptoServiceProvider sHA384CryptoServiceProvider = new SHA384CryptoServiceProvider();
		byte[] bytes = Encoding.UTF8.GetBytes(input);
		bytes = sHA384CryptoServiceProvider.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array = bytes;
		foreach (byte b in array)
		{
			stringBuilder.Append(b.ToString("x2").ToLower());
		}
		return stringBuilder.ToString();
	}

	public static string SHA384(string input, string inputEncoding)
	{
		SHA384CryptoServiceProvider sHA384CryptoServiceProvider = new SHA384CryptoServiceProvider();
		byte[] bytes;
		StringBuilder stringBuilder;
		byte[] array;
		switch (inputEncoding)
		{
		case "UTF7":
			bytes = Encoding.UTF7.GetBytes(input);
			goto IL_009d;
		case "UTF32":
			bytes = Encoding.UTF32.GetBytes(input);
			goto IL_009d;
		case "Unicode":
			bytes = Encoding.Unicode.GetBytes(input);
			goto IL_009d;
		case "ASCII":
			bytes = Encoding.ASCII.GetBytes(input);
			goto IL_009d;
		case "UTF8":
			bytes = Encoding.UTF8.GetBytes(input);
			goto IL_009d;
		default:
			{
				return "";
			}
			IL_009d:
			bytes = sHA384CryptoServiceProvider.ComputeHash(bytes);
			stringBuilder = new StringBuilder();
			array = bytes;
			foreach (byte b in array)
			{
				stringBuilder.Append(b.ToString("x2").ToLower());
			}
			return stringBuilder.ToString();
		}
	}

	public static string SHA384(string input, string inputEncoding, out string Error)
	{
		SHA384CryptoServiceProvider sHA384CryptoServiceProvider = new SHA384CryptoServiceProvider();
		byte[] bytes;
		StringBuilder stringBuilder;
		byte[] array;
		string result;
		switch (inputEncoding)
		{
		case "UTF7":
			bytes = Encoding.UTF7.GetBytes(input);
			goto IL_009d;
		case "UTF32":
			bytes = Encoding.UTF32.GetBytes(input);
			goto IL_009d;
		case "Unicode":
			bytes = Encoding.Unicode.GetBytes(input);
			goto IL_009d;
		case "ASCII":
			bytes = Encoding.ASCII.GetBytes(input);
			goto IL_009d;
		case "UTF8":
			bytes = Encoding.UTF8.GetBytes(input);
			goto IL_009d;
		default:
			{
				Error = "inputEncoding: ASCII Unicode UTF7 UTF8 UTF32";
				return "";
			}
			IL_009d:
			bytes = sHA384CryptoServiceProvider.ComputeHash(bytes);
			stringBuilder = new StringBuilder();
			array = bytes;
			foreach (byte b in array)
			{
				stringBuilder.Append(b.ToString("x2").ToLower());
			}
			result = stringBuilder.ToString();
			Error = "";
			return result;
		}
	}

	public static string SHA384(byte[] input)
	{
		SHA384CryptoServiceProvider sHA384CryptoServiceProvider = new SHA384CryptoServiceProvider();
		input = sHA384CryptoServiceProvider.ComputeHash(input);
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array = input;
		foreach (byte b in array)
		{
			stringBuilder.Append(b.ToString("x2").ToLower());
		}
		return stringBuilder.ToString();
	}

	public static string SHA512(string input)
	{
		SHA512CryptoServiceProvider sHA512CryptoServiceProvider = new SHA512CryptoServiceProvider();
		byte[] bytes = Encoding.UTF8.GetBytes(input);
		bytes = sHA512CryptoServiceProvider.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array = bytes;
		foreach (byte b in array)
		{
			stringBuilder.Append(b.ToString("x2").ToLower());
		}
		return stringBuilder.ToString();
	}

	public static string SHA512(string input, string inputEncoding)
	{
		SHA512CryptoServiceProvider sHA512CryptoServiceProvider = new SHA512CryptoServiceProvider();
		byte[] bytes;
		StringBuilder stringBuilder;
		byte[] array;
		switch (inputEncoding)
		{
		case "UTF7":
			bytes = Encoding.UTF7.GetBytes(input);
			goto IL_009d;
		case "UTF32":
			bytes = Encoding.UTF32.GetBytes(input);
			goto IL_009d;
		case "Unicode":
			bytes = Encoding.Unicode.GetBytes(input);
			goto IL_009d;
		case "ASCII":
			bytes = Encoding.ASCII.GetBytes(input);
			goto IL_009d;
		case "UTF8":
			bytes = Encoding.UTF8.GetBytes(input);
			goto IL_009d;
		default:
			{
				return "";
			}
			IL_009d:
			bytes = sHA512CryptoServiceProvider.ComputeHash(bytes);
			stringBuilder = new StringBuilder();
			array = bytes;
			foreach (byte b in array)
			{
				stringBuilder.Append(b.ToString("x2").ToLower());
			}
			return stringBuilder.ToString();
		}
	}

	public static string SHA512(string input, string inputEncoding, out string Error)
	{
		SHA512CryptoServiceProvider sHA512CryptoServiceProvider = new SHA512CryptoServiceProvider();
		byte[] bytes;
		StringBuilder stringBuilder;
		byte[] array;
		string result;
		switch (inputEncoding)
		{
		case "UTF7":
			bytes = Encoding.UTF7.GetBytes(input);
			goto IL_009d;
		case "UTF32":
			bytes = Encoding.UTF32.GetBytes(input);
			goto IL_009d;
		case "Unicode":
			bytes = Encoding.Unicode.GetBytes(input);
			goto IL_009d;
		case "ASCII":
			bytes = Encoding.ASCII.GetBytes(input);
			goto IL_009d;
		case "UTF8":
			bytes = Encoding.UTF8.GetBytes(input);
			goto IL_009d;
		default:
			{
				Error = "inputEncoding: ASCII Unicode UTF7 UTF8 UTF32";
				return "";
			}
			IL_009d:
			bytes = sHA512CryptoServiceProvider.ComputeHash(bytes);
			stringBuilder = new StringBuilder();
			array = bytes;
			foreach (byte b in array)
			{
				stringBuilder.Append(b.ToString("x2").ToLower());
			}
			result = stringBuilder.ToString();
			Error = "";
			return result;
		}
	}

	public static string SHA512(byte[] input)
	{
		SHA512CryptoServiceProvider sHA512CryptoServiceProvider = new SHA512CryptoServiceProvider();
		input = sHA512CryptoServiceProvider.ComputeHash(input);
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array = input;
		foreach (byte b in array)
		{
			stringBuilder.Append(b.ToString("x2").ToLower());
		}
		return stringBuilder.ToString();
	}
}
