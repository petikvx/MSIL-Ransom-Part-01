using System;
using System.Drawing;
using Microsoft.VisualBasic.CompilerServices;

namespace NoobCrypt2._0;

internal struct Bloom
{
	public string _Name;

	private Color _Value;

	public string Name => _Name;

	public Color Value
	{
		get
		{
			return _Value;
		}
		set
		{
			_Value = value;
		}
	}

	public string ValueHex
	{
		get
		{
			return "#" + _Value.R.ToString("X2", null) + _Value.G.ToString("X2", null) + _Value.B.ToString("X2", null);
		}
		set
		{
			try
			{
				_Value = ColorTranslator.FromHtml(value);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public Bloom(string name, Color value)
	{
		this = default(Bloom);
		_Name = name;
		_Value = value;
	}
}
