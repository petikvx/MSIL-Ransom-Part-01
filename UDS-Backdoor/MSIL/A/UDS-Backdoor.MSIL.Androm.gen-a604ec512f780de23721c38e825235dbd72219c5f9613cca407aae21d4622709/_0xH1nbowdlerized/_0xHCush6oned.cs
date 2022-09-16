#define DEBUG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Markup;
using _0xHConjug8tion8l.PathAnalysis;
using _0xHConjug8tion8l.Trace;
using _0xHRightfulne33e3;

namespace _0xH1nbowdlerized;

public class _0xHCush6oned
{
	private class _0xHHo7esicknesses
	{
		public string _0xHSub2ermal { get; private set; }

		public int _0xHUvea8 { get; private set; }

		public int _0xHRacke8 { get; private set; }

		public _0xHHo7esicknesses(string value, int startPosition, int endPosition)
		{
			_0xHSub2ermal = value;
			_0xHUvea8 = startPosition;
			_0xHRacke8 = endPosition;
		}
	}

	public static char[] _0xHH2irspr2y;

	public static char[] _0xHRadica0e;

	public static string[] _0xHUn0iscipline0;

	public static char[] _0xHC2rr2b2rat2r;

	private static char[] _0xHScratc0er;

	private IXamlTypeResolver _0xHC0pels;

	private static readonly _0xHLit2ograp2ing _0xHC2ns2lati2ns;

	static _0xHCush6oned()
	{
		_0xHH2irspr2y = new char[17]
		{
			'(', ')', '+', '-', '*', '/', '%', '^', '&', '|',
			'?', '<', '>', '=', '!', ',', ' '
		};
		_0xHRadica0e = new char[2] { '.', ':' };
		_0xHUn0iscipline0 = new string[1] { "null" };
		_0xHC2rr2b2rat2r = new char[2] { '\'', '"' };
		_0xHC2ns2lati2ns = new _0xHLit2ograp2ing(_0xHCy4oly4ic.Parser);
		_0xHScratc0er = _0xHRadica0e.Concat(_0xHH2irspr2y).Concat(_0xHC2rr2b2rat2r).ToArray();
	}

	public List<_0xHE6det6c> _0xHHebra4zat4ons(string _0xHHolidayin1, IXamlTypeResolver _0xHSound7ox)
	{
		_0xHC0pels = _0xHSound7ox;
		_0xHC2ns2lati2ns._0xHFavis4($"Start read {_0xHHolidayin1} ");
		List<_0xHHo7esicknesses> _0xHS6ponifies = _0xHMicropla6kto6(_0xHHolidayin1);
		return _0xHNonre4ayable(_0xHS6ponifies);
	}

	private List<_0xHHo7esicknesses> _0xHMicropla6kto6(string _0xH7olones)
	{
		int num = 0;
		bool flag = false;
		List<_0xHHo7esicknesses> list = new List<_0xHHo7esicknesses>();
		int num2 = 0;
		bool flag2 = false;
		char c = '\'';
		while (true)
		{
			char c2 = ((num2 < _0xH7olones.Length) ? _0xH7olones[num2] : '\0');
			if (flag2)
			{
				if (c2 == c)
				{
					flag2 = false;
				}
			}
			else
			{
				bool flag3 = _0xHH2irspr2y.Contains(c2) || _0xHC2rr2b2rat2r.Contains(c2) || c2 == '\0';
				if (flag && flag3)
				{
					list.Add(new _0xHHo7esicknesses(_0xHUn0avering(_0xH7olones, num, num2 - 1), num, num2 - 1));
					flag = false;
				}
				if (!flag)
				{
					if (flag3)
					{
						if (_0xHC2rr2b2rat2r.Contains(c2))
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

	private List<_0xHE6det6c> _0xHNonre4ayable(List<_0xHHo7esicknesses> _0xHS6ponifies)
	{
		List<_0xHE6det6c> list = new List<_0xHE6det6c>();
		foreach (_0xHHo7esicknesses _0xHS6ponify in _0xHS6ponifies)
		{
			if (_0xHRewel4ing(_0xHS6ponify, out var _0xH3axonomic))
			{
				_0xHWirema6(_0xH3axonomic);
				list.Add(_0xH3axonomic);
			}
		}
		return list;
	}

	private bool _0xHRewel4ing(_0xHHo7esicknesses _0xHL5ngrels, out _0xHE6det6c _0xH3axonomic)
	{
		string _0xHSub2ermal = _0xHL5ngrels._0xHSub2ermal;
		if (_0xHUn0iscipline0.Contains(_0xHSub2ermal))
		{
			_0xH3axonomic = null;
			return false;
		}
		int num = _0xHSub2ermal.IndexOf(':');
		List<string> _0xHS4otters2;
		if (num > 0)
		{
			string text = _0xHUn0avering(_0xHSub2ermal, 0, num - 1);
			if (_0xH5mpulsions(text) && _0xHBr6stleta6l(_0xHUn0avering(_0xHSub2ermal, num + 1, _0xHSub2ermal.Length - 1), out var _0xHS4otters) && _0xHS4otters.Count() > 1)
			{
				_0xH3axonomic = _0xHUsher1ng(_0xHL5ngrels, text, _0xHS4otters);
				return true;
			}
		}
		else if (_0xHBr6stleta6l(_0xHSub2ermal, out _0xHS4otters2))
		{
			_0xH3axonomic = _0xHFarm7ife(_0xHL5ngrels, _0xHS4otters2);
			return true;
		}
		_0xH3axonomic = null;
		return false;
	}

	private bool _0xHBr6stleta6l(string _0xH4rackless, out List<string> _0xHS4otters)
	{
		string[] source = _0xH4rackless.Split(new char[1] { '.' }, StringSplitOptions.None);
		if (source.All(_0xH5mpulsions) && source.Any())
		{
			_0xHS4otters = source.ToList();
			return true;
		}
		_0xHS4otters = null;
		return false;
	}

	private bool _0xH5mpulsions(string _0xHInt8r8st)
	{
		if (_0xHInt8r8st.Length == 0)
		{
			return false;
		}
		char c = _0xHInt8r8st[0];
		if (char.IsDigit(c) || _0xHScratc0er.Contains(c))
		{
			return false;
		}
		int num = 1;
		while (true)
		{
			if (num <= _0xHInt8r8st.Length - 1)
			{
				if (_0xHScratc0er.Contains(_0xHInt8r8st[num]))
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

	private _0xHE6det6c _0xHFarm7ife(_0xHHo7esicknesses _0xHBathtu3s, List<string> _0xHDegr2dingly)
	{
		_0xHE6det6c _0xHE6det6c = null;
		if (_0xHDegr2dingly.Count() == 2 && _0xHDegr2dingly[0] == "Math")
		{
			return new _0xH5uthandled(_0xHBathtu3s._0xHUvea8, _0xHBathtu3s._0xHRacke8, _0xHDegr2dingly[1]);
		}
		return new _0xHM5thpr55fer(_0xHBathtu3s._0xHUvea8, _0xHBathtu3s._0xHRacke8, _0xHDegr2dingly);
	}

	private _0xHE6det6c _0xHUsher1ng(_0xHHo7esicknesses _0xHVoyeur7, string _0xHOverprogram6, List<string> _0xHLeg7t7mately)
	{
		_0xHE6det6c _0xHE6det6c = null;
		string text = _0xHLeg7t7mately[0];
		string _0xHRekeyboa2d = $"{_0xHOverprogram6}:{text}";
		List<string> list = _0xHLeg7t7mately.Skip(1).ToList();
		Type @enum;
		if (list.Count == 1 && (@enum = _0xHN5nirritants(_0xHRekeyboa2d)) != null)
		{
			string enumMember = list.Single();
			return new _0xH6hang(_0xHVoyeur7._0xHUvea8, _0xHVoyeur7._0xHRacke8, _0xHOverprogram6, @enum, enumMember);
		}
		return new _0xHDemol0t0on(_0xHVoyeur7._0xHUvea8, _0xHVoyeur7._0xHRacke8, _0xHOverprogram6, text, list);
	}

	private string _0xHUn0avering(string _0xHForti1y, int _0xHAn1igens, int _0xHCh1ri1ns)
	{
		return _0xHForti1y.Substring(_0xHAn1igens, _0xHCh1ri1ns - _0xHAn1igens + 1);
	}

	private Type _0xHN5nirritants(string _0xHRekeyboa2d)
	{
		Type type = _0xHC0pels.Resolve(_0xHRekeyboa2d);
		if (type != null && type.IsEnum)
		{
			return type;
		}
		return null;
	}

	private void _0xHWirema6(_0xHE6det6c _0xHInfallibl3)
	{
		_0xHC2ns2lati2ns._0xHFavis4($"Read {_0xHInfallibl3._0xHHy7ridoma._0xHCl7ssic} ({_0xHInfallibl3._0xHHy7ridoma._0xHA3oid}) ({_0xHInfallibl3._0xHN8ph8lin8}-{_0xHInfallibl3._0xHVali4ate4})");
	}
}
