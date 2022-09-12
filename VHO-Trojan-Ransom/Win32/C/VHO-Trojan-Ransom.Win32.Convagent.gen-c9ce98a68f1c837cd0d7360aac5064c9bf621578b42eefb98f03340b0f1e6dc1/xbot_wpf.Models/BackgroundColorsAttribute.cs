using System;
using System.Runtime.CompilerServices;

namespace xbot_wpf.Models;

public class BackgroundColorsAttribute : Attribute
{
	[CompilerGenerated]
	private string string_0;

	public string BackgroundColors
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		private set
		{
			string_0 = value;
		}
	}

	public BackgroundColorsAttribute(string backgroundColors)
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
		BackgroundColors = backgroundColors;
	}
}
