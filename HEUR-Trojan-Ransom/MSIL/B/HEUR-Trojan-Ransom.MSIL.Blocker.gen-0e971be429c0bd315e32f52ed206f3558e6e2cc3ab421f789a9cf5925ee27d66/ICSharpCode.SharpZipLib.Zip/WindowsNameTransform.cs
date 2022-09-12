using System;
using System.IO;
using System.Text;
using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.Zip;

public class WindowsNameTransform : INameTransform
{
	private string jOSPUxKItkCUeaErGpJvkpYBejBiA;

	private static readonly char[] nmRZOsWCvcyWXBTqoDoAnkXXmFKN;

	private const int kZjsgkjntcMbCgyOPchGLwNkxtnn = 260;

	private char YANRniKgKmsyCTSvqypuDFaUDQdS;

	private bool QKcqpjGXNfLRJIFyOLqBmCmvuPfD;

	public string BaseDirectory
	{
		get
		{
			return jOSPUxKItkCUeaErGpJvkpYBejBiA;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			jOSPUxKItkCUeaErGpJvkpYBejBiA = Path.GetFullPath(value);
		}
	}

	public char Replacement
	{
		get
		{
			return YANRniKgKmsyCTSvqypuDFaUDQdS;
		}
		set
		{
			for (int i = 0; i < nmRZOsWCvcyWXBTqoDoAnkXXmFKN.Length; i++)
			{
				if (nmRZOsWCvcyWXBTqoDoAnkXXmFKN[i] == value)
				{
					throw new ArgumentException("invalid path character");
				}
			}
			if (value == '\\' || value == '/')
			{
				throw new ArgumentException("invalid replacement character");
			}
			YANRniKgKmsyCTSvqypuDFaUDQdS = value;
		}
	}

	public bool TrimIncomingPaths
	{
		get
		{
			return QKcqpjGXNfLRJIFyOLqBmCmvuPfD;
		}
		set
		{
			QKcqpjGXNfLRJIFyOLqBmCmvuPfD = value;
		}
	}

	static WindowsNameTransform()
	{
		char[] invalidPathChars = Path.GetInvalidPathChars();
		int num = invalidPathChars.Length + 3;
		nmRZOsWCvcyWXBTqoDoAnkXXmFKN = new char[num];
		Array.Copy(invalidPathChars, 0, nmRZOsWCvcyWXBTqoDoAnkXXmFKN, 0, invalidPathChars.Length);
		nmRZOsWCvcyWXBTqoDoAnkXXmFKN[num - 1] = '*';
		nmRZOsWCvcyWXBTqoDoAnkXXmFKN[num - 2] = '?';
		nmRZOsWCvcyWXBTqoDoAnkXXmFKN[num - 2] = ':';
	}

	public WindowsNameTransform()
	{
		YANRniKgKmsyCTSvqypuDFaUDQdS = '_';
	}

	public WindowsNameTransform(string baseDirectory)
	{
		YANRniKgKmsyCTSvqypuDFaUDQdS = '_';
		if (baseDirectory == null)
		{
			throw new ArgumentNullException("baseDirectory", "Directory name is invalid");
		}
		BaseDirectory = baseDirectory;
	}

	public static bool IsValidName(string name)
	{
		return name != null && name.Length <= 260 && string.Compare(name, MakeValidName(name, '_')) == 0;
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
		num = name.IndexOfAny(nmRZOsWCvcyWXBTqoDoAnkXXmFKN);
		if (num >= 0)
		{
			StringBuilder stringBuilder = new StringBuilder(name);
			while (num >= 0)
			{
				stringBuilder[num] = replacement;
				num = ((num >= name.Length) ? (-1) : name.IndexOfAny(nmRZOsWCvcyWXBTqoDoAnkXXmFKN, num + 1));
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
		if (name == null)
		{
			name = string.Empty;
			return name;
		}
		name = MakeValidName(name, YANRniKgKmsyCTSvqypuDFaUDQdS);
		if (QKcqpjGXNfLRJIFyOLqBmCmvuPfD)
		{
			name = Path.GetFileName(name);
		}
		if (jOSPUxKItkCUeaErGpJvkpYBejBiA != null)
		{
			name = Path.Combine(jOSPUxKItkCUeaErGpJvkpYBejBiA, name);
		}
		return name;
	}
}
