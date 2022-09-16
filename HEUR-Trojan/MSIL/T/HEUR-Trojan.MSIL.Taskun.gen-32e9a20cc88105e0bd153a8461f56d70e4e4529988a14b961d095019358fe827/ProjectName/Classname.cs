using System;
using System.Text;
using GreenPixelsCalculator.Utils;

namespace ProjectName;

public class Classname : Settings
{
	private const string keyItem1 = "Item1";

	private const string keyItem2 = "Item2";

	private const string keyItem3 = "Item3";

	public string Item1
	{
		get
		{
			return base["Item1"];
		}
		set
		{
			base["Item1"] = value;
		}
	}

	public double? Item2
	{
		get
		{
			return (base["Item2"] == null) ? null : new double?(double.Parse(base["Item2"]));
		}
		set
		{
			double? num = value;
			base["Item2"] = num.ToString() ?? "";
		}
	}

	public bool? Item3
	{
		get
		{
			return (base["Item3"] == null) ? null : new bool?(bool.Parse(base["Item3"]));
		}
		set
		{
			bool? flag = value;
			base["Item3"] = flag.ToString() ?? "";
		}
	}

	public Classname(string path)
		: base(path, Encoding.ASCII)
	{
	}

	public override void LoadDefaults(bool overwrite)
	{
		if (!overwrite)
		{
			Item1 = Item1 ?? "Value1";
			Item2 = Item2 ?? Math.PI;
			Item3 = Item3.GetValueOrDefault();
		}
		else
		{
			Item1 = "Value1";
			Item2 = Math.PI;
			Item3 = false;
		}
	}
}
