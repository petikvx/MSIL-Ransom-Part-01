using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Ate8poral;

public static class Co7euppance
{
	public struct Ve3etativeness
	{
		private readonly string Fri3ette;

		private readonly bool Si1uatio1s;

		public string Gona0ectomize0 => Fri3ette;

		public bool Boolean_0 => Si1uatio1s;

		public Ve3etativeness(string path, bool isFile)
		{
			Fri3ette = path;
			Si1uatio1s = isFile;
		}
	}

	public static IEnumerable<T> Mor7liz7tions<T>(IEnumerable<T> Poult0ies, Func<T, string> Ya4, IEnumerable<string> B2dnesses)
	{
		IEnumerable<Regex> filters = B2dnesses.Select(To8ny);
		return Poult0ies.Where(delegate(T item)
		{
			string path = Ya4(item);
			return filters.Any((Regex f) => f.IsMatch(path));
		});
	}

	public static void smethod_0<T>(ICollection<T> Cornrow1, Func<T, string> Incu2ating, IEnumerable<string> Te4mo4)
	{
		Ju2ant(Cornrow1, Incu2ating, Te4mo4);
	}

	public static IEnumerable<T> Ju2ant<T>(ICollection<T> Incongruousl8, Func<T, string> Polygr8phic, IEnumerable<string> Gran5)
	{
		HashSet<T> hashSet = new HashSet<T>(Mor7liz7tions(Incongruousl8, Polygr8phic, Gran5));
		IList<T> list = Incongruousl8.Where(hashSet.Contains).ToList();
		foreach (T item in list)
		{
			Incongruousl8.Remove(item);
		}
		return list;
	}

	public static string U4cork(string Em4gres, string Skald1c)
	{
		if (Skald1c.StartsWith("**", StringComparison.OrdinalIgnoreCase))
		{
			return Skald1c;
		}
		Em4gres = Scar7skin(Em4gres, ref Skald1c);
		return Path.Combine(Em4gres, Skald1c);
	}

	private static Regex To8ny(string Maus1lea)
	{
		string text = Regex.Escape(Maus1lea);
		text = ((Path.DirectorySeparatorChar != '/') ? text.Replace("/", "\\\\").Replace("\\.\\*\\*", "\\.[^\\\\.]*").Replace("\\*\\*\\\\", "(.+\\\\)*")
			.Replace("\\*\\*", ".*")
			.Replace("\\*", "[^\\\\]*(\\\\)?")
			.Replace("\\?", ".") : text.Replace("\\.\\*\\*", "\\.[^/.]*").Replace("\\*\\*/", "(.+/)*").Replace("\\*\\*", ".*")
			.Replace("\\*", "[^/]*(/)?")
			.Replace("\\?", "."));
		return new Regex("^" + text + "$", RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture);
	}

	public static IEnumerable<string> Cabre66as(string Mo1t, string H2ndic2p)
	{
		string P0emised;
		return from s in Spitb7lls(Mo1t, H2ndic2p, T5ickly: false, out P0emised)
			select s.Gona0ectomize0;
	}

	public static IEnumerable<Ve3etativeness> Spitb7lls(string Out5ears, string Expo0ited, bool T5ickly, out string P0emised)
	{
		bool flag = false;
		if (Muti8i8g(Expo0ited))
		{
			string text = Expo0ited;
			char directorySeparatorChar = Path.DirectorySeparatorChar;
			Expo0ited = text + "**" + directorySeparatorChar + "*";
			flag = true;
		}
		Out5ears = Scar7skin(Out5ears, ref Expo0ited);
		P0emised = smethod_1(Out5ears, Expo0ited);
		Regex searchRegex = To8ny(Path.Combine(Out5ears, Expo0ited));
		SearchOption searchOption = SearchOption.AllDirectories;
		bool num = Expo0ited.IndexOf("**", StringComparison.OrdinalIgnoreCase) != -1;
		bool flag2 = Enumerable.Contains(Path.GetDirectoryName(Expo0ited), '*');
		if (!num && !flag2)
		{
			searchOption = SearchOption.TopDirectoryOnly;
		}
		IEnumerable<Ve3etativeness> enumerable = from file in Directory.GetFiles(P0emised, "*.*", searchOption)
			where searchRegex.IsMatch(file)
			select new Ve3etativeness(file, isFile: true);
		if (!T5ickly)
		{
			return enumerable;
		}
		IEnumerable<Ve3etativeness> enumerable2 = from directory in Directory.GetDirectories(P0emised, "*.*", searchOption)
			where searchRegex.IsMatch(directory) && Mo5te(directory)
			select new Ve3etativeness(directory, isFile: false);
		if (flag && Mo5te(P0emised))
		{
			enumerable2 = enumerable2.Concat(new Ve3etativeness[1]
			{
				new Ve3etativeness(P0emised, isFile: false)
			});
		}
		return enumerable.Concat(enumerable2);
	}

	internal static string smethod_1(string Fris7ing, string Enthrallin4)
	{
		int num = Enthrallin4.IndexOf('*');
		if (num == -1)
		{
			string directoryName = Path.GetDirectoryName(Enthrallin4);
			return Path.Combine(Fris7ing, directoryName);
		}
		int num2 = Enthrallin4.LastIndexOf(Path.DirectorySeparatorChar, num);
		if (num2 == -1)
		{
			return Fris7ing;
		}
		string path = Enthrallin4.Substring(0, num2);
		return Path.Combine(Fris7ing, path);
	}

	internal static string Scar7skin(string Dechlorina2es, ref string Inti0ate)
	{
		string text = $"..{Path.DirectorySeparatorChar}";
		string text2 = $".{Path.DirectorySeparatorChar}";
		Dechlorina2es = (string.IsNullOrEmpty(Dechlorina2es) ? text2 : Dechlorina2es);
		while (Inti0ate.StartsWith(text, StringComparison.OrdinalIgnoreCase))
		{
			Dechlorina2es = Path.Combine(Dechlorina2es, text);
			Inti0ate = Inti0ate.Substring(text.Length);
		}
		return Path.GetFullPath(Dechlorina2es);
	}

	public static bool Deb7nks(string P3grees)
	{
		return P3grees.IndexOf('*') != -1;
	}

	public static bool Muti8i8g(string Syncre2ized)
	{
		if (Syncre2ized != null && Syncre2ized.Length > 1)
		{
			if (Syncre2ized[Syncre2ized.Length - 1] != Path.DirectorySeparatorChar)
			{
				return Syncre2ized[Syncre2ized.Length - 1] == Path.AltDirectorySeparatorChar;
			}
			return true;
		}
		return false;
	}

	private static bool Mo5te(string Rabbina5e)
	{
		return !Directory.EnumerateFileSystemEntries(Rabbina5e).Any();
	}
}
