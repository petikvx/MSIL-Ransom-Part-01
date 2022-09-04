using System;

namespace ns4;

public class GEventArgs3 : EventArgs
{
	internal GEnum1 genum1_0;

	internal bool bool_0;

	internal string string_0 = string.Empty;

	internal string string_1 = string.Empty;

	public GEnum1 Step => genum1_0;

	public bool Failed => bool_0;

	public string ErrorMessage => string_0;

	public string ReportID => string_1;

	internal GEventArgs3(GEnum1 genum1_1, string string_2)
		: this(genum1_1, string_2, string.Empty)
	{
	}

	internal GEventArgs3(GEnum1 genum1_1, string string_2, string string_3)
	{
		GEnum1 gEnum = (genum1_0 = genum1_1);
		bool flag = (bool_0 = string_2 != null && string_2.Length > 0);
		string text = (string_0 = string_2);
		string text2 = (string_1 = string_3);
	}

	static GEventArgs3()
	{
		GClass11.smethod_0();
	}
}
