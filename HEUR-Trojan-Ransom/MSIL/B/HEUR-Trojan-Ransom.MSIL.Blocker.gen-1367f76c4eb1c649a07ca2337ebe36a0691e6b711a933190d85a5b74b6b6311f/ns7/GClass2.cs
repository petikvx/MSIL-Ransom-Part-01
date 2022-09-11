using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using ns8;

namespace ns7;

public class GClass2 : Window
{
	[CompilerGenerated]
	private static int[] int_0;

	private static bool _contentLoaded;

	internal static int[] Int32_0
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		set
		{
			int_0 = value;
		}
	}

	public GClass2()
	{
		smethod_0();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public static void smethod_0()
	{
		try
		{
			Class4.smethod_0();
			if (!_contentLoaded)
			{
				_contentLoaded = true;
			}
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
	}

	internal static char smethod_1()
	{
		return 'o';
	}
}
