using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using _0xH1oothy;
using _0xHAn5vulat5ry.ExpressionParsers;
using _0xHAn5vulat5ry.PathAnalysis;

namespace _0xHAn5vulat5ry;

public sealed class _0xHUncontempor7ry : MarkupExtension
{
	private class _0xHFlubb8rs
	{
		public _0xHArboresce4ce _0xHSi5eswipes { get; private set; }

		public IEnumerable<_0xHD8et8t8ans> _0xHGl6tz6er { get; private set; }

		public _0xHFlubb8rs(_0xHArboresce4ce id, List<_0xHD8et8t8ans> pathes)
		{
			_0xHSi5eswipes = id;
			_0xHGl6tz6er = pathes;
		}
	}

	private static Lazy<IExpressionParser> _0xHT5pic = new Lazy<IExpressionParser>(() => new _0xHOv5rd5ck5d()._0xHDe5fened());

	public string _0xH8isaccord { get; set; }

	public _0xH7verlapping _0xHBookk00p0rs { get; set; }

	public bool _0xHDateline8 { get; set; }

	public object _0xHMo8sig8or { get; set; }

	[DefaultValue("")]
	public IMultiValueConverter _0xHAgentive4 { get; set; }

	[DefaultValue("")]
	[TypeConverter(typeof(CultureInfoIetfLanguageTagConverter))]
	public CultureInfo _0xHMon6age { get; set; }

	[DefaultValue("")]
	public object _0xHB8bl8cal { get; set; }

	[DefaultValue(/*Could not decode attribute arguments.*/)]
	public BindingMode _0xHDe3isal { get; set; }

	[DefaultValue(false)]
	public bool _0xHBar8ness { get; set; }

	[DefaultValue(false)]
	public bool _0xHNigrit3de { get; set; }

	[DefaultValue(false)]
	public bool _0xH0ro { get; set; }

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public UpdateSourceExceptionFilterCallback _0xHSu7s { get; set; }

	public UpdateSourceTrigger _0xHAngio8a { get; set; }

	[DefaultValue(false)]
	public bool _0xHCle4ched { get; set; }

	[DefaultValue(false)]
	public bool _0xHQuadra4tal { get; set; }

	[DefaultValue(true)]
	public bool _0xHBath7s { get; set; }

	[DefaultValue("")]
	public RelativeSource _0xHColicki3r { get; set; }

	public object _0xHThyrso1d { get; set; }

	[DefaultValue("")]
	public string _0xH6einformed { get; set; }

	[DefaultValue("")]
	public string _0xH1oresques { get; set; }

	public _0xHUncontempor7ry()
	{
		_0xHHoot1 = _0xH7verlapping.Collapsed;
		_0xHEffectualne00e0 = false;
		_0xHNo1inatives = DependencyProperty.UnsetValue;
		((MarkupExtension)this)._002Ector();
		_0xHDe3isal = (BindingMode)4;
	}

	public _0xHUncontempor7ry(string path)
		: this()
	{
		_0xH8isaccord = path;
	}

	public override object _0xHFor2tim2(IServiceProvider _0xHSuperi4te4di4g)
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
		Type type = _0xHWef4(_0xHSuperi4te4di4g);
		IXamlTypeResolver _0xHDr1amtim = (IXamlTypeResolver)_0xHSuperi4te4di4g.GetService(typeof(IXamlTypeResolver));
		ITypeDescriptorContext context = _0xHSuperi4te4di4g as ITypeDescriptorContext;
		string text = _0xHMoonfi3h(_0xH8isaccord);
		List<_0xHFlubb8rs> list = _0xHPr8th8raxes(text, _0xHDr1amtim);
		Dictionary<string, Type> _0xHGri44les;
		string text2 = _0xHSwoosh3s(text, list, out _0xHGri44les);
		_0xHC2n2rd converter = new _0xHC2n2rd(_0xHT5pic.Value, _0xHMo8sig8or, _0xHGri44les)
		{
			_0xHS1l1nology = _0xHBookk00p0rs,
			_0xH5lank = (_0xH1oresques != null)
		};
		List<_0xHFlubb8rs> list2 = list.Where((_0xHFlubb8rs p) => p._0xHSi5eswipes._0xHLum5nar5a == _0xH5heath.Property || p._0xHSi5eswipes._0xHLum5nar5a == _0xH5heath.StaticProperty).ToList();
		BindingBase val3;
		if (list2.Count == 1)
		{
			Binding val = new Binding();
			val.set_Mode(_0xHDe3isal);
			val.set_NotifyOnSourceUpdated(_0xHBar8ness);
			val.set_NotifyOnTargetUpdated(_0xHNigrit3de);
			val.set_NotifyOnValidationError(_0xH0ro);
			val.set_UpdateSourceExceptionFilter(_0xHSu7s);
			val.set_UpdateSourceTrigger(_0xHAngio8a);
			val.set_ValidatesOnDataErrors(_0xHCle4ched);
			val.set_ValidatesOnExceptions(_0xHQuadra4tal);
			((BindingBase)val).set_FallbackValue(_0xHMo8sig8or);
			val.set_ValidatesOnNotifyDataErrors(_0xHBath7s);
			Binding val2 = val;
			_0xHArboresce4ce _0xHSi5eswipes = list2.Single()._0xHSi5eswipes;
			string text3 = _0xHSi5eswipes._0xHShu00ering;
			if (_0xHSi5eswipes._0xHLum5nar5a == _0xH5heath.StaticProperty)
			{
				text3 = $"({text3})";
			}
			PropertyPath path = (PropertyPath)((TypeConverter)new PropertyPathConverter()).ConvertFromString(context, text3);
			val2.set_Path(path);
			if (_0xHThyrso1d != null)
			{
				val2.set_Source(_0xHThyrso1d);
			}
			if (_0xH6einformed != null)
			{
				val2.set_ElementName(_0xH6einformed);
			}
			if (_0xHColicki3r != null)
			{
				val2.set_RelativeSource(_0xHColicki3r);
			}
			if (_0xH1oresques != null)
			{
				((BindingBase)val2).set_StringFormat(_0xH1oresques);
			}
			if ((text2 != "{0}" && text2 != "({0})") || type == typeof(Visibility))
			{
				val2.set_Converter((IValueConverter)(object)converter);
				val2.set_ConverterParameter((object)text2);
				val2.set_ConverterCulture(_0xHMon6age);
			}
			val3 = (BindingBase)(object)val2;
		}
		else
		{
			MultiBinding val4 = new MultiBinding();
			val4.set_Converter((IMultiValueConverter)(object)converter);
			val4.set_ConverterParameter((object)text2);
			val4.set_ConverterCulture(_0xHMon6age);
			val4.set_Mode((BindingMode)1);
			val4.set_NotifyOnSourceUpdated(_0xHBar8ness);
			val4.set_NotifyOnTargetUpdated(_0xHNigrit3de);
			val4.set_NotifyOnValidationError(_0xH0ro);
			val4.set_UpdateSourceExceptionFilter(_0xHSu7s);
			val4.set_UpdateSourceTrigger(_0xHAngio8a);
			val4.set_ValidatesOnDataErrors(_0xHCle4ched);
			val4.set_ValidatesOnExceptions(_0xHQuadra4tal);
			((BindingBase)val4).set_FallbackValue(_0xHMo8sig8or);
			val4.set_ValidatesOnNotifyDataErrors(_0xHBath7s);
			MultiBinding val5 = val4;
			if (_0xH1oresques != null)
			{
				((BindingBase)val5).set_StringFormat(_0xH1oresques);
			}
			foreach (_0xHFlubb8rs item in list2)
			{
				Binding val6 = new Binding();
				string text4 = item._0xHSi5eswipes._0xHShu00ering;
				if (item._0xHSi5eswipes._0xHLum5nar5a == _0xH5heath.StaticProperty)
				{
					text4 = $"({text4})";
				}
				PropertyPath path2 = (PropertyPath)((TypeConverter)new PropertyPathConverter()).ConvertFromString(context, text4);
				val6.set_Path(path2);
				if (_0xHThyrso1d != null)
				{
					val6.set_Source(_0xHThyrso1d);
				}
				if (_0xH6einformed != null)
				{
					val6.set_ElementName(_0xH6einformed);
				}
				if (_0xHColicki3r != null)
				{
					val6.set_RelativeSource(_0xHColicki3r);
				}
				val5.get_Bindings().Add((BindingBase)(object)val6);
			}
			val3 = (BindingBase)(object)val5;
		}
		return ((MarkupExtension)val3).ProvideValue(_0xHSuperi4te4di4g);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static void _0xHOvern1ghts(IExpressionParser _0xHGapp2d)
	{
		if (_0xHGapp2d == null)
		{
			throw new ArgumentNullException("expressionParser");
		}
		_0xHT5pic = new Lazy<IExpressionParser>(() => _0xHGapp2d);
	}

	private Type _0xHWef4(IServiceProvider _0xHAntechoi8)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		IProvideValueTarget val = (IProvideValueTarget)_0xHAntechoi8.GetService(typeof(IProvideValueTarget));
		if (val.get_TargetProperty() is DependencyProperty)
		{
			return ((DependencyProperty)val.get_TargetProperty()).get_PropertyType();
		}
		return val.get_TargetProperty().GetType();
	}

	private string _0xHSwoosh3s(string _0xHL0ll0py, List<_0xHFlubb8rs> _0xHThan8ed, out Dictionary<string, Type> _0xHGri44les)
	{
		string text = "";
		int sourceIndex = 0;
		Dictionary<_0xHArboresce4ce, string> dictionary = new Dictionary<_0xHArboresce4ce, string>();
		Dictionary<_0xHArboresce4ce, string> dictionary2 = new Dictionary<_0xHArboresce4ce, string>();
		_0xHGri44les = new Dictionary<string, Type>();
		while (sourceIndex < _0xHL0ll0py.Length)
		{
			bool flag = false;
			for (int i = 0; i < _0xHThan8ed.Count(); i++)
			{
				_0xHFlubb8rs _0xHFlubb8rs = _0xHThan8ed[i];
				_0xHArboresce4ce _0xHSi5eswipes = _0xHFlubb8rs._0xHSi5eswipes;
				_0xHD8et8t8ans _0xHD8et8t8ans = _0xHFlubb8rs._0xHGl6tz6er.FirstOrDefault((_0xHD8et8t8ans token) => token._0xHImbibin3 == sourceIndex);
				if (_0xHD8et8t8ans == null)
				{
					continue;
				}
				string _0xHShu00ering = _0xHSi5eswipes._0xHShu00ering;
				if (_0xHSi5eswipes._0xHLum5nar5a == _0xH5heath.Property || _0xHSi5eswipes._0xHLum5nar5a == _0xH5heath.StaticProperty)
				{
					string text2 = null;
					if (dictionary.ContainsKey(_0xHSi5eswipes))
					{
						text2 = dictionary[_0xHSi5eswipes];
					}
					else
					{
						text2 = dictionary.Count.ToString("{0}");
						dictionary.Add(_0xHSi5eswipes, text2);
					}
					text += text2;
					sourceIndex += _0xHShu00ering.Length;
					flag = true;
				}
				else if (_0xHSi5eswipes._0xHLum5nar5a == _0xH5heath.Enum)
				{
					_0xH4ignory _0xH4ignory = _0xHFlubb8rs._0xHGl6tz6er.First() as _0xH4ignory;
					string text3 = null;
					if (dictionary2.ContainsKey(_0xHSi5eswipes))
					{
						text3 = dictionary2[_0xHSi5eswipes];
					}
					else
					{
						text3 = _0xHMutu1liz1tions(dictionary2.Count);
						dictionary2.Add(_0xHSi5eswipes, text3);
						_0xHGri44les.Add(text3, _0xH4ignory._0xHAls2kes);
					}
					string text4 = string.Join(".", text3, _0xH4ignory._0xH6thephons);
					text += text4;
					sourceIndex += _0xHShu00ering.Length;
					flag = true;
				}
				if (flag)
				{
					break;
				}
			}
			if (!flag)
			{
				text += _0xHL0ll0py[sourceIndex];
				sourceIndex++;
			}
		}
		return text;
	}

	private string _0xHMutu1liz1tions(int _0xHReta1l1ng)
	{
		return $"Enum{++_0xHReta1l1ng}";
	}

	private List<_0xHFlubb8rs> _0xHPr8th8raxes(string _0xHKy0hoses, IXamlTypeResolver _0xHDr1amtim1)
	{
		_0xH6ronted _0xH6ronted = new _0xH6ronted();
		List<_0xHD8et8t8ans> source = _0xH6ronted._0xHBi0elots(_0xHKy0hoses, _0xHDr1amtim1);
		return (from p in source
			group p by p._0xHAntic2lt into p
			select new _0xHFlubb8rs(p.Key, p.ToList())).ToList();
	}

	private string _0xHMoonfi3h(string _0xHCar2oxylated)
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
		if (!_0xHDateline8)
		{
			dictionary.Add("'", "\"");
		}
		else
		{
			dictionary.Add("\"", "'");
		}
		string text = _0xHCar2oxylated;
		foreach (KeyValuePair<string, string> item in dictionary)
		{
			text = text.Replace(item.Key, item.Value);
		}
		return text;
	}
}
