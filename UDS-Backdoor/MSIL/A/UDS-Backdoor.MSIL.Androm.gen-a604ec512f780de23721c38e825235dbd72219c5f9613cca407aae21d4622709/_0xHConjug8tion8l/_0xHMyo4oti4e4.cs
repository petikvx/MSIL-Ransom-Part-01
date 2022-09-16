using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using _0xH1nbowdlerized;
using _0xHConjug8tion8l.ExpressionParsers;
using _0xHConjug8tion8l.PathAnalysis;

namespace _0xHConjug8tion8l;

public sealed class _0xHMyo4oti4e4 : MarkupExtension
{
	private class _0xHEx1ortability
	{
		public _0xHWheel6arrowing _0xHBe6sprea6s { get; private set; }

		public IEnumerable<_0xHE6det6c> _0xHG2l2xes { get; private set; }

		public _0xHEx1ortability(_0xHWheel6arrowing id, List<_0xHE6det6c> pathes)
		{
			_0xHBe6sprea6s = id;
			_0xHG2l2xes = pathes;
		}
	}

	private static Lazy<IExpressionParser> _0xHSubae7ially = new Lazy<IExpressionParser>(() => new _0xHT5nsiliti5s()._0xHLa8encies());

	public string _0xHUnth1nk { get; set; }

	public _0xHPerman4anate _0xHP2aros { get; set; }

	public bool _0xH3uckhound { get; set; }

	public object _0xHHyperploidie3 { get; set; }

	[DefaultValue("")]
	public IMultiValueConverter _0xHBrighte5ers { get; set; }

	[TypeConverter(typeof(CultureInfoIetfLanguageTagConverter))]
	[DefaultValue("")]
	public CultureInfo _0xHUnde8heated { get; set; }

	[DefaultValue("")]
	public object _0xHT1as1l { get; set; }

	[DefaultValue(/*Could not decode attribute arguments.*/)]
	public BindingMode _0xHVe5biage { get; set; }

	[DefaultValue(false)]
	public bool _0xHOverf5r { get; set; }

	[DefaultValue(false)]
	public bool _0xHS3ftwares { get; set; }

	[DefaultValue(false)]
	public bool _0xH2himsy { get; set; }

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public UpdateSourceExceptionFilterCallback _0xHRee3tabli3hed { get; set; }

	public UpdateSourceTrigger _0xHU1ediospo1es { get; set; }

	[DefaultValue(false)]
	public bool _0xHCo5al5oot { get; set; }

	[DefaultValue(false)]
	public bool _0xHSecularization8 { get; set; }

	[DefaultValue(true)]
	public bool _0xHOutb0gs { get; set; }

	[DefaultValue("")]
	public RelativeSource _0xHBla8 { get; set; }

	public object _0xHAn1idraf1 { get; set; }

	[DefaultValue("")]
	public string _0xHRamparte3 { get; set; }

	[DefaultValue("")]
	public string _0xH4anorama { get; set; }

	public _0xHMyo4oti4e4()
	{
		_0xHB1bbed = _0xHPerman4anate.Collapsed;
		_0xHComparat0v0st = false;
		_0xHG2mmat2s = DependencyProperty.UnsetValue;
		((MarkupExtension)this)._002Ector();
		_0xHVe5biage = (BindingMode)4;
	}

	public _0xHMyo4oti4e4(string path)
		: this()
	{
		_0xHUnth1nk = path;
	}

	public override object _0xHSub7imed(IServiceProvider _0xHArs6nid6)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected O, but got Unknown
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected O, but got Unknown
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected O, but got Unknown
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected O, but got Unknown
		Type type = _0xHSto8er(_0xHArs6nid6);
		IXamlTypeResolver _0xHDye = (IXamlTypeResolver)_0xHArs6nid6.GetService(typeof(IXamlTypeResolver));
		ITypeDescriptorContext context = _0xHArs6nid6 as ITypeDescriptorContext;
		string text = _0xHO6icide(_0xHUnth1nk);
		List<_0xHEx1ortability> list = _0xHVi6idness(text, _0xHDye);
		Dictionary<string, Type> _0xHHypercalce0ias;
		string text2 = _0xH3iliolate(text, list, out _0xHHypercalce0ias);
		_0xHPo7tions converter = new _0xHPo7tions(_0xHSubae7ially.Value, _0xHHyperploidie3, _0xHHypercalce0ias)
		{
			_0xHJass8d = _0xHP2aros,
			_0xHF5eshly = (_0xH4anorama != null)
		};
		List<_0xHEx1ortability> list2 = list.Where((_0xHEx1ortability p) => p._0xHBe6sprea6s._0xHA3oid == _0xHFlocculato0.Property || p._0xHBe6sprea6s._0xHA3oid == _0xHFlocculato0.StaticProperty).ToList();
		BindingBase val3;
		if (list2.Count == 1)
		{
			Binding val = new Binding();
			val.set_Mode(_0xHVe5biage);
			val.set_NotifyOnSourceUpdated(_0xHOverf5r);
			val.set_NotifyOnTargetUpdated(_0xHS3ftwares);
			val.set_NotifyOnValidationError(_0xH2himsy);
			val.set_UpdateSourceExceptionFilter(_0xHRee3tabli3hed);
			val.set_UpdateSourceTrigger(_0xHU1ediospo1es);
			val.set_ValidatesOnDataErrors(_0xHCo5al5oot);
			val.set_ValidatesOnExceptions(_0xHSecularization8);
			((BindingBase)val).set_FallbackValue(_0xHHyperploidie3);
			val.set_ValidatesOnNotifyDataErrors(_0xHOutb0gs);
			Binding val2 = val;
			_0xHWheel6arrowing _0xHBe6sprea6s = list2.Single()._0xHBe6sprea6s;
			string text3 = _0xHBe6sprea6s._0xHCl7ssic;
			if (_0xHBe6sprea6s._0xHA3oid == _0xHFlocculato0.StaticProperty)
			{
				text3 = $"({text3})";
			}
			PropertyPath path = (PropertyPath)((TypeConverter)new PropertyPathConverter()).ConvertFromString(context, text3);
			val2.set_Path(path);
			if (_0xHAn1idraf1 != null)
			{
				val2.set_Source(_0xHAn1idraf1);
			}
			if (_0xHRamparte3 != null)
			{
				val2.set_ElementName(_0xHRamparte3);
			}
			if (_0xHBla8 != null)
			{
				val2.set_RelativeSource(_0xHBla8);
			}
			if (_0xH4anorama != null)
			{
				((BindingBase)val2).set_StringFormat(_0xH4anorama);
			}
			if ((text2 != "{0}" && text2 != "({0})") || type == typeof(Visibility))
			{
				val2.set_Converter((IValueConverter)(object)converter);
				val2.set_ConverterParameter((object)text2);
				val2.set_ConverterCulture(_0xHUnde8heated);
			}
			val3 = (BindingBase)(object)val2;
		}
		else
		{
			MultiBinding val4 = new MultiBinding();
			val4.set_Converter((IMultiValueConverter)(object)converter);
			val4.set_ConverterParameter((object)text2);
			val4.set_ConverterCulture(_0xHUnde8heated);
			val4.set_Mode((BindingMode)1);
			val4.set_NotifyOnSourceUpdated(_0xHOverf5r);
			val4.set_NotifyOnTargetUpdated(_0xHS3ftwares);
			val4.set_NotifyOnValidationError(_0xH2himsy);
			val4.set_UpdateSourceExceptionFilter(_0xHRee3tabli3hed);
			val4.set_UpdateSourceTrigger(_0xHU1ediospo1es);
			val4.set_ValidatesOnDataErrors(_0xHCo5al5oot);
			val4.set_ValidatesOnExceptions(_0xHSecularization8);
			((BindingBase)val4).set_FallbackValue(_0xHHyperploidie3);
			val4.set_ValidatesOnNotifyDataErrors(_0xHOutb0gs);
			MultiBinding val5 = val4;
			if (_0xH4anorama != null)
			{
				((BindingBase)val5).set_StringFormat(_0xH4anorama);
			}
			foreach (_0xHEx1ortability item in list2)
			{
				Binding val6 = new Binding();
				string text4 = item._0xHBe6sprea6s._0xHCl7ssic;
				if (item._0xHBe6sprea6s._0xHA3oid == _0xHFlocculato0.StaticProperty)
				{
					text4 = $"({text4})";
				}
				PropertyPath path2 = (PropertyPath)((TypeConverter)new PropertyPathConverter()).ConvertFromString(context, text4);
				val6.set_Path(path2);
				if (_0xHAn1idraf1 != null)
				{
					val6.set_Source(_0xHAn1idraf1);
				}
				if (_0xHRamparte3 != null)
				{
					val6.set_ElementName(_0xHRamparte3);
				}
				if (_0xHBla8 != null)
				{
					val6.set_RelativeSource(_0xHBla8);
				}
				val5.get_Bindings().Add((BindingBase)(object)val6);
			}
			val3 = (BindingBase)(object)val5;
		}
		return ((MarkupExtension)val3).ProvideValue(_0xHArs6nid6);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static void _0xH8osmical(IExpressionParser _0xHAverse7esses)
	{
		if (_0xHAverse7esses == null)
		{
			throw new ArgumentNullException("expressionParser");
		}
		_0xHSubae7ially = new Lazy<IExpressionParser>(() => _0xHAverse7esses);
	}

	private Type _0xHSto8er(IServiceProvider _0xHCoh1siv1)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		IProvideValueTarget val = (IProvideValueTarget)_0xHCoh1siv1.GetService(typeof(IProvideValueTarget));
		if (val.get_TargetProperty() is DependencyProperty)
		{
			return ((DependencyProperty)val.get_TargetProperty()).get_PropertyType();
		}
		return val.get_TargetProperty().GetType();
	}

	private string _0xH3iliolate(string _0xHO6enta, List<_0xHEx1ortability> _0xHHel3con3a, out Dictionary<string, Type> _0xHHypercalce0ias)
	{
		string text = "";
		int sourceIndex = 0;
		Dictionary<_0xHWheel6arrowing, string> dictionary = new Dictionary<_0xHWheel6arrowing, string>();
		Dictionary<_0xHWheel6arrowing, string> dictionary2 = new Dictionary<_0xHWheel6arrowing, string>();
		_0xHHypercalce0ias = new Dictionary<string, Type>();
		while (sourceIndex < _0xHO6enta.Length)
		{
			bool flag = false;
			for (int i = 0; i < _0xHHel3con3a.Count(); i++)
			{
				_0xHEx1ortability _0xHEx1ortability = _0xHHel3con3a[i];
				_0xHWheel6arrowing _0xHBe6sprea6s = _0xHEx1ortability._0xHBe6sprea6s;
				_0xHE6det6c _0xHE6det6c = _0xHEx1ortability._0xHG2l2xes.FirstOrDefault((_0xHE6det6c token) => token._0xHN8ph8lin8 == sourceIndex);
				if (_0xHE6det6c == null)
				{
					continue;
				}
				string _0xHCl7ssic = _0xHBe6sprea6s._0xHCl7ssic;
				if (_0xHBe6sprea6s._0xHA3oid == _0xHFlocculato0.Property || _0xHBe6sprea6s._0xHA3oid == _0xHFlocculato0.StaticProperty)
				{
					string text2 = null;
					if (dictionary.ContainsKey(_0xHBe6sprea6s))
					{
						text2 = dictionary[_0xHBe6sprea6s];
					}
					else
					{
						text2 = dictionary.Count.ToString("{0}");
						dictionary.Add(_0xHBe6sprea6s, text2);
					}
					text += text2;
					sourceIndex += _0xHCl7ssic.Length;
					flag = true;
				}
				else if (_0xHBe6sprea6s._0xHA3oid == _0xHFlocculato0.Enum)
				{
					_0xH6hang _0xH6hang = _0xHEx1ortability._0xHG2l2xes.First() as _0xH6hang;
					string text3 = null;
					if (dictionary2.ContainsKey(_0xHBe6sprea6s))
					{
						text3 = dictionary2[_0xHBe6sprea6s];
					}
					else
					{
						text3 = _0xHLongevou7(dictionary2.Count);
						dictionary2.Add(_0xHBe6sprea6s, text3);
						_0xHHypercalce0ias.Add(text3, _0xH6hang._0xHA66i6tant6hip6);
					}
					string text4 = string.Join(".", text3, _0xH6hang._0xHS2ack);
					text += text4;
					sourceIndex += _0xHCl7ssic.Length;
					flag = true;
				}
				if (flag)
				{
					break;
				}
			}
			if (!flag)
			{
				text += _0xHO6enta[sourceIndex];
				sourceIndex++;
			}
		}
		return text;
	}

	private string _0xHLongevou7(int _0xHS0rubwoman)
	{
		return $"Enum{++_0xHS0rubwoman}";
	}

	private List<_0xHEx1ortability> _0xHVi6idness(string _0xHInterregnu5, IXamlTypeResolver _0xHDye0)
	{
		_0xHCush6oned _0xHCush6oned = new _0xHCush6oned();
		List<_0xHE6det6c> source = _0xHCush6oned._0xHHebra4zat4ons(_0xHInterregnu5, _0xHDye0);
		return (from p in source
			group p by p._0xHHy7ridoma into p
			select new _0xHEx1ortability(p.Key, p.ToList())).ToList();
	}

	private string _0xHO6icide(string _0xHS4ressing)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>
		{
			{ " and ", " && " },
			{ ")and ", ")&& " },
			{ " and(", " &&(" },
			{ ")and(", ")&&(" },
			{ " or ", " || " },
			{ ")or ", ")|| " },
			{ " or(", " ||(" },
			{ ")or(", ")||(" },
			{ " less ", " < " },
			{ ")less ", ")< " },
			{ " less(", " <(" },
			{ ")less(", ")<(" },
			{ " less=", " <=" },
			{ ")less=", ")<=" },
			{ "not ", "!" }
		};
		if (!_0xH3uckhound)
		{
			dictionary.Add("'", "\"");
		}
		else
		{
			dictionary.Add("\"", "'");
		}
		string text = _0xHS4ressing;
		foreach (KeyValuePair<string, string> item in dictionary)
		{
			text = text.Replace(item.Key, item.Value);
		}
		return text;
	}
}
