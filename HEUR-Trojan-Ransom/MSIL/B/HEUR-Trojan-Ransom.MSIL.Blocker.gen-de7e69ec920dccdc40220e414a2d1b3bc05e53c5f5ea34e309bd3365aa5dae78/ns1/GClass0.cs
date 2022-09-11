using System;
using System.CodeDom.Compiler;
using System.Windows;
using ns4;

namespace ns1;

public class GClass0 : Application
{
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void method_0()
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
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[STAThread]
	public static void Main()
	{
		int num = 0;
		do
		{
			if (num == 1)
			{
				new GClass0().method_0();
				num = 2;
			}
			if (num == 2)
			{
				GClass1.p_00243K6eD_X8();
				num = 3;
			}
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 3);
	}

	static GClass0()
	{
	}
}
