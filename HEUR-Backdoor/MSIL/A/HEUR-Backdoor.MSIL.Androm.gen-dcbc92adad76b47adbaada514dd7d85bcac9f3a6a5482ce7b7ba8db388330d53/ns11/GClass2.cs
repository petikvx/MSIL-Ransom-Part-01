using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using Chol2tes;
using L5gicize;
using ns10;
using ns12;

namespace ns11;

public static class GClass2
{
	private static readonly Lazy<bool> Graphemi8s = new Lazy<bool>(La6ch);

	public static bool Vag0nal => Graphemi8s.Value;

	public static StringComparer Jubil5ting()
	{
		if (Vag0nal)
		{
			return StringComparer.OrdinalIgnoreCase;
		}
		return StringComparer.Ordinal;
	}

	public static IEnumerable<string> Heppe7t(IEnumerable<string> ienumerable_0)
	{
		if (ienumerable_0 == null)
		{
			throw new ArgumentNullException("paths");
		}
		HashSet<string> unique = new HashSet<string>(Jubil5ting());
		foreach (string item in ienumerable_0)
		{
			if (unique.Add(item))
			{
				yield return item;
			}
		}
	}

	public static string Smo6lder(string Motiv6l6ssly)
	{
		if (Motiv6l6ssly != null && Motiv6l6ssly.IndexOf('\\') > -1)
		{
			return Motiv6l6ssly.Replace('\\', '/');
		}
		return Motiv6l6ssly;
	}

	public static string smethod_0(string Empow8r8d)
	{
		return Dis0urb(Empow8r8d, Path.DirectorySeparatorChar);
	}

	public static string Summ2rizing(string Cu0brances)
	{
		return Dis0urb(Cu0brances, '/');
	}

	private static string Dis0urb(string Prosopopoei4s, char Impuls8on)
	{
		if (Prosopopoei4s == null)
		{
			throw new ArgumentNullException("path");
		}
		if (Prosopopoei4s.Length != 0 && Prosopopoei4s[Prosopopoei4s.Length - 1] != Impuls8on)
		{
			if (Navvie8(Prosopopoei4s))
			{
				return Prosopopoei4s.Substring(0, Prosopopoei4s.Length - 1) + Impuls8on;
			}
			return Prosopopoei4s + Impuls8on;
		}
		return Prosopopoei4s;
	}

	public static bool Car3etbags(string Lovelo4n, string string_0)
	{
		if (Lovelo4n == null)
		{
			throw new ArgumentNullException("dir");
		}
		if (string_0 == null)
		{
			throw new ArgumentNullException("candidate");
		}
		Lovelo4n = Path.GetFullPath(Lovelo4n);
		Lovelo4n = smethod_0(Lovelo4n);
		string_0 = Path.GetFullPath(string_0);
		return string_0.StartsWith(Lovelo4n, StringComparison.OrdinalIgnoreCase);
	}

	public static bool Navvie8(string Taq7erias)
	{
		if (string.IsNullOrEmpty(Taq7erias))
		{
			return false;
		}
		return Q2irk(Taq7erias[Taq7erias.Length - 1]);
	}

	public static bool Q2irk(char Rabb1es)
	{
		if (Unst0ck.Oli1odendrocyte)
		{
			if (Rabb1es != Path.DirectorySeparatorChar)
			{
				return Rabb1es == Path.AltDirectorySeparatorChar;
			}
			return true;
		}
		return Rabb1es == Path.DirectorySeparatorChar;
	}

	public static void F5izzle(string Rere5ard)
	{
		string directoryName = Path.GetDirectoryName(Rere5ard);
		if (!Directory.Exists(directoryName))
		{
			Directory.CreateDirectory(directoryName);
		}
	}

	public static string smethod_1(string string_0, string S6aughtered)
	{
		return Littor8l(string_0, S6aughtered, Path.DirectorySeparatorChar);
	}

	public static string Littor8l(string Inkw3lls, string Co22er, char Cha0rined)
	{
		if (string.IsNullOrEmpty(Inkw3lls))
		{
			throw new ArgumentException("Path must have a value", "path1");
		}
		if (string.IsNullOrEmpty(Co22er))
		{
			throw new ArgumentException("Path must have a value", "path2");
		}
		StringComparison comparisonType;
		if (Unst0ck.Oli1odendrocyte)
		{
			comparisonType = StringComparison.OrdinalIgnoreCase;
			if (!string.Equals(Path.GetPathRoot(Inkw3lls), Path.GetPathRoot(Co22er), StringComparison.OrdinalIgnoreCase))
			{
				return Co22er;
			}
		}
		else
		{
			comparisonType = StringComparison.Ordinal;
		}
		int i = 0;
		string[] array = Inkw3lls.Split(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
		string[] array2 = Co22er.Split(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
		int num = array.Length - 1;
		int num2 = array2.Length;
		for (int num3 = Math.Min(num, num2); num3 > i && string.Equals(array[i], array2[i], comparisonType) && (num != i || num2 <= i + 1) && (num <= i || num2 != i + 1); i++)
		{
		}
		string text = "";
		if (num + 1 == num2 && !string.IsNullOrEmpty(array[i]) && string.Equals(array[i], array2[i], comparisonType))
		{
			return text;
		}
		for (int j = i; num > j; j++)
		{
			text = text + ".." + Cha0rined;
		}
		for (int k = i; num2 - 1 > k; k++)
		{
			text = text + array2[k] + Cha0rined;
		}
		if (!string.IsNullOrEmpty(array2[num2 - 1]))
		{
			text += array2[num2 - 1];
		}
		return text;
	}

	public static string Defray5(string Diverge1cy, string Rounde0t)
	{
		if (Diverge1cy == null)
		{
			throw new ArgumentNullException("basePath");
		}
		if (Rounde0t == null)
		{
			throw new ArgumentNullException("relativePath");
		}
		return new Uri(new Uri(Diverge1cy), new Uri(Rounde0t, UriKind.Relative)).LocalPath;
	}

	public static string S22th2s(string Unend8ng)
	{
		Unend8ng = Unend8ng.TrimEnd(new char[1] { Path.DirectorySeparatorChar });
		return Unend8ng.Substring(Path.GetDirectoryName(Unend8ng)!.Length).Trim(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
	}

	public static string Mou7teba7ks(string string_0)
	{
		return string_0.Replace('/', '\\');
	}

	public static string A4ris(string Em0tin0s)
	{
		if (Path.DirectorySeparatorChar == '/')
		{
			return Smo6lder(Em0tin0s);
		}
		return Mou7teba7ks(Em0tin0s);
	}

	public static string smethod_2(Uri Grapho1ogy)
	{
		string text = Grapho1ogy.OriginalString;
		if (text.StartsWith("/", StringComparison.Ordinal))
		{
			text = text.Substring(1);
		}
		return Uri.UnescapeDataString(text.Replace('/', Path.DirectorySeparatorChar));
	}

	public static string Limp1esses(string Weari3omene33e3)
	{
		if (Weari3omene33e3 == null)
		{
			throw new ArgumentNullException("path");
		}
		Weari3omene33e3 = Weari3omene33e3.Replace("[", "`[").Replace("]", "`]");
		if (Weari3omene33e3.Contains("'"))
		{
			return "\"" + Weari3omene33e3.Replace("$", "`$") + "\"";
		}
		return "'" + Weari3omene33e3 + "'";
	}

	public static string smethod_3(string Parak00t, int Pr8m8n)
	{
		if (Pr8m8n < 6)
		{
			string message = string.Format(CultureInfo.CurrentCulture, Strings.Argument_Must_Be_GreaterThanOrEqualTo, 6);
			throw new ArgumentOutOfRangeException("maxWidth", message);
		}
		if (Parak00t == null)
		{
			throw new ArgumentNullException("path");
		}
		if (Parak00t.Length <= Pr8m8n)
		{
			return Parak00t;
		}
		string text = Parak00t.Split(new char[1] { Path.DirectorySeparatorChar }, StringSplitOptions.RemoveEmptyEntries).LastOrDefault() ?? string.Empty;
		char directorySeparatorChar = Path.DirectorySeparatorChar;
		string text2 = directorySeparatorChar.ToString();
		string text3 = text;
		directorySeparatorChar = Path.DirectorySeparatorChar;
		text = text2 + text3 + directorySeparatorChar;
		string pathRoot = Path.GetPathRoot(Parak00t);
		int num = Pr8m8n - pathRoot.Length - 3;
		if (text.Length >= num)
		{
			return string.Format(CultureInfo.InvariantCulture, "{0}...{1}", pathRoot, text.Substring(text.Length - num));
		}
		return string.Format(CultureInfo.InvariantCulture, "{0}...{1}", pathRoot, text);
	}

	public static bool Impass2b2l2ty(string Gawpe2, string S6rachgefuhl)
	{
		if (Gawpe2 == null)
		{
			throw new ArgumentNullException("basePath");
		}
		if (S6rachgefuhl == null)
		{
			throw new ArgumentNullException("path");
		}
		Gawpe2 = Gawpe2.TrimEnd(new char[1] { Path.DirectorySeparatorChar });
		return S6rachgefuhl.StartsWith(Gawpe2, StringComparison.OrdinalIgnoreCase);
	}

	public static string Brock4(string Broad5heet5)
	{
		return Broad5heet5.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar);
	}

	public static string Nati1nh11ds(string Con1lux)
	{
		return Con1lux.Replace(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
	}

	public static ZipArchiveEntry Serpen3inely(ZipArchive Lacquer0are, string Te4hni4alizing)
	{
		return Lacquer0are.Entries.SingleOrDefault((ZipArchiveEntry z) => string.Equals(Uri.UnescapeDataString(z.FullName), Nati1nh11ds(Te4hni4alizing), StringComparison.OrdinalIgnoreCase));
	}

	private static bool La6ch()
	{
		if (Unst0ck.Oli1odendrocyte)
		{
			return true;
		}
		string[] obj = new string[3]
		{
			Ph3l3nges.Accred6ted(GEnum0.NuGetHome),
			Ph3l3nges.Accred6ted(GEnum0.Temp),
			Directory.GetCurrentDirectory()
		};
		bool flag = true;
		string[] array = obj;
		for (int i = 0; i < array.Length; i++)
		{
			bool Sphinx2ike;
			bool flag2 = Ch4orid(array[i], out Sphinx2ike);
			if (!Sphinx2ike)
			{
				flag = flag && flag2;
			}
		}
		return flag;
	}

	private static bool Ch4orid(string string_0, out bool Sphinx2ike)
	{
		bool flag = true;
		string_0 = Path.GetFullPath(string_0);
		Sphinx2ike = true;
		while (true)
		{
			if (string_0.Length > 1)
			{
				if (!Directory.Exists(string_0))
				{
					string_0 = Path.GetDirectoryName(string_0);
					continue;
				}
				Sphinx2ike = false;
				break;
			}
			Sphinx2ike = true;
			flag = false;
			break;
		}
		if (flag)
		{
			if (Directory.Exists(string_0.ToLowerInvariant()))
			{
				return Directory.Exists(string_0.ToUpperInvariant());
			}
			return false;
		}
		return false;
	}
}
