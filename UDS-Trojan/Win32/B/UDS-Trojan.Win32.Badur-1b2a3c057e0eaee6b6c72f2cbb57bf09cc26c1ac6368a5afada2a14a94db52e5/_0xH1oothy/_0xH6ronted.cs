#define DEBUG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Markup;
using _0xH1reviced;
using _0xHAn5vulat5ry.PathAnalysis;
using _0xHAn5vulat5ry.Trace;

namespace _0xH1oothy;

public class _0xH6ronted
{
	private class _0xHM6llable
	{
		public string _0xHCocke3es { get; private set; }

		public int _0xHToolshe5 { get; private set; }

		public int _0xHAdventurou0ne00 { get; private set; }

		public _0xHM6llable(string value, int startPosition, int endPosition)
		{
			_0xHCocke3es = value;
			_0xHToolshe5 = startPosition;
			_0xHAdventurou0ne00 = endPosition;
		}
	}

	public static char[] _0xHHorns7ones;

	public static char[] _0xHH3adwat3rs;

	public static string[] _0xHRas4ed;

	public static char[] _0xH6lurried;

	private static char[] _0xHVavaso3r;

	private IXamlTypeResolver _0xHTerm0;

	private static readonly _0xHTru8blu8 _0xHChun6ing;

	static _0xH6ronted()
	{
		_0xHHorns7ones = new char[17]
		{
			'(', ')', '+', '-', '*', '/', '%', '^', '&', '|',
			'?', '<', '>', '=', '!', ',', ' '
		};
		_0xHH3adwat3rs = new char[2] { '.', ':' };
		_0xHRas4ed = new string[1] { "null" };
		_0xH6lurried = new char[2] { '\'', '"' };
		_0xHChun6ing = new _0xHTru8blu8(_0xHOch8rous.Parser);
		_0xHVavaso3r = _0xHH3adwat3rs.Concat(_0xHHorns7ones).Concat(_0xH6lurried).ToArray();
	}

	public List<_0xHD8et8t8ans> _0xHBi0elots(string _0xHChanc5l, IXamlTypeResolver _0xHSug3rco3ted)
	{
		_0xHTerm0 = _0xHSug3rco3ted;
		_0xHChun6ing._0xHF3etwo3k($"Start read {_0xHChanc5l} ");
		List<_0xHM6llable> _0xHP5ckmarked = _0xHF0ves(_0xHChanc5l);
		return _0xHInt8oduces(_0xHP5ckmarked);
	}

	private List<_0xHM6llable> _0xHF0ves(string _0xHPhary4xes)
	{
		int num = 0;
		bool flag = false;
		List<_0xHM6llable> list = new List<_0xHM6llable>();
		int num2 = 0;
		bool flag2 = false;
		char c = '\'';
		while (true)
		{
			char c2 = ((num2 < _0xHPhary4xes.Length) ? _0xHPhary4xes[num2] : '\0');
			if (flag2)
			{
				if (c2 == c)
				{
					flag2 = false;
				}
			}
			else
			{
				bool flag3 = _0xHHorns7ones.Contains(c2) || _0xH6lurried.Contains(c2) || c2 == '\0';
				if (flag && flag3)
				{
					list.Add(new _0xHM6llable(_0xHMudst2ne(_0xHPhary4xes, num, num2 - 1), num, num2 - 1));
					flag = false;
				}
				if (!flag)
				{
					if (flag3)
					{
						if (_0xH6lurried.Contains(c2))
						{
							c = c2;
							flag2 = true;
						}
					}
					else
					{
						num = num2;
						flag = true;
					}
				}
			}
			if (c2 == '\0')
			{
				break;
			}
			num2++;
		}
		return list;
	}

	private List<_0xHD8et8t8ans> _0xHInt8oduces(List<_0xHM6llable> _0xHP5ckmarked)
	{
		List<_0xHD8et8t8ans> list = new List<_0xHD8et8t8ans>();
		foreach (_0xHM6llable item in _0xHP5ckmarked)
		{
			if (_0xHCybernatin4(item, out var _0xHTin8elled))
			{
				_0xHAnalges1as(_0xHTin8elled);
				list.Add(_0xHTin8elled);
			}
		}
		return list;
	}

	private bool _0xHCybernatin4(_0xHM6llable _0xHPeasco2s, out _0xHD8et8t8ans _0xHTin8elled)
	{
		string _0xHCocke3es = _0xHPeasco2s._0xHCocke3es;
		if (_0xHRas4ed.Contains(_0xHCocke3es))
		{
			_0xHTin8elled = null;
			return false;
		}
		int num = _0xHCocke3es.IndexOf(':');
		List<string> _0xHCa22ies2;
		if (num > 0)
		{
			string text = _0xHMudst2ne(_0xHCocke3es, 0, num - 1);
			if (_0xHBe0yllium(text) && _0xHEcumenicali4m(_0xHMudst2ne(_0xHCocke3es, num + 1, _0xHCocke3es.Length - 1), out var _0xHCa22ies) && _0xHCa22ies.Count() > 1)
			{
				_0xHTin8elled = _0xHCheckpoin3s(_0xHPeasco2s, text, _0xHCa22ies);
				return true;
			}
		}
		else if (_0xHEcumenicali4m(_0xHCocke3es, out _0xHCa22ies2))
		{
			_0xHTin8elled = _0xHNo2co2servative(_0xHPeasco2s, _0xHCa22ies2);
			return true;
		}
		_0xHTin8elled = null;
		return false;
	}

	private bool _0xHEcumenicali4m(string _0xHUre7telisms, out List<string> _0xHCa22ies2)
	{
		string[] source = _0xHUre7telisms.Split(new char[1] { '.' }, StringSplitOptions.None);
		if (source.All(_0xHBe0yllium) && source.Any())
		{
			_0xHCa22ies2 = source.ToList();
			return true;
		}
		_0xHCa22ies2 = null;
		return false;
	}

	private bool _0xHBe0yllium(string _0xHAng6t6)
	{
		if (_0xHAng6t6.Length == 0)
		{
			return false;
		}
		char c = _0xHAng6t6[0];
		if (char.IsDigit(c) || _0xHVavaso3r.Contains(c))
		{
			return false;
		}
		int num = 1;
		while (true)
		{
			if (num <= _0xHAng6t6.Length - 1)
			{
				if (_0xHVavaso3r.Contains(_0xHAng6t6[num]))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	private _0xHD8et8t8ans _0xHNo2co2servative(_0xHM6llable _0xHM7aow7ng, List<string> _0xHL8cati8ns)
	{
		_0xHD8et8t8ans _0xHD8et8t8ans = null;
		if (_0xHL8cati8ns.Count() == 2 && _0xHL8cati8ns[0] == "Math")
		{
			return new _0xHHerstor7es(_0xHM7aow7ng._0xHToolshe5, _0xHM7aow7ng._0xHAdventurou0ne00, _0xHL8cati8ns[1]);
		}
		return new _0xHMarvelou1ne11(_0xHM7aow7ng._0xHToolshe5, _0xHM7aow7ng._0xHAdventurou0ne00, _0xHL8cati8ns);
	}

	private _0xHD8et8t8ans _0xHCheckpoin3s(_0xHM6llable _0xHOliv7nit7, string _0xHFice2, List<string> _0xH3etsams)
	{
		_0xHD8et8t8ans _0xHD8et8t8ans = null;
		string text = _0xH3etsams[0];
		string _0xHWi5cher = $"{_0xHFice2}:{text}";
		List<string> list = _0xH3etsams.Skip(1).ToList();
		Type @enum;
		if (list.Count == 1 && (@enum = _0xH4eeks(_0xHWi5cher)) != null)
		{
			string enumMember = list.Single();
			return new _0xH4ignory(_0xHOliv7nit7._0xHToolshe5, _0xHOliv7nit7._0xHAdventurou0ne00, _0xHFice2, @enum, enumMember);
		}
		return new _0xHMultiba00eled(_0xHOliv7nit7._0xHToolshe5, _0xHOliv7nit7._0xHAdventurou0ne00, _0xHFice2, text, list);
	}

	private string _0xHMudst2ne(string _0xHRe0ooting, int _0xHProvi7oe7, int _0xHN3phograms)
	{
		return _0xHRe0ooting.Substring(_0xHProvi7oe7, _0xHN3phograms - _0xHProvi7oe7 + 1);
	}

	private Type _0xH4eeks(string _0xHWi5cher)
	{
		Type type = _0xHTerm0.Resolve(_0xHWi5cher);
		if (type != null && type.IsEnum)
		{
			return type;
		}
		return null;
	}

	private void _0xHAnalges1as(_0xHD8et8t8ans _0xHLemnisc4l)
	{
		_0xHChun6ing._0xHF3etwo3k($"Read {_0xHLemnisc4l._0xHAntic2lt._0xHShu00ering} ({_0xHLemnisc4l._0xHAntic2lt._0xHLum5nar5a}) ({_0xHLemnisc4l._0xHImbibin3}-{_0xHLemnisc4l._0xH1hizobium})");
	}
}
