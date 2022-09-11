using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Calculator;

public class GClass0
{
	private double double_0 = 0.0;

	private string string_0 = "";

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private GClass0 gclass0_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private GClass0 gclass0_1;

	private GClass0 GClass0_0
	{
		[CompilerGenerated]
		get
		{
			return gclass0_0;
		}
		[CompilerGenerated]
		set
		{
			gclass0_0 = value;
		}
	}

	private GClass0 GClass0_1
	{
		[CompilerGenerated]
		get
		{
			return gclass0_1;
		}
		[CompilerGenerated]
		set
		{
			gclass0_1 = value;
		}
	}

	public GClass0(double double_1)
	{
		double_0 = double_1;
	}

	public GClass0(double double_1, string string_1)
		: this(double_1)
	{
		string_0 = string_1;
	}

	public GClass0 method_0(double double_1)
	{
		GClass0_0 = new GClass0(double_1);
		GClass0_0.GClass0_1 = this;
		string_0 = "*";
		return GClass0_0;
	}

	public GClass0 method_1(double double_1)
	{
		GClass0_0 = new GClass0(double_1);
		GClass0_0.GClass0_1 = this;
		string_0 = "/";
		return GClass0_0;
	}

	public GClass0 method_2(double double_1)
	{
		GClass0_0 = new GClass0(double_1);
		GClass0_0.GClass0_1 = this;
		string_0 = "+";
		return GClass0_0;
	}

	public GClass0 method_3(double double_1)
	{
		GClass0_0 = new GClass0(double_1);
		GClass0_0.GClass0_1 = this;
		string_0 = "-";
		return GClass0_0;
	}

	public void method_4(GClass0 gclass0_2, string string_1 = "+-*/")
	{
		GClass0 gClass = null;
		while (gclass0_2 != null)
		{
			gClass = gclass0_2.GClass0_0;
			if (gClass != null)
			{
				gclass0_2.double_0 = method_6(gclass0_2.string_0, gclass0_2.double_0, gClass.double_0);
				gclass0_2.GClass0_0 = gClass.GClass0_0;
				gclass0_2.string_0 = gClass.string_0;
				continue;
			}
			if (gClass != null)
			{
				gclass0_2 = gClass;
				continue;
			}
			break;
		}
	}

	public double method_5()
	{
		method_4(this, "*/");
		method_4(this, "+-");
		return double_0;
	}

	private double method_6(string string_1, double double_1, double double_2)
	{
		return string_1 switch
		{
			"/" => double_1 / double_2, 
			"*" => double_1 * double_2, 
			"-" => double_1 - double_2, 
			"+" => double_1 + double_2, 
			_ => 0.0, 
		};
	}
}
