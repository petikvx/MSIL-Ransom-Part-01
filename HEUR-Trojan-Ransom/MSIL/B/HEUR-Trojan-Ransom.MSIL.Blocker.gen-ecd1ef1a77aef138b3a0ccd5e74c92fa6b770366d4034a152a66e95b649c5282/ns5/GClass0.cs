using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Markup;
using ns8;

namespace ns5;

public class GClass0 : Window, IComponentConnector
{
	[CompilerGenerated]
	private static int[] int_0;

	private static bool _contentLoaded;

	internal static int[] Int32_0
	{
		[CompilerGenerated]
		get
		{
			int num = 0;
			do
			{
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 1);
			return int_0;
		}
		[CompilerGenerated]
		set
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					int_0 = value;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}
	}

	public GClass0()
	{
		smethod_0();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public static void smethod_0()
	{
		int num = 0;
		do
		{
			if (num == 3)
			{
				_contentLoaded = true;
				num = 4;
			}
			if (num == 1)
			{
				Class5.smethod_0();
				num = 2;
			}
			if (num == 2)
			{
				if (_contentLoaded)
				{
					break;
				}
				num = 3;
			}
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 4);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num = 0;
		do
		{
			if (num == 1)
			{
				_contentLoaded = true;
				num = 2;
			}
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 2);
	}

	void IComponentConnector.InitializeComponent()
	{
		int num = 0;
		do
		{
			if (num == 1)
			{
				smethod_0();
				num = 2;
			}
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 2);
	}
}
