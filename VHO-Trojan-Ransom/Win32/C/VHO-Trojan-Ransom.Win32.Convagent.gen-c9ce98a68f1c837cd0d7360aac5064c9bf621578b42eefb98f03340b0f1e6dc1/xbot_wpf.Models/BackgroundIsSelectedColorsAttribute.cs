using System;
using System.Runtime.CompilerServices;

namespace xbot_wpf.Models;

public class BackgroundIsSelectedColorsAttribute : Attribute
{
	[CompilerGenerated]
	private string string_0;

	public string BackgroundIsSelectedColors
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

	public BackgroundIsSelectedColorsAttribute(string backgroundIsSelectedColors)
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
		BackgroundIsSelectedColors = backgroundIsSelectedColors;
	}
}
