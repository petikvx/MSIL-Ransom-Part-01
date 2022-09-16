using System;
using System.IO;

namespace Merryth8ught;

public class U3realized
{
	public static readonly string Ta7k = "project.json";

	public static readonly string Dua7 = ".project.json";

	public static readonly string Bo2kins = "project.lock.json";

	public static string Deepfr0zen(string Re66ers, string Ka1oes)
	{
		if (string.IsNullOrEmpty(Ka1oes))
		{
			throw new ArgumentException("projectName");
		}
		string text = Path.Combine(Re66ers, Nonnutr6t6ous(Ka1oes));
		if (!File.Exists(text))
		{
			text = Path.Combine(Re66ers, Ta7k);
		}
		return text;
	}

	public static string Nonnutr6t6ous(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			throw new ArgumentException("projectName");
		}
		return $"{string_0}.{Ta7k}";
	}

	public static string Ou4cooked(string K6lif6tes)
	{
		if (string.IsNullOrEmpty(K6lif6tes))
		{
			throw new ArgumentException("projectName");
		}
		return $"{K6lif6tes}.{Bo2kins}";
	}

	public static string Ther1ostat(string Double1s)
	{
		string text = null;
		string directoryName = Path.GetDirectoryName(Double1s);
		string text2 = Gn3stic(Double1s);
		if (text2 == null)
		{
			return Path.Combine(directoryName, Bo2kins);
		}
		string path = Ou4cooked(text2);
		return Path.Combine(directoryName, path);
	}

	public static string Gn3stic(string Ti7ing)
	{
		if (Ti7ing == null)
		{
			throw new ArgumentNullException("configPath");
		}
		string fileName = Path.GetFileName(Ti7ing);
		string result = null;
		if (fileName != null && fileName.EndsWith(Dua7, StringComparison.OrdinalIgnoreCase))
		{
			int length = fileName.Length - Ta7k.Length - 1;
			result = fileName.Substring(0, length);
		}
		return result;
	}

	public static bool smethod_0(string Encroac4)
	{
		if (Encroac4 == null)
		{
			throw new ArgumentNullException("configPath");
		}
		if (Encroac4.EndsWith(Ta7k, StringComparison.OrdinalIgnoreCase))
		{
			string text = null;
			try
			{
				text = Path.GetFileName(Encroac4);
			}
			catch
			{
				return false;
			}
			if (!string.Equals(Ta7k, text, StringComparison.OrdinalIgnoreCase))
			{
				return text.EndsWith(Dua7, StringComparison.OrdinalIgnoreCase);
			}
			return true;
		}
		return false;
	}
}
