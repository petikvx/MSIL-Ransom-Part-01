using System;
using System.IO;
using System.Text;
using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.Zip;

public class ZipNameTransform : INameTransform
{
	private static readonly char[] eJHuLSsjJBcXIkFHjhtdXIcOwIJE;

	private static readonly char[] mBokguMjXWpleZVMAdRPhgvTaRRM;

	private string nfNviOArKRmPSzWZTMwEsPKQJckB;

	public string TrimPrefix
	{
		get
		{
			return nfNviOArKRmPSzWZTMwEsPKQJckB;
		}
		set
		{
			nfNviOArKRmPSzWZTMwEsPKQJckB = value;
			if (nfNviOArKRmPSzWZTMwEsPKQJckB != null)
			{
				nfNviOArKRmPSzWZTMwEsPKQJckB = nfNviOArKRmPSzWZTMwEsPKQJckB.ToLower();
			}
		}
	}

	static ZipNameTransform()
	{
		char[] invalidPathChars = Path.GetInvalidPathChars();
		int num = invalidPathChars.Length + 2;
		mBokguMjXWpleZVMAdRPhgvTaRRM = new char[num];
		Array.Copy(invalidPathChars, 0, mBokguMjXWpleZVMAdRPhgvTaRRM, 0, invalidPathChars.Length);
		mBokguMjXWpleZVMAdRPhgvTaRRM[num - 1] = '*';
		mBokguMjXWpleZVMAdRPhgvTaRRM[num - 2] = '?';
		num = invalidPathChars.Length + 4;
		eJHuLSsjJBcXIkFHjhtdXIcOwIJE = new char[num];
		Array.Copy(invalidPathChars, 0, eJHuLSsjJBcXIkFHjhtdXIcOwIJE, 0, invalidPathChars.Length);
		eJHuLSsjJBcXIkFHjhtdXIcOwIJE[num - 1] = ':';
		eJHuLSsjJBcXIkFHjhtdXIcOwIJE[num - 2] = '\\';
		eJHuLSsjJBcXIkFHjhtdXIcOwIJE[num - 3] = '*';
		eJHuLSsjJBcXIkFHjhtdXIcOwIJE[num - 4] = '?';
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
		if (name != null && name.IndexOfAny(eJHuLSsjJBcXIkFHjhtdXIcOwIJE) < 0)
		{
			return name.IndexOf('/') != 0;
		}
		return false;
	}

	public static bool IsValidName(string name, bool relaxed)
	{
		bool result;
		if (!(result = name != null))
		{
			return result;
		}
		if (!relaxed)
		{
			if (name.IndexOfAny(eJHuLSsjJBcXIkFHjhtdXIcOwIJE) < 0)
			{
				return name.IndexOf('/') != 0;
			}
			return false;
		}
		return name.IndexOfAny(mBokguMjXWpleZVMAdRPhgvTaRRM) < 0;
	}

	private static string eNngNzNVVEHFjYlPrgvQblrbamac(string name, char replacement)
	{
		int num = name.IndexOfAny(eJHuLSsjJBcXIkFHjhtdXIcOwIJE);
		if (num >= 0)
		{
			StringBuilder stringBuilder = new StringBuilder(name);
			while (num >= 0)
			{
				stringBuilder[num] = replacement;
				num = ((num < name.Length) ? name.IndexOfAny(eJHuLSsjJBcXIkFHjhtdXIcOwIJE, num + 1) : (-1));
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
		if (nfNviOArKRmPSzWZTMwEsPKQJckB != null && text.IndexOf(nfNviOArKRmPSzWZTMwEsPKQJckB) == 0)
		{
			name = name.Substring(nfNviOArKRmPSzWZTMwEsPKQJckB.Length);
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
		name = eNngNzNVVEHFjYlPrgvQblrbamac(name, '_');
		return name;
	}
}
