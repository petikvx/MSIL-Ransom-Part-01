using System;
using System.IO;
using System.Text;
using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.Zip;

public class ZipNameTransform : INameTransform
{
	private static readonly char[] nmRZOsWCvcyWXBTqoDoAnkXXmFKN;

	private static readonly char[] rNopQLwfXrMTkuwzLtoaJoaMAkWM;

	private string uaPeTHiadgmEDNQjYMJVrKINRchMA;

	public string TrimPrefix
	{
		get
		{
			return uaPeTHiadgmEDNQjYMJVrKINRchMA;
		}
		set
		{
			uaPeTHiadgmEDNQjYMJVrKINRchMA = value;
			if (uaPeTHiadgmEDNQjYMJVrKINRchMA != null)
			{
				uaPeTHiadgmEDNQjYMJVrKINRchMA = uaPeTHiadgmEDNQjYMJVrKINRchMA.ToLower();
			}
		}
	}

	static ZipNameTransform()
	{
		char[] invalidPathChars = Path.GetInvalidPathChars();
		int num = invalidPathChars.Length + 2;
		rNopQLwfXrMTkuwzLtoaJoaMAkWM = new char[num];
		Array.Copy(invalidPathChars, 0, rNopQLwfXrMTkuwzLtoaJoaMAkWM, 0, invalidPathChars.Length);
		rNopQLwfXrMTkuwzLtoaJoaMAkWM[num - 1] = '*';
		rNopQLwfXrMTkuwzLtoaJoaMAkWM[num - 2] = '?';
		num = invalidPathChars.Length + 4;
		nmRZOsWCvcyWXBTqoDoAnkXXmFKN = new char[num];
		Array.Copy(invalidPathChars, 0, nmRZOsWCvcyWXBTqoDoAnkXXmFKN, 0, invalidPathChars.Length);
		nmRZOsWCvcyWXBTqoDoAnkXXmFKN[num - 1] = ':';
		nmRZOsWCvcyWXBTqoDoAnkXXmFKN[num - 2] = '\\';
		nmRZOsWCvcyWXBTqoDoAnkXXmFKN[num - 3] = '*';
		nmRZOsWCvcyWXBTqoDoAnkXXmFKN[num - 4] = '?';
	}

	public ZipNameTransform()
	{
	}

	public ZipNameTransform(string trimPrefix)
	{
		TrimPrefix = trimPrefix;
	}

	public static bool IsValidName(string name)
	{
		return name != null && name.IndexOfAny(nmRZOsWCvcyWXBTqoDoAnkXXmFKN) < 0 && name.IndexOf('/') != 0;
	}

	public static bool IsValidName(string name, bool relaxed)
	{
		bool result;
		if (result = name != null)
		{
			if (!relaxed)
			{
				return name.IndexOfAny(nmRZOsWCvcyWXBTqoDoAnkXXmFKN) < 0 && name.IndexOf('/') != 0;
			}
			return name.IndexOfAny(rNopQLwfXrMTkuwzLtoaJoaMAkWM) < 0;
		}
		return result;
	}

	private static string ddpFCilTVfGdLHtEkchOcBsauXrZB(string name, char replacement)
	{
		int num = name.IndexOfAny(nmRZOsWCvcyWXBTqoDoAnkXXmFKN);
		if (num >= 0)
		{
			StringBuilder stringBuilder = new StringBuilder(name);
			while (num >= 0)
			{
				stringBuilder[num] = replacement;
				num = ((num < name.Length) ? name.IndexOfAny(nmRZOsWCvcyWXBTqoDoAnkXXmFKN, num + 1) : (-1));
			}
			name = stringBuilder.ToString();
		}
		if (name.Length > 65535)
		{
			throw new PathTooLongException();
		}
		return name;
	}

	public string TransformDirectory(string name)
	{
		name = TransformFile(name);
		if (name.Length <= 0)
		{
			throw new ZipException("Cannot have an empty directory name");
		}
		if (!name.EndsWith("/"))
		{
			name += "/";
		}
		return name;
	}

	public string TransformFile(string name)
	{
		if (name == null)
		{
			name = string.Empty;
			return name;
		}
		string text = name.ToLower();
		if (uaPeTHiadgmEDNQjYMJVrKINRchMA != null && text.IndexOf(uaPeTHiadgmEDNQjYMJVrKINRchMA) == 0)
		{
			name = name.Substring(uaPeTHiadgmEDNQjYMJVrKINRchMA.Length);
		}
		name = name.Replace("\\", "/");
		name = WindowsPathUtils.DropPathRoot(name);
		while (name.Length > 0 && name[0] == '/')
		{
			name = name.Remove(0, 1);
		}
		while (name.Length > 0 && name[name.Length - 1] == '/')
		{
			name = name.Remove(name.Length - 1, 1);
		}
		for (int num = name.IndexOf("//"); num >= 0; num = name.IndexOf("//"))
		{
			name = name.Remove(num, 1);
		}
		name = ddpFCilTVfGdLHtEkchOcBsauXrZB(name, '_');
		return name;
	}
}
