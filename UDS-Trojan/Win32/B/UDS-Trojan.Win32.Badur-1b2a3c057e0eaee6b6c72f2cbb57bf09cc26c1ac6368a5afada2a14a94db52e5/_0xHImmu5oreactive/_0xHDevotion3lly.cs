using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using _0xHCo4sumership;
using _0xHDaphn6s;
using _0xHG6uziness;
using _0xHHypoderm7c;
using _0xHI3dustriously;
using _0xHMisd1er;
using _0xHPul5erize;
using _0xHPun6tate;
using _0xHSeltze6s;
using _0xHSigm1te;
using _0xHSnorke7er;
using _0xHTrammeler7;

namespace _0xHImmu5oreactive;

internal class _0xHDevotion3lly
{
	private class _0xHR8conqu8r8d
	{
		public string _0xHW5rmy;

		public ulong _0xHS7ochas7ic;

		public _0xHSlo8he8 _0xHTric7rboxylic;
	}

	private const int _0xHToothl1ss = 8;

	private Dictionary<int, string> _0xHWhi6kered;

	private Dictionary<int, string> _0xHT6uffe;

	private Dictionary<int, _0xHR8conqu8r8d> _0xHS0orkeled;

	private Dictionary<ulong, string> _0xHCro2er;

	private Dictionary<string, Type> _0xHSl3nd3r3r;

	private Dictionary<string, string> _0xHT0sti0r;

	private ulong _0xHDissipa6edly = 9223372036854775808uL;

	private StringBuilder _0xHLan1uorously;

	private StringBuilder _0xH6etags;

	private StringBuilder _0xHGumma4ous;

	private string _0xHTensin8;

	private ResourceManager _0xHG88gaws;

	private _0xHAquapla5er _0xHFerociou3ne33e3;

	private IList<string> _0xHWallar77s;

	private Dictionary<string, List<int>> _0xHPeytre5s;

	private string _0xHVersi8y;

	private int _0xH2efiltering;

	private List<int> _0xHRuff0er;

	public IList<string> _0xHL0ngu0ne => _0xHWallar77s;

	public _0xHDevotion3lly(string providerName, Guid providerGuid, string dllName, ResourceManager resources, _0xHAquapla5er flags)
	{
		_0xHTensin8 = providerName;
		_0xHFerociou3ne33e3 = flags;
		_0xHG88gaws = resources;
		_0xHLan1uorously = new StringBuilder();
		_0xH6etags = new StringBuilder();
		_0xHGumma4ous = new StringBuilder();
		_0xHWhi6kered = new Dictionary<int, string>();
		_0xHT0sti0r = new Dictionary<string, string>();
		_0xHWallar77s = new List<string>();
		_0xHPeytre5s = new Dictionary<string, List<int>>();
		_0xHLan1uorously.AppendLine("<instrumentationManifest xmlns=\"http://schemas.microsoft.com/win/2004/08/events\">");
		_0xHLan1uorously.AppendLine(" <instrumentation xmlns:xs=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:win=\"http://manifests.microsoft.com/win/2004/08/windows/events\">");
		_0xHLan1uorously.AppendLine("  <events xmlns=\"http://schemas.microsoft.com/win/2004/08/events\">");
		_0xHLan1uorously.Append("<provider name=\"").Append(providerName).Append("\" guid=\"{")
			.Append(providerGuid.ToString())
			.Append("}");
		if (dllName != null)
		{
			_0xHLan1uorously.Append("\" resourceFileName=\"").Append(dllName).Append("\" messageFileName=\"")
				.Append(dllName);
		}
		string value = providerName.Replace("-", "").Replace(".", "_");
		_0xHLan1uorously.Append("\" symbol=\"").Append(value);
		_0xHLan1uorously.Append("\">").AppendLine();
	}

	public void _0xH6nnumerably(string _0xHC6nfide, int _0xHReb7its)
	{
		if ((_0xHFerociou3ne33e3 & _0xHAquapla5er.Strict) != 0)
		{
			if (_0xHReb7its <= 10 || _0xHReb7its >= 239)
			{
				_0xHForr7t(_0xHA2eotropy._0xHSpon8or("EventSource_IllegalOpcodeValue", _0xHC6nfide, _0xHReb7its));
			}
			if (_0xHWhi6kered.TryGetValue(_0xHReb7its, out var value) && !_0xHC6nfide.Equals(value, StringComparison.Ordinal))
			{
				_0xHForr7t(_0xHA2eotropy._0xHSpon8or("EventSource_OpcodeCollision", _0xHC6nfide, value, _0xHReb7its));
			}
		}
		_0xHWhi6kered[_0xHReb7its] = _0xHC6nfide;
	}

	public void _0xHMobilization2(string _0xHCo2fessio2, int _0xHLif7l7ssn7ss)
	{
		if ((_0xHFerociou3ne33e3 & _0xHAquapla5er.Strict) != 0)
		{
			if (_0xHLif7l7ssn7ss <= 0 || _0xHLif7l7ssn7ss >= 65535)
			{
				_0xHForr7t(_0xHA2eotropy._0xHSpon8or("EventSource_IllegalTaskValue", _0xHCo2fessio2, _0xHLif7l7ssn7ss));
			}
			if (_0xHT6uffe != null && _0xHT6uffe.TryGetValue(_0xHLif7l7ssn7ss, out var value) && !_0xHCo2fessio2.Equals(value, StringComparison.Ordinal))
			{
				_0xHForr7t(_0xHA2eotropy._0xHSpon8or("EventSource_TaskCollision", _0xHCo2fessio2, value, _0xHLif7l7ssn7ss));
			}
		}
		if (_0xHT6uffe == null)
		{
			_0xHT6uffe = new Dictionary<int, string>();
		}
		_0xHT6uffe[_0xHLif7l7ssn7ss] = _0xHCo2fessio2;
	}

	public void _0xHMiddlin4ly(string _0xHClos7n7ss, ulong _0xHSe3es)
	{
		if ((_0xHSe3es & checked(_0xHSe3es - 1uL)) != 0L)
		{
			_0xHForr7t(_0xHA2eotropy._0xHSpon8or("EventSource_KeywordNeedPowerOfTwo", "0x" + _0xHSe3es.ToString("x", CultureInfo.CurrentCulture), _0xHClos7n7ss), _0xHHea4tie4: true);
		}
		if ((_0xHFerociou3ne33e3 & _0xHAquapla5er.Strict) != 0)
		{
			if (_0xHSe3es >= 17592186044416L && !_0xHClos7n7ss.StartsWith("Session", StringComparison.Ordinal))
			{
				_0xHForr7t(_0xHA2eotropy._0xHSpon8or("EventSource_IllegalKeywordsValue", _0xHClos7n7ss, "0x" + _0xHSe3es.ToString("x", CultureInfo.CurrentCulture)));
			}
			if (_0xHCro2er != null && _0xHCro2er.TryGetValue(_0xHSe3es, out var value) && !_0xHClos7n7ss.Equals(value, StringComparison.Ordinal))
			{
				_0xHForr7t(_0xHA2eotropy._0xHSpon8or("EventSource_KeywordCollision", _0xHClos7n7ss, value, "0x" + _0xHSe3es.ToString("x", CultureInfo.CurrentCulture)));
			}
		}
		if (_0xHCro2er == null)
		{
			_0xHCro2er = new Dictionary<ulong, string>();
		}
		_0xHCro2er[_0xHSe3es] = _0xHClos7n7ss;
	}

	public void _0xHE8ponent(string _0xHSn1ps, int _0xHInterpellat6ons, _0xHSlo8he8 _0xHFlatti5h)
	{
		_0xHSummar4ses _0xHSummar4ses = (_0xHSummar4ses)checked((byte)_0xHInterpellat6ons);
		if (_0xHInterpellat6ons >= 16 && _0xHInterpellat6ons <= 255)
		{
			if ((int)_0xHSummar4ses >= 16 && (int)_0xHSummar4ses <= 19 && _0xHFlatti5h != null && _0xH3lcerated(_0xHSummar4ses) != _0xHFlatti5h._0xHLandholder1)
			{
				_0xHForr7t(_0xHA2eotropy._0xHSpon8or("EventSource_ChannelTypeDoesNotMatchEventChannelValue", _0xHSn1ps, ((_0xHSummar4ses)checked((byte)_0xHInterpellat6ons)).ToString()));
			}
		}
		else
		{
			_0xHForr7t(_0xHA2eotropy._0xHSpon8or("EventSource_EventChannelOutOfRange", _0xHSn1ps, _0xHInterpellat6ons));
		}
		ulong _0xHS7ochas7ic = _0xH2uteo(_0xHSummar4ses);
		if (_0xHS0orkeled == null)
		{
			_0xHS0orkeled = new Dictionary<int, _0xHR8conqu8r8d>(4);
		}
		_0xHS0orkeled[_0xHInterpellat6ons] = new _0xHR8conqu8r8d
		{
			_0xHW5rmy = _0xHSn1ps,
			_0xHS7ochas7ic = _0xHS7ochas7ic,
			_0xHTric7rboxylic = _0xHFlatti5h
		};
	}

	private _0xHWave6ff _0xH3lcerated(_0xHSummar4ses _0xHCla22able)
	{
		return (_0xHWave6ff)checked(unchecked((int)_0xHCla22able) - 16 + 1);
	}

	private _0xHSlo8he8 _0xHGnawin1ly(_0xHSummar4ses _0xHKl5tzy)
	{
		_0xHSlo8he8 _0xHSlo8he = new _0xHSlo8he8();
		_0xHSlo8he._0xHLandholder1 = _0xH3lcerated(_0xHKl5tzy);
		if (_0xHSlo8he._0xHLandholder1 <= _0xHWave6ff.Operational)
		{
			_0xHSlo8he._0xHPr4d4signat4 = true;
		}
		return _0xHSlo8he;
	}

	public ulong[] _0xHWint8ri8st()
	{
		if (_0xHS0orkeled == null)
		{
			return new ulong[0];
		}
		int num = -1;
		foreach (int key in _0xHS0orkeled.Keys)
		{
			if (key > num)
			{
				num = key;
			}
		}
		ulong[] array = new ulong[checked(num + 1)];
		foreach (KeyValuePair<int, _0xHR8conqu8r8d> item in _0xHS0orkeled)
		{
			array[item.Key] = item.Value._0xHS7ochas7ic;
		}
		return array;
	}

	public void _0xHU2size(string _0xHUnh5tches, _0xHSkiff4ed _0xHHand3icking)
	{
		_0xHVersi8y = _0xHUnh5tches;
		_0xH2efiltering = 0;
		_0xHRuff0er = null;
		_0xH6etags.Append("  <event").Append(" value=\"").Append(_0xHHand3icking._0xHC0t0es)
			.Append("\"")
			.Append(" version=\"")
			.Append(_0xHHand3icking._0xHCoheire66)
			.Append("\"")
			.Append(" level=\"")
			.Append(_0xH5iping(_0xHHand3icking._0xHPas6eurizers))
			.Append("\"")
			.Append(" symbol=\"")
			.Append(_0xHUnh5tches)
			.Append("\"");
		_0xHDi22yda22y(_0xH6etags, "event", _0xHUnh5tches, _0xHHand3icking._0xHSpeedba11ed);
		if (_0xHHand3icking._0xHR0modify != _0xHSov8r8ignti8s.None)
		{
			_0xH6etags.Append(" keywords=\"").Append(_0xHOff7ut(checked((ulong)_0xHHand3icking._0xHR0modify), _0xHUnh5tches)).Append("\"");
		}
		if (_0xHHand3icking._0xHV1n1n1s != 0)
		{
			_0xH6etags.Append(" opcode=\"").Append(_0xHSemicircle8(_0xHHand3icking._0xHV1n1n1s, _0xHUnh5tches)).Append("\"");
		}
		if (_0xHHand3icking._0xHCha00elizes != 0)
		{
			_0xH6etags.Append(" task=\"").Append(_0xHLing4isticians(_0xHHand3icking._0xHCha00elizes, _0xHUnh5tches)).Append("\"");
		}
		if (_0xHHand3icking._0xHP6ddlebo6t != 0)
		{
			_0xH6etags.Append(" channel=\"").Append(_0xHM3sl3ghted(_0xHHand3icking._0xHP6ddlebo6t, _0xHUnh5tches, _0xHHand3icking._0xHSpeedba11ed)).Append("\"");
		}
	}

	public void _0xHTam3s(Type _0xHBoyco11ed, string _0xHP7nicle)
	{
		if (_0xH2efiltering == 0)
		{
			_0xHGumma4ous.Append("  <template tid=\"").Append(_0xHVersi8y).Append("Args\">")
				.AppendLine();
		}
		checked
		{
			if (_0xHBoyco11ed == typeof(byte[]))
			{
				if (_0xHRuff0er == null)
				{
					_0xHRuff0er = new List<int>(4);
				}
				_0xHRuff0er.Add(_0xH2efiltering);
				_0xH2efiltering++;
				_0xHGumma4ous.Append("   <data name=\"").Append(_0xHP7nicle).Append("Size\" inType=\"win:UInt32\"/>")
					.AppendLine();
			}
			_0xH2efiltering++;
			_0xHGumma4ous.Append("   <data name=\"").Append(_0xHP7nicle).Append("\" inType=\"")
				.Append(_0xHZeph2r(_0xHBoyco11ed))
				.Append("\"");
			if ((_0xHBoyco11ed.IsArray || _0xHBoyco11ed.IsPointer) && _0xHBoyco11ed.GetElementType() == typeof(byte))
			{
				_0xHGumma4ous.Append(" length=\"").Append(_0xHP7nicle).Append("Size\"");
			}
			if (_0xHBoyco11ed._0xH6igout() && Enum.GetUnderlyingType(_0xHBoyco11ed) != typeof(ulong) && Enum.GetUnderlyingType(_0xHBoyco11ed) != typeof(long))
			{
				_0xHGumma4ous.Append(" map=\"").Append(_0xHBoyco11ed.Name).Append("\"");
				if (_0xHSl3nd3r3r == null)
				{
					_0xHSl3nd3r3r = new Dictionary<string, Type>();
				}
				if (!_0xHSl3nd3r3r.ContainsKey(_0xHBoyco11ed.Name))
				{
					_0xHSl3nd3r3r.Add(_0xHBoyco11ed.Name, _0xHBoyco11ed);
				}
			}
			_0xHGumma4ous.Append("/>").AppendLine();
		}
	}

	public void _0xHDeclina6ions()
	{
		if (_0xH2efiltering > 0)
		{
			_0xHGumma4ous.Append("  </template>").AppendLine();
			_0xH6etags.Append(" template=\"").Append(_0xHVersi8y).Append("Args\"");
		}
		_0xH6etags.Append("/>").AppendLine();
		if (_0xHRuff0er != null)
		{
			_0xHPeytre5s[_0xHVersi8y] = _0xHRuff0er;
		}
		if (_0xHT0sti0r.TryGetValue("event_" + _0xHVersi8y, out var value))
		{
			value = _0xH4hiftlessness(value, _0xHVersi8y);
			_0xHT0sti0r["event_" + _0xHVersi8y] = value;
		}
		_0xHVersi8y = null;
		_0xH2efiltering = 0;
		_0xHRuff0er = null;
	}

	public ulong _0xH2uteo(_0xHSummar4ses _0xHMacroa77re7ates)
	{
		if (_0xHS0orkeled == null)
		{
			_0xHS0orkeled = new Dictionary<int, _0xHR8conqu8r8d>(4);
		}
		if (_0xHS0orkeled.Count == 8)
		{
			_0xHForr7t(_0xHA2eotropy._0xHSpon8or("EventSource_MaxChannelExceeded"));
		}
		ulong _0xHS7ochas7ic;
		if (!_0xHS0orkeled.TryGetValue((int)_0xHMacroa77re7ates, out var value))
		{
			_0xHS7ochas7ic = _0xHDissipa6edly;
			_0xHDissipa6edly >>= 1;
		}
		else
		{
			_0xHS7ochas7ic = value._0xHS7ochas7ic;
		}
		return _0xHS7ochas7ic;
	}

	public byte[] _0xHC6nstructi6ns()
	{
		string s = _0xHUltra5odern();
		return Encoding.UTF8.GetBytes(s);
	}

	public void _0xHForr7t(string _0xHD4sequ4l4br4um, bool _0xHHea4tie4 = false)
	{
		if ((_0xHFerociou3ne33e3 & _0xHAquapla5er.Strict) != 0)
		{
			_0xHWallar77s.Add(_0xHD4sequ4l4br4um);
		}
		else if (_0xHHea4tie4)
		{
			throw new ArgumentException(_0xHD4sequ4l4br4um);
		}
	}

	private string _0xHUltra5odern()
	{
		checked
		{
			if (_0xHS0orkeled != null)
			{
				_0xHLan1uorously.Append(" <channels>").AppendLine();
				List<KeyValuePair<int, _0xHR8conqu8r8d>> list = new List<KeyValuePair<int, _0xHR8conqu8r8d>>();
				foreach (KeyValuePair<int, _0xHR8conqu8r8d> item in _0xHS0orkeled)
				{
					list.Add(item);
				}
				list.Sort((KeyValuePair<int, _0xHR8conqu8r8d> _0xHPle1otrop1es, KeyValuePair<int, _0xHR8conqu8r8d> _0xHVa7opre77in7) => -Comparer<ulong>.Default.Compare(_0xHPle1otrop1es.Value._0xHS7ochas7ic, _0xHVa7opre77in7.Value._0xHS7ochas7ic));
				foreach (KeyValuePair<int, _0xHR8conqu8r8d> item2 in list)
				{
					int key = item2.Key;
					_0xHR8conqu8r8d value = item2.Value;
					string text = null;
					string text2 = "channel";
					bool flag = false;
					string text3 = null;
					if (value._0xHTric7rboxylic != null)
					{
						_0xHSlo8he8 _0xHTric7rboxylic = value._0xHTric7rboxylic;
						if (Enum.IsDefined(typeof(_0xHWave6ff), _0xHTric7rboxylic._0xHLandholder1))
						{
							text = _0xHTric7rboxylic._0xHLandholder1.ToString();
						}
						flag = _0xHTric7rboxylic._0xHPr4d4signat4;
					}
					if (text3 == null)
					{
						text3 = _0xHTensin8 + "/" + value._0xHW5rmy;
					}
					_0xHLan1uorously.Append("  <").Append(text2);
					_0xHLan1uorously.Append(" chid=\"").Append(value._0xHW5rmy).Append("\"");
					_0xHLan1uorously.Append(" name=\"").Append(text3).Append("\"");
					if (text2 == "channel")
					{
						_0xHDi22yda22y(_0xHLan1uorously, "channel", value._0xHW5rmy, null);
						_0xHLan1uorously.Append(" value=\"").Append(key).Append("\"");
						if (text != null)
						{
							_0xHLan1uorously.Append(" type=\"").Append(text).Append("\"");
						}
						_0xHLan1uorously.Append(" enabled=\"").Append(flag.ToString().ToLower()).Append("\"");
					}
					_0xHLan1uorously.Append("/>").AppendLine();
				}
				_0xHLan1uorously.Append(" </channels>").AppendLine();
			}
			if (_0xHT6uffe != null)
			{
				_0xHLan1uorously.Append(" <tasks>").AppendLine();
				List<int> list2 = new List<int>(_0xHT6uffe.Keys);
				list2.Sort();
				foreach (int item3 in list2)
				{
					_0xHLan1uorously.Append("  <task");
					_0xHUn6ersi6es(_0xHLan1uorously, "task", _0xHT6uffe[item3]);
					_0xHLan1uorously.Append(" value=\"").Append(item3).Append("\"/>")
						.AppendLine();
				}
				_0xHLan1uorously.Append(" </tasks>").AppendLine();
			}
			if (_0xHSl3nd3r3r != null)
			{
				_0xHLan1uorously.Append(" <maps>").AppendLine();
				foreach (Type value4 in _0xHSl3nd3r3r.Values)
				{
					bool flag2;
					string value2 = ((flag2 = _0xH2wooned._0xHCompa7atist(value4, typeof(FlagsAttribute), _0xHFerociou3ne33e3) != null) ? "bitMap" : "valueMap");
					_0xHLan1uorously.Append("  <").Append(value2).Append(" name=\"")
						.Append(value4.Name)
						.Append("\">")
						.AppendLine();
					FieldInfo[] fields = value4.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Public);
					FieldInfo[] array = fields;
					foreach (FieldInfo fieldInfo in array)
					{
						object rawConstantValue = fieldInfo.GetRawConstantValue();
						if (rawConstantValue == null)
						{
							continue;
						}
						long num;
						if (rawConstantValue is int)
						{
							num = (int)rawConstantValue;
						}
						else
						{
							if (!(rawConstantValue is long))
							{
								continue;
							}
							num = (long)rawConstantValue;
						}
						if (!flag2 || ((num & (num - 1L)) == 0L && num != 0L))
						{
							_0xHLan1uorously.Append("   <map value=\"0x").Append(num.ToString("x", CultureInfo.InvariantCulture)).Append("\"");
							_0xHDi22yda22y(_0xHLan1uorously, "map", value4.Name + "." + fieldInfo.Name, fieldInfo.Name);
							_0xHLan1uorously.Append("/>").AppendLine();
						}
					}
					_0xHLan1uorously.Append("  </").Append(value2).Append(">")
						.AppendLine();
				}
				_0xHLan1uorously.Append(" </maps>").AppendLine();
			}
			_0xHLan1uorously.Append(" <opcodes>").AppendLine();
			List<int> list3 = new List<int>(_0xHWhi6kered.Keys);
			list3.Sort();
			foreach (int item4 in list3)
			{
				_0xHLan1uorously.Append("  <opcode");
				_0xHUn6ersi6es(_0xHLan1uorously, "opcode", _0xHWhi6kered[item4]);
				_0xHLan1uorously.Append(" value=\"").Append(item4).Append("\"/>")
					.AppendLine();
			}
			_0xHLan1uorously.Append(" </opcodes>").AppendLine();
			if (_0xHCro2er != null)
			{
				_0xHLan1uorously.Append(" <keywords>").AppendLine();
				List<ulong> list4 = new List<ulong>(_0xHCro2er.Keys);
				list4.Sort();
				foreach (ulong item5 in list4)
				{
					_0xHLan1uorously.Append("  <keyword");
					_0xHUn6ersi6es(_0xHLan1uorously, "keyword", _0xHCro2er[item5]);
					_0xHLan1uorously.Append(" mask=\"0x").Append(item5.ToString("x", CultureInfo.InvariantCulture)).Append("\"/>")
						.AppendLine();
				}
				_0xHLan1uorously.Append(" </keywords>").AppendLine();
			}
			_0xHLan1uorously.Append(" <events>").AppendLine();
			_0xHLan1uorously.Append((object?)_0xH6etags);
			_0xHLan1uorously.Append(" </events>").AppendLine();
			_0xHLan1uorously.Append(" <templates>").AppendLine();
			if (_0xHGumma4ous.Length > 0)
			{
				_0xHLan1uorously.Append((object?)_0xHGumma4ous);
			}
			else
			{
				_0xHLan1uorously.Append("    <template tid=\"_empty\"></template>").AppendLine();
			}
			_0xHLan1uorously.Append(" </templates>").AppendLine();
			_0xHLan1uorously.Append("</provider>").AppendLine();
			_0xHLan1uorously.Append("</events>").AppendLine();
			_0xHLan1uorously.Append("</instrumentation>").AppendLine();
			_0xHLan1uorously.Append("<localization>").AppendLine();
			List<CultureInfo> list5 = null;
			if (_0xHG88gaws != null && (_0xHFerociou3ne33e3 & _0xHAquapla5er.AllCultures) != 0)
			{
				list5 = _0xHT8nmen(_0xHG88gaws);
			}
			else
			{
				list5 = new List<CultureInfo>();
				list5.Add(CultureInfo.CurrentUICulture);
			}
			List<string> list6 = new List<string>(_0xHT0sti0r.Keys);
			list6.Sort();
			foreach (CultureInfo item6 in list5)
			{
				_0xHLan1uorously.Append(" <resources culture=\"").Append(item6.Name).Append("\">")
					.AppendLine();
				_0xHLan1uorously.Append("  <stringTable>").AppendLine();
				foreach (string item7 in list6)
				{
					string value3 = _0xHRa6ionalis6(item7, item6, _0xHNonint1r1st: true);
					_0xHLan1uorously.Append("   <string id=\"").Append(item7).Append("\" value=\"")
						.Append(value3)
						.Append("\"/>")
						.AppendLine();
				}
				_0xHLan1uorously.Append("  </stringTable>").AppendLine();
				_0xHLan1uorously.Append(" </resources>").AppendLine();
			}
			_0xHLan1uorously.Append("</localization>").AppendLine();
			_0xHLan1uorously.AppendLine("</instrumentationManifest>");
			return _0xHLan1uorously.ToString();
		}
	}

	private void _0xHUn6ersi6es(StringBuilder _0xHTe8drils, string _0xHWaftag2s, string _0xHR0glaz0s)
	{
		_0xHTe8drils.Append(" name=\"").Append(_0xHR0glaz0s).Append("\"");
		_0xHDi22yda22y(_0xHLan1uorously, _0xHWaftag2s, _0xHR0glaz0s, _0xHR0glaz0s);
	}

	private void _0xHDi22yda22y(StringBuilder _0xHAdhe8ional, string _0xHS5erking, string _0xHPro8el, string _0xHNonstap2e)
	{
		string text = _0xHS5erking + "_" + _0xHPro8el;
		if (_0xHG88gaws != null)
		{
			string @string = _0xHG88gaws.GetString(text, CultureInfo.InvariantCulture);
			if (@string != null)
			{
				_0xHNonstap2e = @string;
			}
		}
		if (_0xHNonstap2e != null)
		{
			_0xHAdhe8ional.Append(" message=\"$(string.").Append(text).Append(")\"");
			if (_0xHT0sti0r.TryGetValue(text, out var value) && !value.Equals(_0xHNonstap2e))
			{
				_0xHForr7t(_0xHA2eotropy._0xHSpon8or("EventSource_DuplicateStringKey", text), _0xHHea4tie4: true);
			}
			else
			{
				_0xHT0sti0r[text] = _0xHNonstap2e;
			}
		}
	}

	internal string _0xHRa6ionalis6(string _0xHHi0pling, CultureInfo _0xHC6r6mels, bool _0xHNonint1r1st)
	{
		string value = null;
		if (_0xHG88gaws != null)
		{
			string @string = _0xHG88gaws.GetString(_0xHHi0pling, _0xHC6r6mels);
			if (@string != null)
			{
				value = @string;
				if (_0xHNonint1r1st && _0xHHi0pling.StartsWith("event_"))
				{
					string _0xHSalac4ty = _0xHHi0pling.Substring("event_".Length);
					value = _0xH4hiftlessness(value, _0xHSalac4ty);
				}
			}
		}
		if (_0xHNonint1r1st && value == null)
		{
			_0xHT0sti0r.TryGetValue(_0xHHi0pling, out value);
		}
		return value;
	}

	private static List<CultureInfo> _0xHT8nmen(ResourceManager _0xHJasp0ry)
	{
		List<CultureInfo> list = new List<CultureInfo>();
		CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
		foreach (CultureInfo cultureInfo in cultures)
		{
			if (_0xHJasp0ry.GetResourceSet(cultureInfo, createIfNotExists: true, tryParents: false) != null)
			{
				list.Add(cultureInfo);
			}
		}
		if (!list.Contains(CultureInfo.CurrentUICulture))
		{
			list.Insert(0, CultureInfo.CurrentUICulture);
		}
		return list;
	}

	private static string _0xH5iping(_0xHFire0ots _0xHCr8mpet)
	{
		return ((_0xHCr8mpet >= (_0xHFire0ots)16) ? "" : "win:") + _0xHCr8mpet;
	}

	private string _0xHM3sl3ghted(_0xHSummar4ses _0xHA6eneses, string _0xHS3amps, string _0xHQ5ench)
	{
		_0xHR8conqu8r8d value = null;
		if (_0xHS0orkeled == null || !_0xHS0orkeled.TryGetValue((int)_0xHA6eneses, out value))
		{
			if ((int)_0xHA6eneses < 16)
			{
				_0xHForr7t(_0xHA2eotropy._0xHSpon8or("EventSource_UndefinedChannel", _0xHA6eneses, _0xHS3amps));
			}
			if (_0xHS0orkeled == null)
			{
				_0xHS0orkeled = new Dictionary<int, _0xHR8conqu8r8d>(4);
			}
			string text = _0xHA6eneses.ToString();
			if (19 < (int)_0xHA6eneses)
			{
				text = "Channel" + text;
			}
			_0xHE8ponent(text, (int)_0xHA6eneses, _0xHGnawin1ly(_0xHA6eneses));
			if (!_0xHS0orkeled.TryGetValue((int)_0xHA6eneses, out value))
			{
				_0xHForr7t(_0xHA2eotropy._0xHSpon8or("EventSource_UndefinedChannel", _0xHA6eneses, _0xHS3amps));
			}
		}
		if (_0xHG88gaws != null && _0xHQ5ench == null)
		{
			_0xHQ5ench = _0xHG88gaws.GetString("event_" + _0xHS3amps, CultureInfo.InvariantCulture);
		}
		if (value._0xHTric7rboxylic._0xHLandholder1 == _0xHWave6ff.Admin && _0xHQ5ench == null)
		{
			_0xHForr7t(_0xHA2eotropy._0xHSpon8or("EventSource_EventWithAdminChannelMustHaveMessage", _0xHS3amps, value._0xHW5rmy));
		}
		return value._0xHW5rmy;
	}

	private string _0xHLing4isticians(_0xHIn1lows _0xHA55ogates, string _0xHMount7ineers)
	{
		if (_0xHA55ogates == _0xHIn1lows.None)
		{
			return "";
		}
		if (_0xHT6uffe == null)
		{
			_0xHT6uffe = new Dictionary<int, string>();
		}
		if (!_0xHT6uffe.TryGetValue((int)_0xHA55ogates, out var value))
		{
			return _0xHT6uffe[(int)_0xHA55ogates] = _0xHMount7ineers;
		}
		return value;
	}

	private string _0xHSemicircle8(_0xHK7z7tsky _0xHOp8imizes, string _0xHSpinni7s)
	{
		switch (_0xHOp8imizes)
		{
		default:
		{
			if (_0xHWhi6kered == null || !_0xHWhi6kered.TryGetValue((int)_0xHOp8imizes, out var value))
			{
				_0xHForr7t(_0xHA2eotropy._0xHSpon8or("EventSource_UndefinedOpcode", _0xHOp8imizes, _0xHSpinni7s), _0xHHea4tie4: true);
				return null;
			}
			return value;
		}
		case _0xHK7z7tsky.Receive:
			return "win:Receive";
		case _0xHK7z7tsky.Info:
			return "win:Info";
		case _0xHK7z7tsky.Start:
			return "win:Start";
		case _0xHK7z7tsky.Stop:
			return "win:Stop";
		case _0xHK7z7tsky.DataCollectionStart:
			return "win:DC_Start";
		case _0xHK7z7tsky.DataCollectionStop:
			return "win:DC_Stop";
		case _0xHK7z7tsky.Extension:
			return "win:Extension";
		case _0xHK7z7tsky.Reply:
			return "win:Reply";
		case _0xHK7z7tsky.Resume:
			return "win:Resume";
		case _0xHK7z7tsky.Suspend:
			return "win:Suspend";
		case _0xHK7z7tsky.Send:
			return "win:Send";
		}
	}

	private string _0xHOff7ut(ulong _0xHSpelli1g, string _0xH8edolent)
	{
		string text = "";
		for (ulong num = 1uL; num != 0L; num <<= 1)
		{
			if ((_0xHSpelli1g & num) != 0L)
			{
				string value = null;
				if ((_0xHCro2er == null || !_0xHCro2er.TryGetValue(num, out value)) && num >= 281474976710656L)
				{
					value = string.Empty;
				}
				if (value == null)
				{
					_0xHForr7t(_0xHA2eotropy._0xHSpon8or("EventSource_UndefinedKeyword", "0x" + num.ToString("x", CultureInfo.CurrentCulture), _0xH8edolent), _0xHHea4tie4: true);
					value = string.Empty;
				}
				if (text.Length != 0 && value.Length != 0)
				{
					text += " ";
				}
				text += value;
			}
		}
		return text;
	}

	private string _0xHZeph2r(Type _0xH8om)
	{
		if (_0xH8om._0xH6igout())
		{
			FieldInfo[] fields = _0xH8om.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			string text = _0xHZeph2r(fields[0].FieldType);
			return text.Replace("win:Int", "win:UInt");
		}
		switch (_0xH8om._0xHCann4bal4ze())
		{
		case TypeCode.Boolean:
			return "win:Boolean";
		case TypeCode.SByte:
			return "win:Int8";
		case TypeCode.Byte:
			return "win:UInt8";
		case TypeCode.Int16:
			return "win:Int16";
		case TypeCode.Char:
		case TypeCode.UInt16:
			return "win:UInt16";
		case TypeCode.Int32:
			return "win:Int32";
		case TypeCode.UInt32:
			return "win:UInt32";
		case TypeCode.Int64:
			return "win:Int64";
		case TypeCode.UInt64:
			return "win:UInt64";
		case TypeCode.Single:
			return "win:Float";
		case TypeCode.Double:
			return "win:Double";
		case TypeCode.DateTime:
			return "win:FILETIME";
		default:
			if (_0xH8om == typeof(Guid))
			{
				return "win:GUID";
			}
			if (_0xH8om == typeof(IntPtr))
			{
				return "win:Pointer";
			}
			if ((_0xH8om.IsArray || _0xH8om.IsPointer) && _0xH8om.GetElementType() == typeof(byte))
			{
				return "win:Binary";
			}
			_0xHForr7t(_0xHA2eotropy._0xHSpon8or("EventSource_UnsupportedEventTypeInManifest", _0xH8om.Name), _0xHHea4tie4: true);
			return string.Empty;
		case TypeCode.String:
			return "win:UnicodeString";
		}
	}

	private static void _0xHG2easie2(ref StringBuilder _0xHNorthbo8nd, string _0xHWyando88es, int _0xHCarpen1er, int _0xHFo0iest)
	{
		if (_0xHNorthbo8nd == null)
		{
			_0xHNorthbo8nd = new StringBuilder();
		}
		_0xHNorthbo8nd.Append(_0xHWyando88es, _0xHCarpen1er, _0xHFo0iest);
	}

	private string _0xH4hiftlessness(string _0xH6appie, string _0xHSalac4ty)
	{
		StringBuilder stringBuilder = null;
		int writtenSoFar = 0;
		int num = -1;
		int i = 0;
		checked
		{
			while (i < _0xH6appie.Length)
			{
				if (_0xH6appie[i] == '%')
				{
					_0xHG2easie2(ref stringBuilder, _0xH6appie, writtenSoFar, i - writtenSoFar);
					stringBuilder.Append("%%");
					i++;
					writtenSoFar = i;
				}
				else if (i < _0xH6appie.Length - 1 && ((_0xH6appie[i] == '{' && _0xH6appie[i + 1] == '{') || (_0xH6appie[i] == '}' && _0xH6appie[i + 1] == '}')))
				{
					_0xHG2easie2(ref stringBuilder, _0xH6appie, writtenSoFar, i - writtenSoFar);
					stringBuilder.Append(_0xH6appie[i]);
					i++;
					i++;
					writtenSoFar = i;
				}
				else if (_0xH6appie[i] == '{')
				{
					int num2 = i;
					i++;
					int num3 = 0;
					for (; i < _0xH6appie.Length && char.IsDigit(_0xH6appie[i]); i++)
					{
						num3 = num3 * 10 + unchecked((int)_0xH6appie[i]) - 48;
					}
					if (i < _0xH6appie.Length && _0xH6appie[i] == '}')
					{
						i++;
						_0xHG2easie2(ref stringBuilder, _0xH6appie, writtenSoFar, num2 - writtenSoFar);
						int value = _0xHEx0viate(num3, _0xHSalac4ty);
						stringBuilder.Append('%').Append(value);
						if (i < _0xH6appie.Length && _0xH6appie[i] == '!')
						{
							i++;
							stringBuilder.Append("%!");
						}
						writtenSoFar = i;
					}
					else
					{
						_0xHForr7t(_0xHA2eotropy._0xHSpon8or("EventSource_UnsupportedMessageProperty", _0xHSalac4ty, _0xH6appie));
					}
				}
				else if ((num = "&<>'\"\r\n\t".IndexOf(_0xH6appie[i])) >= 0)
				{
					string[] array = new string[8] { "&amp;", "&lt;", "&gt;", "&apos;", "&quot;", "%r", "%n", "%t" };
					Action<char, string> action = delegate(char ch, string escape)
					{
						_0xHG2easie2(ref stringBuilder, _0xH6appie, writtenSoFar, i - writtenSoFar);
						i++;
						stringBuilder.Append(escape);
						writtenSoFar = i;
					};
					action(_0xH6appie[i], array[num]);
				}
				else
				{
					i++;
				}
			}
			if (stringBuilder == null)
			{
				return _0xH6appie;
			}
			_0xHG2easie2(ref stringBuilder, _0xH6appie, writtenSoFar, i - writtenSoFar);
			return stringBuilder.ToString();
		}
	}

	private int _0xHEx0viate(int _0xHRehe6rses, string _0xH6eddler)
	{
		checked
		{
			if (_0xHPeytre5s.TryGetValue(_0xH6eddler, out var value))
			{
				foreach (int item in value)
				{
					if (_0xHRehe6rses >= item)
					{
						_0xHRehe6rses++;
						continue;
					}
					break;
				}
			}
			return _0xHRehe6rses + 1;
		}
	}

	[CompilerGenerated]
	private static int _0xHAu2lander2(KeyValuePair<int, _0xHR8conqu8r8d> _0xHPle1otrop1es, KeyValuePair<int, _0xHR8conqu8r8d> _0xHVa7opre77in7)
	{
		return checked(-Comparer<ulong>.Default.Compare(_0xHPle1otrop1es.Value._0xHS7ochas7ic, _0xHVa7opre77in7.Value._0xHS7ochas7ic));
	}
}
