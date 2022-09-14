using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace NuGet.Common;

public static class lvwr71aXVK
{
	public struct _5StZ0Gwx9C
	{
		private readonly string TH2ezPknBf;

		private readonly bool mJEKRQEjef;

		public string wOghWFaVZy => TH2ezPknBf;

		public bool UNpkBj49fa => mJEKRQEjef;

		public _5StZ0Gwx9C(string path, bool isFile)
		{
			TH2ezPknBf = path;
			mJEKRQEjef = isFile;
		}
	}

	[CompilerGenerated]
	private sealed class _0vavgFz68e<T>
	{
		public Func<T, string> VMehnwGPfx;

		public IEnumerable<Regex> SZcQHgPPZg;

		internal bool jIWBDiYI6n(T M8HseAambw)
		{
			GToQ6UtOBr<T> @object = new GToQ6UtOBr<T>
			{
				path = this.getPath(M8HseAambw)
			};
			return this.filters.Any((Func<Regex, bool>)@object._003CGetMatches_003Eb__1);
		}
	}

	[CompilerGenerated]
	private sealed class GToQ6UtOBr<T>
	{
		public string cRuBGZUodh;

		internal bool _1fWM1vuesf(Regex WaM2eTFfQq)
		{
			return WaM2eTFfQq.IsMatch(this.path);
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _7PNxrQWDTd
	{
		public static readonly _7PNxrQWDTd MISq1cKVWw = new _7PNxrQWDTd();

		public static Func<_5StZ0Gwx9C, string> fv3T9DvTce;

		public static Func<string, _5StZ0Gwx9C> yGHio7y4Ov;

		public static Func<string, _5StZ0Gwx9C> nENLAIxLtD;

		internal string hj67teEGyD(_5StZ0Gwx9C Z8vUud6WHU)
		{
			return Z8vUud6WHU.wOghWFaVZy;
		}

		internal _5StZ0Gwx9C kWvhOC8rk9(string jjBfHUs215)
		{
			return new _5StZ0Gwx9C(jjBfHUs215, isFile: true);
		}

		internal _5StZ0Gwx9C IU2MPWlIOT(string _6bhmltSKJo)
		{
			return new _5StZ0Gwx9C(_6bhmltSKJo, isFile: false);
		}
	}

	[CompilerGenerated]
	private sealed class _62TbHrXhTg
	{
		public Regex TWFzOPyQQU;

		internal bool FA7XzPkkFH(string x9Fail5uEh)
		{
			return TWFzOPyQQU.IsMatch(x9Fail5uEh);
		}

		internal bool _5LF1sPfyXu(string gLpbqiuZPw)
		{
			if (TWFzOPyQQU.IsMatch(gLpbqiuZPw))
			{
				return _7W3V1jelwa(gLpbqiuZPw);
			}
			return false;
		}
	}

	public static IEnumerable<T> XJJU3J36Yp<T>(IEnumerable<T> AZBJngX3Qc, Func<T, string> KF1nZHD2W1, IEnumerable<string> leyKKX7hcw)
	{
		_0vavgFz68e<T> _0vavgFz68e = new _0vavgFz68e<T>();
		_0vavgFz68e.getPath = KF1nZHD2W1;
		_0vavgFz68e.filters = leyKKX7hcw.Select(b7DqWw58E4);
		return AZBJngX3Qc.Where((Func<T, bool>)_0vavgFz68e._003CGetMatches_003Eb__0);
	}

	public static void IrzhEaPU6z<T>(ICollection<T> IG618IxCXp, Func<T, string> HndAjpxhEJ, IEnumerable<string> PaodyEmU63)
	{
		dJacbiXPZr(IG618IxCXp, HndAjpxhEJ, PaodyEmU63);
	}

	public static IEnumerable<T> dJacbiXPZr<T>(ICollection<T> _1smmomHnJg, Func<T, string> epG1o4ScR5, IEnumerable<string> VEdPEhW0sg)
	{
		HashSet<T> hashSet = new HashSet<T>(XJJU3J36Yp(_1smmomHnJg, epG1o4ScR5, VEdPEhW0sg));
		IList<T> list = _1smmomHnJg.Where(hashSet.Contains).ToList();
		foreach (T item in list)
		{
			_1smmomHnJg.Remove(item);
		}
		return list;
	}

	public static string _5IoCpDosUk(string _6NFG6I3tnh, string OjRlyhrw24)
	{
		if (OjRlyhrw24.StartsWith("**", StringComparison.OrdinalIgnoreCase))
		{
			return OjRlyhrw24;
		}
		_6NFG6I3tnh = zv02g9DVyB(_6NFG6I3tnh, ref OjRlyhrw24);
		return Path.Combine(_6NFG6I3tnh, OjRlyhrw24);
	}

	private static Regex b7DqWw58E4(string uomk1GEybX)
	{
		string text = Regex.Escape(uomk1GEybX);
		text = ((Path.DirectorySeparatorChar != '/') ? text.Replace("/", "\\\\").Replace("\\.\\*\\*", "\\.[^\\\\.]*").Replace("\\*\\*\\\\", "(.+\\\\)*")
			.Replace("\\*\\*", ".*")
			.Replace("\\*", "[^\\\\]*(\\\\)?")
			.Replace("\\?", ".") : text.Replace("\\.\\*\\*", "\\.[^/.]*").Replace("\\*\\*/", "(.+/)*").Replace("\\*\\*", ".*")
			.Replace("\\*", "[^/]*(/)?")
			.Replace("\\?", "."));
		return new Regex("^" + text + "$", RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture);
	}

	public static IEnumerable<string> fkSmdtyQWl(string whTp7Kqe5c, string VQRU7jQcsY)
	{
		string _0ooTh0EcBM;
		return from Z8vUud6WHU in USyhugwRyJ(whTp7Kqe5c, VQRU7jQcsY, Aw6rOPg8yV: false, out _0ooTh0EcBM)
			select Z8vUud6WHU.wOghWFaVZy;
	}

	public static IEnumerable<_5StZ0Gwx9C> USyhugwRyJ(string IjlQlULXWS, string ZiopefbtFb, bool Aw6rOPg8yV, out string _0ooTh0EcBM)
	{
		bool flag = false;
		if (ZoYdYPfyHg(ZiopefbtFb))
		{
			string text = ZiopefbtFb;
			char directorySeparatorChar = Path.DirectorySeparatorChar;
			ZiopefbtFb = text + "**" + directorySeparatorChar + "*";
			flag = true;
		}
		IjlQlULXWS = zv02g9DVyB(IjlQlULXWS, ref ZiopefbtFb);
		_0ooTh0EcBM = UQqrgCsmTO(IjlQlULXWS, ZiopefbtFb);
		Regex TWFzOPyQQU = b7DqWw58E4(Path.Combine(IjlQlULXWS, ZiopefbtFb));
		SearchOption searchOption = SearchOption.AllDirectories;
		bool num = ZiopefbtFb.IndexOf("**", StringComparison.OrdinalIgnoreCase) != -1;
		bool flag2 = Enumerable.Contains(Path.GetDirectoryName(ZiopefbtFb), '*');
		if (!num && !flag2)
		{
			searchOption = SearchOption.TopDirectoryOnly;
		}
		IEnumerable<_5StZ0Gwx9C> enumerable = from x9Fail5uEh in Directory.GetFiles(_0ooTh0EcBM, "*.*", searchOption)
			where TWFzOPyQQU.IsMatch(x9Fail5uEh)
			select x9Fail5uEh into jjBfHUs215
			select new _5StZ0Gwx9C(jjBfHUs215, isFile: true);
		if (!Aw6rOPg8yV)
		{
			return enumerable;
		}
		IEnumerable<_5StZ0Gwx9C> enumerable2 = from gLpbqiuZPw in Directory.GetDirectories(_0ooTh0EcBM, "*.*", searchOption)
			where TWFzOPyQQU.IsMatch(gLpbqiuZPw) && _7W3V1jelwa(gLpbqiuZPw)
			select gLpbqiuZPw into _6bhmltSKJo
			select new _5StZ0Gwx9C(_6bhmltSKJo, isFile: false);
		if (flag && _7W3V1jelwa(_0ooTh0EcBM))
		{
			enumerable2 = enumerable2.Concat(new _5StZ0Gwx9C[1]
			{
				new _5StZ0Gwx9C(_0ooTh0EcBM, isFile: false)
			});
		}
		return enumerable.Concat(enumerable2);
	}

	internal static string UQqrgCsmTO(string slE6MhDYBg, string MWibinO3ya)
	{
		int num = MWibinO3ya.IndexOf('*');
		if (num == -1)
		{
			string directoryName = Path.GetDirectoryName(MWibinO3ya);
			return Path.Combine(slE6MhDYBg, directoryName);
		}
		int num2 = MWibinO3ya.LastIndexOf(Path.DirectorySeparatorChar, num);
		if (num2 == -1)
		{
			return slE6MhDYBg;
		}
		string path = MWibinO3ya.Substring(0, num2);
		return Path.Combine(slE6MhDYBg, path);
	}

	internal static string zv02g9DVyB(string LIC8YKc9qZ, ref string _4nu3OgKlCm)
	{
		string text = $"..{Path.DirectorySeparatorChar}";
		string text2 = $".{Path.DirectorySeparatorChar}";
		LIC8YKc9qZ = (string.IsNullOrEmpty(LIC8YKc9qZ) ? text2 : LIC8YKc9qZ);
		while (_4nu3OgKlCm.StartsWith(text, StringComparison.OrdinalIgnoreCase))
		{
			LIC8YKc9qZ = Path.Combine(LIC8YKc9qZ, text);
			_4nu3OgKlCm = _4nu3OgKlCm.Substring(text.Length);
		}
		return Path.GetFullPath(LIC8YKc9qZ);
	}

	public static bool bd3Jbtcsee(string M1HXbtwGbg)
	{
		return M1HXbtwGbg.IndexOf('*') != -1;
	}

	public static bool ZoYdYPfyHg(string xQzaCnUaJd)
	{
		if (xQzaCnUaJd != null && xQzaCnUaJd.Length > 1)
		{
			if (xQzaCnUaJd[xQzaCnUaJd.Length - 1] != Path.DirectorySeparatorChar)
			{
				return xQzaCnUaJd[xQzaCnUaJd.Length - 1] == Path.AltDirectorySeparatorChar;
			}
			return true;
		}
		return false;
	}

	private static bool _7W3V1jelwa(string gOGJXjHnac)
	{
		return !Directory.EnumerateFileSystemEntries(gOGJXjHnac).Any();
	}
}
