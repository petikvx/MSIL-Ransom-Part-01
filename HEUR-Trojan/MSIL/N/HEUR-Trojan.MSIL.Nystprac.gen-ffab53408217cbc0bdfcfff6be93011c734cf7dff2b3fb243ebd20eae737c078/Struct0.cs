using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

internal struct Struct0
{
	public string string_0;

	private Color color_0;

	[SpecialName]
	public string method_0()
	{
		return string_0;
	}

	[SpecialName]
	public Color method_1()
	{
		return color_0;
	}

	[SpecialName]
	public void method_2(Color color_1)
	{
		color_0 = color_1;
	}

	[SpecialName]
	public string method_3()
	{
		return "#" + color_0.R.ToString("X2", null) + color_0.G.ToString("X2", null) + color_0.B.ToString("X2", null);
	}

	[SpecialName]
	public void method_4(string string_1)
	{
		try
		{
			color_0 = ColorTranslator.FromHtml(string_1);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public Struct0(string string_1, Color color_1)
	{
		Class14.hYiyYvszsKHjE();
		this = default(Struct0);
		string_0 = string_1;
		color_0 = color_1;
	}
}
