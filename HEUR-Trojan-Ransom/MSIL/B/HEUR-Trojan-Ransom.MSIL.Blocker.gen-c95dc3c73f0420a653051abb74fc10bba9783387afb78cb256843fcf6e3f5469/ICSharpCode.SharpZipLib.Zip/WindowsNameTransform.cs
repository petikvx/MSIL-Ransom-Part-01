using System;
using System.IO;
using System.Text;
using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.Zip;

public class WindowsNameTransform : INameTransform
{
	private string mWCycMuEpJggkLJIZZCKExPYrOQS;

	private static readonly char[] eJHuLSsjJBcXIkFHjhtdXIcOwIJE;

	private const int fojIUJLptVZhSJtbOqRdnuWhEZeH = 260;

	private char FURwjToKCPzIAqPSlGvBlxfHojgw;

	private bool DfeTCWmZPIWfLragXNWcUFDiUBoO;

	public string BaseDirectory
	{
		get
		{
			return mWCycMuEpJggkLJIZZCKExPYrOQS;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			mWCycMuEpJggkLJIZZCKExPYrOQS = Path.GetFullPath(value);
		}
	}

	public char Replacement
	{
		get
		{
			return FURwjToKCPzIAqPSlGvBlxfHojgw;
		}
		set
		{
			for (int i = 0; i < eJHuLSsjJBcXIkFHjhtdXIcOwIJE.Length; i++)
			{
				if (eJHuLSsjJBcXIkFHjhtdXIcOwIJE[i] == value)
				{
					throw new ArgumentException("invalid path character");
				}
			}
			if (value == '\\' || value == '/')
			{
				throw new ArgumentException("invalid replacement character");
			}
			FURwjToKCPzIAqPSlGvBlxfHojgw = value;
		}
	}

	public bool TrimIncomingPaths
	{
		get
		{
			return DfeTCWmZPIWfLragXNWcUFDiUBoO;
		}
		set
		{
			DfeTCWmZPIWfLragXNWcUFDiUBoO = value;
		}
	}

	static WindowsNameTransform()
	{
		char[] invalidPathChars = Path.GetInvalidPathChars();
		int num = invalidPathChars.Length + 3;
		eJHuLSsjJBcXIkFHjhtdXIcOwIJE = new char[num];
		Array.Copy(invalidPathChars, 0, eJHuLSsjJBcXIkFHjhtdXIcOwIJE, 0, invalidPathChars.Length);
		eJHuLSsjJBcXIkFHjhtdXIcOwIJE[num - 1] = '*';
		eJHuLSsjJBcXIkFHjhtdXIcOwIJE[num - 2] = '?';
		eJHuLSsjJBcXIkFHjhtdXIcOwIJE[num - 2] = ':';
	}

	public WindowsNameTransform()
	{
		FURwjToKCPzIAqPSlGvBlxfHojgw = '_';
	}

	public WindowsNameTransform(string baseDirectory)
	{
		FURwjToKCPzIAqPSlGvBlxfHojgw = '_';
		if (baseDirectory == null)
		{
			throw new ArgumentNullException("baseDirectory", "Directory name is invalid");
		}
		BaseDirectory = baseDirectory;
	}

	public static bool IsValidName(string name)
	{
		if (name != null && name.Length <= 260)
		{
			return string.Compare(name, MakeValidName(name, '_')) == 0;
		}
		return false;
	}

	public static string MakeValidName(string name, char replacement)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		name = WindowsPathUtils.DropPathRoot(name.Replace("/", "\\"));
		while (name.Length > 0 && name[0] == '\\')
		{
			name = name.Remove(0, 1);
		}
		while (name.Length > 0 && name[name.Length - 1] == '\\')
		{
			name = name.Remove(name.Length - 1, 1);
		}
		int num;
		for (num = name.IndexOf("\\\\"); num >= 0; num = name.IndexOf("\\\\"))
		{
			name = name.Remove(num, 1);
		}
		num = name.IndexOfAny(eJHuLSsjJBcXIkFHjhtdXIcOwIJE);
		if (num >= 0)
		{
			StringBuilder stringBuilder = new StringBuilder(name);
			while (num >= 0)
			{
				stringBuilder[num] = replacement;
				num = ((num >= name.Length) ? (-1) : name.IndexOfAny(eJHuLSsjJBcXIkFHjhtdXIcOwIJE, num + 1));
			}
			name = stringBuilder.ToString();
		}
		if (name.Length > 260)
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
		while (name.EndsWith("\\"))
		{
			name = name.Remove(name.Length - 1, 1);
		}
		return name;
	}

	public string TransformFile(string name)
	{
		if (name != null)
		{
			name = MakeValidName(name, FURwjToKCPzIAqPSlGvBlxfHojgw);
			if (DfeTCWmZPIWfLragXNWcUFDiUBoO)
			{
				name = Path.GetFileName(name);
			}
			if (mWCycMuEpJggkLJIZZCKExPYrOQS != null)
			{
				name = Path.Combine(mWCycMuEpJggkLJIZZCKExPYrOQS, name);
			}
			return name;
		}
		name = string.Empty;
		return name;
	}
}
